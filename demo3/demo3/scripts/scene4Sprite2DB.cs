using Godot;
using System;

public partial class scene4Sprite2DB : Sprite2D
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		// 获取 Sprite2DA 节点, 两个节点距离较远，可以使用绝对路径超找到节点
		var spriteA = GetNode<scene4SpriteA>("/root/game4/Sprite2DA"); // 根据实际场景树调整路径
		if (spriteA != null)
		{
			// 连接信号
			spriteA.Connect("MySignal", new Callable(this, "BEventHandler"));
		}
		else
		{
			GD.PrintErr("scene4SpriteA not found!");
		}
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}

	public void BEventHandler()
	{
		GD.Print("BEventHandler");
	}
}
