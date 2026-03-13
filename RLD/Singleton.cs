using System;

namespace RLD
{
	// Token: 0x020001F3 RID: 499
	public abstract class Singleton<T> where T : class, new()
	{
		// Token: 0x170007F3 RID: 2035
		// (get) Token: 0x06001742 RID: 5954 RVA: 0x00023684 File Offset: 0x00021884
		public static T Get
		{
			get
			{
				return default(T);
			}
		}

		// Token: 0x04000818 RID: 2072
		private static T _instance;
	}
}
