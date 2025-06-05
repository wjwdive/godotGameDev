using Godot;
using System;

public partial class scene4 : Node2D
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		
		//按下左键
		if (Input.IsActionJustPressed("ui_left"))
		{
			//获取当前场景树
			SceneTree st = this.GetTree();
			//跳转到场景2 方法一
			st.ChangeSceneToFile("res://scenes/game3.tscn");
		}
	}
}
