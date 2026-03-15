namespace RLD;

[Flags]
public enum GameObjectType : int
{
	Mesh = 1,
	Terrain = 2,
	Sprite = 4,
	Camera = 8,
	Light = 16,
	ParticleSystem = 32,
	Empty = 64,
}

