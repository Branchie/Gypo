namespace Gypo.StateMachine
{
	using System;
	using System.Collections.Generic;

	public class TransitionManager
	{
		private Dictionary<IState, List<ITransition>> transitions;

		public TransitionManager()
		{
			transitions = new Dictionary<IState, List<ITransition>>();
		}

		public bool Process(StateMachine stateMachine)
		{
			if (!transitions.TryGetValue(stateMachine.currentState, out List<ITransition> result))
				return false;

			foreach (ITransition t in result)
			{
				if (!t.condition())
					continue;

				stateMachine.ChangeState(t.to);
				t.action?.Invoke();

				return true;
			}

			return false;
		}

		public TransitionManager AddTransition(ITransition transition)
		{
			if (transitions.TryGetValue(transition.from, out List<ITransition> result))
				result.Add(transition);
			else
				transitions.Add(transition.from, new List<ITransition>() { transition });

			return this;
		}

		public TransitionManager AddTransition(IState from, IState to)
		{
			return AddTransition(new Transition(from, to, () => true, null));
		}

		public TransitionManager AddTransition(IState from, IState to, Action action)
		{
			return AddTransition(new Transition(from, to, () => true, action));
		}

		public TransitionManager AddTransition(IState from, IState to, Func<bool> condition)
		{
			return AddTransition(new Transition(from, to, condition, null));
		}

		public TransitionManager AddTransition(IState from, IState to, Func<bool> condition, Action action)
		{
			return AddTransition(new Transition(from, to, condition, action));
		}
	}
}