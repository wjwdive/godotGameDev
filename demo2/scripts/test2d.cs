using Godot;
using System;

public partial class test2d : Sprite2D
{
	/// <summary>
	/// 节点添加到节点树中的时候调用。
	/// </summary>
	public override void _EnterTree()
	{
		base._EnterTree();
		GD.Print(nameof(_EnterTree));
	}

	/// <summary>
	/// 节点加载完成时调用，用于初始化。
	/// </summary>
	public override void _Ready()
	{
		//初始化的逻辑都在这里
		base._Ready();
		GD.Print(nameof(_Ready));
	}

	/// <summary>
	/// 每帧调用一次，用于处理游戏逻辑。
	/// </summary>
	/// <param name="delta">自上一帧以来经过的时间（秒）。</param>
	public override void _Process(double delta)
	{
		base._Process(delta);
		// 在这里处理游戏逻辑
	}


	/// <summary>
	/// 每帧调用一次，用于处理物理相关的逻辑。
	/// </summary>
	/// <param name="delta">自上一帧以来经过的时间（秒）。</param>
	public override void _PhysicsProcess(double delta)
	{
		// 在这里处理物理相关的逻辑
		base._PhysicsProcess(delta);
	}

	/// <summary>
	/// 节点从节点树中移除时调用，用于清理资源。
	/// </summary>
	public override void _ExitTree()
	{
		base._ExitTree();
		GD.Print(nameof(_ExitTree));
	}


}
