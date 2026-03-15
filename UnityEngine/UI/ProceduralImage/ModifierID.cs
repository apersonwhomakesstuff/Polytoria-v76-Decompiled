namespace UnityEngine.UI.ProceduralImage;

[AttributeUsage(AttributeTargets::Class (4))]
public class ModifierID : Attribute
{
	private string name; //Field offset: 0x10

	public string Name
	{
		 get { } //Length: 5
	}

	public ModifierID(string name) { }

	public string get_Name() { }

}

