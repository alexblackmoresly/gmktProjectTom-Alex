using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class initalVel : MonoBehaviour
{
    private bool firstLoop = false;
    public float angle, speed;
    private Vector2 direction;
    private Rigidbody2D rb2d;
    // Start is called before the first frame update
    void Start()
    {
        //Time.timeScale = 0;
    }

        // Update is called once per frame
        void Update()
    {
        if (firstLoop == false)
        {
            Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward);
            transform.rotation = rotation;
            angle = angle * Mathf.Deg2Rad;
            Vector2 direction = new Vector2(Mathf.Cos(angle), Mathf.Sin(angle)).normalized;
            Rigidbody2D rb2d = GetComponent<Rigidbody2D>();
            rb2d.AddForce(direction * speed);
            firstLoop = true;
        }
        
    }
}
