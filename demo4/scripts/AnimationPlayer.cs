using Godot;
using System;

public partial class AnimationPlayer : Godot.AnimationPlayer
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		if (Input.IsActionJustPressed("left"))
		{
			this.Play("idle");
			//其他方法
			// this.Pause();
			// this.Stop();
			// this.IsPlaying();
		}

		if (Input.IsActionJustPressed("right"))
		{
			this.Play("run");
		}
	}
}
