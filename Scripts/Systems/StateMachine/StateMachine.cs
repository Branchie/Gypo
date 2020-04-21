namespace Gypo.StateMachine
{
	using System;
	using System.Collections.Generic;

	public class StateMachine
	{
		public event Action<IState> onStateChanged = delegate { };

		private Dictionary<Type, TransitionManager> transitionManagers;

		public IState currentState	{ get; private set; }
		public IState defaultState	{ get; private set; }
		public IState prevState		{ get; private set; }
		public ITrigger prevTrigger	{ get; private set; }

		public StateMachine() : this(null) { }
		public StateMachine(IState defaultState)
		{
			this.defaultState = defaultState;
			transitionManagers = new Dictionary<Type, TransitionManager>();

			ChangeState(defaultState);
		}

		public void ChangeState(IState state)
		{
			if (!Equals(currentState, null))
				currentState.OnExit();

			prevState = currentState;
			currentState = state;

			if (!Equals(currentState, null))
				currentState.OnEnter();

			onStateChanged?.Invoke(currentState);
		}

		public void Update()
		{
			currentState?.OnUpdate();
		}

		public void Trigger<T>() where T : ITrigger
		{
			if (!transitionManagers.TryGetValue(typeof(T), out TransitionManager result))
				return;

			prevTrigger = null;
			result.Process(this);
		}

		public void Trigger(ITrigger trigger)
		{
			if (!transitionManagers.TryGetValue(trigger.GetType(), out TransitionManager result))
				return;

			prevTrigger = trigger;
			result.Process(this);
		}

		public TransitionManager GetTransitionManager<T>() where T : ITrigger
		{
			if (transitionManagers.TryGetValue(typeof(T), out TransitionManager result))
				return result;

			return null;
		}

		public TransitionManager GetOrAddTransitionManager<T>() where T : ITrigger
		{
			if (transitionManagers.TryGetValue(typeof(T), out TransitionManager result))
				return result;

			result = new TransitionManager();
			transitionManagers.Add(typeof(T), result);

			return result;
		}

		public void Reset()
		{
			ChangeState(defaultState);
		}
	}
}