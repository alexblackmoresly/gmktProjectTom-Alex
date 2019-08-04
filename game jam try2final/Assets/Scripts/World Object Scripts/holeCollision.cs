using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class holeCollision : MonoBehaviour
{
    private GameObject[] blocks;
    
    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
           

            
            blocks = GameObject.FindGameObjectsWithTag("block");
            foreach (GameObject block in blocks)
            {
                Destroy(block);
            }
            SceneManager.LoadScene(3);
        }
    }
}