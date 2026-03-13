using System;
using System.Collections.Generic;
using Mirror;

namespace Polytoria.Datamodel
{
	// Token: 0x02000294 RID: 660
	public static class NetMessageReadWriteFunctions
	{
		// Token: 0x06001D88 RID: 7560 RVA: 0x0001AE23 File Offset: 0x00019023
		private static void WriteDictionary<T>(NetworkWriter writer, Dictionary<string, T> dict)
		{
		}

		// Token: 0x06001D89 RID: 7561 RVA: 0x0001AE25 File Offset: 0x00019025
		public static Dictionary<string, T> ReadDictionary<T>(NetworkReader reader)
		{
			return null;
		}

		// Token: 0x06001D8A RID: 7562 RVA: 0x0001AE28 File Offset: 0x00019028
		public static void WriteNetMessage(NetworkWriter writer, NetMessage value)
		{
		}

		// Token: 0x06001D8B RID: 7563 RVA: 0x0001AE2A File Offset: 0x0001902A
		public static NetMessage ReadNetMessage(NetworkReader reader)
		{
			return null;
		}
	}
}
