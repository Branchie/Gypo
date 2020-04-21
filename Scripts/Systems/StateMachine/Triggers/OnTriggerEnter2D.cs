namespace Gypo.StateMachine.Triggers
{
	using UnityEngine;

	public class OnTriggerEnter2D : ITrigger
	{
		public readonly Collider2D other;

		public OnTriggerEnter2D(Collider2D other)
		{
			this.other = other;
		}
	}
}