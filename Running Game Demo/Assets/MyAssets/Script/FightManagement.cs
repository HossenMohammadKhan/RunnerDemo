using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class FightManagement : MonoBehaviour
{
    private float speed = 2f;
    [SerializeField] GameObject[] Players, Enemies;


    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        foreach (GameObject player in Players)
        {
            foreach (GameObject Enemy in Enemies)
            {
                if (player != null && Enemy != null)
                {
                    float step = speed * Time.deltaTime;
                    float distance = Vector3.Distance(player.transform.position, Enemy.transform.position);
                    if (distance < 10f)
                    {
                        if (distance > 3)
                        {
                            player.transform.position = Vector3.MoveTowards(player.transform.position, Enemy.transform.position, step);
                            Enemy.transform.position = Vector3.MoveTowards(Enemy.transform.position, player.transform.position, step);
                        }
                    }
                }
            }
        }
    }
}
