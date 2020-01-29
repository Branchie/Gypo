namespace Gypo.Editor
{
	using UnityEditor;

	public static class Reserializer
	{
		[MenuItem("Assets/Reserialize All")]
		public static void ReserializeAll()
		{
			AssetDatabase.ForceReserializeAssets();
		}
	}
}