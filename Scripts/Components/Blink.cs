namespace Gypo
{
	using UnityEngine;

	public class Blink : BlinkBase
	{
		private Renderer rend;

		private bool startEnabled;

		protected override void Awake()
		{
			rend = GetComponent<Renderer>();

			if (rend == null)
			{
				Destroy(this);
				return;
			}

			startEnabled = rend.enabled;

			base.Awake();
		}

		protected override void OnBlink()
		{
			rend.enabled = !rend.enabled;
		}

		public override void OnReset()
		{
			rend.enabled = startEnabled;

			base.OnReset();
		}
	}
}