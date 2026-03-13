using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Xml;
using Polytoria.Datamodel;
using Polytoria.Types;
using U8Xml;
using UnityEngine;
using UnityEngine.Networking;

namespace Polytoria.Controllers
{
	// Token: 0x02000327 RID: 807
	public class GameIO : MonoBehaviour
	{
		// Token: 0x06002833 RID: 10291 RVA: 0x0001CB3D File Offset: 0x0001AD3D
		private void Awake()
		{
		}

		// Token: 0x06002834 RID: 10292 RVA: 0x0001CB3F File Offset: 0x0001AD3F
		public void Load(int id, Action<bool> callback = null)
		{
		}

		// Token: 0x06002835 RID: 10293 RVA: 0x0001CB41 File Offset: 0x0001AD41
		public void LoadFromFile(string path, Action<bool> callback = null)
		{
		}

		// Token: 0x06002836 RID: 10294 RVA: 0x0001CB43 File Offset: 0x0001AD43
		public Instance LoadModelFromFile(string path, Instance parent)
		{
			return null;
		}

		// Token: 0x06002837 RID: 10295 RVA: 0x0001CB46 File Offset: 0x0001AD46
		public void LoadModelFromSite(int id, Instance parent, Action<Instance> callback = null)
		{
		}

		// Token: 0x06002838 RID: 10296 RVA: 0x0001CB48 File Offset: 0x0001AD48
		public Model LoadModelFromXmlString(string xmlString, Instance parent)
		{
			return null;
		}

		// Token: 0x06002839 RID: 10297 RVA: 0x0001CB4B File Offset: 0x0001AD4B
		public void ClearDatamodel()
		{
		}

		// Token: 0x0600283A RID: 10298 RVA: 0x0001CB4D File Offset: 0x0001AD4D
		private IEnumerator PostClearDatamodel()
		{
			return null;
		}

		// Token: 0x0600283B RID: 10299 RVA: 0x0001CB50 File Offset: 0x0001AD50
		public void PostMapLoad()
		{
		}

		// Token: 0x0600283C RID: 10300 RVA: 0x0001CB52 File Offset: 0x0001AD52
		public IEnumerator ModelFromSite(int id, Instance parent, Action<Instance> callback)
		{
			return null;
		}

		// Token: 0x0600283D RID: 10301 RVA: 0x0001CB55 File Offset: 0x0001AD55
		public IEnumerator LoadFromSite(int id, Action<bool> callback = null)
		{
			return null;
		}

		// Token: 0x0600283E RID: 10302 RVA: 0x0001CB58 File Offset: 0x0001AD58
		private Instance LoadXml(U8Xml.XmlNode xml, Instance parent = null)
		{
			return null;
		}

		// Token: 0x0600283F RID: 10303 RVA: 0x0001CB5B File Offset: 0x0001AD5B
		private Instance HandleXmlNodes(U8Xml.XmlNodeList nodes, Instance parent)
		{
			return null;
		}

		// Token: 0x06002840 RID: 10304 RVA: 0x00026218 File Offset: 0x00024418
		public Vector3 XmlConvertVector3(U8Xml.XmlNode property)
		{
			return default(Vector3);
		}

		// Token: 0x06002841 RID: 10305 RVA: 0x00026230 File Offset: 0x00024430
		public Vector2 XmlConvertVector2(U8Xml.XmlNode property)
		{
			return default(Vector2);
		}

		// Token: 0x06002842 RID: 10306 RVA: 0x00026248 File Offset: 0x00024448
		public Color XmlConvertColor(U8Xml.XmlNode property)
		{
			return default(Color);
		}

		// Token: 0x06002843 RID: 10307 RVA: 0x00026260 File Offset: 0x00024460
		public ColorRange XmlConvertColorRange(U8Xml.XmlNode property)
		{
			return default(ColorRange);
		}

		// Token: 0x06002844 RID: 10308 RVA: 0x00026278 File Offset: 0x00024478
		public NumberRange XmlConvertNumberRange(U8Xml.XmlNode property)
		{
			return default(NumberRange);
		}

		// Token: 0x06002845 RID: 10309 RVA: 0x0001CB5E File Offset: 0x0001AD5E
		public string SaveModelToString(Instance root)
		{
			return null;
		}

		// Token: 0x06002846 RID: 10310 RVA: 0x0001CB61 File Offset: 0x0001AD61
		public void SaveModelToFile(Instance root, string path)
		{
		}

		// Token: 0x06002847 RID: 10311 RVA: 0x0001CB63 File Offset: 0x0001AD63
		public string SaveToString()
		{
			return null;
		}

		// Token: 0x06002848 RID: 10312 RVA: 0x0001CB66 File Offset: 0x0001AD66
		public void SaveToFile(string path)
		{
		}

		// Token: 0x06002849 RID: 10313 RVA: 0x0001CB68 File Offset: 0x0001AD68
		private void SaveHandleChild(XmlDocument doc, Instance i, XmlElement parent)
		{
		}

		// Token: 0x0600284A RID: 10314 RVA: 0x0001CB6A File Offset: 0x0001AD6A
		private void SaveString(XmlDocument doc, XmlElement properties, string name, string value)
		{
		}

		// Token: 0x0600284B RID: 10315 RVA: 0x0001CB6C File Offset: 0x0001AD6C
		private void SaveFloat(XmlDocument doc, XmlElement properties, string name, float value)
		{
		}

		// Token: 0x0600284C RID: 10316 RVA: 0x0001CB6E File Offset: 0x0001AD6E
		private void SaveInt(XmlDocument doc, XmlElement properties, string name, int value)
		{
		}

		// Token: 0x0600284D RID: 10317 RVA: 0x0001CB70 File Offset: 0x0001AD70
		private void SaveBool(XmlDocument doc, XmlElement properties, string name, bool value)
		{
		}

		// Token: 0x0600284E RID: 10318 RVA: 0x0001CB72 File Offset: 0x0001AD72
		private void SaveVector3(XmlDocument doc, XmlElement properties, string name, Vector3 value)
		{
		}

		// Token: 0x0600284F RID: 10319 RVA: 0x0001CB74 File Offset: 0x0001AD74
		private void SaveVector2(XmlDocument doc, XmlElement properties, string name, Vector2 value)
		{
		}

		// Token: 0x06002850 RID: 10320 RVA: 0x0001CB76 File Offset: 0x0001AD76
		private void SaveColor(XmlDocument doc, XmlElement properties, string name, Color value)
		{
		}

		// Token: 0x06002851 RID: 10321 RVA: 0x0001CB78 File Offset: 0x0001AD78
		private void SaveColorRange(XmlDocument doc, XmlElement properties, string name, ColorRange value)
		{
		}

		// Token: 0x06002852 RID: 10322 RVA: 0x0001CB7A File Offset: 0x0001AD7A
		private void SaveNumberRange(XmlDocument doc, XmlElement properties, string name, NumberRange value)
		{
		}

		// Token: 0x04000D91 RID: 3473
		private Game game;

		// Token: 0x04000D92 RID: 3474
		public static GameIO singleton;

		// Token: 0x04000D93 RID: 3475
		private List<Instance> spawnInstances;

		// Token: 0x0200041D RID: 1053
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06002CC2 RID: 11458 RVA: 0x0001DA3F File Offset: 0x0001BC3F
			internal bool <SaveHandleChild>b__25_0(PropertyInfo prop)
			{
				return false;
			}

			// Token: 0x040011AC RID: 4524
			public static readonly GameIO.<>c <>9;

			// Token: 0x040011AD RID: 4525
			public static Func<PropertyInfo, bool> <>9__25_0;
		}

		// Token: 0x0200041E RID: 1054
		private sealed class <LoadFromSite>d__13 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06002CC3 RID: 11459 RVA: 0x0001DA42 File Offset: 0x0001BC42
			public <LoadFromSite>d__13(int <>1__state)
			{
			}

			// Token: 0x06002CC4 RID: 11460 RVA: 0x0001DA4A File Offset: 0x0001BC4A
			void IDisposable.Dispose()
			{
			}

			// Token: 0x06002CC5 RID: 11461 RVA: 0x0001DA4C File Offset: 0x0001BC4C
			bool IEnumerator.MoveNext()
			{
				return false;
			}

			// Token: 0x06002CC6 RID: 11462 RVA: 0x0001DA4F File Offset: 0x0001BC4F
			private void <>m__Finally1()
			{
			}

			// Token: 0x17000CFE RID: 3326
			// (get) Token: 0x06002CC7 RID: 11463 RVA: 0x0001DA51 File Offset: 0x0001BC51
			object IEnumerator<object>.Current
			{
				get
				{
					return null;
				}
			}

			// Token: 0x06002CC8 RID: 11464 RVA: 0x0001DA54 File Offset: 0x0001BC54
			void IEnumerator.Reset()
			{
			}

			// Token: 0x17000CFF RID: 3327
			// (get) Token: 0x06002CC9 RID: 11465 RVA: 0x0001DA56 File Offset: 0x0001BC56
			object IEnumerator.Current
			{
				get
				{
					return null;
				}
			}

			// Token: 0x040011AE RID: 4526
			private int <>1__state;

			// Token: 0x040011AF RID: 4527
			private object <>2__current;

			// Token: 0x040011B0 RID: 4528
			public int id;

			// Token: 0x040011B1 RID: 4529
			public GameIO <>4__this;

			// Token: 0x040011B2 RID: 4530
			public Action<bool> callback;

			// Token: 0x040011B3 RID: 4531
			private UnityWebRequest <uwr>5__2;
		}

		// Token: 0x0200041F RID: 1055
		private sealed class <ModelFromSite>d__12 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06002CCA RID: 11466 RVA: 0x0001DA59 File Offset: 0x0001BC59
			public <ModelFromSite>d__12(int <>1__state)
			{
			}

			// Token: 0x06002CCB RID: 11467 RVA: 0x0001DA61 File Offset: 0x0001BC61
			void IDisposable.Dispose()
			{
			}

			// Token: 0x06002CCC RID: 11468 RVA: 0x0001DA63 File Offset: 0x0001BC63
			bool IEnumerator.MoveNext()
			{
				return false;
			}

			// Token: 0x06002CCD RID: 11469 RVA: 0x0001DA66 File Offset: 0x0001BC66
			private void <>m__Finally1()
			{
			}

			// Token: 0x17000D00 RID: 3328
			// (get) Token: 0x06002CCE RID: 11470 RVA: 0x0001DA68 File Offset: 0x0001BC68
			object IEnumerator<object>.Current
			{
				get
				{
					return null;
				}
			}

			// Token: 0x06002CCF RID: 11471 RVA: 0x0001DA6B File Offset: 0x0001BC6B
			void IEnumerator.Reset()
			{
			}

			// Token: 0x17000D01 RID: 3329
			// (get) Token: 0x06002CD0 RID: 11472 RVA: 0x0001DA6D File Offset: 0x0001BC6D
			object IEnumerator.Current
			{
				get
				{
					return null;
				}
			}

			// Token: 0x040011B4 RID: 4532
			private int <>1__state;

			// Token: 0x040011B5 RID: 4533
			private object <>2__current;

			// Token: 0x040011B6 RID: 4534
			public int id;

			// Token: 0x040011B7 RID: 4535
			public GameIO <>4__this;

			// Token: 0x040011B8 RID: 4536
			public Instance parent;

			// Token: 0x040011B9 RID: 4537
			public Action<Instance> callback;

			// Token: 0x040011BA RID: 4538
			private UnityWebRequest <uwr>5__2;
		}

		// Token: 0x02000420 RID: 1056
		private sealed class <PostClearDatamodel>d__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06002CD1 RID: 11473 RVA: 0x0001DA70 File Offset: 0x0001BC70
			public <PostClearDatamodel>d__10(int <>1__state)
			{
			}

			// Token: 0x06002CD2 RID: 11474 RVA: 0x0001DA78 File Offset: 0x0001BC78
			void IDisposable.Dispose()
			{
			}

			// Token: 0x06002CD3 RID: 11475 RVA: 0x0001DA7A File Offset: 0x0001BC7A
			bool IEnumerator.MoveNext()
			{
				return false;
			}

			// Token: 0x17000D02 RID: 3330
			// (get) Token: 0x06002CD4 RID: 11476 RVA: 0x0001DA7D File Offset: 0x0001BC7D
			object IEnumerator<object>.Current
			{
				get
				{
					return null;
				}
			}

			// Token: 0x06002CD5 RID: 11477 RVA: 0x0001DA80 File Offset: 0x0001BC80
			void IEnumerator.Reset()
			{
			}

			// Token: 0x17000D03 RID: 3331
			// (get) Token: 0x06002CD6 RID: 11478 RVA: 0x0001DA82 File Offset: 0x0001BC82
			object IEnumerator.Current
			{
				get
				{
					return null;
				}
			}

			// Token: 0x040011BB RID: 4539
			private int <>1__state;

			// Token: 0x040011BC RID: 4540
			private object <>2__current;

			// Token: 0x040011BD RID: 4541
			public GameIO <>4__this;
		}
	}
}
