namespace Polytoria.Controllers;

public class LoadScreenController : MonoBehaviour
{
	public static LoadScreenController singleton; //Field offset: 0x0
	[SerializeField]
	private Image progressBar; //Field offset: 0x20
	[SerializeField]
	private GameObject progressBarContainer; //Field offset: 0x28
	[SerializeField]
	private TMP_Text gameName; //Field offset: 0x30
	[SerializeField]
	private TMP_Text loadingStatus; //Field offset: 0x38
	[CompilerGenerated]
	private bool <IsLoadingMap>k__BackingField; //Field offset: 0x40

	public bool IsLoadingMap
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public LoadScreenController() { }

	private void Awake() { }

	public void GameLoaded() { }

	[CompilerGenerated]
	public bool get_IsLoadingMap() { }

	[CompilerGenerated]
	public void set_IsLoadingMap(bool value) { }

	public void SetGameInfo(string name) { }

	public void SetStatus(string status) { }

	private void Start() { }

	private void Update() { }

}

