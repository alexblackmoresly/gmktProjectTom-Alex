using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerGravity : MonoBehaviour
{
    private GameObject[] massiveObjects;
    private Rigidbody2D rb2d;
    private Vector2 resulantForce, tempForce, direction;
    private float objMass, gravityConstant;
    public bool isGravityEnabled;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        massiveObjects = GameObject.FindGameObjectsWithTag("massive");
        gravityConstant = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        if (isGravityEnabled == true)
        {
            addGravityForce();
        }
    }
    
    void addGravityForce()
    {
        resulantForce = resulantForce * 0;
        foreach (GameObject obj in massiveObjects)
        {
            objMass = obj.GetComponent<Rigidbody2D>().mass;
            Vector2 playerPosition = new Vector2(transform.position.x, transform.position.y);
            Vector2 objPosition = new Vector2(obj.transform.position.x, obj.transform.position.y);
            direction = objPosition - playerPosition;
            tempForce = direction  * Mathf.Pow(direction.magnitude, -2f) * objMass * gravityConstant;
            resulantForce = resulantForce + tempForce;


        }
        rb2d.AddForce(resulantForce);
    }
}
