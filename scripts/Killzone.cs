using Godot;

public partial class Killzone : Area2D
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		BodyEntered += OnBodyEntered; // Subscribe to the event
		var timer = GetNode<Timer>("Timer");
		timer.Connect("timeout", Callable.From(OnTimerTimeout));
    }

	private void OnBodyEntered(Node2D body) // Or Node3D body for 3D
	{
		GD.Print("You died");
		var timer = GetNode<Timer>("Timer");
		timer.Start();
	}

	private void OnTimerTimeout()
    {
		GetTree().ReloadCurrentScene();
    }
}
