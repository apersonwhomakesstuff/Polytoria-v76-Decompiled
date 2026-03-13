using System;
using System.Reflection;

namespace MoonSharp.Interpreter.Compatibility.Frameworks
{
	// Token: 0x02000125 RID: 293
	internal abstract class FrameworkReflectionBase : FrameworkBase
	{
		// Token: 0x06000D2B RID: 3371
		public abstract Type GetTypeInfoFromType(Type t);

		// Token: 0x06000D2C RID: 3372 RVA: 0x0000EECB File Offset: 0x0000D0CB
		public override Assembly GetAssembly(Type t)
		{
			return null;
		}

		// Token: 0x06000D2D RID: 3373 RVA: 0x0000EECE File Offset: 0x0000D0CE
		public override Type GetBaseType(Type t)
		{
			return null;
		}

		// Token: 0x06000D2E RID: 3374 RVA: 0x0000EED1 File Offset: 0x0000D0D1
		public override bool IsValueType(Type t)
		{
			return false;
		}

		// Token: 0x06000D2F RID: 3375 RVA: 0x0000EED4 File Offset: 0x0000D0D4
		public override bool IsInterface(Type t)
		{
			return false;
		}

		// Token: 0x06000D30 RID: 3376 RVA: 0x0000EED7 File Offset: 0x0000D0D7
		public override bool IsNestedPublic(Type t)
		{
			return false;
		}

		// Token: 0x06000D31 RID: 3377 RVA: 0x0000EEDA File Offset: 0x0000D0DA
		public override bool IsAbstract(Type t)
		{
			return false;
		}

		// Token: 0x06000D32 RID: 3378 RVA: 0x0000EEDD File Offset: 0x0000D0DD
		public override bool IsEnum(Type t)
		{
			return false;
		}

		// Token: 0x06000D33 RID: 3379 RVA: 0x0000EEE0 File Offset: 0x0000D0E0
		public override bool IsGenericTypeDefinition(Type t)
		{
			return false;
		}

		// Token: 0x06000D34 RID: 3380 RVA: 0x0000EEE3 File Offset: 0x0000D0E3
		public override bool IsGenericType(Type t)
		{
			return false;
		}

		// Token: 0x06000D35 RID: 3381 RVA: 0x0000EEE6 File Offset: 0x0000D0E6
		public override Attribute[] GetCustomAttributes(Type t, bool inherit)
		{
			return null;
		}

		// Token: 0x06000D36 RID: 3382 RVA: 0x0000EEE9 File Offset: 0x0000D0E9
		public override Attribute[] GetCustomAttributes(Type t, Type at, bool inherit)
		{
			return null;
		}
	}
}
