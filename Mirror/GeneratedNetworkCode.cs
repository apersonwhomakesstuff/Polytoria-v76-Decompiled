using System;
using System.Runtime.InteropServices;
using Mirror.Discovery;
using Polytoria.Controllers;
using Polytoria.Datamodel;
using Polytoria.Networking;
using Polytoria.Types;
using TMPro;
using UnityEngine;

namespace Mirror
{
	[StructLayout(3, CharSet = CharSet.Auto)]
	public static class GeneratedNetworkCode
	{
		public static TimeSnapshotMessage TimeSnapshotMessage(NetworkReader reader)
		{
			return default(TimeSnapshotMessage);
		}

		public static void TimeSnapshotMessage(NetworkWriter writer, TimeSnapshotMessage value)
		{
		}

		public static ReadyMessage ReadyMessage(NetworkReader reader)
		{
			return default(ReadyMessage);
		}

		public static void ReadyMessage(NetworkWriter writer, ReadyMessage value)
		{
		}

		public static NotReadyMessage NotReadyMessage(NetworkReader reader)
		{
			return default(NotReadyMessage);
		}

		public static void NotReadyMessage(NetworkWriter writer, NotReadyMessage value)
		{
		}

		public static AddPlayerMessage AddPlayerMessage(NetworkReader reader)
		{
			return default(AddPlayerMessage);
		}

		public static void AddPlayerMessage(NetworkWriter writer, AddPlayerMessage value)
		{
		}

		public static SceneMessage SceneMessage(NetworkReader reader)
		{
			return default(SceneMessage);
		}

		public static SceneOperation SceneOperation(NetworkReader reader)
		{
			return SceneOperation.Normal;
		}

		public static void SceneMessage(NetworkWriter writer, SceneMessage value)
		{
		}

		public static void SceneOperation(NetworkWriter writer, SceneOperation value)
		{
		}

		public static CommandMessage CommandMessage(NetworkReader reader)
		{
			return default(CommandMessage);
		}

		public static void CommandMessage(NetworkWriter writer, CommandMessage value)
		{
		}

		public static RpcMessage RpcMessage(NetworkReader reader)
		{
			return default(RpcMessage);
		}

		public static void RpcMessage(NetworkWriter writer, RpcMessage value)
		{
		}

		public static SpawnMessage SpawnMessage(NetworkReader reader)
		{
			return default(SpawnMessage);
		}

		public static SpawnFlags SpawnFlags(NetworkReader reader)
		{
			return SpawnFlags.None;
		}

		public static void SpawnMessage(NetworkWriter writer, SpawnMessage value)
		{
		}

		public static void SpawnFlags(NetworkWriter writer, SpawnFlags value)
		{
		}

		public static ChangeOwnerMessage ChangeOwnerMessage(NetworkReader reader)
		{
			return default(ChangeOwnerMessage);
		}

		public static void ChangeOwnerMessage(NetworkWriter writer, ChangeOwnerMessage value)
		{
		}

		public static ObjectSpawnStartedMessage ObjectSpawnStartedMessage(NetworkReader reader)
		{
			return default(ObjectSpawnStartedMessage);
		}

		public static void ObjectSpawnStartedMessage(NetworkWriter writer, ObjectSpawnStartedMessage value)
		{
		}

		public static ObjectSpawnFinishedMessage ObjectSpawnFinishedMessage(NetworkReader reader)
		{
			return default(ObjectSpawnFinishedMessage);
		}

		public static void ObjectSpawnFinishedMessage(NetworkWriter writer, ObjectSpawnFinishedMessage value)
		{
		}

		public static ObjectDestroyMessage ObjectDestroyMessage(NetworkReader reader)
		{
			return default(ObjectDestroyMessage);
		}

		public static void ObjectDestroyMessage(NetworkWriter writer, ObjectDestroyMessage value)
		{
		}

		public static ObjectHideMessage ObjectHideMessage(NetworkReader reader)
		{
			return default(ObjectHideMessage);
		}

		public static void ObjectHideMessage(NetworkWriter writer, ObjectHideMessage value)
		{
		}

		public static EntityStateMessage EntityStateMessage(NetworkReader reader)
		{
			return default(EntityStateMessage);
		}

		public static void EntityStateMessage(NetworkWriter writer, EntityStateMessage value)
		{
		}

		public static NetworkPingMessage NetworkPingMessage(NetworkReader reader)
		{
			return default(NetworkPingMessage);
		}

		public static void NetworkPingMessage(NetworkWriter writer, NetworkPingMessage value)
		{
		}

		public static NetworkPongMessage NetworkPongMessage(NetworkReader reader)
		{
			return default(NetworkPongMessage);
		}

		public static void NetworkPongMessage(NetworkWriter writer, NetworkPongMessage value)
		{
		}

		public static ServerRequest ServerRequest(NetworkReader reader)
		{
			return default(ServerRequest);
		}

		public static void ServerRequest(NetworkWriter writer, ServerRequest value)
		{
		}

		public static ServerResponse ServerResponse(NetworkReader reader)
		{
			return default(ServerResponse);
		}

		public static void ServerResponse(NetworkWriter writer, ServerResponse value)
		{
		}

		public static PTAuthenticator.AuthRequestMessage PTAuthenticator/AuthRequestMessage(NetworkReader reader)
		{
			return default(PTAuthenticator.AuthRequestMessage);
		}

		public static void PTAuthenticator/AuthRequestMessage(NetworkWriter writer, PTAuthenticator.AuthRequestMessage value)
		{
		}

		public static PTAuthenticator.AuthResponseMessage PTAuthenticator/AuthResponseMessage(NetworkReader reader)
		{
			return default(PTAuthenticator.AuthResponseMessage);
		}

		public static void PTAuthenticator/AuthResponseMessage(NetworkWriter writer, PTAuthenticator.AuthResponseMessage value)
		{
		}

		public static void PartShape(NetworkWriter writer, PartShape value)
		{
		}

		public static PartShape PartShape(NetworkReader reader)
		{
			return PartShape.Brick;
		}

		public static void PartMaterial(NetworkWriter writer, PartMaterial value)
		{
		}

		public static PartMaterial PartMaterial(NetworkReader reader)
		{
			return PartMaterial.SmoothPlastic;
		}

		public static void PhysicsMaterialCombine(NetworkWriter writer, PhysicsMaterialCombine value)
		{
		}

		public static PhysicsMaterialCombine PhysicsMaterialCombine(NetworkReader reader)
		{
			return PhysicsMaterialCombine.Average;
		}

		public static void ImageType(NetworkWriter writer, ImageType value)
		{
		}

		public static ImageType ImageType(NetworkReader reader)
		{
			return ImageType.Asset;
		}

		public static void SkyboxPreset(NetworkWriter writer, SkyboxPreset value)
		{
		}

		public static SkyboxPreset SkyboxPreset(NetworkReader reader)
		{
			return SkyboxPreset.Day1;
		}

		public static void ImageSky/SkyboxSide(NetworkWriter writer, ImageSky.SkyboxSide value)
		{
		}

		public static ImageSky.SkyboxSide ImageSky/SkyboxSide(NetworkReader reader)
		{
			return ImageSky.SkyboxSide.Top;
		}

		public static void AmbientSource(NetworkWriter writer, AmbientSource value)
		{
		}

		public static AmbientSource AmbientSource(NetworkReader reader)
		{
			return AmbientSource.Skybox;
		}

		public static void CollisionType(NetworkWriter writer, CollisionType value)
		{
		}

		public static CollisionType CollisionType(NetworkReader reader)
		{
			return CollisionType.Bounds;
		}

		public static void ColorRange(NetworkWriter writer, ColorRange value)
		{
		}

		public static void ParticleColorMode(NetworkWriter writer, ParticleColorMode value)
		{
		}

		public static void NumberRange(NetworkWriter writer, NumberRange value)
		{
		}

		public static void ParticleSimulationSpace(NetworkWriter writer, ParticleSimulationSpace value)
		{
		}

		public static void ParticleShape(NetworkWriter writer, ParticleShape value)
		{
		}

		public static ColorRange ColorRange(NetworkReader reader)
		{
			return default(ColorRange);
		}

		public static ParticleColorMode ParticleColorMode(NetworkReader reader)
		{
			return ParticleColorMode.Multiply;
		}

		public static NumberRange NumberRange(NetworkReader reader)
		{
			return default(NumberRange);
		}

		public static ParticleSimulationSpace ParticleSimulationSpace(NetworkReader reader)
		{
			return ParticleSimulationSpace.Local;
		}

		public static ParticleShape ParticleShape(NetworkReader reader)
		{
			return ParticleShape.Sphere;
		}

		public static void BodyPart(NetworkWriter writer, BodyPart value)
		{
		}

		public static BodyPart BodyPart(NetworkReader reader)
		{
			return BodyPart.Head;
		}

		public static void HorizontalAlignmentOptions(NetworkWriter writer, HorizontalAlignmentOptions value)
		{
		}

		public static HorizontalAlignmentOptions HorizontalAlignmentOptions(NetworkReader reader)
		{
			return (HorizontalAlignmentOptions)0;
		}

		public static void VerticalAlignmentOptions(NetworkWriter writer, VerticalAlignmentOptions value)
		{
		}

		public static VerticalAlignmentOptions VerticalAlignmentOptions(NetworkReader reader)
		{
			return (VerticalAlignmentOptions)0;
		}

		public static void TextFontPreset(NetworkWriter writer, TextFontPreset value)
		{
		}

		public static TextFontPreset TextFontPreset(NetworkReader reader)
		{
			return TextFontPreset.SourceSans;
		}

		public static void TextJustify(NetworkWriter writer, TextJustify value)
		{
		}

		public static void TextVerticalAlign(NetworkWriter writer, TextVerticalAlign value)
		{
		}

		public static TextJustify TextJustify(NetworkReader reader)
		{
			return TextJustify.Left;
		}

		public static TextVerticalAlign TextVerticalAlign(NetworkReader reader)
		{
			return TextVerticalAlign.Top;
		}

		public static void TextAnchor(NetworkWriter writer, TextAnchor value)
		{
		}

		public static TextAnchor TextAnchor(NetworkReader reader)
		{
			return TextAnchor.UpperLeft;
		}

		public static void String[](NetworkWriter writer, string[] value)
		{
		}

		public static string[] String[](NetworkReader reader)
		{
			return null;
		}

		public static void InitReadWriters()
		{
		}
	}
}
