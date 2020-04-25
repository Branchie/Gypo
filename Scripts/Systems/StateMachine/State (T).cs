namespace Gypo.StateMachine
{
	public class State<T> : State
	{
		protected T parent;

		public virtual void Init(T parent)
		{
			this.parent = parent;
		}
	}
}