/// <summary>
/// 状态拥有者
/// </summary>
public class StateBase<T> : StateBase
{

	public T owner;   //拥有者(范型)

	public StateBase (int id, T o) : base (id)
	{
		owner = o;
	}
}