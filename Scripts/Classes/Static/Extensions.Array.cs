namespace Gypo
{
	public static partial class Extensions
	{
		public static bool Contains<T>(this T[] arr, T element) where T : class
		{
			foreach (T e in arr)
			{
				if (ReferenceEquals(e, element))
					return true;
			}

			return false;
		}

		public static bool TryFindIndex<T>(this T[] arr, T element, out int result)
		{
			for (int i = 0; i < arr.Length; i++)
			{
				if (ReferenceEquals(arr[i], element))
				{
					result = i;
					return true;
				}
			}

			result = -1;
			return false;
		}
	}
}