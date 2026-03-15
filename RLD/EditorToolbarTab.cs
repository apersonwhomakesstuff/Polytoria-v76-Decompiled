namespace RLD;

public class EditorToolbarTab
{
	[SerializeField]
	private string _tooltip; //Field offset: 0x10
	[SerializeField]
	private string _text; //Field offset: 0x18
	private EditorToolbar _targetToolbar; //Field offset: 0x20
	private List<Settings> _targetSettings; //Field offset: 0x28

	public int NumTargetSettings
	{
		 get { } //Length: 60
	}

	public EditorToolbar TargetToolbar
	{
		 get { } //Length: 5
		 set { } //Length: 19
	}

	public string Text
	{
		 get { } //Length: 5
		 set { } //Length: 19
	}

	public string Tooltip
	{
		 get { } //Length: 5
		 set { } //Length: 19
	}

	public EditorToolbarTab(string text, string tooltip) { }

	public void AddTargetSettings(Settings targetSettings) { }

	public int get_NumTargetSettings() { }

	public EditorToolbar get_TargetToolbar() { }

	public string get_Text() { }

	public string get_Tooltip() { }

	public void set_TargetToolbar(EditorToolbar value) { }

	public void set_Text(string value) { }

	public void set_Tooltip(string value) { }

}

