using UnityEngine;

public class PipeScript : MonoBehaviour
{
    [SerializeField] private float _speed = 0.40f;

    private void Update()
    {
        float currentSpeed = _speed + ScoreScript.instance.GetSpeedBonus();
        transform.position += Vector3.left * currentSpeed * Time.deltaTime;
    }
}
