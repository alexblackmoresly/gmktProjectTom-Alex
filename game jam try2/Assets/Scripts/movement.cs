using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    private GameObject[] theCounter;
    private Vector2 mouseLocation;
    public LineRenderer lr;
    public Rigidbody2D rb;
    public float maxForce;
    public float maxDistance;
    private Vector2 direction;
    private float power;
    private bool down = false;
    private bool enableFiring = true;
    public GameObject block;

    // Start is called before the first frame update
    void Start()
    {
        theCounter = GameObject.FindGameObjectsWithTag("counter");
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


        if (Input.GetMouseButtonDown(0)) {
            RaycastHit2D hit = Physics2D.Raycast(mouseLocation, Vector2.zero);

            if (hit.collider != null && hit.collider.CompareTag("Player") && enableFiring == true){
                lr.enabled = true;
                down = true;
            } else if (((mouseLocation - (Vector2)transform.position).magnitude > 2f) || enableFiring == false){
                Instantiate(block, mouseLocation, Quaternion.identity);
            }
        }
        if (Input.GetMouseButtonUp(0) && down == true) {
            fire();
            lr.enabled = false;
            down = false;
        }
    }

    public void fire()
    {
        rb.AddForce(direction * power);
        enableFiring = false;
        GetComponent<playerGravity>().isGravityEnabled = true;
        foreach (GameObject counter in theCounter)
        {
            counter.GetComponent<Counter>().startTimer = true;
        }
    }
}
