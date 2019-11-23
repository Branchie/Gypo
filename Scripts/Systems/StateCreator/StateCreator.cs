namespace Gypo.Editor.StateCreator
{
	using System.Collections.Generic;
	using System.IO;
	using System.Text;
	using UnityEditor;
	using UnityEngine;

	public class StateCreator : EditorWindow
	{
		[System.Serializable]
		public class Templates
		{
			public TextAsset controller;
			public TextAsset logic;
			public TextAsset state;
			public TextAsset states;

			public void Load()
			{
				controller	= Load<TextAsset>(Constants.GUID_TEMPLATE_CONTROLLER);
				logic		= Load<TextAsset>(Constants.GUID_TEMPLATE_LOGIC);
				state		= Load<TextAsset>(Constants.GUID_TEMPLATE_STATE);
				states		= Load<TextAsset>(Constants.GUID_TEMPLATE_STATES);
			}

			private T Load<T>(string guid) where T : Object => AssetDatabase.LoadAssetAtPath<T>(AssetDatabase.GUIDToAssetPath(guid));
		}

		[SerializeField] private Templates templates;

		[SerializeField] private string className = "Class";
		[SerializeField] private string nameSpace = "Gypo.{PATH}";
		[SerializeField] private string path = "Actors/{CLASS_NAME}";
		[SerializeField] private string[] states =
		{
			"Input",
			"Graphic",
			"Gravity",
			"Motor",
			"Movement",
		};

		private void OnGUI()
		{
			if (templates == null)
			{
				templates = new Templates();
				templates.Load();
			}

			SerializedObject serializedObject = new SerializedObject(this);

			className = EditorGUILayout.TextField("Class Name", className);
			nameSpace = EditorGUILayout.TextField("Namespace", nameSpace);
			path = EditorGUILayout.TextField("Path", path);

			DrawArray(serializedObject, "states");

			if (GUILayout.Button("Generate"))
				Generate();

			DrawArray(serializedObject, "templates");
			serializedObject.ApplyModifiedProperties();
		}

		private void Generate()
		{
			System.Array.Sort(states);

			Generate_Controller();
			Generate_Logic();

			for (int i = 0; i < states.Length; i++)
				Generate_State(states[i]);

			Generate_States();
		}

		private void Generate_Controller()
		{
			string text = templates.controller.text;

			text = ReplaceAll(text, "#NAMESPACE#", FormatNamespace(nameSpace));
			text = ReplaceAll(text, "#ROOT_NAME#", Format(className));

			Write($"{className}Controller", text);
		}

		private void Generate_Logic()
		{
			string text = templates.logic.text;

			text = ReplaceAll(text, "#NAMESPACE#", FormatNamespace(nameSpace));
			text = ReplaceAll(text, "#ROOT_NAME#", Format(className));

			List<string> lines = new List<string>(text.Split('\n'));
			ReplaceLine_State(ref lines, "#STATE_CONDITION#",	s => $"public bool allow{s} => true");
			ReplaceLine_State(ref lines, "#STATE_SET_ACTIVE#",	s => $"CharacterStateBase.SetActive(states.{ToCamelCase(s)}, allow{s})");
			ReplaceLine_State(ref lines, "#STATE_UPDATE#",		s => $"CharacterStateBase.UpdateState(states.{ToCamelCase(s)})");

			text = LinesToText(lines);
			Write($"{className}Logic", text);
		}

		private void Generate_State(string stateName)
		{
			string text = templates.state.text;

			text = ReplaceAll(text, "#NAMESPACE#",			FormatNamespace(nameSpace));
			text = ReplaceAll(text, "#ROOT_NAME#",			Format(className));
			text = ReplaceAll(text, "#STATE_NAME#",			Format(stateName));
			text = ReplaceAll(text, "#STATE_NAME_LOWER#",	FormatLower(stateName));

			Write($"{className}{stateName}", text);
		}

		private void Generate_States()
		{
			string text = templates.states.text;

			text = ReplaceAll(text, "#NAMESPACE#", FormatNamespace(nameSpace));
			text = ReplaceAll(text, "#ROOT_NAME#", Format(className));

			List<string> lines = new List<string>(text.Split('\n'));
			ReplaceLine_State(ref lines, "#STATE#", s => $"public {className}{s} {ToCamelCase(s)}");

			text = LinesToText(lines);
			Write($"{className}States", text);
		}

		private void ReplaceLine_State(ref List<string> lines, string condition, System.Func<string, string> action)
		{
			for (int i = lines.Count - 1; i >= 0; i--)
			{
				string line = lines[i];

				if (line.Contains(condition))
				{
					lines.RemoveAt(i);

					for (int j = states.Length - 1; j >= 0; j--)
						lines.Insert(i, line.Replace(condition, action(states[j])));

					break;
				}
			}
		}

		private string Format(string s)
		{
			s = ReplaceAll(s, "{PATH}", path);
			s = ReplaceAll(s, "{CLASS_NAME}", className);

			return s;
		}

		private string FormatNamespace(string s)
		{
			return ReplaceAll(Format(s), "/", ".");
		}

		private string FormatLower(string s)
		{
			return ToCamelCase(Format(s));
		}

		private string ToCamelCase(string s)
		{
			if (string.IsNullOrEmpty(s))
				return "";

			if (char.IsUpper(s[0]))
				return char.ToLower(s[0]) + s.Substring(1, s.Length - 1);

			return s;
		}

		private string LinesToText(IList<string> lines)
		{
			if (lines == null || lines.Count == 0)
				return "";

			StringBuilder builder = new StringBuilder(lines[0]);

			for (int i = 1; i < lines.Count; i++)
			{
				builder.Append("\n");
				builder.Append(lines[i]);
			}

			return builder.ToString();
		}

		private string ReplaceAll(string text, string from, string to)
		{
			while (text.Contains(from))
				text = text.Replace(from, to);

			return text;
		}

		private void Write(string name, string text)
		{
			string path = $"{ReplaceAll(Application.dataPath, "\\", "/")}/{Format(this.path)}";
			string filePath = $"{path}/{name}.cs";

			if (!Directory.Exists(path))
				Directory.CreateDirectory(path);

			if (File.Exists(filePath))
				File.Delete(filePath);

			File.WriteAllText(filePath, text, Encoding.Unicode);
			AssetDatabase.Refresh();

			Debug.Log($"{name}\n\n{text}");
		}

		private void DrawArray(SerializedObject serializedObject, string propertyName)
		{
			SerializedProperty t = serializedObject.FindProperty(propertyName);
			EditorGUILayout.PropertyField(t, true);
		}

		[MenuItem("Gypo/StateCreator")]
		private static void ShowMe()
		{
			GetWindow<StateCreator>();
		}
	}
}