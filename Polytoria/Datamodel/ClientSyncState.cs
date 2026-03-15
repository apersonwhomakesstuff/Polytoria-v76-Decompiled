namespace Polytoria.Datamodel;

public struct ClientSyncState
{
	public float nextSyncTime; //Field offset: 0x0
	public Vector3 velocity; //Field offset: 0x4
	public Vector3 angularVelocity; //Field offset: 0x10
	public bool isKinematic; //Field offset: 0x1C
	public bool useGravity; //Field offset: 0x1D
	public float drag; //Field offset: 0x20
	public float angularDrag; //Field offset: 0x24

}

