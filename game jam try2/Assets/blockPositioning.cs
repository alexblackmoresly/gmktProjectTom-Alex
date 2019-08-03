using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blockPositioning : MonoBehaviour
{
    private bool canMove;
    public Vector2 startMouseLocation, currentMouseLocation;
    private Vector2 direction;
    // Start is called before the first frame update
    void Start()
    {
        startMouseLocation = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        canMove = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (canMove == true)
        {
            moveBlock(startMouseLocation);
        }
    }
    void moveBlock(Vector2 startPos)
    {
        if (Input.GetMouseButton(0))
        {
            currentMouseLocation = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            direction = (currentMouseLocation - startMouseLocation).normalized;
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward);
            transform.rotation = rotation;
        }
        else
        {
            canMove = false;
        }
    
        
    }
}
