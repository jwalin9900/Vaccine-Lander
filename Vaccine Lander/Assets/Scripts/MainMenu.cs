using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    public void StartGame_OnClick(){
        SceneManager.LoadScene("Level1");

    }
    public void EndGame_OnClick(){
        Application.Quit();
    }
}
