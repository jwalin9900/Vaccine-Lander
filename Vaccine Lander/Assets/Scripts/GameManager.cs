using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public Text bottomText;
     
    public IEnumerator GameOverWin(){
        bottomText.text="Mission Complete";
        yield return new WaitForSeconds(20.0f);
        SceneManager.LoadScene("Level2");
    }
    public IEnumerator GameOverLose(){
        bottomText.text="Mission Failed";
        yield return new WaitForSeconds(20.0f);
        SceneManager.LoadScene("Level1");
    }
}
