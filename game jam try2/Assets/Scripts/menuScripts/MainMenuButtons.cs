using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuButtons : MonoBehaviour
{
    public int levelChosen;
    public void getLevelChosen(int i)
    {
        SceneManager.LoadScene(i);
    }
    // Start is called before the first frame update
    public void PlayLevel1()
    {
        SceneManager.LoadScene(1);
    }
    

    public void QuitGame()
    {
        Application.Quit();
    }
    public void loadMainMenu()
    {
        SceneManager.LoadScene(0);
    }
    void Start()
    {
        
        
    }
    
    // Update is called once per frame
    void Update()
    {

    }
}
