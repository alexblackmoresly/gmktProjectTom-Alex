using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blockPositioning : MonoBehaviour
{
    private bool canMove;
    public Vector2 startMouseLocation, currentMouseLocation;
    private Vector2 direction;
    private AudioSource bounceNoise;

    private float size;
    // Start is called before the first frame update
    void Start()
    {
        bounceNoise = GetComponent<AudioSource>();
        startMouseLocation = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        canMove = true;
    }

    // Update is called once per frame
    void LateUpdate()
    {

        
        if (canMove == true)
        {
            moveBlock();
        }
    }
    void moveBlock()
    {
        if (Input.GetMouseButton(0))
        {
            currentMouseLocation = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            direction = (currentMouseLocation - startMouseLocation).normalized;
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward);
            transform.rotation = rotation;

            transform.position = (currentMouseLocation + startMouseLocation) / 2;
            transform.localScale = new Vector3((currentMouseLocation - startMouseLocation).magnitude * 0.15f, 1f, 1f);
        }
        else
        {
            canMove = false;
        }
    
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            //Debug.Log("yeet");
           // bounceNoise.Play(0);
            //Debug.Log("yeet");
        }
    }
}
