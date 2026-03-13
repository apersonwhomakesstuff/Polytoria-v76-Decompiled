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
	// Token: 0x02000347 RID: 839
	[StructLayout(3, CharSet = CharSet.Auto)]
	public static class GeneratedNetworkCode
	{
		// Token: 0x060029C0 RID: 10688 RVA: 0x0002635C File Offset: 0x0002455C
		public static TimeSnapshotMessage TimeSnapshotMessage(NetworkReader reader)
		{
			return default(TimeSnapshotMessage);
		}

		// Token: 0x060029C1 RID: 10689 RVA: 0x0001D080 File Offset: 0x0001B280
		public static void TimeSnapshotMessage(NetworkWriter writer, TimeSnapshotMessage value)
		{
		}

		// Token: 0x060029C2 RID: 10690 RVA: 0x00026374 File Offset: 0x00024574
		public static ReadyMessage ReadyMessage(NetworkReader reader)
		{
			return default(ReadyMessage);
		}

		// Token: 0x060029C3 RID: 10691 RVA: 0x0001D082 File Offset: 0x0001B282
		public static void ReadyMessage(NetworkWriter writer, ReadyMessage value)
		{
		}

		// Token: 0x060029C4 RID: 10692 RVA: 0x0002638C File Offset: 0x0002458C
		public static NotReadyMessage NotReadyMessage(NetworkReader reader)
		{
			return default(NotReadyMessage);
		}

		// Token: 0x060029C5 RID: 10693 RVA: 0x0001D084 File Offset: 0x0001B284
		public static void NotReadyMessage(NetworkWriter writer, NotReadyMessage value)
		{
		}

		// Token: 0x060029C6 RID: 10694 RVA: 0x000263A4 File Offset: 0x000245A4
		public static AddPlayerMessage AddPlayerMessage(NetworkReader reader)
		{
			return default(AddPlayerMessage);
		}

		// Token: 0x060029C7 RID: 10695 RVA: 0x0001D086 File Offset: 0x0001B286
		public static void AddPlayerMessage(NetworkWriter writer, AddPlayerMessage value)
		{
		}

		// Token: 0x060029C8 RID: 10696 RVA: 0x000263BC File Offset: 0x000245BC
		public static SceneMessage SceneMessage(NetworkReader reader)
		{
			return default(SceneMessage);
		}

		// Token: 0x060029C9 RID: 10697 RVA: 0x000263D4 File Offset: 0x000245D4
		public static SceneOperation SceneOperation(NetworkReader reader)
		{
			return SceneOperation.Normal;
		}

		// Token: 0x060029CA RID: 10698 RVA: 0x0001D088 File Offset: 0x0001B288
		public static void SceneMessage(NetworkWriter writer, SceneMessage value)
		{
		}

		// Token: 0x060029CB RID: 10699 RVA: 0x0001D08A File Offset: 0x0001B28A
		public static void SceneOperation(NetworkWriter writer, SceneOperation value)
		{
		}

		// Token: 0x060029CC RID: 10700 RVA: 0x000263EC File Offset: 0x000245EC
		public static CommandMessage CommandMessage(NetworkReader reader)
		{
			return default(CommandMessage);
		}

		// Token: 0x060029CD RID: 10701 RVA: 0x0001D08C File Offset: 0x0001B28C
		public static void CommandMessage(NetworkWriter writer, CommandMessage value)
		{
		}

		// Token: 0x060029CE RID: 10702 RVA: 0x00026404 File Offset: 0x00024604
		public static RpcMessage RpcMessage(NetworkReader reader)
		{
			return default(RpcMessage);
		}

		// Token: 0x060029CF RID: 10703 RVA: 0x0001D08E File Offset: 0x0001B28E
		public static void RpcMessage(NetworkWriter writer, RpcMessage value)
		{
		}

		// Token: 0x060029D0 RID: 10704 RVA: 0x0002641C File Offset: 0x0002461C
		public static SpawnMessage SpawnMessage(NetworkReader reader)
		{
			return default(SpawnMessage);
		}

		// Token: 0x060029D1 RID: 10705 RVA: 0x00026434 File Offset: 0x00024634
		public static SpawnFlags SpawnFlags(NetworkReader reader)
		{
			return SpawnFlags.None;
		}

		// Token: 0x060029D2 RID: 10706 RVA: 0x0001D090 File Offset: 0x0001B290
		public static void SpawnMessage(NetworkWriter writer, SpawnMessage value)
		{
		}

		// Token: 0x060029D3 RID: 10707 RVA: 0x0001D092 File Offset: 0x0001B292
		public static void SpawnFlags(NetworkWriter writer, SpawnFlags value)
		{
		}

		// Token: 0x060029D4 RID: 10708 RVA: 0x0002644C File Offset: 0x0002464C
		public static ChangeOwnerMessage ChangeOwnerMessage(NetworkReader reader)
		{
			return default(ChangeOwnerMessage);
		}

		// Token: 0x060029D5 RID: 10709 RVA: 0x0001D094 File Offset: 0x0001B294
		public static void ChangeOwnerMessage(NetworkWriter writer, ChangeOwnerMessage value)
		{
		}

		// Token: 0x060029D6 RID: 10710 RVA: 0x00026464 File Offset: 0x00024664
		public static ObjectSpawnStartedMessage ObjectSpawnStartedMessage(NetworkReader reader)
		{
			return default(ObjectSpawnStartedMessage);
		}

		// Token: 0x060029D7 RID: 10711 RVA: 0x0001D096 File Offset: 0x0001B296
		public static void ObjectSpawnStartedMessage(NetworkWriter writer, ObjectSpawnStartedMessage value)
		{
		}

		// Token: 0x060029D8 RID: 10712 RVA: 0x0002647C File Offset: 0x0002467C
		public static ObjectSpawnFinishedMessage ObjectSpawnFinishedMessage(NetworkReader reader)
		{
			return default(ObjectSpawnFinishedMessage);
		}

		// Token: 0x060029D9 RID: 10713 RVA: 0x0001D098 File Offset: 0x0001B298
		public static void ObjectSpawnFinishedMessage(NetworkWriter writer, ObjectSpawnFinishedMessage value)
		{
		}

		// Token: 0x060029DA RID: 10714 RVA: 0x00026494 File Offset: 0x00024694
		public static ObjectDestroyMessage ObjectDestroyMessage(NetworkReader reader)
		{
			return default(ObjectDestroyMessage);
		}

		// Token: 0x060029DB RID: 10715 RVA: 0x0001D09A File Offset: 0x0001B29A
		public static void ObjectDestroyMessage(NetworkWriter writer, ObjectDestroyMessage value)
		{
		}

		// Token: 0x060029DC RID: 10716 RVA: 0x000264AC File Offset: 0x000246AC
		public static ObjectHideMessage ObjectHideMessage(NetworkReader reader)
		{
			return default(ObjectHideMessage);
		}

		// Token: 0x060029DD RID: 10717 RVA: 0x0001D09C File Offset: 0x0001B29C
		public static void ObjectHideMessage(NetworkWriter writer, ObjectHideMessage value)
		{
		}

		// Token: 0x060029DE RID: 10718 RVA: 0x000264C4 File Offset: 0x000246C4
		public static EntityStateMessage EntityStateMessage(NetworkReader reader)
		{
			return default(EntityStateMessage);
		}

		// Token: 0x060029DF RID: 10719 RVA: 0x0001D09E File Offset: 0x0001B29E
		public static void EntityStateMessage(NetworkWriter writer, EntityStateMessage value)
		{
		}

		// Token: 0x060029E0 RID: 10720 RVA: 0x000264DC File Offset: 0x000246DC
		public static NetworkPingMessage NetworkPingMessage(NetworkReader reader)
		{
			return default(NetworkPingMessage);
		}

		// Token: 0x060029E1 RID: 10721 RVA: 0x0001D0A0 File Offset: 0x0001B2A0
		public static void NetworkPingMessage(NetworkWriter writer, NetworkPingMessage value)
		{
		}

		// Token: 0x060029E2 RID: 10722 RVA: 0x000264F4 File Offset: 0x000246F4
		public static NetworkPongMessage NetworkPongMessage(NetworkReader reader)
		{
			return default(NetworkPongMessage);
		}

		// Token: 0x060029E3 RID: 10723 RVA: 0x0001D0A2 File Offset: 0x0001B2A2
		public static void NetworkPongMessage(NetworkWriter writer, NetworkPongMessage value)
		{
		}

		// Token: 0x060029E4 RID: 10724 RVA: 0x0002650C File Offset: 0x0002470C
		public static ServerRequest ServerRequest(NetworkReader reader)
		{
			return default(ServerRequest);
		}

		// Token: 0x060029E5 RID: 10725 RVA: 0x0001D0A4 File Offset: 0x0001B2A4
		public static void ServerRequest(NetworkWriter writer, ServerRequest value)
		{
		}

		// Token: 0x060029E6 RID: 10726 RVA: 0x00026524 File Offset: 0x00024724
		public static ServerResponse ServerResponse(NetworkReader reader)
		{
			return default(ServerResponse);
		}

		// Token: 0x060029E7 RID: 10727 RVA: 0x0001D0A6 File Offset: 0x0001B2A6
		public static void ServerResponse(NetworkWriter writer, ServerResponse value)
		{
		}

		// Token: 0x060029E8 RID: 10728 RVA: 0x0002653C File Offset: 0x0002473C
		public static PTAuthenticator.AuthRequestMessage PTAuthenticator/AuthRequestMessage(NetworkReader reader)
		{
			return default(PTAuthenticator.AuthRequestMessage);
		}

		// Token: 0x060029E9 RID: 10729 RVA: 0x0001D0A8 File Offset: 0x0001B2A8
		public static void PTAuthenticator/AuthRequestMessage(NetworkWriter writer, PTAuthenticator.AuthRequestMessage value)
		{
		}

		// Token: 0x060029EA RID: 10730 RVA: 0x00026554 File Offset: 0x00024754
		public static PTAuthenticator.AuthResponseMessage PTAuthenticator/AuthResponseMessage(NetworkReader reader)
		{
			return default(PTAuthenticator.AuthResponseMessage);
		}

		// Token: 0x060029EB RID: 10731 RVA: 0x0001D0AA File Offset: 0x0001B2AA
		public static void PTAuthenticator/AuthResponseMessage(NetworkWriter writer, PTAuthenticator.AuthResponseMessage value)
		{
		}

		// Token: 0x060029EC RID: 10732 RVA: 0x0001D0AC File Offset: 0x0001B2AC
		public static void PartShape(NetworkWriter writer, PartShape value)
		{
		}

		// Token: 0x060029ED RID: 10733 RVA: 0x0002656C File Offset: 0x0002476C
		public static PartShape PartShape(NetworkReader reader)
		{
			return PartShape.Brick;
		}

		// Token: 0x060029EE RID: 10734 RVA: 0x0001D0AE File Offset: 0x0001B2AE
		public static void PartMaterial(NetworkWriter writer, PartMaterial value)
		{
		}

		// Token: 0x060029EF RID: 10735 RVA: 0x00026584 File Offset: 0x00024784
		public static PartMaterial PartMaterial(NetworkReader reader)
		{
			return PartMaterial.SmoothPlastic;
		}

		// Token: 0x060029F0 RID: 10736 RVA: 0x0001D0B0 File Offset: 0x0001B2B0
		public static void PhysicsMaterialCombine(NetworkWriter writer, PhysicsMaterialCombine value)
		{
		}

		// Token: 0x060029F1 RID: 10737 RVA: 0x0002659C File Offset: 0x0002479C
		public static PhysicsMaterialCombine PhysicsMaterialCombine(NetworkReader reader)
		{
			return PhysicsMaterialCombine.Average;
		}

		// Token: 0x060029F2 RID: 10738 RVA: 0x0001D0B2 File Offset: 0x0001B2B2
		public static void ImageType(NetworkWriter writer, ImageType value)
		{
		}

		// Token: 0x060029F3 RID: 10739 RVA: 0x000265B4 File Offset: 0x000247B4
		public static ImageType ImageType(NetworkReader reader)
		{
			return ImageType.Asset;
		}

		// Token: 0x060029F4 RID: 10740 RVA: 0x0001D0B4 File Offset: 0x0001B2B4
		public static void SkyboxPreset(NetworkWriter writer, SkyboxPreset value)
		{
		}

		// Token: 0x060029F5 RID: 10741 RVA: 0x000265CC File Offset: 0x000247CC
		public static SkyboxPreset SkyboxPreset(NetworkReader reader)
		{
			return SkyboxPreset.Day1;
		}

		// Token: 0x060029F6 RID: 10742 RVA: 0x0001D0B6 File Offset: 0x0001B2B6
		public static void ImageSky/SkyboxSide(NetworkWriter writer, ImageSky.SkyboxSide value)
		{
		}

		// Token: 0x060029F7 RID: 10743 RVA: 0x000265E4 File Offset: 0x000247E4
		public static ImageSky.SkyboxSide ImageSky/SkyboxSide(NetworkReader reader)
		{
			return ImageSky.SkyboxSide.Top;
		}

		// Token: 0x060029F8 RID: 10744 RVA: 0x0001D0B8 File Offset: 0x0001B2B8
		public static void AmbientSource(NetworkWriter writer, AmbientSource value)
		{
		}

		// Token: 0x060029F9 RID: 10745 RVA: 0x000265FC File Offset: 0x000247FC
		public static AmbientSource AmbientSource(NetworkReader reader)
		{
			return AmbientSource.Skybox;
		}

		// Token: 0x060029FA RID: 10746 RVA: 0x0001D0BA File Offset: 0x0001B2BA
		public static void CollisionType(NetworkWriter writer, CollisionType value)
		{
		}

		// Token: 0x060029FB RID: 10747 RVA: 0x00026614 File Offset: 0x00024814
		public static CollisionType CollisionType(NetworkReader reader)
		{
			return CollisionType.Bounds;
		}

		// Token: 0x060029FC RID: 10748 RVA: 0x0001D0BC File Offset: 0x0001B2BC
		public static void ColorRange(NetworkWriter writer, ColorRange value)
		{
		}

		// Token: 0x060029FD RID: 10749 RVA: 0x0001D0BE File Offset: 0x0001B2BE
		public static void ParticleColorMode(NetworkWriter writer, ParticleColorMode value)
		{
		}

		// Token: 0x060029FE RID: 10750 RVA: 0x0001D0C0 File Offset: 0x0001B2C0
		public static void NumberRange(NetworkWriter writer, NumberRange value)
		{
		}

		// Token: 0x060029FF RID: 10751 RVA: 0x0001D0C2 File Offset: 0x0001B2C2
		public static void ParticleSimulationSpace(NetworkWriter writer, ParticleSimulationSpace value)
		{
		}

		// Token: 0x06002A00 RID: 10752 RVA: 0x0001D0C4 File Offset: 0x0001B2C4
		public static void ParticleShape(NetworkWriter writer, ParticleShape value)
		{
		}

		// Token: 0x06002A01 RID: 10753 RVA: 0x0002662C File Offset: 0x0002482C
		public static ColorRange ColorRange(NetworkReader reader)
		{
			return default(ColorRange);
		}

		// Token: 0x06002A02 RID: 10754 RVA: 0x00026644 File Offset: 0x00024844
		public static ParticleColorMode ParticleColorMode(NetworkReader reader)
		{
			return ParticleColorMode.Multiply;
		}

		// Token: 0x06002A03 RID: 10755 RVA: 0x0002665C File Offset: 0x0002485C
		public static NumberRange NumberRange(NetworkReader reader)
		{
			return default(NumberRange);
		}

		// Token: 0x06002A04 RID: 10756 RVA: 0x00026674 File Offset: 0x00024874
		public static ParticleSimulationSpace ParticleSimulationSpace(NetworkReader reader)
		{
			return ParticleSimulationSpace.Local;
		}

		// Token: 0x06002A05 RID: 10757 RVA: 0x0002668C File Offset: 0x0002488C
		public static ParticleShape ParticleShape(NetworkReader reader)
		{
			return ParticleShape.Sphere;
		}

		// Token: 0x06002A06 RID: 10758 RVA: 0x0001D0C6 File Offset: 0x0001B2C6
		public static void BodyPart(NetworkWriter writer, BodyPart value)
		{
		}

		// Token: 0x06002A07 RID: 10759 RVA: 0x000266A4 File Offset: 0x000248A4
		public static BodyPart BodyPart(NetworkReader reader)
		{
			return BodyPart.Head;
		}

		// Token: 0x06002A08 RID: 10760 RVA: 0x0001D0C8 File Offset: 0x0001B2C8
		public static void HorizontalAlignmentOptions(NetworkWriter writer, HorizontalAlignmentOptions value)
		{
		}

		// Token: 0x06002A09 RID: 10761 RVA: 0x000266BC File Offset: 0x000248BC
		public static HorizontalAlignmentOptions HorizontalAlignmentOptions(NetworkReader reader)
		{
			return (HorizontalAlignmentOptions)0;
		}

		// Token: 0x06002A0A RID: 10762 RVA: 0x0001D0CA File Offset: 0x0001B2CA
		public static void VerticalAlignmentOptions(NetworkWriter writer, VerticalAlignmentOptions value)
		{
		}

		// Token: 0x06002A0B RID: 10763 RVA: 0x000266D4 File Offset: 0x000248D4
		public static VerticalAlignmentOptions VerticalAlignmentOptions(NetworkReader reader)
		{
			return (VerticalAlignmentOptions)0;
		}

		// Token: 0x06002A0C RID: 10764 RVA: 0x0001D0CC File Offset: 0x0001B2CC
		public static void TextFontPreset(NetworkWriter writer, TextFontPreset value)
		{
		}

		// Token: 0x06002A0D RID: 10765 RVA: 0x000266EC File Offset: 0x000248EC
		public static TextFontPreset TextFontPreset(NetworkReader reader)
		{
			return TextFontPreset.SourceSans;
		}

		// Token: 0x06002A0E RID: 10766 RVA: 0x0001D0CE File Offset: 0x0001B2CE
		public static void TextJustify(NetworkWriter writer, TextJustify value)
		{
		}

		// Token: 0x06002A0F RID: 10767 RVA: 0x0001D0D0 File Offset: 0x0001B2D0
		public static void TextVerticalAlign(NetworkWriter writer, TextVerticalAlign value)
		{
		}

		// Token: 0x06002A10 RID: 10768 RVA: 0x00026704 File Offset: 0x00024904
		public static TextJustify TextJustify(NetworkReader reader)
		{
			return TextJustify.Left;
		}

		// Token: 0x06002A11 RID: 10769 RVA: 0x0002671C File Offset: 0x0002491C
		public static TextVerticalAlign TextVerticalAlign(NetworkReader reader)
		{
			return TextVerticalAlign.Top;
		}

		// Token: 0x06002A12 RID: 10770 RVA: 0x0001D0D2 File Offset: 0x0001B2D2
		public static void TextAnchor(NetworkWriter writer, TextAnchor value)
		{
		}

		// Token: 0x06002A13 RID: 10771 RVA: 0x00026734 File Offset: 0x00024934
		public static TextAnchor TextAnchor(NetworkReader reader)
		{
			return TextAnchor.UpperLeft;
		}

		// Token: 0x06002A14 RID: 10772 RVA: 0x0001D0D4 File Offset: 0x0001B2D4
		public static void String[](NetworkWriter writer, string[] value)
		{
		}

		// Token: 0x06002A15 RID: 10773 RVA: 0x0001D0D6 File Offset: 0x0001B2D6
		public static string[] String[](NetworkReader reader)
		{
			return null;
		}

		// Token: 0x06002A16 RID: 10774 RVA: 0x0001D0D9 File Offset: 0x0001B2D9
		public static void InitReadWriters()
		{
		}
	}
}
