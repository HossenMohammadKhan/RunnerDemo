using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMoveScript : MonoBehaviour
{
    Rigidbody rb;
    public float Speed;
    public float xmin, xmax;

    private void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }
    private void Update()
    {
        Vector3 playerpos = transform.position;
        if (playerpos.x < xmin)
        {
            playerpos.x = xmin;
        }
        if (playerpos.x > xmax)
        {
            playerpos.x = xmax;
        }
        transform.position = playerpos;
        rb.velocity = new Vector3(Input.GetAxis("Horizontal") * 5, 0, Speed);
    }
}
