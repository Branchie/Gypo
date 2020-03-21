namespace Gypo
{
	using UnityEngine;

	public static partial class Extensions
	{
		public static void MulLocalScale_X(this Transform t, float x)
		{
			Vector3 localScale = t.localScale;
			localScale.x *= x;

			t.localScale = localScale;
		}

		public static void MulLocalScale_Y(this Transform t, float y)
		{
			Vector3 localScale = t.localScale;
			localScale.y *= y;

			t.localScale = localScale;
		}

		public static void MulLocalScale_Z(this Transform t, float z)
		{
			Vector3 localScale = t.localScale;
			localScale.z *= z;

			t.localScale = localScale;
		}

		public static void SetLocalScale_X(this Transform t, float x)
		{
			Vector3 localScale = t.localScale;
			localScale.x = x;

			t.localScale = localScale;
		}

		public static void SetLocalScale_Y(this Transform t, float y)
		{
			Vector3 localScale = t.localScale;
			localScale.y = y;

			t.localScale = localScale;
		}

		public static void SetLocalScale_Z(this Transform t, float z)
		{
			Vector3 localScale = t.localScale;
			localScale.z = z;

			t.localScale = localScale;
		}
	}
}