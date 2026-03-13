using System;
using Polytoria.Lua;
using UnityEngine;

namespace Polytoria.Datamodel.Proxies
{
	// Token: 0x020002F7 RID: 759
	public class SoundProxy : DynamicInstanceProxy
	{
		// Token: 0x06002669 RID: 9833 RVA: 0x0001C60E File Offset: 0x0001A80E
		public SoundProxy(Sound target) : base(null)
		{
		}

		// Token: 0x17000BCB RID: 3019
		// (get) Token: 0x0600266A RID: 9834 RVA: 0x0001C617 File Offset: 0x0001A817
		public bool Playing
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000BCC RID: 3020
		// (get) Token: 0x0600266B RID: 9835 RVA: 0x0001C61A File Offset: 0x0001A81A
		// (set) Token: 0x0600266C RID: 9836 RVA: 0x0001C61D File Offset: 0x0001A81D
		public int SoundID
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x17000BCD RID: 3021
		// (get) Token: 0x0600266D RID: 9837 RVA: 0x0001C61F File Offset: 0x0001A81F
		// (set) Token: 0x0600266E RID: 9838 RVA: 0x0001C626 File Offset: 0x0001A826
		public float Pitch
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17000BCE RID: 3022
		// (get) Token: 0x0600266F RID: 9839 RVA: 0x0001C628 File Offset: 0x0001A828
		public float Length
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000BCF RID: 3023
		// (get) Token: 0x06002670 RID: 9840 RVA: 0x00025D20 File Offset: 0x00023F20
		// (set) Token: 0x06002671 RID: 9841 RVA: 0x0001C62F File Offset: 0x0001A82F
		public new Vector3 Size
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		// Token: 0x17000BD0 RID: 3024
		// (get) Token: 0x06002672 RID: 9842 RVA: 0x00025D38 File Offset: 0x00023F38
		// (set) Token: 0x06002673 RID: 9843 RVA: 0x0001C631 File Offset: 0x0001A831
		public new Vector3 Rotation
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		// Token: 0x17000BD1 RID: 3025
		// (get) Token: 0x06002674 RID: 9844 RVA: 0x0001C633 File Offset: 0x0001A833
		// (set) Token: 0x06002675 RID: 9845 RVA: 0x0001C63A File Offset: 0x0001A83A
		public float Time
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17000BD2 RID: 3026
		// (get) Token: 0x06002676 RID: 9846 RVA: 0x0001C63C File Offset: 0x0001A83C
		// (set) Token: 0x06002677 RID: 9847 RVA: 0x0001C63F File Offset: 0x0001A83F
		public bool Autoplay
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x17000BD3 RID: 3027
		// (get) Token: 0x06002678 RID: 9848 RVA: 0x0001C641 File Offset: 0x0001A841
		// (set) Token: 0x06002679 RID: 9849 RVA: 0x0001C644 File Offset: 0x0001A844
		public bool Loop
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x17000BD4 RID: 3028
		// (get) Token: 0x0600267A RID: 9850 RVA: 0x0001C646 File Offset: 0x0001A846
		// (set) Token: 0x0600267B RID: 9851 RVA: 0x0001C649 File Offset: 0x0001A849
		public bool PlayInWorld
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x17000BD5 RID: 3029
		// (get) Token: 0x0600267C RID: 9852 RVA: 0x0001C64B File Offset: 0x0001A84B
		// (set) Token: 0x0600267D RID: 9853 RVA: 0x0001C652 File Offset: 0x0001A852
		public float Volume
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17000BD6 RID: 3030
		// (get) Token: 0x0600267E RID: 9854 RVA: 0x0001C654 File Offset: 0x0001A854
		// (set) Token: 0x0600267F RID: 9855 RVA: 0x0001C65B File Offset: 0x0001A85B
		public float MaxDistance
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17000BD7 RID: 3031
		// (get) Token: 0x06002680 RID: 9856 RVA: 0x0001C65D File Offset: 0x0001A85D
		public bool Loading
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06002681 RID: 9857 RVA: 0x0001C660 File Offset: 0x0001A860
		public void Play()
		{
		}

		// Token: 0x06002682 RID: 9858 RVA: 0x0001C662 File Offset: 0x0001A862
		public void PlayOneShot(float volume = 1f)
		{
		}

		// Token: 0x06002683 RID: 9859 RVA: 0x0001C664 File Offset: 0x0001A864
		public void Stop()
		{
		}

		// Token: 0x17000BD8 RID: 3032
		// (get) Token: 0x06002684 RID: 9860 RVA: 0x0001C666 File Offset: 0x0001A866
		public LuaEvent Loaded
		{
			get
			{
				return null;
			}
		}

		// Token: 0x04000D23 RID: 3363
		private readonly Sound sound;
	}
}
