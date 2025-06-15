using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI enemiesLeftText;
    [SerializeField] private GameObject youWinText;

    private int enemiesLeft = 0;

    private const string ENEMIES_LEFT_STRING = "Enemies Left: ";

    public void AdjustEnemiesLeft(int amount)
    {
        enemiesLeft += amount;
        enemiesLeftText.text = ENEMIES_LEFT_STRING + enemiesLeft;

        if (enemiesLeft <= 0)
            youWinText.SetActive(true);
    }

    public void RestartLevelButton()
    {
        int currentScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentScene);
    }

    public void QuitButton() => Application.Quit();
}