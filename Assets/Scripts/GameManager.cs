using UnityEngine;

public class GameManager : MonoBehaviour
{
   public static GameManager Instance { get; private set; }

    public int score;
    public int currentWave;
    public int playerHealth;
    public bool isGameOver;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
    }
    public void AddScore(int amount)
    {
        score += amount;
    }

    public void WinGame()
    {
        if (isGameOver) return;
        isGameOver = true;
        Debug.Log("YOU WIN!");
    }
    public void GameOver()
    {
        if (isGameOver) return;
        isGameOver = true;
        Debug.Log("GAME OVER!");
    }
    public void TakeDamage(int damage)
    {
        playerHealth = Mathf.Max(0, playerHealth - damage);
        if (playerHealth == 0)
        {
            isGameOver = true;
        }
    }
}
