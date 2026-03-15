namespace RLD;

public class RTUndoRedo : MonoSingleton<RTUndoRedo>
{
	private class ActionGroup
	{
		public List<IUndoRedoAction> Actions; //Field offset: 0x10

		public ActionGroup(IUndoRedoAction action) { }

	}

	[CompilerGenerated]
	private UndoStartHandler UndoStart; //Field offset: 0x20
	[CompilerGenerated]
	private UndoEndHandler UndoEnd; //Field offset: 0x28
	[CompilerGenerated]
	private RedoStartHandler RedoStart; //Field offset: 0x30
	[CompilerGenerated]
	private RedoEndHandler RedoEnd; //Field offset: 0x38
	[CompilerGenerated]
	private CanUndoRedoHandler CanUndoRedo; //Field offset: 0x40
	[SerializeField]
	private bool _isEnabled; //Field offset: 0x48
	[SerializeField]
	private int _actionLimit; //Field offset: 0x4C
	private List<ActionGroup> _actionGroupStack; //Field offset: 0x50
	private int _stackPointer; //Field offset: 0x58

	public event CanUndoRedoHandler CanUndoRedo
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public event RedoEndHandler RedoEnd
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public event RedoStartHandler RedoStart
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public event UndoEndHandler UndoEnd
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public event UndoStartHandler UndoStart
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public int ActionLimit
	{
		 get { } //Length: 4
		 set { } //Length: 105
	}

	public bool IsEnabled
	{
		 get { } //Length: 5
	}

	public RTUndoRedo() { }

	[CompilerGenerated]
	public void add_CanUndoRedo(CanUndoRedoHandler value) { }

	[CompilerGenerated]
	public void add_RedoEnd(RedoEndHandler value) { }

	[CompilerGenerated]
	public void add_RedoStart(RedoStartHandler value) { }

	[CompilerGenerated]
	public void add_UndoEnd(UndoEndHandler value) { }

	[CompilerGenerated]
	public void add_UndoStart(UndoStartHandler value) { }

	public void ClearActions() { }

	public int get_ActionLimit() { }

	public bool get_IsEnabled() { }

	private void OnValidate() { }

	public void RecordAction(IUndoRedoAction action) { }

	public void Redo() { }

	[CompilerGenerated]
	public void remove_CanUndoRedo(CanUndoRedoHandler value) { }

	[CompilerGenerated]
	public void remove_RedoEnd(RedoEndHandler value) { }

	[CompilerGenerated]
	public void remove_RedoStart(RedoStartHandler value) { }

	[CompilerGenerated]
	public void remove_UndoEnd(UndoEndHandler value) { }

	[CompilerGenerated]
	public void remove_UndoStart(UndoStartHandler value) { }

	private void RemoveGroups(int startIndex, int count) { }

	public void set_ActionLimit(int value) { }

	public void SetEnabled(bool isEnabled) { }

	public void Undo() { }

	public void Update_SystemCall() { }

}

