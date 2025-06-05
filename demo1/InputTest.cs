using Godot;
using System;

public partial class InputTest : Node
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		//鼠标设置：显示、隐藏、限制在游戏窗口(光标只能在窗口内活动)
		Input.MouseMode = Input.MouseModeEnum.Visible;// Hidden, Confined, ConfinedHidden,
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		//是否按下F键，这里每一帧都会调用一次。
		if(Input.IsKeyPressed(Key.F)){
			GD.Print("按下了F键");
		}

		//【监听用户输入】按下了虚拟按键，虚拟按键比键盘事件监听要好用的多，不用一点点做事件类型判断和事件转换。
		if(Input.IsActionJustPressed("		choco install scriptcs")){
			GD.Print("按下了跳跃");
		}
		if(Input.IsActionPressed("跳跃")){
			GD.Print("跳跃中");
		}
		if(Input.IsActionJustReleased("跳跃")){
			GD.Print("按结束跳跃");
		}
		//获取按键的按压力度,返回 0~1的数字
		float f = Input.GetActionStrength("跳跃");
		GD.Print("按压力度: " + f);
		//获取x水平轴
		float horizontal = Input.GetAxis("左", "右");
		GD.Print("水平轴向: " + horizontal);

		// 获取上下左右组成的一个向量
		Vector2 dir = Input.GetVector("左","右","上","下");
		GD.Print("上下左右轴向: " + dir);

		//【如何查找一个节点】
		//按下键盘的左键
		if(Input.IsActionJustPressed("左")){
			//获取当前场景的根节点
			Node root = this.GetTree().CurrentScene;
			//去寻找test节点
			Node test = root.FindChild("Test");
			//尝试删除test节点
			//test.QueueFree();

			//修改test为InputTest的子节点
			//1、要把Test节点从节点树中拿出来
			root.RemoveChild(test);
			//2、将孤立的test节点添加到当前节点下
			this.AddChild(test);

		}

		if(Input.IsActionJustPressed("右")){
			//获取当前场景的根节点
			Node root = this.GetTree().CurrentScene;
			//创建一个新节点
			Node2D node2D = new Node2D();
			//修改名称
			node2D.Name = "new";
			//添加 new节点
			this.AddChild(node2D);
		}

		if(Input.IsActionJustPressed("上")){
			//查找某个节点，可以先后去根节点，使用findChild查找，最后转为 Node2D
			//查找某个节点的父节点
			Node2D node = this.GetParent() as Node2D;
			Node2D nodep = this.GetParent<Node2D>();//使用泛型
			GD.Print("node " + node);
			GD.Print("nodep " + nodep);
			//使用相对领，绝对路径查找节点
			Node2D node1 = GetNode<Node2D>("Node2D3/Node2D4");//当前在Node2D，之下有个Node2D4
			Node2D node11 = GetNode<Node2D>("res://Node2D/Node2DNew");//如果有这个路径节点，绝对路径
		}


	}
	//_Input() 生命周期中方法，

    public override void _Input(InputEvent @event)
    {
        base._Input(@event);
		//如果是键盘事件，
		if(@event is InputEventKey){
			//转成键盘事件
			var key = @event as InputEventKey;
			//判断我们当前按下的是否是键D
			if(key.Keycode == Key.D){
				GD.Print("按下了D键");
				//在Input方法里处理案件可以监听案件的状态，持续按压；按下瞬间；抬起瞬间
				if(key.IsEcho()){
					GD.Print("持续按D");
				}
				else if(key.IsPressed()){
					GD.Print("按下D");
				}else if(key.IsReleased()){
					GD.Print("抬起D");
				}

			}
			
		}
		if(@event is InputEventMouse){
			//转成鼠标事件
			var mouse = @event as InputEventMouse;
			if(mouse.IsPressed()){
				//打印鼠标位置
				GD.Print(mouse.Position);
				//打印鼠标按键
				GD.Print(mouse.ButtonMask);
			}
		}
    }

}
