using System;
using System.Collections.Generic;
using System.Text;

namespace Discord
{
	// Token: 0x02000162 RID: 354
	public class StorageManager
	{
		// Token: 0x170001CB RID: 459
		// (get) Token: 0x06000E29 RID: 3625 RVA: 0x000108C8 File Offset: 0x0000EAC8
		private StorageManager.FFIMethods Methods
		{
			get
			{
				return default(StorageManager.FFIMethods);
			}
		}

		// Token: 0x06000E2A RID: 3626 RVA: 0x0000F120 File Offset: 0x0000D320
		internal StorageManager(IntPtr ptr, IntPtr eventsPtr, ref StorageManager.FFIEvents events)
		{
		}

		// Token: 0x06000E2B RID: 3627 RVA: 0x0000F128 File Offset: 0x0000D328
		private void InitEvents(IntPtr eventsPtr, ref StorageManager.FFIEvents events)
		{
		}

		// Token: 0x06000E2C RID: 3628 RVA: 0x0000F12A File Offset: 0x0000D32A
		public uint Read(string name, byte[] data)
		{
			return 0U;
		}

		// Token: 0x06000E2D RID: 3629 RVA: 0x0000F12D File Offset: 0x0000D32D
		private static void ReadAsyncCallbackImpl(IntPtr ptr, Result result, IntPtr dataPtr, int dataLen)
		{
		}

		// Token: 0x06000E2E RID: 3630 RVA: 0x0000F12F File Offset: 0x0000D32F
		public void ReadAsync(string name, StorageManager.ReadAsyncHandler callback)
		{
		}

		// Token: 0x06000E2F RID: 3631 RVA: 0x0000F131 File Offset: 0x0000D331
		private static void ReadAsyncPartialCallbackImpl(IntPtr ptr, Result result, IntPtr dataPtr, int dataLen)
		{
		}

		// Token: 0x06000E30 RID: 3632 RVA: 0x0000F133 File Offset: 0x0000D333
		public void ReadAsyncPartial(string name, ulong offset, ulong length, StorageManager.ReadAsyncPartialHandler callback)
		{
		}

		// Token: 0x06000E31 RID: 3633 RVA: 0x0000F135 File Offset: 0x0000D335
		public void Write(string name, byte[] data)
		{
		}

		// Token: 0x06000E32 RID: 3634 RVA: 0x0000F137 File Offset: 0x0000D337
		private static void WriteAsyncCallbackImpl(IntPtr ptr, Result result)
		{
		}

		// Token: 0x06000E33 RID: 3635 RVA: 0x0000F139 File Offset: 0x0000D339
		public void WriteAsync(string name, byte[] data, StorageManager.WriteAsyncHandler callback)
		{
		}

		// Token: 0x06000E34 RID: 3636 RVA: 0x0000F13B File Offset: 0x0000D33B
		public void Delete(string name)
		{
		}

		// Token: 0x06000E35 RID: 3637 RVA: 0x0000F13D File Offset: 0x0000D33D
		public bool Exists(string name)
		{
			return false;
		}

		// Token: 0x06000E36 RID: 3638 RVA: 0x0000F140 File Offset: 0x0000D340
		public int Count()
		{
			return 0;
		}

		// Token: 0x06000E37 RID: 3639 RVA: 0x000108E0 File Offset: 0x0000EAE0
		public FileStat Stat(string name)
		{
			return default(FileStat);
		}

		// Token: 0x06000E38 RID: 3640 RVA: 0x000108F8 File Offset: 0x0000EAF8
		public FileStat StatAt(int index)
		{
			return default(FileStat);
		}

		// Token: 0x06000E39 RID: 3641 RVA: 0x0000F143 File Offset: 0x0000D343
		public string GetPath()
		{
			return null;
		}

		// Token: 0x06000E3A RID: 3642 RVA: 0x0000F146 File Offset: 0x0000D346
		public IEnumerable<FileStat> Files()
		{
			return null;
		}

		// Token: 0x040005DF RID: 1503
		private IntPtr MethodsPtr;

		// Token: 0x040005E0 RID: 1504
		private object MethodsStructure;

		// Token: 0x0200021E RID: 542
		internal struct FFIEvents
		{
		}

		// Token: 0x0200021F RID: 543
		internal struct FFIMethods
		{
			// Token: 0x040007F6 RID: 2038
			internal StorageManager.FFIMethods.ReadMethod Read;

			// Token: 0x040007F7 RID: 2039
			internal StorageManager.FFIMethods.ReadAsyncMethod ReadAsync;

			// Token: 0x040007F8 RID: 2040
			internal StorageManager.FFIMethods.ReadAsyncPartialMethod ReadAsyncPartial;

			// Token: 0x040007F9 RID: 2041
			internal StorageManager.FFIMethods.WriteMethod Write;

			// Token: 0x040007FA RID: 2042
			internal StorageManager.FFIMethods.WriteAsyncMethod WriteAsync;

			// Token: 0x040007FB RID: 2043
			internal StorageManager.FFIMethods.DeleteMethod Delete;

			// Token: 0x040007FC RID: 2044
			internal StorageManager.FFIMethods.ExistsMethod Exists;

			// Token: 0x040007FD RID: 2045
			internal StorageManager.FFIMethods.CountMethod Count;

			// Token: 0x040007FE RID: 2046
			internal StorageManager.FFIMethods.StatMethod Stat;

			// Token: 0x040007FF RID: 2047
			internal StorageManager.FFIMethods.StatAtMethod StatAt;

			// Token: 0x04000800 RID: 2048
			internal StorageManager.FFIMethods.GetPathMethod GetPath;

			// Token: 0x020002D5 RID: 725
			// (Invoke) Token: 0x060013CB RID: 5067
			internal delegate Result ReadMethod(IntPtr methodsPtr, string name, byte[] data, int dataLen, ref uint read);

			// Token: 0x020002D6 RID: 726
			// (Invoke) Token: 0x060013CF RID: 5071
			internal delegate void ReadAsyncCallback(IntPtr ptr, Result result, IntPtr dataPtr, int dataLen);

			// Token: 0x020002D7 RID: 727
			// (Invoke) Token: 0x060013D3 RID: 5075
			internal delegate void ReadAsyncMethod(IntPtr methodsPtr, string name, IntPtr callbackData, StorageManager.FFIMethods.ReadAsyncCallback callback);

			// Token: 0x020002D8 RID: 728
			// (Invoke) Token: 0x060013D7 RID: 5079
			internal delegate void ReadAsyncPartialCallback(IntPtr ptr, Result result, IntPtr dataPtr, int dataLen);

			// Token: 0x020002D9 RID: 729
			// (Invoke) Token: 0x060013DB RID: 5083
			internal delegate void ReadAsyncPartialMethod(IntPtr methodsPtr, string name, ulong offset, ulong length, IntPtr callbackData, StorageManager.FFIMethods.ReadAsyncPartialCallback callback);

			// Token: 0x020002DA RID: 730
			// (Invoke) Token: 0x060013DF RID: 5087
			internal delegate Result WriteMethod(IntPtr methodsPtr, string name, byte[] data, int dataLen);

			// Token: 0x020002DB RID: 731
			// (Invoke) Token: 0x060013E3 RID: 5091
			internal delegate void WriteAsyncCallback(IntPtr ptr, Result result);

			// Token: 0x020002DC RID: 732
			// (Invoke) Token: 0x060013E7 RID: 5095
			internal delegate void WriteAsyncMethod(IntPtr methodsPtr, string name, byte[] data, int dataLen, IntPtr callbackData, StorageManager.FFIMethods.WriteAsyncCallback callback);

			// Token: 0x020002DD RID: 733
			// (Invoke) Token: 0x060013EB RID: 5099
			internal delegate Result DeleteMethod(IntPtr methodsPtr, string name);

			// Token: 0x020002DE RID: 734
			// (Invoke) Token: 0x060013EF RID: 5103
			internal delegate Result ExistsMethod(IntPtr methodsPtr, string name, ref bool exists);

			// Token: 0x020002DF RID: 735
			// (Invoke) Token: 0x060013F3 RID: 5107
			internal delegate void CountMethod(IntPtr methodsPtr, ref int count);

			// Token: 0x020002E0 RID: 736
			// (Invoke) Token: 0x060013F7 RID: 5111
			internal delegate Result StatMethod(IntPtr methodsPtr, string name, ref FileStat stat);

			// Token: 0x020002E1 RID: 737
			// (Invoke) Token: 0x060013FB RID: 5115
			internal delegate Result StatAtMethod(IntPtr methodsPtr, int index, ref FileStat stat);

			// Token: 0x020002E2 RID: 738
			// (Invoke) Token: 0x060013FF RID: 5119
			internal delegate Result GetPathMethod(IntPtr methodsPtr, StringBuilder path);
		}

		// Token: 0x02000220 RID: 544
		// (Invoke) Token: 0x06001122 RID: 4386
		public delegate void ReadAsyncHandler(Result result, byte[] data);

		// Token: 0x02000221 RID: 545
		// (Invoke) Token: 0x06001126 RID: 4390
		public delegate void ReadAsyncPartialHandler(Result result, byte[] data);

		// Token: 0x02000222 RID: 546
		// (Invoke) Token: 0x0600112A RID: 4394
		public delegate void WriteAsyncHandler(Result result);
	}
}
