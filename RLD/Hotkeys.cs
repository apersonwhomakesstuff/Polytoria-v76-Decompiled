namespace RLD;

public class Hotkeys
{
	private static List<KeyCode> _availableKeys; //Field offset: 0x0
	private const int _maxNumberOfKeys = 2; //Field offset: 0x0
	private static List<String> _availableKeyNames; //Field offset: 0x8
	[SerializeField]
	private bool _isEnabled; //Field offset: 0x10
	[SerializeField]
	private KeyCode _key; //Field offset: 0x14
	[SerializeField]
	private bool _lCtrl; //Field offset: 0x18
	[SerializeField]
	private bool _lCmd; //Field offset: 0x19
	[SerializeField]
	private bool _lAlt; //Field offset: 0x1A
	[SerializeField]
	private bool _lShift; //Field offset: 0x1B
	[SerializeField]
	private bool _useStrictModifierCheck; //Field offset: 0x1C
	[SerializeField]
	private bool _lMouseBtn; //Field offset: 0x1D
	[SerializeField]
	private bool _rMouseBtn; //Field offset: 0x1E
	[SerializeField]
	private bool _mMouseBtn; //Field offset: 0x1F
	[SerializeField]
	private bool _useStrictMouseCheck; //Field offset: 0x20
	[SerializeField]
	private string _name; //Field offset: 0x28
	private List<Hotkeys> _potentialOverlaps; //Field offset: 0x30
	[SerializeField]
	private HotkeysStaticData _staticData; //Field offset: 0x38

	public static List<String> AvailableKeyNames
	{
		 get { } //Length: 151
	}

	public static List<KeyCode> AvailableKeys
	{
		 get { } //Length: 150
	}

	public bool IsEnabled
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public KeyCode Key
	{
		 get { } //Length: 4
		 set { } //Length: 138
	}

	public bool LAlt
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public bool LCmd
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public bool LCtrl
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public bool LMouseButton
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public bool LShift
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public bool MMouseButton
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public string Name
	{
		 get { } //Length: 5
	}

	public bool RMouseButton
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public bool UseStrictModifierCheck
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public bool UseStrictMouseCheck
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	private static Hotkeys() { }

	public Hotkeys(string name) { }

	public Hotkeys(string name, HotkeysStaticData staticData) { }

	public void AddPotentialOverlap(Hotkeys hotkeys) { }

	public bool ContainsPotentialOverlap(Hotkeys hotkeys) { }

	public static void EstablishPotentialOverlaps(List<Hotkeys> hotkeysCollection) { }

	public static List<String> get_AvailableKeyNames() { }

	public static List<KeyCode> get_AvailableKeys() { }

	public bool get_IsEnabled() { }

	public KeyCode get_Key() { }

	public bool get_LAlt() { }

	public bool get_LCmd() { }

	public bool get_LCtrl() { }

	public bool get_LMouseButton() { }

	public bool get_LShift() { }

	public bool get_MMouseButton() { }

	public string get_Name() { }

	public bool get_RMouseButton() { }

	public bool get_UseStrictModifierCheck() { }

	public bool get_UseStrictMouseCheck() { }

	public List<KeyCode> GetAllUsedModifiers() { }

	public List<MouseButton> GetAllUsedMouseButtons() { }

	public int GetNumModifiers() { }

	public int GetNumMouseButtons() { }

	public bool HasNoKeys() { }

	public bool HasNoModifiers() { }

	public bool HasNoMouseButtons() { }

	public bool IsActive(bool checkForOverlaps = true) { }

	public bool IsActiveInFrame(bool checkForOverlaps = true) { }

	private bool IsAnyModifierKeyPressed() { }

	private bool IsAnyMouseButtonPressed() { }

	public bool IsEmpty() { }

	public bool IsOverlappedBy(Hotkeys hotkeys) { }

	public void set_IsEnabled(bool value) { }

	public void set_Key(KeyCode value) { }

	public void set_LAlt(bool value) { }

	public void set_LCmd(bool value) { }

	public void set_LCtrl(bool value) { }

	public void set_LMouseButton(bool value) { }

	public void set_LShift(bool value) { }

	public void set_MMouseButton(bool value) { }

	public void set_RMouseButton(bool value) { }

	public void set_UseStrictModifierCheck(bool value) { }

	public void set_UseStrictMouseCheck(bool value) { }

	public bool UsesModifiers(List<KeyCode> modifiers) { }

	public bool UsesMouseButtons(List<MouseButton> buttons) { }

}

