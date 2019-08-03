using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activate : MonoBehaviour
{
    public bool triggered = false;
    public bool move = false;
    public Vector2 moveTo;
    public float time;
    public bool speedMod = false;
    public float speed;
    public bool applyForce;
    public Vector2 dir;
    public float mag;
    public bool changeMass;
    public float newMass;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (triggered == true) {
            if (move == true) {
                transform.position = Vector2.Lerp(transform.position, moveTo, (1/time) * Time.deltaTime);
            }
            if (speedMod == true) {
                transform.GetComponent<Rigidbody2D>().velocity *= speed;
                speedMod = false;
            }
            if (applyForce == true) {
                transform.GetComponent<Rigidbody2D>().AddForce(mag * dir.normalized);
                applyForce = false;
            }
            if (changeMass == true) {
                transform.GetComponent<Rigidbody2D>().mass = newMass;
                changeMass = false;
            }
        }
    }
}
