using System;

namespace Discord
{
	// Token: 0x02000161 RID: 353
	public class OverlayManager
	{
		// Token: 0x170001CA RID: 458
		// (get) Token: 0x06000E0A RID: 3594 RVA: 0x000108B0 File Offset: 0x0000EAB0
		private OverlayManager.FFIMethods Methods
		{
			get
			{
				return default(OverlayManager.FFIMethods);
			}
		}

		// Token: 0x14000012 RID: 18
		// (add) Token: 0x06000E0B RID: 3595 RVA: 0x0000F0DB File Offset: 0x0000D2DB
		// (remove) Token: 0x06000E0C RID: 3596 RVA: 0x0000F0DD File Offset: 0x0000D2DD
		public event OverlayManager.ToggleHandler OnToggle
		{
			add
			{
			}
			remove
			{
			}
		}

		// Token: 0x06000E0D RID: 3597 RVA: 0x0000F0DF File Offset: 0x0000D2DF
		internal OverlayManager(IntPtr ptr, IntPtr eventsPtr, ref OverlayManager.FFIEvents events)
		{
		}

		// Token: 0x06000E0E RID: 3598 RVA: 0x0000F0E7 File Offset: 0x0000D2E7
		private void InitEvents(IntPtr eventsPtr, ref OverlayManager.FFIEvents events)
		{
		}

		// Token: 0x06000E0F RID: 3599 RVA: 0x0000F0E9 File Offset: 0x0000D2E9
		public bool IsEnabled()
		{
			return false;
		}

		// Token: 0x06000E10 RID: 3600 RVA: 0x0000F0EC File Offset: 0x0000D2EC
		public bool IsLocked()
		{
			return false;
		}

		// Token: 0x06000E11 RID: 3601 RVA: 0x0000F0EF File Offset: 0x0000D2EF
		private static void SetLockedCallbackImpl(IntPtr ptr, Result result)
		{
		}

		// Token: 0x06000E12 RID: 3602 RVA: 0x0000F0F1 File Offset: 0x0000D2F1
		public void SetLocked(bool locked, OverlayManager.SetLockedHandler callback)
		{
		}

		// Token: 0x06000E13 RID: 3603 RVA: 0x0000F0F3 File Offset: 0x0000D2F3
		private static void OpenActivityInviteCallbackImpl(IntPtr ptr, Result result)
		{
		}

		// Token: 0x06000E14 RID: 3604 RVA: 0x0000F0F5 File Offset: 0x0000D2F5
		public void OpenActivityInvite(ActivityActionType type, OverlayManager.OpenActivityInviteHandler callback)
		{
		}

		// Token: 0x06000E15 RID: 3605 RVA: 0x0000F0F7 File Offset: 0x0000D2F7
		private static void OpenGuildInviteCallbackImpl(IntPtr ptr, Result result)
		{
		}

		// Token: 0x06000E16 RID: 3606 RVA: 0x0000F0F9 File Offset: 0x0000D2F9
		public void OpenGuildInvite(string code, OverlayManager.OpenGuildInviteHandler callback)
		{
		}

		// Token: 0x06000E17 RID: 3607 RVA: 0x0000F0FB File Offset: 0x0000D2FB
		private static void OpenVoiceSettingsCallbackImpl(IntPtr ptr, Result result)
		{
		}

		// Token: 0x06000E18 RID: 3608 RVA: 0x0000F0FD File Offset: 0x0000D2FD
		public void OpenVoiceSettings(OverlayManager.OpenVoiceSettingsHandler callback)
		{
		}

		// Token: 0x06000E19 RID: 3609 RVA: 0x0000F0FF File Offset: 0x0000D2FF
		public void InitDrawingDxgi(IntPtr swapchain, bool useMessageForwarding)
		{
		}

		// Token: 0x06000E1A RID: 3610 RVA: 0x0000F101 File Offset: 0x0000D301
		public void OnPresent()
		{
		}

		// Token: 0x06000E1B RID: 3611 RVA: 0x0000F103 File Offset: 0x0000D303
		public void ForwardMessage(IntPtr message)
		{
		}

		// Token: 0x06000E1C RID: 3612 RVA: 0x0000F105 File Offset: 0x0000D305
		public void KeyEvent(bool down, string keyCode, KeyVariant variant)
		{
		}

		// Token: 0x06000E1D RID: 3613 RVA: 0x0000F107 File Offset: 0x0000D307
		public void CharEvent(string character)
		{
		}

		// Token: 0x06000E1E RID: 3614 RVA: 0x0000F109 File Offset: 0x0000D309
		public void MouseButtonEvent(byte down, int clickCount, MouseButton which, int x, int y)
		{
		}

		// Token: 0x06000E1F RID: 3615 RVA: 0x0000F10B File Offset: 0x0000D30B
		public void MouseMotionEvent(int x, int y)
		{
		}

		// Token: 0x06000E20 RID: 3616 RVA: 0x0000F10D File Offset: 0x0000D30D
		public void ImeCommitText(string text)
		{
		}

		// Token: 0x06000E21 RID: 3617 RVA: 0x0000F10F File Offset: 0x0000D30F
		public void ImeSetComposition(string text, ImeUnderline underlines, int from, int to)
		{
		}

		// Token: 0x06000E22 RID: 3618 RVA: 0x0000F111 File Offset: 0x0000D311
		public void ImeCancelComposition()
		{
		}

		// Token: 0x06000E23 RID: 3619 RVA: 0x0000F113 File Offset: 0x0000D313
		private static void SetImeCompositionRangeCallbackCallbackImpl(IntPtr ptr, int from, int to, ref Rect bounds)
		{
		}

		// Token: 0x06000E24 RID: 3620 RVA: 0x0000F115 File Offset: 0x0000D315
		public void SetImeCompositionRangeCallback(OverlayManager.SetImeCompositionRangeCallbackHandler callback)
		{
		}

		// Token: 0x06000E25 RID: 3621 RVA: 0x0000F117 File Offset: 0x0000D317
		private static void SetImeSelectionBoundsCallbackCallbackImpl(IntPtr ptr, Rect anchor, Rect focus, bool isAnchorFirst)
		{
		}

		// Token: 0x06000E26 RID: 3622 RVA: 0x0000F119 File Offset: 0x0000D319
		public void SetImeSelectionBoundsCallback(OverlayManager.SetImeSelectionBoundsCallbackHandler callback)
		{
		}

		// Token: 0x06000E27 RID: 3623 RVA: 0x0000F11B File Offset: 0x0000D31B
		public bool IsPointInsideClickZone(int x, int y)
		{
			return false;
		}

		// Token: 0x06000E28 RID: 3624 RVA: 0x0000F11E File Offset: 0x0000D31E
		private static void OnToggleImpl(IntPtr ptr, bool locked)
		{
		}

		// Token: 0x040005DC RID: 1500
		private IntPtr MethodsPtr;

		// Token: 0x040005DD RID: 1501
		private object MethodsStructure;

		// Token: 0x02000215 RID: 533
		internal struct FFIEvents
		{
			// Token: 0x040007E2 RID: 2018
			internal OverlayManager.FFIEvents.ToggleHandler OnToggle;

			// Token: 0x020002BB RID: 699
			// (Invoke) Token: 0x06001363 RID: 4963
			internal delegate void ToggleHandler(IntPtr ptr, bool locked);
		}

		// Token: 0x02000216 RID: 534
		internal struct FFIMethods
		{
			// Token: 0x040007E3 RID: 2019
			internal OverlayManager.FFIMethods.IsEnabledMethod IsEnabled;

			// Token: 0x040007E4 RID: 2020
			internal OverlayManager.FFIMethods.IsLockedMethod IsLocked;

			// Token: 0x040007E5 RID: 2021
			internal OverlayManager.FFIMethods.SetLockedMethod SetLocked;

			// Token: 0x040007E6 RID: 2022
			internal OverlayManager.FFIMethods.OpenActivityInviteMethod OpenActivityInvite;

			// Token: 0x040007E7 RID: 2023
			internal OverlayManager.FFIMethods.OpenGuildInviteMethod OpenGuildInvite;

			// Token: 0x040007E8 RID: 2024
			internal OverlayManager.FFIMethods.OpenVoiceSettingsMethod OpenVoiceSettings;

			// Token: 0x040007E9 RID: 2025
			internal OverlayManager.FFIMethods.InitDrawingDxgiMethod InitDrawingDxgi;

			// Token: 0x040007EA RID: 2026
			internal OverlayManager.FFIMethods.OnPresentMethod OnPresent;

			// Token: 0x040007EB RID: 2027
			internal OverlayManager.FFIMethods.ForwardMessageMethod ForwardMessage;

			// Token: 0x040007EC RID: 2028
			internal OverlayManager.FFIMethods.KeyEventMethod KeyEvent;

			// Token: 0x040007ED RID: 2029
			internal OverlayManager.FFIMethods.CharEventMethod CharEvent;

			// Token: 0x040007EE RID: 2030
			internal OverlayManager.FFIMethods.MouseButtonEventMethod MouseButtonEvent;

			// Token: 0x040007EF RID: 2031
			internal OverlayManager.FFIMethods.MouseMotionEventMethod MouseMotionEvent;

			// Token: 0x040007F0 RID: 2032
			internal OverlayManager.FFIMethods.ImeCommitTextMethod ImeCommitText;

			// Token: 0x040007F1 RID: 2033
			internal OverlayManager.FFIMethods.ImeSetCompositionMethod ImeSetComposition;

			// Token: 0x040007F2 RID: 2034
			internal OverlayManager.FFIMethods.ImeCancelCompositionMethod ImeCancelComposition;

			// Token: 0x040007F3 RID: 2035
			internal OverlayManager.FFIMethods.SetImeCompositionRangeCallbackMethod SetImeCompositionRangeCallback;

			// Token: 0x040007F4 RID: 2036
			internal OverlayManager.FFIMethods.SetImeSelectionBoundsCallbackMethod SetImeSelectionBoundsCallback;

			// Token: 0x040007F5 RID: 2037
			internal OverlayManager.FFIMethods.IsPointInsideClickZoneMethod IsPointInsideClickZone;

			// Token: 0x020002BC RID: 700
			// (Invoke) Token: 0x06001367 RID: 4967
			internal delegate void IsEnabledMethod(IntPtr methodsPtr, ref bool enabled);

			// Token: 0x020002BD RID: 701
			// (Invoke) Token: 0x0600136B RID: 4971
			internal delegate void IsLockedMethod(IntPtr methodsPtr, ref bool locked);

			// Token: 0x020002BE RID: 702
			// (Invoke) Token: 0x0600136F RID: 4975
			internal delegate void SetLockedCallback(IntPtr ptr, Result result);

			// Token: 0x020002BF RID: 703
			// (Invoke) Token: 0x06001373 RID: 4979
			internal delegate void SetLockedMethod(IntPtr methodsPtr, bool locked, IntPtr callbackData, OverlayManager.FFIMethods.SetLockedCallback callback);

			// Token: 0x020002C0 RID: 704
			// (Invoke) Token: 0x06001377 RID: 4983
			internal delegate void OpenActivityInviteCallback(IntPtr ptr, Result result);

			// Token: 0x020002C1 RID: 705
			// (Invoke) Token: 0x0600137B RID: 4987
			internal delegate void OpenActivityInviteMethod(IntPtr methodsPtr, ActivityActionType type, IntPtr callbackData, OverlayManager.FFIMethods.OpenActivityInviteCallback callback);

			// Token: 0x020002C2 RID: 706
			// (Invoke) Token: 0x0600137F RID: 4991
			internal delegate void OpenGuildInviteCallback(IntPtr ptr, Result result);

			// Token: 0x020002C3 RID: 707
			// (Invoke) Token: 0x06001383 RID: 4995
			internal delegate void OpenGuildInviteMethod(IntPtr methodsPtr, string code, IntPtr callbackData, OverlayManager.FFIMethods.OpenGuildInviteCallback callback);

			// Token: 0x020002C4 RID: 708
			// (Invoke) Token: 0x06001387 RID: 4999
			internal delegate void OpenVoiceSettingsCallback(IntPtr ptr, Result result);

			// Token: 0x020002C5 RID: 709
			// (Invoke) Token: 0x0600138B RID: 5003
			internal delegate void OpenVoiceSettingsMethod(IntPtr methodsPtr, IntPtr callbackData, OverlayManager.FFIMethods.OpenVoiceSettingsCallback callback);

			// Token: 0x020002C6 RID: 710
			// (Invoke) Token: 0x0600138F RID: 5007
			internal delegate Result InitDrawingDxgiMethod(IntPtr methodsPtr, IntPtr swapchain, bool useMessageForwarding);

			// Token: 0x020002C7 RID: 711
			// (Invoke) Token: 0x06001393 RID: 5011
			internal delegate void OnPresentMethod(IntPtr methodsPtr);

			// Token: 0x020002C8 RID: 712
			// (Invoke) Token: 0x06001397 RID: 5015
			internal delegate void ForwardMessageMethod(IntPtr methodsPtr, IntPtr message);

			// Token: 0x020002C9 RID: 713
			// (Invoke) Token: 0x0600139B RID: 5019
			internal delegate void KeyEventMethod(IntPtr methodsPtr, bool down, string keyCode, KeyVariant variant);

			// Token: 0x020002CA RID: 714
			// (Invoke) Token: 0x0600139F RID: 5023
			internal delegate void CharEventMethod(IntPtr methodsPtr, string character);

			// Token: 0x020002CB RID: 715
			// (Invoke) Token: 0x060013A3 RID: 5027
			internal delegate void MouseButtonEventMethod(IntPtr methodsPtr, byte down, int clickCount, MouseButton which, int x, int y);

			// Token: 0x020002CC RID: 716
			// (Invoke) Token: 0x060013A7 RID: 5031
			internal delegate void MouseMotionEventMethod(IntPtr methodsPtr, int x, int y);

			// Token: 0x020002CD RID: 717
			// (Invoke) Token: 0x060013AB RID: 5035
			internal delegate void ImeCommitTextMethod(IntPtr methodsPtr, string text);

			// Token: 0x020002CE RID: 718
			// (Invoke) Token: 0x060013AF RID: 5039
			internal delegate void ImeSetCompositionMethod(IntPtr methodsPtr, string text, ref ImeUnderline underlines, int from, int to);

			// Token: 0x020002CF RID: 719
			// (Invoke) Token: 0x060013B3 RID: 5043
			internal delegate void ImeCancelCompositionMethod(IntPtr methodsPtr);

			// Token: 0x020002D0 RID: 720
			// (Invoke) Token: 0x060013B7 RID: 5047
			internal delegate void SetImeCompositionRangeCallbackCallback(IntPtr ptr, int from, int to, ref Rect bounds);

			// Token: 0x020002D1 RID: 721
			// (Invoke) Token: 0x060013BB RID: 5051
			internal delegate void SetImeCompositionRangeCallbackMethod(IntPtr methodsPtr, IntPtr callbackData, OverlayManager.FFIMethods.SetImeCompositionRangeCallbackCallback callback);

			// Token: 0x020002D2 RID: 722
			// (Invoke) Token: 0x060013BF RID: 5055
			internal delegate void SetImeSelectionBoundsCallbackCallback(IntPtr ptr, Rect anchor, Rect focus, bool isAnchorFirst);

			// Token: 0x020002D3 RID: 723
			// (Invoke) Token: 0x060013C3 RID: 5059
			internal delegate void SetImeSelectionBoundsCallbackMethod(IntPtr methodsPtr, IntPtr callbackData, OverlayManager.FFIMethods.SetImeSelectionBoundsCallbackCallback callback);

			// Token: 0x020002D4 RID: 724
			// (Invoke) Token: 0x060013C7 RID: 5063
			internal delegate bool IsPointInsideClickZoneMethod(IntPtr methodsPtr, int x, int y);
		}

		// Token: 0x02000217 RID: 535
		// (Invoke) Token: 0x06001106 RID: 4358
		public delegate void SetLockedHandler(Result result);

		// Token: 0x02000218 RID: 536
		// (Invoke) Token: 0x0600110A RID: 4362
		public delegate void OpenActivityInviteHandler(Result result);

		// Token: 0x02000219 RID: 537
		// (Invoke) Token: 0x0600110E RID: 4366
		public delegate void OpenGuildInviteHandler(Result result);

		// Token: 0x0200021A RID: 538
		// (Invoke) Token: 0x06001112 RID: 4370
		public delegate void OpenVoiceSettingsHandler(Result result);

		// Token: 0x0200021B RID: 539
		// (Invoke) Token: 0x06001116 RID: 4374
		public delegate void SetImeCompositionRangeCallbackHandler(int from, int to, ref Rect bounds);

		// Token: 0x0200021C RID: 540
		// (Invoke) Token: 0x0600111A RID: 4378
		public delegate void SetImeSelectionBoundsCallbackHandler(Rect anchor, Rect focus, bool isAnchorFirst);

		// Token: 0x0200021D RID: 541
		// (Invoke) Token: 0x0600111E RID: 4382
		public delegate void ToggleHandler(bool locked);
	}
}
