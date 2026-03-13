using System;

namespace Discord
{
	// Token: 0x02000164 RID: 356
	public class VoiceManager
	{
		// Token: 0x170001CD RID: 461
		// (get) Token: 0x06000E53 RID: 3667 RVA: 0x00010988 File Offset: 0x0000EB88
		private VoiceManager.FFIMethods Methods
		{
			get
			{
				return default(VoiceManager.FFIMethods);
			}
		}

		// Token: 0x14000015 RID: 21
		// (add) Token: 0x06000E54 RID: 3668 RVA: 0x0000F17A File Offset: 0x0000D37A
		// (remove) Token: 0x06000E55 RID: 3669 RVA: 0x0000F17C File Offset: 0x0000D37C
		public event VoiceManager.SettingsUpdateHandler OnSettingsUpdate
		{
			add
			{
			}
			remove
			{
			}
		}

		// Token: 0x06000E56 RID: 3670 RVA: 0x0000F17E File Offset: 0x0000D37E
		internal VoiceManager(IntPtr ptr, IntPtr eventsPtr, ref VoiceManager.FFIEvents events)
		{
		}

		// Token: 0x06000E57 RID: 3671 RVA: 0x0000F186 File Offset: 0x0000D386
		private void InitEvents(IntPtr eventsPtr, ref VoiceManager.FFIEvents events)
		{
		}

		// Token: 0x06000E58 RID: 3672 RVA: 0x000109A0 File Offset: 0x0000EBA0
		public InputMode GetInputMode()
		{
			return default(InputMode);
		}

		// Token: 0x06000E59 RID: 3673 RVA: 0x0000F188 File Offset: 0x0000D388
		private static void SetInputModeCallbackImpl(IntPtr ptr, Result result)
		{
		}

		// Token: 0x06000E5A RID: 3674 RVA: 0x0000F18A File Offset: 0x0000D38A
		public void SetInputMode(InputMode inputMode, VoiceManager.SetInputModeHandler callback)
		{
		}

		// Token: 0x06000E5B RID: 3675 RVA: 0x0000F18C File Offset: 0x0000D38C
		public bool IsSelfMute()
		{
			return false;
		}

		// Token: 0x06000E5C RID: 3676 RVA: 0x0000F18F File Offset: 0x0000D38F
		public void SetSelfMute(bool mute)
		{
		}

		// Token: 0x06000E5D RID: 3677 RVA: 0x0000F191 File Offset: 0x0000D391
		public bool IsSelfDeaf()
		{
			return false;
		}

		// Token: 0x06000E5E RID: 3678 RVA: 0x0000F194 File Offset: 0x0000D394
		public void SetSelfDeaf(bool deaf)
		{
		}

		// Token: 0x06000E5F RID: 3679 RVA: 0x0000F196 File Offset: 0x0000D396
		public bool IsLocalMute(long userId)
		{
			return false;
		}

		// Token: 0x06000E60 RID: 3680 RVA: 0x0000F199 File Offset: 0x0000D399
		public void SetLocalMute(long userId, bool mute)
		{
		}

		// Token: 0x06000E61 RID: 3681 RVA: 0x0000F19B File Offset: 0x0000D39B
		public byte GetLocalVolume(long userId)
		{
			return 0;
		}

		// Token: 0x06000E62 RID: 3682 RVA: 0x0000F19E File Offset: 0x0000D39E
		public void SetLocalVolume(long userId, byte volume)
		{
		}

		// Token: 0x06000E63 RID: 3683 RVA: 0x0000F1A0 File Offset: 0x0000D3A0
		private static void OnSettingsUpdateImpl(IntPtr ptr)
		{
		}

		// Token: 0x040005E5 RID: 1509
		private IntPtr MethodsPtr;

		// Token: 0x040005E6 RID: 1510
		private object MethodsStructure;

		// Token: 0x0200022A RID: 554
		internal struct FFIEvents
		{
			// Token: 0x0400080D RID: 2061
			internal VoiceManager.FFIEvents.SettingsUpdateHandler OnSettingsUpdate;

			// Token: 0x020002F2 RID: 754
			// (Invoke) Token: 0x0600143F RID: 5183
			internal delegate void SettingsUpdateHandler(IntPtr ptr);
		}

		// Token: 0x0200022B RID: 555
		internal struct FFIMethods
		{
			// Token: 0x0400080E RID: 2062
			internal VoiceManager.FFIMethods.GetInputModeMethod GetInputMode;

			// Token: 0x0400080F RID: 2063
			internal VoiceManager.FFIMethods.SetInputModeMethod SetInputMode;

			// Token: 0x04000810 RID: 2064
			internal VoiceManager.FFIMethods.IsSelfMuteMethod IsSelfMute;

			// Token: 0x04000811 RID: 2065
			internal VoiceManager.FFIMethods.SetSelfMuteMethod SetSelfMute;

			// Token: 0x04000812 RID: 2066
			internal VoiceManager.FFIMethods.IsSelfDeafMethod IsSelfDeaf;

			// Token: 0x04000813 RID: 2067
			internal VoiceManager.FFIMethods.SetSelfDeafMethod SetSelfDeaf;

			// Token: 0x04000814 RID: 2068
			internal VoiceManager.FFIMethods.IsLocalMuteMethod IsLocalMute;

			// Token: 0x04000815 RID: 2069
			internal VoiceManager.FFIMethods.SetLocalMuteMethod SetLocalMute;

			// Token: 0x04000816 RID: 2070
			internal VoiceManager.FFIMethods.GetLocalVolumeMethod GetLocalVolume;

			// Token: 0x04000817 RID: 2071
			internal VoiceManager.FFIMethods.SetLocalVolumeMethod SetLocalVolume;

			// Token: 0x020002F3 RID: 755
			// (Invoke) Token: 0x06001443 RID: 5187
			internal delegate Result GetInputModeMethod(IntPtr methodsPtr, ref InputMode inputMode);

			// Token: 0x020002F4 RID: 756
			// (Invoke) Token: 0x06001447 RID: 5191
			internal delegate void SetInputModeCallback(IntPtr ptr, Result result);

			// Token: 0x020002F5 RID: 757
			// (Invoke) Token: 0x0600144B RID: 5195
			internal delegate void SetInputModeMethod(IntPtr methodsPtr, InputMode inputMode, IntPtr callbackData, VoiceManager.FFIMethods.SetInputModeCallback callback);

			// Token: 0x020002F6 RID: 758
			// (Invoke) Token: 0x0600144F RID: 5199
			internal delegate Result IsSelfMuteMethod(IntPtr methodsPtr, ref bool mute);

			// Token: 0x020002F7 RID: 759
			// (Invoke) Token: 0x06001453 RID: 5203
			internal delegate Result SetSelfMuteMethod(IntPtr methodsPtr, bool mute);

			// Token: 0x020002F8 RID: 760
			// (Invoke) Token: 0x06001457 RID: 5207
			internal delegate Result IsSelfDeafMethod(IntPtr methodsPtr, ref bool deaf);

			// Token: 0x020002F9 RID: 761
			// (Invoke) Token: 0x0600145B RID: 5211
			internal delegate Result SetSelfDeafMethod(IntPtr methodsPtr, bool deaf);

			// Token: 0x020002FA RID: 762
			// (Invoke) Token: 0x0600145F RID: 5215
			internal delegate Result IsLocalMuteMethod(IntPtr methodsPtr, long userId, ref bool mute);

			// Token: 0x020002FB RID: 763
			// (Invoke) Token: 0x06001463 RID: 5219
			internal delegate Result SetLocalMuteMethod(IntPtr methodsPtr, long userId, bool mute);

			// Token: 0x020002FC RID: 764
			// (Invoke) Token: 0x06001467 RID: 5223
			internal delegate Result GetLocalVolumeMethod(IntPtr methodsPtr, long userId, ref byte volume);

			// Token: 0x020002FD RID: 765
			// (Invoke) Token: 0x0600146B RID: 5227
			internal delegate Result SetLocalVolumeMethod(IntPtr methodsPtr, long userId, byte volume);
		}

		// Token: 0x0200022C RID: 556
		// (Invoke) Token: 0x06001142 RID: 4418
		public delegate void SetInputModeHandler(Result result);

		// Token: 0x0200022D RID: 557
		// (Invoke) Token: 0x06001146 RID: 4422
		public delegate void SettingsUpdateHandler();
	}
}
