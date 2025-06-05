using Godot;
using System;

public partial class main : Node
{
    //定时器
    float timer = 100;

    //节点添加到书中的时候调用，节点的添加是先创建所有的节点，再依次添加各个节点到树上。所以在这里不能调用节点的一些处理方法，因为子节点可能还没有调用_EntryTree()
    public override void _EnterTree()
    {
        base._EnterTree();
        //输出
        GD.Print("enter tree!");
    }
    //节点加载完成，这里初始化。
	public override void _Ready(){
        GD.Print("Ready!");
        // 连接输入事件信号
        this.even += OnAreaInputEvent;
        
        //确保能接收鼠标
        this.MouseFilter = MouseFilterEnum.Stop;
    }

     private void OnAreaInputEvent(Node viewport, InputEvent @event, long shapeIdx)
    {
        if (@event is InputEventMouseButton mouseEvent && 
            mouseEvent.ButtonIndex == MouseButton.Left && 
            mouseEvent.Pressed)
        {
            GD.Print("Area2D被左键点击");
        }
    }

    //帧，也就是刷新方法
    public override void _Process(double delta) {
        //游戏逻辑
        
        //计时器开始倒计时
        timer -= (float)delta;
        //判断有没有到时间
        if(timer <= 0){
            timer = 100;
            //销毁节点
            this.QueueFree();
        }

    }

    //每次物理系统计算，调用依次，调用频率不及刷新函数的频率
    public override void _PhysicsProcess(double delta){
        base._PhysicsProcess(delta);
    }

    //节点离开节点树，销毁
    public override void _ExitTree(){
        base._ExitTree();
    }

    public override void _Input(InputEvent @event)
    {
        base._Input(@event);
        if(@event is InputEventMouse){
			//转成鼠标事件
			var mouse = @event as InputEventMouse;
			//判断是否为鼠标按键事件
            if (@event is InputEventMouseButton mouseEvent)
            {
                // 检测左键按下
                if (mouseEvent.ButtonIndex == MouseButton.Left && mouseEvent.Pressed)
                {
                    GD.Print("左键按下");

                }
                // 检测左键释放
                else if (mouseEvent.ButtonIndex == MouseButton.Left && !mouseEvent.Pressed)
                {
                    GD.Print("左键释放");
                }
            }
        }
    }


    
    

}
