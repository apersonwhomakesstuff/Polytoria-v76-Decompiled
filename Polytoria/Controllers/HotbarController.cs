namespace Polytoria.Controllers;

public class HotbarController : MonoBehaviour
{
	public static HotbarController singleton; //Field offset: 0x0
	private RectTransform hotbarItem; //Field offset: 0x20
	private Dictionary<Tool, RectTransform> tools; //Field offset: 0x28
	private int toolIndex; //Field offset: 0x30

	public HotbarController() { }

	private void Awake() { }

	private void EquipTool(Tool tool) { }

	private void Start() { }

	public void ToolLinked(Tool tool, Instance parent) { }

	private void Update() { }

}

