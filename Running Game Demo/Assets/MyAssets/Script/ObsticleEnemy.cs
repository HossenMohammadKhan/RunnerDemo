using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObsticleEnemy : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "ChildSingle")
        {
            other.gameObject.GetComponent<Animator>().SetTrigger("isDead");
            other.gameObject.GetComponent<ChildMovement>().Speed = 0f;
            other.gameObject.GetComponentInChildren<ParticleSystem>().Play();
            Destroy(other.gameObject, 2f);
        }
        else if (other.gameObject.tag == "Player")
        {
            other.gameObject.GetComponent<Animator>().SetTrigger("isDead");
            other.gameObject.GetComponent<PlayerMovementDemoRunner>().Speed = 0f;
            other.gameObject.GetComponentInChildren<ParticleSystem>().Play();
            Destroy(other.gameObject, 2f);
        }
        else if (other.gameObject.tag == "GroupChild")
        {
            other.gameObject.GetComponent<Animator>().SetTrigger("isDead");
            other.gameObject.GetComponent<GroupChildMovement>().Speed = 0f;
            other.gameObject.GetComponentInChildren<ParticleSystem>().Play();
            Destroy(other.gameObject, 2f);
        }
    }


}
