namespace Polytoria.UI;

public class UICommandList : MonoBehaviour
{
	public static bool IsActive; //Field offset: 0x0
	public static SlashCommand ActiveCommand; //Field offset: 0x8
	public static bool ActiveCommandFilled; //Field offset: 0x10
	private Transform container; //Field offset: 0x20
	private Transform listContainer; //Field offset: 0x28
	private Transform emptyContainer; //Field offset: 0x30
	private ScrollRect scrollRect; //Field offset: 0x38
	public SlashCommand[] commands; //Field offset: 0x40
	private List<Transform> commandObjects; //Field offset: 0x48
	[SerializeField]
	private int curActive; //Field offset: 0x50

	public UICommandList() { }

	public void AddObject(SlashCommand cmd) { }

	private void Awake() { }

	public void Search(string Text) { }

	public void SetActive(bool active) { }

	private void Update() { }

}

