namespace RLD;

public class MaterialPool : Singleton<MaterialPool>
{
	private Material _linearGradientCameraBk; //Field offset: 0x10
	private Material _xzGrid_Plane; //Field offset: 0x18
	private Material _gizmoSolidHandle; //Field offset: 0x20
	private Material _tintedTexture; //Field offset: 0x28
	private Material _simpleColor; //Field offset: 0x30
	private Material _circleCull; //Field offset: 0x38
	private Material _torusCull; //Field offset: 0x40
	private Material _cylindricalTorusCull; //Field offset: 0x48

	public Material CircleCull
	{
		 get { } //Length: 359
	}

	public Material CylindricalTorusCull
	{
		 get { } //Length: 359
	}

	public Material GizmoSolidHandle
	{
		 get { } //Length: 359
	}

	public Material LinearGradientCameraBk
	{
		 get { } //Length: 359
	}

	public Material SimpleColor
	{
		 get { } //Length: 359
	}

	public Material TintedTexture
	{
		 get { } //Length: 359
	}

	public Material TorusCull
	{
		 get { } //Length: 359
	}

	public Material XZGrid_Plane
	{
		 get { } //Length: 359
	}

	public MaterialPool() { }

	public Material get_CircleCull() { }

	public Material get_CylindricalTorusCull() { }

	public Material get_GizmoSolidHandle() { }

	public Material get_LinearGradientCameraBk() { }

	public Material get_SimpleColor() { }

	public Material get_TintedTexture() { }

	public Material get_TorusCull() { }

	public Material get_XZGrid_Plane() { }

}

