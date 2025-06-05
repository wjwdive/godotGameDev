using Godot;
using System;

public partial class Sprite2d2 : Sprite2D
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		// 在这里处理游戏逻辑
		if (Input.IsKeyPressed(Key.Space))
		{
			GD.Print("Space key pressed in Sprite2d2");
		}


		//虚拟按键
		//按了space跳跃
		if (Input.IsActionJustPressed("jump"))
		{
			GD.Print("Jump action just pressed in Sprite2d2");
		}
		//按space中
		if (Input.IsActionPressed("jump"))
		{
			GD.Print("Jump action is being pressed in Sprite2d2");
		}
		//松开了space
		if (Input.IsActionJustReleased("jump"))
		{
			GD.Print("Jump action just released in Sprite2d2");
		}

		//获取按键力度
		float jumpStrength = Input.GetActionStrength("jump");
		//GD.Print($"Jump action strength: {jumpStrength}");

		//获取上下左右的一个向量
		Vector2 direction = Input.GetVector("left", "right", "up", "down");
		GD.Print(direction);
	}
}
