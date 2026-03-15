namespace RLD;

public class Plane2D
{
	private Vector2 _normal; //Field offset: 0x10
	private float _distance; //Field offset: 0x18

	public float Distance
	{
		 get { } //Length: 6
		 set { } //Length: 6
	}

	public Vector2 Normal
	{
		 get { } //Length: 19
		 set { } //Length: 59
	}

	public Plane2D(Vector2 normal, float distance) { }

	public Plane2D(Vector2 normal, Vector2 pointOnPlane) { }

	public float get_Distance() { }

	public Vector2 get_Normal() { }

	public float GetDistanceToPoint(Vector2 point) { }

	public bool Raycast(Vector2 rayOrigin, Vector2 rayDir, out float t) { }

	public void set_Distance(float value) { }

	public void set_Normal(Vector2 value) { }

}

