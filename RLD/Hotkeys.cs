using System;
using System.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000134 RID: 308
	[Serializable]
	public class Hotkeys
	{
		// Token: 0x1700053E RID: 1342
		// (get) Token: 0x06000FCA RID: 4042 RVA: 0x0001890B File Offset: 0x00016B0B
		public static List<KeyCode> AvailableKeys
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700053F RID: 1343
		// (get) Token: 0x06000FCB RID: 4043 RVA: 0x0001890E File Offset: 0x00016B0E
		public static List<string> AvailableKeyNames
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000540 RID: 1344
		// (get) Token: 0x06000FCC RID: 4044 RVA: 0x00018911 File Offset: 0x00016B11
		// (set) Token: 0x06000FCD RID: 4045 RVA: 0x00018914 File Offset: 0x00016B14
		public bool IsEnabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x17000541 RID: 1345
		// (get) Token: 0x06000FCE RID: 4046 RVA: 0x00018916 File Offset: 0x00016B16
		public string Name
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000542 RID: 1346
		// (get) Token: 0x06000FCF RID: 4047 RVA: 0x00020D24 File Offset: 0x0001EF24
		// (set) Token: 0x06000FD0 RID: 4048 RVA: 0x00018919 File Offset: 0x00016B19
		public KeyCode Key
		{
			get
			{
				return KeyCode.None;
			}
			set
			{
			}
		}

		// Token: 0x17000543 RID: 1347
		// (get) Token: 0x06000FD1 RID: 4049 RVA: 0x0001891B File Offset: 0x00016B1B
		// (set) Token: 0x06000FD2 RID: 4050 RVA: 0x0001891E File Offset: 0x00016B1E
		public bool LCtrl
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x17000544 RID: 1348
		// (get) Token: 0x06000FD3 RID: 4051 RVA: 0x00018920 File Offset: 0x00016B20
		// (set) Token: 0x06000FD4 RID: 4052 RVA: 0x00018923 File Offset: 0x00016B23
		public bool LCmd
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x17000545 RID: 1349
		// (get) Token: 0x06000FD5 RID: 4053 RVA: 0x00018925 File Offset: 0x00016B25
		// (set) Token: 0x06000FD6 RID: 4054 RVA: 0x00018928 File Offset: 0x00016B28
		public bool LAlt
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x17000546 RID: 1350
		// (get) Token: 0x06000FD7 RID: 4055 RVA: 0x0001892A File Offset: 0x00016B2A
		// (set) Token: 0x06000FD8 RID: 4056 RVA: 0x0001892D File Offset: 0x00016B2D
		public bool LShift
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x17000547 RID: 1351
		// (get) Token: 0x06000FD9 RID: 4057 RVA: 0x0001892F File Offset: 0x00016B2F
		// (set) Token: 0x06000FDA RID: 4058 RVA: 0x00018932 File Offset: 0x00016B32
		public bool LMouseButton
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x17000548 RID: 1352
		// (get) Token: 0x06000FDB RID: 4059 RVA: 0x00018934 File Offset: 0x00016B34
		// (set) Token: 0x06000FDC RID: 4060 RVA: 0x00018937 File Offset: 0x00016B37
		public bool RMouseButton
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x17000549 RID: 1353
		// (get) Token: 0x06000FDD RID: 4061 RVA: 0x00018939 File Offset: 0x00016B39
		// (set) Token: 0x06000FDE RID: 4062 RVA: 0x0001893C File Offset: 0x00016B3C
		public bool MMouseButton
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x1700054A RID: 1354
		// (get) Token: 0x06000FDF RID: 4063 RVA: 0x0001893E File Offset: 0x00016B3E
		// (set) Token: 0x06000FE0 RID: 4064 RVA: 0x00018941 File Offset: 0x00016B41
		public bool UseStrictMouseCheck
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x1700054B RID: 1355
		// (get) Token: 0x06000FE1 RID: 4065 RVA: 0x00018943 File Offset: 0x00016B43
		// (set) Token: 0x06000FE2 RID: 4066 RVA: 0x00018946 File Offset: 0x00016B46
		public bool UseStrictModifierCheck
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x06000FE3 RID: 4067 RVA: 0x00018948 File Offset: 0x00016B48
		public Hotkeys(string name)
		{
		}

		// Token: 0x06000FE4 RID: 4068 RVA: 0x00018950 File Offset: 0x00016B50
		public Hotkeys(string name, HotkeysStaticData staticData)
		{
		}

		// Token: 0x06000FE5 RID: 4069 RVA: 0x00018958 File Offset: 0x00016B58
		public static void EstablishPotentialOverlaps(List<Hotkeys> hotkeysCollection)
		{
		}

		// Token: 0x06000FE6 RID: 4070 RVA: 0x0001895A File Offset: 0x00016B5A
		public int GetNumModifiers()
		{
			return 0;
		}

		// Token: 0x06000FE7 RID: 4071 RVA: 0x0001895D File Offset: 0x00016B5D
		public int GetNumMouseButtons()
		{
			return 0;
		}

		// Token: 0x06000FE8 RID: 4072 RVA: 0x00018960 File Offset: 0x00016B60
		public List<MouseButton> GetAllUsedMouseButtons()
		{
			return null;
		}

		// Token: 0x06000FE9 RID: 4073 RVA: 0x00018963 File Offset: 0x00016B63
		public bool UsesMouseButtons(List<MouseButton> buttons)
		{
			return false;
		}

		// Token: 0x06000FEA RID: 4074 RVA: 0x00018966 File Offset: 0x00016B66
		public List<KeyCode> GetAllUsedModifiers()
		{
			return null;
		}

		// Token: 0x06000FEB RID: 4075 RVA: 0x00018969 File Offset: 0x00016B69
		public bool UsesModifiers(List<KeyCode> modifiers)
		{
			return false;
		}

		// Token: 0x06000FEC RID: 4076 RVA: 0x0001896C File Offset: 0x00016B6C
		public void AddPotentialOverlap(Hotkeys hotkeys)
		{
		}

		// Token: 0x06000FED RID: 4077 RVA: 0x0001896E File Offset: 0x00016B6E
		public bool ContainsPotentialOverlap(Hotkeys hotkeys)
		{
			return false;
		}

		// Token: 0x06000FEE RID: 4078 RVA: 0x00018971 File Offset: 0x00016B71
		public bool IsOverlappedBy(Hotkeys hotkeys)
		{
			return false;
		}

		// Token: 0x06000FEF RID: 4079 RVA: 0x00018974 File Offset: 0x00016B74
		public bool IsActive(bool checkForOverlaps = true)
		{
			return false;
		}

		// Token: 0x06000FF0 RID: 4080 RVA: 0x00018977 File Offset: 0x00016B77
		public bool IsActiveInFrame(bool checkForOverlaps = true)
		{
			return false;
		}

		// Token: 0x06000FF1 RID: 4081 RVA: 0x0001897A File Offset: 0x00016B7A
		public bool HasNoKeys()
		{
			return false;
		}

		// Token: 0x06000FF2 RID: 4082 RVA: 0x0001897D File Offset: 0x00016B7D
		public bool HasNoModifiers()
		{
			return false;
		}

		// Token: 0x06000FF3 RID: 4083 RVA: 0x00018980 File Offset: 0x00016B80
		public bool HasNoMouseButtons()
		{
			return false;
		}

		// Token: 0x06000FF4 RID: 4084 RVA: 0x00018983 File Offset: 0x00016B83
		public bool IsEmpty()
		{
			return false;
		}

		// Token: 0x06000FF5 RID: 4085 RVA: 0x00018986 File Offset: 0x00016B86
		private bool IsAnyModifierKeyPressed()
		{
			return false;
		}

		// Token: 0x06000FF6 RID: 4086 RVA: 0x00018989 File Offset: 0x00016B89
		private bool IsAnyMouseButtonPressed()
		{
			return false;
		}

		// Token: 0x0400056B RID: 1387
		private static List<KeyCode> _availableKeys;

		// Token: 0x0400056C RID: 1388
		private static List<string> _availableKeyNames;

		// Token: 0x0400056D RID: 1389
		private const int _maxNumberOfKeys = 2;

		// Token: 0x0400056E RID: 1390
		private bool _isEnabled;

		// Token: 0x0400056F RID: 1391
		private KeyCode _key;

		// Token: 0x04000570 RID: 1392
		private bool _lCtrl;

		// Token: 0x04000571 RID: 1393
		private bool _lCmd;

		// Token: 0x04000572 RID: 1394
		private bool _lAlt;

		// Token: 0x04000573 RID: 1395
		private bool _lShift;

		// Token: 0x04000574 RID: 1396
		private bool _useStrictModifierCheck;

		// Token: 0x04000575 RID: 1397
		private bool _lMouseBtn;

		// Token: 0x04000576 RID: 1398
		private bool _rMouseBtn;

		// Token: 0x04000577 RID: 1399
		private bool _mMouseBtn;

		// Token: 0x04000578 RID: 1400
		private bool _useStrictMouseCheck;

		// Token: 0x04000579 RID: 1401
		private string _name;

		// Token: 0x0400057A RID: 1402
		[NonSerialized]
		private List<Hotkeys> _potentialOverlaps;

		// Token: 0x0400057B RID: 1403
		private HotkeysStaticData _staticData;
	}
}
