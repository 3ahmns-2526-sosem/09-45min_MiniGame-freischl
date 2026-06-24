# Avoid Game - 45-Minute Unity Mini Game Challenge

## Spielidee
**Avoid Game** ist ein minimalistischer Unity-Prototyp, bei dem es darum geht, herabfallenden Hindernissen so lange wie möglich auszuweichen. Der Spieler steuert eine Figur am unteren Bildschirmrand, während von oben kontinuierlich Hindernisse spawnen und nach unten fallen. Sobald ein Hindernis den Spieler berührt, endet das Spiel sofort und es erscheint die Rückmeldung **"Game Over"**.

## Steuerung
* **A / D** oder **Pfeiltaste Links / Pfeiltaste Rechts**: Spieler nach links und rechts bewegen.

## KI-Nutzung (Dokumentation)
Für die Erstellung dieses Prototyps wurde eine KI (z. B. ChatGPT) wie folgt unterstützend eingesetzt:
1. **Spieler-Bewegung:** Generierung eines einfachen, framerate-unabhängigen Bewegungsskripts mittels `Input.GetAxis("Horizontal")` und `Transform.Translate`.
2. **Spawner-Logik:** Unterstützung bei der Implementierung einer `InvokeRepeating`-Methode, die in regelmäßigen Abständen Hindernisse an zufälligen X-Positionen außerhalb der Kamera instanziiert.
3. **Kollision & UI:** Code-Schnipsel für die `OnTriggerEnter2D`-Erkennung und das Aktivieren des Game-Over-Textelements.

*Erklärung des Codes:* Der generierte Code wurde manuell geprüft. Die Bewegung nutzt `Time.deltaTime`, um ein Ruckeln zu verhindern (Framerate-Unabhängigkeit). Die Kollisionserkennung basiert auf Unity-Tags (`"Obstacle"`), um sicherzustellen, dass ausschließlich Hindernisse das Game-Over auslösen.

---

## Mindestanforderungen (Übersicht)

1. **Unity-Projekt startet ohne Compile Errors** – Sichergestellt vor dem finalen Push.
2. **Erkennbare Spielidee** – Ausweichen von herabfallenden Hindernissen.
3. **Mindestens eine Interaktion** – Spielerbewegung per Tastatur (A/D oder Pfeiltasten).
4. **Ein Ziel oder eine Win/Lose-Bedingung** – Lose-Bedingung durch Kollision mit einem Hindernis.
5. **Feedback für die Spieler:innen** – Sichtbarer "Game Over"-Text bei Berührung.
6. **Mindestens 3 GitHub Issues** – Dokumentiert und nachverfolgt im Repository.
7. **Mindestens 1 Commit** – Versionsverwaltung via Git aktiv genutzt.
8. **README mit Spielidee, Steuerung und KI-Nutzung** – Vollständig in diesem Dokument hinterlegt.
