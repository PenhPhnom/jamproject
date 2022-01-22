using System.Collections.Generic;

/// <summary>
/// 状态机器类：由Player控制。完成状态的存储，切换，和状态的保持
/// </summary>
public class StateMachine
{

	//用来存储当前机器所控制的所有状态
	public Dictionary<int, StateBase> stateCache;

	//定义上一个状态
	public StateBase previousState;
	//定义当前状态
	public StateBase currentState;

	//机器初始化时，没有上一个状态
	public StateMachine (StateBase beginState)
	{
		previousState = null;
		currentState = beginState;

		stateCache = new Dictionary<int, StateBase> ();
		//把状态添加到集合中
		AddState (beginState);
		currentState.OnEnter ();
	}

	public void AddState (StateBase state)
	{
		if (!stateCache.ContainsKey (state.Id))
		{
			stateCache.Add (state.Id, state);
			state.machine = this;
		}
	}

	//通过Id来切换状态
	public void TranslateState (int id)
	{
		if (!stateCache.ContainsKey (id))
		{
			return;
		}

		previousState = currentState;
		currentState = stateCache[id];
		currentState.OnEnter ();
	}

	//状态保持
	public void Update ()
	{
		if (currentState != null)
		{
			currentState.OnUpdate ();
		}
	}
}