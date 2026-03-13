using System;
using System.Collections.Generic;
using Polytoria.Lua;
using UnityEngine;

namespace Polytoria.Datamodel.Services
{
	// Token: 0x020002CA RID: 714
	public class InputService
	{
		// Token: 0x17000AD6 RID: 2774
		// (get) Token: 0x060023EE RID: 9198 RVA: 0x000253F0 File Offset: 0x000235F0
		public static Vector3 MousePosition
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17000AD7 RID: 2775
		// (get) Token: 0x060023EF RID: 9199 RVA: 0x0001BE99 File Offset: 0x0001A099
		// (set) Token: 0x060023F0 RID: 9200 RVA: 0x0001BE9C File Offset: 0x0001A09C
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

		// Token: 0x17000AD8 RID: 2776
		// (get) Token: 0x060023F1 RID: 9201 RVA: 0x0001BE9E File Offset: 0x0001A09E
		// (set) Token: 0x060023F2 RID: 9202 RVA: 0x0001BEA1 File Offset: 0x0001A0A1
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

		// Token: 0x17000AD9 RID: 2777
		// (get) Token: 0x060023F3 RID: 9203 RVA: 0x0001BEA3 File Offset: 0x0001A0A3
		public static int ScreenWidth
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x17000ADA RID: 2778
		// (get) Token: 0x060023F4 RID: 9204 RVA: 0x0001BEA6 File Offset: 0x0001A0A6
		public static int ScreenHeight
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x17000ADB RID: 2779
		// (get) Token: 0x060023F5 RID: 9205 RVA: 0x0001BEA9 File Offset: 0x0001A0A9
		public static bool AnyKey
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000ADC RID: 2780
		// (get) Token: 0x060023F6 RID: 9206 RVA: 0x0001BEAC File Offset: 0x0001A0AC
		public static bool AnyKeyDown
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000ADD RID: 2781
		// (get) Token: 0x060023F7 RID: 9207 RVA: 0x0001BEAF File Offset: 0x0001A0AF
		public static bool IsInputFocused
		{
			get
			{
				return false;
			}
		}

		// Token: 0x060023F8 RID: 9208 RVA: 0x00025408 File Offset: 0x00023608
		public static Vector3 GetMouseWorldPosition()
		{
			return default(Vector3);
		}

		// Token: 0x060023F9 RID: 9209 RVA: 0x00025420 File Offset: 0x00023620
		public static Vector3 GetMouseWorldPoint()
		{
			return default(Vector3);
		}

		// Token: 0x060023FA RID: 9210 RVA: 0x00025438 File Offset: 0x00023638
		public static Vector3 ScreenToWorldPoint(Vector3 pos)
		{
			return default(Vector3);
		}

		// Token: 0x060023FB RID: 9211 RVA: 0x00025450 File Offset: 0x00023650
		public static Vector3 ScreenToViewportPoint(Vector3 pos)
		{
			return default(Vector3);
		}

		// Token: 0x060023FC RID: 9212 RVA: 0x00025468 File Offset: 0x00023668
		public static Vector3 WorldToScreenPoint(Vector3 pos)
		{
			return default(Vector3);
		}

		// Token: 0x060023FD RID: 9213 RVA: 0x00025480 File Offset: 0x00023680
		public static Vector3 WorldToViewportPoint(Vector3 pos)
		{
			return default(Vector3);
		}

		// Token: 0x060023FE RID: 9214 RVA: 0x00025498 File Offset: 0x00023698
		public static Vector3 ViewportToWorldPoint(Vector3 pos)
		{
			return default(Vector3);
		}

		// Token: 0x060023FF RID: 9215 RVA: 0x000254B0 File Offset: 0x000236B0
		public static Vector3 ViewportToScreenPoint(Vector3 pos)
		{
			return default(Vector3);
		}

		// Token: 0x06002400 RID: 9216 RVA: 0x000254C8 File Offset: 0x000236C8
		public static RayResult? ScreenPointToRay(Vector3 pos, List<Instance> ignoreList = null)
		{
			return null;
		}

		// Token: 0x06002401 RID: 9217 RVA: 0x000254E0 File Offset: 0x000236E0
		public static RayResult? ViewportPointToRay(Vector3 pos, List<Instance> ignoreList = null)
		{
			return null;
		}

		// Token: 0x06002402 RID: 9218 RVA: 0x0001BEB2 File Offset: 0x0001A0B2
		public static bool GetButton(string buttonName)
		{
			return false;
		}

		// Token: 0x06002403 RID: 9219 RVA: 0x0001BEB5 File Offset: 0x0001A0B5
		public static bool GetButtonDown(string buttonName)
		{
			return false;
		}

		// Token: 0x06002404 RID: 9220 RVA: 0x0001BEB8 File Offset: 0x0001A0B8
		public static bool GetButtonUp(string buttonName)
		{
			return false;
		}

		// Token: 0x06002405 RID: 9221 RVA: 0x0001BEBB File Offset: 0x0001A0BB
		public static float GetAxis(string axisName)
		{
			return 0f;
		}

		// Token: 0x06002406 RID: 9222 RVA: 0x0001BEC2 File Offset: 0x0001A0C2
		public static float GetAxisRaw(string axisName)
		{
			return 0f;
		}

		// Token: 0x06002407 RID: 9223 RVA: 0x0001BEC9 File Offset: 0x0001A0C9
		public static bool GetKey(KeyCode key)
		{
			return false;
		}

		// Token: 0x06002408 RID: 9224 RVA: 0x0001BECC File Offset: 0x0001A0CC
		public static bool GetKeyDown(KeyCode key)
		{
			return false;
		}

		// Token: 0x06002409 RID: 9225 RVA: 0x0001BECF File Offset: 0x0001A0CF
		public static bool GetKeyUp(KeyCode key)
		{
			return false;
		}

		// Token: 0x0600240A RID: 9226 RVA: 0x0001BED2 File Offset: 0x0001A0D2
		public static bool GetMouseButton(int button)
		{
			return false;
		}

		// Token: 0x0600240B RID: 9227 RVA: 0x0001BED5 File Offset: 0x0001A0D5
		public static bool GetMouseButtonDown(int button)
		{
			return false;
		}

		// Token: 0x0600240C RID: 9228 RVA: 0x0001BED8 File Offset: 0x0001A0D8
		public static bool GetMouseButtonUp(int button)
		{
			return false;
		}

		// Token: 0x04000CED RID: 3309
		public static LuaEvent KeyDown;

		// Token: 0x04000CEE RID: 3310
		public static LuaEvent KeyUp;
	}
}
