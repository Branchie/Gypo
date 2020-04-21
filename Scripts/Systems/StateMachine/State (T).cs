namespace Gypo.StateMachine
{
	public class State<T> : State
	{
		protected T parent;

		public State(T parent)
		{
			this.parent = parent;
		}
	}
}