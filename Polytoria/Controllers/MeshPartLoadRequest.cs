namespace Polytoria.Controllers;

public struct MeshPartLoadRequest
{
	public int assetID; //Field offset: 0x0
	public MeshPart meshPart; //Field offset: 0x8
	public Action onComplete; //Field offset: 0x10

	public MeshPartLoadRequest(int assetID, MeshPart meshPart, Action onLoadComplete = null) { }

}

