//Type is in global namespace

public class PurchasesService : NetworkBehaviour
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass13_0
	{
		public int assetID; //Field offset: 0x10
		public string refId; //Field offset: 0x18

		public <>c__DisplayClass13_0() { }

		internal void <ShowPurchaseModal>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <DoProcessPurchase>d__18 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public PurchaseRequest request; //Field offset: 0x20
		public PurchasesService <>4__this; //Field offset: 0x40
		private bool <success>5__2; //Field offset: 0x48
		private string <message>5__3; //Field offset: 0x50
		private UnityWebRequest <uwr>5__4; //Field offset: 0x58

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
		public <DoProcessPurchase>d__18(int <>1__state) { }

		private void <>m__Finally1() { }

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

	[CompilerGenerated]
	private sealed class <ShowPurchaseModal>d__13 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public int assetID; //Field offset: 0x20
		public string refId; //Field offset: 0x28
		private <>c__DisplayClass13_0 <>8__1; //Field offset: 0x30
		public PurchasesService <>4__this; //Field offset: 0x38
		private UnityWebRequest <www>5__2; //Field offset: 0x40
		private string <assetName>5__3; //Field offset: 0x48
		private int <price>5__4; //Field offset: 0x50
		private UnityWebRequest <thumbnailRequest>5__5; //Field offset: 0x58
		private Button <purchaseButton>5__6; //Field offset: 0x60

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
		public <ShowPurchaseModal>d__13(int <>1__state) { }

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

	internal struct PurchaseRequest
	{
		public Player player; //Field offset: 0x0
		public int assetID; //Field offset: 0x8
		public int expectedPrice; //Field offset: 0xC
		public DynValue callback; //Field offset: 0x10
		public DateTime timestamp; //Field offset: 0x18

	}

	[CompilerGenerated]
	private static PurchasesService <Instance>k__BackingField; //Field offset: 0x0
	[SerializeField]
	private RectTransform purchaseModalPrefab; //Field offset: 0x68
	[SerializeField]
	private RectTransform purchaseResultPrefab; //Field offset: 0x70
	private string currentRefId; //Field offset: 0x78
	private Dictionary<String, PurchaseRequest> pendingPurchases; //Field offset: 0x80
	private bool readyToPurchase; //Field offset: 0x88
	private int currentExpectedPrice; //Field offset: 0x8C

	public private static PurchasesService Instance
	{
		[CompilerGenerated]
		 get { } //Length: 78
		[CompilerGenerated]
		private set { } //Length: 105
	}

	private static PurchasesService() { }

	public PurchasesService() { }

	private void Awake() { }

	public void CancelButton() { }

	private void CleanupExpiredPurchases() { }

	[Command(requiresAuthority = False)]
	private void CmdCancelPurchase(string refId) { }

	[Command(requiresAuthority = False)]
	private void CmdProcessPurchase(string refId, int expectedPrice) { }

	[TargetRpc]
	private void DispatchPurchase(NetworkConnection target, int assetID, string refId) { }

	[IteratorStateMachine(typeof(<DoProcessPurchase>d__18))]
	private IEnumerator DoProcessPurchase(PurchaseRequest request) { }

	[CompilerGenerated]
	public static PurchasesService get_Instance() { }

	protected static void InvokeUserCode_CmdCancelPurchase__String(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection) { }

	protected static void InvokeUserCode_CmdProcessPurchase__String__Int32(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection) { }

	protected static void InvokeUserCode_DispatchPurchase__NetworkConnection__Int32__String(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection) { }

	protected static void InvokeUserCode_TargetPurchaseResult__NetworkConnection__Boolean__String(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection) { }

	public void Prompt(Player player, int assetID, DynValue callback) { }

	public void PurchaseButton() { }

	[CompilerGenerated]
	private static void set_Instance(PurchasesService value) { }

	[IteratorStateMachine(typeof(<ShowPurchaseModal>d__13))]
	private IEnumerator ShowPurchaseModal(int assetID, string refId) { }

	private void ShowPurchaseResultUI(bool success, string message) { }

	[TargetRpc]
	private void TargetPurchaseResult(NetworkConnection target, bool success, string message) { }

	private void Update() { }

	protected void UserCode_CmdCancelPurchase__String(string refId) { }

	protected void UserCode_CmdProcessPurchase__String__Int32(string refId, int expectedPrice) { }

	protected void UserCode_DispatchPurchase__NetworkConnection__Int32__String(NetworkConnection target, int assetID, string refId) { }

	protected void UserCode_TargetPurchaseResult__NetworkConnection__Boolean__String(NetworkConnection target, bool success, string message) { }

	public virtual bool Weaved() { }

}

