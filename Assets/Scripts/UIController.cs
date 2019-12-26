using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public Button replayBtn;
    public Transform gamePanel;
    public AudioSource hit;

    void Start()
    {
        replayBtn.onClick.AddListener(Replay);
    }
    private void Replay()
    {
        Time.timeScale = 1;
       // mainPanel.gameObject.SetActive(true);
        //GameController.gameController.SetGameState(true);
        int sahne = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(sahne);
    }
 
    public void GameOver()
    {
      //  mainPanel.gameObject.SetActive(false);
        //GameController.gameController.SetGameState(false);
        Time.timeScale = 0;
        gamePanel.gameObject.SetActive(true);
    }

    public void hitSound()
    {
        hit.Play();
    }
}
