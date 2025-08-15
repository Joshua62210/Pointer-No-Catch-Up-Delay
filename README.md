**Pointer No-Catch-Up-Delay (OpenTabletDriver Plugin)**

Plugin that allows each pen report to be sent immediately in order to reduce latency as much as possible.

___________________________________________________________________________________________________________________________________________

**⚙️ How does it work ?**

Windows peut introduire un petit retard entre ton mouvement réel et le déplacement du pointeur à l’écran à cause :

Coalescence des mouvements : Windows peut fusionner des mouvements très rapprochés pour réduire le nombre d’événements livrés.

Files d’attente / cadence par frame : si l’application(Jeux vidéo) lit les entrées par IPS ou si la file d’événements est occupée, la livraison peut être légèrement décalée.

Rattrapage visuel : il arrive que le pointeur fasse de petits mouvements supplémentaires juste après, le temps que tout suive.

**✅ What the plugin does when you activate it ?**

No Catch-Up: each pen report is sent immediately, without waiting for any late updates.

Zero Movement Coalescence: No merging or swallowing of close reports.

→ Result: the portion managed by OpenTabletDriver no longer adds any delay. The noticeable lag between your gesture and the pointer is greatly reduced, and the feeling of responsiveness is significantly increased.

___________________________________________________________________________________________________________________________________________

**📦 Installation**

