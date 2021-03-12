/* Copyright (c) 2020 ExT (V.Sigalkin) */

using UnityEngine;

namespace extOSC.Examples
{
	public class ScriptingExample : MonoBehaviour
	{
		#region Private Vars

		private OSCTransmitter _transmitter;

		private OSCReceiver _receiver;

		private const string _oscAddress = "/1/unityTest/"; // Also, you cam use mask in address: /example/*/

		#endregion

		#region Unity Methods

		protected virtual void Start()
		{
			// Creating a transmitter.
			_transmitter = gameObject.AddComponent<OSCTransmitter>();

			// Set remote host address.
			_transmitter.RemoteHost = "192.168.178.71";

			// Set remote port;
			_transmitter.RemotePort = 9002;


			// Creating a receiver.
			_receiver = gameObject.AddComponent<OSCReceiver>();

			// Set local port.
			_receiver.LocalPort = 7001;

			// Bind "MessageReceived" method to special address.
			_receiver.Bind(_oscAddress, MessageReceived);
		}

		protected virtual void Update()
		{
			if (_transmitter == null) return;

			// Create message
			var message = new OSCMessage(_oscAddress);
			message.AddValue(OSCValue.String("Impulse sent!"));
			message.AddValue(OSCValue.Impulse());

			// Send message
			_transmitter.Send(message);
		}

		#endregion

		#region Protected Methods

		protected void MessageReceived(OSCMessage message)
		{
			Debug.Log(message);
		}

		#endregion
	}
}