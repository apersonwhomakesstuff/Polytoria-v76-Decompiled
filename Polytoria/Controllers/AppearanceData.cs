namespace Polytoria.Controllers;

public class AppearanceData
{
	public Color headColor; //Field offset: 0x10
	public Color torsoColor; //Field offset: 0x20
	public Color leftArmColor; //Field offset: 0x30
	public Color rightArmColor; //Field offset: 0x40
	public Color leftLegColor; //Field offset: 0x50
	public Color rightLegColor; //Field offset: 0x60
	public String[] hatUrls; //Field offset: 0x70
	public int faceID; //Field offset: 0x78
	public int shirtID; //Field offset: 0x7C
	public int pantsID; //Field offset: 0x80
	public int torsoID; //Field offset: 0x84
	public string torsoUrl; //Field offset: 0x88

	public AppearanceData() { }

	public virtual bool Equals(object obj) { }

	public virtual int GetHashCode() { }

}

