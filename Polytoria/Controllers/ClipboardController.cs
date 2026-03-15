namespace Polytoria.Controllers;

public class ClipboardController : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Instance, Boolean> <>9__16_0; //Field offset: 0x8
		public static Func<Instance, Int32> <>9__16_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal bool <CopyInstancesToClipboard>b__16_0(Instance i) { }

		internal int <CopyInstancesToClipboard>b__16_1(Instance i) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass16_0
	{
		public int lowestLevel; //Field offset: 0x10

		public <>c__DisplayClass16_0() { }

		internal bool <CopyInstancesToClipboard>b__2(Instance i) { }

	}

	public static ClipboardController singleton; //Field offset: 0x0
	private const string CLIPBOARD_PREFIX = "POLYTORIA_CLIPBOARD:"; //Field offset: 0x0
	private const uint GMEM_MOVEABLE = 2; //Field offset: 0x0
	private const uint CF_UNICODETEXT = 13; //Field offset: 0x0

	public ClipboardController() { }

	private void Awake() { }

	private static bool CloseClipboard() { }

	private string CompressString(string text) { }

	public void CopyInstancesToClipboard(List<Instance> instances) { }

	private string DecompressString(string compressedText) { }

	private static bool EmptyClipboard() { }

	private static IntPtr GetClipboardData(uint uFormat) { }

	private static string GetClipboardText() { }

	private static IntPtr GlobalAlloc(uint flags, UIntPtr size) { }

	private static IntPtr GlobalFree(IntPtr hMem) { }

	private static IntPtr GlobalLock(IntPtr hMem) { }

	private static bool GlobalUnlock(IntPtr hMem) { }

	private static bool OpenClipboard(IntPtr hWndNewOwner) { }

	public void PasteInstancesFromClipboard(Instance targetParent = null) { }

	private static IntPtr SetClipboardData(uint uFormat, IntPtr data) { }

	private static void SetClipboardText(string text) { }

}

