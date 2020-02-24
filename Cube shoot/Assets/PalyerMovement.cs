using UnityEngine;
using System.Collections;

public class PalyerMovement : MonoBehaviour
{

    public Rigidbody rb;
    public GameObject bulletPrefab;
    // public Camera playerCamera;

    // public float forwardForce = 2000f;
    public float sidewaysForce = 500f;
    

    // Update is called once per frame
    void FixedUpdate()
    {
        // rb.AddForce(0,0,forwardForce * Time.deltaTime);

        if (Input.GetMouseButtonDown(0))
        {
            GameObject bulletObject = Instantiate(bulletPrefab);
            // bulletObject.transform.position = playerCamera.transform.position + playerCamera.transform.forward;
            // bulletObject.transform.forward = playerCamera.transform.forward;
            bulletObject.transform.position = transform.position + transform.forward;
            bulletObject.transform.forward = transform.forward;
        }

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime,0,0);
        }
        
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime,0,0);
        }
        
        if (Input.GetKey("w"))
        {
            rb.AddForce(0,0,sidewaysForce * Time.deltaTime);
        }
        
        if (Input.GetKey("s"))
        {
            rb.AddForce(0,0,-sidewaysForce * Time.deltaTime);
        }
    }
}
