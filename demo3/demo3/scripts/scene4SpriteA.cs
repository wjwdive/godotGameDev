using Godot;
using System;

public partial class scene4SpriteA : Sprite2D
{
	//声明一个信号
	[Signal]
	//声明一个委托
	public delegate void MySignalEventHandler();//必须以 EventHandler结尾

	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		//按下up
		if (Input.IsActionJustPressed("ui_up"))
		{
			//发射信号
			EmitSignal("MySignal");
		}
	}
}
