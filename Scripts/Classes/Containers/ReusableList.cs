namespace Gypo
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public class ReusableList<T> : IEnumerable<T> where T : class
	{
		public event Action onChanged = delegate { };

		private T[] data;

		public int count { get; private set; }

		public T this[int index]
		{
			get => data[index];
			set => data[index] = value;
		}

		public ReusableList(int size)
		{
			data = new T[size];
		}

		public int Add(T item)
		{
			for (int i = 0; i < data.Length; i++)
			{
				if (data[i] == null)
				{
					data[i] = item;
					count++;

					onChanged();
					return i;
				}
			}

			return -1;
		}

		public bool Remove(T item)
		{
			if (!TryFindIndex(item, out int index))
				return false;

			data[index] = null;
			count--;

			onChanged();
			return true;
		}

		public bool TryFindIndex(T item, out int index)
		{
			for (int i = 0; i < data.Length; i++)
			{
				if (data[i] == item)
				{
					index = i;
					return true;
				}
			}

			index = -1;
			return false;
		}

		public bool Contains(T item)
		{
			foreach (T i in data)
			{
				if (Equals(item, i))
					return true;
			}

			return false;
		}

		public void Clear()
		{
			for (int i = 0; i < data.Length; i++)
				data[i] = null;

			count = 0;
			onChanged();
		}

		public IEnumerator<T> GetEnumerator() => ((IEnumerable<T>)data).GetEnumerator();
		IEnumerator IEnumerable.GetEnumerator() => ((IEnumerable<T>)data).GetEnumerator();
	}
}