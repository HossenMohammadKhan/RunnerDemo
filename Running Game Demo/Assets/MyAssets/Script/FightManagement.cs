using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class FightManagement : MonoBehaviour
{
    private float speed = 10f;
    [SerializeField] GameObject[] Players, Enemies;
    void Start()
    {
    }
    // Update is called once per frame
    private bool isMoved1, isMoved2, isMoved3 = false;
    void Update()
    {
        foreach (GameObject Enemy in Enemies)
        {
            //var currentPlayer = player;
            foreach (GameObject player in Players)
            {
                // if (player != null && Enemy != null)
                // {
                //     float step = speed * Time.deltaTime;
                //     float distance = Vector3.Distance(player.transform.position, Enemy.transform.position);
                //     if (distance < 10f && distance > 1 && isMoved1 == false)
                //     {
                //         player.transform.position = Vector3.MoveTowards(player.transform.position, Enemy.transform.position, step);
                //         if (distance < 1)
                //         {
                //             //isMoved1 = true;
                //             player.transform.position = Vector3.MoveTowards(player.transform.position, Enemy.transform.position, 0);
                //             Enemy.transform.position = Vector3.MoveTowards(Enemy.transform.position, player.transform.position, 0);
                //             if (player.tag == "ChildSingle")
                //             {
                //                 player.gameObject.GetComponent<ChildMovement>().Speed = 0;
                //             }
                //             else if (player.tag == "Player")
                //             {
                //                 player.gameObject.GetComponent<PlayerMovementDemoRunner>().Speed = 0;
                //             }
                //             else if (player.tag == "GroupChild")
                //             {
                //                 player.gameObject.GetComponent<GroupChildMovement>().Speed = 0;
                //             }
                //         }
                //     }
                // }
            }
        }
    }
}
