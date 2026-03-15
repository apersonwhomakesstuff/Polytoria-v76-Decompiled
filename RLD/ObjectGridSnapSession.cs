namespace RLD;

public class ObjectGridSnapSession
{
	private enum State : int
	{
		Inactive = 0,
		SelectPivot = 1,
		Snap = 2,
	}

	[CompilerGenerated]
	private ObjectGridSnapSessionBeginHandler SessionBegin; //Field offset: 0x10
	[CompilerGenerated]
	private ObjectGridSnapSessionEndHandler SessionEnd; //Field offset: 0x18
	private List<GameObject> _targetParents; //Field offset: 0x20
	private List<GameObject> _targetObjects; //Field offset: 0x28
	private List<LocalTransformSnapshot> _preTargetTransformSnapshots; //Field offset: 0x30
	private Vector3 _snapPivotPoint; //Field offset: 0x38
	private State _state; //Field offset: 0x44
	private ObjectGridSnapHotkeys _sharedHotkeys; //Field offset: 0x48
	private ObjectGridSnapLookAndFeel _sharedLookAndFeel; //Field offset: 0x50

	public event ObjectGridSnapSessionBeginHandler SessionBegin
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public event ObjectGridSnapSessionEndHandler SessionEnd
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public bool IsActive
	{
		 get { } //Length: 8
	}

	public ObjectGridSnapHotkeys SharedHotkeys
	{
		 get { } //Length: 5
		 set { } //Length: 19
	}

	public ObjectGridSnapLookAndFeel SharedLookAndFeel
	{
		 get { } //Length: 5
		 set { } //Length: 19
	}

	public ObjectGridSnapSession() { }

	[CompilerGenerated]
	public void add_SessionBegin(ObjectGridSnapSessionBeginHandler value) { }

	[CompilerGenerated]
	public void add_SessionEnd(ObjectGridSnapSessionEndHandler value) { }

	private bool Begin(IEnumerable<GameObject> targetObjects) { }

	public void End() { }

	public bool get_IsActive() { }

	public ObjectGridSnapHotkeys get_SharedHotkeys() { }

	public ObjectGridSnapLookAndFeel get_SharedLookAndFeel() { }

	private QueryConfig GetObjectBoundsQConfig() { }

	private bool IdentifyTargetObjects(IEnumerable<GameObject> targetObjects) { }

	private bool IdentifyTargetParents(IEnumerable<GameObject> targetObjects) { }

	[CompilerGenerated]
	public void remove_SessionBegin(ObjectGridSnapSessionBeginHandler value) { }

	[CompilerGenerated]
	public void remove_SessionEnd(ObjectGridSnapSessionEndHandler value) { }

	public void Render(Camera renderCamera) { }

	private void SelectPivot() { }

	public void set_SharedHotkeys(ObjectGridSnapHotkeys value) { }

	public void set_SharedLookAndFeel(ObjectGridSnapLookAndFeel value) { }

	private void Snap() { }

	public void Update(IEnumerable<GameObject> targetObjects) { }

}

