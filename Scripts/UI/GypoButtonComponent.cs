namespace Gypo.UI
{
	using UnityEngine;

	public class GypoButtonComponent : MonoBehaviour
	{
		protected GypoButton target;

		protected virtual void OnEnable()
		{
			if (!target && !TryGetComponent(out target))
				return;

			Subscribe();
		}

		protected virtual void OnDisable()
		{
			if (target)
				Unsubscribe();
		}

		protected virtual void Subscribe() { }
		protected virtual void Unsubscribe() { }
	}
}