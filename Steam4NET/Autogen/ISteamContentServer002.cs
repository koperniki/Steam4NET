// This file is automatically generated.
using System;
using System.Text;
using System.Runtime.InteropServices;
using Steam4NET.Attributes;

namespace Steam4NET
{

	[InterfaceVersion("SteamContentServer002")]
	public interface ISteamContentServer002
	{
		[VTableSlot(0)]
		bool LogOn(UInt32 uContentServerID);
		[VTableSlot(1)]
		bool LogOff();
		[VTableSlot(2)]
		bool BLoggedOn();
		[VTableSlot(3)]
		void SendClientContentAuthRequest(CSteamID steamID, UInt32 uContentID, UInt64 ulSessionToken, bool bTokenPresent);
		[VTableSlot(4)]
		bool BCheckTicket(CSteamID steamID, UInt32 uContentID, Byte[] pvTicketData, UInt32 cubTicketLength);
	};
}
