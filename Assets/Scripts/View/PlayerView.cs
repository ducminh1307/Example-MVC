using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerView : MonoBehaviour
{
    private PlayerController controller;

    public Rigidbody2D rb { get; private set; }
    [SerializeField] private float speed;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        controller = new PlayerController(new PlayerModel(Vector3.zero, speed), this);
    }

    private void Update()
    {
        controller.HandleInput();

        controller.SpeedUp();
        controller.SpeedDown();
    }
}
