using System;
using System.Collections.Generic;

namespace RLD
{
	// Token: 0x0200018F RID: 399
	public static class GameObjectTypeHelper
	{
		// Token: 0x170005BD RID: 1469
		// (get) Token: 0x060011D5 RID: 4565 RVA: 0x00018F56 File Offset: 0x00017156
		public static int NumTypes
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x170005BE RID: 1470
		// (get) Token: 0x060011D6 RID: 4566 RVA: 0x00018F59 File Offset: 0x00017159
		public static GameObjectType[] AllObjectTypes
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170005BF RID: 1471
		// (get) Token: 0x060011D7 RID: 4567 RVA: 0x0002192C File Offset: 0x0001FB2C
		public static GameObjectType AllCombined
		{
			get
			{
				return (GameObjectType)0;
			}
		}

		// Token: 0x060011D8 RID: 4568 RVA: 0x00018F5C File Offset: 0x0001715C
		public static bool Is3DObjectType(GameObjectType objectType)
		{
			return false;
		}

		// Token: 0x060011D9 RID: 4569 RVA: 0x00018F5F File Offset: 0x0001715F
		public static bool Is2DObjectType(GameObjectType objectType)
		{
			return false;
		}

		// Token: 0x060011DA RID: 4570 RVA: 0x00018F62 File Offset: 0x00017162
		public static bool HasVolume(GameObjectType objectType)
		{
			return false;
		}

		// Token: 0x060011DB RID: 4571 RVA: 0x00018F65 File Offset: 0x00017165
		public static bool IsTypeBitSet(int objectTypeMask, GameObjectType typeBit)
		{
			return false;
		}

		// Token: 0x060011DC RID: 4572 RVA: 0x00018F68 File Offset: 0x00017168
		public static int SetTypeBit(int objectTypeMask, GameObjectType typeBit)
		{
			return 0;
		}

		// Token: 0x060011DD RID: 4573 RVA: 0x00018F6B File Offset: 0x0001716B
		public static int ClearTypeBit(int objectTypeMask, GameObjectType typeBit)
		{
			return 0;
		}

		// Token: 0x04000651 RID: 1617
		private static int _numTypes;

		// Token: 0x04000652 RID: 1618
		private static List<GameObjectType> _allObjectTypes;

		// Token: 0x04000653 RID: 1619
		private static GameObjectType _allCombined;
	}
}
