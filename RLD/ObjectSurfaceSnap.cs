namespace RLD;

public class ObjectSurfaceSnap
{
	private class MeshSurfaceRaycaster : SurfaceRaycaster
	{

		public MeshSurfaceRaycaster(GameObject surfaceObject, bool raycastReverse) { }

		public virtual GameObjectRayHit Raycast(Ray ray) { }

	}

	internal struct SnapConfig
	{
		public bool AlignAxis; //Field offset: 0x0
		public TransformAxis AlignmentAxis; //Field offset: 0x4
		public Type SurfaceType; //Field offset: 0x8
		public float OffsetFromSurface; //Field offset: 0xC
		public Vector3 SurfaceHitPoint; //Field offset: 0x10
		public Vector3 SurfaceHitNormal; //Field offset: 0x1C
		public Plane SurfaceHitPlane; //Field offset: 0x28
		public GameObject SurfaceObject; //Field offset: 0x38

		public bool IsSurfaceMesh() { }

	}

	internal struct SnapResult
	{
		public bool Success; //Field offset: 0x0
		public Plane SittingPlane; //Field offset: 0x4
		public Vector3 SittingPoint; //Field offset: 0x14

		public SnapResult(Plane sittingPlane, Vector3 sittingPoint) { }

	}

	private abstract class SurfaceRaycaster
	{
		protected GameObject _surfaceObject; //Field offset: 0x10
		protected bool _raycastReverse; //Field offset: 0x18

		public SurfaceRaycaster(GameObject surfaceObject, bool raycastReverse) { }

		public abstract GameObjectRayHit Raycast(Ray ray) { }

	}

	internal enum Type : int
	{
		UnityTerrain = 0,
		Mesh = 1,
		TerrainMesh = 2,
		SphericalMesh = 3,
		SceneGrid = 4,
	}


	public ObjectSurfaceSnap() { }

	public static Vector3 CalculateEmbedVector(List<Vector3> embedPoints, GameObject embedSurface, Vector3 embedDirection, Type surfaceType) { }

	public static Vector3 CalculateSitOnSurfaceOffset(OBB obb, Plane surfacePlane, float offsetFromSurface) { }

	public static Vector3 CalculateSitOnSurfaceOffset(AABB aabb, Plane surfacePlane, float offsetFromSurface) { }

	private static SurfaceRaycaster CreateSurfaceRaycaster(Type surfaceType, GameObject surfaceObject, bool raycastReverse) { }

	public static SnapResult SnapHierarchy(GameObject root, SnapConfig snapConfig) { }

}

