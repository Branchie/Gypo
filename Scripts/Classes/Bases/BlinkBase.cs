namespace Gypo
{
	using UnityEngine;

	public abstract class BlinkBase : MonoBehaviour, IResetable, ISuspendable
	{
		[SerializeField] protected float interval = 1f / 15f;
		[SerializeField] protected float offset = 0;

		protected float activeTime;

		public virtual string resetKey		=> "Game";
		public virtual string suspensionKey	=> "Game";

		public virtual bool isSuspended { get; set; }

		protected virtual void Awake()
		{
			activeTime = offset;

			ResetManager.Register(this, resetKey);
			SuspensionManager.Register(this, suspensionKey);
		}

		protected virtual void OnDestroy()
		{
			ResetManager.Unregister(this, resetKey);
			SuspensionManager.Unregister(this, suspensionKey);
		}

		protected virtual void Update()
		{
			if (isSuspended)
				return;

			activeTime += Time.deltaTime;

			if (activeTime >= interval)
			{
				OnBlink();
				activeTime -= interval;
			}
		}

		protected abstract void OnBlink();

		public virtual void OnReset()
		{
			activeTime = offset;
		}
	}
}