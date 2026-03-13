using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Polytoria.Datamodel;
using UnityEngine;

namespace Polytoria.Controllers
{
	// Token: 0x02000325 RID: 805
	public class ClipboardController : MonoBehaviour
	{
		// Token: 0x06002819 RID: 10265 RVA: 0x0001CB03 File Offset: 0x0001AD03
		private void Awake()
		{
		}

		// Token: 0x0600281A RID: 10266
		[PreserveSig]
		private static extern bool OpenClipboard(IntPtr hWndNewOwner);

		// Token: 0x0600281B RID: 10267
		[PreserveSig]
		private static extern bool CloseClipboard();

		// Token: 0x0600281C RID: 10268
		[PreserveSig]
		private static extern bool EmptyClipboard();

		// Token: 0x0600281D RID: 10269
		[PreserveSig]
		private static extern IntPtr SetClipboardData(uint uFormat, IntPtr data);

		// Token: 0x0600281E RID: 10270
		[PreserveSig]
		private static extern IntPtr GetClipboardData(uint uFormat);

		// Token: 0x0600281F RID: 10271
		[PreserveSig]
		private static extern IntPtr GlobalAlloc(uint flags, UIntPtr size);

		// Token: 0x06002820 RID: 10272
		[PreserveSig]
		private static extern IntPtr GlobalLock(IntPtr hMem);

		// Token: 0x06002821 RID: 10273
		[PreserveSig]
		private static extern bool GlobalUnlock(IntPtr hMem);

		// Token: 0x06002822 RID: 10274
		[PreserveSig]
		private static extern IntPtr GlobalFree(IntPtr hMem);

		// Token: 0x06002823 RID: 10275 RVA: 0x0001CB05 File Offset: 0x0001AD05
		private static void SetClipboardText(string text)
		{
		}

		// Token: 0x06002824 RID: 10276 RVA: 0x0001CB07 File Offset: 0x0001AD07
		private static string GetClipboardText()
		{
			return null;
		}

		// Token: 0x06002825 RID: 10277 RVA: 0x0001CB0A File Offset: 0x0001AD0A
		public void CopyInstancesToClipboard(List<Instance> instances)
		{
		}

		// Token: 0x06002826 RID: 10278 RVA: 0x0001CB0C File Offset: 0x0001AD0C
		public void PasteInstancesFromClipboard(Instance targetParent = null)
		{
		}

		// Token: 0x06002827 RID: 10279 RVA: 0x0001CB0E File Offset: 0x0001AD0E
		private string CompressString(string text)
		{
			return null;
		}

		// Token: 0x06002828 RID: 10280 RVA: 0x0001CB11 File Offset: 0x0001AD11
		private string DecompressString(string compressedText)
		{
			return null;
		}

		// Token: 0x04000D89 RID: 3465
		public static ClipboardController singleton;

		// Token: 0x04000D8A RID: 3466
		private const string CLIPBOARD_PREFIX = "POLYTORIA_CLIPBOARD:";

		// Token: 0x04000D8B RID: 3467
		private const uint GMEM_MOVEABLE = 2U;

		// Token: 0x04000D8C RID: 3468
		private const uint CF_UNICODETEXT = 13U;

		// Token: 0x0200041A RID: 1050
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06002CB9 RID: 11449 RVA: 0x0001DA18 File Offset: 0x0001BC18
			internal bool <CopyInstancesToClipboard>b__16_0(Instance i)
			{
				return false;
			}

			// Token: 0x06002CBA RID: 11450 RVA: 0x0001DA1B File Offset: 0x0001BC1B
			internal int <CopyInstancesToClipboard>b__16_1(Instance i)
			{
				return 0;
			}

			// Token: 0x040011A6 RID: 4518
			public static readonly ClipboardController.<>c <>9;

			// Token: 0x040011A7 RID: 4519
			public static Func<Instance, bool> <>9__16_0;

			// Token: 0x040011A8 RID: 4520
			public static Func<Instance, int> <>9__16_1;
		}

		// Token: 0x0200041B RID: 1051
		private sealed class <>c__DisplayClass16_0
		{
			// Token: 0x06002CBC RID: 11452 RVA: 0x0001DA26 File Offset: 0x0001BC26
			internal bool <CopyInstancesToClipboard>b__2(Instance i)
			{
				return false;
			}

			// Token: 0x040011A9 RID: 4521
			public int lowestLevel;
		}
	}
}
