using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class FightManagement : MonoBehaviour
{
    private float speed = 10f;
    [SerializeField] GameObject[] Players, Enemies;
    public List<GameObject> p = new List<GameObject>();
    public List<GameObject> e = new List<GameObject>();
    void Start()
    {
        for (int i = 1; i < Players.Length; i++)
        {
            p.Add(Players[i]);
        }
        for (int i = 1; i < Enemies.Length; i++)
        {
            e.Add(Enemies[i]);
        }
        for (int i = 0; i < 10000; i++)
        {
            Check[i] = false;
        }
    }
    // Update is called once per frame
    private bool isMoved1, isMoved2, isMoved3 = false;
    private bool[] Check = new bool[10000];

    void FightCheck()
    {
        // GameObject pl;
        // GameObject el;
        // for (int i = p.Count - 1; i > -1; i--)
        // {
        //     for (int j = e.Count - 1; j > -1; j--)
        //     {
        //         //WriteAboutEnemyHere
        //         if (p[i] != null && e[j] != null)
        //         {
        //             float distance = Vector3.Distance(p[i].transform.position, e[j].transform.position);
        //             if (distance < 15f && Check[i] != true)
        //             {



        //                 Check[i] = true;
        //                 pl = p[i];
        //                 el = e[i];


        //             }
        //         }

        //     }

        //     //WriteAboutPlayerHere
        // }
        // pl.transform.position = Vector3.MoveTowards(pl.transform.position, el.transform.position, 10 * Time.deltaTime);
    }
    void Update()
    {
        FightCheck();
        // foreach (GameObject Enemy in Enemies)
        // {
        //     //var currentPlayer = player;
        //     foreach (GameObject player in Players)
        //     {
        //         if (player != null && Enemy != null)
        //         {
        //             float step = speed * Time.deltaTime;
        //             float distance = Vector3.Distance(player.transform.position, Enemy.transform.position);
        //             if (distance < 10f && distance > 1)
        //             {
        //                 player.transform.position = Vector3.MoveTowards(player.transform.position, Enemy.transform.position, step);
        //                 if (distance < 1)
        //                 {
        //                     //isMoved1 = true;
        //                     player.transform.position = Vector3.MoveTowards(player.transform.position, Enemy.transform.position, 0);
        //                     Enemy.transform.position = Vector3.MoveTowards(Enemy.transform.position, player.transform.position, 0);
        //                     if (player.tag == "ChildSingle")
        //                     {
        //                         player.gameObject.GetComponent<ChildMovement>().Speed = 0;
        //                     }
        //                     else if (player.tag == "Player")
        //                     {
        //                         player.gameObject.GetComponent<PlayerMovementDemoRunner>().Speed = 0;
        //                     }
        //                     else if (player.tag == "GroupChild")
        //                     {
        //                         player.gameObject.GetComponent<GroupChildMovement>().Speed = 0;
        //                     }
        //                 }
        //             }
        //         }
        //     }
        // }
    }
}
