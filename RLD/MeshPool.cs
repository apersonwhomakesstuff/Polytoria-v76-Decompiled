namespace RLD;

public class MeshPool : Singleton<MeshPool>
{
	private Mesh _unitTorus; //Field offset: 0x10
	private Mesh _unitCylindricalTorus; //Field offset: 0x18
	private Mesh _unitBox; //Field offset: 0x20
	private Mesh _unitWireBox; //Field offset: 0x28
	private Mesh _unitPyramid; //Field offset: 0x30
	private Mesh _unitWirePyramid; //Field offset: 0x38
	private Mesh _unitTriangularPrism; //Field offset: 0x40
	private Mesh _unitWireTriangularPrism; //Field offset: 0x48
	private Mesh _unitCone; //Field offset: 0x50
	private Mesh _unitCylinder; //Field offset: 0x58
	private Mesh _unitSphere; //Field offset: 0x60
	private Mesh _unitCoordSystem; //Field offset: 0x68
	private Mesh _unitSegmentX; //Field offset: 0x70
	private Mesh _unitQuadXY; //Field offset: 0x78
	private Mesh _unitQuadXZ; //Field offset: 0x80
	private Mesh _unitWireQuadXY; //Field offset: 0x88
	private Mesh _unitCircleXY; //Field offset: 0x90
	private Mesh _unitWireCircleXY; //Field offset: 0x98
	private Mesh _unitRightAngledTriangleXY; //Field offset: 0xA0
	private Mesh _unitWireRightAngledTriangleXY; //Field offset: 0xA8
	private Mesh _unitEqTriangleXY; //Field offset: 0xB0
	private Mesh _unitWireEqTriangleXY; //Field offset: 0xB8

	public Mesh UnitBox
	{
		 get { } //Length: 160
	}

	public Mesh UnitCircleXY
	{
		 get { } //Length: 165
	}

	public Mesh UnitCone
	{
		 get { } //Length: 195
	}

	public Mesh UnitCoordSystem
	{
		 get { } //Length: 148
	}

	public Mesh UnitCylinder
	{
		 get { } //Length: 195
	}

	public Mesh UnitCylindricalTorus
	{
		 get { } //Length: 241
	}

	public Mesh UnitEqTriangleXY
	{
		 get { } //Length: 224
	}

	public Mesh UnitPyramid
	{
		 get { } //Length: 233
	}

	public Mesh UnitQuadXY
	{
		 get { } //Length: 151
	}

	public Mesh UnitQuadXZ
	{
		 get { } //Length: 163
	}

	public Mesh UnitRightAngledTriangleXY
	{
		 get { } //Length: 237
	}

	public Mesh UnitSegmentX
	{
		 get { } //Length: 239
	}

	public Mesh UnitSphere
	{
		 get { } //Length: 162
	}

	public Mesh UnitTorus
	{
		 get { } //Length: 244
	}

	public Mesh UnitTriangularPrism
	{
		 get { } //Length: 245
	}

	public Mesh UnitWireBox
	{
		 get { } //Length: 160
	}

	public Mesh UnitWireCircleXY
	{
		 get { } //Length: 165
	}

	public Mesh UnitWireEqTriangleXY
	{
		 get { } //Length: 224
	}

	public Mesh UnitWirePyramid
	{
		 get { } //Length: 233
	}

	public Mesh UnitWireQuadXY
	{
		 get { } //Length: 239
	}

	public Mesh UnitWireRightAngledTriangleXY
	{
		 get { } //Length: 237
	}

	public Mesh UnitWireTriangularPrism
	{
		 get { } //Length: 245
	}

	public MeshPool() { }

	public Mesh get_UnitBox() { }

	public Mesh get_UnitCircleXY() { }

	public Mesh get_UnitCone() { }

	public Mesh get_UnitCoordSystem() { }

	public Mesh get_UnitCylinder() { }

	public Mesh get_UnitCylindricalTorus() { }

	public Mesh get_UnitEqTriangleXY() { }

	public Mesh get_UnitPyramid() { }

	public Mesh get_UnitQuadXY() { }

	public Mesh get_UnitQuadXZ() { }

	public Mesh get_UnitRightAngledTriangleXY() { }

	public Mesh get_UnitSegmentX() { }

	public Mesh get_UnitSphere() { }

	public Mesh get_UnitTorus() { }

	public Mesh get_UnitTriangularPrism() { }

	public Mesh get_UnitWireBox() { }

	public Mesh get_UnitWireCircleXY() { }

	public Mesh get_UnitWireEqTriangleXY() { }

	public Mesh get_UnitWirePyramid() { }

	public Mesh get_UnitWireQuadXY() { }

	public Mesh get_UnitWireRightAngledTriangleXY() { }

	public Mesh get_UnitWireTriangularPrism() { }

}

