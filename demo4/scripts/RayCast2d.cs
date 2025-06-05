using Godot;
using System;

public partial class RayCast2d : RayCast2D
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		
	}

	//每次物理更新，都会自动做一次碰检测
	public override void _PhysicsProcess(double delta)
	{
		base._PhysicsProcess(delta);
		//按下键，做碰撞检测
		if (Input.IsActionJustPressed("down"))
		{
			//拿到当前一次的检测结果
			if (this.IsColliding())
			{
				//拿到碰撞检测区域
				Area2D area2D = this.GetCollider() as Area2D;
				GD.Print("检测到了：" + area2D.Name);
			}
			else
			{
				GD.Print("没检测到射线碰撞");
			}
		}
	}
}
