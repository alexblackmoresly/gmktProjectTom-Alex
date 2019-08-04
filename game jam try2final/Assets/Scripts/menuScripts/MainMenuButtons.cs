using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuButtons : MonoBehaviour
{
    public int levelChosen;
    private GameObject[] blocks, counters;
    public void getLevelChosen(int i)
    {
        blocks = GameObject.FindGameObjectsWithTag("block");
        foreach (GameObject block in blocks)
        {
            Destroy(block);
        }
        counters = GameObject.FindGameObjectsWithTag("counter");
        foreach (GameObject counter in counters)
        {
            Destroy(counter);
        }

        SceneManager.LoadScene(i);
    }
    // Start is called before the first frame update
    public void PlayLevel1()
    {
        blocks = GameObject.FindGameObjectsWithTag("block");
        counters = GameObject.FindGameObjectsWithTag("counter");
        SceneManager.LoadScene(1);
        foreach (GameObject block in blocks)
        {
            Destroy(block);
        }
        foreach (GameObject counter in counters)
        {
            Destroy(counter);
        }
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
