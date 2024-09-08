using UnityEngine;

public class LevelManager : MonoBehaviour
{
    private string currentDifficulty;
/*    private int easyTargetScore = 100;
    private int mediumTargetScore = 50;
    private int difficultTargetScore = 30;*/
    private int easyWordTarget = 2;
    private int mediumWordTarget = 3;
    private int difficultWordTarget = 4;

    public GameManager manager;

    void Start()
    {
        SetDifficulty("Easy");  // Set default difficulty to Easy
    }

    public void SetDifficulty(string difficulty)
    {
        currentDifficulty = difficulty;
        SetTarget();
    }

/*    public void AddPointsToPlayer(int playerNumber, int points)
    {
        if (playerNumber == 1)
        {
            player1Score += points;
            CheckForWin(player1Score);
        }
        else if (playerNumber == 2)
        {
            player2Score += points;
            CheckForWin(player2Score);
        }
    }

    private void CheckForWin(int playerScore)
    {
        int targetScore = GetTargetScore();
        if (playerScore >= targetScore)
        {
            Debug.Log("Player wins!");
            // Implement the win logic here (e.g., end the game, show win screen, etc.)
        }
    }*/

    private void SetTarget()
    {
        //manager.P1_TargetScore.text = manager.P2_TargetScore.text = GetTargetScore().ToString();
        manager.WordTarget = GetWordTarget();
    }
/*    private int GetTargetScore()
    {
        switch (currentDifficulty)
        {
            case "Medium":
                return mediumTargetScore;
            case "Hard":
                return difficultTargetScore;
            default:
                return easyTargetScore;
        }
    }*/
    private int GetWordTarget()
    {
        switch (currentDifficulty)
        {
            case "Medium":
                return mediumWordTarget;
            case "Hard":
                return difficultWordTarget;
            default:
                return easyWordTarget;
        }
    }
}
