using UnityEngine;
using UnityEngine.UI;

public class PointSystem : MonoBehaviour
{
    public int score = 0;
    public Text scoreText;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Point"))
        {
            score++;
            scoreText.text = "Score: " + score;
            Destroy(other.gameObject);
        }
    }
}
