using Godot;

public partial class Slime : Node2D
{
	private const int Speed = 60;
	
	private int _direction = 1;

	public override void _Process(double delta)
	{
		var rayCastR = GetNode<RayCast2D>("RayCastRight");
		var rayCastL = GetNode<RayCast2D>("RayCastLeft");
		var slimeSprite = GetNode<AnimatedSprite2D>("AnimatedSprite2D");

		if (rayCastR.IsColliding())
        {
			this._direction = -1;
			slimeSprite.FlipH = true;
        }
		
		if (rayCastL.IsColliding())
        {
			this._direction = 1;
			slimeSprite.FlipH = false;
        }

		var position = Position;
		position.X += _direction * (float)(Speed* delta);
		Position = position;
    }
}