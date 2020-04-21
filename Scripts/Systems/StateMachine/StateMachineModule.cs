namespace Gypo.StateMachine
{
	using Triggers;
	using UnityEngine;

	public class StateMachineModule : MonoBehaviour
	{
		public StateMachine stateMachine = new StateMachine();

		protected virtual void FixedUpdate()
		{
			stateMachine.Trigger<OnFixedUpdate>();
		}

		protected virtual void Update()
		{
			stateMachine.Trigger<OnUpdate>();
		}

		protected virtual void OnCollisionEnter2D(Collision2D collision)
		{
			stateMachine.Trigger(new OnCollisionEnter2D(collision));
		}

		protected virtual void OnCollisionStay2D(Collision2D collision)
		{
			stateMachine.Trigger(new OnCollisionStay2D(collision));
		}

		protected virtual void OnCollisionExit2D(Collision2D collision)
		{
			stateMachine.Trigger(new OnCollisionExit2D(collision));
		}

		protected virtual void OnTriggerEnter2D(Collider2D other)
		{
			stateMachine.Trigger(new OnTriggerEnter2D(other));
		}

		protected virtual void OnTriggerStay2D(Collider2D other)
		{
			stateMachine.Trigger(new OnTriggerStay2D(other));
		}

		protected virtual void OnTriggerExit2D(Collider2D other)
		{
			stateMachine.Trigger(new OnTriggerExit2D(other));
		}
	}
}