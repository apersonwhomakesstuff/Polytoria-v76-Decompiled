using System;

namespace MoonSharp.Interpreter.Debugging
{
	// Token: 0x020000FF RID: 255
	public class WatchItem
	{
		// Token: 0x170001A9 RID: 425
		// (get) Token: 0x06000B76 RID: 2934 RVA: 0x0000E970 File Offset: 0x0000CB70
		// (set) Token: 0x06000B77 RID: 2935 RVA: 0x0000E978 File Offset: 0x0000CB78
		public int Address
		{
			get
			{
				return this.<Address>k__BackingField;
			}
			set
			{
				this.<Address>k__BackingField = value;
			}
		}

		// Token: 0x170001AA RID: 426
		// (get) Token: 0x06000B78 RID: 2936 RVA: 0x0000E981 File Offset: 0x0000CB81
		// (set) Token: 0x06000B79 RID: 2937 RVA: 0x0000E989 File Offset: 0x0000CB89
		public int BasePtr
		{
			get
			{
				return this.<BasePtr>k__BackingField;
			}
			set
			{
				this.<BasePtr>k__BackingField = value;
			}
		}

		// Token: 0x170001AB RID: 427
		// (get) Token: 0x06000B7A RID: 2938 RVA: 0x0000E992 File Offset: 0x0000CB92
		// (set) Token: 0x06000B7B RID: 2939 RVA: 0x0000E99A File Offset: 0x0000CB9A
		public int RetAddress
		{
			get
			{
				return this.<RetAddress>k__BackingField;
			}
			set
			{
				this.<RetAddress>k__BackingField = value;
			}
		}

		// Token: 0x170001AC RID: 428
		// (get) Token: 0x06000B7C RID: 2940 RVA: 0x0000E9A3 File Offset: 0x0000CBA3
		// (set) Token: 0x06000B7D RID: 2941 RVA: 0x0000E9AB File Offset: 0x0000CBAB
		public string Name
		{
			get
			{
				return this.<Name>k__BackingField;
			}
			set
			{
				this.<Name>k__BackingField = value;
			}
		}

		// Token: 0x170001AD RID: 429
		// (get) Token: 0x06000B7E RID: 2942 RVA: 0x0000E9B4 File Offset: 0x0000CBB4
		// (set) Token: 0x06000B7F RID: 2943 RVA: 0x0000E9BC File Offset: 0x0000CBBC
		public DynValue Value
		{
			get
			{
				return this.<Value>k__BackingField;
			}
			set
			{
				this.<Value>k__BackingField = value;
			}
		}

		// Token: 0x170001AE RID: 430
		// (get) Token: 0x06000B80 RID: 2944 RVA: 0x0000E9C5 File Offset: 0x0000CBC5
		// (set) Token: 0x06000B81 RID: 2945 RVA: 0x0000E9CD File Offset: 0x0000CBCD
		public SymbolRef LValue
		{
			get
			{
				return this.<LValue>k__BackingField;
			}
			set
			{
				this.<LValue>k__BackingField = value;
			}
		}

		// Token: 0x170001AF RID: 431
		// (get) Token: 0x06000B82 RID: 2946 RVA: 0x0000E9D6 File Offset: 0x0000CBD6
		// (set) Token: 0x06000B83 RID: 2947 RVA: 0x0000E9DE File Offset: 0x0000CBDE
		public bool IsError
		{
			get
			{
				return this.<IsError>k__BackingField;
			}
			set
			{
				this.<IsError>k__BackingField = value;
			}
		}

		// Token: 0x170001B0 RID: 432
		// (get) Token: 0x06000B84 RID: 2948 RVA: 0x0000E9E7 File Offset: 0x0000CBE7
		// (set) Token: 0x06000B85 RID: 2949 RVA: 0x0000E9EF File Offset: 0x0000CBEF
		public SourceRef Location
		{
			get
			{
				return this.<Location>k__BackingField;
			}
			set
			{
				this.<Location>k__BackingField = value;
			}
		}

		// Token: 0x06000B86 RID: 2950 RVA: 0x0000E9F8 File Offset: 0x0000CBF8
		public override string ToString()
		{
			return null;
		}

		// Token: 0x04000486 RID: 1158
		private int <Address>k__BackingField;

		// Token: 0x04000487 RID: 1159
		private int <BasePtr>k__BackingField;

		// Token: 0x04000488 RID: 1160
		private int <RetAddress>k__BackingField;

		// Token: 0x04000489 RID: 1161
		private string <Name>k__BackingField;

		// Token: 0x0400048A RID: 1162
		private DynValue <Value>k__BackingField;

		// Token: 0x0400048B RID: 1163
		private SymbolRef <LValue>k__BackingField;

		// Token: 0x0400048C RID: 1164
		private bool <IsError>k__BackingField;

		// Token: 0x0400048D RID: 1165
		private SourceRef <Location>k__BackingField;
	}
}
