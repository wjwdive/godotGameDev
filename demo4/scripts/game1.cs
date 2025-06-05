using Godot;
using System;

public partial class game1 : Node2D
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		AudioManager audioManager = GetNode<AudioManager>("/root/AudioManager");
		var backgroundMusic = GD.Load<AudioStream>("res://2dres/bgm/bg.ogg");
		audioManager.PlayBackgroundMusic(backgroundMusic);
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		
		//按下右键
		if (Input.IsActionJustPressed("right"))
		{
			//获取当前场景树
			SceneTree st = this.GetTree();
			//跳转到场景2
			st.ChangeSceneToFile("res://scenes/game2.tscn");
		}
	}
}
