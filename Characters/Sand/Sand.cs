using Godot;
using System;

public class Sand : MeshInstance
{
    // Member variables here, example:
    // private int a = 2;
    // private string b = "textvar";
    private int life;
    private int state;
    public Vector3 lookinat;
    public override void _Ready()
    {
        // Called every time the node is added to the scene.
        // Initialization here
        life = 100;
        lookinat = new Vector3(0,0,-2);
    }

    public override void _Process(float delta)
    {    
        this.LookAt(lookinat, new Vector3(0,1,0));
    }
    public override void _Input(InputEvent @event)
    {
        if (@event.IsClass("InputEventMouseMotion"))
        {
            InputEventMouseMotion mouse = (InputEventMouseMotion)@event;
            Vector2 mousepos = mouse.GlobalPosition;
            Camera cam = (Camera)GetNode("../Camera");
            lookinat = cam.ProjectPosition(mousepos);
        }
    }

}
