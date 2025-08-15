**Pointer No-Catch-Up-Delay (OpenTabletDriver Plugin)**

Plugin that allows each pen report to be sent immediately in order to reduce latency as much as possible.

___________________________________________________________________________________________________________________________________________

**⚙️ How does it work ?**

Windows may introduce a slight delay between your actual movement and the movement of the pointer on the screen due to:

Movement coalescing: Windows may merge movements that are very close together to reduce the number of events delivered.

Queues/frame rate: if the application (video games) reads inputs per IPS or if the event queue is busy, delivery may be slightly delayed.

Visual catch-up: sometimes the pointer makes small additional movements just after, while everything catches up.

**✅ What the plugin does when you activate it ?**

No Catch-Up: each pen report is sent immediately, without waiting for any late updates.

Zero Movement Coalescence: No merging or swallowing of close reports.

→ Result: the portion managed by OpenTabletDriver no longer adds any delay. The noticeable lag between your gesture and the pointer is greatly reduced, and the feeling of responsiveness is significantly increased.

___________________________________________________________________________________________________________________________________________

**📦 Installation**

