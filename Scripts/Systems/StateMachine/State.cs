namespace Gypo.StateMachine
{
	using System;

	public class State : IState
	{
		public event Action onEnterEvent	= delegate { };
		public event Action onExitEvent		= delegate { };
		public event Action onUpdateEvent	= delegate { };

		public virtual void OnEnter()	=> onEnterEvent?.Invoke();
		public virtual void OnUpdate()	=> onUpdateEvent?.Invoke();
		public virtual void OnExit()	=> onExitEvent?.Invoke();
	}
}