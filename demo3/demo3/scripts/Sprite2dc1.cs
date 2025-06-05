using Godot;
using System;

public partial class Sprite2dc1 : Sprite2D
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		//是否显示
		this.Visible = true;
		//渲染顺序
		this.ZIndex = 1; // 设置渲染顺序，值越大越靠前
		this.ZAsRelative = false; // 保持宽高比

		//Node2D 常用属性
		//位置
		this.Position = new Vector2(100, 100); // 设置位置

		//旋转
		this.Rotation = 0.5f; // 设置旋转角度，单位为弧度

		//缩放
		this.Scale = new Vector2(1.0f, 1.0f); // 设置缩放比例

		//倾斜
		//this.Skew =30; // 设置倾斜角度

	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		//获取鼠标位置
		var mousePosition = GetGlobalMousePosition();
		//看向鼠标
		LookAt(mousePosition);
	}
}
