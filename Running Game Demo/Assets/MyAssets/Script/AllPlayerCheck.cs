using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllPlayerCheck : MonoBehaviour
{
    public GameObject[] AllPlayers;
    public GameObject RestartPanel;
    public List<GameObject> Players = new List<GameObject>();

    private void Start()
    {
        for (int i = 1; i < AllPlayers.Length; i++)
        {
            Players.Add(AllPlayers[i]);
        }
    }
    private void Update()
    {
        for (var i = Players.Count - 1; i > -1; i--)
        {
            if (Players[i] == null)
            {
                Players.RemoveAt(i);
            }

            if (Players.Count < 1)
            {
                RestartPanel.SetActive(true);
                Time.timeScale = 0f;
            }
        }
    }
}
