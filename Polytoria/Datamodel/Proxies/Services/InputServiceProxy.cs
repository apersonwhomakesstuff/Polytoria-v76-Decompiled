using System;
using System.Collections.Generic;
using Polytoria.Datamodel.Services;
using Polytoria.Lua;
using UnityEngine;

namespace Polytoria.Datamodel.Proxies.Services
{
	// Token: 0x02000310 RID: 784
	public class InputServiceProxy
	{
		// Token: 0x06002755 RID: 10069 RVA: 0x0001C8EE File Offset: 0x0001AAEE
		public InputServiceProxy(InputService target)
		{
		}

		// Token: 0x17000C34 RID: 3124
		// (get) Token: 0x06002756 RID: 10070 RVA: 0x0001C8F6 File Offset: 0x0001AAF6
		public static LuaEvent KeyDown
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000C35 RID: 3125
		// (get) Token: 0x06002757 RID: 10071 RVA: 0x00025FD8 File Offset: 0x000241D8
		public static Vector3 MousePosition
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17000C36 RID: 3126
		// (get) Token: 0x06002758 RID: 10072 RVA: 0x0001C8F9 File Offset: 0x0001AAF9
		// (set) Token: 0x06002759 RID: 10073 RVA: 0x0001C8FC File Offset: 0x0001AAFC
		public static bool CursorLocked
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x17000C37 RID: 3127
		// (get) Token: 0x0600275A RID: 10074 RVA: 0x0001C8FE File Offset: 0x0001AAFE
		// (set) Token: 0x0600275B RID: 10075 RVA: 0x0001C901 File Offset: 0x0001AB01
		public static bool CursorVisible
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x17000C38 RID: 3128
		// (get) Token: 0x0600275C RID: 10076 RVA: 0x0001C903 File Offset: 0x0001AB03
		public static int ScreenWidth
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x17000C39 RID: 3129
		// (get) Token: 0x0600275D RID: 10077 RVA: 0x0001C906 File Offset: 0x0001AB06
		public static int ScreenHeight
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x17000C3A RID: 3130
		// (get) Token: 0x0600275E RID: 10078 RVA: 0x0001C909 File Offset: 0x0001AB09
		public static bool AnyKey
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000C3B RID: 3131
		// (get) Token: 0x0600275F RID: 10079 RVA: 0x0001C90C File Offset: 0x0001AB0C
		public static bool AnyKeyDown
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000C3C RID: 3132
		// (get) Token: 0x06002760 RID: 10080 RVA: 0x0001C90F File Offset: 0x0001AB0F
		public static bool IsInputFocused
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06002761 RID: 10081 RVA: 0x00025FF0 File Offset: 0x000241F0
		public static Vector3 GetMouseWorldPosition()
		{
			return default(Vector3);
		}

		// Token: 0x06002762 RID: 10082 RVA: 0x00026008 File Offset: 0x00024208
		public static Vector3 GetMouseWorldPoint()
		{
			return default(Vector3);
		}

		// Token: 0x06002763 RID: 10083 RVA: 0x00026020 File Offset: 0x00024220
		public static Vector3 ScreenToWorldPoint(Vector3 pos)
		{
			return default(Vector3);
		}

		// Token: 0x06002764 RID: 10084 RVA: 0x00026038 File Offset: 0x00024238
		public static Vector3 ScreenToViewportPoint(Vector3 pos)
		{
			return default(Vector3);
		}

		// Token: 0x06002765 RID: 10085 RVA: 0x00026050 File Offset: 0x00024250
		public static Vector3 WorldToScreenPoint(Vector3 pos)
		{
			return default(Vector3);
		}

		// Token: 0x06002766 RID: 10086 RVA: 0x00026068 File Offset: 0x00024268
		public static Vector3 WorldToViewportPoint(Vector3 pos)
		{
			return default(Vector3);
		}

		// Token: 0x06002767 RID: 10087 RVA: 0x00026080 File Offset: 0x00024280
		public static Vector3 ViewportToWorldPoint(Vector3 pos)
		{
			return default(Vector3);
		}

		// Token: 0x06002768 RID: 10088 RVA: 0x00026098 File Offset: 0x00024298
		public static Vector3 ViewportToScreenPoint(Vector3 pos)
		{
			return default(Vector3);
		}

		// Token: 0x06002769 RID: 10089 RVA: 0x000260B0 File Offset: 0x000242B0
		public static RayResult? ScreenPointToRay(Vector3 pos, List<Instance> ignoreList = null)
		{
			return null;
		}

		// Token: 0x0600276A RID: 10090 RVA: 0x000260C8 File Offset: 0x000242C8
		public static RayResult? ViewportPointToRay(Vector3 pos, List<Instance> ignoreList = null)
		{
			return null;
		}

		// Token: 0x0600276B RID: 10091 RVA: 0x0001C912 File Offset: 0x0001AB12
		public static bool GetButton(string buttonName)
		{
			return false;
		}

		// Token: 0x0600276C RID: 10092 RVA: 0x0001C915 File Offset: 0x0001AB15
		public static bool GetButtonDown(string buttonName)
		{
			return false;
		}

		// Token: 0x0600276D RID: 10093 RVA: 0x0001C918 File Offset: 0x0001AB18
		public static bool GetButtonUp(string buttonName)
		{
			return false;
		}

		// Token: 0x0600276E RID: 10094 RVA: 0x0001C91B File Offset: 0x0001AB1B
		public static float GetAxis(string axisName)
		{
			return 0f;
		}

		// Token: 0x0600276F RID: 10095 RVA: 0x0001C922 File Offset: 0x0001AB22
		public static float GetAxisRaw(string axisName)
		{
			return 0f;
		}

		// Token: 0x06002770 RID: 10096 RVA: 0x0001C929 File Offset: 0x0001AB29
		public static bool GetKey(KeyCode key)
		{
			return false;
		}

		// Token: 0x06002771 RID: 10097 RVA: 0x0001C92C File Offset: 0x0001AB2C
		public static bool GetKeyDown(KeyCode key)
		{
			return false;
		}

		// Token: 0x06002772 RID: 10098 RVA: 0x0001C92F File Offset: 0x0001AB2F
		public static bool GetKeyUp(KeyCode key)
		{
			return false;
		}

		// Token: 0x06002773 RID: 10099 RVA: 0x0001C932 File Offset: 0x0001AB32
		public static bool GetMouseButton(int button)
		{
			return false;
		}

		// Token: 0x06002774 RID: 10100 RVA: 0x0001C935 File Offset: 0x0001AB35
		public static bool GetMouseButtonDown(int button)
		{
			return false;
		}

		// Token: 0x06002775 RID: 10101 RVA: 0x0001C938 File Offset: 0x0001AB38
		public static bool GetMouseButtonUp(int button)
		{
			return false;
		}

		// Token: 0x04000D3C RID: 3388
		private readonly InputService inputService;

		// Token: 0x04000D3D RID: 3389
		public static LuaEvent KeyUp;
	}
}
