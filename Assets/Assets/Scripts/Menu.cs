using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {


    public Canvas MainCanvas;
    public Canvas MultiCanvas;

    private void Awake()
    {
        MultiCanvas.enabled = false;
    }

    public void MultiOn()
    {
        MultiCanvas.enabled = true;
        MainCanvas.enabled = false;
    }

    public void ReturnOn()
    {
        MultiCanvas.enabled = false;
        MainCanvas.enabled = true;
    }

    public void LoadSoloOn()
    {
        SceneManager.LoadScene("GameSolo");
        
    }

    public void ConnectOn()
    {
        SceneManager.LoadScene("PUN");

    }

    public void CreatetOn()
    {
        SceneManager.LoadScene("Create");

    }
}
