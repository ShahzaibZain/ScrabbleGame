using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [Header("Panels")]
    public GameObject LevelSelectionPanel;
    public GameObject GameplayPanel;
    public GameObject P1PausePanel;
    public GameObject P2PausePanel;
    public GameObject GameOverPanel;
    public GameObject GameBoard;

    [Header("Scripts")]
    public LevelManager LevelManager;

    [Header("Texts")]
    public Text P1_Score;
    public Text P2_Score;
    public Text P1_TargetScore;
    public Text P2_TargetScore;
    public int WordTarget;


    // Start is called before the first frame update
    void Start()
    {
        P1_TargetScore.text = P2_TargetScore.text = 20.ToString();
        P1_Score.text = P2_Score.text = 0.ToString();
        LevelSelectionPanel.SetActive(true);
        GameplayPanel.SetActive(false);
        GameOverPanel.SetActive(false);
        GameBoard.SetActive(false);
        P1PausePanel.SetActive(false);
        P2PausePanel.SetActive(false);
    }

    public void Home()
    {

    }
}
