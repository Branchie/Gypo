namespace Gypo.StateMachine
{
	using System;

	public class Transition : ITransition
	{
		public Action action { get; }
		public Func<bool> condition { get; }

		public IState from { get; }
		public IState to { get; }

		public Transition(IState from, IState to, Func<bool> condition, Action action)
		{
			this.action		= action;
			this.condition	= condition;
			this.from		= from;
			this.to			= to;
		}
	}
}