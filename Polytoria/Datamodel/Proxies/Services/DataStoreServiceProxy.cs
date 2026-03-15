namespace Polytoria.Datamodel.Proxies.Services;

public class DataStoreServiceProxy
{
	private readonly DataStoreService dataStoreService; //Field offset: 0x10

	[MoonSharpHidden]
	public DataStoreServiceProxy(DataStoreService target) { }

	public Datastore GetDatastore(string key) { }

}

