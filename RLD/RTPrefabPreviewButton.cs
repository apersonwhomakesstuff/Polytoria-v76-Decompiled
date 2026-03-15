namespace RLD;

public class RTPrefabPreviewButton : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
{
	internal sealed class HoverEnterHandler : MulticastDelegate
	{

		public HoverEnterHandler(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(RTPrefab prefab, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(RTPrefab prefab) { }

	}

	internal sealed class HoverExitHandler : MulticastDelegate
	{

		public HoverExitHandler(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(RTPrefab prefab, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(RTPrefab prefab) { }

	}

	[CompilerGenerated]
	private HoverEnterHandler HoverEnter; //Field offset: 0x20
	[CompilerGenerated]
	private HoverExitHandler HoverExit; //Field offset: 0x28
	private Text _text; //Field offset: 0x30
	private RTPrefab _prefab; //Field offset: 0x38

	public event HoverEnterHandler HoverEnter
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public event HoverExitHandler HoverExit
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public RTPrefab Prefab
	{
		 get { } //Length: 5
		 set { } //Length: 19
	}

	public string Text
	{
		 get { } //Length: 155
		 set { } //Length: 148
	}

	public RTPrefabPreviewButton() { }

	[CompilerGenerated]
	public void add_HoverEnter(HoverEnterHandler value) { }

	[CompilerGenerated]
	public void add_HoverExit(HoverExitHandler value) { }

	public RTPrefab get_Prefab() { }

	public string get_Text() { }

	private void OnEnable() { }

	public override void OnPointerEnter(PointerEventData eventData) { }

	public override void OnPointerExit(PointerEventData eventData) { }

	[CompilerGenerated]
	public void remove_HoverEnter(HoverEnterHandler value) { }

	[CompilerGenerated]
	public void remove_HoverExit(HoverExitHandler value) { }

	public void set_Prefab(RTPrefab value) { }

	public void set_Text(string value) { }

}

