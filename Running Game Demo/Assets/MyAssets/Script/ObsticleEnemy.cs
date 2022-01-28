using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObsticleEnemy : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "ChildSingle" || other.gameObject.tag == "Player" || other.gameObject.tag == "GroupChild")
        {

            other.gameObject.GetComponent<Animator>().SetTrigger("isDead");
            Destroy(other.gameObject, 2f);
        }
    }


}
