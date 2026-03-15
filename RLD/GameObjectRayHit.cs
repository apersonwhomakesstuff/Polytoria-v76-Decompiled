namespace RLD;

public class GameObjectRayHit
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Comparison<GameObjectRayHit> <>9__18_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal int <SortByHitDistance>b__18_0(GameObjectRayHit h0, GameObjectRayHit h1) { }

	}

	private GameObject _hitObject; //Field offset: 0x10
	private Vector3 _hitPoint; //Field offset: 0x18
	private float _hitEnter; //Field offset: 0x24
	private Vector3 _hitNormal; //Field offset: 0x28
	private Plane _hitPlane; //Field offset: 0x34
	private MeshRayHit _meshRayHit; //Field offset: 0x48

	public float HitEnter
	{
		 get { } //Length: 6
	}

	public Vector3 HitNormal
	{
		 get { } //Length: 19
	}

	public GameObject HitObject
	{
		 get { } //Length: 5
	}

	public Plane HitPlane
	{
		 get { } //Length: 11
	}

	public Vector3 HitPoint
	{
		 get { } //Length: 19
	}

	public MeshRayHit MeshRayHit
	{
		 get { } //Length: 5
	}

	public GameObjectRayHit(Ray hitRay, RaycastHit hit3D) { }

	public GameObjectRayHit(Ray hitRay, RaycastHit2D hit2D) { }

	public GameObjectRayHit(Ray hitRay, GameObject hitObject, Vector3 hitNormal, float hitEnter) { }

	public GameObjectRayHit(Ray ray, GameObject hitObject, MeshRayHit meshRayHit) { }

	public float get_HitEnter() { }

	public Vector3 get_HitNormal() { }

	public GameObject get_HitObject() { }

	public Plane get_HitPlane() { }

	public Vector3 get_HitPoint() { }

	public MeshRayHit get_MeshRayHit() { }

	public static void SortByHitDistance(List<GameObjectRayHit> hits) { }

	public static void Store(Ray hitRay, IEnumerable<RaycastHit2D> hits2D, IEnumerable<RaycastHit> hits3D, List<GameObjectRayHit> hits) { }

}

