using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController
{
    private PlayerModel model;
    private PlayerView view;

    public PlayerController(PlayerModel model, PlayerView view)
    {
        this.model = model;
        this.view = view;
    }

    public void HandleInput()
    {
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        float verticalInput = Input.GetAxisRaw("Vertical");

        Vector2 input = new Vector2(horizontalInput, verticalInput).normalized;
        view.rb.velocity = input * model.Speed;
    }

    public void SpeedUp()
    {
        if (Input.GetMouseButtonDown(0)) 
        {
            model.SetSpeed(model.Speed + 1);
        }
    }

    public void SpeedDown()
    {
        if (Input.GetMouseButtonDown(1))
        {
            model.SetSpeed(model.Speed - 1);
        }
    }
}
