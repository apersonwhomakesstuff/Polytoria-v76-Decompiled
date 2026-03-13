using System;
using UnityEngine;

namespace Discord
{
	// Token: 0x0200015D RID: 349
	public class ImageManager
	{
		// Token: 0x170001C6 RID: 454
		// (get) Token: 0x06000D98 RID: 3480 RVA: 0x00010778 File Offset: 0x0000E978
		private ImageManager.FFIMethods Methods
		{
			get
			{
				return default(ImageManager.FFIMethods);
			}
		}

		// Token: 0x06000D99 RID: 3481 RVA: 0x0000EFE5 File Offset: 0x0000D1E5
		internal ImageManager(IntPtr ptr, IntPtr eventsPtr, ref ImageManager.FFIEvents events)
		{
		}

		// Token: 0x06000D9A RID: 3482 RVA: 0x0000EFED File Offset: 0x0000D1ED
		private void InitEvents(IntPtr eventsPtr, ref ImageManager.FFIEvents events)
		{
		}

		// Token: 0x06000D9B RID: 3483 RVA: 0x0000EFEF File Offset: 0x0000D1EF
		private static void FetchCallbackImpl(IntPtr ptr, Result result, ImageHandle handleResult)
		{
		}

		// Token: 0x06000D9C RID: 3484 RVA: 0x0000EFF1 File Offset: 0x0000D1F1
		public void Fetch(ImageHandle handle, bool refresh, ImageManager.FetchHandler callback)
		{
		}

		// Token: 0x06000D9D RID: 3485 RVA: 0x00010790 File Offset: 0x0000E990
		public ImageDimensions GetDimensions(ImageHandle handle)
		{
			return default(ImageDimensions);
		}

		// Token: 0x06000D9E RID: 3486 RVA: 0x0000EFF3 File Offset: 0x0000D1F3
		public void GetData(ImageHandle handle, byte[] data)
		{
		}

		// Token: 0x06000D9F RID: 3487 RVA: 0x0000EFF5 File Offset: 0x0000D1F5
		public void Fetch(ImageHandle handle, ImageManager.FetchHandler callback)
		{
		}

		// Token: 0x06000DA0 RID: 3488 RVA: 0x0000EFF7 File Offset: 0x0000D1F7
		public byte[] GetData(ImageHandle handle)
		{
			return null;
		}

		// Token: 0x06000DA1 RID: 3489 RVA: 0x0000EFFA File Offset: 0x0000D1FA
		public Texture2D GetTexture(ImageHandle handle)
		{
			return null;
		}

		// Token: 0x040005C8 RID: 1480
		private IntPtr MethodsPtr;

		// Token: 0x040005C9 RID: 1481
		private object MethodsStructure;

		// Token: 0x020001F4 RID: 500
		internal struct FFIEvents
		{
		}

		// Token: 0x020001F5 RID: 501
		internal struct FFIMethods
		{
			// Token: 0x040007A6 RID: 1958
			internal ImageManager.FFIMethods.FetchMethod Fetch;

			// Token: 0x040007A7 RID: 1959
			internal ImageManager.FFIMethods.GetDimensionsMethod GetDimensions;

			// Token: 0x040007A8 RID: 1960
			internal ImageManager.FFIMethods.GetDataMethod GetData;

			// Token: 0x02000272 RID: 626
			// (Invoke) Token: 0x0600123F RID: 4671
			internal delegate void FetchCallback(IntPtr ptr, Result result, ImageHandle handleResult);

			// Token: 0x02000273 RID: 627
			// (Invoke) Token: 0x06001243 RID: 4675
			internal delegate void FetchMethod(IntPtr methodsPtr, ImageHandle handle, bool refresh, IntPtr callbackData, ImageManager.FFIMethods.FetchCallback callback);

			// Token: 0x02000274 RID: 628
			// (Invoke) Token: 0x06001247 RID: 4679
			internal delegate Result GetDimensionsMethod(IntPtr methodsPtr, ImageHandle handle, ref ImageDimensions dimensions);

			// Token: 0x02000275 RID: 629
			// (Invoke) Token: 0x0600124B RID: 4683
			internal delegate Result GetDataMethod(IntPtr methodsPtr, ImageHandle handle, byte[] data, int dataLen);
		}

		// Token: 0x020001F6 RID: 502
		// (Invoke) Token: 0x060010A2 RID: 4258
		public delegate void FetchHandler(Result result, ImageHandle handleResult);
	}
}
