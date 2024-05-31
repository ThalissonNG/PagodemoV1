using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void StartGame()
    {
        // Carrega a pr�xima cena no �ndice da build, que ser� a cena do jogo
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
