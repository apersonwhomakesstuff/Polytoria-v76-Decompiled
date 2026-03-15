namespace RLD;

public class RTHoveredPrefabNameLabel : MonoBehaviour
{
	private Text _label; //Field offset: 0x20

	public string PrefabName
	{
		 get { } //Length: 42
		 set { } //Length: 52
	}

	public RTHoveredPrefabNameLabel() { }

	private void Awake() { }

	public string get_PrefabName() { }

	public void set_PrefabName(string value) { }

}

