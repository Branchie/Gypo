namespace Gypo.StateMachine.Triggers
{
	using UnityEngine;

	public class OnTriggerStay2D : ITrigger
	{
		public readonly Collider2D other;

		public OnTriggerStay2D(Collider2D other)
		{
			this.other = other;
		}
	}
}