using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Bewegungseinstellungen")]
    [Tooltip("Geschwindigkeit des Spielers. Kann im Unity-Inspector angepasst werden.")]
    public float moveSpeed = 8f;

    void Update()
    {
        // 1. Eingabe abfragen (A/D oder Pfeiltasten links/rechts)
        // Liefert einen Wert zwischen -1 (links) und 1 (rechts)
        float moveInput = Input.GetAxis("Horizontal");

        // 2. Bewegung berechnen und auf das Objekt anwenden
        // Vector3.right ist (1, 0, 0). Multipliziert mit moveInput ergibt das die Richtung.
        // moveSpeed bestimmt das Tempo.
        // Time.deltaTime sorgt dafür, dass die Bewegung pro Sekunde statt pro Frame berechnet wird.
        transform.Translate(Vector3.right * moveInput * moveSpeed * Time.deltaTime);
    }
}