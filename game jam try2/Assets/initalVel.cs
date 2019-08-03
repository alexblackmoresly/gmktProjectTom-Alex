using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class initalVel : MonoBehaviour
{
    public float angle, speed;
    // Start is called before the first frame update
    void Start()
    {
        Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        transform.rotation = rotation;
        Rigidbody2D rb2d = GetComponent<Rigidbody2D>();
        angle = angle * Mathf.Deg2Rad;
        Vector2 direction = new Vector2(Mathf.Cos(angle), Mathf.Sin(angle)).normalized;
        rb2d.AddForce(direction * speed);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
