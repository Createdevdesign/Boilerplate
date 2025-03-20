using BoilerSupplier.DataTransferObject;
using System;
using System.Collections.Generic;
using System.Text;

namespace BoilerSupplier.Repository
{
    public class DataManger : IDataManger
    {
        #region L O G I N
        private LoginRepository loginRepository;
        private LoginRepository LoginRepositoryInstance
        {
            get { return loginRepository ?? new LoginRepository(); }
        }

        public User FindUserByIdAndPassword(User input)
        {
            return LoginRepositoryInstance.FindUserByIdAndPassword(input);
        }


        public User LoginCheck(User input)
        {
            return LoginRepositoryInstance.LoginCheck(input);
        }
        #endregion

        #region L O O K U P   D A T A
        private LookupRepository lookupRepository;

        private LookupRepository LookupRepositoryInstance
        {
            get
            {
                if (lookupRepository == null)
                {
                    lookupRepository = new LookupRepository();
                }
                return lookupRepository;
            }
        }

        public IList<Lookup> GetAllLookupMasterData(Lookup input)
        {
            return LookupRepositoryInstance.GetAllLookupMasterData(input);
        }
        #endregion

        #region Lookup Value

        private LookupValueRepository lookupValueRepository;

        private LookupValueRepository LookupValueRepositoryInstance
        {
            get
            {
                if (lookupValueRepository == null)
                {
                    lookupValueRepository = new LookupValueRepository();
                }
                return lookupValueRepository;
            }
        }

        public IList<LookupValue> GetAllLookupValueData(LookupValue input)
        {
            return LookupValueRepositoryInstance.GetAllLookupValueData(input);
        }
        #endregion

        #region File Schema


        private FileSchemaRepository fileSchemaRepository;

        private FileSchemaRepository FileSchemaRepositoryInstance
        {
            get
            {
                if (fileSchemaRepository == null)
                {
                    fileSchemaRepository = new FileSchemaRepository();
                }
                return fileSchemaRepository;
            }
        }

        public IList<FileSchema> GetAllFileSchemaData(FileSchema input)
        {
            return FileSchemaRepositoryInstance.GetAllFileSchemaData(input);
        }
        #endregion

        #region SMS Format

        private SMSFormatRepository smsFormatRepository;

        private SMSFormatRepository SMSFormatRepositoryInstance
        {
            get
            {
                if (smsFormatRepository == null)
                {
                    smsFormatRepository = new SMSFormatRepository();
                }
                return smsFormatRepository;
            }
        }

        public IList<SMSFormat> GetAllSMSFormatData(SMSFormat input)
        {
            return SMSFormatRepositoryInstance.GetAllSMSFormatData(input);
        }
        #endregion

        #region Main Menu

        private MainMenuRepository mainMenuRepository;

        private MainMenuRepository MainMenuRepositoryInstance
        {
            get
            {
                if (mainMenuRepository == null)
                {
                    mainMenuRepository = new MainMenuRepository();
                }
                return mainMenuRepository;
            }
        }

        public IList<MainMenu> GetAllMainMenuData(MainMenu input)
        {
            return MainMenuRepositoryInstance.GetAllMainMenuData(input);
        }
        #endregion

        #region Sub Menu

        private SubMenuRepository subMenuRepository;

        private SubMenuRepository SubMenuRepositoryInstance
        {
            get
            {
                if (subMenuRepository == null)
                {
                    subMenuRepository = new SubMenuRepository();
                }
                return subMenuRepository;
            }
        }

        public IList<SubMenu> GetAllSubMenuData(SubMenu input)
        {
            return SubMenuRepositoryInstance.GetAllSubMenuData(input);
        }
        #endregion

        #region Screen Role Mapping

        private ScreenRoleMappingRepository screenRoleMappingRepository;

        private ScreenRoleMappingRepository ScreenRoleMappingRepositoryInstance
        {
            get
            {
                if (screenRoleMappingRepository == null)
                {
                    screenRoleMappingRepository = new ScreenRoleMappingRepository();
                }
                return screenRoleMappingRepository;
            }
        }

        public IList<ScreenRoleMapping> GetAllScreenRoleMappingData(ScreenRoleMapping input)
        {
            return ScreenRoleMappingRepositoryInstance.GetAllScreenRoleMappingData(input);
        }
        #endregion

        #region Configration

        private ConfigrationRepository configrationRepository;

        private ConfigrationRepository ConfigrationRepositoryInstance
        {
            get
            {
                if (configrationRepository == null)
                {
                    configrationRepository = new ConfigrationRepository();
                }
                return configrationRepository;
            }
        }

        public IList<ConfigrationMaster> GetAllConfigrationData(ConfigrationMaster input)
        {
            return ConfigrationRepositoryInstance.GetAllConfigrationData(input);
        }
        #endregion

        #region Operational Configration

        private OperationalConfigrationRepository operationalConfigrationRepository;

        private OperationalConfigrationRepository OperationalConfigrationRepositoryInstance
        {
            get
            {
                if (operationalConfigrationRepository == null)
                {
                    operationalConfigrationRepository = new OperationalConfigrationRepository();
                }
                return operationalConfigrationRepository;
            }
        }

        public IList<OperationalConfigrationMaster> GetAllOperationalConfigrationData(OperationalConfigrationMaster input)
        {
            return OperationalConfigrationRepositoryInstance.GetAllOperationalConfigrationData(input);
        }
        #endregion

        #region Module Assigment

        private ModuleAssigmentRepository moduleAssigmentRepository;

        private ModuleAssigmentRepository ModuleAssigmentRepositoryInstance
        {
            get
            {
                if (moduleAssigmentRepository == null)
                {
                    moduleAssigmentRepository = new ModuleAssigmentRepository();
                }
                return moduleAssigmentRepository;
            }
        }

        public IList<Module_Assigment> GetAllModuleAssigmentData(Module_Assigment input)
        {
            return ModuleAssigmentRepositoryInstance.GetAllModuleAssigmentData(input);
        }
        #endregion

        #region Module

        private ModuleRepository moduleRepository;

        private ModuleRepository ModuleRepositoryInstance
        {
            get
            {
                if (moduleRepository == null)
                {
                    moduleRepository = new ModuleRepository();
                }
                return moduleRepository;
            }
        }

        public IList<ModuleMaster> GetAllModuleData(ModuleMaster input)
        {
            return ModuleRepositoryInstance.GetAllModuleData(input);
        }
        #endregion

        #region Address

        private AddressRepository addressRepository;

        private AddressRepository AddressRepositoryInstance
        {
            get
            {
                if (addressRepository == null)
                {
                    addressRepository = new AddressRepository();
                }
                return addressRepository;
            }
        }

        public IList<Address> GetAllAddressData(Address input)
        {
            return AddressRepositoryInstance.GetAllAddressData(input);
        }
        #endregion

        #region Banking Details

        private BankingDetailsRepository bankingDetailsRepository;

        private BankingDetailsRepository BankingDetailsRepositoryInstance
        {
            get
            {
                if (bankingDetailsRepository == null)
                {
                    bankingDetailsRepository = new BankingDetailsRepository();
                }
                return bankingDetailsRepository;
            }
        }

        public IList<BankingDetail> GetAllBankingDetailsData(BankingDetail input)
        {
            return BankingDetailsRepositoryInstance.GetAllBankingDetailsData(input);
        }
        #endregion

        #region Document Entity Mapping

        private DocumentEntityMappingRepository documentEntityMappingRepository;

        private DocumentEntityMappingRepository DocumentEntityMappingRepositoryInstance
        {
            get
            {
                if (documentEntityMappingRepository == null)
                {
                    documentEntityMappingRepository = new DocumentEntityMappingRepository();
                }
                return documentEntityMappingRepository;
            }
        }

        public IList<DocumentEntityMapping> GetAllDocumentEntityMappingData(DocumentEntityMapping input)
        {
            return DocumentEntityMappingRepositoryInstance.GetAllDocumentEntityMappingData(input);
        }
        #endregion

        #region Contact Details

        private ContactDetailsRepository contactDetailsRepository;

        private ContactDetailsRepository ContactDetailsRepositoryInstance
        {
            get
            {
                if (contactDetailsRepository == null)
                {
                    contactDetailsRepository = new ContactDetailsRepository();
                }
                return contactDetailsRepository;
            }
        }

        public IList<ContactDetail> GetAllContactDetailsData(ContactDetail input)
        {
            return ContactDetailsRepositoryInstance.GetAllContactDetailsData(input);
        }
        #endregion

        #region Email Format

        private Email_FormatRepository email_FormatRepository;

        private Email_FormatRepository Email_FormatRepositoryInstance
        {
            get
            {
                if (email_FormatRepository == null)
                {
                    email_FormatRepository = new Email_FormatRepository();
                }
                return email_FormatRepository;
            }
        }

        public IList<Email_Format> GetAllEmail_FormatData(Email_Format input)
        {
            return Email_FormatRepositoryInstance.GetAllEmail_FormatData(input);
        }
        #endregion

        #region Email Format Mapping

        private EmailFormatMappingRepository emailFormatMappingRepository;

        private EmailFormatMappingRepository EmailFormatMappingRepositoryInstance
        {
            get
            {
                if (emailFormatMappingRepository == null)
                {
                    emailFormatMappingRepository = new EmailFormatMappingRepository();
                }
                return emailFormatMappingRepository;
            }
        }

        public IList<EmailFormatMapping> GetAllEmailFormatMappingData(EmailFormatMapping input)
        {
            return EmailFormatMappingRepositoryInstance.GetAllEmailFormatMappingData(input);
        }
        #endregion

        #region File Field

        private FileFieldRepository fileFieldRepository;

        private FileFieldRepository FileFieldRepositoryInstance
        {
            get
            {
                if (fileFieldRepository == null)
                {
                    fileFieldRepository = new FileFieldRepository();
                }
                return fileFieldRepository;
            }
        }

        public IList<FileField> GetAllFileFieldData(FileField input)
        {
            return FileFieldRepositoryInstance.GetAllFileFieldData(input);
        }
        #endregion

        #region FileMaster

        private FileMasterRepository fileMasterRepository;

        private FileMasterRepository FileMasterRepositoryInstance
        {
            get
            {
                if (fileMasterRepository == null)
                {
                    fileMasterRepository = new FileMasterRepository();
                }
                return fileMasterRepository;
            }
        }

        public IList<FileMaster> GetAllFileMasterData(FileMaster input)
        {
            return FileMasterRepositoryInstance.GetAllFileMasterData(input);
        }
        #endregion

        #region merchant

        private merchantRepository merchantRepository;

        private merchantRepository merchantRepositoryInstance
        {
            get
            {
                if (merchantRepository == null)
                {
                    merchantRepository = new merchantRepository();
                }
                return merchantRepository;
            }
        }

        public IList<merchant> GetAllmerchantData(merchant input)
        {
            return merchantRepositoryInstance.GetAllmerchantData(input);
        }
        #endregion

        #region SMSFormatMapping

        private SMSFormatMappingRepository sMSFormatMappingRepository;

        private SMSFormatMappingRepository SMSFormatMappingRepositoryInstance
        {
            get
            {
                if (sMSFormatMappingRepository == null)
                {
                    sMSFormatMappingRepository = new SMSFormatMappingRepository();
                }
                return sMSFormatMappingRepository;
            }
        }

        public IList<SMSFormatMapping> GetAllSMSFormatMappingData(SMSFormatMapping input)
        {
            return SMSFormatMappingRepositoryInstance.GetAllSMSFormatMappingData(input);
        }
        #endregion

        #region Submerchant

        private SubmerchantRepository submerchantRepository;

        private SubmerchantRepository SubmerchantRepositoryInstance
        {
            get
            {
                if (submerchantRepository == null)
                {
                    submerchantRepository = new SubmerchantRepository();
                }
                return submerchantRepository;
            }
        }

        public IList<Submerchant> GetAllSubmerchantData(Submerchant input)
        {
            return SubmerchantRepositoryInstance.GetAllSubmerchantData(input);
        }
        #endregion

        #region User

        private UserRepository userRepository;

        private UserRepository UserRepositoryInstance
        {
            get
            {
                if (userRepository == null)
                {
                    userRepository = new UserRepository();
                }
                return userRepository;
            }
        }

        public IList<User> GetAllUserData(User input)
        {
            return UserRepositoryInstance.GetAllUserData(input);
        }
        #endregion

        #region vehiclemapping

        private vehiclemappingRepository vehiclemappingRepository;

        private vehiclemappingRepository vehiclemappingRepositoryInstance
        {
            get
            {
                if (vehiclemappingRepository == null)
                {
                    vehiclemappingRepository = new vehiclemappingRepository();
                }
                return vehiclemappingRepository;
            }
        }

        public IList<vehiclemapping> GetAllvehiclemappingData(vehiclemapping input)
        {
            return vehiclemappingRepositoryInstance.GetAllvehiclemappingData(input);
        }
        #endregion

        #region Document

        private DocumentRepository documentRepository;

        private DocumentRepository DocumentRepositoryInstance
        {
            get
            {
                if (documentRepository == null)
                {
                    documentRepository = new DocumentRepository();
                }
                return documentRepository;
            }
        }

        public IList<Document> GetAllDocumentData(Document input)
        {
            return DocumentRepositoryInstance.GetAllDocumentData(input);
        }
        #endregion

        //#region Entity

        //private EntityRepository entityRepository;

        //private EntityRepository EntityRepositoryInstance
        //{
        //    get
        //    {
        //        if (entityRepository == null)
        //        {
        //            entityRepository = new EntityRepository();
        //        }
        //        return entityRepository;
        //    }
        //}

        //public IList<EntityDocument> GetAllEntityData(EntityDocument input)
        //{
        //    return EntityRepositoryInstance.GetAllEntityData(input);
        //}
        //#endregion

        #region Vendor

        private VendorRepository vendorRepository;

        private VendorRepository VendorRepositoryInstance
        {
            get
            {
                if (vendorRepository == null)
                {
                    vendorRepository = new VendorRepository();
                }
                return vendorRepository;
            }
        }

        public IList<Vendor> GetAllVendorData(Vendor input)
        {
            return VendorRepositoryInstance.GetAllVendorData(input);
        }
        #endregion

        #region Vendor Document

        private VendorDocumentRepository vendorDocumentRepository;

        private VendorDocumentRepository VendorDocumentRepositoryInstance
        {
            get
            {
                if (vendorDocumentRepository == null)
                {
                    vendorDocumentRepository = new VendorDocumentRepository();
                }
                return vendorDocumentRepository;
            }
        }

        public IList<VendorDocument> GetAllVendorDocumentData(VendorDocument input)
        {
            return VendorDocumentRepositoryInstance.GetAllVendorDocumentData(input);
        }
        #endregion

        #region TTL Use

        private TTLUseRepository ttlUseRepository;

        private TTLUseRepository TTLUseRepositoryInstance
        {
            get
            {
                if (ttlUseRepository == null)
                {
                    ttlUseRepository = new TTLUseRepository();
                }
                return ttlUseRepository;
            }
        }

        public IList<TTLUse> GetAllTTLUseData(TTLUse input)
        {
            return TTLUseRepositoryInstance.GetAllTTLUseData(input);
        }
        #endregion

        #region Vendor SAP

        private VendorSAPRepository vendorSAPRepository;

        private VendorSAPRepository VendorSAPRepositoryInstance
        {
            get
            {
                if (vendorSAPRepository == null)
                {
                    vendorSAPRepository = new VendorSAPRepository();
                }
                return vendorSAPRepository;
            }
        }

        public IList<VendorSAP> GetAllVendorSAPData(VendorSAP input)
        {
            return VendorSAPRepositoryInstance.GetAllVendorSAPData(input);
        }

        public VendorSAP GetVendorSAPData(VendorSAP input)
        {
            return VendorSAPRepositoryInstance.GetVendorSAPData(input);
        }
        #endregion

        #region Withholding Tax

        private WithholdingTaxRepository withholdingTaxRepository;

        private WithholdingTaxRepository WithholdingTaxRepositoryInstance
        {
            get
            {
                if (withholdingTaxRepository == null)
                {
                    withholdingTaxRepository = new WithholdingTaxRepository();
                }
                return withholdingTaxRepository;
            }
        }

        public IList<WithholdingTax> GetAllWithholdingTaxData(WithholdingTax input)
        {
            return WithholdingTaxRepositoryInstance.GetAllWithholdingTaxData(input);
        }

       
        #endregion

        #region Withholding Tax Exe

        private WithholdingTaxExeRepository withholdingTaxExeRepository;

        private WithholdingTaxExeRepository WithholdingTaxExeRepositoryInstance
        {
            get
            {
                if (withholdingTaxExeRepository == null)
                {
                    withholdingTaxExeRepository = new WithholdingTaxExeRepository();
                }
                return withholdingTaxExeRepository;
            }
        }

        public IList<WithholdingTaxExe> GetAllWithholdingTaxExeData(WithholdingTaxExe input)
        {
            return WithholdingTaxExeRepositoryInstance.GetAllWithholdingTaxExeData(input);
        }

      
        #endregion


        #region Quotation

        private QuotationRepository quotationRepository;

        private QuotationRepository QuotationRepositoryInstance
        {
            get
            {
                if (quotationRepository == null)
                {
                    quotationRepository = new QuotationRepository();
                }
                return quotationRepository;
            }
        }

        public IList<Quotation> GetAllQuotationData(Quotation input)
        {
            return QuotationRepositoryInstance.GetAllQuotationData(input);
        }

        public Quotation InsertQuotation(Quotation input)
        {
            return QuotationRepositoryInstance.InsertQuotation(input);
        }
        #endregion

        #region Purchase Order

        private PurchaseOrderRepository purchaseOrderRepository;

        private PurchaseOrderRepository PurchaseOrderRepositoryInstance
        {
            get
            {
                if (purchaseOrderRepository == null)
                {
                    purchaseOrderRepository = new PurchaseOrderRepository();
                }
                return purchaseOrderRepository;
            }
        }

        public IList<PurchaseOrder> GetAllPurchaseOrderData(PurchaseOrder input)
        {
            return PurchaseOrderRepositoryInstance.GetAllPurchaseOrderData(input);
        }
        #endregion

        //#region Dispatch

        //private DispatchRepository dispatchRepository;

        //private DispatchRepository DispatchRepositoryInstance
        //{
        //    get
        //    {
        //        if (dispatchRepository == null)
        //        {
        //            dispatchRepository = new DispatchRepository();
        //        }
        //        return dispatchRepository;
        //    }
        //}

        //public IList<Dispatch> GetAllDispatchData(Dispatch input)
        //{
        //    return DispatchRepositoryInstance.GetAllDispatchData(input);
        //}
        //#endregion

        //vinod add 27-2-2021
        //vinod add 2-3-2021
        #region FileUpload

        private FileUploadRepository fileUploadRepository;

        private FileUploadRepository FileUploadRepositoryInstance
        {
            get
            {
                if (fileUploadRepository == null)
                {
                    fileUploadRepository = new FileUploadRepository();
                }
                return fileUploadRepository;
            }
        }

        public IList<FileUpload> GetAllFileUploadData(FileUpload input)
        {
            return FileUploadRepositoryInstance.GetAllFileUploadData(input);
        }
        #endregion


        //vinod add 4-3-2021
        #region Tabfields

        private TabfieldsRepository tabfieldsRepository;

        private TabfieldsRepository TabfieldsRepositoryInstance
        {
            get
            {
                if (tabfieldsRepository == null)
                {
                    tabfieldsRepository = new TabfieldsRepository();
                }
                return tabfieldsRepository;
            }
        }

        public IList<Tabfields> GetAllTabfieldsData(Tabfields input)
        {
            return TabfieldsRepositoryInstance.GetAllTabfieldsData(input);
        }
        #endregion

        #region Signup

        private SignupRepository signupRepository;

        private SignupRepository SignupRepositoryInstance
        {
            get
            {
                if (signupRepository == null)
                {
                    signupRepository = new SignupRepository();
                }
                return signupRepository;
            }
        }

        public IList<Signup> GetAllSignupData(Signup input)
        {
            return SignupRepositoryInstance.GetAllSignupData(input);
        }


        public Signup InsertSignupDetails(Signup input)
        {
            return SignupRepositoryInstance.InsertSignupDetails(input);
        }
        #endregion

        //vinod add 9-3-2021

        #region Invite

        private InviteRepository inviteRepository;

        private InviteRepository InviteRepositoryInstance
        {
            get
            {
                if (inviteRepository == null)
                {
                    inviteRepository = new InviteRepository();
                }
                return inviteRepository;
            }
        }

        public IList<Invite> GetAllInviteData(Invite input)
        {
            return InviteRepositoryInstance.GetAllInviteData(input);
        }
        #endregion

        //vinod add 6-4-2021

        #region Invoice

        private InvoiceRepository invoiceRepository;

        private InvoiceRepository InvoiceRepositoryInstance
        {
            get
            {
                if (invoiceRepository == null)
                {
                    invoiceRepository = new InvoiceRepository();
                }
                return invoiceRepository;
            }
        }

        public IList<Invoice> GetAllInvoiceData(Invoice input)
        {
            return InvoiceRepositoryInstance.GetAllInvoiceData(input);
        }
        #endregion

        //vinod add 15-4-2021

        #region ReqStatus

        private ReqStatusRepository reqStatusRepository;

        private ReqStatusRepository ReqStatusRepositoryInstance
        {
            get
            {
                if (reqStatusRepository == null)
                {
                    reqStatusRepository = new ReqStatusRepository();
                }
                return reqStatusRepository;
            }
        }

        public IList<ReqStatus> GetAllReqStatusData(ReqStatus input)
        {
            return ReqStatusRepositoryInstance.GetAllReqStatusData(input);
        }
        #endregion

        #region VendorStatus

        private VendorStatusRepository vendorStatusRepository;

        private VendorStatusRepository VendorStatusRepositoryInstance
        {
            get
            {
                if (vendorStatusRepository == null)
                {
                    vendorStatusRepository = new VendorStatusRepository();
                }
                return vendorStatusRepository;
            }
        }

        public IList<VendorStatus> GetAllVendorStatusData(VendorStatus input)
        {
            return VendorStatusRepositoryInstance.GetAllVendorStatusData(input);
        }
        #endregion

        //vinod add 28-4-2021
        #region References

        private ReferencesRepository referencesRepository;

        private ReferencesRepository ReferencesRepositoryInstance
        {
            get
            {
                if (referencesRepository == null)
                {
                    referencesRepository = new ReferencesRepository();
                }
                return referencesRepository;
            }
        }

        public IList<References> GetAllReferencesData(References input)
        {
            return ReferencesRepositoryInstance.GetAllReferencesData(input);
        }
        #endregion

        //vinod add 21-6-2021
        #region InviteSupplier

        private InviteSupplierRepository inviteSupplierRepository;

        private InviteSupplierRepository InviteSupplierRepositoryInstance
        {
            get
            {
                if (inviteSupplierRepository == null)
                {
                    inviteSupplierRepository = new InviteSupplierRepository();
                }
                return inviteSupplierRepository;
            }
        }

        public IList<InviteSupplier> GetAllInviteSupplierData(InviteSupplier input)
        {
            return InviteSupplierRepositoryInstance.GetAllInviteSupplierData(input);
        }
        #endregion

        #region Remark

        private RemarkRepository remarkRepository;

        private RemarkRepository RemarkRepositoryInstance
        {
            get
            {
                if (remarkRepository == null)
                {
                    remarkRepository = new RemarkRepository();
                }
                return remarkRepository;
            }
        }

        public IList<Remark> GetAllRemarkData(Remark input)
        {
            return RemarkRepositoryInstance.GetAllRemarkData(input);
        }
        #endregion

        //vinod add 22-6-2021
        #region PurchasingOrganisation

        private PurchasingOrganisationRepository purchasingOrganisationRepository;

        private PurchasingOrganisationRepository PurchasingOrganisationRepositoryInstance
        {
            get
            {
                if (purchasingOrganisationRepository == null)
                {
                    purchasingOrganisationRepository = new PurchasingOrganisationRepository();
                }
                return purchasingOrganisationRepository;
            }
        }

        public IList<SAPMaster> GetAllPurchasingOrganisationData(SAPMaster input)
        {
            return PurchasingOrganisationRepositoryInstance.GetAllPurchasingOrganisationData(input);
        }
        #endregion

        //vinod add 26-6-2021
        #region BankKey

        private BankKeyRepository bankKeyRepository;

        private BankKeyRepository BankKeyRepositoryInstance
        {
            get
            {
                if (bankKeyRepository == null)
                {
                    bankKeyRepository = new BankKeyRepository();
                }
                return bankKeyRepository;
            }
        }

        public IList<SAPMaster> GetAllBankKeyData(SAPMaster input)
        {
            return BankKeyRepositoryInstance.GetAllBankKeyData(input);
        }
        #endregion

        #region ReconciliationAccount

        private ReconciliationAccountRepository reconciliationAccountRepository;

        private ReconciliationAccountRepository ReconciliationAccountRepositoryInstance
        {
            get
            {
                if (reconciliationAccountRepository == null)
                {
                    reconciliationAccountRepository = new ReconciliationAccountRepository();
                }
                return reconciliationAccountRepository;
            }
        }

        public IList<SAPMaster> GetAllReconciliationAccountData(SAPMaster input)
        {
            return ReconciliationAccountRepositoryInstance.GetAllReconciliationAccountData(input);
        }
        #endregion


        #region PaymentTerm

        private PaymentTermRepository paymentTermRepository;

        private PaymentTermRepository PaymentTermRepositoryInstance
        {
            get
            {
                if (paymentTermRepository == null)
                {
                    paymentTermRepository = new PaymentTermRepository();
                }
                return paymentTermRepository;
            }
        }

        public IList<SAPMaster> GetAllPaymentTermData(SAPMaster input)
        {
            return PaymentTermRepositoryInstance.GetAllPaymentTermData(input);
        }
        #endregion


        #region PaymentMethods

        private PaymentMethodsRepository paymentMethodsRepository;

        private PaymentMethodsRepository PaymentMethodsRepositoryInstance
        {
            get
            {
                if (paymentMethodsRepository == null)
                {
                    paymentMethodsRepository = new PaymentMethodsRepository();
                }
                return paymentMethodsRepository;
            }
        }

        public IList<SAPMaster> GetAllPaymentMethodsData(SAPMaster input)
        {
            return PaymentMethodsRepositoryInstance.GetAllPaymentMethodsData(input);
        }
        #endregion


        #region PaymentBlock

        private PaymentBlockRepository paymentBlockRepository;

        private PaymentBlockRepository PaymentBlockRepositoryInstance
        {
            get
            {
                if (paymentBlockRepository == null)
                {
                    paymentBlockRepository = new PaymentBlockRepository();
                }
                return paymentBlockRepository;
            }
        }

        public IList<SAPMaster> GetAllPaymentBlockData(SAPMaster input)
        {
            return PaymentBlockRepositoryInstance.GetAllPaymentBlockData(input);
        }
        #endregion

        #region HouseBank

        private HouseBankRepository houseBankRepository;

        private HouseBankRepository HouseBankRepositoryInstance
        {
            get
            {
                if (houseBankRepository == null)
                {
                    houseBankRepository = new HouseBankRepository();
                }
                return houseBankRepository;
            }
        }

        public IList<SAPMaster> GetAllHouseBankData(SAPMaster input)
        {
            return HouseBankRepositoryInstance.GetAllHouseBankData(input);
        }
        #endregion

        #region SchemaGroupVendor
        private SchemaGroupVendorRepository schemaGroupVendorRepository;

        private SchemaGroupVendorRepository SchemaGroupVendorRepositoryInstance
        {
            get
            {
                if (schemaGroupVendorRepository == null)
                {
                    schemaGroupVendorRepository = new SchemaGroupVendorRepository();
                }
                return schemaGroupVendorRepository;
            }
        }

        public IList<SAPMaster> GetAllSchemaGroupVendorData(SAPMaster input)
        {
            return SchemaGroupVendorRepositoryInstance.GetAllSchemaGroupVendorData(input);
        }
        #endregion

        #region PaymentTermLevel

        private PaymentTermLevelRepository paymentTermLevelRepository;

        private PaymentTermLevelRepository PaymentTermLevelRepositoryInstance
        {
            get
            {
                if (paymentTermLevelRepository == null)
                {
                    paymentTermLevelRepository = new PaymentTermLevelRepository();
                }
                return paymentTermLevelRepository;
            }
        }

        public IList<SAPMaster> GetAllPaymentTermLevelData(SAPMaster input)
        {
            return PaymentTermLevelRepositoryInstance.GetAllPaymentTermLevelData(input);
        }
        #endregion

        #region WithholdingTaxCountry

        private WithholdingTaxCountryRepository withholdingTaxCountryRepository;

        private WithholdingTaxCountryRepository WithholdingTaxCountryRepositoryInstance
        {
            get
            {
                if (withholdingTaxCountryRepository == null)
                {
                    withholdingTaxCountryRepository = new WithholdingTaxCountryRepository();
                }
                return withholdingTaxCountryRepository;
            }
        }

        public IList<SAPMaster> GetAllWithholdingTaxCountryData(SAPMaster input)
        {
            return WithholdingTaxCountryRepositoryInstance.GetAllWithholdingTaxCountryData(input);
        }
        #endregion

        #region VendorClassificationGST

        private VendorClassificationGSTRepository vendorClassificationGSTRepository;

        private VendorClassificationGSTRepository VendorClassificationGSTRepositoryInstance
        {
            get
            {
                if (vendorClassificationGSTRepository == null)
                {
                    vendorClassificationGSTRepository = new VendorClassificationGSTRepository();
                }
                return vendorClassificationGSTRepository;
            }
        }

        public IList<SAPMaster> GetAllVendorClassificationGSTData(SAPMaster input)
        {
            return VendorClassificationGSTRepositoryInstance.GetAllVendorClassificationGSTData(input);
        }
        #endregion

        #region WithholdingTaxType

        private WithholdingTaxTypeRepository withholdingTaxTypeRepository;

        private WithholdingTaxTypeRepository WithholdingTaxTypeRepositoryInstance
        {
            get
            {
                if (withholdingTaxTypeRepository == null)
                {
                    withholdingTaxTypeRepository = new WithholdingTaxTypeRepository();
                }
                return withholdingTaxTypeRepository;
            }
        }

        public IList<SAPMaster> GetAllWithholdingTaxTypeData(SAPMaster input)
        {
            return WithholdingTaxTypeRepositoryInstance.GetAllWithholdingTaxTypeData(input);
        }
        #endregion

        #region WithholdingTaxCode

        private WithholdingTaxCodeRepository withholdingTaxCodeRepository;

        private WithholdingTaxCodeRepository WithholdingTaxCodeRepositoryInstance
        {
            get
            {
                if (withholdingTaxCodeRepository == null)
                {
                    withholdingTaxCodeRepository = new WithholdingTaxCodeRepository();
                }
                return withholdingTaxCodeRepository;
            }
        }

        public IList<SAPMaster> GetAllWithholdingTaxCodeData(SAPMaster input)
        {
            return WithholdingTaxCodeRepositoryInstance.GetAllWithholdingTaxCodeData(input);
        }
        #endregion

        #region TypeOfRecipient

        private TypeOfRecipientRepository typeOfRecipientRepository;

        private TypeOfRecipientRepository TypeOfRecipientRepositoryInstance
        {
            get
            {
                if (typeOfRecipientRepository == null)
                {
                    typeOfRecipientRepository = new TypeOfRecipientRepository();
                }
                return typeOfRecipientRepository;
            }
        }

        public IList<SAPMaster> GetAllTypeOfRecipientData(SAPMaster input)
        {
            return TypeOfRecipientRepositoryInstance.GetAllTypeOfRecipientData(input);
        }
        #endregion

        #region SectionCode

        private SectionCodeRepository sectionCodeRepository;

        private SectionCodeRepository SectionCodeRepositoryInstance
        {
            get
            {
                if (sectionCodeRepository == null)
                {
                    sectionCodeRepository = new SectionCodeRepository();
                }
                return sectionCodeRepository;
            }
        }

        public IList<SAPMaster> GetAllSectionCodeData(SAPMaster input)
        {
            return SectionCodeRepositoryInstance.GetAllSectionCodeData(input);
        }
        #endregion

        #region WithholdingTaxTypeExemption

        private WithholdingTaxTypeExemptionRepository withholdingTaxTypeExemptionRepository;

        private WithholdingTaxTypeExemptionRepository WithholdingTaxTypeExemptionRepositoryInstance
        {
            get
            {
                if (withholdingTaxTypeExemptionRepository == null)
                {
                    withholdingTaxTypeExemptionRepository = new WithholdingTaxTypeExemptionRepository();
                }
                return withholdingTaxTypeExemptionRepository;
            }
        }

        public IList<SAPMaster> GetAllWithholdingTaxTypeExemptionData(SAPMaster input)
        {
            return WithholdingTaxTypeExemptionRepositoryInstance.GetAllWithholdingTaxTypeExemptionData(input);
        }
        #endregion

        #region WithholdingTaxCodeExemption

        private WithholdingTaxCodeExemptionRepository withholdingTaxCodeExemptionRepository;

        private WithholdingTaxCodeExemptionRepository WithholdingTaxCodeExemptionRepositoryInstance
        {
            get
            {
                if (withholdingTaxCodeExemptionRepository == null)
                {
                    withholdingTaxCodeExemptionRepository = new WithholdingTaxCodeExemptionRepository();
                }
                return withholdingTaxCodeExemptionRepository;
            }
        }

        public IList<SAPMaster> GetAllWithholdingTaxCodeExemptionData(SAPMaster input)
        {
            return WithholdingTaxCodeExemptionRepositoryInstance.GetAllWithholdingTaxCodeExemptionData(input);
        }
        #endregion


        #region Currency

        private CurrencyRepository currencyRepository;

        private CurrencyRepository CurrencyRepositoryInstance
        {
            get
            {
                if (currencyRepository == null)
                {
                    currencyRepository = new CurrencyRepository();
                }
                return currencyRepository;
            }
        }

        public IList<SAPMaster> GetAllCurrencyData(SAPMaster input)
        {
            return CurrencyRepositoryInstance.GetAllCurrencyData(input);
        }
        #endregion


        //8-7-2021
        #region NDAApp

        private NDAAppRepository ndaAppRepository;

        private NDAAppRepository NDAAppRepositoryInstance
        {
            get
            {
                if (ndaAppRepository == null)
                {
                    ndaAppRepository = new NDAAppRepository();
                }
                return ndaAppRepository;
            }
        }

        public IList<NDAApp> GetAllNDAAppData(NDAApp input)
        {
            return NDAAppRepositoryInstance.GetAllNDAAppData(input);
        }
        #endregion

        //9-7-2021
        #region RemarkList

        private RemarkListRepository remarkListRepository;

        private RemarkListRepository RemarkListRepositoryInstance
        {
            get
            {
                if (remarkListRepository == null)
                {
                    remarkListRepository = new RemarkListRepository();
                }
                return remarkListRepository;
            }
        }

        public IList<Remark> GetAllRemarkListData(Remark input)
        {
            return RemarkListRepositoryInstance.GetAllRemarkListData(input);
        }
        #endregion


        //10-7-2021
        #region Withholding Tax List

        private WithholdingTaxListRepository withholdingTaxListRepository;

        private WithholdingTaxListRepository WithholdingTaxListRepositoryInstance
        {
            get
            {
                if (withholdingTaxListRepository == null)
                {
                    withholdingTaxListRepository = new WithholdingTaxListRepository();
                }
                return withholdingTaxListRepository;
            }
        }

        public IList<WithholdingTax> GetAllWithholdingTaxListData(WithholdingTax input)
        {
            return WithholdingTaxListRepositoryInstance.GetAllWithholdingTaxListData(input);
        }

        public WithholdingTax GetWithholdingTaxListData(WithholdingTax input)
        {
            return WithholdingTaxListRepositoryInstance.GetWithholdingTaxListData(input);
        }
        #endregion

        #region Withholding Tax Exe List

        private WithholdingTaxExeListRepository withholdingTaxExeListRepository;

        private WithholdingTaxExeListRepository WithholdingTaxExeListRepositoryInstance
        {
            get
            {
                if (withholdingTaxExeListRepository == null)
                {
                    withholdingTaxExeListRepository = new WithholdingTaxExeListRepository();
                }
                return withholdingTaxExeListRepository;
            }
        }

        public IList<WithholdingTaxExe> GetAllWithholdingTaxExeListData(WithholdingTaxExe input)
        {
            return WithholdingTaxExeListRepositoryInstance.GetAllWithholdingTaxExeListData(input);
        }

        public WithholdingTaxExe GetWithholdingTaxExeListData(WithholdingTaxExe input)
        {
            return WithholdingTaxExeListRepositoryInstance.GetWithholdingTaxExeListData(input);
        }

        #endregion

        #region WIPApplicationList

        private WIPApplicationListRepository wIPApplicationListRepository;

        private WIPApplicationListRepository WIPApplicationListRepositoryInstance
        {
            get
            {
                if (wIPApplicationListRepository == null)
                {
                    wIPApplicationListRepository = new WIPApplicationListRepository();
                }
                return wIPApplicationListRepository;
            }
        }

        public IList<WIPApplicationList> GetAllWIPApplicationListData(WIPApplicationList input)
        {
            return WIPApplicationListRepositoryInstance.GetAllWIPApplicationListData(input);
        }
        #endregion

        //14-7-2021
        #region RegisterList

        private RegisterListRepository registerListRepository;

        private RegisterListRepository RegisterListRepositoryInstance
        {
            get
            {
                if (registerListRepository == null)
                {
                    registerListRepository = new RegisterListRepository();
                }
                return registerListRepository;
            }
        }

        public IList<RegisterList> GetAllRegisterListData(RegisterList input)
        {
            return RegisterListRepositoryInstance.GetAllRegisterListData(input);
        }
        #endregion

        #region Supplier Details

        private SupplierDetailsRepository supplierDetailsRepository;

        private SupplierDetailsRepository SupplierDetailsRepositoryInstance
        {
            get
            {
                if (supplierDetailsRepository == null)
                {
                    supplierDetailsRepository = new SupplierDetailsRepository();
                }
                return supplierDetailsRepository;
            }
        }

        public IList<Vendor> GetAllSupplierDetailsData(Vendor input)
        {
            return SupplierDetailsRepositoryInstance.GetAllSupplierDetailsData(input);
        }
        #endregion

        //vinod add 23-7-2021
        #region References List

        private ReferencesListRepository referencesListRepository;

        private ReferencesListRepository ReferencesListRepositoryInstance
        {
            get
            {
                if (referencesListRepository == null)
                {
                    referencesListRepository = new ReferencesListRepository();
                }
                return referencesListRepository;
            }
        }

        public IList<Vendor> GetAllReferencesListData(Vendor input)
        {
            return ReferencesListRepositoryInstance.GetAllReferencesListData(input);
        }
        #endregion



        #region TTLUse Detail

        private TTLUseDetailRepository ttlUseDetailRepository;

        private TTLUseDetailRepository TTLUseDetailRepositoryInstance
        {
            get
            {
                if (ttlUseDetailRepository == null)
                {
                    ttlUseDetailRepository = new TTLUseDetailRepository();
                }
                return ttlUseDetailRepository;
            }
        }

        public IList<TTLUse> GetAllTTLUseDetailData(TTLUse input)
        {
            return TTLUseDetailRepositoryInstance.GetAllTTLUseDetailData(input);
        }
        #endregion

        //vinod add 24-7-2021

        #region Invite List

        private InviteListRepository inviteListRepository;

        private InviteListRepository InviteListRepositoryInstance
        {
            get
            {
                if (inviteListRepository == null)
                {
                    inviteListRepository = new InviteListRepository();
                }
                return inviteListRepository;
            }
        }

        public IList<Invite> GetAllInviteListData(Invite input)
        {
            return InviteListRepositoryInstance.GetAllInviteListData(input);
        }
        #endregion

        //vinod add 28-7-2021

        #region CheckPreferredUserID

        private CheckPreferredUserIDRepository checkPreferredUserIDRepository;

        private CheckPreferredUserIDRepository CheckPreferredUserIDRepositoryInstance
        {
            get
            {
                if (checkPreferredUserIDRepository == null)
                {
                    checkPreferredUserIDRepository = new CheckPreferredUserIDRepository();
                }
                return checkPreferredUserIDRepository;
            }
        }

        public IList<Signup> CheckPreferredUserID(Signup input)
        {
            return CheckPreferredUserIDRepositoryInstance.CheckPreferredUserID(input);
        }
        #endregion

        //31-8-2021
        #region NDA

        private NDARepository ndaRepository;

        private NDARepository NDARepositoryInstance
        {
            get
            {
                if (ndaRepository == null)
                {
                    ndaRepository = new NDARepository();
                }
                return ndaRepository;
            }
        }

        public IList<NDAApp> GetAllNDAData(NDAApp input)
        {
            return NDARepositoryInstance.GetAllNDAData(input);
        }
        #endregion
        //1-9-2021
        #region Approval

        private ApprovalRepository approvalRepository;

        private ApprovalRepository ApprovalRepositoryInstance
        {
            get
            {
                if (approvalRepository == null)
                {
                    approvalRepository = new ApprovalRepository();
                }
                return approvalRepository;
            }
        }

       


        public Approval InsertApproval(Approval input)
        {
            return ApprovalRepositoryInstance.InsertApproval(input);
        }
        #endregion

        #region SendBack

        private SendBackRepository sendBackRepository;

        private SendBackRepository SendBackRepositoryInstance
        {
            get
            {
                if (sendBackRepository == null)
                {
                    sendBackRepository = new SendBackRepository();
                }
                return sendBackRepository;
            }
        }




        public SendBack InsertSendBack(SendBack input)
        {
            return SendBackRepositoryInstance.InsertSendBack(input);
        }
        #endregion
        //2-9-2021
        #region Register

        private RegisterRepository registerRepository;

        private RegisterRepository RegisterRepositoryInstance
        {
            get
            {
                if (registerRepository == null)
                {
                    registerRepository = new RegisterRepository();
                }
                return registerRepository;
            }
        }




        public Register InsertRegister(Register input)
        {
            return RegisterRepositoryInstance.InsertRegister(input);
        }


        #endregion

        //14-9-2021
        #region TabVerifyAccept

        private TabVerifyAcceptRepository tabVerifyAcceptRepository;

        private TabVerifyAcceptRepository TabVerifyAcceptRepositoryInstance
        {
            get
            {
                if (tabVerifyAcceptRepository == null)
                {
                    tabVerifyAcceptRepository = new TabVerifyAcceptRepository();
                }
                return tabVerifyAcceptRepository;
            }
        }

      
        public TabVerifyAccept InsertTabVerifyAccept(TabVerifyAccept input)
        {
            return TabVerifyAcceptRepositoryInstance.InsertTabVerifyAccept(input);
        }
        #endregion

        //14-9-2021
        #region TabVerifyAcceptDetails

        private TabVerifyAcceptDetailsRepository tabVerifyAcceptDetailsRepository;

        private TabVerifyAcceptDetailsRepository TabVerifyAcceptDetailsRepositoryInstance
        {
            get
            {
                if (tabVerifyAcceptDetailsRepository == null)
                {
                    tabVerifyAcceptDetailsRepository = new TabVerifyAcceptDetailsRepository();
                }
                return tabVerifyAcceptDetailsRepository;
            }
        }


        public IList<TabVerifyAccept> GetTabVerifyAcceptDetails(TabVerifyAccept input)
        {
            return TabVerifyAcceptDetailsRepositoryInstance.GetTabVerifyAcceptDetails(input);
        }
        #endregion


        //27-9-2021
        #region EmpRoleType

        private EmpRoleTypeRepository empRoleTypeRepository;

        private EmpRoleTypeRepository EmpRoleTypeRepositoryInstance
        {
            get
            {
                if (empRoleTypeRepository == null)
                {
                    empRoleTypeRepository = new EmpRoleTypeRepository();
                }
                return empRoleTypeRepository;
            }
        }


        public IList<EmpRole> GetEmpRoleTypeData(EmpRole input)
        {
            return EmpRoleTypeRepositoryInstance.GetEmpRoleTypeData(input);
        }
        #endregion

        //9-7-2021
        #region RemarkDetails

        private RemarkDetailsRepository remarkDetailsRepository;

        private RemarkDetailsRepository RemarkDetailsRepositoryInstance
        {
            get
            {
                if (remarkDetailsRepository == null)
                {
                    remarkDetailsRepository = new RemarkDetailsRepository();
                }
                return remarkDetailsRepository;
            }
        }

        public IList<Remark> GetRemarkByFieldID(Remark input)
        {
            return RemarkDetailsRepositoryInstance.GetRemarkByFieldID(input);
        }
        #endregion

    }
}
