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
        controller = new PlayerController(new PlayerModel(Vector3.zero, speed), this);
    }

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        controller.HandleInput();

        controller.SpeedUp();
        controller.SpeedDown();
    }
}
