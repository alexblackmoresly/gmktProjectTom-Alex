using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fragmentMove : MonoBehaviour
{
    private float angle, speed;
    public float maxspeed, minspeed;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector2(transform.position.x + Random.Range(-2f, 2f), transform.position.y + Random.Range(-2f, 2f));
        angle = Random.Range(0f, 306f);
        Vector2 direction = new Vector2(Mathf.Cos(angle), Mathf.Sin(angle)).normalized;
        angle = angle * Mathf.Deg2Rad;
        Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        transform.rotation = rotation;
        speed = Random.Range(minspeed, maxspeed);
        GetComponent<Rigidbody2D>().AddForce(direction * speed);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
