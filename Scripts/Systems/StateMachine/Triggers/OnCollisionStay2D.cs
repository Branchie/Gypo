namespace Gypo.StateMachine.Triggers
{
	using UnityEngine;

	public class OnCollisionStay2D : ITrigger
	{
		public readonly Collision2D collision;

		public OnCollisionStay2D(Collision2D collision)
		{
			this.collision = collision;
		}
	}
}