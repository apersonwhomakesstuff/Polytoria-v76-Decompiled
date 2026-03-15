namespace namudev;

public class PropertyGridTemplate : MonoBehaviour
{
	[SerializeField]
	private string type; //Field offset: 0x20

	public string Type
	{
		 get { } //Length: 5
	}

	public PropertyGridTemplate() { }

	public string get_Type() { }

}

