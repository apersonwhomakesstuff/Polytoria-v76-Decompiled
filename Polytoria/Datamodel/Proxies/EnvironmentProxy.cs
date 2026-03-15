namespace Polytoria.Datamodel.Proxies;

public class EnvironmentProxy : InstanceProxy
{
	private readonly Environment environment; //Field offset: 0x18

	public bool AutoGenerateNavMesh
	{
		 get { } //Length: 30
		 set { } //Length: 30
	}

	public Color FogColor
	{
		 get { } //Length: 36
		 set { } //Length: 44
	}

	public bool FogEnabled
	{
		 get { } //Length: 30
		 set { } //Length: 30
	}

	public float FogEndDistance
	{
		 get { } //Length: 31
		 set { } //Length: 30
	}

	public float FogStartDistance
	{
		 get { } //Length: 31
		 set { } //Length: 30
	}

	public Vector3 Gravity
	{
		 get { } //Length: 47
		 set { } //Length: 53
	}

	public float PartDestroyHeight
	{
		 get { } //Length: 31
		 set { } //Length: 30
	}

	public SkyboxPreset Skybox
	{
		 get { } //Length: 29
		 set { } //Length: 30
	}

	[MoonSharpHidden]
	public EnvironmentProxy(Environment target) { }

	[LuaCallbackParameter("callback", typeof(Instance), "hit", False)]
	public void CreateExplosion(Vector3 position, float radius = 10, float force = 5000, bool affectKinematic = true, DynValue callback = null, float damage = 10000) { }

	public bool get_AutoGenerateNavMesh() { }

	public Color get_FogColor() { }

	public bool get_FogEnabled() { }

	public float get_FogEndDistance() { }

	public float get_FogStartDistance() { }

	public Vector3 get_Gravity() { }

	public float get_PartDestroyHeight() { }

	public SkyboxPreset get_Skybox() { }

	public Vector3 GetPointOnNavMesh(Vector3 position, float maxDistance = 100) { }

	public Instance[] OverlapBox(Vector3 center, Vector3 halfExtents, Vector3 rotation, List<Instance> ignoreList = null) { }

	public Instance[] OverlapSphere(Vector3 position, float radius, List<Instance> ignoreList = null) { }

	public Nullable<RayResult> Raycast(Vector3 origin, Vector3 direction, float maxDistance = ∞, List<Instance> ignoreList = null) { }

	public RayResult[] RaycastAll(Vector3 origin, Vector3 direction, float maxDistance = ∞, List<Instance> ignoreList = null) { }

	public void RebuildNavMesh(Instance root) { }

	public void set_AutoGenerateNavMesh(bool value) { }

	public void set_FogColor(Color value) { }

	public void set_FogEnabled(bool value) { }

	public void set_FogEndDistance(float value) { }

	public void set_FogStartDistance(float value) { }

	public void set_Gravity(Vector3 value) { }

	public void set_PartDestroyHeight(float value) { }

	public void set_Skybox(SkyboxPreset value) { }

}

