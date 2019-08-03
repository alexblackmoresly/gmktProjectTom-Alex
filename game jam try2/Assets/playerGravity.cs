using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerGravity : MonoBehaviour
{
    private GameObject[] massiveObjects;
    private Rigidbody2D rb2d;
    private Vector2 resultantForce, tempForce, direction;
    private float objMass, gravityConstant;
    public bool isGravityEnabled;
    public bool playerNotDestroyed = true;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        massiveObjects = GameObject.FindGameObjectsWithTag("massive");
        gravityConstant = 1/rb2d.mass;
    }

    // Update is called once per frame
    void Update()
    {
        massiveObjects = GameObject.FindGameObjectsWithTag("massive");
        if (isGravityEnabled == true)
        {
            addGravityForce();
        }
        if (rb2d.mass < 0.001)
        {
            gravityConstant = 0;
        }
    }
    
    void addGravityForce()
    {
        resultantForce = resultantForce * 0;
        foreach (GameObject obj in massiveObjects)
        {
            if (obj.transform == transform)
            {
                continue;
            }
            objMass = obj.GetComponent<Rigidbody2D>().mass;
            Vector2 playerPosition = new Vector2(transform.position.x, transform.position.y);
            Vector2 objPosition = new Vector2(obj.transform.position.x, obj.transform.position.y);
            direction = objPosition - playerPosition;
            tempForce = direction  * Mathf.Pow(direction.magnitude, -2f) * objMass * gravityConstant;
            resultantForce = resultantForce + tempForce;


        }
        rb2d.AddForce(resultantForce);
    }
}
