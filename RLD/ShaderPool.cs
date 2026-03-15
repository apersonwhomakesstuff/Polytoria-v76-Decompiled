namespace RLD;

public class ShaderPool : Singleton<ShaderPool>
{
	private Shader _linearGradientCameraBk; //Field offset: 0x10
	private Shader _xzGrid_Plane; //Field offset: 0x18
	private Shader _gizmoSolidHandle; //Field offset: 0x20
	private Shader _tintedTexture; //Field offset: 0x28
	private Shader _simpleColor; //Field offset: 0x30
	private Shader _circleCull; //Field offset: 0x38
	private Shader _torusCull; //Field offset: 0x40
	private Shader _cylindricalTorusCull; //Field offset: 0x48

	public Shader CircleCull
	{
		 get { } //Length: 140
	}

	public Shader CylindricalTorusCull
	{
		 get { } //Length: 140
	}

	public Shader GizmoSolidHandle
	{
		 get { } //Length: 140
	}

	public Shader LinearGradientCameraBk
	{
		 get { } //Length: 140
	}

	public Shader SimpleColor
	{
		 get { } //Length: 140
	}

	public Shader TintedTexture
	{
		 get { } //Length: 140
	}

	public Shader TorusCull
	{
		 get { } //Length: 140
	}

	public Shader XZGrid_Plane
	{
		 get { } //Length: 140
	}

	public ShaderPool() { }

	public Shader get_CircleCull() { }

	public Shader get_CylindricalTorusCull() { }

	public Shader get_GizmoSolidHandle() { }

	public Shader get_LinearGradientCameraBk() { }

	public Shader get_SimpleColor() { }

	public Shader get_TintedTexture() { }

	public Shader get_TorusCull() { }

	public Shader get_XZGrid_Plane() { }

}

