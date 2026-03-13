using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace SimpleJSON
{
	// Token: 0x0200001C RID: 28
	public abstract class JSONNode
	{
		// Token: 0x1700002F RID: 47
		// (get) Token: 0x06000324 RID: 804
		public abstract JSONNodeType Tag { get; }

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x06000325 RID: 805 RVA: 0x0000C6B3 File Offset: 0x0000A8B3
		// (set) Token: 0x06000326 RID: 806 RVA: 0x0000C6B6 File Offset: 0x0000A8B6
		public virtual JSONNode Item
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x06000327 RID: 807 RVA: 0x0000C6B8 File Offset: 0x0000A8B8
		// (set) Token: 0x06000328 RID: 808 RVA: 0x0000C6BB File Offset: 0x0000A8BB
		public virtual JSONNode Item
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x06000329 RID: 809 RVA: 0x0000C6BD File Offset: 0x0000A8BD
		// (set) Token: 0x0600032A RID: 810 RVA: 0x0000C6C0 File Offset: 0x0000A8C0
		public virtual string Value
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x0600032B RID: 811 RVA: 0x0000C6C2 File Offset: 0x0000A8C2
		public virtual int Count
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x0600032C RID: 812 RVA: 0x0000C6C5 File Offset: 0x0000A8C5
		public virtual bool IsNumber
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x0600032D RID: 813 RVA: 0x0000C6C8 File Offset: 0x0000A8C8
		public virtual bool IsString
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x0600032E RID: 814 RVA: 0x0000C6CB File Offset: 0x0000A8CB
		public virtual bool IsBoolean
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x0600032F RID: 815 RVA: 0x0000C6CE File Offset: 0x0000A8CE
		public virtual bool IsNull
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x06000330 RID: 816 RVA: 0x0000C6D1 File Offset: 0x0000A8D1
		public virtual bool IsArray
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x06000331 RID: 817 RVA: 0x0000C6D4 File Offset: 0x0000A8D4
		public virtual bool IsObject
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x06000332 RID: 818 RVA: 0x0000C6D7 File Offset: 0x0000A8D7
		// (set) Token: 0x06000333 RID: 819 RVA: 0x0000C6DA File Offset: 0x0000A8DA
		public virtual bool Inline
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x06000334 RID: 820 RVA: 0x0000C6DC File Offset: 0x0000A8DC
		public virtual void Add(string aKey, JSONNode aItem)
		{
		}

		// Token: 0x06000335 RID: 821 RVA: 0x0000C6DE File Offset: 0x0000A8DE
		public virtual void Add(JSONNode aItem)
		{
		}

		// Token: 0x06000336 RID: 822 RVA: 0x0000C6E0 File Offset: 0x0000A8E0
		public virtual JSONNode Remove(string aKey)
		{
			return null;
		}

		// Token: 0x06000337 RID: 823 RVA: 0x0000C6E3 File Offset: 0x0000A8E3
		public virtual JSONNode Remove(int aIndex)
		{
			return null;
		}

		// Token: 0x06000338 RID: 824 RVA: 0x0000C6E6 File Offset: 0x0000A8E6
		public virtual JSONNode Remove(JSONNode aNode)
		{
			return null;
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x06000339 RID: 825 RVA: 0x0000C6E9 File Offset: 0x0000A8E9
		public virtual IEnumerable<JSONNode> Children
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x0600033A RID: 826 RVA: 0x0000C6EC File Offset: 0x0000A8EC
		public IEnumerable<JSONNode> DeepChildren
		{
			get
			{
				return null;
			}
		}

		// Token: 0x0600033B RID: 827 RVA: 0x0000C6EF File Offset: 0x0000A8EF
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600033C RID: 828 RVA: 0x0000C6F2 File Offset: 0x0000A8F2
		public virtual string ToString(int aIndent)
		{
			return null;
		}

		// Token: 0x0600033D RID: 829
		internal abstract void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode);

		// Token: 0x0600033E RID: 830
		public abstract JSONNode.Enumerator GetEnumerator();

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x0600033F RID: 831 RVA: 0x0000C6F5 File Offset: 0x0000A8F5
		public IEnumerable<KeyValuePair<string, JSONNode>> Linq
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x06000340 RID: 832 RVA: 0x0000FE18 File Offset: 0x0000E018
		public JSONNode.KeyEnumerator Keys
		{
			get
			{
				return default(JSONNode.KeyEnumerator);
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x06000341 RID: 833 RVA: 0x0000FE30 File Offset: 0x0000E030
		public JSONNode.ValueEnumerator Values
		{
			get
			{
				return default(JSONNode.ValueEnumerator);
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x06000342 RID: 834 RVA: 0x0000C6F8 File Offset: 0x0000A8F8
		// (set) Token: 0x06000343 RID: 835 RVA: 0x0000C703 File Offset: 0x0000A903
		public virtual double AsDouble
		{
			get
			{
				return 0.0;
			}
			set
			{
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x06000344 RID: 836 RVA: 0x0000C705 File Offset: 0x0000A905
		// (set) Token: 0x06000345 RID: 837 RVA: 0x0000C708 File Offset: 0x0000A908
		public virtual int AsInt
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x06000346 RID: 838 RVA: 0x0000C70A File Offset: 0x0000A90A
		// (set) Token: 0x06000347 RID: 839 RVA: 0x0000C711 File Offset: 0x0000A911
		public virtual float AsFloat
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x06000348 RID: 840 RVA: 0x0000C713 File Offset: 0x0000A913
		// (set) Token: 0x06000349 RID: 841 RVA: 0x0000C716 File Offset: 0x0000A916
		public virtual bool AsBool
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x0600034A RID: 842 RVA: 0x0000C718 File Offset: 0x0000A918
		public virtual JSONArray AsArray
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x0600034B RID: 843 RVA: 0x0000C71B File Offset: 0x0000A91B
		public virtual JSONObject AsObject
		{
			get
			{
				return null;
			}
		}

		// Token: 0x0600034C RID: 844 RVA: 0x0000C71E File Offset: 0x0000A91E
		public static implicit operator JSONNode(string s)
		{
			return null;
		}

		// Token: 0x0600034D RID: 845 RVA: 0x0000C721 File Offset: 0x0000A921
		public static implicit operator string(JSONNode d)
		{
			return null;
		}

		// Token: 0x0600034E RID: 846 RVA: 0x0000C724 File Offset: 0x0000A924
		public static implicit operator JSONNode(double n)
		{
			return null;
		}

		// Token: 0x0600034F RID: 847 RVA: 0x0000C727 File Offset: 0x0000A927
		public static implicit operator double(JSONNode d)
		{
			return 0.0;
		}

		// Token: 0x06000350 RID: 848 RVA: 0x0000C732 File Offset: 0x0000A932
		public static implicit operator JSONNode(float n)
		{
			return null;
		}

		// Token: 0x06000351 RID: 849 RVA: 0x0000C735 File Offset: 0x0000A935
		public static implicit operator float(JSONNode d)
		{
			return 0f;
		}

		// Token: 0x06000352 RID: 850 RVA: 0x0000C73C File Offset: 0x0000A93C
		public static implicit operator JSONNode(int n)
		{
			return null;
		}

		// Token: 0x06000353 RID: 851 RVA: 0x0000C73F File Offset: 0x0000A93F
		public static implicit operator int(JSONNode d)
		{
			return 0;
		}

		// Token: 0x06000354 RID: 852 RVA: 0x0000C742 File Offset: 0x0000A942
		public static implicit operator JSONNode(bool b)
		{
			return null;
		}

		// Token: 0x06000355 RID: 853 RVA: 0x0000C745 File Offset: 0x0000A945
		public static implicit operator bool(JSONNode d)
		{
			return false;
		}

		// Token: 0x06000356 RID: 854 RVA: 0x0000C748 File Offset: 0x0000A948
		public static implicit operator JSONNode(KeyValuePair<string, JSONNode> aKeyValue)
		{
			return null;
		}

		// Token: 0x06000357 RID: 855 RVA: 0x0000C74B File Offset: 0x0000A94B
		public static bool operator ==(JSONNode a, object b)
		{
			return false;
		}

		// Token: 0x06000358 RID: 856 RVA: 0x0000C74E File Offset: 0x0000A94E
		public static bool operator !=(JSONNode a, object b)
		{
			return false;
		}

		// Token: 0x06000359 RID: 857 RVA: 0x0000C751 File Offset: 0x0000A951
		public override bool Equals(object obj)
		{
			return false;
		}

		// Token: 0x0600035A RID: 858 RVA: 0x0000C754 File Offset: 0x0000A954
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x0600035B RID: 859 RVA: 0x0000C757 File Offset: 0x0000A957
		internal static StringBuilder EscapeBuilder
		{
			get
			{
				return null;
			}
		}

		// Token: 0x0600035C RID: 860 RVA: 0x0000C75A File Offset: 0x0000A95A
		internal static string Escape(string aText)
		{
			return null;
		}

		// Token: 0x0600035D RID: 861 RVA: 0x0000C75D File Offset: 0x0000A95D
		private static void ParseElement(JSONNode ctx, string token, string tokenName, bool quoted)
		{
		}

		// Token: 0x0600035E RID: 862 RVA: 0x0000C75F File Offset: 0x0000A95F
		public static JSONNode Parse(string aJSON)
		{
			return null;
		}

		// Token: 0x0600035F RID: 863 RVA: 0x0000C762 File Offset: 0x0000A962
		private static JSONNode GetContainer(JSONContainerType aType)
		{
			return null;
		}

		// Token: 0x06000360 RID: 864 RVA: 0x0000C765 File Offset: 0x0000A965
		public static implicit operator JSONNode(Vector2 aVec)
		{
			return null;
		}

		// Token: 0x06000361 RID: 865 RVA: 0x0000C768 File Offset: 0x0000A968
		public static implicit operator JSONNode(Vector3 aVec)
		{
			return null;
		}

		// Token: 0x06000362 RID: 866 RVA: 0x0000C76B File Offset: 0x0000A96B
		public static implicit operator JSONNode(Vector4 aVec)
		{
			return null;
		}

		// Token: 0x06000363 RID: 867 RVA: 0x0000C76E File Offset: 0x0000A96E
		public static implicit operator JSONNode(Quaternion aRot)
		{
			return null;
		}

		// Token: 0x06000364 RID: 868 RVA: 0x0000C771 File Offset: 0x0000A971
		public static implicit operator JSONNode(Rect aRect)
		{
			return null;
		}

		// Token: 0x06000365 RID: 869 RVA: 0x0000C774 File Offset: 0x0000A974
		public static implicit operator JSONNode(RectOffset aRect)
		{
			return null;
		}

		// Token: 0x06000366 RID: 870 RVA: 0x0000FE48 File Offset: 0x0000E048
		public static implicit operator Vector2(JSONNode aNode)
		{
			return default(Vector2);
		}

		// Token: 0x06000367 RID: 871 RVA: 0x0000FE60 File Offset: 0x0000E060
		public static implicit operator Vector3(JSONNode aNode)
		{
			return default(Vector3);
		}

		// Token: 0x06000368 RID: 872 RVA: 0x0000FE78 File Offset: 0x0000E078
		public static implicit operator Vector4(JSONNode aNode)
		{
			return default(Vector4);
		}

		// Token: 0x06000369 RID: 873 RVA: 0x0000FE90 File Offset: 0x0000E090
		public static implicit operator Quaternion(JSONNode aNode)
		{
			return default(Quaternion);
		}

		// Token: 0x0600036A RID: 874 RVA: 0x0000FEA8 File Offset: 0x0000E0A8
		public static implicit operator Rect(JSONNode aNode)
		{
			return default(Rect);
		}

		// Token: 0x0600036B RID: 875 RVA: 0x0000C777 File Offset: 0x0000A977
		public static implicit operator RectOffset(JSONNode aNode)
		{
			return null;
		}

		// Token: 0x0600036C RID: 876 RVA: 0x0000FEC0 File Offset: 0x0000E0C0
		public Vector2 ReadVector2(Vector2 aDefault)
		{
			return default(Vector2);
		}

		// Token: 0x0600036D RID: 877 RVA: 0x0000FED8 File Offset: 0x0000E0D8
		public Vector2 ReadVector2(string aXName, string aYName)
		{
			return default(Vector2);
		}

		// Token: 0x0600036E RID: 878 RVA: 0x0000FEF0 File Offset: 0x0000E0F0
		public Vector2 ReadVector2()
		{
			return default(Vector2);
		}

		// Token: 0x0600036F RID: 879 RVA: 0x0000C77A File Offset: 0x0000A97A
		public JSONNode WriteVector2(Vector2 aVec, string aXName = "x", string aYName = "y")
		{
			return null;
		}

		// Token: 0x06000370 RID: 880 RVA: 0x0000FF08 File Offset: 0x0000E108
		public Vector3 ReadVector3(Vector3 aDefault)
		{
			return default(Vector3);
		}

		// Token: 0x06000371 RID: 881 RVA: 0x0000FF20 File Offset: 0x0000E120
		public Vector3 ReadVector3(string aXName, string aYName, string aZName)
		{
			return default(Vector3);
		}

		// Token: 0x06000372 RID: 882 RVA: 0x0000FF38 File Offset: 0x0000E138
		public Vector3 ReadVector3()
		{
			return default(Vector3);
		}

		// Token: 0x06000373 RID: 883 RVA: 0x0000C77D File Offset: 0x0000A97D
		public JSONNode WriteVector3(Vector3 aVec, string aXName = "x", string aYName = "y", string aZName = "z")
		{
			return null;
		}

		// Token: 0x06000374 RID: 884 RVA: 0x0000FF50 File Offset: 0x0000E150
		public Vector4 ReadVector4(Vector4 aDefault)
		{
			return default(Vector4);
		}

		// Token: 0x06000375 RID: 885 RVA: 0x0000FF68 File Offset: 0x0000E168
		public Vector4 ReadVector4()
		{
			return default(Vector4);
		}

		// Token: 0x06000376 RID: 886 RVA: 0x0000C780 File Offset: 0x0000A980
		public JSONNode WriteVector4(Vector4 aVec)
		{
			return null;
		}

		// Token: 0x06000377 RID: 887 RVA: 0x0000FF80 File Offset: 0x0000E180
		public Quaternion ReadQuaternion(Quaternion aDefault)
		{
			return default(Quaternion);
		}

		// Token: 0x06000378 RID: 888 RVA: 0x0000FF98 File Offset: 0x0000E198
		public Quaternion ReadQuaternion()
		{
			return default(Quaternion);
		}

		// Token: 0x06000379 RID: 889 RVA: 0x0000C783 File Offset: 0x0000A983
		public JSONNode WriteQuaternion(Quaternion aRot)
		{
			return null;
		}

		// Token: 0x0600037A RID: 890 RVA: 0x0000FFB0 File Offset: 0x0000E1B0
		public Rect ReadRect(Rect aDefault)
		{
			return default(Rect);
		}

		// Token: 0x0600037B RID: 891 RVA: 0x0000FFC8 File Offset: 0x0000E1C8
		public Rect ReadRect()
		{
			return default(Rect);
		}

		// Token: 0x0600037C RID: 892 RVA: 0x0000C786 File Offset: 0x0000A986
		public JSONNode WriteRect(Rect aRect)
		{
			return null;
		}

		// Token: 0x0600037D RID: 893 RVA: 0x0000C789 File Offset: 0x0000A989
		public RectOffset ReadRectOffset(RectOffset aDefault)
		{
			return null;
		}

		// Token: 0x0600037E RID: 894 RVA: 0x0000C78C File Offset: 0x0000A98C
		public RectOffset ReadRectOffset()
		{
			return null;
		}

		// Token: 0x0600037F RID: 895 RVA: 0x0000C78F File Offset: 0x0000A98F
		public JSONNode WriteRectOffset(RectOffset aRect)
		{
			return null;
		}

		// Token: 0x06000380 RID: 896 RVA: 0x0000FFE0 File Offset: 0x0000E1E0
		public Matrix4x4 ReadMatrix()
		{
			return default(Matrix4x4);
		}

		// Token: 0x06000381 RID: 897 RVA: 0x0000C792 File Offset: 0x0000A992
		public JSONNode WriteMatrix(Matrix4x4 aMatrix)
		{
			return null;
		}

		// Token: 0x0400013C RID: 316
		public static bool forceASCII;

		// Token: 0x0400013D RID: 317
		private static StringBuilder m_EscapeBuilder;

		// Token: 0x0400013E RID: 318
		public static JSONContainerType VectorContainerType;

		// Token: 0x0400013F RID: 319
		public static JSONContainerType QuaternionContainerType;

		// Token: 0x04000140 RID: 320
		public static JSONContainerType RectContainerType;

		// Token: 0x02000172 RID: 370
		public struct Enumerator
		{
			// Token: 0x170001D1 RID: 465
			// (get) Token: 0x06000EB0 RID: 3760 RVA: 0x0000F253 File Offset: 0x0000D453
			public bool IsValid
			{
				get
				{
					return false;
				}
			}

			// Token: 0x06000EB1 RID: 3761 RVA: 0x00010A00 File Offset: 0x0000EC00
			public Enumerator(List<JSONNode>.Enumerator aArrayEnum)
			{
				this.type = JSONNode.Enumerator.Type.None;
				this.m_Object = default(Dictionary<string, JSONNode>.Enumerator);
				this.m_Array = default(List<JSONNode>.Enumerator);
			}

			// Token: 0x06000EB2 RID: 3762 RVA: 0x00010A3C File Offset: 0x0000EC3C
			public Enumerator(Dictionary<string, JSONNode>.Enumerator aDictEnum)
			{
				this.type = JSONNode.Enumerator.Type.None;
				this.m_Object = default(Dictionary<string, JSONNode>.Enumerator);
				this.m_Array = default(List<JSONNode>.Enumerator);
			}

			// Token: 0x170001D2 RID: 466
			// (get) Token: 0x06000EB3 RID: 3763 RVA: 0x00010A78 File Offset: 0x0000EC78
			public KeyValuePair<string, JSONNode> Current
			{
				get
				{
					return default(KeyValuePair<string, JSONNode>);
				}
			}

			// Token: 0x06000EB4 RID: 3764 RVA: 0x0000F256 File Offset: 0x0000D456
			public bool MoveNext()
			{
				return false;
			}

			// Token: 0x04000612 RID: 1554
			private JSONNode.Enumerator.Type type;

			// Token: 0x04000613 RID: 1555
			private Dictionary<string, JSONNode>.Enumerator m_Object;

			// Token: 0x04000614 RID: 1556
			private List<JSONNode>.Enumerator m_Array;

			// Token: 0x02000236 RID: 566
			private enum Type
			{
				// Token: 0x0400081F RID: 2079
				None,
				// Token: 0x04000820 RID: 2080
				Array,
				// Token: 0x04000821 RID: 2081
				Object
			}
		}

		// Token: 0x02000173 RID: 371
		public struct ValueEnumerator
		{
			// Token: 0x06000EB5 RID: 3765 RVA: 0x00010A90 File Offset: 0x0000EC90
			public ValueEnumerator(List<JSONNode>.Enumerator aArrayEnum)
			{
				this.m_Enumerator = default(JSONNode.Enumerator);
			}

			// Token: 0x06000EB6 RID: 3766 RVA: 0x00010AAC File Offset: 0x0000ECAC
			public ValueEnumerator(Dictionary<string, JSONNode>.Enumerator aDictEnum)
			{
				this.m_Enumerator = default(JSONNode.Enumerator);
			}

			// Token: 0x06000EB7 RID: 3767 RVA: 0x00010AC8 File Offset: 0x0000ECC8
			public ValueEnumerator(JSONNode.Enumerator aEnumerator)
			{
				this.m_Enumerator = default(JSONNode.Enumerator);
			}

			// Token: 0x170001D3 RID: 467
			// (get) Token: 0x06000EB8 RID: 3768 RVA: 0x0000F259 File Offset: 0x0000D459
			public JSONNode Current
			{
				get
				{
					return null;
				}
			}

			// Token: 0x06000EB9 RID: 3769 RVA: 0x0000F25C File Offset: 0x0000D45C
			public bool MoveNext()
			{
				return false;
			}

			// Token: 0x06000EBA RID: 3770 RVA: 0x00010AE4 File Offset: 0x0000ECE4
			public JSONNode.ValueEnumerator GetEnumerator()
			{
				return default(JSONNode.ValueEnumerator);
			}

			// Token: 0x04000615 RID: 1557
			private JSONNode.Enumerator m_Enumerator;
		}

		// Token: 0x02000174 RID: 372
		public struct KeyEnumerator
		{
			// Token: 0x06000EBB RID: 3771 RVA: 0x00010AFC File Offset: 0x0000ECFC
			public KeyEnumerator(List<JSONNode>.Enumerator aArrayEnum)
			{
				this.m_Enumerator = default(JSONNode.Enumerator);
			}

			// Token: 0x06000EBC RID: 3772 RVA: 0x00010B18 File Offset: 0x0000ED18
			public KeyEnumerator(Dictionary<string, JSONNode>.Enumerator aDictEnum)
			{
				this.m_Enumerator = default(JSONNode.Enumerator);
			}

			// Token: 0x06000EBD RID: 3773 RVA: 0x00010B34 File Offset: 0x0000ED34
			public KeyEnumerator(JSONNode.Enumerator aEnumerator)
			{
				this.m_Enumerator = default(JSONNode.Enumerator);
			}

			// Token: 0x170001D4 RID: 468
			// (get) Token: 0x06000EBE RID: 3774 RVA: 0x0000F25F File Offset: 0x0000D45F
			public JSONNode Current
			{
				get
				{
					return null;
				}
			}

			// Token: 0x06000EBF RID: 3775 RVA: 0x0000F262 File Offset: 0x0000D462
			public bool MoveNext()
			{
				return false;
			}

			// Token: 0x06000EC0 RID: 3776 RVA: 0x00010B50 File Offset: 0x0000ED50
			public JSONNode.KeyEnumerator GetEnumerator()
			{
				return default(JSONNode.KeyEnumerator);
			}

			// Token: 0x04000616 RID: 1558
			private JSONNode.Enumerator m_Enumerator;
		}

		// Token: 0x02000175 RID: 373
		public class LinqEnumerator : IEnumerator<KeyValuePair<string, JSONNode>>, IEnumerator, IDisposable, IEnumerable<KeyValuePair<string, JSONNode>>, IEnumerable
		{
			// Token: 0x06000EC1 RID: 3777 RVA: 0x0000F265 File Offset: 0x0000D465
			internal LinqEnumerator(JSONNode aNode)
			{
			}

			// Token: 0x170001D5 RID: 469
			// (get) Token: 0x06000EC2 RID: 3778 RVA: 0x00010B68 File Offset: 0x0000ED68
			public KeyValuePair<string, JSONNode> Current
			{
				get
				{
					return default(KeyValuePair<string, JSONNode>);
				}
			}

			// Token: 0x170001D6 RID: 470
			// (get) Token: 0x06000EC3 RID: 3779 RVA: 0x0000F26D File Offset: 0x0000D46D
			object IEnumerator.Current
			{
				get
				{
					return null;
				}
			}

			// Token: 0x06000EC4 RID: 3780 RVA: 0x0000F270 File Offset: 0x0000D470
			public bool MoveNext()
			{
				return false;
			}

			// Token: 0x06000EC5 RID: 3781 RVA: 0x0000F273 File Offset: 0x0000D473
			public void Dispose()
			{
			}

			// Token: 0x06000EC6 RID: 3782 RVA: 0x0000F275 File Offset: 0x0000D475
			public IEnumerator<KeyValuePair<string, JSONNode>> GetEnumerator()
			{
				return null;
			}

			// Token: 0x06000EC7 RID: 3783 RVA: 0x0000F278 File Offset: 0x0000D478
			public void Reset()
			{
			}

			// Token: 0x06000EC8 RID: 3784 RVA: 0x0000F27A File Offset: 0x0000D47A
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			// Token: 0x04000617 RID: 1559
			private JSONNode m_Node;

			// Token: 0x04000618 RID: 1560
			private JSONNode.Enumerator m_Enumerator;
		}

		// Token: 0x02000176 RID: 374
		private sealed class <get_Children>d__39 : IEnumerable<JSONNode>, IEnumerable, IEnumerator<JSONNode>, IEnumerator, IDisposable
		{
			// Token: 0x06000EC9 RID: 3785 RVA: 0x0000F27D File Offset: 0x0000D47D
			public <get_Children>d__39(int <>1__state)
			{
			}

			// Token: 0x06000ECA RID: 3786 RVA: 0x0000F285 File Offset: 0x0000D485
			void IDisposable.Dispose()
			{
			}

			// Token: 0x06000ECB RID: 3787 RVA: 0x0000F287 File Offset: 0x0000D487
			bool IEnumerator.MoveNext()
			{
				return false;
			}

			// Token: 0x170001D7 RID: 471
			// (get) Token: 0x06000ECC RID: 3788 RVA: 0x0000F28A File Offset: 0x0000D48A
			JSONNode IEnumerator<JSONNode>.Current
			{
				get
				{
					return null;
				}
			}

			// Token: 0x06000ECD RID: 3789 RVA: 0x0000F28D File Offset: 0x0000D48D
			void IEnumerator.Reset()
			{
			}

			// Token: 0x170001D8 RID: 472
			// (get) Token: 0x06000ECE RID: 3790 RVA: 0x0000F28F File Offset: 0x0000D48F
			object IEnumerator.Current
			{
				get
				{
					return null;
				}
			}

			// Token: 0x06000ECF RID: 3791 RVA: 0x0000F292 File Offset: 0x0000D492
			IEnumerator<JSONNode> IEnumerable<JSONNode>.GetEnumerator()
			{
				return null;
			}

			// Token: 0x06000ED0 RID: 3792 RVA: 0x0000F295 File Offset: 0x0000D495
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			// Token: 0x04000619 RID: 1561
			private int <>1__state;

			// Token: 0x0400061A RID: 1562
			private JSONNode <>2__current;

			// Token: 0x0400061B RID: 1563
			private int <>l__initialThreadId;
		}

		// Token: 0x02000177 RID: 375
		private sealed class <get_DeepChildren>d__41 : IEnumerable<JSONNode>, IEnumerable, IEnumerator<JSONNode>, IEnumerator, IDisposable
		{
			// Token: 0x06000ED1 RID: 3793 RVA: 0x0000F298 File Offset: 0x0000D498
			public <get_DeepChildren>d__41(int <>1__state)
			{
			}

			// Token: 0x06000ED2 RID: 3794 RVA: 0x0000F2A0 File Offset: 0x0000D4A0
			void IDisposable.Dispose()
			{
			}

			// Token: 0x06000ED3 RID: 3795 RVA: 0x0000F2A2 File Offset: 0x0000D4A2
			bool IEnumerator.MoveNext()
			{
				return false;
			}

			// Token: 0x06000ED4 RID: 3796 RVA: 0x0000F2A5 File Offset: 0x0000D4A5
			private void <>m__Finally1()
			{
			}

			// Token: 0x06000ED5 RID: 3797 RVA: 0x0000F2A7 File Offset: 0x0000D4A7
			private void <>m__Finally2()
			{
			}

			// Token: 0x170001D9 RID: 473
			// (get) Token: 0x06000ED6 RID: 3798 RVA: 0x0000F2A9 File Offset: 0x0000D4A9
			JSONNode IEnumerator<JSONNode>.Current
			{
				get
				{
					return null;
				}
			}

			// Token: 0x06000ED7 RID: 3799 RVA: 0x0000F2AC File Offset: 0x0000D4AC
			void IEnumerator.Reset()
			{
			}

			// Token: 0x170001DA RID: 474
			// (get) Token: 0x06000ED8 RID: 3800 RVA: 0x0000F2AE File Offset: 0x0000D4AE
			object IEnumerator.Current
			{
				get
				{
					return null;
				}
			}

			// Token: 0x06000ED9 RID: 3801 RVA: 0x0000F2B1 File Offset: 0x0000D4B1
			IEnumerator<JSONNode> IEnumerable<JSONNode>.GetEnumerator()
			{
				return null;
			}

			// Token: 0x06000EDA RID: 3802 RVA: 0x0000F2B4 File Offset: 0x0000D4B4
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			// Token: 0x0400061C RID: 1564
			private int <>1__state;

			// Token: 0x0400061D RID: 1565
			private JSONNode <>2__current;

			// Token: 0x0400061E RID: 1566
			private int <>l__initialThreadId;

			// Token: 0x0400061F RID: 1567
			public JSONNode <>4__this;

			// Token: 0x04000620 RID: 1568
			private IEnumerator<JSONNode> <>7__wrap1;

			// Token: 0x04000621 RID: 1569
			private IEnumerator<JSONNode> <>7__wrap2;
		}
	}
}
