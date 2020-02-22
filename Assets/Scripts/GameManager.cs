using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class GameManager : MonoBehaviour
{
    private float slowFactor = 10f; // 1 second -> 10 units (10 seconds)

    private IEnumerator RestartLevel()
    {
        Time.timeScale = 1f / slowFactor;
        Time.fixedDeltaTime /= slowFactor;

        yield return new WaitForSeconds(1f / slowFactor); /// wait 1 second of real time.

        Time.timeScale = 1f;
        Time.fixedDeltaTime *= slowFactor;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void EndGame()
    {
        StartCoroutine(RestartLevel());
    }
}
