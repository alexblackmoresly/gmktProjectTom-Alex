using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objDestruction : MonoBehaviour
{
    public GameObject fragment;
    public Sprite emptySprite;
    public float destructThreshold;
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
        if ((other.GetComponent<Rigidbody2D>().mass * Mathf.Pow(other.GetComponent<Rigidbody2D>().velocity.magnitude, 2f)) > destructThreshold)
        {
            
            for (float i = 0; i < GetComponent<Rigidbody2D>().mass; i += 0.6f)
            {
                Instantiate(fragment, transform.position, Quaternion.identity);
            }
            
            GetComponent<Rigidbody2D>().mass = 0;
            GetComponent<SpriteRenderer>().sprite = emptySprite;
            GetComponent<playerGravity>().playerNotDestroyed = false;
            Destroy(gameObject);
            //Debug.Log("wow");
        }
    }
}
