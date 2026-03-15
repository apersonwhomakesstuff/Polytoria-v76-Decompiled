namespace RLD;

public class GizmoRotationArc3D
{
	private ArcShape3D _arc; //Field offset: 0x10

	public float Radius
	{
		 get { } //Length: 28
		 set { } //Length: 30
	}

	public float RotationAngle
	{
		 get { } //Length: 28
		 set { } //Length: 30
	}

	public GizmoRotationArc3D() { }

	public float get_Radius() { }

	public float get_RotationAngle() { }

	public void Render(GizmoRotationArc3DLookAndFeel lookAndFeel) { }

	public void set_Radius(float value) { }

	public void set_RotationAngle(float value) { }

	public void SetArcData(Vector3 rotationAxis, Vector3 arcOrigin, Vector3 arcStart, float radius) { }

}

