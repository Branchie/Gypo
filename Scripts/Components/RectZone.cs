namespace Gypo
{
	using UnityEngine;

	[RequireComponent(typeof(RectTransform))]
	public class RectZone : Entity
	{
		public Vector2 center => position;
		public Vector2 max => center + halfSize;
		public Vector2 min => center - halfSize;

		protected Vector2 halfSize => ((RectTransform)transform).sizeDelta / 2f;

		protected virtual void OnDrawGizmos()
		{
			GizmosHelper.DrawBox(min, max, Color.white);
		}
	}
}