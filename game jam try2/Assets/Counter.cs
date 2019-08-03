using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Counter : MonoBehaviour
{
    public int levelNumber;
    public int blockCounter;
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
        blockCounter = blocks.Length;
        if (startTimer == true)
        {
            timer += Time.deltaTime;
        }
        if (Input.GetButtonDown("Jump"))
        {
            SceneManager.LoadScene(levelNumber);
            Destroy(gameObject);
        }
    }
}
