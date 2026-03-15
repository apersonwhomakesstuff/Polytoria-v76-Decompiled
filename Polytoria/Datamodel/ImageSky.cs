namespace Polytoria.Datamodel;

[Instantiatable]
public class ImageSky : SkyBase
{
	[CompilerGenerated]
	private sealed class <LoadSkyboxImage>d__35 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public ImageSky <>4__this; //Field offset: 0x20
		public ImageLoadQueueEntry entry; //Field offset: 0x28
		private UnityWebRequest <uwr>5__2; //Field offset: 0x38
		private UnityWebRequest <twr>5__3; //Field offset: 0x40

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <LoadSkyboxImage>d__35(int <>1__state) { }

		private void <>m__Finally1() { }

		private void <>m__Finally2() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	private struct ImageLoadQueueEntry
	{
		[CompilerGenerated]
		private string <TextureName>k__BackingField; //Field offset: 0x0
		[CompilerGenerated]
		private int <ImageId>k__BackingField; //Field offset: 0x8

		public int ImageId
		{
			[CompilerGenerated]
			[IsReadOnly]
			 get { } //Length: 4
			[CompilerGenerated]
			 set { } //Length: 4
		}

		public string TextureName
		{
			[CompilerGenerated]
			[IsReadOnly]
			 get { } //Length: 4
			[CompilerGenerated]
			 set { } //Length: 8
		}

		[CompilerGenerated]
		[IsReadOnly]
		public int get_ImageId() { }

		[CompilerGenerated]
		[IsReadOnly]
		public string get_TextureName() { }

		[CompilerGenerated]
		public void set_ImageId(int value) { }

		[CompilerGenerated]
		public void set_TextureName(string value) { }

	}

	private enum SkyboxSide : int
	{
		Top = 0,
		Bottom = 1,
		Left = 2,
		Right = 3,
		Front = 4,
		Back = 5,
	}

	private static readonly string topTextureName; //Field offset: 0x0
	private static readonly string bottomTextureName; //Field offset: 0x8
	private static readonly string leftTextureName; //Field offset: 0x10
	private static readonly string rightTextureName; //Field offset: 0x18
	private static readonly string frontTextureName; //Field offset: 0x20
	private static readonly string backTextureName; //Field offset: 0x28
	private bool processing; //Field offset: 0x100
	[SyncVar]
	private int topId; //Field offset: 0x104
	[SyncVar]
	private int bottomId; //Field offset: 0x108
	[SyncVar]
	private int leftId; //Field offset: 0x10C
	[SyncVar]
	private int rightId; //Field offset: 0x110
	[SyncVar]
	private int frontId; //Field offset: 0x114
	[SyncVar]
	private int backId; //Field offset: 0x118
	private Queue<ImageLoadQueueEntry> queue; //Field offset: 0x120

	[Archivable]
	[CreatorProperty]
	public int BackId
	{
		 get { } //Length: 7
		 set { } //Length: 368
	}

	[Archivable]
	[CreatorProperty]
	public int BottomId
	{
		 get { } //Length: 7
		 set { } //Length: 368
	}

	[Archivable]
	[CreatorProperty]
	public int FrontId
	{
		 get { } //Length: 7
		 set { } //Length: 368
	}

	[Archivable]
	[CreatorProperty]
	public int LeftId
	{
		 get { } //Length: 7
		 set { } //Length: 368
	}

	public int NetworkbackId
	{
		 get { } //Length: 7
		 set { } //Length: 177
	}

	public int NetworkbottomId
	{
		 get { } //Length: 7
		 set { } //Length: 177
	}

	public int NetworkfrontId
	{
		 get { } //Length: 7
		 set { } //Length: 177
	}

	public int NetworkleftId
	{
		 get { } //Length: 7
		 set { } //Length: 177
	}

	public int NetworkrightId
	{
		 get { } //Length: 7
		 set { } //Length: 177
	}

	public int NetworktopId
	{
		 get { } //Length: 7
		 set { } //Length: 177
	}

	[Archivable]
	[CreatorProperty]
	public int RightId
	{
		 get { } //Length: 7
		 set { } //Length: 368
	}

	[Archivable]
	[CreatorProperty]
	public int TopId
	{
		 get { } //Length: 7
		 set { } //Length: 364
	}

	private static ImageSky() { }

	public ImageSky() { }

	protected virtual void Apply() { }

	protected virtual void CopyProperties(Instance clone) { }

	public virtual void DeserializeSyncVars(NetworkReader reader, bool initialState) { }

	public int get_BackId() { }

	public int get_BottomId() { }

	public int get_FrontId() { }

	public int get_LeftId() { }

	public int get_NetworkbackId() { }

	public int get_NetworkbottomId() { }

	public int get_NetworkfrontId() { }

	public int get_NetworkleftId() { }

	public int get_NetworkrightId() { }

	public int get_NetworktopId() { }

	public int get_RightId() { }

	public int get_TopId() { }

	protected static void InvokeUserCode_RpcSetImageId__SkyboxSide__Int32(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection) { }

	[IteratorStateMachine(typeof(<LoadSkyboxImage>d__35))]
	private IEnumerator LoadSkyboxImage(ImageLoadQueueEntry entry) { }

	[ClientRpc]
	private void RpcSetImageId(SkyboxSide side, int id) { }

	public virtual void SerializeSyncVars(NetworkWriter writer, bool forceAll) { }

	public void set_BackId(int value) { }

	public void set_BottomId(int value) { }

	public void set_FrontId(int value) { }

	public void set_LeftId(int value) { }

	public void set_NetworkbackId(in int value) { }

	public void set_NetworkbottomId(in int value) { }

	public void set_NetworkfrontId(in int value) { }

	public void set_NetworkleftId(in int value) { }

	public void set_NetworkrightId(in int value) { }

	public void set_NetworktopId(in int value) { }

	public void set_RightId(int value) { }

	public void set_TopId(int value) { }

	protected virtual void Start() { }

	private void Update() { }

	protected void UserCode_RpcSetImageId__SkyboxSide__Int32(SkyboxSide side, int id) { }

	public virtual bool Weaved() { }

}

