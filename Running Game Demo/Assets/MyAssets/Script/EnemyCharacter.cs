using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCharacter : MonoBehaviour
{
    Animator animator;
    CapsuleCollider capsuleCollider;
    Rigidbody rb;
    //public ParticleSystem Empact;
    private void Start()
    {
        animator = gameObject.GetComponent<Animator>();
        capsuleCollider = gameObject.GetComponent<CapsuleCollider>();
        rb = gameObject.GetComponent<Rigidbody>();
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "ChildSingle")
        {
            this.gameObject.GetComponentInChildren<ParticleSystem>().Play();
            other.gameObject.GetComponent<Animator>().SetTrigger("isDead");
            animator.SetTrigger("isDead");
            other.gameObject.GetComponent<ChildMovement>().Speed = 0f;
            Destroy(other.gameObject, 2f);
            Destroy(this.gameObject, 1f);
            capsuleCollider.enabled = false;
            rb.useGravity = false;
            rb.isKinematic = true;
            isAttacked = true;
        }
        else if (other.gameObject.tag == "Player")
        {
            this.gameObject.GetComponentInChildren<ParticleSystem>().Play();
            other.gameObject.GetComponent<Animator>().SetTrigger("isDead");
            animator.SetTrigger("isDead");
            other.gameObject.GetComponent<PlayerMovementDemoRunner>().Speed = 0f;
            Destroy(other.gameObject, 2f);
            Destroy(this.gameObject, 1f);
            capsuleCollider.enabled = false;
            rb.useGravity = false;
            rb.isKinematic = true;
        }
        else if (other.gameObject.tag == "GroupChild")
        {
            this.gameObject.GetComponentInChildren<ParticleSystem>().Play();
            other.gameObject.GetComponent<Animator>().SetTrigger("isDead");
            animator.SetTrigger("isDead");
            other.gameObject.GetComponent<GroupChildMovement>().Speed = 0f;
            Destroy(other.gameObject, 2f);
            Destroy(this.gameObject, 1f);
            capsuleCollider.enabled = false;
            rb.useGravity = false;
            rb.isKinematic = true;
        }
    }

    public bool isAttacked = false;

    public void GettingAttack()
    {

    }


}
