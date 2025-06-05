using Godot;
using System;

public partial class scene4button : Button
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{   //这里是代码中连接信号；还可以在godot里设置。
		//this连接 一个pressed消息， 消息的执行者是this，消息的名称是。。。，
		this.Connect("pressed", new Callable(this, "_on_scene4button_pressed"));
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}

	//找到响应节点，并删除
	public void _on_scene4button_pressed()
	{
		//获取当前场景树
		var sprite = GetNodeOrNull<Sprite2D>("/root/game4/Sprite2D");
		GD.Print("sprite:", sprite);
		if (sprite != null)
		{
			sprite.QueueFree();
		}
	}
}
