using UnityEngine;

public class CloudMovement : MonoBehaviour
{
    public float speed = 0.4f;

    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;

        if (transform.position.x < -10f) // นอกจอ
        {
            Destroy(gameObject);
        }
    }
}
