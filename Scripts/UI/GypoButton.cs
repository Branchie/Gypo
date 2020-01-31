namespace Gypo.UI
{
	using UnityEngine;
	using UnityEngine.Events;
	using UnityEngine.EventSystems;
	using UnityEngine.UI;

	public class GypoButton : MonoBehaviour, ICanvasRaycastFilter, IPointerDownHandler, IPointerUpHandler, IPointerEnterHandler, IPointerExitHandler
	{
		public enum State
		{
			Normal,

			Inactive,
			Highlighted,
			Pressed,
		}

		public event System.Action<State> onStateChanged = delegate { };

		[SerializeField] private Image image			= default;
		[SerializeField] private UnityEvent onClicked	= default;

		public State state
		{
			get => _state;
			private set
			{
				if (_state == value)
					return;

				_state = value;
				onStateChanged?.Invoke(_state);
			}
		}
		private State _state;

		public void OnPointerDown(PointerEventData eventData)
		{
			if (state == State.Pressed || state == State.Inactive)
				return;

			state = State.Pressed;
			eventData.Use();
		}

		public void OnPointerUp(PointerEventData eventData)
		{
			if (state != State.Pressed)
				return;

			state = State.Highlighted;
			onClicked?.Invoke();

			eventData.Use();
		}

		public void OnPointerEnter(PointerEventData eventData)
		{
			if (state != State.Normal && state != State.Inactive)
				return;

			state = State.Highlighted;
		}

		public void OnPointerExit(PointerEventData eventData)
		{
			if (state == State.Normal)
				return;

			state = State.Normal;
		}

		public void Reset()
		{
			if (image == null)
				image = GetComponentInChildren<Image>();
		}

		public bool TryGetImage(out Image result)
		{
			result = image;
			return result;
		}

		public Image GetImage() => image;

		public bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera) => image ? image.IsRaycastLocationValid(sp, eventCamera) : true;
	}
}