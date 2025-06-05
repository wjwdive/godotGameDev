using Godot;
using System;

public partial class scene1 : Node2D
{
	//新场景
	[Export]
	public PackedScene newScene2;
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
			st.ChangeSceneToFile("res://scenes/game2.tscn");

		}

		//按下右键
		if (Input.IsActionJustPressed("ui_right"))
		{
			//获取当前场景树
			SceneTree st = this.GetTree();
			//跳转到场景2 方法二
			st.ChangeSceneToPacked(newScene2);
		}

		//按下下键 跳转到场景2 方法三-挂载
		if (Input.IsActionJustPressed("ui_down"))
		{
			//实例化新场景
			Node Node = newScene2.Instantiate();
			//添加到根节点
			this.GetTree().CurrentScene.AddChild(Node);
		}
	}
}
