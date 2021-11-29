using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : Singleton <GameManager>
{
    public int score;
    public Text scoreText;
    public Text scoreFailText;
 

    public void GameScore(int ringScore)
    {
        score += ringScore;
        scoreText.text = score.ToString();
        
    }

    
}
