using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroupManagement : MonoBehaviour
{
    public GameObject[] group1, group2, group3;
    //public bool AnyofG1Running, AnyofG2Running, AnyofG3Running;
    void Start()
    {

    }


    void Update()
    {
        foreach (GameObject member in group1)
        {
            if (member != null && member.gameObject.GetComponent<GroupChildMovement>().ReadytoRun == true)
            {
                foreach (GameObject item in group1)
                {
                    if (item != null)
                    {
                        item.gameObject.GetComponent<GroupChildMovement>().ReadytoRun = true;
                    }
                }
            }
        }

        foreach (GameObject member in group2)
        {
            if (member != null && member.gameObject.GetComponent<GroupChildMovement>().ReadytoRun == true)
            {
                foreach (GameObject item in group2)
                {
                    if (item != null)
                    {
                        item.gameObject.GetComponent<GroupChildMovement>().ReadytoRun = true;
                    }
                }
            }
        }

        foreach (GameObject member in group3)
        {
            if (member != null && member.gameObject.GetComponent<GroupChildMovement>().ReadytoRun == true)
            {
                foreach (GameObject item in group3)
                {
                    if (item != null)
                    {
                        item.gameObject.GetComponent<GroupChildMovement>().ReadytoRun = true;
                    }
                }
            }
        }
    }
}
