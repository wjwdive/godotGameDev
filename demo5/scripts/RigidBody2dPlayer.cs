using Godot;
using System;

public partial class RigidBody2dPlayer : RigidBody2D
{
	public bool isOnGround = false;
	public override void _Ready()
	{
		//锁定旋转
		this.LockRotation = true;
		//如果要做碰撞检测
		this.ContactMonitor = true;
		//获取最新一次的碰撞信息
		this.MaxContactsReported = 1;
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{

	}

	public override void _PhysicsProcess(double delta)
	{
		//通过获取 水平轴，控制左右移动
		float horizontal = Input.GetAxis("left", "right");
		//速度
		this.LinearVelocity = new Vector2(horizontal * 100, this.LinearVelocity.Y);
		//如果按了空格（跳跃）
		if (Input.IsActionJustPressed("jump") && isOnGround == true)
		{
			//速度
			this.LinearVelocity = new Vector2(this.LinearVelocity.X, -300);
		}
	}

	public new void BodyEntered(Node body)
	{
		GD.Print("碰撞了");
		isOnGround = true;
	}

	public new void BodyExit(Node body)
	{
		isOnGround = false;
	}
}
