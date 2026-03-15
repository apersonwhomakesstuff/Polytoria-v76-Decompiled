namespace RLD;

public class UniversalGizmoConfig : Settings
{
	[SerializeField]
	private UniversalGizmoSettingsCategory _inheritCategory; //Field offset: 0x28
	[SerializeField]
	private UniversalGizmoSettingsType _inheritType; //Field offset: 0x2C
	[SerializeField]
	private UniversalGizmoSettingsCategory _displayCategory; //Field offset: 0x30

	public UniversalGizmoSettingsCategory DisplayCategory
	{
		 get { } //Length: 174
		 set { } //Length: 4
	}

	public UniversalGizmoSettingsCategory InheritCategory
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public UniversalGizmoSettingsType InheritType
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public UniversalGizmoConfig() { }

	public UniversalGizmoSettingsCategory get_DisplayCategory() { }

	public UniversalGizmoSettingsCategory get_InheritCategory() { }

	public UniversalGizmoSettingsType get_InheritType() { }

	public void set_DisplayCategory(UniversalGizmoSettingsCategory value) { }

	public void set_InheritCategory(UniversalGizmoSettingsCategory value) { }

	public void set_InheritType(UniversalGizmoSettingsType value) { }

}

