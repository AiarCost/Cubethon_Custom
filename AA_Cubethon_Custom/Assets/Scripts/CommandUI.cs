using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CommandUI : MonoBehaviour
{
    public TextMeshProUGUI text;


    public void AddToText(string AddText)
    {
        text.text += AddText;
        text.text += "\n";
    }
}
