using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Timers;

public class TimerAction : MonoBehaviour
{
    public float targetTime = 5.0f ; //time (in seconds) to do action
    public SpriteRenderer spriteRenderer; //for color change (at end of timer. Use for debug)
    public Transform transform; //for action (rotation in this case)

    void Update()
    {


        if (targetTime <= 0.0f)
        {
            timerEnded();
        }
        else
        {
            targetTime -= Time.deltaTime; //decriments timer
            transform.Rotate(Vector3.forward * -90); //action as proof of concept
        }
    }

    void timerEnded()
    {
        spriteRenderer.color = new Color(1f, 0f, 0f, 1f); //change color to show finished
    }
}
