using Godot;
using System;

public partial class Scene2Sprite2d2 : Sprite2D
{
	//暴露出一个外部变量，给编辑器使用
	[Export]
	public Texture2D newTexture;
	double timer = 0.0;
	public override void _Ready()
	{
		//加载纹理
		Texture2D texture = (Texture2D)GD.Load("res://images/player.png");
		this.Texture = texture;
		//中心点还是左上角，勾选掉offset下 的 Centered。默认精灵的左上角就会对齐窗口的左上角。
		this.Centered = false;
		//偏移
		this.Offset = new Vector2(100, 100); // 设置偏移量
		this.FlipH = false;                                   //水平翻转
		this.FlipV = false;                               //垂直翻转
		this.ZIndex = 1; // 设置渲染顺序，值越大越靠前

		//动画，帧动画
		this.Hframes = 4;
		this.Vframes = 4;
		this.Scale =new Vector2(3, 3); // 设置缩放比例
		this.Frame = 0; // 设置当前帧
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		//计时
		timer += delta;
		//当超过1秒救换一个图像
		if (timer > 0.25)
		{
			// 重置计时器
			timer = 0.0;
			//获取下一帧
			int index = this.Frame + 1;

			if (index > 3) index = 0;
			//让精灵生成下一帧
			this.Frame = index;
		}
	}
}
