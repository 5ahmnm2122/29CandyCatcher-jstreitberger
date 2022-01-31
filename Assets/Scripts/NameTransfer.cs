using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NameTransfer : MonoBehaviour
{
    public static string playerNameString;

    public Text playerNameText;

   
    void Start()
    {
        playerNameText.text = playerNameString;
    }
}
