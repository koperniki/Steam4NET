// This file is automatically generated.
using System;
using System.Text;
using System.Runtime.InteropServices;
using Steam4NET.Attributes;

namespace Steam4NET
{

	public enum EPackageStatus : int
	{
	};
	
	[InterfaceVersion("CLIENTBILLING_INTERFACE_VERSION001")]
	public interface IClientBilling
	{
		[VTableSlot(0)]
		bool PurchaseWithActivationCode(string pchActivationCode);
		[VTableSlot(1)]
		UInt32 GetLicensePackageID(UInt32 nLicenseIndex);
		[VTableSlot(2)]
		UInt32 GetLicenseTimeCreated(UInt32 nLicenseIndex);
		[VTableSlot(3)]
		UInt32 GetLicenseTimeNextProcess(UInt32 nLicenseIndex);
		[VTableSlot(4)]
		Int32 GetLicenseMinuteLimit(UInt32 nLicenseIndex);
		[VTableSlot(5)]
		Int32 GetLicenseMinutesUsed(UInt32 nLicenseIndex);
		[VTableSlot(6)]
		EPaymentMethod GetLicensePaymentMethod(UInt32 nLicenseIndex);
		[VTableSlot(7)]
		ELicenseFlags GetLicenseFlags(UInt32 nLicenseIndex);
		[VTableSlot(8)]
		string GetLicensePurchaseCountryCode(UInt32 nLicenseIndex);
		[VTableSlot(9)]
		Int32 GetLicenseTerritoryCode(UInt32 nLicenseIndex);
		[VTableSlot(10)]
		bool GetLicenseInfo(UInt32 nLicenseIndex, ref UInt32 pRTime32Created, ref UInt32 pRTime32NextProcess, ref Int32 pnMinuteLimit, ref Int32 pnMinutesUsed, ref EPaymentMethod pePaymentMethod, ref UInt32 punFlags, ref Int32 pnTerritoryCode, StringBuilder prgchPurchaseCountryCode);
		[VTableSlot(11)]
		UInt32 GetReceiptPackageID(UInt32 nReceiptIndex);
		[VTableSlot(12)]
		EPurchaseStatus GetReceiptStatus(UInt32 nReceiptIndex);
		[VTableSlot(13)]
		EPurchaseResultDetail GetReceiptResultDetail(UInt32 nReceiptIndex);
		[VTableSlot(14)]
		UInt32 GetReceiptTransTime(UInt32 nReceiptIndex);
		[VTableSlot(15)]
		UInt64 GetReceiptTransID(UInt32 nReceiptIndex);
		[VTableSlot(16)]
		EPaymentMethod GetReceiptPaymentMethod(UInt32 nReceiptIndex);
		[VTableSlot(17)]
		UInt32 GetReceiptBaseCost(UInt32 nReceiptIndex);
		[VTableSlot(18)]
		UInt32 GetReceiptTotalDiscount(UInt32 nReceiptIndex);
		[VTableSlot(19)]
		UInt32 GetReceiptTax(UInt32 nReceiptIndex);
		[VTableSlot(20)]
		UInt32 GetReceiptShipping(UInt32 nReceiptIndex);
		[VTableSlot(21)]
		ECurrencyCode GetReceiptCurrencyCode(UInt32 nReceiptIndex);
		[VTableSlot(22)]
		string GetReceiptCountryCode(UInt32 nReceiptIndex);
		[VTableSlot(23)]
		string GetReceiptErrorHeadline(UInt32 nReceiptIndex);
		[VTableSlot(24)]
		string GetReceiptErrorString(UInt32 nReceiptIndex);
		[VTableSlot(25)]
		string GetReceiptErrorLinkText(UInt32 nReceiptIndex);
		[VTableSlot(26)]
		string GetReceiptErrorLinkURL(UInt32 nReceiptIndex);
		[VTableSlot(27)]
		UInt32 GetReceiptErrorAppID(UInt32 nReceiptIndex);
		[VTableSlot(28)]
		UInt32 GetNumLicenses();
		[VTableSlot(29)]
		UInt32 GetNumReceipts();
		[VTableSlot(30)]
		bool PurchaseWithMachineID(UInt32 nPackageID, string pchCustomData);
		[VTableSlot(31)]
		bool GetReceiptCardInfo(UInt32 nReceiptIndex, ref ECreditCardType eCreditCardType, StringBuilder pchCardLast4Digits, StringBuilder pchCardHolderFirstName, StringBuilder pchCardHolderLastName, StringBuilder pchCardExpYear, StringBuilder pchCardExpMonth);
		[VTableSlot(32)]
		bool GetReceiptBillingAddress(UInt32 nReceiptIndex, StringBuilder pchFirstName, StringBuilder pchLastName, StringBuilder pchAddress1, StringBuilder pchAddress2, StringBuilder pchCity, StringBuilder pchPostcode, StringBuilder pchState, StringBuilder pchCountry, StringBuilder pchPhone);
		[VTableSlot(33)]
		UInt32 GetReceiptLineItemCount(UInt32 nReceiptIndex);
		[VTableSlot(34)]
		bool GetReceiptLineItemInfo(UInt32 nReceiptIndex, UInt32 nLineItemIndex, ref UInt32 nPackageID, ref UInt32 nBaseCost, ref UInt32 nDiscount, ref UInt32 nTax, ref UInt32 nShipping, ref ECurrencyCode eCurrencyCode, ref UInt32 punAppId, StringBuilder pchDescription, StringBuilder pchCouponInfoURL);
		[VTableSlot(35)]
		void EnableTestLicense(UInt32 unPackageID);
		[VTableSlot(36)]
		void DisableTestLicense(UInt32 unPackageID);
		[VTableSlot(37)]
		bool ActivateOEMTicket(string pchOEMLicenseFile);
		[VTableSlot(38)]
		UInt32 GetPackageName(UInt32 unPackageID, StringBuilder pchName, Int32 cubName);
		[VTableSlot(39)]
		bool GetPackageInfo(UInt32 unPackageID, ref UInt32 puNumAppIds, ref UInt32 puNumDepotIDs, ref EBillingType peBillingType, ref ELicenseType peLicenseType, ref EPackageStatus pePackageStatus, ref Int32 piCodeClass, ref Int32 piGameCode, ref Int32 piTerritoryCode, ref bool pbRequiresShipping, ref bool pbIsPreorder);
		[VTableSlot(40)]
		UInt32 GetAppsInPackage(UInt32 unPackageID, ref UInt32 puIds, UInt32 uMaxIds, bool bExcludeDepots, bool bExcludeApps);
		[VTableSlot(41)]
		UInt32 GetPackageExtendedInfo(UInt32 unPackageID, Byte[] pubData, Int32 cubData, bool bSharedKVSymbols);
		[VTableSlot(42)]
		UInt64 RequestFreeLicenseForApp(UInt32 unAppId);
	};
}
