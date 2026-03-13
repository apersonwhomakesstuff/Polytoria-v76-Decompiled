using System;
using System.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x0200023C RID: 572
	[Serializable]
	public class RTObjectSelectionGizmos : MonoSingleton<RTObjectSelectionGizmos>, IObjectCollectionGizmoController
	{
		// Token: 0x17000863 RID: 2147
		// (get) Token: 0x06001915 RID: 6421 RVA: 0x0001A133 File Offset: 0x00018333
		public bool AreGizmosVisible
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000864 RID: 2148
		// (get) Token: 0x06001916 RID: 6422 RVA: 0x0001A136 File Offset: 0x00018336
		public GameObject PivotObject
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000865 RID: 2149
		// (get) Token: 0x06001917 RID: 6423 RVA: 0x0001A139 File Offset: 0x00018339
		public Gizmo WorkGizmo
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000866 RID: 2150
		// (get) Token: 0x06001918 RID: 6424 RVA: 0x0001A13C File Offset: 0x0001833C
		public ObjectSelectionGizmosHotkeys Hotkeys
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000867 RID: 2151
		// (get) Token: 0x06001919 RID: 6425 RVA: 0x0001A13F File Offset: 0x0001833F
		public MoveGizmoSettings2D MoveGizmoSettings2D
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000868 RID: 2152
		// (get) Token: 0x0600191A RID: 6426 RVA: 0x0001A142 File Offset: 0x00018342
		public MoveGizmoSettings3D MoveGizmoSettings3D
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000869 RID: 2153
		// (get) Token: 0x0600191B RID: 6427 RVA: 0x0001A145 File Offset: 0x00018345
		public MoveGizmoLookAndFeel2D MoveGizmoLookAndFeel2D
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700086A RID: 2154
		// (get) Token: 0x0600191C RID: 6428 RVA: 0x0001A148 File Offset: 0x00018348
		public MoveGizmoLookAndFeel3D MoveGizmoLookAndFeel3D
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700086B RID: 2155
		// (get) Token: 0x0600191D RID: 6429 RVA: 0x0001A14B File Offset: 0x0001834B
		public MoveGizmoHotkeys MoveGizmoHotkeys
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700086C RID: 2156
		// (get) Token: 0x0600191E RID: 6430 RVA: 0x0001A14E File Offset: 0x0001834E
		public ObjectTransformGizmoSettings ObjectMoveGizmoSettings
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700086D RID: 2157
		// (get) Token: 0x0600191F RID: 6431 RVA: 0x0001A151 File Offset: 0x00018351
		public RotationGizmoSettings3D RotationGizmoSettings3D
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700086E RID: 2158
		// (get) Token: 0x06001920 RID: 6432 RVA: 0x0001A154 File Offset: 0x00018354
		public RotationGizmoLookAndFeel3D RotationGizmoLookAndFeel3D
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700086F RID: 2159
		// (get) Token: 0x06001921 RID: 6433 RVA: 0x0001A157 File Offset: 0x00018357
		public RotationGizmoHotkeys RotationGizmoHotkeys
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000870 RID: 2160
		// (get) Token: 0x06001922 RID: 6434 RVA: 0x0001A15A File Offset: 0x0001835A
		public ObjectTransformGizmoSettings ObjectRotationGizmoSettings
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000871 RID: 2161
		// (get) Token: 0x06001923 RID: 6435 RVA: 0x0001A15D File Offset: 0x0001835D
		public ScaleGizmoSettings3D ScaleGizmoSettings3D
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000872 RID: 2162
		// (get) Token: 0x06001924 RID: 6436 RVA: 0x0001A160 File Offset: 0x00018360
		public ScaleGizmoLookAndFeel3D ScaleGizmoLookAndFeel3D
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000873 RID: 2163
		// (get) Token: 0x06001925 RID: 6437 RVA: 0x0001A163 File Offset: 0x00018363
		public ScaleGizmoHotkeys ScaleGizmoHotkeys
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000874 RID: 2164
		// (get) Token: 0x06001926 RID: 6438 RVA: 0x0001A166 File Offset: 0x00018366
		public ObjectTransformGizmoSettings ObjectScaleGizmoSettings
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000875 RID: 2165
		// (get) Token: 0x06001927 RID: 6439 RVA: 0x0001A169 File Offset: 0x00018369
		public UniversalGizmoSettings2D UniversalGizmoSettings2D
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000876 RID: 2166
		// (get) Token: 0x06001928 RID: 6440 RVA: 0x0001A16C File Offset: 0x0001836C
		public UniversalGizmoSettings3D UniversalGizmoSettings3D
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000877 RID: 2167
		// (get) Token: 0x06001929 RID: 6441 RVA: 0x0001A16F File Offset: 0x0001836F
		public UniversalGizmoLookAndFeel2D UniversalGizmoLookAndFeel2D
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000878 RID: 2168
		// (get) Token: 0x0600192A RID: 6442 RVA: 0x0001A172 File Offset: 0x00018372
		public UniversalGizmoLookAndFeel3D UniversalGizmoLookAndFeel3D
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000879 RID: 2169
		// (get) Token: 0x0600192B RID: 6443 RVA: 0x0001A175 File Offset: 0x00018375
		public UniversalGizmoHotkeys UniversalGizmoHotkeys
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700087A RID: 2170
		// (get) Token: 0x0600192C RID: 6444 RVA: 0x0001A178 File Offset: 0x00018378
		public ObjectTransformGizmoSettings ObjectUniversalGizmoSettings
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700087B RID: 2171
		// (get) Token: 0x0600192D RID: 6445 RVA: 0x0001A17B File Offset: 0x0001837B
		public BoxGizmoSettings3D BoxScaleGizmoSettings3D
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700087C RID: 2172
		// (get) Token: 0x0600192E RID: 6446 RVA: 0x0001A17E File Offset: 0x0001837E
		public BoxGizmoLookAndFeel3D BoxScaleGizmoLookAndFeel3D
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700087D RID: 2173
		// (get) Token: 0x0600192F RID: 6447 RVA: 0x0001A181 File Offset: 0x00018381
		public BoxGizmoHotkeys BoxScaleGizmoHotkeys
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700087E RID: 2174
		// (get) Token: 0x06001930 RID: 6448 RVA: 0x0001A184 File Offset: 0x00018384
		public ObjectExtrudeGizmoLookAndFeel3D ExtrudeGizmoLookAndFeel3D
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700087F RID: 2175
		// (get) Token: 0x06001931 RID: 6449 RVA: 0x0001A187 File Offset: 0x00018387
		public ObjectExtrudeGizmoHotkeys ExtrudeGozmoHotkeys
		{
			get
			{
				return null;
			}
		}

		// Token: 0x06001932 RID: 6450 RVA: 0x0001A18A File Offset: 0x0001838A
		public void SetTargetObjectCollection(IEnumerable<GameObject> targetObjectCollection)
		{
		}

		// Token: 0x06001933 RID: 6451 RVA: 0x0001A18C File Offset: 0x0001838C
		public void Initialize_SystemCall()
		{
		}

		// Token: 0x06001934 RID: 6452 RVA: 0x0001A18E File Offset: 0x0001838E
		public void SetGizmoUsable(int gizmoId, bool isUsable)
		{
		}

		// Token: 0x06001935 RID: 6453 RVA: 0x0001A190 File Offset: 0x00018390
		public Gizmo GetGizmoById(int gizmoId)
		{
			return null;
		}

		// Token: 0x06001936 RID: 6454 RVA: 0x0001A193 File Offset: 0x00018393
		public List<Gizmo> GetAllGizmos()
		{
			return null;
		}

		// Token: 0x06001937 RID: 6455 RVA: 0x0001A196 File Offset: 0x00018396
		public int GetGizmoId(Gizmo gizmo)
		{
			return 0;
		}

		// Token: 0x06001938 RID: 6456 RVA: 0x0001A199 File Offset: 0x00018399
		public ObjectTransformGizmo GetTransformGizmoById(int id)
		{
			return null;
		}

		// Token: 0x06001939 RID: 6457 RVA: 0x0001A19C File Offset: 0x0001839C
		public void SetTransformPivot(GizmoObjectTransformPivot transformPivot)
		{
		}

		// Token: 0x0600193A RID: 6458 RVA: 0x0001A19E File Offset: 0x0001839E
		public void SetTransformSpace(GizmoSpace transformSpace)
		{
		}

		// Token: 0x0600193B RID: 6459 RVA: 0x0001A1A0 File Offset: 0x000183A0
		public void SetWorkGizmo(int gizmoId)
		{
		}

		// Token: 0x0600193C RID: 6460 RVA: 0x0001A1A2 File Offset: 0x000183A2
		public void SetGizmosVisisble(bool visible)
		{
		}

		// Token: 0x0600193D RID: 6461 RVA: 0x0001A1A4 File Offset: 0x000183A4
		public void Update_SystemCall()
		{
		}

		// Token: 0x0600193E RID: 6462 RVA: 0x0001A1A6 File Offset: 0x000183A6
		private void OnObjectSelectionChanged(ObjectSelectionChangedEventArgs args)
		{
		}

		// Token: 0x0600193F RID: 6463 RVA: 0x0001A1A8 File Offset: 0x000183A8
		private void OnUndoRedo(IUndoRedoAction action)
		{
		}

		// Token: 0x06001940 RID: 6464 RVA: 0x0001A1AA File Offset: 0x000183AA
		private void OnGizmoPostEnabled(Gizmo gizmo)
		{
		}

		// Token: 0x06001941 RID: 6465 RVA: 0x0001A1AC File Offset: 0x000183AC
		private void OnTargetObjectGroupUpdated()
		{
		}

		// Token: 0x06001942 RID: 6466 RVA: 0x0001A1AE File Offset: 0x000183AE
		private void OnObjectSelectionManipSessionBegin(ObjectSelectionManipSession manipSession)
		{
		}

		// Token: 0x06001943 RID: 6467 RVA: 0x0001A1B0 File Offset: 0x000183B0
		private void OnObjectSelectionManipSessionEnd(ObjectSelectionManipSession manipSession)
		{
		}

		// Token: 0x06001944 RID: 6468 RVA: 0x0001A1B2 File Offset: 0x000183B2
		private void OnObjectSelectionRotated()
		{
		}

		// Token: 0x06001945 RID: 6469 RVA: 0x0001A1B4 File Offset: 0x000183B4
		private void OnObjectSelectionEnabled()
		{
		}

		// Token: 0x06001946 RID: 6470 RVA: 0x0001A1B6 File Offset: 0x000183B6
		private void OnObjectSelectionDisabled()
		{
		}

		// Token: 0x06001947 RID: 6471 RVA: 0x0001A1B8 File Offset: 0x000183B8
		private RTObjectSelectionGizmos.ObjectSelectionGizmo GetObjectSelectionGizmo(Gizmo gizmo)
		{
			return null;
		}

		// Token: 0x06001948 RID: 6472 RVA: 0x0001A1BB File Offset: 0x000183BB
		private RTObjectSelectionGizmos.ObjectSelectionGizmo GetObjectSelectionGizmo(int id)
		{
			return null;
		}

		// Token: 0x06001949 RID: 6473 RVA: 0x0001A1BE File Offset: 0x000183BE
		private bool IsGizmoRegistered(int gizmoId)
		{
			return false;
		}

		// Token: 0x0600194A RID: 6474 RVA: 0x0001A1C1 File Offset: 0x000183C1
		private bool IsGizmoRegistered(Gizmo gizmo)
		{
			return false;
		}

		// Token: 0x0600194B RID: 6475 RVA: 0x0001A1C4 File Offset: 0x000183C4
		private bool RegisterGizmo(int gizmoId, Gizmo gizmo)
		{
			return false;
		}

		// Token: 0x040008EC RID: 2284
		private EditorToolbar _mainToolbar;

		// Token: 0x040008ED RID: 2285
		private UniversalGizmoConfig _universalGizmoConfig;

		// Token: 0x040008EE RID: 2286
		private GizmoCollectionEnabledStateSnapshot _gizmosEnabledStateSnapshot;

		// Token: 0x040008EF RID: 2287
		private List<RTObjectSelectionGizmos.ObjectSelectionGizmo> _allGizmos;

		// Token: 0x040008F0 RID: 2288
		private List<ObjectTransformGizmo> _objectTransformGizmos;

		// Token: 0x040008F1 RID: 2289
		private int _workGizmoId;

		// Token: 0x040008F2 RID: 2290
		private RTObjectSelectionGizmos.ObjectSelectionGizmo _workGizmo;

		// Token: 0x040008F3 RID: 2291
		private bool _areGizmosVisible;

		// Token: 0x040008F4 RID: 2292
		private GizmoSpace _transformSpace;

		// Token: 0x040008F5 RID: 2293
		private GameObject _pivotObject;

		// Token: 0x040008F6 RID: 2294
		private IEnumerable<GameObject> _targetObjectCollection;

		// Token: 0x040008F7 RID: 2295
		private ObjectSelectionGizmosHotkeys _hotkeys;

		// Token: 0x040008F8 RID: 2296
		private MoveGizmoSettings2D _moveGizmoSettings2D;

		// Token: 0x040008F9 RID: 2297
		private MoveGizmoSettings3D _moveGizmoSettings3D;

		// Token: 0x040008FA RID: 2298
		private MoveGizmoLookAndFeel2D _moveGizmoLookAndFeel2D;

		// Token: 0x040008FB RID: 2299
		private MoveGizmoLookAndFeel3D _moveGizmoLookAndFeel3D;

		// Token: 0x040008FC RID: 2300
		private MoveGizmoHotkeys _moveGizmoHotkeys;

		// Token: 0x040008FD RID: 2301
		private ObjectTransformGizmoSettings _objectMoveGizmoSettings;

		// Token: 0x040008FE RID: 2302
		private RotationGizmoSettings3D _rotationGizmoSettings3D;

		// Token: 0x040008FF RID: 2303
		private RotationGizmoLookAndFeel3D _rotationGizmoLookAndFeel3D;

		// Token: 0x04000900 RID: 2304
		private RotationGizmoHotkeys _rotationGizmoHotkeys;

		// Token: 0x04000901 RID: 2305
		private ObjectTransformGizmoSettings _objectRotationGizmoSettings;

		// Token: 0x04000902 RID: 2306
		private ScaleGizmoSettings3D _scaleGizmoSettings3D;

		// Token: 0x04000903 RID: 2307
		private ScaleGizmoLookAndFeel3D _scaleGizmoLookAndFeel3D;

		// Token: 0x04000904 RID: 2308
		private ScaleGizmoHotkeys _scaleGizmoHotkeys;

		// Token: 0x04000905 RID: 2309
		private ObjectTransformGizmoSettings _objectScaleGizmoSettings;

		// Token: 0x04000906 RID: 2310
		private UniversalGizmoSettings2D _universalGizmoSettings2D;

		// Token: 0x04000907 RID: 2311
		private UniversalGizmoSettings3D _universalGizmoSettings3D;

		// Token: 0x04000908 RID: 2312
		private UniversalGizmoLookAndFeel2D _universalGizmoLookAndFeel2D;

		// Token: 0x04000909 RID: 2313
		private UniversalGizmoLookAndFeel3D _universalGizmoLookAndFeel3D;

		// Token: 0x0400090A RID: 2314
		private UniversalGizmoHotkeys _universalGizmoHotkeys;

		// Token: 0x0400090B RID: 2315
		private ObjectTransformGizmoSettings _objectUniversalGizmoSettings;

		// Token: 0x0400090C RID: 2316
		private BoxGizmoSettings3D _boxScaleGizmoSettings3D;

		// Token: 0x0400090D RID: 2317
		private BoxGizmoLookAndFeel3D _boxScaleGizmoLookAndFeel3D;

		// Token: 0x0400090E RID: 2318
		private BoxGizmoHotkeys _boxScaleGizmoHotkeys;

		// Token: 0x0400090F RID: 2319
		private ObjectExtrudeGizmoLookAndFeel3D _extrudeGizmoLookAndFeel3D;

		// Token: 0x04000910 RID: 2320
		private ObjectExtrudeGizmoHotkeys _extrudeGizmoHotkeys;

		// Token: 0x020003D3 RID: 979
		private class ObjectSelectionGizmo
		{
			// Token: 0x17000CB1 RID: 3249
			// (get) Token: 0x06002B3A RID: 11066 RVA: 0x0001D4B8 File Offset: 0x0001B6B8
			public int Id
			{
				get
				{
					return 0;
				}
			}

			// Token: 0x17000CB2 RID: 3250
			// (get) Token: 0x06002B3B RID: 11067 RVA: 0x0001D4BB File Offset: 0x0001B6BB
			public Gizmo Gizmo
			{
				get
				{
					return null;
				}
			}

			// Token: 0x17000CB3 RID: 3251
			// (get) Token: 0x06002B3C RID: 11068 RVA: 0x0001D4BE File Offset: 0x0001B6BE
			public BoxGizmo BoxScaleGizmo
			{
				get
				{
					return null;
				}
			}

			// Token: 0x17000CB4 RID: 3252
			// (get) Token: 0x06002B3D RID: 11069 RVA: 0x0001D4C1 File Offset: 0x0001B6C1
			public bool IsBoxScaleGizmo
			{
				get
				{
					return false;
				}
			}

			// Token: 0x17000CB5 RID: 3253
			// (get) Token: 0x06002B3E RID: 11070 RVA: 0x0001D4C4 File Offset: 0x0001B6C4
			public ObjectTransformGizmo TransformGizmo
			{
				get
				{
					return null;
				}
			}

			// Token: 0x17000CB6 RID: 3254
			// (get) Token: 0x06002B3F RID: 11071 RVA: 0x0001D4C7 File Offset: 0x0001B6C7
			public bool IsTransformGizmo
			{
				get
				{
					return false;
				}
			}

			// Token: 0x17000CB7 RID: 3255
			// (get) Token: 0x06002B40 RID: 11072 RVA: 0x0001D4CA File Offset: 0x0001B6CA
			public ObjectExtrudeGizmo ExtrudeGizmo
			{
				get
				{
					return null;
				}
			}

			// Token: 0x17000CB8 RID: 3256
			// (get) Token: 0x06002B41 RID: 11073 RVA: 0x0001D4CD File Offset: 0x0001B6CD
			public bool IsExtrudeGizmo
			{
				get
				{
					return false;
				}
			}

			// Token: 0x17000CB9 RID: 3257
			// (get) Token: 0x06002B42 RID: 11074 RVA: 0x0001D4D0 File Offset: 0x0001B6D0
			// (set) Token: 0x06002B43 RID: 11075 RVA: 0x0001D4D3 File Offset: 0x0001B6D3
			public bool IsUsable
			{
				get
				{
					return false;
				}
				set
				{
				}
			}

			// Token: 0x06002B44 RID: 11076 RVA: 0x0001D4D5 File Offset: 0x0001B6D5
			public ObjectSelectionGizmo(int id, Gizmo gizmo)
			{
			}

			// Token: 0x04001046 RID: 4166
			private int _id;

			// Token: 0x04001047 RID: 4167
			private Gizmo _gizmo;

			// Token: 0x04001048 RID: 4168
			private BoxGizmo _boxScaleGizmo;

			// Token: 0x04001049 RID: 4169
			private ObjectTransformGizmo _transformGizmo;

			// Token: 0x0400104A RID: 4170
			private ObjectExtrudeGizmo _extrudeGizmo;

			// Token: 0x0400104B RID: 4171
			private bool _isUsable;
		}

		// Token: 0x020003D4 RID: 980
		private sealed class <>c__DisplayClass101_0
		{
			// Token: 0x06002B46 RID: 11078 RVA: 0x0001D4E5 File Offset: 0x0001B6E5
			internal bool <GetGizmoId>b__0(RTObjectSelectionGizmos.ObjectSelectionGizmo item)
			{
				return false;
			}

			// Token: 0x0400104C RID: 4172
			public Gizmo gizmo;
		}

		// Token: 0x020003D5 RID: 981
		private sealed class <>c__DisplayClass102_0
		{
			// Token: 0x06002B48 RID: 11080 RVA: 0x0001D4F0 File Offset: 0x0001B6F0
			internal bool <GetTransformGizmoById>b__0(RTObjectSelectionGizmos.ObjectSelectionGizmo item)
			{
				return false;
			}

			// Token: 0x0400104D RID: 4173
			public int id;
		}

		// Token: 0x020003D6 RID: 982
		private sealed class <>c__DisplayClass119_0
		{
			// Token: 0x06002B4A RID: 11082 RVA: 0x0001D4FB File Offset: 0x0001B6FB
			internal bool <IsGizmoRegistered>b__0(RTObjectSelectionGizmos.ObjectSelectionGizmo item)
			{
				return false;
			}

			// Token: 0x0400104E RID: 4174
			public int gizmoId;
		}

		// Token: 0x020003D7 RID: 983
		private sealed class <>c__DisplayClass120_0
		{
			// Token: 0x06002B4C RID: 11084 RVA: 0x0001D506 File Offset: 0x0001B706
			internal bool <IsGizmoRegistered>b__0(RTObjectSelectionGizmos.ObjectSelectionGizmo item)
			{
				return false;
			}

			// Token: 0x0400104F RID: 4175
			public Gizmo gizmo;
		}
	}
}
