using Godot;
using System;

public class SandComp : Spatial
{
    // Member variables here, example:
    // private int a = 2;
    // private string b = "textvar";

    public override void _Ready()
    {
        // Called every time the node is added to the scene.
        // Initialization here
        
    }

    public override void _Process(float delta)
    {
        SandMovement();      
    }
    public void SandMovement()
    {
        Transform sand = this.GetTransform();
        Vector3 movement = new Vector3(0,0,0);
        float speed = 0.025f;
        if (Input.IsActionPressed("SANDUP") )
        {
            movement.z = -speed;
        }
        if (Input.IsActionPressed("SANDDOWN"))
        {
            movement.z = speed;
        }
        if (Input.IsActionPressed("SANDLEFT"))
        {
            movement.x = -speed;
        }
        if (Input.IsActionPressed("SANDRIGHT"))
        {
            movement.x = speed;
        }
        sand.origin += movement;
        this.Translate(movement);
        /*Console.Write(this.GlobalTransform.origin);
        this.GlobalTransform = sand;*/
    }
}
