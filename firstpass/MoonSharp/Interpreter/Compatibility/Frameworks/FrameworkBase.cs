using System;
using System.Reflection;

namespace MoonSharp.Interpreter.Compatibility.Frameworks
{
	// Token: 0x02000123 RID: 291
	public abstract class FrameworkBase
	{
		// Token: 0x06000CF7 RID: 3319
		public abstract bool StringContainsChar(string str, char chr);

		// Token: 0x06000CF8 RID: 3320
		public abstract bool IsValueType(Type t);

		// Token: 0x06000CF9 RID: 3321
		public abstract Assembly GetAssembly(Type t);

		// Token: 0x06000CFA RID: 3322
		public abstract Type GetBaseType(Type t);

		// Token: 0x06000CFB RID: 3323
		public abstract bool IsGenericType(Type t);

		// Token: 0x06000CFC RID: 3324
		public abstract bool IsGenericTypeDefinition(Type t);

		// Token: 0x06000CFD RID: 3325
		public abstract bool IsEnum(Type t);

		// Token: 0x06000CFE RID: 3326
		public abstract bool IsNestedPublic(Type t);

		// Token: 0x06000CFF RID: 3327
		public abstract bool IsAbstract(Type t);

		// Token: 0x06000D00 RID: 3328
		public abstract bool IsInterface(Type t);

		// Token: 0x06000D01 RID: 3329
		public abstract Attribute[] GetCustomAttributes(Type t, bool inherit);

		// Token: 0x06000D02 RID: 3330
		public abstract Attribute[] GetCustomAttributes(Type t, Type at, bool inherit);

		// Token: 0x06000D03 RID: 3331
		public abstract Type[] GetInterfaces(Type t);

		// Token: 0x06000D04 RID: 3332
		public abstract bool IsInstanceOfType(Type t, object o);

		// Token: 0x06000D05 RID: 3333
		public abstract MethodInfo GetAddMethod(EventInfo ei);

		// Token: 0x06000D06 RID: 3334
		public abstract MethodInfo GetRemoveMethod(EventInfo ei);

		// Token: 0x06000D07 RID: 3335
		public abstract MethodInfo GetGetMethod(PropertyInfo pi);

		// Token: 0x06000D08 RID: 3336
		public abstract MethodInfo GetSetMethod(PropertyInfo pi);

		// Token: 0x06000D09 RID: 3337
		public abstract Type GetInterface(Type type, string name);

		// Token: 0x06000D0A RID: 3338
		public abstract PropertyInfo[] GetProperties(Type type);

		// Token: 0x06000D0B RID: 3339
		public abstract PropertyInfo GetProperty(Type type, string name);

		// Token: 0x06000D0C RID: 3340
		public abstract Type[] GetNestedTypes(Type type);

		// Token: 0x06000D0D RID: 3341
		public abstract EventInfo[] GetEvents(Type type);

		// Token: 0x06000D0E RID: 3342
		public abstract ConstructorInfo[] GetConstructors(Type type);

		// Token: 0x06000D0F RID: 3343
		public abstract Type[] GetAssemblyTypes(Assembly asm);

		// Token: 0x06000D10 RID: 3344
		public abstract MethodInfo[] GetMethods(Type type);

		// Token: 0x06000D11 RID: 3345
		public abstract FieldInfo[] GetFields(Type t);

		// Token: 0x06000D12 RID: 3346
		public abstract MethodInfo GetMethod(Type type, string name);

		// Token: 0x06000D13 RID: 3347
		public abstract Type[] GetGenericArguments(Type t);

		// Token: 0x06000D14 RID: 3348
		public abstract bool IsAssignableFrom(Type current, Type toCompare);

		// Token: 0x06000D15 RID: 3349
		public abstract bool IsDbNull(object o);

		// Token: 0x06000D16 RID: 3350
		public abstract MethodInfo GetMethod(Type resourcesType, string v, Type[] type);
	}
}
