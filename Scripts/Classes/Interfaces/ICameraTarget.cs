namespace Gypo
{
	public interface ICameraTarget
	{
		void OnGainedCameraFocus(ICamera cam);
		void OnLostCameraFocus(ICamera cam);
	}
}