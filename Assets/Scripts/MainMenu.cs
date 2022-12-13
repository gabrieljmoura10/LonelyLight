using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    [SerializeField] private string nameLevel;
    [SerializeField] private GameObject homeMenuPanel;

    public void Play(){
        SceneManager.LoadScene(nameLevel);
    }

    public void Exit(){
        Debug.Log("Sair do Jogo");
        Application.Quit();
    }
}
