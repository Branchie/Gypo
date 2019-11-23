namespace Gypo.Input.Standalone
{
	using UnityEngine;

	[System.Serializable]
	public class GamepadButtonAxis : IAxisInput
	{
		[SerializeField] private Gamepad.Button negative = default;
		[SerializeField] private Gamepad.Button positive = default;

		private int controllerID = 0;

		public float Get()
		{
			float val = 0;

			if (Gamepad.GetButton(negative, controllerID))
				val -= 1;

			if (Gamepad.GetButton(positive, controllerID))
				val += 1;

			return val;
		}

		public void SetControllerID(int controllerID)
		{
			this.controllerID = controllerID;
		}
	}
}

#if UNITY_EDITOR

namespace Gypo.Input.Standalone.Editor
{
	using UnityEditor;
	using UnityEngine;

	[CustomPropertyDrawer(typeof(GamepadButtonAxis), true)]
	public class EditorGamepadButtonAxis : PropertyDrawer
	{
		public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
		{
			EditorGUI.indentLevel++;
			EditorGUIUtility.labelWidth = (EditorGUI.indentLevel * 24) - 24;

			SerializedProperty negative = property.FindPropertyRelative("negative");
			SerializedProperty positive = property.FindPropertyRelative("positive");
			Rect r = position;

			r.width /= 2;
			EditorGUI.PropertyField(r, negative, new GUIContent("-"));

			r.x += r.width;
			EditorGUI.PropertyField(r, positive, new GUIContent("+"));
		}
	}
}

#endif