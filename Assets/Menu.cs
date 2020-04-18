using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void PlayGame() {
        SceneManager.LoadScene("MainScene");
    }

    public void GoToRules() {
        SceneManager.LoadScene("Rules");
    }

    public void GoToMainMenu() {
        SceneManager.LoadScene("MenuScene");

    }
}