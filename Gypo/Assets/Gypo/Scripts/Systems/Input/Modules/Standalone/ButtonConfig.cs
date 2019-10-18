namespace Gypo.Input.Standalone
{
	using UnityEngine;

	[System.Serializable]
	public class ButtonConfig : IButtonInput
	{
		[SerializeField] private KeyCode[] keys = default;

		public bool Get()
		{
			foreach (KeyCode key in keys)
				if (Input.GetKey(key))
					return true;

			return false;
		}
	}
}