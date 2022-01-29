using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChildMovement : MonoBehaviour
{
    Rigidbody rb;
    private bool ReadytoRun = false;
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
        //transform.position = transform.position + new Vector3(0, 0, 1f * Time.deltaTime);
        if (ReadytoRun == true)
        {
            FindClosestEnemy();
            animator.SetInteger("Movement", 0);
            if (Input.GetKey(KeyCode.RightArrow))
            {
                animator.SetInteger("Movement", 1);
            }
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                animator.SetInteger("Movement", -1);
            }
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

    [SerializeField] private GameObject levelcomplete;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "EndCollider")
        {
            levelcomplete.SetActive(true);
            Time.timeScale = 0f;
        }
    }

    private Transform player; public bool isAttacking = false; private bool a, b, c, d;
    public GameObject[] Enemies;
    public void FindClosestEnemy()
    {


        //     float distancetoclosestEnemy = Mathf.Infinity;
        //     GameObject closestEnemy = null, middleEnemy = null, farenemy = null, veryfarenemy = null;

        //     foreach (GameObject currentenemy in Enemies)
        //     {
        //         if (currentenemy != null)
        //         {
        //             float distancetoEnemy = Vector3.Distance(currentenemy.transform.position, this.transform.position);
        //             if (distancetoEnemy < 20f)
        //             {
        //                 if (distancetoEnemy < distancetoclosestEnemy)
        //                 {
        //                     distancetoclosestEnemy = distancetoEnemy;
        //                     closestEnemy = currentenemy;
        //                     a = true;
        //                 }
        //                 if (distancetoEnemy < distancetoclosestEnemy && a == true && b == false && closestEnemy != currentenemy)
        //                 {
        //                     middleEnemy = currentenemy;
        //                     b = true;
        //                 }

        //             }
        //         }
        //     }
        //     if (closestEnemy != null && a == true)
        //     {
        //         transform.position = Vector3.MoveTowards(transform.position, closestEnemy.transform.position, 10 * Time.deltaTime);
        //         //closestEnemy.gameObject.GetComponent<EnemyCharacter>().isAttacked = true;
        //     }
        //     if (closestEnemy != null && b == true)
        //     {
        //         transform.position = Vector3.MoveTowards(transform.position, middleEnemy.transform.position, 10 * Time.deltaTime);
        //         //closestEnemy.gameObject.GetComponent<EnemyCharacter>().isAttacked = true;
        //     }

    }

}
