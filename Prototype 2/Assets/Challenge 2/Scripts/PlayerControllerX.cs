using UnityEngine;
using System.Collections;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float spawnCooldown = 1f; // Time in seconds between spawns

    private bool canSpawn = true;

    void Update()
    {
        // Check if the player presses the spacebar
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Check if the cooldown has expired
            if (canSpawn)
            {
                SpawnDog();
                StartCoroutine(StartCooldown());
            }
        }
    }

    private void SpawnDog()
    {
        // Spawn a new dog at the current position
        Instantiate(dogPrefab, transform.position, transform.rotation);
    }

    private IEnumerator StartCooldown()
    {
        canSpawn = false;
        yield return new WaitForSeconds(spawnCooldown);
        canSpawn = true;
    }
}
