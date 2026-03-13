using System;
using System.Collections.Generic;

namespace MoonSharp.Interpreter.Debugging
{
	// Token: 0x020000FD RID: 253
	public class SourceCode : IScriptPrivateResource
	{
		// Token: 0x1700019B RID: 411
		// (get) Token: 0x06000B4F RID: 2895 RVA: 0x0000E852 File Offset: 0x0000CA52
		// (set) Token: 0x06000B50 RID: 2896 RVA: 0x0000E85A File Offset: 0x0000CA5A
		public string Name
		{
			get
			{
				return this.<Name>k__BackingField;
			}
			private set
			{
				this.<Name>k__BackingField = value;
			}
		}

		// Token: 0x1700019C RID: 412
		// (get) Token: 0x06000B51 RID: 2897 RVA: 0x0000E863 File Offset: 0x0000CA63
		// (set) Token: 0x06000B52 RID: 2898 RVA: 0x0000E86B File Offset: 0x0000CA6B
		public string Code
		{
			get
			{
				return this.<Code>k__BackingField;
			}
			private set
			{
				this.<Code>k__BackingField = value;
			}
		}

		// Token: 0x1700019D RID: 413
		// (get) Token: 0x06000B53 RID: 2899 RVA: 0x0000E874 File Offset: 0x0000CA74
		// (set) Token: 0x06000B54 RID: 2900 RVA: 0x0000E87C File Offset: 0x0000CA7C
		public string[] Lines
		{
			get
			{
				return this.<Lines>k__BackingField;
			}
			private set
			{
				this.<Lines>k__BackingField = value;
			}
		}

		// Token: 0x1700019E RID: 414
		// (get) Token: 0x06000B55 RID: 2901 RVA: 0x0000E885 File Offset: 0x0000CA85
		// (set) Token: 0x06000B56 RID: 2902 RVA: 0x0000E88D File Offset: 0x0000CA8D
		public Script OwnerScript
		{
			get
			{
				return this.<OwnerScript>k__BackingField;
			}
			private set
			{
				this.<OwnerScript>k__BackingField = value;
			}
		}

		// Token: 0x1700019F RID: 415
		// (get) Token: 0x06000B57 RID: 2903 RVA: 0x0000E896 File Offset: 0x0000CA96
		// (set) Token: 0x06000B58 RID: 2904 RVA: 0x0000E89E File Offset: 0x0000CA9E
		public int SourceID
		{
			get
			{
				return this.<SourceID>k__BackingField;
			}
			private set
			{
				this.<SourceID>k__BackingField = value;
			}
		}

		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x06000B59 RID: 2905 RVA: 0x0000E8A7 File Offset: 0x0000CAA7
		// (set) Token: 0x06000B5A RID: 2906 RVA: 0x0000E8AF File Offset: 0x0000CAAF
		internal List<SourceRef> Refs
		{
			get
			{
				return this.<Refs>k__BackingField;
			}
			private set
			{
				this.<Refs>k__BackingField = value;
			}
		}

		// Token: 0x06000B5B RID: 2907 RVA: 0x0000E8B8 File Offset: 0x0000CAB8
		internal SourceCode(string name, string code, int sourceID, Script ownerScript)
		{
		}

		// Token: 0x06000B5C RID: 2908 RVA: 0x0000E8C0 File Offset: 0x0000CAC0
		public string GetCodeSnippet(SourceRef sourceCodeRef)
		{
			return null;
		}

		// Token: 0x06000B5D RID: 2909 RVA: 0x0000E8C3 File Offset: 0x0000CAC3
		private int AdjustStrIndex(string str, int loc)
		{
			return 0;
		}

		// Token: 0x04000477 RID: 1143
		private string <Name>k__BackingField;

		// Token: 0x04000478 RID: 1144
		private string <Code>k__BackingField;

		// Token: 0x04000479 RID: 1145
		private string[] <Lines>k__BackingField;

		// Token: 0x0400047A RID: 1146
		private Script <OwnerScript>k__BackingField;

		// Token: 0x0400047B RID: 1147
		private int <SourceID>k__BackingField;

		// Token: 0x0400047C RID: 1148
		private List<SourceRef> <Refs>k__BackingField;
	}
}
