namespace RLD;

public abstract class GizmoScreenDrag : GizmoDragSession
{
	private bool _isSnapEnabled; //Field offset: 0x68
	private float _sensitivity; //Field offset: 0x6C
	protected InputDeviceScreenDragSession _screenDragSession; //Field offset: 0x70

	public virtual bool IsActive
	{
		 get { } //Length: 19
	}

	public bool IsSnapEnabled
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public float Sensitivity
	{
		 get { } //Length: 6
		 set { } //Length: 20
	}

	protected GizmoScreenDrag() { }

	protected bool CanSnap() { }

	protected virtual bool DoBeginSession() { }

	protected virtual void DoEndSession() { }

	protected virtual bool DoUpdateSession() { }

	public virtual bool get_IsActive() { }

	public bool get_IsSnapEnabled() { }

	public float get_Sensitivity() { }

	public void set_IsSnapEnabled(bool value) { }

	public void set_Sensitivity(float value) { }

}

