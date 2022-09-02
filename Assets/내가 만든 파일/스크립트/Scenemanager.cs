using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenemanager : MonoBehaviour
{
    void Start() 
    {
        
    }

    void Update() 
    {
        
    }

    public void Main_1()
    {
        SceneManager.LoadScene("Main");
    }

    public void Random()
    {
        SceneManager.LoadScene("Random");
    }

    public void Team()
    {
        SceneManager.LoadScene("Team");
    }

    public void Chatting()
    {
        SceneManager.LoadScene("Chatting");
    }
}
