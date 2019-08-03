using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tripWire : MonoBehaviour
{
    public GameObject[] targets;
    public bool instantiate;
    public GameObject insObject;
    public Vector2 insPos;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D col) {
        if (col.CompareTag("Player")) {
            for (int i = 0; i < targets.Length; i++) {
                targets[i].GetComponent<activate>().triggered = true;
            }
            if (instantiate == true) {
                Instantiate(insObject, insPos, Quaternion.identity);
            }
        }
    }
}
