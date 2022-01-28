using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChildMovement : MonoBehaviour
{
    Rigidbody rb;
    private bool ReadytoRun = false;
    public float Speed;
    public float xmin, xmax;
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = transform.position + new Vector3(0, 0, 1f * Time.deltaTime);
        if (ReadytoRun == true)
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

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "ChildSingle" || other.gameObject.tag == "Player" || other.gameObject.tag == "GroupChild")
        {
            ReadytoRun = true;
        }
    }
}
