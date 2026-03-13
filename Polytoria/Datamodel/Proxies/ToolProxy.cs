using System;
using Polytoria.Lua;

namespace Polytoria.Datamodel.Proxies
{
	// Token: 0x020002FC RID: 764
	public class ToolProxy : DynamicInstanceProxy
	{
		// Token: 0x060026A9 RID: 9897 RVA: 0x0001C6DF File Offset: 0x0001A8DF
		public ToolProxy(Tool target) : base(null)
		{
		}

		// Token: 0x17000BE9 RID: 3049
		// (get) Token: 0x060026AA RID: 9898 RVA: 0x0001C6E8 File Offset: 0x0001A8E8
		public LuaEvent Activated
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000BEA RID: 3050
		// (get) Token: 0x060026AB RID: 9899 RVA: 0x0001C6EB File Offset: 0x0001A8EB
		public LuaEvent Deactivated
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000BEB RID: 3051
		// (get) Token: 0x060026AC RID: 9900 RVA: 0x0001C6EE File Offset: 0x0001A8EE
		public LuaEvent Equipped
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000BEC RID: 3052
		// (get) Token: 0x060026AD RID: 9901 RVA: 0x0001C6F1 File Offset: 0x0001A8F1
		public LuaEvent Unequipped
		{
			get
			{
				return null;
			}
		}

		// Token: 0x060026AE RID: 9902 RVA: 0x0001C6F4 File Offset: 0x0001A8F4
		public void Play(string anim)
		{
		}

		// Token: 0x17000BED RID: 3053
		// (get) Token: 0x060026AF RID: 9903 RVA: 0x0001C6F6 File Offset: 0x0001A8F6
		// (set) Token: 0x060026B0 RID: 9904 RVA: 0x0001C6F9 File Offset: 0x0001A8F9
		public bool Droppable
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x04000D28 RID: 3368
		private readonly Tool tool;
	}
}
