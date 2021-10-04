using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public float restartDelay = 1f;
    bool gameHasEnded = false;

    public GameObject competeLevelUI;

    bool instantReplay = false;
    public GameObject player;
    float replayStartTime;
    public GameObject ReplayText;

    private void OnEnable()
    {
        Score.nextLevel += CompleteLevel;
    }
    private void Start()
    {
        ReplayText.SetActive(false);
        if (CommandLog.commands.Count > 0)
        {
            ReplayText.SetActive(true);
            instantReplay = true;
            replayStartTime = Time.timeSinceLevelLoad;
        }
    }

    private void Update()
    {
        if (instantReplay)
            RunInstantReplay();
    }
    public void GameOver()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Invoke("Restart", restartDelay);
        }

    }


    void Restart()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }


    public void CompleteLevel()
    {
        Score.nextLevel -= CompleteLevel;
        competeLevelUI.SetActive(true);
    }

    void RunInstantReplay()
    {

        if (CommandLog.commands.Count == 0)
        {
            return;
        }



        Command command = CommandLog.commands.Peek();

        if(Time.timeSinceLevelLoad >= command.timestamp)
        {
            command = CommandLog.commands.Dequeue();
            command._player = player.GetComponent<Rigidbody>();
            Invoker invoker = new Invoker();
            invoker.DisableLog = true;
            invoker.SetCommand(command);
            invoker.ExecuteCommand();
        }
    }
}
