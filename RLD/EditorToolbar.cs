namespace RLD;

public class EditorToolbar
{
	[SerializeField]
	private Color _activeTabColor; //Field offset: 0x10
	[SerializeField]
	private int _numTabsPerRow; //Field offset: 0x20
	[SerializeField]
	private EditorToolbarTab[] _tabs; //Field offset: 0x28
	[SerializeField]
	private int _activeTabIndex; //Field offset: 0x30

	public EditorToolbarTab ActiveTab
	{
		 get { } //Length: 43
	}

	public Color ActiveTabColor
	{
		 get { } //Length: 11
		 set { } //Length: 8
	}

	public int ActiveTabIndex
	{
		 get { } //Length: 174
	}

	public int NumTabs
	{
		 get { } //Length: 26
	}

	public int NumTabsPerRow
	{
		 get { } //Length: 4
		 set { } //Length: 16
	}

	public EditorToolbar(EditorToolbarTab[] tabs, int numTabsPerRow, Color activeTabColor) { }

	public EditorToolbarTab get_ActiveTab() { }

	public Color get_ActiveTabColor() { }

	public int get_ActiveTabIndex() { }

	public int get_NumTabs() { }

	public int get_NumTabsPerRow() { }

	public EditorToolbarTab GetTabByIndex(int tabIndex) { }

	public void set_ActiveTabColor(Color value) { }

	public void set_NumTabsPerRow(int value) { }

}

