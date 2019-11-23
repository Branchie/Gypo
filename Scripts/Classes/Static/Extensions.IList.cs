namespace Gypo
{
	using System.Collections.Generic;
	using System.Text;
	using UnityEngine;

	public static partial class Extensions
	{
		public static T GetRandom<T>(this IList<T> l)
		{
			return l[Random.Range(0, l.Count)];
		}

		public static string ToCSV<T>(this IList<T> l) => l.ToString(',');
		public static string ToSpacedCSV<T>(this IList<T> l) => l.ToString(", ");
		public static string ToString<T>(this IList<T> l, char seperator)
		{
			if (l.Count == 0)
				return "";

			StringBuilder builder = new StringBuilder(l[0].ToString());

			for (int i = 1; i < l.Count; i++)
			{
				builder.Append(seperator);
				builder.Append(l[i].ToString());
			}

			return builder.ToString();
		}

		public static string ToString<T>(this IList<T> l, string seperator)
		{
			if (l.Count == 0)
				return "";

			StringBuilder builder = new StringBuilder(l[0].ToString());

			for (int i = 1; i < l.Count; i++)
			{
				builder.Append(seperator);
				builder.Append(l[i].ToString());
			}

			return builder.ToString();
		}
	}
}