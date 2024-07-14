using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerModel
{
    public Vector3 startPosition { get; private set; }
    public float speed {  get; private set; }

    public PlayerModel(Vector3 startPosition, float speed)
    {
        this.startPosition = startPosition;
        this.speed = speed;
    }

    public void SetSpeed(float speed) 
    {
        if (speed < 0)
            return;

        this.speed = speed;
    } 
}
 