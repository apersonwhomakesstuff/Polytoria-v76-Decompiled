namespace RLD;

public struct BoxFaceAreaDesc
{
	public BoxFaceAreaType AreaType; //Field offset: 0x0
	public float Area; //Field offset: 0x4

	public BoxFaceAreaDesc(BoxFaceAreaType areaType, float area) { }

	public static BoxFaceAreaDesc GetInvalid() { }

}

