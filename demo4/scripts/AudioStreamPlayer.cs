using Godot;
using System;

public partial class AudioStreamPlayer : Godot.AudioStreamPlayer
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{

		// if (Input.IsActionJustPressed("defend"))
		// {
		// 	if (this.Playing == false)
		// 	{
		// 		this.Play();
		// 	}
		// }

		// if (Input.IsActionJustPressed("down"))
		// {
		// 	this.StreamPaused = true;
		// }

		// if (Input.IsActionJustPressed("up"))
		// {
		// 	this.StreamPaused = false;
		// }
	}
}
