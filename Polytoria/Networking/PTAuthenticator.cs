using System;
using System.Collections;
using System.Collections.Generic;
using Mirror;
using SimpleJSON;
using UnityEngine.Networking;

namespace Polytoria.Networking
{
	public class PTAuthenticator : NetworkAuthenticator
	{
		public override void OnStartServer()
		{
		}

		public override void OnServerAuthenticate(NetworkConnectionToClient conn)
		{
		}

		public void OnAuthRequestMessage(NetworkConnectionToClient conn, PTAuthenticator.AuthRequestMessage msg)
		{
		}

		public IEnumerator ValidateToken(NetworkConnectionToClient conn, PTAuthenticator.AuthRequestMessage msg)
		{
			return null;
		}

		public IEnumerator DelayedDisconnect(NetworkConnectionToClient conn, float waitTime)
		{
			return null;
		}

		public override void OnStartClient()
		{
		}

		public override void OnClientAuthenticate()
		{
		}

		public void OnAuthResponseMessage(PTAuthenticator.AuthResponseMessage msg)
		{
		}

		public struct AuthRequestMessage : NetworkMessage
		{
			public string clientToken;
			public int localUserId;
		}

		public struct AuthResponseMessage : NetworkMessage
		{
			public byte code;
			public string message;
			public int instanceCount;
		}

		private sealed class <DelayedDisconnect>d__6 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int <>1__state;
			private object <>2__current;
			public float waitTime;
			public NetworkConnectionToClient conn;

			public <DelayedDisconnect>d__6(int <>1__state)
			{
			}

			void IDisposable.Dispose()
			{
			}

			bool IEnumerator.MoveNext()
			{
				return false;
			}

			object IEnumerator<object>.Current
			{
				get
				{
					return null;
				}
			}

			void IEnumerator.Reset()
			{
			}

			object IEnumerator.Current
			{
				get
				{
					return null;
				}
			}
		}

		private sealed class <ValidateToken>d__5 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int <>1__state;
			private object <>2__current;
			public PTAuthenticator.AuthRequestMessage msg;
			public NetworkConnectionToClient conn;
			public PTAuthenticator <>4__this;
			private PTAuthenticator.AuthResponseMessage <authResponseMessage>5__2;
			private bool <approve>5__3;
			private JSONNode <tokenData>5__4;
			private UnityWebRequest <uwr>5__5;

			public <ValidateToken>d__5(int <>1__state)
			{
			}

			void IDisposable.Dispose()
			{
			}

			bool IEnumerator.MoveNext()
			{
				return false;
			}

			private void <>m__Finally1()
			{
			}

			private void <>m__Finally2()
			{
			}

			object IEnumerator<object>.Current
			{
				get
				{
					return null;
				}
			}

			void IEnumerator.Reset()
			{
			}

			object IEnumerator.Current
			{
				get
				{
					return null;
				}
			}
		}
	}
}
