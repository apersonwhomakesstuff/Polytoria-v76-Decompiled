namespace Polytoria.UI;

public class UISpeechBubble : MonoBehaviour
{
	private RectTransform chatContentRect; //Field offset: 0x20
	private RectTransform bubbleRect; //Field offset: 0x28
	private TMP_Text chatText; //Field offset: 0x30
	private string message; //Field offset: 0x38
	public Vector2 Padding; //Field offset: 0x40
	public float DisplayTime; //Field offset: 0x48
	private float targetOpacity; //Field offset: 0x4C
	private float timer; //Field offset: 0x50
	private CanvasGroup canvasGroup; //Field offset: 0x58

	public string Message
	{
		 get { } //Length: 5
		 set { } //Length: 202
	}

	public UISpeechBubble() { }

	private void Awake() { }

	public string get_Message() { }

	public void set_Message(string value) { }

	private void Update() { }

}

