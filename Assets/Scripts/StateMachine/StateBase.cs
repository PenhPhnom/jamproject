/// <summary>
/// 状态的基础类：给子类提供方法
/// </summary>
/// 
public abstract class StateBase
{

	//给每个状态设置一个ID
	public int Id { get; set; }

	//被当前机器所控制
	public StateMachine machine;

	protected StateBase (int id)
	{
		Id = id;
	}

	//给子类提供方法
	public virtual void OnEnter (params object[] args) { }
	public virtual void OnUpdate (params object[] args) { }
	public virtual void OnExit (params object[] args) { }

}