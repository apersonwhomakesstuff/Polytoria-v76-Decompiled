using System;

namespace MoonSharp.Interpreter.Interop.LuaStateInterop
{
	// Token: 0x020000C9 RID: 201
	public class CharPtr
	{
		// Token: 0x17000158 RID: 344
		// (get) Token: 0x06000925 RID: 2341 RVA: 0x0000DFC9 File Offset: 0x0000C1C9
		// (set) Token: 0x06000926 RID: 2342 RVA: 0x0000DFCC File Offset: 0x0000C1CC
		public char Item
		{
			get
			{
				return '\0';
			}
			set
			{
			}
		}

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x06000927 RID: 2343 RVA: 0x0000DFCE File Offset: 0x0000C1CE
		// (set) Token: 0x06000928 RID: 2344 RVA: 0x0000DFD1 File Offset: 0x0000C1D1
		public char Item
		{
			get
			{
				return '\0';
			}
			set
			{
			}
		}

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x06000929 RID: 2345 RVA: 0x0000DFD3 File Offset: 0x0000C1D3
		// (set) Token: 0x0600092A RID: 2346 RVA: 0x0000DFD6 File Offset: 0x0000C1D6
		public char Item
		{
			get
			{
				return '\0';
			}
			set
			{
			}
		}

		// Token: 0x0600092B RID: 2347 RVA: 0x0000DFD8 File Offset: 0x0000C1D8
		public static implicit operator CharPtr(string str)
		{
			return null;
		}

		// Token: 0x0600092C RID: 2348 RVA: 0x0000DFDB File Offset: 0x0000C1DB
		public static implicit operator CharPtr(char[] chars)
		{
			return null;
		}

		// Token: 0x0600092D RID: 2349 RVA: 0x0000DFDE File Offset: 0x0000C1DE
		public static implicit operator CharPtr(byte[] bytes)
		{
			return null;
		}

		// Token: 0x0600092E RID: 2350 RVA: 0x0000DFE1 File Offset: 0x0000C1E1
		public CharPtr()
		{
		}

		// Token: 0x0600092F RID: 2351 RVA: 0x0000DFE9 File Offset: 0x0000C1E9
		public CharPtr(string str)
		{
		}

		// Token: 0x06000930 RID: 2352 RVA: 0x0000DFF1 File Offset: 0x0000C1F1
		public CharPtr(CharPtr ptr)
		{
		}

		// Token: 0x06000931 RID: 2353 RVA: 0x0000DFF9 File Offset: 0x0000C1F9
		public CharPtr(CharPtr ptr, int index)
		{
		}

		// Token: 0x06000932 RID: 2354 RVA: 0x0000E001 File Offset: 0x0000C201
		public CharPtr(char[] chars)
		{
		}

		// Token: 0x06000933 RID: 2355 RVA: 0x0000E009 File Offset: 0x0000C209
		public CharPtr(char[] chars, int index)
		{
		}

		// Token: 0x06000934 RID: 2356 RVA: 0x0000E011 File Offset: 0x0000C211
		public CharPtr(byte[] bytes)
		{
		}

		// Token: 0x06000935 RID: 2357 RVA: 0x0000E019 File Offset: 0x0000C219
		public CharPtr(IntPtr ptr)
		{
		}

		// Token: 0x06000936 RID: 2358 RVA: 0x0000E021 File Offset: 0x0000C221
		public static CharPtr operator +(CharPtr ptr, int offset)
		{
			return null;
		}

		// Token: 0x06000937 RID: 2359 RVA: 0x0000E024 File Offset: 0x0000C224
		public static CharPtr operator -(CharPtr ptr, int offset)
		{
			return null;
		}

		// Token: 0x06000938 RID: 2360 RVA: 0x0000E027 File Offset: 0x0000C227
		public static CharPtr operator +(CharPtr ptr, uint offset)
		{
			return null;
		}

		// Token: 0x06000939 RID: 2361 RVA: 0x0000E02A File Offset: 0x0000C22A
		public static CharPtr operator -(CharPtr ptr, uint offset)
		{
			return null;
		}

		// Token: 0x0600093A RID: 2362 RVA: 0x0000E02D File Offset: 0x0000C22D
		public void inc()
		{
		}

		// Token: 0x0600093B RID: 2363 RVA: 0x0000E02F File Offset: 0x0000C22F
		public void dec()
		{
		}

		// Token: 0x0600093C RID: 2364 RVA: 0x0000E031 File Offset: 0x0000C231
		public CharPtr next()
		{
			return null;
		}

		// Token: 0x0600093D RID: 2365 RVA: 0x0000E034 File Offset: 0x0000C234
		public CharPtr prev()
		{
			return null;
		}

		// Token: 0x0600093E RID: 2366 RVA: 0x0000E037 File Offset: 0x0000C237
		public CharPtr add(int ofs)
		{
			return null;
		}

		// Token: 0x0600093F RID: 2367 RVA: 0x0000E03A File Offset: 0x0000C23A
		public CharPtr sub(int ofs)
		{
			return null;
		}

		// Token: 0x06000940 RID: 2368 RVA: 0x0000E03D File Offset: 0x0000C23D
		public static bool operator ==(CharPtr ptr, char ch)
		{
			return false;
		}

		// Token: 0x06000941 RID: 2369 RVA: 0x0000E040 File Offset: 0x0000C240
		public static bool operator ==(char ch, CharPtr ptr)
		{
			return false;
		}

		// Token: 0x06000942 RID: 2370 RVA: 0x0000E043 File Offset: 0x0000C243
		public static bool operator !=(CharPtr ptr, char ch)
		{
			return false;
		}

		// Token: 0x06000943 RID: 2371 RVA: 0x0000E046 File Offset: 0x0000C246
		public static bool operator !=(char ch, CharPtr ptr)
		{
			return false;
		}

		// Token: 0x06000944 RID: 2372 RVA: 0x0000E049 File Offset: 0x0000C249
		public static CharPtr operator +(CharPtr ptr1, CharPtr ptr2)
		{
			return null;
		}

		// Token: 0x06000945 RID: 2373 RVA: 0x0000E04C File Offset: 0x0000C24C
		public static int operator -(CharPtr ptr1, CharPtr ptr2)
		{
			return 0;
		}

		// Token: 0x06000946 RID: 2374 RVA: 0x0000E04F File Offset: 0x0000C24F
		public static bool operator <(CharPtr ptr1, CharPtr ptr2)
		{
			return false;
		}

		// Token: 0x06000947 RID: 2375 RVA: 0x0000E052 File Offset: 0x0000C252
		public static bool operator <=(CharPtr ptr1, CharPtr ptr2)
		{
			return false;
		}

		// Token: 0x06000948 RID: 2376 RVA: 0x0000E055 File Offset: 0x0000C255
		public static bool operator >(CharPtr ptr1, CharPtr ptr2)
		{
			return false;
		}

		// Token: 0x06000949 RID: 2377 RVA: 0x0000E058 File Offset: 0x0000C258
		public static bool operator >=(CharPtr ptr1, CharPtr ptr2)
		{
			return false;
		}

		// Token: 0x0600094A RID: 2378 RVA: 0x0000E05B File Offset: 0x0000C25B
		public static bool operator ==(CharPtr ptr1, CharPtr ptr2)
		{
			return false;
		}

		// Token: 0x0600094B RID: 2379 RVA: 0x0000E05E File Offset: 0x0000C25E
		public static bool operator !=(CharPtr ptr1, CharPtr ptr2)
		{
			return false;
		}

		// Token: 0x0600094C RID: 2380 RVA: 0x0000E061 File Offset: 0x0000C261
		public override bool Equals(object o)
		{
			return false;
		}

		// Token: 0x0600094D RID: 2381 RVA: 0x0000E064 File Offset: 0x0000C264
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600094E RID: 2382 RVA: 0x0000E067 File Offset: 0x0000C267
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600094F RID: 2383 RVA: 0x0000E06A File Offset: 0x0000C26A
		public string ToString(int length)
		{
			return null;
		}

		// Token: 0x04000379 RID: 889
		public char[] chars;

		// Token: 0x0400037A RID: 890
		public int index;
	}
}
