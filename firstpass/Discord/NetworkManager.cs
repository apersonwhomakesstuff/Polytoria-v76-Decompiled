using System;

namespace Discord
{
	// Token: 0x02000160 RID: 352
	public class NetworkManager
	{
		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x06000DF9 RID: 3577 RVA: 0x00010898 File Offset: 0x0000EA98
		private NetworkManager.FFIMethods Methods
		{
			get
			{
				return default(NetworkManager.FFIMethods);
			}
		}

		// Token: 0x14000010 RID: 16
		// (add) Token: 0x06000DFA RID: 3578 RVA: 0x0000F0B3 File Offset: 0x0000D2B3
		// (remove) Token: 0x06000DFB RID: 3579 RVA: 0x0000F0B5 File Offset: 0x0000D2B5
		public event NetworkManager.MessageHandler OnMessage
		{
			add
			{
			}
			remove
			{
			}
		}

		// Token: 0x14000011 RID: 17
		// (add) Token: 0x06000DFC RID: 3580 RVA: 0x0000F0B7 File Offset: 0x0000D2B7
		// (remove) Token: 0x06000DFD RID: 3581 RVA: 0x0000F0B9 File Offset: 0x0000D2B9
		public event NetworkManager.RouteUpdateHandler OnRouteUpdate
		{
			add
			{
			}
			remove
			{
			}
		}

		// Token: 0x06000DFE RID: 3582 RVA: 0x0000F0BB File Offset: 0x0000D2BB
		internal NetworkManager(IntPtr ptr, IntPtr eventsPtr, ref NetworkManager.FFIEvents events)
		{
		}

		// Token: 0x06000DFF RID: 3583 RVA: 0x0000F0C3 File Offset: 0x0000D2C3
		private void InitEvents(IntPtr eventsPtr, ref NetworkManager.FFIEvents events)
		{
		}

		// Token: 0x06000E00 RID: 3584 RVA: 0x0000F0C5 File Offset: 0x0000D2C5
		public ulong GetPeerId()
		{
			return (ulong)0;
		}

		// Token: 0x06000E01 RID: 3585 RVA: 0x0000F0C9 File Offset: 0x0000D2C9
		public void Flush()
		{
		}

		// Token: 0x06000E02 RID: 3586 RVA: 0x0000F0CB File Offset: 0x0000D2CB
		public void OpenPeer(ulong peerId, string routeData)
		{
		}

		// Token: 0x06000E03 RID: 3587 RVA: 0x0000F0CD File Offset: 0x0000D2CD
		public void UpdatePeer(ulong peerId, string routeData)
		{
		}

		// Token: 0x06000E04 RID: 3588 RVA: 0x0000F0CF File Offset: 0x0000D2CF
		public void ClosePeer(ulong peerId)
		{
		}

		// Token: 0x06000E05 RID: 3589 RVA: 0x0000F0D1 File Offset: 0x0000D2D1
		public void OpenChannel(ulong peerId, byte channelId, bool reliable)
		{
		}

		// Token: 0x06000E06 RID: 3590 RVA: 0x0000F0D3 File Offset: 0x0000D2D3
		public void CloseChannel(ulong peerId, byte channelId)
		{
		}

		// Token: 0x06000E07 RID: 3591 RVA: 0x0000F0D5 File Offset: 0x0000D2D5
		public void SendMessage(ulong peerId, byte channelId, byte[] data)
		{
		}

		// Token: 0x06000E08 RID: 3592 RVA: 0x0000F0D7 File Offset: 0x0000D2D7
		private static void OnMessageImpl(IntPtr ptr, ulong peerId, byte channelId, IntPtr dataPtr, int dataLen)
		{
		}

		// Token: 0x06000E09 RID: 3593 RVA: 0x0000F0D9 File Offset: 0x0000D2D9
		private static void OnRouteUpdateImpl(IntPtr ptr, string routeData)
		{
		}

		// Token: 0x040005D8 RID: 1496
		private IntPtr MethodsPtr;

		// Token: 0x040005D9 RID: 1497
		private object MethodsStructure;

		// Token: 0x02000211 RID: 529
		internal struct FFIEvents
		{
			// Token: 0x040007D8 RID: 2008
			internal NetworkManager.FFIEvents.MessageHandler OnMessage;

			// Token: 0x040007D9 RID: 2009
			internal NetworkManager.FFIEvents.RouteUpdateHandler OnRouteUpdate;

			// Token: 0x020002B1 RID: 689
			// (Invoke) Token: 0x0600133B RID: 4923
			internal delegate void MessageHandler(IntPtr ptr, ulong peerId, byte channelId, IntPtr dataPtr, int dataLen);

			// Token: 0x020002B2 RID: 690
			// (Invoke) Token: 0x0600133F RID: 4927
			internal delegate void RouteUpdateHandler(IntPtr ptr, string routeData);
		}

		// Token: 0x02000212 RID: 530
		internal struct FFIMethods
		{
			// Token: 0x040007DA RID: 2010
			internal NetworkManager.FFIMethods.GetPeerIdMethod GetPeerId;

			// Token: 0x040007DB RID: 2011
			internal NetworkManager.FFIMethods.FlushMethod Flush;

			// Token: 0x040007DC RID: 2012
			internal NetworkManager.FFIMethods.OpenPeerMethod OpenPeer;

			// Token: 0x040007DD RID: 2013
			internal NetworkManager.FFIMethods.UpdatePeerMethod UpdatePeer;

			// Token: 0x040007DE RID: 2014
			internal NetworkManager.FFIMethods.ClosePeerMethod ClosePeer;

			// Token: 0x040007DF RID: 2015
			internal NetworkManager.FFIMethods.OpenChannelMethod OpenChannel;

			// Token: 0x040007E0 RID: 2016
			internal NetworkManager.FFIMethods.CloseChannelMethod CloseChannel;

			// Token: 0x040007E1 RID: 2017
			internal NetworkManager.FFIMethods.SendMessageMethod SendMessage;

			// Token: 0x020002B3 RID: 691
			// (Invoke) Token: 0x06001343 RID: 4931
			internal delegate void GetPeerIdMethod(IntPtr methodsPtr, ref ulong peerId);

			// Token: 0x020002B4 RID: 692
			// (Invoke) Token: 0x06001347 RID: 4935
			internal delegate Result FlushMethod(IntPtr methodsPtr);

			// Token: 0x020002B5 RID: 693
			// (Invoke) Token: 0x0600134B RID: 4939
			internal delegate Result OpenPeerMethod(IntPtr methodsPtr, ulong peerId, string routeData);

			// Token: 0x020002B6 RID: 694
			// (Invoke) Token: 0x0600134F RID: 4943
			internal delegate Result UpdatePeerMethod(IntPtr methodsPtr, ulong peerId, string routeData);

			// Token: 0x020002B7 RID: 695
			// (Invoke) Token: 0x06001353 RID: 4947
			internal delegate Result ClosePeerMethod(IntPtr methodsPtr, ulong peerId);

			// Token: 0x020002B8 RID: 696
			// (Invoke) Token: 0x06001357 RID: 4951
			internal delegate Result OpenChannelMethod(IntPtr methodsPtr, ulong peerId, byte channelId, bool reliable);

			// Token: 0x020002B9 RID: 697
			// (Invoke) Token: 0x0600135B RID: 4955
			internal delegate Result CloseChannelMethod(IntPtr methodsPtr, ulong peerId, byte channelId);

			// Token: 0x020002BA RID: 698
			// (Invoke) Token: 0x0600135F RID: 4959
			internal delegate Result SendMessageMethod(IntPtr methodsPtr, ulong peerId, byte channelId, byte[] data, int dataLen);
		}

		// Token: 0x02000213 RID: 531
		// (Invoke) Token: 0x060010FE RID: 4350
		public delegate void MessageHandler(ulong peerId, byte channelId, byte[] data);

		// Token: 0x02000214 RID: 532
		// (Invoke) Token: 0x06001102 RID: 4354
		public delegate void RouteUpdateHandler(string routeData);
	}
}
