namespace Polytoria.Controllers;

public class MaterialCache : MonoBehaviour
{
	private struct MaterialCacheEntry
	{
		public Material Opaque; //Field offset: 0x0
		public Material Transparent; //Field offset: 0x8

	}

	[CompilerGenerated]
	private static MaterialCache <Instance>k__BackingField; //Field offset: 0x0
	private Dictionary<PartMaterial, MaterialCacheEntry> materials; //Field offset: 0x20

	public private static MaterialCache Instance
	{
		[CompilerGenerated]
		 get { } //Length: 54
		[CompilerGenerated]
		private set { } //Length: 81
	}

	public MaterialCache() { }

	private void Awake() { }

	[CompilerGenerated]
	public static MaterialCache get_Instance() { }

	public Material GetMaterial(PartMaterial material, bool isTransparent = false) { }

	[CompilerGenerated]
	private static void set_Instance(MaterialCache value) { }

}

