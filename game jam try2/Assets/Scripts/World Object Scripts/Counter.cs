using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Counter : MonoBehaviour
{
    public int levelNumber;
    public int blockCounter, currentBlocks;
    public float timer;
    private GameObject[] blocks;
    public bool startTimer = false;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(transform.gameObject);
            
    }

    // Update is called once per frame
    void Update()
    {
        blocks = GameObject.FindGameObjectsWithTag("block");
        currentBlocks = blocks.Length;
        if (currentBlocks > blockCounter || blockCounter == 0)
        {
            blockCounter = currentBlocks;
        }
        if (startTimer == true)
        {
            timer += Time.deltaTime;
        }
        if (Input.GetButtonDown("Jump"))
        {

            foreach (GameObject block in blocks)
            {
                Destroy(block);
            }
            SceneManager.LoadScene(levelNumber);     
            Destroy(gameObject);
        }
    }
}
