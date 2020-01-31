namespace Gypo
{
	using System;
	using System.Collections.Generic;
	using System.Text;

	public static partial class Extensions
	{
		public static T GetRandom<T>(this IList<T> l)
		{
			return l[UnityEngine.Random.Range(0, l.Count)];
		}

		public static string ToCSV<T>(this IList<T> l)								=> l.ToString(',');
		public static string ToCSV<T>(this IList<T> l, Func<T, string> str)			=> l.ToString(str, ',');
		public static string ToSpacedCSV<T>(this IList<T> l)						=> l.ToString(", ");
		public static string ToSpacedCSV<T>(this IList<T> l, Func<T, string> str)	=> l.ToString(str, ", ");
		public static string ToString<T>(this IList<T> l, char seperator)			=> l.ToString(i => i.ToString(), seperator);
		public static string ToString<T>(this IList<T> l, string seperator)			=> l.ToString(i => i.ToString(), seperator);

		public static string ToString<T>(this IList<T> l, Func<T, string> str, char seperator)
		{
			if (l.Count == 0)
				return "";

			StringBuilder builder = new StringBuilder(str(l[0]));

			for (int i = 1; i < l.Count; i++)
			{
				builder.Append(seperator);
				builder.Append(str(l[i]));
			}

			return builder.ToString();
		}

		public static string ToString<T>(this IList<T> l, Func<T, string> str, string seperator)
		{
			if (l.Count == 0)
				return "";

			StringBuilder builder = new StringBuilder(str(l[0]));

			for (int i = 1; i < l.Count; i++)
			{
				builder.Append(seperator);
				builder.Append(str(l[i]));
			}

			return builder.ToString();
		}
	}
}