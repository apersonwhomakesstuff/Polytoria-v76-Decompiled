namespace Polytoria.Types;

[CreateAssetMenu(fileName = "FootstepCollection", menuName = "Polytoria/FootstepCollection")]
public class FootstepCollection : ScriptableObject
{
	public FootstepSounds fallback; //Field offset: 0x18
	public FootstepMaterial[] sounds; //Field offset: 0x20

	public FootstepCollection() { }

	public FootstepSounds GetSounds(PartMaterial partMaterial) { }

}

