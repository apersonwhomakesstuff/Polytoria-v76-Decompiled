using System;
using System.Collections.Generic;
using MoonSharp.Interpreter.DataStructs;

namespace MoonSharp.Interpreter
{
	// Token: 0x02000036 RID: 54
	public class Table : RefIdObject, IScriptPrivateResource
	{
		// Token: 0x060004A0 RID: 1184 RVA: 0x0000CB5A File Offset: 0x0000AD5A
		public Table(Script owner)
		{
		}

		// Token: 0x060004A1 RID: 1185 RVA: 0x0000CB62 File Offset: 0x0000AD62
		public Table(Script owner, DynValue[] arrayValues)
		{
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x060004A2 RID: 1186 RVA: 0x0000CB6A File Offset: 0x0000AD6A
		public Script OwnerScript
		{
			get
			{
				return null;
			}
		}

		// Token: 0x060004A3 RID: 1187 RVA: 0x0000CB6D File Offset: 0x0000AD6D
		public void Clear()
		{
		}

		// Token: 0x060004A4 RID: 1188 RVA: 0x0000CB6F File Offset: 0x0000AD6F
		private int GetIntegralKey(double d)
		{
			return 0;
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x060004A5 RID: 1189 RVA: 0x0000CB72 File Offset: 0x0000AD72
		// (set) Token: 0x060004A6 RID: 1190 RVA: 0x0000CB75 File Offset: 0x0000AD75
		public object Item
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x060004A7 RID: 1191 RVA: 0x0000CB77 File Offset: 0x0000AD77
		// (set) Token: 0x060004A8 RID: 1192 RVA: 0x0000CB7A File Offset: 0x0000AD7A
		public object Item
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x060004A9 RID: 1193 RVA: 0x0000CB7C File Offset: 0x0000AD7C
		private Table ResolveMultipleKeys(object[] keys, out object key)
		{
			key = null;
			return null;
		}

		// Token: 0x060004AA RID: 1194 RVA: 0x0000CB82 File Offset: 0x0000AD82
		public void Append(DynValue value)
		{
		}

		// Token: 0x060004AB RID: 1195 RVA: 0x0000CB84 File Offset: 0x0000AD84
		private void PerformTableSet<T>(LinkedListIndex<T, TablePair> listIndex, T key, DynValue keyDynValue, DynValue value, bool isNumber, int appendKey)
		{
		}

		// Token: 0x060004AC RID: 1196 RVA: 0x0000CB86 File Offset: 0x0000AD86
		public void Set(string key, DynValue value)
		{
		}

		// Token: 0x060004AD RID: 1197 RVA: 0x0000CB88 File Offset: 0x0000AD88
		public void Set(int key, DynValue value)
		{
		}

		// Token: 0x060004AE RID: 1198 RVA: 0x0000CB8A File Offset: 0x0000AD8A
		public void Set(DynValue key, DynValue value)
		{
		}

		// Token: 0x060004AF RID: 1199 RVA: 0x0000CB8C File Offset: 0x0000AD8C
		public void Set(object key, DynValue value)
		{
		}

		// Token: 0x060004B0 RID: 1200 RVA: 0x0000CB8E File Offset: 0x0000AD8E
		public void Set(object[] keys, DynValue value)
		{
		}

		// Token: 0x060004B1 RID: 1201 RVA: 0x0000CB90 File Offset: 0x0000AD90
		public DynValue Get(string key)
		{
			return null;
		}

		// Token: 0x060004B2 RID: 1202 RVA: 0x0000CB93 File Offset: 0x0000AD93
		public DynValue Get(int key)
		{
			return null;
		}

		// Token: 0x060004B3 RID: 1203 RVA: 0x0000CB96 File Offset: 0x0000AD96
		public DynValue Get(DynValue key)
		{
			return null;
		}

		// Token: 0x060004B4 RID: 1204 RVA: 0x0000CB99 File Offset: 0x0000AD99
		public DynValue Get(object key)
		{
			return null;
		}

		// Token: 0x060004B5 RID: 1205 RVA: 0x0000CB9C File Offset: 0x0000AD9C
		public DynValue Get(object[] keys)
		{
			return null;
		}

		// Token: 0x060004B6 RID: 1206 RVA: 0x0000CB9F File Offset: 0x0000AD9F
		private static DynValue RawGetValue(LinkedListNode<TablePair> linkedListNode)
		{
			return null;
		}

		// Token: 0x060004B7 RID: 1207 RVA: 0x0000CBA2 File Offset: 0x0000ADA2
		public DynValue RawGet(string key)
		{
			return null;
		}

		// Token: 0x060004B8 RID: 1208 RVA: 0x0000CBA5 File Offset: 0x0000ADA5
		public DynValue RawGet(int key)
		{
			return null;
		}

		// Token: 0x060004B9 RID: 1209 RVA: 0x0000CBA8 File Offset: 0x0000ADA8
		public DynValue RawGet(DynValue key)
		{
			return null;
		}

		// Token: 0x060004BA RID: 1210 RVA: 0x0000CBAB File Offset: 0x0000ADAB
		public DynValue RawGet(object key)
		{
			return null;
		}

		// Token: 0x060004BB RID: 1211 RVA: 0x0000CBAE File Offset: 0x0000ADAE
		public DynValue RawGet(object[] keys)
		{
			return null;
		}

		// Token: 0x060004BC RID: 1212 RVA: 0x0000CBB1 File Offset: 0x0000ADB1
		private bool PerformTableRemove<T>(LinkedListIndex<T, TablePair> listIndex, T key, bool isNumber)
		{
			return false;
		}

		// Token: 0x060004BD RID: 1213 RVA: 0x0000CBB4 File Offset: 0x0000ADB4
		public bool Remove(string key)
		{
			return false;
		}

		// Token: 0x060004BE RID: 1214 RVA: 0x0000CBB7 File Offset: 0x0000ADB7
		public bool Remove(int key)
		{
			return false;
		}

		// Token: 0x060004BF RID: 1215 RVA: 0x0000CBBA File Offset: 0x0000ADBA
		public bool Remove(DynValue key)
		{
			return false;
		}

		// Token: 0x060004C0 RID: 1216 RVA: 0x0000CBBD File Offset: 0x0000ADBD
		public bool Remove(object key)
		{
			return false;
		}

		// Token: 0x060004C1 RID: 1217 RVA: 0x0000CBC0 File Offset: 0x0000ADC0
		public bool Remove(object[] keys)
		{
			return false;
		}

		// Token: 0x060004C2 RID: 1218 RVA: 0x0000CBC3 File Offset: 0x0000ADC3
		public void CollectDeadKeys()
		{
		}

		// Token: 0x060004C3 RID: 1219 RVA: 0x00010268 File Offset: 0x0000E468
		public TablePair? NextKey(DynValue v)
		{
			return null;
		}

		// Token: 0x060004C4 RID: 1220 RVA: 0x00010280 File Offset: 0x0000E480
		private TablePair? GetNextOf(LinkedListNode<TablePair> linkedListNode)
		{
			return null;
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x060004C5 RID: 1221 RVA: 0x0000CBC5 File Offset: 0x0000ADC5
		public int Length
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x060004C6 RID: 1222 RVA: 0x0000CBC8 File Offset: 0x0000ADC8
		internal void InitNextArrayKeys(DynValue val, bool lastpos)
		{
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x060004C7 RID: 1223 RVA: 0x0000CBCA File Offset: 0x0000ADCA
		// (set) Token: 0x060004C8 RID: 1224 RVA: 0x0000CBCD File Offset: 0x0000ADCD
		public Table MetaTable
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x060004C9 RID: 1225 RVA: 0x0000CBCF File Offset: 0x0000ADCF
		public IEnumerable<TablePair> Pairs
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x060004CA RID: 1226 RVA: 0x0000CBD2 File Offset: 0x0000ADD2
		public IEnumerable<DynValue> Keys
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x060004CB RID: 1227 RVA: 0x0000CBD5 File Offset: 0x0000ADD5
		public IEnumerable<DynValue> Values
		{
			get
			{
				return null;
			}
		}

		// Token: 0x0400018D RID: 397
		private readonly LinkedList<TablePair> m_Values;

		// Token: 0x0400018E RID: 398
		private readonly LinkedListIndex<DynValue, TablePair> m_ValueMap;

		// Token: 0x0400018F RID: 399
		private readonly LinkedListIndex<string, TablePair> m_StringMap;

		// Token: 0x04000190 RID: 400
		private readonly LinkedListIndex<int, TablePair> m_ArrayMap;

		// Token: 0x04000191 RID: 401
		private readonly Script m_Owner;

		// Token: 0x04000192 RID: 402
		private int m_InitArray;

		// Token: 0x04000193 RID: 403
		private int m_CachedLength;

		// Token: 0x04000194 RID: 404
		private bool m_ContainsNilEntries;

		// Token: 0x04000195 RID: 405
		private Table m_MetaTable;

		// Token: 0x02000182 RID: 386
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06000F19 RID: 3865 RVA: 0x00010B98 File Offset: 0x0000ED98
			internal TablePair <get_Pairs>b__56_0(TablePair n)
			{
				return default(TablePair);
			}

			// Token: 0x06000F1A RID: 3866 RVA: 0x0000F388 File Offset: 0x0000D588
			internal DynValue <get_Keys>b__58_0(TablePair n)
			{
				return null;
			}

			// Token: 0x06000F1B RID: 3867 RVA: 0x0000F38B File Offset: 0x0000D58B
			internal DynValue <get_Values>b__60_0(TablePair n)
			{
				return null;
			}

			// Token: 0x0400064E RID: 1614
			public static readonly Table.<>c <>9;

			// Token: 0x0400064F RID: 1615
			public static Func<TablePair, TablePair> <>9__56_0;

			// Token: 0x04000650 RID: 1616
			public static Func<TablePair, DynValue> <>9__58_0;

			// Token: 0x04000651 RID: 1617
			public static Func<TablePair, DynValue> <>9__60_0;
		}
	}
}
