using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NameController : MonoBehaviour
{
    public InputField playerName;

    public void Star()
    {
        SceneManager.LoadScene("MainScene");
        NameTransfer.playerNameString = playerName.text;
    }
    
  
}
