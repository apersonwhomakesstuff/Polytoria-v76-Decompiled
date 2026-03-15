namespace RLD;

public class GizmoScaleGuide
{
	private GizmoScaleGuideLookAndFeel _lookAndFeel; //Field offset: 0x10
	private GizmoScaleGuideLookAndFeel _sharedLookAndFeel; //Field offset: 0x18

	public GizmoScaleGuideLookAndFeel LookAndFeel
	{
		 get { } //Length: 17
	}

	public GizmoScaleGuideLookAndFeel SharedLookAndFeel
	{
		 get { } //Length: 5
		 set { } //Length: 13
	}

	public GizmoScaleGuide() { }

	public GizmoScaleGuideLookAndFeel get_LookAndFeel() { }

	public GizmoScaleGuideLookAndFeel get_SharedLookAndFeel() { }

	public void Render(IEnumerable<GameObject> gameObjects, Camera camera) { }

	public void set_SharedLookAndFeel(GizmoScaleGuideLookAndFeel value) { }

}

