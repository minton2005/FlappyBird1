using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class PipeIncreaseScore : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            ScoreScript.instance.UpdateScore();
        }
    }
}
