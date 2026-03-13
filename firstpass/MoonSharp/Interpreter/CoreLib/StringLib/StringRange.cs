using System;

namespace MoonSharp.Interpreter.CoreLib.StringLib
{
	// Token: 0x0200011B RID: 283
	internal class StringRange
	{
		// Token: 0x170001BC RID: 444
		// (get) Token: 0x06000CBF RID: 3263 RVA: 0x0000EDCB File Offset: 0x0000CFCB
		// (set) Token: 0x06000CC0 RID: 3264 RVA: 0x0000EDD3 File Offset: 0x0000CFD3
		public int Start
		{
			get
			{
				return this.<Start>k__BackingField;
			}
			set
			{
				this.<Start>k__BackingField = value;
			}
		}

		// Token: 0x170001BD RID: 445
		// (get) Token: 0x06000CC1 RID: 3265 RVA: 0x0000EDDC File Offset: 0x0000CFDC
		// (set) Token: 0x06000CC2 RID: 3266 RVA: 0x0000EDE4 File Offset: 0x0000CFE4
		public int End
		{
			get
			{
				return this.<End>k__BackingField;
			}
			set
			{
				this.<End>k__BackingField = value;
			}
		}

		// Token: 0x06000CC3 RID: 3267 RVA: 0x0000EDED File Offset: 0x0000CFED
		public StringRange()
		{
		}

		// Token: 0x06000CC4 RID: 3268 RVA: 0x0000EDF5 File Offset: 0x0000CFF5
		public StringRange(int start, int end)
		{
		}

		// Token: 0x06000CC5 RID: 3269 RVA: 0x0000EDFD File Offset: 0x0000CFFD
		public static StringRange FromLuaRange(DynValue start, DynValue end, int? defaultEnd = null)
		{
			return null;
		}

		// Token: 0x06000CC6 RID: 3270 RVA: 0x0000EE00 File Offset: 0x0000D000
		public string ApplyToString(string value)
		{
			return null;
		}

		// Token: 0x06000CC7 RID: 3271 RVA: 0x0000EE03 File Offset: 0x0000D003
		public int Length()
		{
			return 0;
		}

		// Token: 0x040004B0 RID: 1200
		private int <Start>k__BackingField;

		// Token: 0x040004B1 RID: 1201
		private int <End>k__BackingField;
	}
}
