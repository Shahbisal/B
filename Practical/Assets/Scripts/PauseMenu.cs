using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public void PauseGame()
    {
        Time.timeScale = 0f; // freeze game
    }

    public void ResumeGame()
    {
        Time.timeScale = 1f; // normal speed
    }
}
