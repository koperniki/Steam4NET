// This file is automatically generated.
using System;
using System.Text;
using System.Runtime.InteropServices;
using Steam4NET.Attributes;

namespace Steam4NET
{

	[InterfaceVersion("SteamMatchMaking008")]
	public interface ISteamMatchmaking008
	{
		[VTableSlot(0)]
		Int32 GetFavoriteGameCount();
		[VTableSlot(1)]
		bool GetFavoriteGame(Int32 iGame, ref UInt32 pnAppID, ref UInt32 pnIP, ref UInt16 pnConnPort, ref UInt16 pnQueryPort, ref UInt32 punFlags, ref UInt32 pRTime32LastPlayedOnServer);
		[VTableSlot(2)]
		Int32 AddFavoriteGame(UInt32 nAppID, UInt32 nIP, UInt16 nConnPort, UInt16 nQueryPort, UInt32 unFlags, UInt32 rTime32LastPlayedOnServer);
		[VTableSlot(3)]
		bool RemoveFavoriteGame(UInt32 nAppID, UInt32 nIP, UInt16 nConnPort, UInt16 nQueryPort, UInt32 unFlags);
		[VTableSlot(4)]
		UInt64 RequestLobbyList();
		[VTableSlot(5)]
		void AddRequestLobbyListStringFilter(string pchKeyToMatch, string pchValueToMatch, ELobbyComparison eComparisonType);
		[VTableSlot(6)]
		void AddRequestLobbyListNumericalFilter(string pchKeyToMatch, Int32 nValueToMatch, ELobbyComparison eComparisonType);
		[VTableSlot(7)]
		void AddRequestLobbyListNearValueFilter(string pchKeyToMatch, Int32 nValueToBeCloseTo);
		[VTableSlot(8)]
		void AddRequestLobbyListFilterSlotsAvailable(Int32 nSlotsAvailable);
		[VTableSlot(9)]
		void AddRequestLobbyListDistanceFilter(ELobbyDistanceFilter eLobbyDistanceFilter);
		[VTableSlot(10)]
		void AddRequestLobbyListResultCountFilter(Int32 cMaxResults);
		[VTableSlot(11)]
		CSteamID GetLobbyByIndex(Int32 iLobby);
		[VTableSlot(12)]
		UInt64 CreateLobby(ELobbyType eLobbyType, Int32 cMaxMembers);
		[VTableSlot(13)]
		UInt64 JoinLobby(CSteamID steamIDLobby);
		[VTableSlot(14)]
		void LeaveLobby(CSteamID steamIDLobby);
		[VTableSlot(15)]
		bool InviteUserToLobby(CSteamID steamIDLobby, CSteamID steamIDInvitee);
		[VTableSlot(16)]
		Int32 GetNumLobbyMembers(CSteamID steamIDLobby);
		[VTableSlot(17)]
		CSteamID GetLobbyMemberByIndex(CSteamID steamIDLobby, Int32 iMember);
		[VTableSlot(18)]
		string GetLobbyData(CSteamID steamIDLobby, string pchKey);
		[VTableSlot(19)]
		bool SetLobbyData(CSteamID steamIDLobby, string pchKey, string pchValue);
		[VTableSlot(20)]
		Int32 GetLobbyDataCount(CSteamID steamIDLobby);
		[VTableSlot(21)]
		bool GetLobbyDataByIndex(CSteamID steamIDLobby, Int32 iLobbyData, StringBuilder pchKey, Int32 cchKeyBufferSize, StringBuilder pchValue, Int32 cchValueBufferSize);
		[VTableSlot(22)]
		bool DeleteLobbyData(CSteamID steamIDLobby, string pchKey);
		[VTableSlot(23)]
		string GetLobbyMemberData(CSteamID steamIDLobby, CSteamID steamIDUser, string pchKey);
		[VTableSlot(24)]
		void SetLobbyMemberData(CSteamID steamIDLobby, string pchKey, string pchValue);
		[VTableSlot(25)]
		bool SendLobbyChatMsg(CSteamID steamIDLobby, Byte[] pvMsgBody, Int32 cubMsgBody);
		[VTableSlot(26)]
		Int32 GetLobbyChatEntry(CSteamID steamIDLobby, Int32 iChatID, ref CSteamID pSteamIDUser, Byte[] pvData, Int32 cubData, ref EChatEntryType peChatEntryType);
		[VTableSlot(27)]
		bool RequestLobbyData(CSteamID steamIDLobby);
		[VTableSlot(28)]
		void SetLobbyGameServer(CSteamID steamIDLobby, UInt32 unGameServerIP, UInt16 unGameServerPort, CSteamID steamIDGameServer);
		[VTableSlot(29)]
		bool GetLobbyGameServer(CSteamID steamIDLobby, ref UInt32 punGameServerIP, ref UInt16 punGameServerPort, ref CSteamID psteamIDGameServer);
		[VTableSlot(30)]
		bool SetLobbyMemberLimit(CSteamID steamIDLobby, Int32 cMaxMembers);
		[VTableSlot(31)]
		Int32 GetLobbyMemberLimit(CSteamID steamIDLobby);
		[VTableSlot(32)]
		bool SetLobbyType(CSteamID steamIDLobby, ELobbyType eLobbyType);
		[VTableSlot(33)]
		bool SetLobbyJoinable(CSteamID steamIDLobby, bool bLobbyJoinable);
		[VTableSlot(34)]
		CSteamID GetLobbyOwner(CSteamID steamIDLobby);
		[VTableSlot(35)]
		bool SetLobbyOwner(CSteamID steamIDLobby, CSteamID steamIDNewOwner);
	};
}
