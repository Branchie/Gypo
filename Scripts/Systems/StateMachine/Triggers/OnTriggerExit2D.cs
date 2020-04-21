namespace Gypo.StateMachine.Triggers
{
	using UnityEngine;

	public class OnTriggerExit2D : ITrigger
	{
		public readonly Collider2D other;

		public OnTriggerExit2D(Collider2D other)
		{
			this.other = other;
		}
	}
}