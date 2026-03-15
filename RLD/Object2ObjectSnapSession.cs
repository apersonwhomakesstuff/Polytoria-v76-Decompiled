namespace RLD;

public class Object2ObjectSnapSession
{
	private struct SitSurface
	{
		public SitSurfaceType SurfaceType; //Field offset: 0x0
		public Vector3 SitPoint; //Field offset: 0x4
		public Plane SitPlane; //Field offset: 0x10

	}

	private enum SitSurfaceType : int
	{
		Invalid = 0,
		Grid = 1,
		Object = 2,
	}

	private enum State : int
	{
		Inactive = 0,
		Active = 1,
	}

	[CompilerGenerated]
	private Object2ObjectSnapSessionBeginHandler SessionBegin; //Field offset: 0x10
	[CompilerGenerated]
	private Object2ObjectSnapSessionEndHandler SessionEnd; //Field offset: 0x18
	private State _state; //Field offset: 0x20
	private List<GameObject> _targetObjects; //Field offset: 0x28
	private List<GameObject> _targetParents; //Field offset: 0x30
	private AABB _targetAABB; //Field offset: 0x38
	private SitSurface _sitSurface; //Field offset: 0x54
	private bool _sitBelowSurface; //Field offset: 0x74
	private Object2ObjectSnapSettings _sharedSettings; //Field offset: 0x78
	private Object2ObjectSnapHotkeys _sharedHotkeys; //Field offset: 0x80
	private List<LocalTransformSnapshot> _preTargetTransformSnapshots; //Field offset: 0x88

	public event Object2ObjectSnapSessionBeginHandler SessionBegin
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public event Object2ObjectSnapSessionEndHandler SessionEnd
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

	public Object2ObjectSnapHotkeys SharedHotkeys
	{
		 get { } //Length: 8
		 set { } //Length: 22
	}

	public Object2ObjectSnapSettings SharedSettings
	{
		 get { } //Length: 5
		 set { } //Length: 19
	}

	public Object2ObjectSnapSession() { }

	[CompilerGenerated]
	public void add_SessionBegin(Object2ObjectSnapSessionBeginHandler value) { }

	[CompilerGenerated]
	public void add_SessionEnd(Object2ObjectSnapSessionEndHandler value) { }

	private bool Begin(IEnumerable<GameObject> targetObjects) { }

	private bool CalculateTargetAABB() { }

	public void End() { }

	public bool get_IsActive() { }

	public Object2ObjectSnapHotkeys get_SharedHotkeys() { }

	public Object2ObjectSnapSettings get_SharedSettings() { }

	private bool IdentifySitSurface() { }

	[CompilerGenerated]
	public void remove_SessionBegin(Object2ObjectSnapSessionBeginHandler value) { }

	[CompilerGenerated]
	public void remove_SessionEnd(Object2ObjectSnapSessionEndHandler value) { }

	public void set_SharedHotkeys(Object2ObjectSnapHotkeys value) { }

	public void set_SharedSettings(Object2ObjectSnapSettings value) { }

	private void SnapTargets() { }

	public void Update(IEnumerable<GameObject> targetObjects) { }

}

