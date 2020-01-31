namespace Gypo.UI.Editor
{
	using UnityEditor;

	[CustomEditor(typeof(GypoButton))]
	public class EditorGypoButton : Editor
	{
		private GypoButtonComponent[] components;

		public override void OnInspectorGUI()
		{
			TryDrawProperty("image");

			EditorGUILayout.Space();

			TryDrawProperty("onClicked");

			DisplayComponents();

			serializedObject.ApplyModifiedProperties();
		}

		private bool TryDrawProperty(string name)
		{
			SerializedProperty prop = serializedObject.FindProperty(name);

			if (prop == null)
			{
				EditorGUILayout.HelpBox($"Couldn't find serialized property '{name}'. Did you rename a variable? Make sure to update {GetType()}.", MessageType.Warning);
				return false;
			}

			return EditorGUILayout.PropertyField(prop);
		}

		private void DisplayComponents()
		{
			if (components == null)
				components = ((GypoButton)target).GetComponentsInChildren<GypoButtonComponent>();

			if (components.Length == 0)
				return;

			EditorGUILayout.Space();
			EditorGUILayout.HelpBox($"Addons: {components.ToSpacedCSV(c => c.GetType().Name)}", MessageType.None);
		}
	}
}