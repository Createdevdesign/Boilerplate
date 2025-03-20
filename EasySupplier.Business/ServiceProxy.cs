using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BoilerSupplier.Repository;


namespace BoilerSupplier.Business
{
    public static class ServiceProxy
    {

        public static ILoginService LoginService { get; internal set; }

        public static ILookupService LookupService { get; internal set; }

        public static IConfigrationService ConfigrationService { get; internal set; }
        public static IOperationalConfigrationService OperationalConfigrationService { get; internal set; }
        public static IFileSchemaService FileSchemaService { get; internal set; }
        public static ILookupValueService LookupValueService { get; internal set; }
        public static IMainMenuService MainMenuService { get; internal set; }
        public static IModuleAssigmentService ModuleAssigmentService { get; internal set; }
        public static IModuleService ModuleService { get; internal set; }
        public static IScreenRoleMappingService ScreenRoleMappingService { get; internal set; }
        public static ISMSFormatService SMSFormatService { get; internal set; }
        public static ISubMenuService SubMenuService { get; internal set; }

        public static IAddressService AddressService { get; internal set; }
        public static IBankingDetailsService BankingDetailsService { get; internal set; }

        public static IDocumentEntityMappingService DocumentEntityMappingService { get; internal set; }

        public static IFileFieldService FileFieldService { get; internal set; }
        public static IFileMasterService FileMasterService { get; internal set; }
        public static IContactDetailsService ContactDetailsService { get; internal set; }
        public static IEmail_FormatService Email_FormatService { get; internal set; }
        public static IUserService UserService { get; internal set; }
        public static IvehiclemappingService vehiclemappingService { get; internal set; }
        public static IEmailFormatMappingService EmailFormatMappingService { get; internal set; }
        public static ISMSFormatMappingService SMSFormatMappingService { get; internal set; }
        public static ImerchantService merchantService { get; internal set; }
        public static ISubmerchantService SubmerchantService { get; internal set; }

        public static IDocumentService DocumentService { get; internal set; }
        //public static IEntityService EntityService { get; internal set; }

        public static IVendorService VendorService { get; internal set; }
        public static IVendorDocumentService VendorDocumentService { get; internal set; }

        public static ITTLUseService TTLUseService { get; internal set; }

        public static IVendorSAPService VendorSAPService { get; internal set; }

        public static IWithholdingTaxService WithholdingTaxService { get; internal set; }
        public static IWithholdingTaxExeService WithholdingTaxExeService { get; internal set; }

        public static IQuotationService QuotationService { get; internal set; }
        public static IPurchaseOrderService PurchaseOrderService { get; internal set; }

        //vinod add 27-2-2021
        public static IFileUploadService FileUploadService { get; internal set; }
       
        //vinod add 4-3-2021
        public static ITabfieldsService TabfieldsService { get; internal set; }
        public static ISignupService SignupService { get; internal set; }

        //vinod add 9-3-2021
        public static IInviteService InviteService { get; internal set; }
        //vinod add 6-4-2021
        public static IInvoiceService InvoiceService { get; internal set; }
        //vinod add 15-4-2021
        public static IReqStatusService ReqStatusService { get; internal set; }
        public static IVendorStatusService VendorStatusService { get; internal set; }

        //vinod add 28-4-2021
        public static IReferencesService ReferencesService { get; internal set; }

        //vinod add 21-6-2021
        public static IInviteSupplierService InviteSupplierService { get; internal set; }
        public static IRemarkService RemarkService { get; internal set; }


        //vinod add 22-6-2021
        public static IPurchasingOrganisationService PurchasingOrganisationService { get; internal set; }

        //vinod add 26-6-2021
        public static IBankKeyService BankKeyService { get; internal set; }
        public static IReconciliationAccountService ReconciliationAccountService { get; internal set; }
        public static IPaymentTermService PaymentTermService { get; internal set; }
        public static IPaymentMethodsService PaymentMethodsService { get; internal set; }
        public static IPaymentBlockService PaymentBlockService { get; internal set; }
        public static IHouseBankService HouseBankService { get; internal set; }
        public static ISchemaGroupVendorService SchemaGroupVendorService { get; internal set; }
        public static IPaymentTermLevelService PaymentTermLevelService { get; internal set; }
        public static IWithholdingTaxCountryService WithholdingTaxCountryService { get; internal set; }
        public static IVendorClassificationGSTService VendorClassificationGSTService { get; internal set; }
        public static IWithholdingTaxTypeService WithholdingTaxTypeService { get; internal set; }
        public static IWithholdingTaxCodeService WithholdingTaxCodeService { get; internal set; }
        public static ITypeOfRecipientService TypeOfRecipientService { get; internal set; }
        public static ISectionCodeService SectionCodeService { get; internal set; }
        public static IWithholdingTaxTypeExemptionService WithholdingTaxTypeExemptionService { get; internal set; }
        public static IWithholdingTaxCodeExemptionService WithholdingTaxCodeExemptionService { get; internal set; }
        public static ICurrencyService CurrencyService { get; internal set; }


        //8-7-2021
        public static INDAAppService NDAAppService { get; internal set; }
        //9-7-2021
        public static IRemarkListService RemarkListService { get; internal set; }

        //10-7-2021
        public static IWithholdingTaxListService WithholdingTaxListService { get; internal set; }
        public static IWithholdingTaxExeListService WithholdingTaxExeListService { get; internal set; }
        //12-7-2021
        public static IWIPApplicationListService WIPApplicationListService { get; internal set; }
        //14-7-2021
        public static IRegisterListService RegisterListService { get; internal set; }
        public static ISupplierDetailsService SupplierDetailsService { get; internal set; }

        //23-7-2021
        public static IReferencesListService ReferencesListService { get; internal set; }
        public static ITTLUseDetailService TTLUseDetailService { get; internal set; }
        //vinod add 24-7-2021
        public static IInviteListService InviteListService { get; internal set; }

        //vinod add 28-7-2021
        public static ICheckPreferredUserIDService CheckPreferredUserIDService { get; internal set; }

        //31-8-2021
        public static INDAService NDAService { get; internal set; }

        //1-9-2021
        public static IApprovalService ApprovalService { get; internal set; }
        public static ISendBackService SendBackService { get; internal set; }

        //2-9-2021
        public static IRegisterService RegisterService { get; internal set; }
        //13-9-2021
        public static ITabVerifyAcceptService TabVerifyAcceptService { get; internal set; }
        //14-9-2021
        public static ITabVerifyAcceptDetailsService TabVerifyAcceptDetailsService { get; internal set; }

        //27-9-2021
        public static IEmpRoleTypeService EmpRoleTypeService { get; internal set; }

        //6-10-2021
        public static IRemarkDetailsService RemarkDetailsService { get; internal set; }


        static ServiceProxy()
        {
            LookupService = new LookupService(new DataManger());
            LoginService = new LoginService(new DataManger());
            // create instance for all 
            LookupValueService = new LookupValueService(new DataManger());
            ConfigrationService = new ConfigrationService(new DataManger());
            OperationalConfigrationService = new OperationalConfigrationService(new DataManger());
            FileSchemaService = new FileSchemaService(new DataManger());

            MainMenuService = new MainMenuService(new DataManger());
            ModuleAssigmentService = new ModuleAssigmentService(new DataManger());
            ModuleService = new ModuleService(new DataManger());
            ScreenRoleMappingService = new ScreenRoleMappingService(new DataManger());
            SMSFormatService = new SMSFormatService(new DataManger());
            SubMenuService = new SubMenuService(new DataManger());


            AddressService = new AddressService(new DataManger());
            BankingDetailsService = new BankingDetailsService(new DataManger());
            DocumentEntityMappingService = new DocumentEntityMappingService(new DataManger());

            FileFieldService = new FileFieldService(new DataManger());
            FileMasterService = new FileMasterService(new DataManger());
            ContactDetailsService = new ContactDetailsService(new DataManger());
            Email_FormatService = new Email_FormatService(new DataManger());
            UserService = new UserService(new DataManger());
            vehiclemappingService = new vehiclemappingService(new DataManger());
            EmailFormatMappingService = new EmailFormatMappingService(new DataManger());
            SMSFormatMappingService = new SMSFormatMappingService(new DataManger());
            merchantService = new merchantService(new DataManger());
            SubmerchantService = new SubmerchantService(new DataManger());

            DocumentService = new DocumentService(new DataManger());
            //EntityService = new EntityService(new DataManger());

            VendorService = new VendorService(new DataManger());
            VendorDocumentService = new VendorDocumentService(new DataManger());

            TTLUseService = new TTLUseService(new DataManger());
            VendorSAPService = new VendorSAPService(new DataManger());

            WithholdingTaxService = new WithholdingTaxService(new DataManger());
            WithholdingTaxExeService = new WithholdingTaxExeService(new DataManger());

            QuotationService = new QuotationService(new DataManger());
            PurchaseOrderService = new PurchaseOrderService(new DataManger());

            //vinod add 27-2-2021
            FileUploadService = new FileUploadService(new DataManger());
            //vinod add 4-3-2021
            TabfieldsService = new TabfieldsService(new DataManger());
            SignupService = new SignupService(new DataManger());

            //vinod add 9-3-2021
            InviteService = new InviteService(new DataManger());
            //vinod add 6-4-2021
            InvoiceService = new InvoiceService(new DataManger());

            //vinod add 15-4-2021
            ReqStatusService = new ReqStatusService(new DataManger());
            VendorStatusService = new VendorStatusService(new DataManger());

            //vinod add 28-4-2021
            ReferencesService = new ReferencesService(new DataManger());
            //vinod add 21-6-2021
            InviteSupplierService = new InviteSupplierService(new DataManger());
            RemarkService = new RemarkService(new DataManger());
            //vinod add 22-6-2021
            PurchasingOrganisationService = new PurchasingOrganisationService(new DataManger());

            //vinod add 26-6-2021
            BankKeyService = new BankKeyService(new DataManger());
            ReconciliationAccountService = new ReconciliationAccountService(new DataManger());
            PaymentTermService = new PaymentTermService(new DataManger());
            PaymentMethodsService = new PaymentMethodsService(new DataManger());
            PaymentBlockService = new PaymentBlockService(new DataManger());
            HouseBankService = new HouseBankService(new DataManger());
            SchemaGroupVendorService = new SchemaGroupVendorService(new DataManger());
            PaymentTermLevelService = new PaymentTermLevelService(new DataManger());
            WithholdingTaxCountryService = new WithholdingTaxCountryService(new DataManger());
            VendorClassificationGSTService = new VendorClassificationGSTService(new DataManger());
            WithholdingTaxTypeService = new WithholdingTaxTypeService(new DataManger());
            WithholdingTaxCodeService = new WithholdingTaxCodeService(new DataManger());
            TypeOfRecipientService = new TypeOfRecipientService(new DataManger());
            SectionCodeService = new SectionCodeService(new DataManger());
            WithholdingTaxTypeExemptionService = new WithholdingTaxTypeExemptionService(new DataManger());
            WithholdingTaxCodeExemptionService = new WithholdingTaxCodeExemptionService(new DataManger());
            CurrencyService = new CurrencyService(new DataManger());
            //vinod 8-7-2021
            NDAAppService = new NDAAppService(new DataManger());

            //9-7-2021
            RemarkListService = new RemarkListService(new DataManger());
            //10-7-2021
            WithholdingTaxListService = new WithholdingTaxListService(new DataManger());
            WithholdingTaxExeListService = new WithholdingTaxExeListService(new DataManger());
            //12-7-2021
            WIPApplicationListService = new WIPApplicationListService(new DataManger());
            //14-7-2021
            RegisterListService = new RegisterListService(new DataManger());
            SupplierDetailsService = new SupplierDetailsService(new DataManger());

            //23-7-2021
            ReferencesListService = new ReferencesListService(new DataManger());
            TTLUseDetailService = new TTLUseDetailService(new DataManger());
            //vinod add 24-7-2021
            InviteListService = new InviteListService(new DataManger());
            //vinod add 28-7-2021
            CheckPreferredUserIDService = new CheckPreferredUserIDService(new DataManger());

            //vinod 31-8-2021
            NDAService = new NDAService(new DataManger());

            //1-9-2021
           ApprovalService = new ApprovalService(new DataManger());
            SendBackService = new SendBackService(new DataManger());


            //2-9-2021
            RegisterService = new RegisterService(new DataManger());
            //13-9-2021
            TabVerifyAcceptService = new TabVerifyAcceptService(new DataManger());

            //14-9-2021
            TabVerifyAcceptDetailsService = new TabVerifyAcceptDetailsService(new DataManger());


            //27-9-2021
            EmpRoleTypeService = new EmpRoleTypeService(new DataManger());
            //6-10-2021
            RemarkDetailsService = new RemarkDetailsService(new DataManger());


        }
    }
}
