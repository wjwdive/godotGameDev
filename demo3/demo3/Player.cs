using Godot;
using System;

public partial class Player : Sprite2D
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		if (Input.IsActionJustPressed("ui_down"))
		{
			//获取分组中的节点
			var enemys = this.GetTree().GetNodesInGroup("enemy");
			//遍历分组中的节点
			foreach (Node enemy in enemys)
			{
				if (enemy is Sprite2D sprite)
				{
					//销毁
					sprite.QueueFree();
				}
			}
		}

		if (Input.IsActionJustPressed("ui_left"))
		{
			//给一个分组中的节点法消息
			this.GetTree().CallGroup("enemy", "test");
		}

		if (Input.IsActionJustPressed("ui_up"))
		{
			//给将当前节点添加到敌人分组
			this.AddToGroup("enemy");
		}

	}
}
