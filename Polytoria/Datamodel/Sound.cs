namespace Polytoria.Datamodel;

[Instantiatable]
[RequireComponent(typeof(AudioSource))]
public class Sound : DynamicInstance
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass39_0
	{
		public int id; //Field offset: 0x10

		public <>c__DisplayClass39_0() { }

		internal bool <GetAudioClip>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <GetAudioClip>d__39 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public int id; //Field offset: 0x20
		public Sound <>4__this; //Field offset: 0x28
		private <>c__DisplayClass39_0 <>8__1; //Field offset: 0x30
		private UnityWebRequest <uwr>5__2; //Field offset: 0x38
		private UnityWebRequest <uwr2>5__3; //Field offset: 0x40

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
		public <GetAudioClip>d__39(int <>1__state) { }

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

	[CompilerGenerated]
	private sealed class <playC>d__56 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public Sound <>4__this; //Field offset: 0x20
		private bool <played>5__2; //Field offset: 0x28
		private int <timeout>5__3; //Field offset: 0x2C

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
		public <playC>d__56(int <>1__state) { }

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

	private struct AudioCacheEntry
	{
		public AudioClip clip; //Field offset: 0x0
		public bool loading; //Field offset: 0x8

	}

	private static Dictionary<Int32, AudioCacheEntry> audioCache; //Field offset: 0x0
	private AudioSource audioSource; //Field offset: 0x210
	private AudioClip clip; //Field offset: 0x218
	[SyncVar]
	private int soundID; //Field offset: 0x220
	[SyncVar]
	private bool _isPlaying; //Field offset: 0x224
	[SyncVar]
	private bool autoplay; //Field offset: 0x225
	[SyncVar]
	private float volume; //Field offset: 0x228
	[SyncVar]
	private float time; //Field offset: 0x22C
	[SyncVar]
	private bool loop; //Field offset: 0x230
	[SyncVar]
	private bool playInWorld; //Field offset: 0x231
	[SyncVar]
	private float pitch; //Field offset: 0x234
	[SyncVar]
	private float maxDistance; //Field offset: 0x238
	public LuaEvent Loaded; //Field offset: 0x240
	private bool loading; //Field offset: 0x248

	[Archivable]
	[CreatorProperty]
	public bool Autoplay
	{
		 get { } //Length: 8
		 set { } //Length: 66
	}

	public float Length
	{
		 get { } //Length: 23
	}

	public bool Loading
	{
		 get { } //Length: 8
	}

	[Archivable]
	[CreatorProperty]
	public bool Loop
	{
		 get { } //Length: 8
		 set { } //Length: 107
	}

	[Archivable]
	[CreatorProperty]
	public float MaxDistance
	{
		 get { } //Length: 9
		 set { } //Length: 551
	}

	public bool Network_isPlaying
	{
		 get { } //Length: 8
		 set { } //Length: 182
	}

	public bool Networkautoplay
	{
		 get { } //Length: 8
		 set { } //Length: 182
	}

	public bool Networkloop
	{
		 get { } //Length: 8
		 set { } //Length: 182
	}

	public float NetworkmaxDistance
	{
		 get { } //Length: 9
		 set { } //Length: 180
	}

	public float Networkpitch
	{
		 get { } //Length: 9
		 set { } //Length: 180
	}

	public bool NetworkplayInWorld
	{
		 get { } //Length: 8
		 set { } //Length: 182
	}

	public int NetworksoundID
	{
		 get { } //Length: 7
		 set { } //Length: 177
	}

	public float Networktime
	{
		 get { } //Length: 9
		 set { } //Length: 180
	}

	public float Networkvolume
	{
		 get { } //Length: 9
		 set { } //Length: 180
	}

	[Archivable]
	[CreatorProperty]
	public float Pitch
	{
		 get { } //Length: 9
		 set { } //Length: 551
	}

	public bool Playing
	{
		 get { } //Length: 8
	}

	[Archivable]
	[CreatorProperty]
	public bool PlayInWorld
	{
		 get { } //Length: 8
		 set { } //Length: 114
	}

	public Vector3 Rotation
	{
		 get { } //Length: 75
		 set { } //Length: 98
	}

	public Vector3 Size
	{
		 get { } //Length: 75
		 set { } //Length: 108
	}

	[Archivable]
	[CreatorProperty]
	public int SoundID
	{
		 get { } //Length: 7
		 set { } //Length: 413
	}

	public float Time
	{
		 get { } //Length: 32
		 set { } //Length: 546
	}

	[Archivable]
	[CreatorProperty]
	public float Volume
	{
		 get { } //Length: 32
		 set { } //Length: 546
	}

	private static Sound() { }

	public Sound() { }

	protected virtual void Awake() { }

	protected virtual void CopyProperties(Instance clone) { }

	public virtual void DeserializeSyncVars(NetworkReader reader, bool initialState) { }

	public bool get_Autoplay() { }

	public float get_Length() { }

	public bool get_Loading() { }

	public bool get_Loop() { }

	public float get_MaxDistance() { }

	public bool get_Network_isPlaying() { }

	public bool get_Networkautoplay() { }

	public bool get_Networkloop() { }

	public float get_NetworkmaxDistance() { }

	public float get_Networkpitch() { }

	public bool get_NetworkplayInWorld() { }

	public int get_NetworksoundID() { }

	public float get_Networktime() { }

	public float get_Networkvolume() { }

	public float get_Pitch() { }

	public bool get_Playing() { }

	public bool get_PlayInWorld() { }

	public Vector3 get_Rotation() { }

	public Vector3 get_Size() { }

	public int get_SoundID() { }

	public float get_Time() { }

	public float get_Volume() { }

	[IteratorStateMachine(typeof(<GetAudioClip>d__39))]
	private IEnumerator GetAudioClip(int id) { }

	protected static void InvokeUserCode_RpcChangeBoolProperty__Int32__Boolean(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection) { }

	protected static void InvokeUserCode_RpcPlay(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection) { }

	protected static void InvokeUserCode_RpcPlayOneShot__Single(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection) { }

	protected static void InvokeUserCode_RpcSetMaxDistance__Single(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection) { }

	protected static void InvokeUserCode_RpcSetPitch__Single(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection) { }

	protected static void InvokeUserCode_RpcSetSoundId__Int32(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection) { }

	protected static void InvokeUserCode_RpcSetTime__Single(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection) { }

	protected static void InvokeUserCode_RpcSetVolume__Single(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection) { }

	protected static void InvokeUserCode_RpcStop(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection) { }

	protected virtual void OnHide() { }

	protected virtual void OnShow() { }

	public void Play() { }

	[IteratorStateMachine(typeof(<playC>d__56))]
	private IEnumerator playC() { }

	public void PlayOneShot(float volume = 1) { }

	[ClientRpc]
	private void RpcChangeBoolProperty(int property, bool value) { }

	[ClientRpc]
	private void RpcPlay() { }

	[ClientRpc]
	public void RpcPlayOneShot(float volume) { }

	[ClientRpc]
	private void RpcSetMaxDistance(float d) { }

	[ClientRpc]
	private void RpcSetPitch(float p) { }

	[ClientRpc]
	private void RpcSetSoundId(int id) { }

	[ClientRpc]
	private void RpcSetTime(float t) { }

	[ClientRpc]
	private void RpcSetVolume(float vol) { }

	[ClientRpc]
	private void RpcStop() { }

	public virtual void SerializeSyncVars(NetworkWriter writer, bool forceAll) { }

	public void set_Autoplay(bool value) { }

	public void set_Loop(bool value) { }

	public void set_MaxDistance(float value) { }

	public void set_Network_isPlaying(in bool value) { }

	public void set_Networkautoplay(in bool value) { }

	public void set_Networkloop(in bool value) { }

	public void set_NetworkmaxDistance(in float value) { }

	public void set_Networkpitch(in float value) { }

	public void set_NetworkplayInWorld(in bool value) { }

	public void set_NetworksoundID(in int value) { }

	public void set_Networktime(in float value) { }

	public void set_Networkvolume(in float value) { }

	public void set_Pitch(float value) { }

	public void set_PlayInWorld(bool value) { }

	public void set_Rotation(Vector3 value) { }

	public void set_Size(Vector3 value) { }

	public void set_SoundID(int value) { }

	public void set_Time(float value) { }

	public void set_Volume(float value) { }

	protected virtual void Start() { }

	public void Stop() { }

	protected virtual void Update() { }

	protected void UserCode_RpcChangeBoolProperty__Int32__Boolean(int property, bool value) { }

	protected void UserCode_RpcPlay() { }

	protected void UserCode_RpcPlayOneShot__Single(float volume) { }

	protected void UserCode_RpcSetMaxDistance__Single(float d) { }

	protected void UserCode_RpcSetPitch__Single(float p) { }

	protected void UserCode_RpcSetSoundId__Int32(int id) { }

	protected void UserCode_RpcSetTime__Single(float t) { }

	protected void UserCode_RpcSetVolume__Single(float vol) { }

	protected void UserCode_RpcStop() { }

	public virtual bool Weaved() { }

}

