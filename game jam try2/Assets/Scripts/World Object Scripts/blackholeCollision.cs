using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class blackholeCollision : MonoBehaviour
{
    private GameObject[] massiveObjects;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        massiveObjects = GameObject.FindGameObjectsWithTag("massive");
    }
    private void OnTriggerEnter2D(Collider2D other)   //resets scene when play collides with it
    {
        if (other.tag == "Player")
        {
            string currentSceneName = SceneManager.GetActiveScene().name;
            SceneManager.LoadScene(currentSceneName);
        }
        if (other.tag == "massive")
        {
            foreach (GameObject obj in massiveObjects)
            {
                if (obj.GetComponent<Collider2D>() == other)
                {
                    Destroy(obj);
                }
            }
                
            
        }
    }
}


