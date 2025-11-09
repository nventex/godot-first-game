using Godot;

public partial class Coin : Area2D
{
	private GameManager _manager;
	private AnimationPlayer _animationPlayer;
	
	public override void _Ready()
	{
		BodyEntered += OnBodyEntered; // Subscribe to the event
		_manager = GetNode<GameManager>("%GameManager");
		_animationPlayer = GetNode<AnimationPlayer>("AnimationPlayer");
	}

	private void OnBodyEntered(Node2D body) // Or Node3D body for 3D
	{
		_manager.AddPoint();
		_animationPlayer.Play("pickup");
	}
}
