using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void StartGame()
    {
        // Carrega a próxima cena no índice da build, que será a cena do jogo
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
