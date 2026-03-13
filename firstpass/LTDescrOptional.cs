using System;
using UnityEngine;

// Token: 0x02000017 RID: 23
public class LTDescrOptional
{
	// Token: 0x17000019 RID: 25
	// (get) Token: 0x060002E5 RID: 741 RVA: 0x0000C504 File Offset: 0x0000A704
	// (set) Token: 0x060002E6 RID: 742 RVA: 0x0000C50C File Offset: 0x0000A70C
	public Transform toTrans
	{
		get
		{
			return this.<toTrans>k__BackingField;
		}
		set
		{
			this.<toTrans>k__BackingField = value;
		}
	}

	// Token: 0x1700001A RID: 26
	// (get) Token: 0x060002E7 RID: 743 RVA: 0x0000C515 File Offset: 0x0000A715
	// (set) Token: 0x060002E8 RID: 744 RVA: 0x0000C51D File Offset: 0x0000A71D
	public Vector3 point
	{
		get
		{
			return this.<point>k__BackingField;
		}
		set
		{
			this.<point>k__BackingField = value;
		}
	}

	// Token: 0x1700001B RID: 27
	// (get) Token: 0x060002E9 RID: 745 RVA: 0x0000C526 File Offset: 0x0000A726
	// (set) Token: 0x060002EA RID: 746 RVA: 0x0000C52E File Offset: 0x0000A72E
	public Vector3 axis
	{
		get
		{
			return this.<axis>k__BackingField;
		}
		set
		{
			this.<axis>k__BackingField = value;
		}
	}

	// Token: 0x1700001C RID: 28
	// (get) Token: 0x060002EB RID: 747 RVA: 0x0000C537 File Offset: 0x0000A737
	// (set) Token: 0x060002EC RID: 748 RVA: 0x0000C53F File Offset: 0x0000A73F
	public float lastVal
	{
		get
		{
			return this.<lastVal>k__BackingField;
		}
		set
		{
			this.<lastVal>k__BackingField = value;
		}
	}

	// Token: 0x1700001D RID: 29
	// (get) Token: 0x060002ED RID: 749 RVA: 0x0000C548 File Offset: 0x0000A748
	// (set) Token: 0x060002EE RID: 750 RVA: 0x0000C550 File Offset: 0x0000A750
	public Quaternion origRotation
	{
		get
		{
			return this.<origRotation>k__BackingField;
		}
		set
		{
			this.<origRotation>k__BackingField = value;
		}
	}

	// Token: 0x1700001E RID: 30
	// (get) Token: 0x060002EF RID: 751 RVA: 0x0000C559 File Offset: 0x0000A759
	// (set) Token: 0x060002F0 RID: 752 RVA: 0x0000C561 File Offset: 0x0000A761
	public LTBezierPath path
	{
		get
		{
			return this.<path>k__BackingField;
		}
		set
		{
			this.<path>k__BackingField = value;
		}
	}

	// Token: 0x1700001F RID: 31
	// (get) Token: 0x060002F1 RID: 753 RVA: 0x0000C56A File Offset: 0x0000A76A
	// (set) Token: 0x060002F2 RID: 754 RVA: 0x0000C572 File Offset: 0x0000A772
	public LTSpline spline
	{
		get
		{
			return this.<spline>k__BackingField;
		}
		set
		{
			this.<spline>k__BackingField = value;
		}
	}

	// Token: 0x17000020 RID: 32
	// (get) Token: 0x060002F3 RID: 755 RVA: 0x0000C57B File Offset: 0x0000A77B
	// (set) Token: 0x060002F4 RID: 756 RVA: 0x0000C583 File Offset: 0x0000A783
	public LTRect ltRect
	{
		get
		{
			return this.<ltRect>k__BackingField;
		}
		set
		{
			this.<ltRect>k__BackingField = value;
		}
	}

	// Token: 0x17000021 RID: 33
	// (get) Token: 0x060002F5 RID: 757 RVA: 0x0000C58C File Offset: 0x0000A78C
	// (set) Token: 0x060002F6 RID: 758 RVA: 0x0000C594 File Offset: 0x0000A794
	public Action<float> onUpdateFloat
	{
		get
		{
			return this.<onUpdateFloat>k__BackingField;
		}
		set
		{
			this.<onUpdateFloat>k__BackingField = value;
		}
	}

	// Token: 0x17000022 RID: 34
	// (get) Token: 0x060002F7 RID: 759 RVA: 0x0000C59D File Offset: 0x0000A79D
	// (set) Token: 0x060002F8 RID: 760 RVA: 0x0000C5A5 File Offset: 0x0000A7A5
	public Action<float, float> onUpdateFloatRatio
	{
		get
		{
			return this.<onUpdateFloatRatio>k__BackingField;
		}
		set
		{
			this.<onUpdateFloatRatio>k__BackingField = value;
		}
	}

	// Token: 0x17000023 RID: 35
	// (get) Token: 0x060002F9 RID: 761 RVA: 0x0000C5AE File Offset: 0x0000A7AE
	// (set) Token: 0x060002FA RID: 762 RVA: 0x0000C5B6 File Offset: 0x0000A7B6
	public Action<float, object> onUpdateFloatObject
	{
		get
		{
			return this.<onUpdateFloatObject>k__BackingField;
		}
		set
		{
			this.<onUpdateFloatObject>k__BackingField = value;
		}
	}

	// Token: 0x17000024 RID: 36
	// (get) Token: 0x060002FB RID: 763 RVA: 0x0000C5BF File Offset: 0x0000A7BF
	// (set) Token: 0x060002FC RID: 764 RVA: 0x0000C5C7 File Offset: 0x0000A7C7
	public Action<Vector2> onUpdateVector2
	{
		get
		{
			return this.<onUpdateVector2>k__BackingField;
		}
		set
		{
			this.<onUpdateVector2>k__BackingField = value;
		}
	}

	// Token: 0x17000025 RID: 37
	// (get) Token: 0x060002FD RID: 765 RVA: 0x0000C5D0 File Offset: 0x0000A7D0
	// (set) Token: 0x060002FE RID: 766 RVA: 0x0000C5D8 File Offset: 0x0000A7D8
	public Action<Vector3> onUpdateVector3
	{
		get
		{
			return this.<onUpdateVector3>k__BackingField;
		}
		set
		{
			this.<onUpdateVector3>k__BackingField = value;
		}
	}

	// Token: 0x17000026 RID: 38
	// (get) Token: 0x060002FF RID: 767 RVA: 0x0000C5E1 File Offset: 0x0000A7E1
	// (set) Token: 0x06000300 RID: 768 RVA: 0x0000C5E9 File Offset: 0x0000A7E9
	public Action<Vector3, object> onUpdateVector3Object
	{
		get
		{
			return this.<onUpdateVector3Object>k__BackingField;
		}
		set
		{
			this.<onUpdateVector3Object>k__BackingField = value;
		}
	}

	// Token: 0x17000027 RID: 39
	// (get) Token: 0x06000301 RID: 769 RVA: 0x0000C5F2 File Offset: 0x0000A7F2
	// (set) Token: 0x06000302 RID: 770 RVA: 0x0000C5FA File Offset: 0x0000A7FA
	public Action<Color> onUpdateColor
	{
		get
		{
			return this.<onUpdateColor>k__BackingField;
		}
		set
		{
			this.<onUpdateColor>k__BackingField = value;
		}
	}

	// Token: 0x17000028 RID: 40
	// (get) Token: 0x06000303 RID: 771 RVA: 0x0000C603 File Offset: 0x0000A803
	// (set) Token: 0x06000304 RID: 772 RVA: 0x0000C60B File Offset: 0x0000A80B
	public Action<Color, object> onUpdateColorObject
	{
		get
		{
			return this.<onUpdateColorObject>k__BackingField;
		}
		set
		{
			this.<onUpdateColorObject>k__BackingField = value;
		}
	}

	// Token: 0x17000029 RID: 41
	// (get) Token: 0x06000305 RID: 773 RVA: 0x0000C614 File Offset: 0x0000A814
	// (set) Token: 0x06000306 RID: 774 RVA: 0x0000C61C File Offset: 0x0000A81C
	public Action onComplete
	{
		get
		{
			return this.<onComplete>k__BackingField;
		}
		set
		{
			this.<onComplete>k__BackingField = value;
		}
	}

	// Token: 0x1700002A RID: 42
	// (get) Token: 0x06000307 RID: 775 RVA: 0x0000C625 File Offset: 0x0000A825
	// (set) Token: 0x06000308 RID: 776 RVA: 0x0000C62D File Offset: 0x0000A82D
	public Action<object> onCompleteObject
	{
		get
		{
			return this.<onCompleteObject>k__BackingField;
		}
		set
		{
			this.<onCompleteObject>k__BackingField = value;
		}
	}

	// Token: 0x1700002B RID: 43
	// (get) Token: 0x06000309 RID: 777 RVA: 0x0000C636 File Offset: 0x0000A836
	// (set) Token: 0x0600030A RID: 778 RVA: 0x0000C63E File Offset: 0x0000A83E
	public object onCompleteParam
	{
		get
		{
			return this.<onCompleteParam>k__BackingField;
		}
		set
		{
			this.<onCompleteParam>k__BackingField = value;
		}
	}

	// Token: 0x1700002C RID: 44
	// (get) Token: 0x0600030B RID: 779 RVA: 0x0000C647 File Offset: 0x0000A847
	// (set) Token: 0x0600030C RID: 780 RVA: 0x0000C64F File Offset: 0x0000A84F
	public object onUpdateParam
	{
		get
		{
			return this.<onUpdateParam>k__BackingField;
		}
		set
		{
			this.<onUpdateParam>k__BackingField = value;
		}
	}

	// Token: 0x1700002D RID: 45
	// (get) Token: 0x0600030D RID: 781 RVA: 0x0000C658 File Offset: 0x0000A858
	// (set) Token: 0x0600030E RID: 782 RVA: 0x0000C660 File Offset: 0x0000A860
	public Action onStart
	{
		get
		{
			return this.<onStart>k__BackingField;
		}
		set
		{
			this.<onStart>k__BackingField = value;
		}
	}

	// Token: 0x0600030F RID: 783 RVA: 0x0000C669 File Offset: 0x0000A869
	public void reset()
	{
	}

	// Token: 0x06000310 RID: 784 RVA: 0x0000C66B File Offset: 0x0000A86B
	public void callOnUpdate(float val, float ratioPassed)
	{
	}

	// Token: 0x0400010F RID: 271
	private Transform <toTrans>k__BackingField;

	// Token: 0x04000110 RID: 272
	private Vector3 <point>k__BackingField;

	// Token: 0x04000111 RID: 273
	private Vector3 <axis>k__BackingField;

	// Token: 0x04000112 RID: 274
	private float <lastVal>k__BackingField;

	// Token: 0x04000113 RID: 275
	private Quaternion <origRotation>k__BackingField;

	// Token: 0x04000114 RID: 276
	private LTBezierPath <path>k__BackingField;

	// Token: 0x04000115 RID: 277
	private LTSpline <spline>k__BackingField;

	// Token: 0x04000116 RID: 278
	public AnimationCurve animationCurve;

	// Token: 0x04000117 RID: 279
	public int initFrameCount;

	// Token: 0x04000118 RID: 280
	public Color color;

	// Token: 0x04000119 RID: 281
	private LTRect <ltRect>k__BackingField;

	// Token: 0x0400011A RID: 282
	private Action<float> <onUpdateFloat>k__BackingField;

	// Token: 0x0400011B RID: 283
	private Action<float, float> <onUpdateFloatRatio>k__BackingField;

	// Token: 0x0400011C RID: 284
	private Action<float, object> <onUpdateFloatObject>k__BackingField;

	// Token: 0x0400011D RID: 285
	private Action<Vector2> <onUpdateVector2>k__BackingField;

	// Token: 0x0400011E RID: 286
	private Action<Vector3> <onUpdateVector3>k__BackingField;

	// Token: 0x0400011F RID: 287
	private Action<Vector3, object> <onUpdateVector3Object>k__BackingField;

	// Token: 0x04000120 RID: 288
	private Action<Color> <onUpdateColor>k__BackingField;

	// Token: 0x04000121 RID: 289
	private Action<Color, object> <onUpdateColorObject>k__BackingField;

	// Token: 0x04000122 RID: 290
	private Action <onComplete>k__BackingField;

	// Token: 0x04000123 RID: 291
	private Action<object> <onCompleteObject>k__BackingField;

	// Token: 0x04000124 RID: 292
	private object <onCompleteParam>k__BackingField;

	// Token: 0x04000125 RID: 293
	private object <onUpdateParam>k__BackingField;

	// Token: 0x04000126 RID: 294
	private Action <onStart>k__BackingField;
}
