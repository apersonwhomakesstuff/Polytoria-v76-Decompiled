namespace RLD;

public class ObjectSelectionGizmosHotkeys : Settings
{
	[SerializeField]
	private Hotkeys _activateMoveGizmo; //Field offset: 0x28
	[SerializeField]
	private Hotkeys _activateRotationGizmo; //Field offset: 0x30
	[SerializeField]
	private Hotkeys _activateScaleGizmo; //Field offset: 0x38
	[SerializeField]
	private Hotkeys _activateBoxScaleGizmo; //Field offset: 0x40
	[SerializeField]
	private Hotkeys _activateUniversalGizmo; //Field offset: 0x48
	[SerializeField]
	private Hotkeys _activateExtrudeGizmo; //Field offset: 0x50
	[SerializeField]
	private Hotkeys _toggleTransformSpace; //Field offset: 0x58

	public Hotkeys ActivateBoxScaleGizmo
	{
		 get { } //Length: 5
	}

	public Hotkeys ActivateExtrudeGizmo
	{
		 get { } //Length: 5
	}

	public Hotkeys ActivateMoveGizmo
	{
		 get { } //Length: 5
	}

	public Hotkeys ActivateRotationGizmo
	{
		 get { } //Length: 95
	}

	public Hotkeys ActivateScaleGizmo
	{
		 get { } //Length: 5
	}

	public Hotkeys ActivateUniversalGizmo
	{
		 get { } //Length: 5
	}

	public Hotkeys ToggleTransformSpace
	{
		 get { } //Length: 5
	}

	public ObjectSelectionGizmosHotkeys() { }

	public Hotkeys get_ActivateBoxScaleGizmo() { }

	public Hotkeys get_ActivateExtrudeGizmo() { }

	public Hotkeys get_ActivateMoveGizmo() { }

	public Hotkeys get_ActivateRotationGizmo() { }

	public Hotkeys get_ActivateScaleGizmo() { }

	public Hotkeys get_ActivateUniversalGizmo() { }

	public Hotkeys get_ToggleTransformSpace() { }

}

