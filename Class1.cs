using OpenTabletDriver.Plugin;
using OpenTabletDriver.Plugin.Attributes;
using OpenTabletDriver.Plugin.Output;
using OpenTabletDriver.Plugin.Tablet;
using System;

namespace Pointer_No_Catch_Up_Delay
{
    [PluginName("Pointer No-Catch-Up-Delay")]
    public sealed class NoCatchUpDelayPlugin : IPositionedPipelineElement<IDeviceReport>
    {
        private bool _noCatchUpDelay;

        [BooleanProperty("Enable/Disable", "Sends each pointer report immediately without waiting.")]
        [DefaultPropertyValue(false)]
        public bool NoCatchUpDelay
        {
            get => _noCatchUpDelay;
            set
            {
                _noCatchUpDelay = value;
                if (value)
                {
                    _coalescenceEnabledInternal = true;
                    _coalescenceWindowUsInternal = 0;
                }
                else
                {
                    _coalescenceEnabledInternal = false;
                }
            }
        }

        private bool _coalescenceEnabledInternal = false;
        private int _coalescenceWindowUsInternal = 0;

        public event Action<IDeviceReport>? Emit;
        public PipelinePosition Position => PipelinePosition.PostTransform;

        public void Consume(IDeviceReport value)
        {
            if (value is not ITabletReport report || !_noCatchUpDelay)
            {
                Emit?.Invoke(value);
                return;
            }

            if (_coalescenceEnabledInternal && _coalescenceWindowUsInternal == 0)
            {
                Emit?.Invoke(report);
                return;
            }

            Emit?.Invoke(report);
        }
    }
}