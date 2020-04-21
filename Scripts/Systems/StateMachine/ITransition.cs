using System;

namespace Gypo.StateMachine
{
	public interface ITransition
	{
		Action action { get; }
		Func<bool> condition { get; }

		IState from { get; }
		IState to { get; }
	}
}