namespace Polytoria.Datamodel.Services;

public class GetDataStoreQueueEntry
{
	public Datastore datastore; //Field offset: 0x10
	public Action<Boolean> callback; //Field offset: 0x18

	public GetDataStoreQueueEntry(Datastore datastore, Action<Boolean> callback) { }

}

