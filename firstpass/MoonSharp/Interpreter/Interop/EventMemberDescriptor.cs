using System;
using System.Collections.Generic;
using System.Reflection;
using MoonSharp.Interpreter.DataStructs;
using MoonSharp.Interpreter.Interop.BasicDescriptors;

namespace MoonSharp.Interpreter.Interop
{
	// Token: 0x020000B2 RID: 178
	public class EventMemberDescriptor : IMemberDescriptor
	{
		// Token: 0x0600083A RID: 2106 RVA: 0x0000DB45 File Offset: 0x0000BD45
		public static EventMemberDescriptor TryCreateIfVisible(EventInfo ei, InteropAccessMode accessMode)
		{
			return null;
		}

		// Token: 0x0600083B RID: 2107 RVA: 0x0000DB48 File Offset: 0x0000BD48
		public static bool CheckEventIsCompatible(EventInfo ei, bool throwException)
		{
			return false;
		}

		// Token: 0x0600083C RID: 2108 RVA: 0x0000DB4B File Offset: 0x0000BD4B
		public EventMemberDescriptor(EventInfo ei, InteropAccessMode accessMode = InteropAccessMode.Default)
		{
		}

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x0600083D RID: 2109 RVA: 0x0000DB53 File Offset: 0x0000BD53
		// (set) Token: 0x0600083E RID: 2110 RVA: 0x0000DB5B File Offset: 0x0000BD5B
		public EventInfo EventInfo
		{
			get
			{
				return this.<EventInfo>k__BackingField;
			}
			private set
			{
				this.<EventInfo>k__BackingField = value;
			}
		}

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x0600083F RID: 2111 RVA: 0x0000DB64 File Offset: 0x0000BD64
		// (set) Token: 0x06000840 RID: 2112 RVA: 0x0000DB6C File Offset: 0x0000BD6C
		public bool IsStatic
		{
			get
			{
				return this.<IsStatic>k__BackingField;
			}
			private set
			{
				this.<IsStatic>k__BackingField = value;
			}
		}

		// Token: 0x06000841 RID: 2113 RVA: 0x0000DB75 File Offset: 0x0000BD75
		public DynValue GetValue(Script script, object obj)
		{
			return null;
		}

		// Token: 0x06000842 RID: 2114 RVA: 0x0000DB78 File Offset: 0x0000BD78
		internal DynValue AddCallback(object o, ScriptExecutionContext context, CallbackArguments args)
		{
			return null;
		}

		// Token: 0x06000843 RID: 2115 RVA: 0x0000DB7B File Offset: 0x0000BD7B
		internal DynValue RemoveCallback(object o, ScriptExecutionContext context, CallbackArguments args)
		{
			return null;
		}

		// Token: 0x06000844 RID: 2116 RVA: 0x0000DB7E File Offset: 0x0000BD7E
		private void RegisterCallback(object o)
		{
		}

		// Token: 0x06000845 RID: 2117 RVA: 0x0000DB80 File Offset: 0x0000BD80
		private void UnregisterCallback(object o)
		{
		}

		// Token: 0x06000846 RID: 2118 RVA: 0x0000DB82 File Offset: 0x0000BD82
		private Delegate CreateDelegate(object sender)
		{
			return null;
		}

		// Token: 0x06000847 RID: 2119 RVA: 0x0000DB85 File Offset: 0x0000BD85
		private void DispatchEvent(object sender, object o01 = null, object o02 = null, object o03 = null, object o04 = null, object o05 = null, object o06 = null, object o07 = null, object o08 = null, object o09 = null, object o10 = null, object o11 = null, object o12 = null, object o13 = null, object o14 = null, object o15 = null, object o16 = null)
		{
		}

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x06000848 RID: 2120 RVA: 0x0000DB87 File Offset: 0x0000BD87
		public string Name
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x06000849 RID: 2121 RVA: 0x00010400 File Offset: 0x0000E600
		public MemberDescriptorAccess MemberAccess
		{
			get
			{
				return (MemberDescriptorAccess)0;
			}
		}

		// Token: 0x0600084A RID: 2122 RVA: 0x0000DB8A File Offset: 0x0000BD8A
		public void SetValue(Script script, object obj, DynValue v)
		{
		}

		// Token: 0x04000326 RID: 806
		public const int MAX_ARGS_IN_DELEGATE = 16;

		// Token: 0x04000327 RID: 807
		private object m_Lock;

		// Token: 0x04000328 RID: 808
		private MultiDictionary<object, Closure> m_Callbacks;

		// Token: 0x04000329 RID: 809
		private Dictionary<object, Delegate> m_Delegates;

		// Token: 0x0400032A RID: 810
		private EventInfo <EventInfo>k__BackingField;

		// Token: 0x0400032B RID: 811
		private bool <IsStatic>k__BackingField;

		// Token: 0x0400032C RID: 812
		private MethodInfo m_Add;

		// Token: 0x0400032D RID: 813
		private MethodInfo m_Remove;

		// Token: 0x0200019D RID: 413
		// (Invoke) Token: 0x06000F68 RID: 3944
		private delegate void EventWrapper00();

		// Token: 0x0200019E RID: 414
		// (Invoke) Token: 0x06000F6C RID: 3948
		private delegate void EventWrapper01(object o1);

		// Token: 0x0200019F RID: 415
		// (Invoke) Token: 0x06000F70 RID: 3952
		private delegate void EventWrapper02(object o1, object o2);

		// Token: 0x020001A0 RID: 416
		// (Invoke) Token: 0x06000F74 RID: 3956
		private delegate void EventWrapper03(object o1, object o2, object o3);

		// Token: 0x020001A1 RID: 417
		// (Invoke) Token: 0x06000F78 RID: 3960
		private delegate void EventWrapper04(object o1, object o2, object o3, object o4);

		// Token: 0x020001A2 RID: 418
		// (Invoke) Token: 0x06000F7C RID: 3964
		private delegate void EventWrapper05(object o1, object o2, object o3, object o4, object o5);

		// Token: 0x020001A3 RID: 419
		// (Invoke) Token: 0x06000F80 RID: 3968
		private delegate void EventWrapper06(object o1, object o2, object o3, object o4, object o5, object o6);

		// Token: 0x020001A4 RID: 420
		// (Invoke) Token: 0x06000F84 RID: 3972
		private delegate void EventWrapper07(object o1, object o2, object o3, object o4, object o5, object o6, object o7);

		// Token: 0x020001A5 RID: 421
		// (Invoke) Token: 0x06000F88 RID: 3976
		private delegate void EventWrapper08(object o1, object o2, object o3, object o4, object o5, object o6, object o7, object o8);

		// Token: 0x020001A6 RID: 422
		// (Invoke) Token: 0x06000F8C RID: 3980
		private delegate void EventWrapper09(object o1, object o2, object o3, object o4, object o5, object o6, object o7, object o8, object o9);

		// Token: 0x020001A7 RID: 423
		// (Invoke) Token: 0x06000F90 RID: 3984
		private delegate void EventWrapper10(object o1, object o2, object o3, object o4, object o5, object o6, object o7, object o8, object o9, object o10);

		// Token: 0x020001A8 RID: 424
		// (Invoke) Token: 0x06000F94 RID: 3988
		private delegate void EventWrapper11(object o1, object o2, object o3, object o4, object o5, object o6, object o7, object o8, object o9, object o10, object o11);

		// Token: 0x020001A9 RID: 425
		// (Invoke) Token: 0x06000F98 RID: 3992
		private delegate void EventWrapper12(object o1, object o2, object o3, object o4, object o5, object o6, object o7, object o8, object o9, object o10, object o11, object o12);

		// Token: 0x020001AA RID: 426
		// (Invoke) Token: 0x06000F9C RID: 3996
		private delegate void EventWrapper13(object o1, object o2, object o3, object o4, object o5, object o6, object o7, object o8, object o9, object o10, object o11, object o12, object o13);

		// Token: 0x020001AB RID: 427
		// (Invoke) Token: 0x06000FA0 RID: 4000
		private delegate void EventWrapper14(object o1, object o2, object o3, object o4, object o5, object o6, object o7, object o8, object o9, object o10, object o11, object o12, object o13, object o14);

		// Token: 0x020001AC RID: 428
		// (Invoke) Token: 0x06000FA4 RID: 4004
		private delegate void EventWrapper15(object o1, object o2, object o3, object o4, object o5, object o6, object o7, object o8, object o9, object o10, object o11, object o12, object o13, object o14, object o15);

		// Token: 0x020001AD RID: 429
		// (Invoke) Token: 0x06000FA8 RID: 4008
		private delegate void EventWrapper16(object o1, object o2, object o3, object o4, object o5, object o6, object o7, object o8, object o9, object o10, object o11, object o12, object o13, object o14, object o15, object o16);

		// Token: 0x020001AE RID: 430
		private sealed class <>c__DisplayClass20_0
		{
			// Token: 0x06000FAC RID: 4012 RVA: 0x0000F4DE File Offset: 0x0000D6DE
			internal Delegate <RegisterCallback>b__0()
			{
				return null;
			}

			// Token: 0x0400069F RID: 1695
			public EventMemberDescriptor <>4__this;

			// Token: 0x040006A0 RID: 1696
			public object o;
		}

		// Token: 0x020001AF RID: 431
		private sealed class <>c__DisplayClass22_0
		{
			// Token: 0x06000FAE RID: 4014 RVA: 0x0000F4E9 File Offset: 0x0000D6E9
			internal void <CreateDelegate>b__0()
			{
			}

			// Token: 0x06000FAF RID: 4015 RVA: 0x0000F4EB File Offset: 0x0000D6EB
			internal void <CreateDelegate>b__1(object o1)
			{
			}

			// Token: 0x06000FB0 RID: 4016 RVA: 0x0000F4ED File Offset: 0x0000D6ED
			internal void <CreateDelegate>b__2(object o1, object o2)
			{
			}

			// Token: 0x06000FB1 RID: 4017 RVA: 0x0000F4EF File Offset: 0x0000D6EF
			internal void <CreateDelegate>b__3(object o1, object o2, object o3)
			{
			}

			// Token: 0x06000FB2 RID: 4018 RVA: 0x0000F4F1 File Offset: 0x0000D6F1
			internal void <CreateDelegate>b__4(object o1, object o2, object o3, object o4)
			{
			}

			// Token: 0x06000FB3 RID: 4019 RVA: 0x0000F4F3 File Offset: 0x0000D6F3
			internal void <CreateDelegate>b__5(object o1, object o2, object o3, object o4, object o5)
			{
			}

			// Token: 0x06000FB4 RID: 4020 RVA: 0x0000F4F5 File Offset: 0x0000D6F5
			internal void <CreateDelegate>b__6(object o1, object o2, object o3, object o4, object o5, object o6)
			{
			}

			// Token: 0x06000FB5 RID: 4021 RVA: 0x0000F4F7 File Offset: 0x0000D6F7
			internal void <CreateDelegate>b__7(object o1, object o2, object o3, object o4, object o5, object o6, object o7)
			{
			}

			// Token: 0x06000FB6 RID: 4022 RVA: 0x0000F4F9 File Offset: 0x0000D6F9
			internal void <CreateDelegate>b__8(object o1, object o2, object o3, object o4, object o5, object o6, object o7, object o8)
			{
			}

			// Token: 0x06000FB7 RID: 4023 RVA: 0x0000F4FB File Offset: 0x0000D6FB
			internal void <CreateDelegate>b__9(object o1, object o2, object o3, object o4, object o5, object o6, object o7, object o8, object o9)
			{
			}

			// Token: 0x06000FB8 RID: 4024 RVA: 0x0000F4FD File Offset: 0x0000D6FD
			internal void <CreateDelegate>b__10(object o1, object o2, object o3, object o4, object o5, object o6, object o7, object o8, object o9, object o10)
			{
			}

			// Token: 0x06000FB9 RID: 4025 RVA: 0x0000F4FF File Offset: 0x0000D6FF
			internal void <CreateDelegate>b__11(object o1, object o2, object o3, object o4, object o5, object o6, object o7, object o8, object o9, object o10, object o11)
			{
			}

			// Token: 0x06000FBA RID: 4026 RVA: 0x0000F501 File Offset: 0x0000D701
			internal void <CreateDelegate>b__12(object o1, object o2, object o3, object o4, object o5, object o6, object o7, object o8, object o9, object o10, object o11, object o12)
			{
			}

			// Token: 0x06000FBB RID: 4027 RVA: 0x0000F503 File Offset: 0x0000D703
			internal void <CreateDelegate>b__13(object o1, object o2, object o3, object o4, object o5, object o6, object o7, object o8, object o9, object o10, object o11, object o12, object o13)
			{
			}

			// Token: 0x06000FBC RID: 4028 RVA: 0x0000F505 File Offset: 0x0000D705
			internal void <CreateDelegate>b__14(object o1, object o2, object o3, object o4, object o5, object o6, object o7, object o8, object o9, object o10, object o11, object o12, object o13, object o14)
			{
			}

			// Token: 0x06000FBD RID: 4029 RVA: 0x0000F507 File Offset: 0x0000D707
			internal void <CreateDelegate>b__15(object o1, object o2, object o3, object o4, object o5, object o6, object o7, object o8, object o9, object o10, object o11, object o12, object o13, object o14, object o15)
			{
			}

			// Token: 0x06000FBE RID: 4030 RVA: 0x0000F509 File Offset: 0x0000D709
			internal void <CreateDelegate>b__16(object o1, object o2, object o3, object o4, object o5, object o6, object o7, object o8, object o9, object o10, object o11, object o12, object o13, object o14, object o15, object o16)
			{
			}

			// Token: 0x040006A1 RID: 1697
			public EventMemberDescriptor <>4__this;

			// Token: 0x040006A2 RID: 1698
			public object sender;
		}
	}
}
