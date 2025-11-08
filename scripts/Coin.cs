using Godot;
using Godot.NativeInterop;
using System;

public partial class Coin : Area2D
{
	public override void _Ready()
	{
		BodyEntered += OnBodyEntered; // Subscribe to the event
	}

	private void OnBodyEntered(Node2D body) // Or Node3D body for 3D
	{
		GD.Print("+1 coin");
		QueueFree(); // Removes Coin object..
	}
}
