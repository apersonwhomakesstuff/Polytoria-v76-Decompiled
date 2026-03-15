namespace Polytoria.Controllers;

public class CreatorThumbnailGenerator : MonoBehaviour
{
	[SerializeField]
	private RawImage preview; //Field offset: 0x20
	[SerializeField]
	private int width; //Field offset: 0x28
	[SerializeField]
	private int height; //Field offset: 0x2C
	[SerializeField]
	private float _padding; //Field offset: 0x30
	[SerializeField]
	private Camera thumbnailCamera; //Field offset: 0x38
	private Dictionary<GameObject, Int32> oldLayers; //Field offset: 0x40

	public CreatorThumbnailGenerator() { }

	private static void FindClosestPointsOnTwoLines(Ray line1, Ray line2, out Vector3 closestPointLine1, out Vector3 closestPointLine2) { }

	public Texture2D GenerateThumbnail(Instance instance) { }

	private static Ray GetPlanesIntersection(Plane p1, Plane p2) { }

	private static bool IsOutermostPointInDirection(int pointIndex, Vector3 direction, Vector3[] boundingBoxPoints) { }

	public void PositionCamera(Camera camera, Bounds bounds, float padding = 0) { }

	private void SetLayer(Instance i, int layer) { }

	public void TestRender() { }

}

