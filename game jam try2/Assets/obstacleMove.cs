using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacleMove : MonoBehaviour
{
    public float angle, distance, speed;
    public bool forward;
    private Vector2 direction, startPos, currentPos;
    private Rigidbody2D rb2d;
    // Start is called before the first frame update
    void Start()
    {
        Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        angle = angle * Mathf.Deg2Rad;
        startPos = new Vector2(transform.position.x, transform.position.y);
        rb2d = GetComponent<Rigidbody2D>();
        direction = new Vector2(Mathf.Cos(angle), Mathf.Sin(angle)).normalized;
        transform.rotation = rotation;
        
    }

    // Update is called once per frame
    void Update()
    {
        currentPos = new Vector2(transform.position.x, transform.position.y);
        if ((currentPos - startPos).magnitude >= distance)
        {
            if (forward == true)
            {
                forward = false;
            }
            else
            {
                forward = true;
            }
        }
        if (forward == true)
        {
            rb2d.velocity = direction * speed;
        }
        if (forward == false)
        {
            rb2d.velocity = direction * speed * -1;
        }
    }
}
