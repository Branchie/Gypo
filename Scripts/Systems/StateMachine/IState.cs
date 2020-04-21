namespace Gypo.StateMachine
{
	using System;

	public interface IState
	{
		event Action onEnterEvent;
		event Action onExitEvent;
		event Action onUpdateEvent;

		void OnEnter();
		void OnExit();
		void OnUpdate();
	}
}