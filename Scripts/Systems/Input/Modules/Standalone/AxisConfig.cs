namespace Gypo.Input.Standalone
{
	using UnityEngine;

	[System.Serializable]
	public class AxisConfig : IAxisInput
	{
		[SerializeField] private Gamepad.Axis[] axis = default;
		[SerializeField] private GamepadButtonAxis[] buttons = default;
		[SerializeField] private KeyCodeAxis[] keys = default;
		[SerializeField] private string[] raw = default;

		private int controllerID = 0;

		public float Get()
		{
			float val = 0;

			if (controllerID <= 0)
			{
				// KeyCodes
				foreach (KeyCodeAxis key in keys)
					val += key.Get();
			}

			if (controllerID >= 0)
			{
				// Gamepad Axis
				foreach (Gamepad.Axis a in axis)
					val += Gamepad.GetAxis(a, controllerID);

				// Gamepad Buttons
				foreach (GamepadButtonAxis button in buttons)
					val += button.Get();
			}

			val = Mathf.Clamp(val, -1, 1);

			if (controllerID <= 0)
			{
				// Raw Axis
				foreach (string r in raw)
					val += Input.GetAxisRaw(r);
			}

			return val;
		}

		public void SetControllerID(int controllerID)
		{
			this.controllerID = controllerID;

			foreach (GamepadButtonAxis button in buttons)
				button.SetControllerID(controllerID);
		}
	}
}