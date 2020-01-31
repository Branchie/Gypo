namespace Gypo.UI
{
	using UnityEngine;
	using UnityEngine.UI;

	public class GypoButtonSpriteSwap : GypoButtonComponent
	{
		[SerializeField] private Sprite highlighted		= default;
		[SerializeField] private Sprite pressed			= default;
		[SerializeField] private Sprite disabled		= default;

		private Sprite defaultSprite;

		protected override void Subscribe()
		{
			if (target.TryGetImage(out Image image))
				defaultSprite = image.sprite;

			target.onStateChanged += OnStateUpdated;
		}

		protected override void Unsubscribe()
		{
			target.onStateChanged -= OnStateUpdated;
		}

		private void OnStateUpdated(GypoButton.State state)
		{
			if (!target.TryGetImage(out Image image))
				return;

			image.sprite = StateToSprite(state);
		}

		private Sprite StateToSprite(GypoButton.State state)
		{
			switch (state)
			{
				case GypoButton.State.Highlighted:
					return highlighted;

				case GypoButton.State.Inactive:
					return disabled;

				case GypoButton.State.Pressed:
					return pressed;

				default:
				case GypoButton.State.Normal:
					return defaultSprite;
			}
		}
	}
}