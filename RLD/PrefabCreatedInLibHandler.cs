namespace RLD;

public sealed class PrefabCreatedInLibHandler : MulticastDelegate
{

	public PrefabCreatedInLibHandler(object object, IntPtr method) { }

	public override IAsyncResult BeginInvoke(RTPrefabLib prefabLib, RTPrefab prefab, AsyncCallback callback, object object) { }

	public override void EndInvoke(IAsyncResult result) { }

	public override void Invoke(RTPrefabLib prefabLib, RTPrefab prefab) { }

}

