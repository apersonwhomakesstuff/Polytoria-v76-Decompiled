using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;

namespace MoonSharp.Interpreter.Interop
{
	// Token: 0x0200009B RID: 155
	public static class DescriptorHelpers
	{
		// Token: 0x060007A4 RID: 1956 RVA: 0x00010370 File Offset: 0x0000E570
		public static bool? GetVisibilityFromAttributes(MemberInfo mi)
		{
			return null;
		}

		// Token: 0x060007A5 RID: 1957 RVA: 0x0000D8FB File Offset: 0x0000BAFB
		public static bool IsDelegateType(Type t)
		{
			return false;
		}

		// Token: 0x060007A6 RID: 1958 RVA: 0x0000D8FE File Offset: 0x0000BAFE
		public static string GetClrVisibility(Type type)
		{
			return null;
		}

		// Token: 0x060007A7 RID: 1959 RVA: 0x0000D901 File Offset: 0x0000BB01
		public static string GetClrVisibility(FieldInfo info)
		{
			return null;
		}

		// Token: 0x060007A8 RID: 1960 RVA: 0x0000D904 File Offset: 0x0000BB04
		public static string GetClrVisibility(PropertyInfo info)
		{
			return null;
		}

		// Token: 0x060007A9 RID: 1961 RVA: 0x0000D907 File Offset: 0x0000BB07
		public static string GetClrVisibility(MethodBase info)
		{
			return null;
		}

		// Token: 0x060007AA RID: 1962 RVA: 0x0000D90A File Offset: 0x0000BB0A
		public static bool IsPropertyInfoPublic(PropertyInfo pi)
		{
			return false;
		}

		// Token: 0x060007AB RID: 1963 RVA: 0x0000D90D File Offset: 0x0000BB0D
		public static List<string> GetMetaNamesFromAttributes(MethodInfo mi)
		{
			return null;
		}

		// Token: 0x060007AC RID: 1964 RVA: 0x0000D910 File Offset: 0x0000BB10
		public static Type[] SafeGetTypes(Assembly asm)
		{
			return null;
		}

		// Token: 0x060007AD RID: 1965 RVA: 0x0000D913 File Offset: 0x0000BB13
		public static string GetConversionMethodName(Type type)
		{
			return null;
		}

		// Token: 0x060007AE RID: 1966 RVA: 0x0000D916 File Offset: 0x0000BB16
		public static IEnumerable<Type> GetAllImplementedTypes(Type t)
		{
			return null;
		}

		// Token: 0x060007AF RID: 1967 RVA: 0x0000D919 File Offset: 0x0000BB19
		public static bool IsValidSimpleIdentifier(string str)
		{
			return false;
		}

		// Token: 0x060007B0 RID: 1968 RVA: 0x0000D91C File Offset: 0x0000BB1C
		public static string ToValidSimpleIdentifier(string str)
		{
			return null;
		}

		// Token: 0x060007B1 RID: 1969 RVA: 0x0000D91F File Offset: 0x0000BB1F
		public static string Camelify(string name)
		{
			return null;
		}

		// Token: 0x060007B2 RID: 1970 RVA: 0x0000D922 File Offset: 0x0000BB22
		public static string UpperFirstLetter(string name)
		{
			return null;
		}

		// Token: 0x02000198 RID: 408
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06000F56 RID: 3926 RVA: 0x0000F493 File Offset: 0x0000D693
			internal string <GetMetaNamesFromAttributes>b__7_0(MoonSharpUserDataMetamethodAttribute a)
			{
				return null;
			}

			// Token: 0x0400068E RID: 1678
			public static readonly DescriptorHelpers.<>c <>9;

			// Token: 0x0400068F RID: 1679
			public static Func<MoonSharpUserDataMetamethodAttribute, string> <>9__7_0;
		}

		// Token: 0x02000199 RID: 409
		private sealed class <GetAllImplementedTypes>d__10 : IEnumerable<Type>, IEnumerable, IEnumerator<Type>, IEnumerator, IDisposable
		{
			// Token: 0x06000F57 RID: 3927 RVA: 0x0000F496 File Offset: 0x0000D696
			public <GetAllImplementedTypes>d__10(int <>1__state)
			{
			}

			// Token: 0x06000F58 RID: 3928 RVA: 0x0000F49E File Offset: 0x0000D69E
			void IDisposable.Dispose()
			{
			}

			// Token: 0x06000F59 RID: 3929 RVA: 0x0000F4A0 File Offset: 0x0000D6A0
			bool IEnumerator.MoveNext()
			{
				return false;
			}

			// Token: 0x170001E7 RID: 487
			// (get) Token: 0x06000F5A RID: 3930 RVA: 0x0000F4A3 File Offset: 0x0000D6A3
			Type IEnumerator<Type>.Current
			{
				get
				{
					return null;
				}
			}

			// Token: 0x06000F5B RID: 3931 RVA: 0x0000F4A6 File Offset: 0x0000D6A6
			void IEnumerator.Reset()
			{
			}

			// Token: 0x170001E8 RID: 488
			// (get) Token: 0x06000F5C RID: 3932 RVA: 0x0000F4A8 File Offset: 0x0000D6A8
			object IEnumerator.Current
			{
				get
				{
					return null;
				}
			}

			// Token: 0x06000F5D RID: 3933 RVA: 0x0000F4AB File Offset: 0x0000D6AB
			IEnumerator<Type> IEnumerable<Type>.GetEnumerator()
			{
				return null;
			}

			// Token: 0x06000F5E RID: 3934 RVA: 0x0000F4AE File Offset: 0x0000D6AE
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			// Token: 0x04000690 RID: 1680
			private int <>1__state;

			// Token: 0x04000691 RID: 1681
			private Type <>2__current;

			// Token: 0x04000692 RID: 1682
			private int <>l__initialThreadId;

			// Token: 0x04000693 RID: 1683
			private Type t;

			// Token: 0x04000694 RID: 1684
			public Type <>3__t;

			// Token: 0x04000695 RID: 1685
			private Type <ot>5__2;

			// Token: 0x04000696 RID: 1686
			private Type[] <>7__wrap2;

			// Token: 0x04000697 RID: 1687
			private int <>7__wrap3;
		}
	}
}
