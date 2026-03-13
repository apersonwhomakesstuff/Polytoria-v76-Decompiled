using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Polytoria.UI
{
	// Token: 0x02000251 RID: 593
	public class ChatWindow : MonoBehaviour
	{
		// Token: 0x1700088B RID: 2187
		// (get) Token: 0x060019CE RID: 6606 RVA: 0x0001A360 File Offset: 0x00018560
		// (set) Token: 0x060019CF RID: 6607 RVA: 0x0001A368 File Offset: 0x00018568
		public RectTransform ChatContainer
		{
			get
			{
				return this.<ChatContainer>k__BackingField;
			}
			private set
			{
				this.<ChatContainer>k__BackingField = value;
			}
		}

		// Token: 0x1700088C RID: 2188
		// (get) Token: 0x060019D0 RID: 6608 RVA: 0x0001A371 File Offset: 0x00018571
		public bool Focused
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700088D RID: 2189
		// (get) Token: 0x060019D1 RID: 6609 RVA: 0x00023C24 File Offset: 0x00021E24
		// (set) Token: 0x060019D2 RID: 6610 RVA: 0x0001A374 File Offset: 0x00018574
		public ChatWindowState state
		{
			get
			{
				return ChatWindowState.Inactive;
			}
			set
			{
			}
		}

		// Token: 0x060019D3 RID: 6611 RVA: 0x0001A376 File Offset: 0x00018576
		private void Awake()
		{
		}

		// Token: 0x060019D4 RID: 6612 RVA: 0x0001A378 File Offset: 0x00018578
		private void Start()
		{
		}

		// Token: 0x060019D5 RID: 6613 RVA: 0x0001A37A File Offset: 0x0001857A
		private IEnumerator inactiveFade(ChatMessageRef t)
		{
			return null;
		}

		// Token: 0x060019D6 RID: 6614 RVA: 0x0001A37D File Offset: 0x0001857D
		private void Update()
		{
		}

		// Token: 0x060019D7 RID: 6615 RVA: 0x0001A37F File Offset: 0x0001857F
		public void ToggleFocused()
		{
		}

		// Token: 0x060019D8 RID: 6616 RVA: 0x0001A381 File Offset: 0x00018581
		public void SetInactive()
		{
		}

		// Token: 0x060019D9 RID: 6617 RVA: 0x0001A383 File Offset: 0x00018583
		private void scrollViewToBottom()
		{
		}

		// Token: 0x060019DA RID: 6618 RVA: 0x0001A385 File Offset: 0x00018585
		public void PushChat(string username, string message, Color usernameColor)
		{
		}

		// Token: 0x060019DC RID: 6620 RVA: 0x0001A38F File Offset: 0x0001858F
		private void <set_state>b__22_0(float val)
		{
		}

		// Token: 0x060019DD RID: 6621 RVA: 0x0001A391 File Offset: 0x00018591
		private void <set_state>b__22_1(float val)
		{
		}

		// Token: 0x060019DE RID: 6622 RVA: 0x0001A393 File Offset: 0x00018593
		private void <set_state>b__22_2(float val)
		{
		}

		// Token: 0x060019DF RID: 6623 RVA: 0x0001A395 File Offset: 0x00018595
		private void <set_state>b__22_3()
		{
		}

		// Token: 0x060019E0 RID: 6624 RVA: 0x0001A397 File Offset: 0x00018597
		private void <set_state>b__22_4(float val)
		{
		}

		// Token: 0x060019E1 RID: 6625 RVA: 0x0001A399 File Offset: 0x00018599
		private void <set_state>b__22_5()
		{
		}

		// Token: 0x060019E2 RID: 6626 RVA: 0x0001A39B File Offset: 0x0001859B
		private void <set_state>b__22_6(float val)
		{
		}

		// Token: 0x060019E3 RID: 6627 RVA: 0x0001A39D File Offset: 0x0001859D
		private void <Start>b__25_0(string <p0>)
		{
		}

		// Token: 0x04000953 RID: 2387
		private Image darken;

		// Token: 0x04000954 RID: 2388
		private Scrollbar scrollbar;

		// Token: 0x04000955 RID: 2389
		private Image focusImage;

		// Token: 0x04000956 RID: 2390
		public TMP_InputField input;

		// Token: 0x04000957 RID: 2391
		private ScrollRect scrollRect;

		// Token: 0x04000958 RID: 2392
		public static ChatWindow instance;

		// Token: 0x04000959 RID: 2393
		private RectTransform chatMessage;

		// Token: 0x0400095A RID: 2394
		private RectTransform <ChatContainer>k__BackingField;

		// Token: 0x0400095B RID: 2395
		private ChatWindowState _state;

		// Token: 0x0400095C RID: 2396
		private RectTransform PopContainer;

		// Token: 0x0400095D RID: 2397
		public Vector2 normalSize;

		// Token: 0x0400095E RID: 2398
		public Vector2 focusedSize;

		// Token: 0x0400095F RID: 2399
		public float stateChangeCooldown;

		// Token: 0x04000960 RID: 2400
		public float StateChangeRateLimit;

		// Token: 0x04000961 RID: 2401
		public UICommandList commandList;

		// Token: 0x04000962 RID: 2402
		private List<ChatMessageRef> chatMessages;

		// Token: 0x04000963 RID: 2403
		private const float chatStayTime = 10f;

		// Token: 0x04000964 RID: 2404
		private const float chatFadeTime = 0.3f;

		// Token: 0x020003DC RID: 988
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06002B5A RID: 11098 RVA: 0x0001D544 File Offset: 0x0001B744
			internal void <inactiveFade>b__28_1()
			{
			}

			// Token: 0x04001058 RID: 4184
			public static readonly ChatWindow.<>c <>9;

			// Token: 0x04001059 RID: 4185
			public static Action <>9__28_1;
		}

		// Token: 0x020003DD RID: 989
		private sealed class <>c__DisplayClass28_0
		{
			// Token: 0x06002B5C RID: 11100 RVA: 0x0001D54E File Offset: 0x0001B74E
			internal void <inactiveFade>b__0(float val)
			{
			}

			// Token: 0x0400105A RID: 4186
			public TMP_Text txt;
		}

		// Token: 0x020003DE RID: 990
		private sealed class <inactiveFade>d__28 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06002B5D RID: 11101 RVA: 0x0001D550 File Offset: 0x0001B750
			public <inactiveFade>d__28(int <>1__state)
			{
			}

			// Token: 0x06002B5E RID: 11102 RVA: 0x0001D558 File Offset: 0x0001B758
			void IDisposable.Dispose()
			{
			}

			// Token: 0x06002B5F RID: 11103 RVA: 0x0001D55A File Offset: 0x0001B75A
			bool IEnumerator.MoveNext()
			{
				return false;
			}

			// Token: 0x17000CBA RID: 3258
			// (get) Token: 0x06002B60 RID: 11104 RVA: 0x0001D55D File Offset: 0x0001B75D
			object IEnumerator<object>.Current
			{
				get
				{
					return null;
				}
			}

			// Token: 0x06002B61 RID: 11105 RVA: 0x0001D560 File Offset: 0x0001B760
			void IEnumerator.Reset()
			{
			}

			// Token: 0x17000CBB RID: 3259
			// (get) Token: 0x06002B62 RID: 11106 RVA: 0x0001D562 File Offset: 0x0001B762
			object IEnumerator.Current
			{
				get
				{
					return null;
				}
			}

			// Token: 0x0400105B RID: 4187
			private int <>1__state;

			// Token: 0x0400105C RID: 4188
			private object <>2__current;

			// Token: 0x0400105D RID: 4189
			public ChatMessageRef t;

			// Token: 0x0400105E RID: 4190
			private ChatWindow.<>c__DisplayClass28_0 <>8__1;
		}
	}
}
