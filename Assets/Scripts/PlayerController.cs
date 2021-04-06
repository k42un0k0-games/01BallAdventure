using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float horizontalInput;
    private float verticalInput;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * Time.deltaTime * 5 * verticalInput);
        transform.Rotate(Vector3.up, 20.0f * Time.deltaTime * horizontalInput);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            print("keydown space");
            rb.AddForce(1, 10.0f, 0, ForceMode.Impulse);
        }
    }
}
