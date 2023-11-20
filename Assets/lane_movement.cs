using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lane_movement : MonoBehaviour
{
    private Transform Player;
    private int currentLane = 0; // 0 for middleLane, -1 for leftLane, 1 for rightLane

    private void Start()
    {
        Player = GetComponent<Transform>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.D) && currentLane < 1)
        {
            // Move to the right lane
            Player.position += new Vector3(-6, 0, 0);
            currentLane++;
        }

        if (Input.GetKeyDown(KeyCode.A) && currentLane > -1)
        {
            // Move to the left lane
            Player.position += new Vector3(6, 0, 0);
            currentLane--;
        }
    }
}
