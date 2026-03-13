using System;
using System.Reflection;

namespace MoonSharp.Interpreter.Compatibility.Frameworks
{
	// Token: 0x02000124 RID: 292
	internal abstract class FrameworkClrBase : FrameworkReflectionBase
	{
		// Token: 0x06000D18 RID: 3352 RVA: 0x0000EE8D File Offset: 0x0000D08D
		public override MethodInfo GetAddMethod(EventInfo ei)
		{
			return null;
		}

		// Token: 0x06000D19 RID: 3353 RVA: 0x0000EE90 File Offset: 0x0000D090
		public override ConstructorInfo[] GetConstructors(Type type)
		{
			return null;
		}

		// Token: 0x06000D1A RID: 3354 RVA: 0x0000EE93 File Offset: 0x0000D093
		public override EventInfo[] GetEvents(Type type)
		{
			return null;
		}

		// Token: 0x06000D1B RID: 3355 RVA: 0x0000EE96 File Offset: 0x0000D096
		public override FieldInfo[] GetFields(Type type)
		{
			return null;
		}

		// Token: 0x06000D1C RID: 3356 RVA: 0x0000EE99 File Offset: 0x0000D099
		public override Type[] GetGenericArguments(Type type)
		{
			return null;
		}

		// Token: 0x06000D1D RID: 3357 RVA: 0x0000EE9C File Offset: 0x0000D09C
		public override MethodInfo GetGetMethod(PropertyInfo pi)
		{
			return null;
		}

		// Token: 0x06000D1E RID: 3358 RVA: 0x0000EE9F File Offset: 0x0000D09F
		public override Type[] GetInterfaces(Type t)
		{
			return null;
		}

		// Token: 0x06000D1F RID: 3359 RVA: 0x0000EEA2 File Offset: 0x0000D0A2
		public override MethodInfo GetMethod(Type type, string name)
		{
			return null;
		}

		// Token: 0x06000D20 RID: 3360 RVA: 0x0000EEA5 File Offset: 0x0000D0A5
		public override MethodInfo[] GetMethods(Type type)
		{
			return null;
		}

		// Token: 0x06000D21 RID: 3361 RVA: 0x0000EEA8 File Offset: 0x0000D0A8
		public override Type[] GetNestedTypes(Type type)
		{
			return null;
		}

		// Token: 0x06000D22 RID: 3362 RVA: 0x0000EEAB File Offset: 0x0000D0AB
		public override PropertyInfo[] GetProperties(Type type)
		{
			return null;
		}

		// Token: 0x06000D23 RID: 3363 RVA: 0x0000EEAE File Offset: 0x0000D0AE
		public override PropertyInfo GetProperty(Type type, string name)
		{
			return null;
		}

		// Token: 0x06000D24 RID: 3364 RVA: 0x0000EEB1 File Offset: 0x0000D0B1
		public override MethodInfo GetRemoveMethod(EventInfo ei)
		{
			return null;
		}

		// Token: 0x06000D25 RID: 3365 RVA: 0x0000EEB4 File Offset: 0x0000D0B4
		public override MethodInfo GetSetMethod(PropertyInfo pi)
		{
			return null;
		}

		// Token: 0x06000D26 RID: 3366 RVA: 0x0000EEB7 File Offset: 0x0000D0B7
		public override bool IsAssignableFrom(Type current, Type toCompare)
		{
			return false;
		}

		// Token: 0x06000D27 RID: 3367 RVA: 0x0000EEBA File Offset: 0x0000D0BA
		public override bool IsInstanceOfType(Type t, object o)
		{
			return false;
		}

		// Token: 0x06000D28 RID: 3368 RVA: 0x0000EEBD File Offset: 0x0000D0BD
		public override MethodInfo GetMethod(Type resourcesType, string name, Type[] types)
		{
			return null;
		}

		// Token: 0x06000D29 RID: 3369 RVA: 0x0000EEC0 File Offset: 0x0000D0C0
		public override Type[] GetAssemblyTypes(Assembly asm)
		{
			return null;
		}

		// Token: 0x040004B7 RID: 1207
		private BindingFlags BINDINGFLAGS_MEMBER;

		// Token: 0x040004B8 RID: 1208
		private BindingFlags BINDINGFLAGS_INNERCLASS;
	}
}
