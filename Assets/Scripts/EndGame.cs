using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class EndGame : MonoBehaviour
{
    [SerializeField] private string nameLevel;
    [SerializeField] private GameObject endGamePanel;
    public void BackGame(){
        SceneManager.LoadScene(nameLevel);
    }

    public void Exit(){
        Debug.Log("Sair do Jogo");
        Application.Quit();
    }
}
