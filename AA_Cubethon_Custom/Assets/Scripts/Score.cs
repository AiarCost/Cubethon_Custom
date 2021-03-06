using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    public Transform player;
    public Text text;

    public delegate void NextLevel();
    public static event NextLevel nextLevel;

    // Update is called once per frame
    void Update()
    {
       text.text  = player.position.z.ToString("0");

        if(player.position.z >= 300f)
        {
            nextLevel();
        }
    }
}
