using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementDemoRunner : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody rb;
    public float Speed;
    public float xmin, xmax;
    Animator animator;
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        animator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
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

        if (Input.GetKey(KeyCode.RightArrow))
        {
            animator.SetInteger("Movement", 1);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            animator.SetInteger("Movement", -1);
        }
        else animator.SetInteger("Movement", 0);

    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "ChildSingle")
        {
            other.transform.parent = transform;
        }
    }
}
