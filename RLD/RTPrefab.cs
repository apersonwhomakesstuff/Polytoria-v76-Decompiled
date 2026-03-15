namespace RLD;

public class RTPrefab
{
	[SerializeField]
	private GameObject _unityPrefab; //Field offset: 0x10
	[SerializeField]
	private Texture2D _previewTexture; //Field offset: 0x18
	private Sprite _previewSprite; //Field offset: 0x20

	public Sprite PreviewSprite
	{
		 get { } //Length: 421
	}

	public Texture2D PreviewTexture
	{
		 get { } //Length: 5
		 set { } //Length: 13
	}

	public GameObject UnityPrefab
	{
		 get { } //Length: 5
		 set { } //Length: 13
	}

	public RTPrefab() { }

	public Sprite get_PreviewSprite() { }

	public Texture2D get_PreviewTexture() { }

	public GameObject get_UnityPrefab() { }

	public GameObject Instantiate() { }

	public GameObject Instantiate(Vector3 worldPos, Quaternion worldRotation) { }

	public GameObject Instantiate(Vector3 worldPos, Quaternion worldRotation, Vector3 worldScale) { }

	public void set_PreviewTexture(Texture2D value) { }

	public void set_UnityPrefab(GameObject value) { }

}

