using System;
using System.Collections.Generic;

namespace RLD
{
	// Token: 0x02000211 RID: 529
	public static class StringMatch
	{
		// Token: 0x060017E7 RID: 6119 RVA: 0x00019E8D File Offset: 0x0001808D
		public static void Match(List<string> strings, string stringToMatch, StringMatch.Case matchCase, List<string> matches)
		{
		}

		// Token: 0x020003CD RID: 973
		public enum Case
		{
			// Token: 0x04001034 RID: 4148
			Sensitive,
			// Token: 0x04001035 RID: 4149
			Insensitive
		}
	}
}
