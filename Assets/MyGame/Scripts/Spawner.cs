using UnityEngine;

public class Spawner : MonoBehaviour
{
    [Header("Spawn Settings")]
    [SerializeField] private GameObject obstaclePrefab; // Das Hindernis-Prefab aus deinem Projektordner
    [SerializeField] private float startDelay = 1.0f;    // Verzögerung bis zum ersten Spawn
    [SerializeField] private float spawnInterval = 2.0f; // Zeit zwischen den Spawns

    [Header("Screen Bounds")]
    [SerializeField] private float minX = -8.0f;         // Linker Rand des Bildschirms
    [SerializeField] private float maxX = 8.0f;          // Rechter Rand des Bildschirms
    [SerializeField] private float spawnY = 6.0f;          // Obere Kante (außerhalb/am oberen Rand der Kamera)

    void Start()
    {
        // Startet die automatische Wiederholung der Spawn-Methode
        InvokeRepeating(nameof(SpawnObstacle), startDelay, spawnInterval);
    }

    void SpawnObstacle()
    {
        if (obstaclePrefab != null)
        {
            // Berechnet eine zufällige X-Position am oberen Bildschirmrand
            float randomX = Random.Range(minX, maxX);
            Vector3 spawnPosition = new Vector3(randomX, spawnY, 0f);

            // Instanziiert das Hindernis ohne Rotation
            Instantiate(obstaclePrefab, spawnPosition, Quaternion.identity);
        }
        else
        {
            Debug.LogWarning("Spawner: Kein 'obstaclePrefab' im Inspektor zugewiesen!");
        }
    }
}