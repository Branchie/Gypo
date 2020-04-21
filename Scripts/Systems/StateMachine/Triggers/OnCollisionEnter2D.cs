namespace Gypo.StateMachine.Triggers
{
	using UnityEngine;

	public class OnCollisionEnter2D : ITrigger
	{
		public readonly Collision2D collision;

		public OnCollisionEnter2D(Collision2D collision)
		{
			this.collision = collision;
		}
	}
}