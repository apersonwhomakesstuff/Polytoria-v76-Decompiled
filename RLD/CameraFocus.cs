namespace RLD;

public static class CameraFocus
{
	internal class Data
	{
		private Vector3 _cameraWorldPosition; //Field offset: 0x10
		private Vector3 _focusPoint; //Field offset: 0x1C
		private float _focusPointOffset; //Field offset: 0x28

		public Vector3 CameraWorldPosition
		{
			 get { } //Length: 19
		}

		public Vector3 FocusPoint
		{
			 get { } //Length: 19
		}

		public float FocusPointOffset
		{
			 get { } //Length: 6
		}

		public Data(Vector3 cameraWorldPosition, Vector3 focusPoint) { }

		public Vector3 get_CameraWorldPosition() { }

		public Vector3 get_FocusPoint() { }

		public float get_FocusPointOffset() { }

	}


	public static Data CalculateFocusData(Camera camera, AABB focusAABB, CameraFocusSettings focusSettings) { }

}

