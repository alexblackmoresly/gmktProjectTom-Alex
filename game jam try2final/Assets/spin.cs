using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spin : MonoBehaviour
{
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.rotation = Quaternion.AngleAxis(speed * Time.deltaTime, Vector3.forward);
        transform.Rotate(new Vector3(0f, 0f, speed * Time.deltaTime));
    }
}
