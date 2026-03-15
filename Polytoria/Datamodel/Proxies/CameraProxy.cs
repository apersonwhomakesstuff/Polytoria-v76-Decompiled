namespace Polytoria.Datamodel.Proxies;

public class CameraProxy : DynamicInstanceProxy
{
	private readonly Camera camera; //Field offset: 0x20

	public bool ClipThroughWalls
	{
		 get { } //Length: 30
		 set { } //Length: 29
	}

	public float Distance
	{
		 get { } //Length: 31
		 set { } //Length: 31
	}

	public float FastFlySpeed
	{
		 get { } //Length: 31
		 set { } //Length: 31
	}

	public float FlySpeed
	{
		 get { } //Length: 31
		 set { } //Length: 31
	}

	public bool FollowLerp
	{
		 get { } //Length: 30
		 set { } //Length: 29
	}

	public DynamicInstance FollowTarget
	{
		 get { } //Length: 30
		 set { } //Length: 30
	}

	public float FOV
	{
		 get { } //Length: 29
		 set { } //Length: 30
	}

	public float FreeLookSensitivity
	{
		 get { } //Length: 31
		 set { } //Length: 31
	}

	public float HorizontalSpeed
	{
		 get { } //Length: 31
		 set { } //Length: 31
	}

	public bool IsFirstPerson
	{
		 get { } //Length: 29
	}

	public float LerpSpeed
	{
		 get { } //Length: 31
		 set { } //Length: 31
	}

	public float MaxDistance
	{
		 get { } //Length: 31
		 set { } //Length: 31
	}

	public float MinDistance
	{
		 get { } //Length: 31
		 set { } //Length: 31
	}

	public CameraMode Mode
	{
		 get { } //Length: 29
		 set { } //Length: 29
	}

	public bool Orthographic
	{
		 get { } //Length: 29
		 set { } //Length: 30
	}

	public float OrthographicSize
	{
		 get { } //Length: 29
		 set { } //Length: 30
	}

	public Vector3 PositionOffset
	{
		 get { } //Length: 47
		 set { } //Length: 46
	}

	public Vector3 RotationOffset
	{
		 get { } //Length: 47
		 set { } //Length: 46
	}

	public float ScrollSensitivity
	{
		 get { } //Length: 31
		 set { } //Length: 31
	}

	public float SensitivityMultiplier
	{
		 get { } //Length: 31
		 set { } //Length: 31
	}

	public float VerticalSpeed
	{
		 get { } //Length: 31
		 set { } //Length: 31
	}

	[MoonSharpHidden]
	public CameraProxy(Camera target) { }

	public bool get_ClipThroughWalls() { }

	public float get_Distance() { }

	public float get_FastFlySpeed() { }

	public float get_FlySpeed() { }

	public bool get_FollowLerp() { }

	public DynamicInstance get_FollowTarget() { }

	public float get_FOV() { }

	public float get_FreeLookSensitivity() { }

	public float get_HorizontalSpeed() { }

	public bool get_IsFirstPerson() { }

	public float get_LerpSpeed() { }

	public float get_MaxDistance() { }

	public float get_MinDistance() { }

	public CameraMode get_Mode() { }

	public bool get_Orthographic() { }

	public float get_OrthographicSize() { }

	public Vector3 get_PositionOffset() { }

	public Vector3 get_RotationOffset() { }

	public float get_ScrollSensitivity() { }

	public float get_SensitivityMultiplier() { }

	public float get_VerticalSpeed() { }

	public void set_ClipThroughWalls(bool value) { }

	public void set_Distance(float value) { }

	public void set_FastFlySpeed(float value) { }

	public void set_FlySpeed(float value) { }

	public void set_FollowLerp(bool value) { }

	public void set_FollowTarget(DynamicInstance value) { }

	public void set_FOV(float value) { }

	public void set_FreeLookSensitivity(float value) { }

	public void set_HorizontalSpeed(float value) { }

	public void set_LerpSpeed(float value) { }

	public void set_MaxDistance(float value) { }

	public void set_MinDistance(float value) { }

	public void set_Mode(CameraMode value) { }

	public void set_Orthographic(bool value) { }

	public void set_OrthographicSize(float value) { }

	public void set_PositionOffset(Vector3 value) { }

	public void set_RotationOffset(Vector3 value) { }

	public void set_ScrollSensitivity(float value) { }

	public void set_SensitivityMultiplier(float value) { }

	public void set_VerticalSpeed(float value) { }

}

