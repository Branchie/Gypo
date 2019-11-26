namespace Gypo
{
	using UnityEngine.UI;

	public class BlinkUI : BlinkBase
	{
		private Graphic graphic;

		private bool startEnabled;

		protected override void Awake()
		{
			graphic = GetComponent<Graphic>();

			if (graphic == null)
			{
				Destroy(this);
				return;
			}

			startEnabled = graphic.enabled;

			base.Awake();
		}

		protected override void OnBlink()
		{
			graphic.enabled = !graphic.enabled;
		}

		public override void OnReset()
		{
			graphic.enabled = startEnabled;

			base.OnReset();
		}
	}
}