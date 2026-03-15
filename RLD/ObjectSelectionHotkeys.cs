namespace RLD;

public class ObjectSelectionHotkeys : Settings
{
	[SerializeField]
	private Hotkeys _appendToSelection; //Field offset: 0x28
	[SerializeField]
	private Hotkeys _multiDeselect; //Field offset: 0x30
	[SerializeField]
	private Hotkeys _deleteSelected; //Field offset: 0x38
	[SerializeField]
	private Hotkeys _focusCameraOnSelection; //Field offset: 0x40
	[SerializeField]
	private Hotkeys _duplicateSelection; //Field offset: 0x48

	public Hotkeys AppendToSelection
	{
		 get { } //Length: 5
	}

	public Hotkeys DeleteSelected
	{
		 get { } //Length: 5
	}

	public Hotkeys DuplicateSelection
	{
		 get { } //Length: 5
	}

	public Hotkeys FocusCameraOnSelection
	{
		 get { } //Length: 5
	}

	public Hotkeys MultiDeselect
	{
		 get { } //Length: 95
	}

	public ObjectSelectionHotkeys() { }

	public Hotkeys get_AppendToSelection() { }

	public Hotkeys get_DeleteSelected() { }

	public Hotkeys get_DuplicateSelection() { }

	public Hotkeys get_FocusCameraOnSelection() { }

	public Hotkeys get_MultiDeselect() { }

}

