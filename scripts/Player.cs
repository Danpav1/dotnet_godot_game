using Godot;
using System;

public partial class Player : CharacterBody2D
{
	// Movement speed in pixels per second
	[Export] public float Speed = 200f;

	public override void _PhysicsProcess(double delta)
	{
		Vector2 velocity = Velocity;

		// Get horizontal input
		float inputX = Input.GetActionStrength("ui_right") - Input.GetActionStrength("ui_left");
		velocity.X = inputX * Speed;

		// Apply movement
		Velocity = velocity;
		MoveAndSlide();
	}
}
