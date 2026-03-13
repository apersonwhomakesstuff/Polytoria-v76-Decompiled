using System;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000025 RID: 37
	public struct GizmoDragInfo
	{
		// Token: 0x1700004E RID: 78
		// (get) Token: 0x0600014C RID: 332 RVA: 0x000161BC File Offset: 0x000143BC
		// (set) Token: 0x0600014D RID: 333 RVA: 0x000161BF File Offset: 0x000143BF
		public bool IsDragged
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x0600014E RID: 334 RVA: 0x000161C1 File Offset: 0x000143C1
		// (set) Token: 0x0600014F RID: 335 RVA: 0x000161C4 File Offset: 0x000143C4
		public int HandleId
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x06000150 RID: 336 RVA: 0x0001DFC4 File Offset: 0x0001C1C4
		// (set) Token: 0x06000151 RID: 337 RVA: 0x000161C6 File Offset: 0x000143C6
		public Vector3 DragBeginPoint
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x06000152 RID: 338 RVA: 0x0001DFDC File Offset: 0x0001C1DC
		// (set) Token: 0x06000153 RID: 339 RVA: 0x000161C8 File Offset: 0x000143C8
		public GizmoDragChannel DragChannel
		{
			get
			{
				return GizmoDragChannel.None;
			}
			set
			{
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x06000154 RID: 340 RVA: 0x0001DFF4 File Offset: 0x0001C1F4
		// (set) Token: 0x06000155 RID: 341 RVA: 0x000161CA File Offset: 0x000143CA
		public GizmoDimension HandleDimension
		{
			get
			{
				return GizmoDimension.None;
			}
			set
			{
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x06000156 RID: 342 RVA: 0x0001E00C File Offset: 0x0001C20C
		// (set) Token: 0x06000157 RID: 343 RVA: 0x000161CC File Offset: 0x000143CC
		public Vector3 TotalOffset
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x06000158 RID: 344 RVA: 0x0001E024 File Offset: 0x0001C224
		// (set) Token: 0x06000159 RID: 345 RVA: 0x000161CE File Offset: 0x000143CE
		public Quaternion TotalRotation
		{
			get
			{
				return default(Quaternion);
			}
			set
			{
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x0600015A RID: 346 RVA: 0x0001E03C File Offset: 0x0001C23C
		// (set) Token: 0x0600015B RID: 347 RVA: 0x000161D0 File Offset: 0x000143D0
		public Vector3 TotalScale
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x0600015C RID: 348 RVA: 0x0001E054 File Offset: 0x0001C254
		// (set) Token: 0x0600015D RID: 349 RVA: 0x000161D2 File Offset: 0x000143D2
		public Vector3 RelativeOffset
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x0600015E RID: 350 RVA: 0x0001E06C File Offset: 0x0001C26C
		// (set) Token: 0x0600015F RID: 351 RVA: 0x000161D4 File Offset: 0x000143D4
		public Quaternion RelativeRotation
		{
			get
			{
				return default(Quaternion);
			}
			set
			{
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x06000160 RID: 352 RVA: 0x0001E084 File Offset: 0x0001C284
		// (set) Token: 0x06000161 RID: 353 RVA: 0x000161D6 File Offset: 0x000143D6
		public Vector3 RelativeScale
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		// Token: 0x06000162 RID: 354 RVA: 0x000161D8 File Offset: 0x000143D8
		public void Reset()
		{
		}

		// Token: 0x04000083 RID: 131
		private bool _isDragged;

		// Token: 0x04000084 RID: 132
		private int _handleId;

		// Token: 0x04000085 RID: 133
		private Vector3 _dragBeginPoint;

		// Token: 0x04000086 RID: 134
		private GizmoDragChannel _dragChannel;

		// Token: 0x04000087 RID: 135
		private GizmoDimension _handleDimension;

		// Token: 0x04000088 RID: 136
		private Vector3 _totalOffset;

		// Token: 0x04000089 RID: 137
		private Quaternion _totalRotation;

		// Token: 0x0400008A RID: 138
		private Vector3 _totalScale;

		// Token: 0x0400008B RID: 139
		private Vector3 _relativeOffset;

		// Token: 0x0400008C RID: 140
		private Quaternion _relativeRotation;

		// Token: 0x0400008D RID: 141
		private Vector3 _relativeScale;
	}
}
