using System;

namespace Polytoria.Datamodel.Proxies
{
	// Token: 0x020002CF RID: 719
	public class BaseScriptProxy : InstanceProxy
	{
		// Token: 0x06002445 RID: 9285 RVA: 0x0001BF98 File Offset: 0x0001A198
		public BaseScriptProxy(BaseScript target) : base(null)
		{
		}

		// Token: 0x17000AE0 RID: 2784
		// (get) Token: 0x06002446 RID: 9286 RVA: 0x0001BFA1 File Offset: 0x0001A1A1
		// (set) Token: 0x06002447 RID: 9287 RVA: 0x0001BFA4 File Offset: 0x0001A1A4
		public new object Item
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x06002448 RID: 9288 RVA: 0x0001BFA6 File Offset: 0x0001A1A6
		public void Call(string function, object[] args)
		{
		}

		// Token: 0x04000CFB RID: 3323
		private readonly BaseScript baseScript;
	}
}
