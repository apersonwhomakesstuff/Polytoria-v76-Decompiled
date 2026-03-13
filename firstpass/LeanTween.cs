using System;
using UnityEngine;
using UnityEngine.SceneManagement;

// Token: 0x0200000D RID: 13
public class LeanTween : MonoBehaviour
{
	// Token: 0x06000043 RID: 67 RVA: 0x0000BD4C File Offset: 0x00009F4C
	public static void init()
	{
	}

	// Token: 0x17000005 RID: 5
	// (get) Token: 0x06000044 RID: 68 RVA: 0x0000BD4E File Offset: 0x00009F4E
	public static int maxSearch
	{
		get
		{
			return 0;
		}
	}

	// Token: 0x17000006 RID: 6
	// (get) Token: 0x06000045 RID: 69 RVA: 0x0000BD51 File Offset: 0x00009F51
	public static int maxSimulataneousTweens
	{
		get
		{
			return 0;
		}
	}

	// Token: 0x17000007 RID: 7
	// (get) Token: 0x06000046 RID: 70 RVA: 0x0000BD54 File Offset: 0x00009F54
	public static int tweensRunning
	{
		get
		{
			return 0;
		}
	}

	// Token: 0x06000047 RID: 71 RVA: 0x0000BD57 File Offset: 0x00009F57
	public static void init(int maxSimultaneousTweens)
	{
	}

	// Token: 0x06000048 RID: 72 RVA: 0x0000BD59 File Offset: 0x00009F59
	public static void init(int maxSimultaneousTweens, int maxSimultaneousSequences)
	{
	}

	// Token: 0x06000049 RID: 73 RVA: 0x0000BD5B File Offset: 0x00009F5B
	public static void reset()
	{
	}

	// Token: 0x0600004A RID: 74 RVA: 0x0000BD5D File Offset: 0x00009F5D
	public void Update()
	{
	}

	// Token: 0x0600004B RID: 75 RVA: 0x0000BD5F File Offset: 0x00009F5F
	private static void onLevelWasLoaded54(Scene scene, LoadSceneMode mode)
	{
	}

	// Token: 0x0600004C RID: 76 RVA: 0x0000BD61 File Offset: 0x00009F61
	private static void internalOnLevelWasLoaded(int lvl)
	{
	}

	// Token: 0x0600004D RID: 77 RVA: 0x0000BD63 File Offset: 0x00009F63
	public static void update()
	{
	}

	// Token: 0x0600004E RID: 78 RVA: 0x0000BD65 File Offset: 0x00009F65
	public static void removeTween(int i, int uniqueId)
	{
	}

	// Token: 0x0600004F RID: 79 RVA: 0x0000BD67 File Offset: 0x00009F67
	public static void removeTween(int i)
	{
	}

	// Token: 0x06000050 RID: 80 RVA: 0x0000BD69 File Offset: 0x00009F69
	public static Vector3[] add(Vector3[] a, Vector3 b)
	{
		return null;
	}

	// Token: 0x06000051 RID: 81 RVA: 0x0000BD6C File Offset: 0x00009F6C
	public static float closestRot(float from, float to)
	{
		return 0f;
	}

	// Token: 0x06000052 RID: 82 RVA: 0x0000BD73 File Offset: 0x00009F73
	public static void cancelAll()
	{
	}

	// Token: 0x06000053 RID: 83 RVA: 0x0000BD75 File Offset: 0x00009F75
	public static void cancelAll(bool callComplete)
	{
	}

	// Token: 0x06000054 RID: 84 RVA: 0x0000BD77 File Offset: 0x00009F77
	public static void cancel(GameObject gameObject)
	{
	}

	// Token: 0x06000055 RID: 85 RVA: 0x0000BD79 File Offset: 0x00009F79
	public static void cancel(GameObject gameObject, bool callOnComplete)
	{
	}

	// Token: 0x06000056 RID: 86 RVA: 0x0000BD7B File Offset: 0x00009F7B
	public static void cancel(RectTransform rect)
	{
	}

	// Token: 0x06000057 RID: 87 RVA: 0x0000BD7D File Offset: 0x00009F7D
	public static void cancel(GameObject gameObject, int uniqueId, bool callOnComplete = false)
	{
	}

	// Token: 0x06000058 RID: 88 RVA: 0x0000BD7F File Offset: 0x00009F7F
	public static void cancel(LTRect ltRect, int uniqueId)
	{
	}

	// Token: 0x06000059 RID: 89 RVA: 0x0000BD81 File Offset: 0x00009F81
	public static void cancel(int uniqueId)
	{
	}

	// Token: 0x0600005A RID: 90 RVA: 0x0000BD83 File Offset: 0x00009F83
	public static void cancel(int uniqueId, bool callOnComplete)
	{
	}

	// Token: 0x0600005B RID: 91 RVA: 0x0000BD85 File Offset: 0x00009F85
	public static LTDescr descr(int uniqueId)
	{
		return null;
	}

	// Token: 0x0600005C RID: 92 RVA: 0x0000BD88 File Offset: 0x00009F88
	public static LTDescr description(int uniqueId)
	{
		return null;
	}

	// Token: 0x0600005D RID: 93 RVA: 0x0000BD8B File Offset: 0x00009F8B
	public static LTDescr[] descriptions(GameObject gameObject = null)
	{
		return null;
	}

	// Token: 0x0600005E RID: 94 RVA: 0x0000BD8E File Offset: 0x00009F8E
	public static void pause(GameObject gameObject, int uniqueId)
	{
	}

	// Token: 0x0600005F RID: 95 RVA: 0x0000BD90 File Offset: 0x00009F90
	public static void pause(int uniqueId)
	{
	}

	// Token: 0x06000060 RID: 96 RVA: 0x0000BD92 File Offset: 0x00009F92
	public static void pause(GameObject gameObject)
	{
	}

	// Token: 0x06000061 RID: 97 RVA: 0x0000BD94 File Offset: 0x00009F94
	public static void pauseAll()
	{
	}

	// Token: 0x06000062 RID: 98 RVA: 0x0000BD96 File Offset: 0x00009F96
	public static void resumeAll()
	{
	}

	// Token: 0x06000063 RID: 99 RVA: 0x0000BD98 File Offset: 0x00009F98
	public static void resume(GameObject gameObject, int uniqueId)
	{
	}

	// Token: 0x06000064 RID: 100 RVA: 0x0000BD9A File Offset: 0x00009F9A
	public static void resume(int uniqueId)
	{
	}

	// Token: 0x06000065 RID: 101 RVA: 0x0000BD9C File Offset: 0x00009F9C
	public static void resume(GameObject gameObject)
	{
	}

	// Token: 0x06000066 RID: 102 RVA: 0x0000BD9E File Offset: 0x00009F9E
	public static bool isPaused(GameObject gameObject = null)
	{
		return false;
	}

	// Token: 0x06000067 RID: 103 RVA: 0x0000BDA1 File Offset: 0x00009FA1
	public static bool isPaused(RectTransform rect)
	{
		return false;
	}

	// Token: 0x06000068 RID: 104 RVA: 0x0000BDA4 File Offset: 0x00009FA4
	public static bool isPaused(int uniqueId)
	{
		return false;
	}

	// Token: 0x06000069 RID: 105 RVA: 0x0000BDA7 File Offset: 0x00009FA7
	public static bool isTweening(GameObject gameObject = null)
	{
		return false;
	}

	// Token: 0x0600006A RID: 106 RVA: 0x0000BDAA File Offset: 0x00009FAA
	public static bool isTweening(RectTransform rect)
	{
		return false;
	}

	// Token: 0x0600006B RID: 107 RVA: 0x0000BDAD File Offset: 0x00009FAD
	public static bool isTweening(int uniqueId)
	{
		return false;
	}

	// Token: 0x0600006C RID: 108 RVA: 0x0000BDB0 File Offset: 0x00009FB0
	public static bool isTweening(LTRect ltRect)
	{
		return false;
	}

	// Token: 0x0600006D RID: 109 RVA: 0x0000BDB3 File Offset: 0x00009FB3
	public static void drawBezierPath(Vector3 a, Vector3 b, Vector3 c, Vector3 d, float arrowSize = 0f, Transform arrowTransform = null)
	{
	}

	// Token: 0x0600006E RID: 110 RVA: 0x0000BDB5 File Offset: 0x00009FB5
	public static object logError(string error)
	{
		return null;
	}

	// Token: 0x0600006F RID: 111 RVA: 0x0000BDB8 File Offset: 0x00009FB8
	public static LTDescr options(LTDescr seed)
	{
		return null;
	}

	// Token: 0x06000070 RID: 112 RVA: 0x0000BDBB File Offset: 0x00009FBB
	public static LTDescr options()
	{
		return null;
	}

	// Token: 0x17000008 RID: 8
	// (get) Token: 0x06000071 RID: 113 RVA: 0x0000BDBE File Offset: 0x00009FBE
	public static GameObject tweenEmpty
	{
		get
		{
			return null;
		}
	}

	// Token: 0x06000072 RID: 114 RVA: 0x0000BDC1 File Offset: 0x00009FC1
	private static LTDescr pushNewTween(GameObject gameObject, Vector3 to, float time, LTDescr tween)
	{
		return null;
	}

	// Token: 0x06000073 RID: 115 RVA: 0x0000BDC4 File Offset: 0x00009FC4
	public static LTDescr play(RectTransform rectTransform, Sprite[] sprites)
	{
		return null;
	}

	// Token: 0x06000074 RID: 116 RVA: 0x0000BDC7 File Offset: 0x00009FC7
	public static LTSeq sequence(bool initSequence = true)
	{
		return null;
	}

	// Token: 0x06000075 RID: 117 RVA: 0x0000BDCA File Offset: 0x00009FCA
	public static LTDescr alpha(GameObject gameObject, float to, float time)
	{
		return null;
	}

	// Token: 0x06000076 RID: 118 RVA: 0x0000BDCD File Offset: 0x00009FCD
	public static LTDescr alpha(LTRect ltRect, float to, float time)
	{
		return null;
	}

	// Token: 0x06000077 RID: 119 RVA: 0x0000BDD0 File Offset: 0x00009FD0
	public static LTDescr textAlpha(RectTransform rectTransform, float to, float time)
	{
		return null;
	}

	// Token: 0x06000078 RID: 120 RVA: 0x0000BDD3 File Offset: 0x00009FD3
	public static LTDescr alphaText(RectTransform rectTransform, float to, float time)
	{
		return null;
	}

	// Token: 0x06000079 RID: 121 RVA: 0x0000BDD6 File Offset: 0x00009FD6
	public static LTDescr alphaCanvas(CanvasGroup canvasGroup, float to, float time)
	{
		return null;
	}

	// Token: 0x0600007A RID: 122 RVA: 0x0000BDD9 File Offset: 0x00009FD9
	public static LTDescr alphaVertex(GameObject gameObject, float to, float time)
	{
		return null;
	}

	// Token: 0x0600007B RID: 123 RVA: 0x0000BDDC File Offset: 0x00009FDC
	public static LTDescr color(GameObject gameObject, Color to, float time)
	{
		return null;
	}

	// Token: 0x0600007C RID: 124 RVA: 0x0000BDDF File Offset: 0x00009FDF
	public static LTDescr textColor(RectTransform rectTransform, Color to, float time)
	{
		return null;
	}

	// Token: 0x0600007D RID: 125 RVA: 0x0000BDE2 File Offset: 0x00009FE2
	public static LTDescr colorText(RectTransform rectTransform, Color to, float time)
	{
		return null;
	}

	// Token: 0x0600007E RID: 126 RVA: 0x0000BDE5 File Offset: 0x00009FE5
	public static LTDescr delayedCall(float delayTime, Action callback)
	{
		return null;
	}

	// Token: 0x0600007F RID: 127 RVA: 0x0000BDE8 File Offset: 0x00009FE8
	public static LTDescr delayedCall(float delayTime, Action<object> callback)
	{
		return null;
	}

	// Token: 0x06000080 RID: 128 RVA: 0x0000BDEB File Offset: 0x00009FEB
	public static LTDescr delayedCall(GameObject gameObject, float delayTime, Action callback)
	{
		return null;
	}

	// Token: 0x06000081 RID: 129 RVA: 0x0000BDEE File Offset: 0x00009FEE
	public static LTDescr delayedCall(GameObject gameObject, float delayTime, Action<object> callback)
	{
		return null;
	}

	// Token: 0x06000082 RID: 130 RVA: 0x0000BDF1 File Offset: 0x00009FF1
	public static LTDescr destroyAfter(LTRect rect, float delayTime)
	{
		return null;
	}

	// Token: 0x06000083 RID: 131 RVA: 0x0000BDF4 File Offset: 0x00009FF4
	public static LTDescr move(GameObject gameObject, Vector3 to, float time)
	{
		return null;
	}

	// Token: 0x06000084 RID: 132 RVA: 0x0000BDF7 File Offset: 0x00009FF7
	public static LTDescr move(GameObject gameObject, Vector2 to, float time)
	{
		return null;
	}

	// Token: 0x06000085 RID: 133 RVA: 0x0000BDFA File Offset: 0x00009FFA
	public static LTDescr move(GameObject gameObject, Vector3[] to, float time)
	{
		return null;
	}

	// Token: 0x06000086 RID: 134 RVA: 0x0000BDFD File Offset: 0x00009FFD
	public static LTDescr move(GameObject gameObject, LTBezierPath to, float time)
	{
		return null;
	}

	// Token: 0x06000087 RID: 135 RVA: 0x0000BE00 File Offset: 0x0000A000
	public static LTDescr move(GameObject gameObject, LTSpline to, float time)
	{
		return null;
	}

	// Token: 0x06000088 RID: 136 RVA: 0x0000BE03 File Offset: 0x0000A003
	public static LTDescr moveSpline(GameObject gameObject, Vector3[] to, float time)
	{
		return null;
	}

	// Token: 0x06000089 RID: 137 RVA: 0x0000BE06 File Offset: 0x0000A006
	public static LTDescr moveSpline(GameObject gameObject, LTSpline to, float time)
	{
		return null;
	}

	// Token: 0x0600008A RID: 138 RVA: 0x0000BE09 File Offset: 0x0000A009
	public static LTDescr moveSplineLocal(GameObject gameObject, Vector3[] to, float time)
	{
		return null;
	}

	// Token: 0x0600008B RID: 139 RVA: 0x0000BE0C File Offset: 0x0000A00C
	public static LTDescr move(LTRect ltRect, Vector2 to, float time)
	{
		return null;
	}

	// Token: 0x0600008C RID: 140 RVA: 0x0000BE0F File Offset: 0x0000A00F
	public static LTDescr moveMargin(LTRect ltRect, Vector2 to, float time)
	{
		return null;
	}

	// Token: 0x0600008D RID: 141 RVA: 0x0000BE12 File Offset: 0x0000A012
	public static LTDescr moveX(GameObject gameObject, float to, float time)
	{
		return null;
	}

	// Token: 0x0600008E RID: 142 RVA: 0x0000BE15 File Offset: 0x0000A015
	public static LTDescr moveY(GameObject gameObject, float to, float time)
	{
		return null;
	}

	// Token: 0x0600008F RID: 143 RVA: 0x0000BE18 File Offset: 0x0000A018
	public static LTDescr moveZ(GameObject gameObject, float to, float time)
	{
		return null;
	}

	// Token: 0x06000090 RID: 144 RVA: 0x0000BE1B File Offset: 0x0000A01B
	public static LTDescr moveLocal(GameObject gameObject, Vector3 to, float time)
	{
		return null;
	}

	// Token: 0x06000091 RID: 145 RVA: 0x0000BE1E File Offset: 0x0000A01E
	public static LTDescr moveLocal(GameObject gameObject, Vector3[] to, float time)
	{
		return null;
	}

	// Token: 0x06000092 RID: 146 RVA: 0x0000BE21 File Offset: 0x0000A021
	public static LTDescr moveLocalX(GameObject gameObject, float to, float time)
	{
		return null;
	}

	// Token: 0x06000093 RID: 147 RVA: 0x0000BE24 File Offset: 0x0000A024
	public static LTDescr moveLocalY(GameObject gameObject, float to, float time)
	{
		return null;
	}

	// Token: 0x06000094 RID: 148 RVA: 0x0000BE27 File Offset: 0x0000A027
	public static LTDescr moveLocalZ(GameObject gameObject, float to, float time)
	{
		return null;
	}

	// Token: 0x06000095 RID: 149 RVA: 0x0000BE2A File Offset: 0x0000A02A
	public static LTDescr moveLocal(GameObject gameObject, LTBezierPath to, float time)
	{
		return null;
	}

	// Token: 0x06000096 RID: 150 RVA: 0x0000BE2D File Offset: 0x0000A02D
	public static LTDescr moveLocal(GameObject gameObject, LTSpline to, float time)
	{
		return null;
	}

	// Token: 0x06000097 RID: 151 RVA: 0x0000BE30 File Offset: 0x0000A030
	public static LTDescr move(GameObject gameObject, Transform to, float time)
	{
		return null;
	}

	// Token: 0x06000098 RID: 152 RVA: 0x0000BE33 File Offset: 0x0000A033
	public static LTDescr rotate(GameObject gameObject, Vector3 to, float time)
	{
		return null;
	}

	// Token: 0x06000099 RID: 153 RVA: 0x0000BE36 File Offset: 0x0000A036
	public static LTDescr rotate(LTRect ltRect, float to, float time)
	{
		return null;
	}

	// Token: 0x0600009A RID: 154 RVA: 0x0000BE39 File Offset: 0x0000A039
	public static LTDescr rotateLocal(GameObject gameObject, Vector3 to, float time)
	{
		return null;
	}

	// Token: 0x0600009B RID: 155 RVA: 0x0000BE3C File Offset: 0x0000A03C
	public static LTDescr rotateX(GameObject gameObject, float to, float time)
	{
		return null;
	}

	// Token: 0x0600009C RID: 156 RVA: 0x0000BE3F File Offset: 0x0000A03F
	public static LTDescr rotateY(GameObject gameObject, float to, float time)
	{
		return null;
	}

	// Token: 0x0600009D RID: 157 RVA: 0x0000BE42 File Offset: 0x0000A042
	public static LTDescr rotateZ(GameObject gameObject, float to, float time)
	{
		return null;
	}

	// Token: 0x0600009E RID: 158 RVA: 0x0000BE45 File Offset: 0x0000A045
	public static LTDescr rotateAround(GameObject gameObject, Vector3 axis, float add, float time)
	{
		return null;
	}

	// Token: 0x0600009F RID: 159 RVA: 0x0000BE48 File Offset: 0x0000A048
	public static LTDescr rotateAroundLocal(GameObject gameObject, Vector3 axis, float add, float time)
	{
		return null;
	}

	// Token: 0x060000A0 RID: 160 RVA: 0x0000BE4B File Offset: 0x0000A04B
	public static LTDescr scale(GameObject gameObject, Vector3 to, float time)
	{
		return null;
	}

	// Token: 0x060000A1 RID: 161 RVA: 0x0000BE4E File Offset: 0x0000A04E
	public static LTDescr scale(LTRect ltRect, Vector2 to, float time)
	{
		return null;
	}

	// Token: 0x060000A2 RID: 162 RVA: 0x0000BE51 File Offset: 0x0000A051
	public static LTDescr scaleX(GameObject gameObject, float to, float time)
	{
		return null;
	}

	// Token: 0x060000A3 RID: 163 RVA: 0x0000BE54 File Offset: 0x0000A054
	public static LTDescr scaleY(GameObject gameObject, float to, float time)
	{
		return null;
	}

	// Token: 0x060000A4 RID: 164 RVA: 0x0000BE57 File Offset: 0x0000A057
	public static LTDescr scaleZ(GameObject gameObject, float to, float time)
	{
		return null;
	}

	// Token: 0x060000A5 RID: 165 RVA: 0x0000BE5A File Offset: 0x0000A05A
	public static LTDescr value(GameObject gameObject, float from, float to, float time)
	{
		return null;
	}

	// Token: 0x060000A6 RID: 166 RVA: 0x0000BE5D File Offset: 0x0000A05D
	public static LTDescr value(float from, float to, float time)
	{
		return null;
	}

	// Token: 0x060000A7 RID: 167 RVA: 0x0000BE60 File Offset: 0x0000A060
	public static LTDescr value(GameObject gameObject, Vector2 from, Vector2 to, float time)
	{
		return null;
	}

	// Token: 0x060000A8 RID: 168 RVA: 0x0000BE63 File Offset: 0x0000A063
	public static LTDescr value(GameObject gameObject, Vector3 from, Vector3 to, float time)
	{
		return null;
	}

	// Token: 0x060000A9 RID: 169 RVA: 0x0000BE66 File Offset: 0x0000A066
	public static LTDescr value(GameObject gameObject, Color from, Color to, float time)
	{
		return null;
	}

	// Token: 0x060000AA RID: 170 RVA: 0x0000BE69 File Offset: 0x0000A069
	public static LTDescr value(GameObject gameObject, Action<float> callOnUpdate, float from, float to, float time)
	{
		return null;
	}

	// Token: 0x060000AB RID: 171 RVA: 0x0000BE6C File Offset: 0x0000A06C
	public static LTDescr value(GameObject gameObject, Action<float, float> callOnUpdateRatio, float from, float to, float time)
	{
		return null;
	}

	// Token: 0x060000AC RID: 172 RVA: 0x0000BE6F File Offset: 0x0000A06F
	public static LTDescr value(GameObject gameObject, Action<Color> callOnUpdate, Color from, Color to, float time)
	{
		return null;
	}

	// Token: 0x060000AD RID: 173 RVA: 0x0000BE72 File Offset: 0x0000A072
	public static LTDescr value(GameObject gameObject, Action<Color, object> callOnUpdate, Color from, Color to, float time)
	{
		return null;
	}

	// Token: 0x060000AE RID: 174 RVA: 0x0000BE75 File Offset: 0x0000A075
	public static LTDescr value(GameObject gameObject, Action<Vector2> callOnUpdate, Vector2 from, Vector2 to, float time)
	{
		return null;
	}

	// Token: 0x060000AF RID: 175 RVA: 0x0000BE78 File Offset: 0x0000A078
	public static LTDescr value(GameObject gameObject, Action<Vector3> callOnUpdate, Vector3 from, Vector3 to, float time)
	{
		return null;
	}

	// Token: 0x060000B0 RID: 176 RVA: 0x0000BE7B File Offset: 0x0000A07B
	public static LTDescr value(GameObject gameObject, Action<float, object> callOnUpdate, float from, float to, float time)
	{
		return null;
	}

	// Token: 0x060000B1 RID: 177 RVA: 0x0000BE7E File Offset: 0x0000A07E
	public static LTDescr delayedSound(AudioClip audio, Vector3 pos, float volume)
	{
		return null;
	}

	// Token: 0x060000B2 RID: 178 RVA: 0x0000BE81 File Offset: 0x0000A081
	public static LTDescr delayedSound(GameObject gameObject, AudioClip audio, Vector3 pos, float volume)
	{
		return null;
	}

	// Token: 0x060000B3 RID: 179 RVA: 0x0000BE84 File Offset: 0x0000A084
	public static LTDescr move(RectTransform rectTrans, Vector3 to, float time)
	{
		return null;
	}

	// Token: 0x060000B4 RID: 180 RVA: 0x0000BE87 File Offset: 0x0000A087
	public static LTDescr moveX(RectTransform rectTrans, float to, float time)
	{
		return null;
	}

	// Token: 0x060000B5 RID: 181 RVA: 0x0000BE8A File Offset: 0x0000A08A
	public static LTDescr moveY(RectTransform rectTrans, float to, float time)
	{
		return null;
	}

	// Token: 0x060000B6 RID: 182 RVA: 0x0000BE8D File Offset: 0x0000A08D
	public static LTDescr moveZ(RectTransform rectTrans, float to, float time)
	{
		return null;
	}

	// Token: 0x060000B7 RID: 183 RVA: 0x0000BE90 File Offset: 0x0000A090
	public static LTDescr rotate(RectTransform rectTrans, float to, float time)
	{
		return null;
	}

	// Token: 0x060000B8 RID: 184 RVA: 0x0000BE93 File Offset: 0x0000A093
	public static LTDescr rotate(RectTransform rectTrans, Vector3 to, float time)
	{
		return null;
	}

	// Token: 0x060000B9 RID: 185 RVA: 0x0000BE96 File Offset: 0x0000A096
	public static LTDescr rotateAround(RectTransform rectTrans, Vector3 axis, float to, float time)
	{
		return null;
	}

	// Token: 0x060000BA RID: 186 RVA: 0x0000BE99 File Offset: 0x0000A099
	public static LTDescr rotateAroundLocal(RectTransform rectTrans, Vector3 axis, float to, float time)
	{
		return null;
	}

	// Token: 0x060000BB RID: 187 RVA: 0x0000BE9C File Offset: 0x0000A09C
	public static LTDescr scale(RectTransform rectTrans, Vector3 to, float time)
	{
		return null;
	}

	// Token: 0x060000BC RID: 188 RVA: 0x0000BE9F File Offset: 0x0000A09F
	public static LTDescr size(RectTransform rectTrans, Vector2 to, float time)
	{
		return null;
	}

	// Token: 0x060000BD RID: 189 RVA: 0x0000BEA2 File Offset: 0x0000A0A2
	public static LTDescr alpha(RectTransform rectTrans, float to, float time)
	{
		return null;
	}

	// Token: 0x060000BE RID: 190 RVA: 0x0000BEA5 File Offset: 0x0000A0A5
	public static LTDescr color(RectTransform rectTrans, Color to, float time)
	{
		return null;
	}

	// Token: 0x060000BF RID: 191 RVA: 0x0000BEA8 File Offset: 0x0000A0A8
	public static float tweenOnCurve(LTDescr tweenDescr, float ratioPassed)
	{
		return 0f;
	}

	// Token: 0x060000C0 RID: 192 RVA: 0x0000F998 File Offset: 0x0000DB98
	public static Vector3 tweenOnCurveVector(LTDescr tweenDescr, float ratioPassed)
	{
		return default(Vector3);
	}

	// Token: 0x060000C1 RID: 193 RVA: 0x0000BEAF File Offset: 0x0000A0AF
	public static float easeOutQuadOpt(float start, float diff, float ratioPassed)
	{
		return 0f;
	}

	// Token: 0x060000C2 RID: 194 RVA: 0x0000BEB6 File Offset: 0x0000A0B6
	public static float easeInQuadOpt(float start, float diff, float ratioPassed)
	{
		return 0f;
	}

	// Token: 0x060000C3 RID: 195 RVA: 0x0000BEBD File Offset: 0x0000A0BD
	public static float easeInOutQuadOpt(float start, float diff, float ratioPassed)
	{
		return 0f;
	}

	// Token: 0x060000C4 RID: 196 RVA: 0x0000F9B0 File Offset: 0x0000DBB0
	public static Vector3 easeInOutQuadOpt(Vector3 start, Vector3 diff, float ratioPassed)
	{
		return default(Vector3);
	}

	// Token: 0x060000C5 RID: 197 RVA: 0x0000BEC4 File Offset: 0x0000A0C4
	public static float linear(float start, float end, float val)
	{
		return 0f;
	}

	// Token: 0x060000C6 RID: 198 RVA: 0x0000BECB File Offset: 0x0000A0CB
	public static float clerp(float start, float end, float val)
	{
		return 0f;
	}

	// Token: 0x060000C7 RID: 199 RVA: 0x0000BED2 File Offset: 0x0000A0D2
	public static float spring(float start, float end, float val)
	{
		return 0f;
	}

	// Token: 0x060000C8 RID: 200 RVA: 0x0000BED9 File Offset: 0x0000A0D9
	public static float easeInQuad(float start, float end, float val)
	{
		return 0f;
	}

	// Token: 0x060000C9 RID: 201 RVA: 0x0000BEE0 File Offset: 0x0000A0E0
	public static float easeOutQuad(float start, float end, float val)
	{
		return 0f;
	}

	// Token: 0x060000CA RID: 202 RVA: 0x0000BEE7 File Offset: 0x0000A0E7
	public static float easeInOutQuad(float start, float end, float val)
	{
		return 0f;
	}

	// Token: 0x060000CB RID: 203 RVA: 0x0000BEEE File Offset: 0x0000A0EE
	public static float easeInOutQuadOpt2(float start, float diffBy2, float val, float val2)
	{
		return 0f;
	}

	// Token: 0x060000CC RID: 204 RVA: 0x0000BEF5 File Offset: 0x0000A0F5
	public static float easeInCubic(float start, float end, float val)
	{
		return 0f;
	}

	// Token: 0x060000CD RID: 205 RVA: 0x0000BEFC File Offset: 0x0000A0FC
	public static float easeOutCubic(float start, float end, float val)
	{
		return 0f;
	}

	// Token: 0x060000CE RID: 206 RVA: 0x0000BF03 File Offset: 0x0000A103
	public static float easeInOutCubic(float start, float end, float val)
	{
		return 0f;
	}

	// Token: 0x060000CF RID: 207 RVA: 0x0000BF0A File Offset: 0x0000A10A
	public static float easeInQuart(float start, float end, float val)
	{
		return 0f;
	}

	// Token: 0x060000D0 RID: 208 RVA: 0x0000BF11 File Offset: 0x0000A111
	public static float easeOutQuart(float start, float end, float val)
	{
		return 0f;
	}

	// Token: 0x060000D1 RID: 209 RVA: 0x0000BF18 File Offset: 0x0000A118
	public static float easeInOutQuart(float start, float end, float val)
	{
		return 0f;
	}

	// Token: 0x060000D2 RID: 210 RVA: 0x0000BF1F File Offset: 0x0000A11F
	public static float easeInQuint(float start, float end, float val)
	{
		return 0f;
	}

	// Token: 0x060000D3 RID: 211 RVA: 0x0000BF26 File Offset: 0x0000A126
	public static float easeOutQuint(float start, float end, float val)
	{
		return 0f;
	}

	// Token: 0x060000D4 RID: 212 RVA: 0x0000BF2D File Offset: 0x0000A12D
	public static float easeInOutQuint(float start, float end, float val)
	{
		return 0f;
	}

	// Token: 0x060000D5 RID: 213 RVA: 0x0000BF34 File Offset: 0x0000A134
	public static float easeInSine(float start, float end, float val)
	{
		return 0f;
	}

	// Token: 0x060000D6 RID: 214 RVA: 0x0000BF3B File Offset: 0x0000A13B
	public static float easeOutSine(float start, float end, float val)
	{
		return 0f;
	}

	// Token: 0x060000D7 RID: 215 RVA: 0x0000BF42 File Offset: 0x0000A142
	public static float easeInOutSine(float start, float end, float val)
	{
		return 0f;
	}

	// Token: 0x060000D8 RID: 216 RVA: 0x0000BF49 File Offset: 0x0000A149
	public static float easeInExpo(float start, float end, float val)
	{
		return 0f;
	}

	// Token: 0x060000D9 RID: 217 RVA: 0x0000BF50 File Offset: 0x0000A150
	public static float easeOutExpo(float start, float end, float val)
	{
		return 0f;
	}

	// Token: 0x060000DA RID: 218 RVA: 0x0000BF57 File Offset: 0x0000A157
	public static float easeInOutExpo(float start, float end, float val)
	{
		return 0f;
	}

	// Token: 0x060000DB RID: 219 RVA: 0x0000BF5E File Offset: 0x0000A15E
	public static float easeInCirc(float start, float end, float val)
	{
		return 0f;
	}

	// Token: 0x060000DC RID: 220 RVA: 0x0000BF65 File Offset: 0x0000A165
	public static float easeOutCirc(float start, float end, float val)
	{
		return 0f;
	}

	// Token: 0x060000DD RID: 221 RVA: 0x0000BF6C File Offset: 0x0000A16C
	public static float easeInOutCirc(float start, float end, float val)
	{
		return 0f;
	}

	// Token: 0x060000DE RID: 222 RVA: 0x0000BF73 File Offset: 0x0000A173
	public static float easeInBounce(float start, float end, float val)
	{
		return 0f;
	}

	// Token: 0x060000DF RID: 223 RVA: 0x0000BF7A File Offset: 0x0000A17A
	public static float easeOutBounce(float start, float end, float val)
	{
		return 0f;
	}

	// Token: 0x060000E0 RID: 224 RVA: 0x0000BF81 File Offset: 0x0000A181
	public static float easeInOutBounce(float start, float end, float val)
	{
		return 0f;
	}

	// Token: 0x060000E1 RID: 225 RVA: 0x0000BF88 File Offset: 0x0000A188
	public static float easeInBack(float start, float end, float val, float overshoot = 1f)
	{
		return 0f;
	}

	// Token: 0x060000E2 RID: 226 RVA: 0x0000BF8F File Offset: 0x0000A18F
	public static float easeOutBack(float start, float end, float val, float overshoot = 1f)
	{
		return 0f;
	}

	// Token: 0x060000E3 RID: 227 RVA: 0x0000BF96 File Offset: 0x0000A196
	public static float easeInOutBack(float start, float end, float val, float overshoot = 1f)
	{
		return 0f;
	}

	// Token: 0x060000E4 RID: 228 RVA: 0x0000BF9D File Offset: 0x0000A19D
	public static float easeInElastic(float start, float end, float val, float overshoot = 1f, float period = 0.3f)
	{
		return 0f;
	}

	// Token: 0x060000E5 RID: 229 RVA: 0x0000BFA4 File Offset: 0x0000A1A4
	public static float easeOutElastic(float start, float end, float val, float overshoot = 1f, float period = 0.3f)
	{
		return 0f;
	}

	// Token: 0x060000E6 RID: 230 RVA: 0x0000BFAB File Offset: 0x0000A1AB
	public static float easeInOutElastic(float start, float end, float val, float overshoot = 1f, float period = 0.3f)
	{
		return 0f;
	}

	// Token: 0x060000E7 RID: 231 RVA: 0x0000BFB2 File Offset: 0x0000A1B2
	public static LTDescr followDamp(Transform trans, Transform target, LeanProp prop, float smoothTime, float maxSpeed = -1f)
	{
		return null;
	}

	// Token: 0x060000E8 RID: 232 RVA: 0x0000BFB5 File Offset: 0x0000A1B5
	public static LTDescr followSpring(Transform trans, Transform target, LeanProp prop, float smoothTime, float maxSpeed = -1f, float friction = 2f, float accelRate = 0.5f)
	{
		return null;
	}

	// Token: 0x060000E9 RID: 233 RVA: 0x0000BFB8 File Offset: 0x0000A1B8
	public static LTDescr followBounceOut(Transform trans, Transform target, LeanProp prop, float smoothTime, float maxSpeed = -1f, float friction = 2f, float accelRate = 0.5f, float hitDamping = 0.9f)
	{
		return null;
	}

	// Token: 0x060000EA RID: 234 RVA: 0x0000BFBB File Offset: 0x0000A1BB
	public static LTDescr followLinear(Transform trans, Transform target, LeanProp prop, float moveSpeed)
	{
		return null;
	}

	// Token: 0x060000EB RID: 235 RVA: 0x0000BFBE File Offset: 0x0000A1BE
	public static void addListener(int eventId, Action<LTEvent> callback)
	{
	}

	// Token: 0x060000EC RID: 236 RVA: 0x0000BFC0 File Offset: 0x0000A1C0
	public static void addListener(GameObject caller, int eventId, Action<LTEvent> callback)
	{
	}

	// Token: 0x060000ED RID: 237 RVA: 0x0000BFC2 File Offset: 0x0000A1C2
	public static bool removeListener(int eventId, Action<LTEvent> callback)
	{
		return false;
	}

	// Token: 0x060000EE RID: 238 RVA: 0x0000BFC5 File Offset: 0x0000A1C5
	public static bool removeListener(int eventId)
	{
		return false;
	}

	// Token: 0x060000EF RID: 239 RVA: 0x0000BFC8 File Offset: 0x0000A1C8
	public static bool removeListener(GameObject caller, int eventId, Action<LTEvent> callback)
	{
		return false;
	}

	// Token: 0x060000F0 RID: 240 RVA: 0x0000BFCB File Offset: 0x0000A1CB
	public static void dispatchEvent(int eventId)
	{
	}

	// Token: 0x060000F1 RID: 241 RVA: 0x0000BFCD File Offset: 0x0000A1CD
	public static void dispatchEvent(int eventId, object data)
	{
	}

	// Token: 0x04000083 RID: 131
	public static bool throwErrors;

	// Token: 0x04000084 RID: 132
	public static float tau;

	// Token: 0x04000085 RID: 133
	public static float PI_DIV2;

	// Token: 0x04000086 RID: 134
	private static LTSeq[] sequences;

	// Token: 0x04000087 RID: 135
	private static LTDescr[] tweens;

	// Token: 0x04000088 RID: 136
	private static int[] tweensFinished;

	// Token: 0x04000089 RID: 137
	private static int[] tweensFinishedIds;

	// Token: 0x0400008A RID: 138
	private static LTDescr tween;

	// Token: 0x0400008B RID: 139
	private static int tweenMaxSearch;

	// Token: 0x0400008C RID: 140
	private static int maxTweens;

	// Token: 0x0400008D RID: 141
	private static int maxSequences;

	// Token: 0x0400008E RID: 142
	private static int frameRendered;

	// Token: 0x0400008F RID: 143
	private static GameObject _tweenEmpty;

	// Token: 0x04000090 RID: 144
	public static float dtEstimated;

	// Token: 0x04000091 RID: 145
	public static float dtManual;

	// Token: 0x04000092 RID: 146
	public static float dtActual;

	// Token: 0x04000093 RID: 147
	private static uint global_counter;

	// Token: 0x04000094 RID: 148
	private static int i;

	// Token: 0x04000095 RID: 149
	private static int j;

	// Token: 0x04000096 RID: 150
	private static int finishedCnt;

	// Token: 0x04000097 RID: 151
	public static AnimationCurve punch;

	// Token: 0x04000098 RID: 152
	public static AnimationCurve shake;

	// Token: 0x04000099 RID: 153
	private static int maxTweenReached;

	// Token: 0x0400009A RID: 154
	public static int startSearch;

	// Token: 0x0400009B RID: 155
	public static LTDescr d;

	// Token: 0x0400009C RID: 156
	private static Action<LTEvent>[] eventListeners;

	// Token: 0x0400009D RID: 157
	private static GameObject[] goListeners;

	// Token: 0x0400009E RID: 158
	private static int eventsMaxSearch;

	// Token: 0x0400009F RID: 159
	public static int EVENTS_MAX;

	// Token: 0x040000A0 RID: 160
	public static int LISTENERS_MAX;

	// Token: 0x040000A1 RID: 161
	private static int INIT_LISTENERS_MAX;

	// Token: 0x02000169 RID: 361
	private sealed class <>c__DisplayClass193_0
	{
		// Token: 0x06000E79 RID: 3705 RVA: 0x0000F1DD File Offset: 0x0000D3DD
		internal void <followDamp>b__0()
		{
		}

		// Token: 0x06000E7A RID: 3706 RVA: 0x0000F1DF File Offset: 0x0000D3DF
		internal void <followDamp>b__1()
		{
		}

		// Token: 0x06000E7B RID: 3707 RVA: 0x0000F1E1 File Offset: 0x0000D3E1
		internal void <followDamp>b__2()
		{
		}

		// Token: 0x06000E7C RID: 3708 RVA: 0x0000F1E3 File Offset: 0x0000D3E3
		internal void <followDamp>b__3()
		{
		}

		// Token: 0x06000E7D RID: 3709 RVA: 0x0000F1E5 File Offset: 0x0000D3E5
		internal void <followDamp>b__4()
		{
		}

		// Token: 0x06000E7E RID: 3710 RVA: 0x0000F1E7 File Offset: 0x0000D3E7
		internal void <followDamp>b__5()
		{
		}

		// Token: 0x06000E7F RID: 3711 RVA: 0x0000F1E9 File Offset: 0x0000D3E9
		internal void <followDamp>b__6()
		{
		}

		// Token: 0x06000E80 RID: 3712 RVA: 0x0000F1EB File Offset: 0x0000D3EB
		internal void <followDamp>b__7()
		{
		}

		// Token: 0x06000E81 RID: 3713 RVA: 0x0000F1ED File Offset: 0x0000D3ED
		internal void <followDamp>b__8()
		{
		}

		// Token: 0x06000E82 RID: 3714 RVA: 0x0000F1EF File Offset: 0x0000D3EF
		internal void <followDamp>b__9()
		{
		}

		// Token: 0x040005F7 RID: 1527
		public LTDescr d;

		// Token: 0x040005F8 RID: 1528
		public float smoothTime;

		// Token: 0x040005F9 RID: 1529
		public float maxSpeed;
	}

	// Token: 0x0200016A RID: 362
	private sealed class <>c__DisplayClass194_0
	{
		// Token: 0x06000E84 RID: 3716 RVA: 0x0000F1F9 File Offset: 0x0000D3F9
		internal void <followSpring>b__0()
		{
		}

		// Token: 0x06000E85 RID: 3717 RVA: 0x0000F1FB File Offset: 0x0000D3FB
		internal void <followSpring>b__1()
		{
		}

		// Token: 0x06000E86 RID: 3718 RVA: 0x0000F1FD File Offset: 0x0000D3FD
		internal void <followSpring>b__2()
		{
		}

		// Token: 0x06000E87 RID: 3719 RVA: 0x0000F1FF File Offset: 0x0000D3FF
		internal void <followSpring>b__3()
		{
		}

		// Token: 0x06000E88 RID: 3720 RVA: 0x0000F201 File Offset: 0x0000D401
		internal void <followSpring>b__4()
		{
		}

		// Token: 0x06000E89 RID: 3721 RVA: 0x0000F203 File Offset: 0x0000D403
		internal void <followSpring>b__5()
		{
		}

		// Token: 0x06000E8A RID: 3722 RVA: 0x0000F205 File Offset: 0x0000D405
		internal void <followSpring>b__6()
		{
		}

		// Token: 0x06000E8B RID: 3723 RVA: 0x0000F207 File Offset: 0x0000D407
		internal void <followSpring>b__7()
		{
		}

		// Token: 0x06000E8C RID: 3724 RVA: 0x0000F209 File Offset: 0x0000D409
		internal void <followSpring>b__8()
		{
		}

		// Token: 0x06000E8D RID: 3725 RVA: 0x0000F20B File Offset: 0x0000D40B
		internal void <followSpring>b__9()
		{
		}

		// Token: 0x040005FA RID: 1530
		public LTDescr d;

		// Token: 0x040005FB RID: 1531
		public float smoothTime;

		// Token: 0x040005FC RID: 1532
		public float maxSpeed;

		// Token: 0x040005FD RID: 1533
		public float friction;

		// Token: 0x040005FE RID: 1534
		public float accelRate;
	}

	// Token: 0x0200016B RID: 363
	private sealed class <>c__DisplayClass195_0
	{
		// Token: 0x06000E8F RID: 3727 RVA: 0x0000F215 File Offset: 0x0000D415
		internal void <followBounceOut>b__0()
		{
		}

		// Token: 0x06000E90 RID: 3728 RVA: 0x0000F217 File Offset: 0x0000D417
		internal void <followBounceOut>b__1()
		{
		}

		// Token: 0x06000E91 RID: 3729 RVA: 0x0000F219 File Offset: 0x0000D419
		internal void <followBounceOut>b__2()
		{
		}

		// Token: 0x06000E92 RID: 3730 RVA: 0x0000F21B File Offset: 0x0000D41B
		internal void <followBounceOut>b__3()
		{
		}

		// Token: 0x06000E93 RID: 3731 RVA: 0x0000F21D File Offset: 0x0000D41D
		internal void <followBounceOut>b__4()
		{
		}

		// Token: 0x06000E94 RID: 3732 RVA: 0x0000F21F File Offset: 0x0000D41F
		internal void <followBounceOut>b__5()
		{
		}

		// Token: 0x06000E95 RID: 3733 RVA: 0x0000F221 File Offset: 0x0000D421
		internal void <followBounceOut>b__6()
		{
		}

		// Token: 0x06000E96 RID: 3734 RVA: 0x0000F223 File Offset: 0x0000D423
		internal void <followBounceOut>b__7()
		{
		}

		// Token: 0x06000E97 RID: 3735 RVA: 0x0000F225 File Offset: 0x0000D425
		internal void <followBounceOut>b__8()
		{
		}

		// Token: 0x06000E98 RID: 3736 RVA: 0x0000F227 File Offset: 0x0000D427
		internal void <followBounceOut>b__9()
		{
		}

		// Token: 0x040005FF RID: 1535
		public LTDescr d;

		// Token: 0x04000600 RID: 1536
		public float smoothTime;

		// Token: 0x04000601 RID: 1537
		public float maxSpeed;

		// Token: 0x04000602 RID: 1538
		public float friction;

		// Token: 0x04000603 RID: 1539
		public float accelRate;

		// Token: 0x04000604 RID: 1540
		public float hitDamping;
	}

	// Token: 0x0200016C RID: 364
	private sealed class <>c__DisplayClass196_0
	{
		// Token: 0x06000E9A RID: 3738 RVA: 0x0000F231 File Offset: 0x0000D431
		internal void <followLinear>b__0()
		{
		}

		// Token: 0x06000E9B RID: 3739 RVA: 0x0000F233 File Offset: 0x0000D433
		internal void <followLinear>b__1()
		{
		}

		// Token: 0x06000E9C RID: 3740 RVA: 0x0000F235 File Offset: 0x0000D435
		internal void <followLinear>b__2()
		{
		}

		// Token: 0x06000E9D RID: 3741 RVA: 0x0000F237 File Offset: 0x0000D437
		internal void <followLinear>b__3()
		{
		}

		// Token: 0x06000E9E RID: 3742 RVA: 0x0000F239 File Offset: 0x0000D439
		internal void <followLinear>b__4()
		{
		}

		// Token: 0x06000E9F RID: 3743 RVA: 0x0000F23B File Offset: 0x0000D43B
		internal void <followLinear>b__5()
		{
		}

		// Token: 0x06000EA0 RID: 3744 RVA: 0x0000F23D File Offset: 0x0000D43D
		internal void <followLinear>b__6()
		{
		}

		// Token: 0x06000EA1 RID: 3745 RVA: 0x0000F23F File Offset: 0x0000D43F
		internal void <followLinear>b__7()
		{
		}

		// Token: 0x06000EA2 RID: 3746 RVA: 0x0000F241 File Offset: 0x0000D441
		internal void <followLinear>b__8()
		{
		}

		// Token: 0x06000EA3 RID: 3747 RVA: 0x0000F243 File Offset: 0x0000D443
		internal void <followLinear>b__9()
		{
		}

		// Token: 0x04000605 RID: 1541
		public LTDescr d;

		// Token: 0x04000606 RID: 1542
		public float moveSpeed;
	}
}
