namespace RLD;

public abstract class Settings
{
	[SerializeField]
	private bool _canBeDisplayed; //Field offset: 0x10
	[SerializeField]
	protected bool _isExpanded; //Field offset: 0x11
	private string _foldoutLabel; //Field offset: 0x18
	[CompilerGenerated]
	private bool <UsesFoldout>k__BackingField; //Field offset: 0x20

	public bool CanBeDisplayed
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public string FoldoutLabel
	{
		 get { } //Length: 5
		 set { } //Length: 19
	}

	public bool IsExpanded
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public bool UsesFoldout
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	protected Settings() { }

	public bool get_CanBeDisplayed() { }

	public string get_FoldoutLabel() { }

	public bool get_IsExpanded() { }

	[CompilerGenerated]
	public bool get_UsesFoldout() { }

	public void set_CanBeDisplayed(bool value) { }

	public void set_FoldoutLabel(string value) { }

	public void set_IsExpanded(bool value) { }

	[CompilerGenerated]
	public void set_UsesFoldout(bool value) { }

}

