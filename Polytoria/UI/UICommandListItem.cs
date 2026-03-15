namespace Polytoria.UI;

public class UICommandListItem : MonoBehaviour
{
	private static List<Sprite> commandIcons; //Field offset: 0x0
	private static List<Sprite> commandIconsActive; //Field offset: 0x8
	private static Sprite contSprite; //Field offset: 0x10
	private static Sprite contSpriteActive; //Field offset: 0x18
	private static bool loaded; //Field offset: 0x20
	private Image cont; //Field offset: 0x20
	private Image icon; //Field offset: 0x28
	private TMP_Text nameT; //Field offset: 0x30
	private TMP_Text description; //Field offset: 0x38
	private SlashCommand cmd; //Field offset: 0x40
	private bool active; //Field offset: 0x48

	private static UICommandListItem() { }

	public UICommandListItem() { }

	private void Awake() { }

	public void SetActive(bool active) { }

	public void SetCommand(SlashCommand cmd) { }

}

