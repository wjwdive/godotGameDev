using Godot;
using System;

public partial class PlayerArea2d : Area2D
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}

	public void OnAreaEnter(Area2D area)
	{
		GD.Print("和敌人发生碰撞,和：" + area.GetParent().Name);
	}
}
