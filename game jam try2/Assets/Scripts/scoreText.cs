using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scoreText : MonoBehaviour
{
    private GameObject[] theCounter;
    private float timeSpent;
    private int blocksUsed, levelNumber;
    // Start is called before the first frame update
    void Start()
    {
        theCounter = GameObject.FindGameObjectsWithTag("counter");
        foreach (GameObject counter in theCounter)
        {
            timeSpent = counter.GetComponent<Counter>().timer;
            blocksUsed = counter.GetComponent<Counter>().blockCounter;
            levelNumber = counter.GetComponent<Counter>().levelNumber;
            Destroy(counter);
        }
        GetComponent<UnityEngine.UI.Text>().text = "Blocks Used : " + blocksUsed + "\n Time Taken : " + timeSpent;
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void retryLevel()
    {
        SceneManager.LoadScene(levelNumber);
    }
    public void nextLevel()
    {
        SceneManager.LoadScene(levelNumber + 1);
    }
    public void levelSelect()
    {
        SceneManager.LoadScene(1);
    }
}
