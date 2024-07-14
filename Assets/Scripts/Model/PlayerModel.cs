using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerModel
{
    public Vector3 StartPosition { get; private set; }
    public float Speed {  get; private set; }

    public PlayerModel(Vector3 startPosition, float speed)
    {
        this.StartPosition = startPosition;
        this.Speed = speed;
    }

    public void SetSpeed(float speed) 
    {
        if (speed < 0)
            return;

        this.Speed = speed;
    } 
}
 