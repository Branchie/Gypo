namespace Gypo.Input.Standalone
{
	using UnityEngine;

	[System.Serializable]
	public class ButtonConfig : IButtonInput
	{
		[SerializeField] private Gamepad.Button[] buttons = default;
		[SerializeField] private KeyCode[] keys = default;

		private int controllerID = 0;

		public bool Get()
		{
			if (controllerID <= 0)
			{
				foreach (KeyCode key in keys)
					if (Input.GetKey(key))
						return true;
			}

			if (controllerID >= 0)
			{
				foreach (Gamepad.Button button in buttons)
					if (Gamepad.GetButton(button, controllerID))
						return true;
			}

			return false;
		}

		public void SetControllerID(int controllerID)
		{
			this.controllerID = controllerID;
		}
	}
}