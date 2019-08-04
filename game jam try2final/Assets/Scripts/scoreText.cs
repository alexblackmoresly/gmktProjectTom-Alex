using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scoreText : MonoBehaviour
{
    private GameObject[] theCounter;
    private float timeSpent;
    private int blocksUsed, levelNumber;

    private int blockRequirement;
    private float timeRequirement;
    private float stars = 1;
    public GameObject star2;
    public GameObject star3;
    // Start is called before the first frame update
    void Start()
    {
        theCounter = GameObject.FindGameObjectsWithTag("counter");
        foreach (GameObject counter in theCounter)
        {
            timeSpent = counter.GetComponent<Counter>().timer;
            blocksUsed = counter.GetComponent<Counter>().blockCounter;
            levelNumber = counter.GetComponent<Counter>().levelNumber;
            blockRequirement = counter.GetComponent<Counter>().blockNo;
            timeRequirement = counter.GetComponent<Counter>().timeRequirement;

            if (timeSpent <= timeRequirement) {
                stars += 1;
            }
            if (blocksUsed <= blockRequirement) {
                stars += 1;
            }
            Destroy(counter);
        }
        GetComponent<UnityEngine.UI.Text>().text = "Blocks Used : " + blocksUsed + "\n Time Taken : " + timeSpent;
        
        if (stars == 2) {
            star2.SetActive(true);
        }
        if (stars == 3) {
            star2.SetActive(true);
            star3.SetActive(true);
        }
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
