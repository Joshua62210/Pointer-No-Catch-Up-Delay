**Pointer No-Catch-Up-Delay (OpenTabletDriver Plugin)**

Plugin minimaliste pour OpenTabletDriver qui permet d'émettre chaque rapport du stylet immédiatement afin de réduire la latence au maximum.

**___**

**⚙️ Comment ça marche ?**

Windows il peut introduire un petit retard entre ton mouvement réel et le déplacement du pointeur à l’écran à cause :

Coalescence des mouvements : Windows peut fusionner des mouvements très rapprochés pour réduire le nombre d’événements livrés.
Files d’attente / cadence par frame : si l’application(Jeux vidéo) lit les entrées par IPS ou si la file d’événements est occupée, la livraison peut être légèrement décalée.
Rattrapage visuel : il arrive que le pointeur fasse de petits mouvements supplémentaires juste après, le temps que tout suive.

**✅ Ce que fait le plugin quand vous l’activée ?**

No Catch-Up : chaque rapport du stylet est émis immédiatement, sans attente d’éventuelles mises à jour tardives.
Zéro Coalescence des Mouvements : Pas de fusionnement ni n’avalement de rapports rapproché.
→ Résultat : la portion gérée par OpenTabletDriver n’ajoute plus de délai. Le décalage perceptible entre ton geste et le pointeur diminue fortement et la sensation de réactivité augmente nettement.

**___**

**📦 Installation**

