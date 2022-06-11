using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
   public void PlayGame()
    {
        SceneManager.LoadScene("Gameplay");
    }
    public void OpenAuthor()
    {
        Debug.Log("Created By Rabbii Akraman-149251970101-69");
    }

}
