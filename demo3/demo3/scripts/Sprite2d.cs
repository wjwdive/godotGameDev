using Godot;
using System;

public partial class Sprite2d : Sprite2D
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		if (Input.IsActionJustPressed("ui_left"))
		{
			//获取当前场景的根节点
			Node root = this.GetTree().CurrentScene;
			//寻找Sprite2D节点
			Node node = root.GetNode<Node>("Node");
			GD.Print(" node found: " + node.Name);
			//尝试删除 节点
			//node.QueueFree();

			//把node节点变为Sprite2D的子节点
			if (node != null)
			{
				//从根节点中移除该节点
				root.RemoveChild(node);
				this.AddChild(node);
				GD.Print("Node added as child to Sprite2d");
			}
			else
			{
				GD.Print("Node not found");
			}
		}

		if (Input.IsActionJustPressed("ui_right"))
		{
			//获取当前场景的根节点
			Node root = this.GetTree().CurrentScene;
			//创建一个新节点
			Sprite2D newNode = new Sprite2D();
			//改变新节点的名称
			newNode.Name = "NewSprite2D";
			this.AddChild(newNode);
			
		}
	}
}
