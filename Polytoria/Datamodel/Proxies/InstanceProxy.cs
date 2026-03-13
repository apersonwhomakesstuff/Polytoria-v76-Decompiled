using System;
using MoonSharp.Interpreter;
using Polytoria.Lua;
using UnityEngine;

namespace Polytoria.Datamodel.Proxies
{
	// Token: 0x020002DE RID: 734
	public class InstanceProxy
	{
		// Token: 0x060024F9 RID: 9465 RVA: 0x0001C1BD File Offset: 0x0001A3BD
		public InstanceProxy(Instance target)
		{
		}

		// Token: 0x17000B2D RID: 2861
		// (get) Token: 0x060024FA RID: 9466 RVA: 0x0001C1C5 File Offset: 0x0001A3C5
		public Instance Item
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000B2E RID: 2862
		// (get) Token: 0x060024FB RID: 9467 RVA: 0x0001C1C8 File Offset: 0x0001A3C8
		public Instance Item
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000B2F RID: 2863
		// (get) Token: 0x060024FC RID: 9468 RVA: 0x0001C1CB File Offset: 0x0001A3CB
		// (set) Token: 0x060024FD RID: 9469 RVA: 0x0001C1CE File Offset: 0x0001A3CE
		public string Name
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x17000B30 RID: 2864
		// (get) Token: 0x060024FE RID: 9470 RVA: 0x0001C1D0 File Offset: 0x0001A3D0
		public string ClassName
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000B31 RID: 2865
		// (get) Token: 0x060024FF RID: 9471 RVA: 0x0001C1D3 File Offset: 0x0001A3D3
		public DynValue Shared
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000B32 RID: 2866
		// (get) Token: 0x06002500 RID: 9472 RVA: 0x0001C1D6 File Offset: 0x0001A3D6
		public bool ClientSpawned
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000B33 RID: 2867
		// (get) Token: 0x06002501 RID: 9473 RVA: 0x0001C1D9 File Offset: 0x0001A3D9
		// (set) Token: 0x06002502 RID: 9474 RVA: 0x0001C1DC File Offset: 0x0001A3DC
		public Instance Parent
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x17000B34 RID: 2868
		// (get) Token: 0x06002503 RID: 9475 RVA: 0x0001C1DE File Offset: 0x0001A3DE
		public LuaEvent ChildRemoved
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000B35 RID: 2869
		// (get) Token: 0x06002504 RID: 9476 RVA: 0x0001C1E1 File Offset: 0x0001A3E1
		public LuaEvent ChildAdded
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000B36 RID: 2870
		// (get) Token: 0x06002505 RID: 9477 RVA: 0x0001C1E4 File Offset: 0x0001A3E4
		public LuaEvent Touched
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000B37 RID: 2871
		// (get) Token: 0x06002506 RID: 9478 RVA: 0x0001C1E7 File Offset: 0x0001A3E7
		public LuaEvent TouchEnded
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000B38 RID: 2872
		// (get) Token: 0x06002507 RID: 9479 RVA: 0x0001C1EA File Offset: 0x0001A3EA
		public LuaEvent Clicked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000B39 RID: 2873
		// (get) Token: 0x06002508 RID: 9480 RVA: 0x0001C1ED File Offset: 0x0001A3ED
		public LuaEvent MouseEnter
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000B3A RID: 2874
		// (get) Token: 0x06002509 RID: 9481 RVA: 0x0001C1F0 File Offset: 0x0001A3F0
		public LuaEvent MouseExit
		{
			get
			{
				return null;
			}
		}

		// Token: 0x0600250A RID: 9482 RVA: 0x0001C1F3 File Offset: 0x0001A3F3
		public Instance GetParent()
		{
			return null;
		}

		// Token: 0x0600250B RID: 9483 RVA: 0x0001C1F6 File Offset: 0x0001A3F6
		public void SetParent(Instance parent)
		{
		}

		// Token: 0x0600250C RID: 9484 RVA: 0x0001C1F8 File Offset: 0x0001A3F8
		public Instance FindChild(string name)
		{
			return null;
		}

		// Token: 0x0600250D RID: 9485 RVA: 0x0001C1FB File Offset: 0x0001A3FB
		public Instance[] GetChildren()
		{
			return null;
		}

		// Token: 0x0600250E RID: 9486 RVA: 0x0001C1FE File Offset: 0x0001A3FE
		public Instance[] GetChildrenOfClass(string className)
		{
			return null;
		}

		// Token: 0x0600250F RID: 9487 RVA: 0x0001C201 File Offset: 0x0001A401
		public Instance FindChildByClass(string className)
		{
			return null;
		}

		// Token: 0x06002510 RID: 9488 RVA: 0x0001C204 File Offset: 0x0001A404
		public bool IsA(string className)
		{
			return false;
		}

		// Token: 0x06002511 RID: 9489 RVA: 0x0001C207 File Offset: 0x0001A407
		public bool IsDescendantOf(Instance parent)
		{
			return false;
		}

		// Token: 0x06002512 RID: 9490 RVA: 0x0001C20A File Offset: 0x0001A40A
		public void Destroy(float time = 0f)
		{
		}

		// Token: 0x06002513 RID: 9491 RVA: 0x0001C20C File Offset: 0x0001A40C
		public void Delete(float time = 0f)
		{
		}

		// Token: 0x06002514 RID: 9492 RVA: 0x0001C20E File Offset: 0x0001A40E
		public static Instance New(string className, Instance parent = null)
		{
			return null;
		}

		// Token: 0x06002515 RID: 9493 RVA: 0x0001C211 File Offset: 0x0001A411
		public Instance Clone()
		{
			return null;
		}

		// Token: 0x06002516 RID: 9494 RVA: 0x00025858 File Offset: 0x00023A58
		public Bounds GetBounds()
		{
			return default(Bounds);
		}

		// Token: 0x04000D0A RID: 3338
		private readonly Instance target;
	}
}
