using System.Collections;
using System.Collections.Generic;
using UnityEngine; 
using UnityEngine.SceneManagement;

public class UIManager : Singleton <UIManager>
{
    public GameObject play;
    public GameObject StartPanel;
    public GameObject InGame;
    public GameObject LevelCompleted;
    public GameObject LevelFail;
 
    public void TapToPlay()
    {
        StartPanel.SetActive(false);
        InGame.SetActive(true);
        play.gameObject.GetComponent<Rigidbody>().useGravity = true;
    }
    public void Levelfail()
    {
        InGame.SetActive(false);
        LevelFail.SetActive(true);
    }
    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void LevelComp()
    {
        InGame.SetActive(false);
        LevelCompleted.SetActive(true);
        GameManager.Instance.scoreFailText.text = GameManager.Instance.score.ToString();
    }
}
