namespace Gypo.StateMachine.Triggers
{
	using UnityEngine;

	public class OnCollisionExit2D : ITrigger
	{
		public readonly Collision2D collision;

		public OnCollisionExit2D(Collision2D collision)
		{
			this.collision = collision;
		}
	}
}