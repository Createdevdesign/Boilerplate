using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BoilerSupplier.Business;
using BoilerSupplier.CrossCutting;
using BoilerSupplier.DataTransferObject;
namespace BoilerSupplier.Webapi.Controllers
{
   
    [Route("api/[controller]")]
    [ApiController]
    public class VendorController : ControllerBase
    {
        // GET: api/<VendorController>
        [HttpGet]
        public IEnumerable<Vendor> Get(Vendor vendor)
        {
            var VendorService = ServiceProxy.VendorService;
            var VendorData = VendorService.GetAllVendorData(
                new Vendor
                {
                    


                    GSTIN = vendor.GSTIN,
                    PANNo = vendor.PANNo,
                    VATRegistration = vendor.VATRegistration ,
                    TaxNumber = vendor.TaxNumber,
                    Country = vendor.Country,
                    Title = vendor.Title,
                    OrganisationType = vendor.OrganisationType ,
                    EstablishmentName = vendor.EstablishmentName,
                    ShortName = vendor.ShortName,
                    NoofEmployees = vendor.NoofEmployees,
                    CompUrl = vendor.CompUrl,
                    CompEmailID = vendor.CompEmailID,
                    HouseNo = vendor.HouseNo,
                    OfficeAddress = vendor.OfficeAddress,
                    Street2 = vendor.Street2,
                    Street3 = vendor.Street3,
                    RegState = vendor.RegState,
                    RegCity = vendor.RegCity,
                    RegPostalCode = vendor.RegPostalCode,
                    CompTelephoneNo = vendor.CompTelephoneNo,
                    CompMobileNo = vendor.CompMobileNo,
                    FaxNo = vendor.FaxNo,
                    SupplierType = vendor.SupplierType,

                    //Bank Info
                    BankCountry = vendor.BankCountry,
                    Currency = vendor.Currency,
                    BeneficiaryName = vendor.BeneficiaryName,
                    BeneficiaryAccountNo = vendor.BeneficiaryAccountNo,
                    BankName = vendor.BankName,
                    BeneficiaryBranch = vendor.BeneficiaryBranch,
                    BeneficiaryAddress = vendor.BeneficiaryAddress,
                    AccountType = vendor.AccountType,
                    IFSCCode = vendor.IFSCCode,
                    SWIFTBICCode = vendor.SWIFTBICCode,
                    //Fin Info
                    RegistrationDate = vendor.RegistrationDate,
                    FinancialYear1 = vendor.FinancialYear1,
                    FinancialYear2 = vendor.FinancialYear2,
                    FinancialYear3 = vendor.FinancialYear3,
                    Profit1 = vendor.Profit1,
                    Profit2 = vendor.Profit2,
                    Profit3 = vendor.Profit3,
                    Turnover1 = vendor.Turnover1,
                    Turnover2 = vendor.Turnover2,
                    Turnover3 = vendor.Turnover3,
                    OnlineCatalog = vendor.OnlineCatalog,
                    OnlineOrdering = vendor.OnlineOrdering,
                    OnlineOrderTracking = vendor.OnlineOrderTracking,
                    OnlineEauctions = vendor.OnlineEauctions,
                    MinorityIndicatorName = vendor.MinorityIndicatorName,
                    MinorityIndicatorDate = vendor.MinorityIndicatorDate,
                    //Certification
                    ISO27001 = vendor.ISO27001,
                    DateISO27001 = vendor.DateISO27001,
                    ISO9001 = vendor.ISO9001,
                    DateISO9001 = vendor.DateISO9001,
                    C9100 = vendor.C9100,
                    DateC9100 = vendor.DateC9100,
                    QMSAvailableAtTheSuppliersSite = vendor.QMSAvailableAtTheSuppliersSite,
                    EnvironmentManagementSystem = vendor.EnvironmentManagementSystem,
                    WorkersCompensationInsurancePolicy = vendor.WorkersCompensationInsurancePolicy,
                    OwnSuppliersAndSubContractors = vendor.OwnSuppliersAndSubContractors,
                    PublicLiabilityInsurancePolicy = vendor.PublicLiabilityInsurancePolicy,
                    SupplierDueDiligenceRequirements = vendor.SupplierDueDiligenceRequirements,
                    IndemnityInsurancePolicy = vendor.IndemnityInsurancePolicy,
                    QualityEnvironmentalStandards = vendor.QualityEnvironmentalStandards,
                    //References
                    RefCustomersName = vendor.RefCustomersName,
                    RefContactPerson = vendor.RefContactPerson,
                    RefDesignation = vendor.RefDesignation,
                    RefContactNo = vendor.RefContactNo,
                    RefEmailID = vendor.RefEmailID,
                    //Additional
                    MOB = vendor.MOB,
                    WOB = vendor.WOB,
                    VOB = vendor.VOB,
                    LGBTOB = vendor.LGBTOB,
                    SDVOB = vendor.SDVOB,
                    SB = vendor.SB,
                    SDB = vendor.SDB,
                    WOSB = vendor.WOSB,
                    HUSB = vendor.HUSB,
                    VOSB = vendor.VOSB,
                    SDVOSB = vendor.SDVOSB,
                    EDWOSB = vendor.EDWOSB,
                    MBE = vendor.MBE,
                    DBE = vendor.DBE,
                    SBE = vendor.SBE,
                    SWAM = vendor.SWAM,
                    LGBT = vendor.LGBT,
                    SupplyAnyOtherTTL = vendor.SupplyAnyOtherTTL,
                    NameofCompanies = vendor.NameofCompanies,
                    TypeofWorkDone = vendor.TypeofWorkDone,

                    PageSize = 10,
                    CurrentPage = 1,
                    MODE = "U"
                });
            return VendorData;
        }

        // GET api/<VendorController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }
        // POST api/<VendorController>
        [HttpPost]
        //public void Post([FromBody] Vendor vendor)
        public ActionResult<IEnumerable<Vendor>> Post([FromBody] Vendor vendor)
        {
            if (vendor.TabIndex == 0)
            {
                ActionResult response;
                var VendorService = ServiceProxy.VendorService;
                var VendorData = VendorService.GetAllVendorData(
                    new Vendor
                    {

                        TabIndex = vendor.TabIndex,
                        LoginEmailID = vendor.LoginEmailID,
                        //Info
                        GSTIN = vendor.GSTIN,
                        PANNo = vendor.PANNo,
                        VATRegistration = vendor.VATRegistration,
                        TaxNumber = vendor.TaxNumber,
                        Country = vendor.Country,
                        Title = vendor.Title,
                        OrganisationType = vendor.OrganisationType,
                        EstablishmentName = vendor.EstablishmentName,
                        ShortName = vendor.ShortName,
                        NoofEmployees = vendor.NoofEmployees,
                        CompUrl = vendor.CompUrl,
                        CompEmailID = vendor.CompEmailID,
                        HouseNo = vendor.HouseNo,
                        OfficeAddress = vendor.OfficeAddress,
                        Street2 = vendor.Street2,
                        Street3 = vendor.Street3,
                        RegState = vendor.RegState,
                        RegCity = vendor.RegCity,
                        RegPostalCode = vendor.RegPostalCode,
                        CompTelephoneNo = vendor.CompTelephoneNo,
                        CompMobileNo = vendor.CompMobileNo,
                        FaxNo = vendor.FaxNo,
                        SupplierType = vendor.SupplierType,


                        PageSize = 10,
                        CurrentPage = 1,
                        MODE = "I"
                    });
                if (VendorData.Count > 0)
                {
                    response = Ok(new
                    {
                        status = 0,
                        data = VendorData

                    });
                }
                else
                {
                    response = Ok(new
                    {
                        status = 1,
                        data = VendorData

                    });
                }


                return response;
            }
            else if (vendor.TabIndex == 1)
            {
                ActionResult response;
                var VendorService = ServiceProxy.VendorService;
                var VendorData = VendorService.GetAllVendorData(
                    new Vendor
                    {

                        TabIndex = vendor.TabIndex,
                        LoginEmailID = vendor.LoginEmailID,

                        //Bank Info
                        BankCountry = vendor.BankCountry.ToString(),
                        Currency = vendor.Currency.ToString(),
                        BeneficiaryName = vendor.BeneficiaryName.ToString(),
                        BeneficiaryAccountNo = vendor.BeneficiaryAccountNo.ToString(),
                        BankName = vendor.BankName.ToString(),
                        BeneficiaryBranch = vendor.BeneficiaryBranch.ToString(),
                        BeneficiaryAddress = vendor.BeneficiaryAddress.ToString(),
                        AccountType = vendor.AccountType.ToString(),
                        IFSCCode = vendor.IFSCCode.ToString(),
                        SWIFTBICCode = vendor.SWIFTBICCode.ToString(),

                        PageSize = 10,
                        CurrentPage = 1,
                        MODE = "I"
                    });

                if (VendorData.Count > 0)
                {
                    response = Ok(new
                    {
                        status = 0,
                        data = VendorData

                    });
                }
                else
                {
                    response = Ok(new
                    {
                        status = 1,
                        data = VendorData

                    });
                }
                return response;
            }
            else if (vendor.TabIndex == 2)
            {
                ActionResult response;
                var VendorService = ServiceProxy.VendorService;
                var VendorData = VendorService.GetAllVendorData(
                    new Vendor
                    {

                        TabIndex = vendor.TabIndex,
                        LoginEmailID = vendor.LoginEmailID,

                        //Fin Info
                        RegistrationDate = vendor.RegistrationDate,
                        FinancialYear1 = vendor.FinancialYear1,
                        FinancialYear2 = vendor.FinancialYear2,
                        FinancialYear3 = vendor.FinancialYear3,
                        Profit1 = vendor.Profit1,
                        Profit2 = vendor.Profit2,
                        Profit3 = vendor.Profit3,
                        Turnover1 = vendor.Turnover1,
                        Turnover2 = vendor.Turnover2,
                        Turnover3 = vendor.Turnover3,
                        OnlineCatalog = vendor.OnlineCatalog,
                        OnlineOrdering = vendor.OnlineOrdering,
                        OnlineOrderTracking = vendor.OnlineOrderTracking,
                        OnlineEauctions = vendor.OnlineEauctions,
                        MinorityIndicatorName = vendor.MinorityIndicatorName,
                        MinorityIndicatorDate = vendor.MinorityIndicatorDate,


                        PageSize = 10,
                        CurrentPage = 1,
                        MODE = "I"
                    });

                if (VendorData.Count > 0)
                {
                    response = Ok(new
                    {
                        status = 0,
                        data = VendorData

                    });
                }
                else
                {
                    response = Ok(new
                    {
                        status = 1,
                        data = VendorData

                    });
                }
                return response;
            }
            else if (vendor.TabIndex == 3)
            {
                ActionResult response;
                var VendorService = ServiceProxy.VendorService;
                var VendorData = VendorService.GetAllVendorData(
                    new Vendor
                    {

                        TabIndex = vendor.TabIndex,
                        LoginEmailID = vendor.LoginEmailID,

                        //Certification
                        ISO27001 = vendor.ISO27001,
                        DateISO27001 = vendor.DateISO27001,
                        ISO9001 = vendor.ISO9001,
                        DateISO9001 = vendor.DateISO9001,
                        C9100 = vendor.C9100,
                        DateC9100 = vendor.DateC9100,
                        QMSAvailableAtTheSuppliersSite = vendor.QMSAvailableAtTheSuppliersSite,
                        EnvironmentManagementSystem = vendor.EnvironmentManagementSystem,
                        WorkersCompensationInsurancePolicy = vendor.WorkersCompensationInsurancePolicy,
                        OwnSuppliersAndSubContractors = vendor.OwnSuppliersAndSubContractors,
                        PublicLiabilityInsurancePolicy = vendor.PublicLiabilityInsurancePolicy,
                        SupplierDueDiligenceRequirements = vendor.SupplierDueDiligenceRequirements,
                        IndemnityInsurancePolicy = vendor.IndemnityInsurancePolicy,
                        QualityEnvironmentalStandards = vendor.QualityEnvironmentalStandards,


                        PageSize = 10,
                        CurrentPage = 1,
                        MODE = "I"
                    });

                if (VendorData.Count > 0)
                {
                    response = Ok(new
                    {
                        status = 0,
                        data = VendorData

                    });
                }
                else
                {
                    response = Ok(new
                    {
                        status = 1,
                        data = VendorData

                    });
                }
                return response;
            }
            else if (vendor.TabIndex == 4)
            {
                ActionResult response;
                var VendorService = ServiceProxy.VendorService;
                var VendorData = VendorService.GetAllVendorData(
                    new Vendor
                    {

                        TabIndex = vendor.TabIndex,
                        LoginEmailID = vendor.LoginEmailID,

                        //References
                        RefCustomersName = vendor.RefCustomersName,
                        RefContactPerson = vendor.RefContactPerson,
                        RefDesignation = vendor.RefDesignation,
                        RefContactNo = vendor.RefContactNo,
                        RefEmailID = vendor.RefEmailID,


                        PageSize = 10,
                        CurrentPage = 1,
                        MODE = "I"
                    });

                if (VendorData.Count > 0)
                {
                    response = Ok(new
                    {
                        status = 0,
                        data = VendorData

                    });
                }
                else
                {
                    response = Ok(new
                    {
                        status = 1,
                        data = VendorData

                    });
                }
                return response;
            }
            else if (vendor.TabIndex == 5)
            {
                ActionResult response;
                var VendorService = ServiceProxy.VendorService;
                var VendorData = VendorService.GetAllVendorData(
                    new Vendor
                    {

                        TabIndex = vendor.TabIndex,
                        LoginEmailID = vendor.LoginEmailID,

                        //Additional
                        MOB = vendor.MOB,
                        WOB = vendor.WOB,
                        VOB = vendor.VOB,
                        LGBTOB = vendor.LGBTOB,
                        SDVOB = vendor.SDVOB,
                        SB = vendor.SB,
                        SDB = vendor.SDB,
                        WOSB = vendor.WOSB,
                        HUSB = vendor.HUSB,
                        VOSB = vendor.VOSB,
                        SDVOSB = vendor.SDVOSB,
                        EDWOSB = vendor.EDWOSB,
                        MBE = vendor.MBE,
                        DBE = vendor.DBE,
                        SBE = vendor.SBE,
                        SWAM = vendor.SWAM,
                        LGBT = vendor.LGBT,
                        SupplyAnyOtherTTL = vendor.SupplyAnyOtherTTL,
                        NameofCompanies = vendor.NameofCompanies,
                        TypeofWorkDone = vendor.TypeofWorkDone,

                        PageSize = 10,
                        CurrentPage = 1,
                        MODE = "I"
                    });

                if (VendorData.Count > 0)
                {
                    response = Ok(new
                    {
                        status = 0,
                        data = VendorData

                    });
                }
                else
                {
                    response = Ok(new
                    {
                        status = 1,
                        data = VendorData

                    });
                }
                return response;
            }
            else if (vendor.TabIndex == 6)
            {
                ActionResult response;
                var VendorService = ServiceProxy.VendorService;
                var VendorData = VendorService.GetAllVendorData(
                    new Vendor
                    {

                        TabIndex = vendor.TabIndex,
                        LoginEmailID = vendor.LoginEmailID,



                        PageSize = 10,
                        CurrentPage = 1,
                        MODE = "I"
                    });

                if (VendorData.Count > 0)
                {
                    response = Ok(new
                    {
                        status = 0,
                        data = VendorData

                    });
                }
                else
                {
                    response = Ok(new
                    {
                        status = 1,
                        data = VendorData

                    });
                }
                return response;
            }
            else if (vendor.TabIndex == 7)
            {
                ActionResult response;
                var VendorService = ServiceProxy.VendorService;
                var VendorData = VendorService.GetAllVendorData(
                    new Vendor
                    {

                        TabIndex = vendor.TabIndex,
                        LoginEmailID = vendor.LoginEmailID,


                        PageSize = 10,
                        CurrentPage = 1,
                        MODE = "I"
                    });

                if (VendorData.Count > 0)
                {
                    response = Ok(new
                    {
                        status = 0,
                        data = VendorData

                    });
                }
                else
                {
                    response = Ok(new
                    {
                        status = 1,
                        data = VendorData

                    });
                }
                return response;
            }

            //28-8-2021
            else if (vendor.TabIndex == 9)
            {
                ActionResult response;
                var VendorService = ServiceProxy.VendorService;
                var VendorData = VendorService.GetAllVendorData(
                    new Vendor
                    {

                        TabIndex = vendor.TabIndex,
                        LoginEmailID = vendor.LoginEmailID,


                        PageSize = 10,
                        CurrentPage = 1,
                        MODE = "I"
                    });

                if (VendorData.Count > 0)
                {
                    response = Ok(new
                    {
                        status = 0,
                        data = VendorData

                    });
                }
                else
                {
                    response = Ok(new
                    {
                        status = 1,
                        data = VendorData

                    });
                }
                return response;
            }
            else
            {
                ActionResult response;
                response = Ok(new
                {
                    status = 2,

                });
                return response;
            }


            //else 
            //{
            //    ActionResult response;
            //    var VendorService = ServiceProxy.VendorService;
            //    var VendorData = VendorService.GetAllVendorData(
            //        new Vendor
            //        {

            //            TabIndex = vendor.TabIndex,
            //            LoginEmailID = vendor.LoginEmailID,
            //            //Info
            //            GSTIN = vendor.GSTIN,
            //            PANNo = vendor.PANNo,
            //            VATRegistration = vendor.VATRegistration,
            //            TaxNumber = vendor.TaxNumber,
            //            Country = vendor.Country,
            //            Title = vendor.Title,
            //            OrganisationType = vendor.OrganisationType,
            //            EstablishmentName = vendor.EstablishmentName,
            //            ShortName = vendor.ShortName,
            //            NoofEmployees = vendor.NoofEmployees,
            //            CompUrl = vendor.CompUrl,
            //            CompEmailID = vendor.CompEmailID,
            //            HouseNo = vendor.HouseNo,
            //            OfficeAddress = vendor.OfficeAddress,
            //            Street2 = vendor.Street2,
            //            Street3 = vendor.Street3,
            //            RegState = vendor.RegState,
            //            RegCity = vendor.RegCity,
            //            RegPostalCode = vendor.RegPostalCode,
            //            CompTelephoneNo = vendor.CompTelephoneNo,
            //            CompMobileNo = vendor.CompMobileNo,
            //            FaxNo = vendor.FaxNo,
            //            SupplierType = vendor.SupplierType,
            //        //Bank Info
            //        BankCountry = vendor.BankCountry,
            //            Currency = vendor.Currency,
            //            BeneficiaryName = vendor.BeneficiaryName,
            //            BeneficiaryAccountNo = vendor.BeneficiaryAccountNo,
            //            BankName = vendor.BankName,
            //            BeneficiaryBranch = vendor.BeneficiaryBranch,
            //            BeneficiaryAddress = vendor.BeneficiaryAddress,
            //            AccountType = vendor.AccountType,
            //            IFSCCode = vendor.IFSCCode,
            //            SWIFTBICCode = vendor.SWIFTBICCode,
            //        //Fin Info
            //        RegistrationDate = vendor.RegistrationDate,
            //            FinancialYear1 = vendor.FinancialYear1,
            //            FinancialYear2 = vendor.FinancialYear2,
            //            FinancialYear3 = vendor.FinancialYear3,
            //            Profit1 = vendor.Profit1,
            //            Profit2 = vendor.Profit2,
            //            Profit3 = vendor.Profit3,
            //            Turnover1 = vendor.Turnover1,
            //            Turnover2 = vendor.Turnover2,
            //            Turnover3 = vendor.Turnover3,
            //            OnlineCatalog = vendor.OnlineCatalog,
            //            OnlineOrdering = vendor.OnlineOrdering,
            //            OnlineOrderTracking = vendor.OnlineOrderTracking,
            //            OnlineEauctions = vendor.OnlineEauctions,
            //            MinorityIndicatorName = vendor.MinorityIndicatorName,
            //            MinorityIndicatorDate = vendor.MinorityIndicatorDate,
            //        //Certification
            //        ISO27001 = vendor.ISO27001,
            //            DateISO27001 = vendor.DateISO27001,
            //            ISO9001 = vendor.ISO9001,
            //            DateISO9001 = vendor.DateISO9001,
            //            C9100 = vendor.C9100,
            //            DateC9100 = vendor.DateC9100,
            //            QMSAvailableAtTheSuppliersSite = vendor.QMSAvailableAtTheSuppliersSite,
            //            EnvironmentManagementSystem = vendor.EnvironmentManagementSystem,
            //            WorkersCompensationInsurancePolicy = vendor.WorkersCompensationInsurancePolicy,
            //            OwnSuppliersAndSubContractors = vendor.OwnSuppliersAndSubContractors,
            //            PublicLiabilityInsurancePolicy = vendor.PublicLiabilityInsurancePolicy,
            //            SupplierDueDiligenceRequirements = vendor.SupplierDueDiligenceRequirements,
            //            IndemnityInsurancePolicy = vendor.IndemnityInsurancePolicy,
            //            QualityEnvironmentalStandards = vendor.QualityEnvironmentalStandards,
            //        //References
            //        RefCustomersName = vendor.RefCustomersName,
            //            RefContactPerson = vendor.RefContactPerson,
            //            RefDesignation = vendor.RefDesignation,
            //            RefContactNo = vendor.RefContactNo,
            //            RefEmailID = vendor.RefEmailID,
            //        //Additional
            //        MOB = vendor.MOB,
            //            WOB = vendor.WOB,
            //            VOB = vendor.VOB,
            //            LGBTOB = vendor.LGBTOB,
            //            SDVOB = vendor.SDVOB,
            //            SB = vendor.SB,
            //            SDB = vendor.SDB,
            //            WOSB = vendor.WOSB,
            //            HUSB = vendor.HUSB,
            //            VOSB = vendor.VOSB,
            //            SDVOSB = vendor.SDVOSB,
            //            EDWOSB = vendor.EDWOSB,
            //            MBE = vendor.MBE,
            //            DBE = vendor.DBE,
            //            SBE = vendor.SBE,
            //            SWAM = vendor.SWAM,
            //            LGBT = vendor.LGBT,
            //            SupplyAnyOtherTTL = vendor.SupplyAnyOtherTTL,
            //            NameofCompanies = vendor.NameofCompanies,
            //            TypeofWorkDone = vendor.TypeofWorkDone,

            //            PageSize = 10,
            //            CurrentPage = 1,
            //            MODE = "I"
            //        });

            //    if (VendorData.Count > 0)
            //    {
            //        response = Ok(new
            //        {
            //            status = 0,
            //            data = VendorData

            //        });
            //    }
            //    else
            //    {
            //        response = Ok(new
            //        {
            //            status = 1,
            //            data = VendorData

            //        });
            //    }
            //    return response;
            //}   
        }

        // PUT api/<VendorController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<VendorController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
