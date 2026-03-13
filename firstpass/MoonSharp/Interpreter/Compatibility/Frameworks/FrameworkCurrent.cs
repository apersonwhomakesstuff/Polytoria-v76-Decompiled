using System;

namespace MoonSharp.Interpreter.Compatibility.Frameworks
{
	// Token: 0x02000126 RID: 294
	internal class FrameworkCurrent : FrameworkClrBase
	{
		// Token: 0x06000D38 RID: 3384 RVA: 0x0000EEF4 File Offset: 0x0000D0F4
		public override Type GetTypeInfoFromType(Type t)
		{
			return null;
		}

		// Token: 0x06000D39 RID: 3385 RVA: 0x0000EEF7 File Offset: 0x0000D0F7
		public override bool IsDbNull(object o)
		{
			return false;
		}

		// Token: 0x06000D3A RID: 3386 RVA: 0x0000EEFA File Offset: 0x0000D0FA
		public override bool StringContainsChar(string str, char chr)
		{
			return false;
		}

		// Token: 0x06000D3B RID: 3387 RVA: 0x0000EEFD File Offset: 0x0000D0FD
		public override Type GetInterface(Type type, string name)
		{
			return null;
		}
	}
}
