using UnityEngine;

public class CloudSpawner : MonoBehaviour
{
    public GameObject cloudPrefab;
    public float spawnRate = 3f;
    public float fixedY = -0.042f;

    private float timer = 0f;

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= spawnRate)
        {
            Vector3 spawnPos = new Vector3(transform.position.x, fixedY, 0);
            Instantiate(cloudPrefab, spawnPos, Quaternion.identity);
            timer = 0f;

             Destroy(cloudPrefab, 10f);
        }
    }
}
