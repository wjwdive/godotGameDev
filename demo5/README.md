## 刚体	

### 1、给角色添加物理性质	
	1、	创建RigidBody2D
	2、新建它的子节点，Sprite2D，用于显示角色	
	3、新建形状碰撞CollisionShape2D，并给角色套上胶囊体碰撞形状。	
	这是其中一种方法，还有一种是直接新建 CharacterBody2D	
	
## 2、模拟地板	
	1、新建StaticBody2D
	2、创建Sprite2D，显示地板纹理
	3、添加CollisionShape2D，并加上举行碰撞形状。

## 3、给角色添加控制移动逻辑
	给刚体 RigidBody2D ，添加脚本，在物理检测逻辑中获取水平 轴。
	记得冻结旋转属性
	
	然后再PhysicalProcess中获取水平轴，并添加水平和垂直方向值。
	左右移动，只需要给x轴赋值，Y轴保持不变。
	跳跃，只需给Y轴赋值，X轴保持不变。
	
	注意】要在Ready中 配置好开启碰撞检测，获取最新的碰撞检测值。
	```
	this.LockRotation = true;
		//如果要做碰撞检测
		this.ContactMonitor = true;		//默认是false
		//获取最新一次的碰撞信息
		this.MaxContactsReported = 1;//默认是0
	```
	也可以在RigidBody2D的检查器中 修改Solver对应属性值。
