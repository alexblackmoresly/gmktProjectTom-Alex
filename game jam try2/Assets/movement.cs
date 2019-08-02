using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    private Vector2 mouseLocation;
    public LineRenderer lr;
    public Rigidbody2D rb;
    public float maxForce;
    public float maxDistance;
    private Vector2 direction;
    private float power;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        lr = GetComponent<LineRenderer>();
        lr.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        mouseLocation = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        lr.SetPosition(0, transform.position);
        lr.SetPosition(1, mouseLocation);

        direction = mouseLocation - (Vector2)transform.position;
        power = direction.magnitude / maxDistance;
        power *= maxForce;
        direction = direction.normalized;

        if (Input.GetMouseButton(0)) {
            lr.enabled = true;
        } else {
            lr.enabled = false;
        }

        if (Input.GetMouseButtonUp(0)) {
            fire();
        }
    }

    public void fire() {
        rb.AddForce(direction * power);
    }
}
