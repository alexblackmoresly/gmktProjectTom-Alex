using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMove : MonoBehaviour
{
    //public movement mvmt;
    private float smallSize;
    private Vector2 initialLocation;
    private float initialScale;
    private float aspectRatio;
    private float fov;
    private float sens = 10f;
    public float fovMax = 90f;
    public float fovMin = 15f;
    private float camX;
    private float camY;

    // Start is called before the first frame update
    void Start()
    {
        initialLocation = transform.position;
        initialScale = Camera.main.orthographicSize;
        aspectRatio = (float)Screen.width / (float)Screen.height;
        camX = transform.position.x;
        camY = transform.position.y;
        fov = 10f;
    }

    // Update is called once per frame
    void Update()
    {
        /*if (mvmt.enableFiring == true) {
            transform.position = new Vector3(initialLocation.x, initialLocation.y, -10f);
            Camera.main.orthographicSize = initialScale;
        } else {
            transform.position = new Vector3(mvmt.transform.position.x, mvmt.transform.position.y, -10f);
            Camera.main.orthographicSize = smallSize;
        }*/

        /*if (Mathf.Abs(mvmt.transform.position.y - transform.position.y) > (Camera.main.orthographicSize - 1f)) {
            var posOrNeg = (mvmt.transform.position.y - transform.position.y) / Mathf.Abs(mvmt.transform.position.y - transform.position.y);
            transform.position = new Vector3(transform.position.x, mvmt.transform.position.y - ((posOrNeg * Camera.main.orthographicSize) - posOrNeg), -10f);
        }
        if (Mathf.Abs(mvmt.transform.position.x - transform.position.x) > ((Camera.main.orthographicSize * aspectRatio) - 1f)) {
            var posOrNegx = (mvmt.transform.position.x - transform.position.x) / Mathf.Abs(mvmt.transform.position.x - transform.position.x);
            transform.position = new Vector3(mvmt.transform.position.x - ((posOrNegx * aspectRatio * Camera.main.orthographicSize) - p), transform.position.x, -10f);
        }*/

        fov -= Input.GetAxis("Mouse ScrollWheel") * sens;
        fov = Mathf.Clamp(fov, fovMin, fovMax);
        Camera.main.orthographicSize = fov;

        if (Input.GetMouseButton(1)) {
            camX -= Input.GetAxis("Mouse X");
            camY -= Input.GetAxis("Mouse Y");
        }

        transform.position = new Vector3(camX, camY, -10f);
    }
}
