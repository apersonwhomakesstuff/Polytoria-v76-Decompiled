namespace RLD;

[Extension]
public static class CameraEx
{
	private static List<GameObject> _objectBuffer; //Field offset: 0x0

	private static CameraEx() { }

	[Extension]
	public static AABB CalculateFrustumAABB(Camera camera) { }

	[Extension]
	public static AABB CalculateOrthoAABB(Camera camera) { }

	[Extension]
	public static AABB CalculateVolumeAABB(Camera camera) { }

	[Extension]
	public static List<Vector2> ConvertWorldToScreenPoints(Camera camera, List<Vector3> worldPoints) { }

	[Extension]
	public static float EstimateZoomFactor(Camera camera, Vector3 worldPos) { }

	[Extension]
	public static float EstimateZoomFactorSpherical(Camera camera, Vector3 worldPos) { }

	[Extension]
	public static Vector3 GetFarMidOrthoTop(Camera camera) { }

	[Extension]
	public static Vector3 GetFarMidPoint(Camera camera) { }

	[Extension]
	public static float GetFOVFromDistanceAndHeight(Camera camera, float frustumHeight, float distance) { }

	[Extension]
	public static float GetFrustumDistanceFromHeight(Camera camera, float frustumHeight) { }

	[Extension]
	public static float GetFrustumHeightFromDistance(Camera camera, float distance) { }

	[Extension]
	public static float GetFrustumWidthFromDistance(Camera camera, float distance) { }

	[Extension]
	public static Plane GetNearPlaneForward(Camera camera) { }

	[Extension]
	public static float GetOrthoFOV(Camera camera) { }

	[Extension]
	public static float GetPointZDistance(Camera camera, Vector3 point) { }

	[Extension]
	public static void GetVisibleObjects(Camera camera, CameraViewVolume viewVolume, List<GameObject> visibleObjects) { }

	[Extension]
	public static List<Vector3> GetVisibleSphereExtents(Camera camera, Sphere sphere) { }

	[Extension]
	public static bool IsCurrent(Camera camera) { }

	[Extension]
	public static bool IsPointFacingCamera(Camera camera, Vector3 point, Vector3 pointNormal) { }

	[Extension]
	public static bool IsPointInFrontNearPlane(Camera camera, Vector3 position) { }

	[Extension]
	public static float ScreenToEstimatedWorldSize(Camera camera, Vector3 worldPos, float screenSize) { }

}

