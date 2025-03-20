using System;
using System.Collections.Generic;
using System.Text;
using BoilerSupplier.DataTransferObject;

namespace BoilerSupplier.Repository
{
    public interface IDataManger
    {
        #region L O G I N 
        //User CreateUser(User input);
        //User DeleteUser(User input);
        User FindUserByIdAndPassword(User input);

        User LoginCheck(User input);
        //User FindUserByName(User input);
        #endregion

        #region Lookup Data
        IList<Lookup> GetAllLookupMasterData(Lookup input);

        #endregion

        #region Lookup Value
        IList<LookupValue> GetAllLookupValueData(LookupValue input);

        #endregion

        #region File Schema
        IList<FileSchema> GetAllFileSchemaData(FileSchema input);

        #endregion
        #region SMS Format
        IList<SMSFormat> GetAllSMSFormatData(SMSFormat input);

        #endregion
        #region Main Menu
        IList<MainMenu> GetAllMainMenuData(MainMenu input);

        #endregion
        #region Sub Menu
        IList<SubMenu> GetAllSubMenuData(SubMenu input);

        #endregion
        #region Screen Role Mapping
        IList<ScreenRoleMapping> GetAllScreenRoleMappingData(ScreenRoleMapping input);

        #endregion
        #region Configration
        IList<ConfigrationMaster> GetAllConfigrationData(ConfigrationMaster input);

        #endregion
        #region Operational Configration
        IList<OperationalConfigrationMaster> GetAllOperationalConfigrationData(OperationalConfigrationMaster input);

        #endregion
        #region Module Assigment
        IList<Module_Assigment> GetAllModuleAssigmentData(Module_Assigment input);

        #endregion
        #region Module
        IList<ModuleMaster> GetAllModuleData(ModuleMaster input);

        #endregion

        #region Address
        IList<Address> GetAllAddressData(Address input);

        #endregion


        #region BankingDetails
        IList<BankingDetail> GetAllBankingDetailsData(BankingDetail input);

        #endregion

        #region DocumentEntityMapping
        IList<DocumentEntityMapping> GetAllDocumentEntityMappingData(DocumentEntityMapping input);

        #endregion


        #region Contact Details
        IList<ContactDetail> GetAllContactDetailsData(ContactDetail input);

        #endregion
        #region Email_Format
        IList<Email_Format> GetAllEmail_FormatData(Email_Format input);

        #endregion
        #region EmailFormatMapping
        IList<EmailFormatMapping> GetAllEmailFormatMappingData(EmailFormatMapping input);

        #endregion
        #region FileField
        IList<FileField> GetAllFileFieldData(FileField input);

        #endregion
        #region FileMaster
        IList<FileMaster> GetAllFileMasterData(FileMaster input);

        #endregion
        #region merchant
        IList<merchant> GetAllmerchantData(merchant input);

        #endregion
        #region SMSFormatMapping
        IList<SMSFormatMapping> GetAllSMSFormatMappingData(SMSFormatMapping input);

        #endregion
        #region Submerchant
        IList<Submerchant> GetAllSubmerchantData(Submerchant input);

        #endregion
        #region User
        IList<User> GetAllUserData(User input);

        #endregion
        #region vehiclemapping
        IList<vehiclemapping> GetAllvehiclemappingData(vehiclemapping input);

        #endregion

        #region Document
        IList<Document> GetAllDocumentData(Document input);

        #endregion
        //#region Entity
        //IList<EntityDocument> GetAllEntityData(EntityDocument input);
        //#endregion

        #region Vendor
        IList<Vendor> GetAllVendorData(Vendor input);
        #endregion

        #region Vendor Document
        IList<VendorDocument> GetAllVendorDocumentData(VendorDocument input);
        #endregion

        #region TTL USe
        IList<TTLUse> GetAllTTLUseData(TTLUse input);
        #endregion

        #region Vendor SAP
         IList<VendorSAP> GetAllVendorSAPData(VendorSAP input);
        VendorSAP GetVendorSAPData(VendorSAP input);
        #endregion

        #region Withholding Tax
        IList<WithholdingTax> GetAllWithholdingTaxData(WithholdingTax input);
       
        #endregion

        #region Withholding Tax Exe
        IList<WithholdingTaxExe> GetAllWithholdingTaxExeData(WithholdingTaxExe input);
      
        #endregion


        #region Quotation
        IList<Quotation> GetAllQuotationData(Quotation input);
        Quotation InsertQuotation(Quotation input);
        #endregion

        #region PurchaseOrder
        IList<PurchaseOrder> GetAllPurchaseOrderData(PurchaseOrder input);
        #endregion

        //#region Dispatch
        //IList<Dispatch> GetAllDispatchData(Dispatch input);
        //#endregion


        //vinod add 27-2-2021
        #region FileUpload
        IList<FileUpload> GetAllFileUploadData(FileUpload input);
        #endregion

        //vinod add 4-3-2021
        #region Tabfields
        IList<Tabfields> GetAllTabfieldsData(Tabfields input);
        #endregion

        #region Signup
        IList<Signup> GetAllSignupData(Signup input);
        Signup InsertSignupDetails(Signup input);
        #endregion

        //vinod add 9-3-2021
        #region Invite
        IList<Invite> GetAllInviteData(Invite input);

        
        #endregion


        //vinod add 6-4-2021
        #region Invoice
        IList<Invoice> GetAllInvoiceData(Invoice input);
        #endregion

        //vinod add 15-4-2021
        #region ReqStatus
        IList<ReqStatus> GetAllReqStatusData(ReqStatus input);
        #endregion

        #region VendorStatus
        IList<VendorStatus> GetAllVendorStatusData(VendorStatus input);
        #endregion

        //vinod add 28-4-2021
        #region References
        IList<References> GetAllReferencesData(References input);
        #endregion

        //vinod add 21-6-2021
        #region InviteSupplier
        IList<InviteSupplier> GetAllInviteSupplierData(InviteSupplier input);
        #endregion

        #region Remark
        IList<Remark> GetAllRemarkData(Remark input);
        #endregion

        //vinod add 22-6-2021
        #region InviteSupplier
        IList<SAPMaster> GetAllPurchasingOrganisationData(SAPMaster input);
        #endregion

        //vinod add 26-6-2021
        #region BankKey
        IList<SAPMaster> GetAllBankKeyData(SAPMaster input);
        #endregion

        #region ReconciliationAccount
        IList<SAPMaster> GetAllReconciliationAccountData(SAPMaster input);
        #endregion

        #region PaymentTerm
        IList<SAPMaster> GetAllPaymentTermData(SAPMaster input);
        #endregion
        #region PaymentMethods
        IList<SAPMaster> GetAllPaymentMethodsData(SAPMaster input);
        #endregion

        #region PaymentBlock
        IList<SAPMaster> GetAllPaymentBlockData(SAPMaster input);
        #endregion

        #region HouseBank
        IList<SAPMaster> GetAllHouseBankData(SAPMaster input);
        #endregion

        #region SchemaGroupVendor
        IList<SAPMaster> GetAllSchemaGroupVendorData(SAPMaster input);
        #endregion
        #region PaymentTermLevel
        IList<SAPMaster> GetAllPaymentTermLevelData(SAPMaster input);
        #endregion
        #region WithholdingTaxCountry
        IList<SAPMaster> GetAllWithholdingTaxCountryData(SAPMaster input);
        #endregion
        #region VendorClassificationGST
        IList<SAPMaster> GetAllVendorClassificationGSTData(SAPMaster input);
        #endregion
        #region WithholdingTaxType
        IList<SAPMaster> GetAllWithholdingTaxTypeData(SAPMaster input);
        #endregion
        #region WithholdingTaxCode
        IList<SAPMaster> GetAllWithholdingTaxCodeData(SAPMaster input);
        #endregion
        #region TypeOfRecipient
        IList<SAPMaster> GetAllTypeOfRecipientData(SAPMaster input);
        #endregion
        #region SectionCode
        IList<SAPMaster> GetAllSectionCodeData(SAPMaster input);
        #endregion
        #region WithholdingTaxTypeExemption
        IList<SAPMaster> GetAllWithholdingTaxTypeExemptionData(SAPMaster input);
        #endregion
        #region WithholdingTaxCodeExemption
        IList<SAPMaster> GetAllWithholdingTaxCodeExemptionData(SAPMaster input);
        #endregion
        #region Currency
        IList<SAPMaster> GetAllCurrencyData(SAPMaster input);
        #endregion

        #region NDAApp
        IList<NDAApp> GetAllNDAAppData(NDAApp input);
        #endregion
        //9-7-2021
        #region RemarkList
        IList<Remark> GetAllRemarkListData(Remark input);
        #endregion

        //10-7-2021
        #region Withholding Tax list
        IList<WithholdingTax> GetAllWithholdingTaxListData(WithholdingTax input);

        WithholdingTax GetWithholdingTaxListData(WithholdingTax input);
        #endregion

        #region Withholding Tax Exe list
        IList<WithholdingTaxExe> GetAllWithholdingTaxExeListData(WithholdingTaxExe input);

        WithholdingTaxExe GetWithholdingTaxExeListData(WithholdingTaxExe input);
        #endregion
        //12-7-2021
        #region WIP Application List
        IList<WIPApplicationList> GetAllWIPApplicationListData(WIPApplicationList input);
        #endregion

        //14-7-2021
        #region Register List
        IList<RegisterList> GetAllRegisterListData(RegisterList input);
        #endregion
        #region Supplier Details
        IList<Vendor> GetAllSupplierDetailsData(Vendor input);
        #endregion

        //23-7-2021
        #region ReferencesList
        IList<Vendor> GetAllReferencesListData(Vendor input);
        #endregion

        #region TTLUse Detail
        IList<TTLUse> GetAllTTLUseDetailData(TTLUse input);
        #endregion

        //vinod add 24-7-2021
        #region Invite List
        IList<Invite> GetAllInviteListData(Invite input);
        #endregion
        //vinod add 28-7-2021
        #region CheckPreferredUserID
        IList<Signup> CheckPreferredUserID(Signup input);
        #endregion
        //31-8-2021
        #region NDA
        IList<NDAApp> GetAllNDAData(NDAApp input);
        #endregion
        //1-9-2021
        #region Approval
        Approval InsertApproval(Approval input);
        #endregion

        #region SendBack
        SendBack InsertSendBack(SendBack input);
        #endregion

        //2-9-2021
        #region Register
        Register InsertRegister(Register input);
        #endregion

        //14-9-2021
        #region TabVerifyAccept

        TabVerifyAccept InsertTabVerifyAccept(TabVerifyAccept input);
        #endregion

        //14-9-2021
        #region TabVerifyAcceptDetails

        IList<TabVerifyAccept> GetTabVerifyAcceptDetails(TabVerifyAccept input);
        #endregion

        //27-9-2021
        #region EmpRoleType
        IList<EmpRole> GetEmpRoleTypeData(EmpRole input);
        #endregion

        //6-10-2021
        #region Remark Details
        IList<Remark> GetRemarkByFieldID(Remark input);
        #endregion
    }

}
