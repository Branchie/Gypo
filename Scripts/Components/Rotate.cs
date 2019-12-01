namespace Gypo
{
	using UnityEngine;

	public class Rotate : MonoBehaviour, ISuspendable
	{
		[SerializeField] protected Space space = Space.Self;
		[SerializeField] protected Vector3 axis = new Vector3(0, 0, 360);

		public virtual string suspensionKey => "Game";

		public virtual bool isSuspended { get; set; }

		protected virtual void Awake()
		{
			SuspensionManager.Register(this, suspensionKey);
		}

		protected virtual void OnDestroy()
		{
			SuspensionManager.Unregister(this, suspensionKey);
		}

		protected virtual void Update()
		{
			if (isSuspended)
				return;

			transform.Rotate(axis * Time.deltaTime, Space.Self);
		}
	}
}