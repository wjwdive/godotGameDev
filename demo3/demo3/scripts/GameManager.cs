using Godot;
using System;

public partial class GameManager : Node
{
	// 游戏管理类，单例，只初始化一次.可以在这里做出一个切换场景也不会被销毁的单例形式脚本了。
	public override void _Ready()
	{
		GD.Print("GameManager is ready.");
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
