using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BoilerSupplier.HelperMethod
{
    public class Class
    {
    }

    #region Public Methods

    public enum ModuleId : int
    {
        Admission = 1,
        Enquiry = 2,
        Fees = 3,
        Student = 4,
        Vendor = 5
    }

    public enum EnquiryActivityType : int
    {
        Call = 1,
        Email = 2,
        Meeting = 3,
        Other = 4
    }
    public enum ImageSize : int
    {
        Icon = 50,
        Small = 100,
        Medium = 200,
        Large = 500
    }

    public enum Gender
    {
        Male,
        Female
    }

    public enum MailChimpEmailTemplates
    {
        Blank,
        AdmissionFormSubmissionMail,
        AdmissionConfirmationMail,
        AdmissionRejectionMail
    }

    public enum ImageNameExtension
    {
        Logo,
        Avatar,
        Barcode,
        FormPhoto,
        Student
    }

    public enum SmsFormat
    {
        Password,
        ResumeOTP,
        Success_Enquiry_Form_Submission,
        Success_Admission_Form_Submission,
        Form_Payment_Successful,
        Form_Payment_Failed,
        Fees_Payment_Success,
        Fees_Payment_Failed,
        Resume_Admission,
        Form_Ending_Message,
        Enquiry_Fee_Request,
        Discount_Coupon,
        Customer_Communication
    }
    public enum EmailFormats
    {
        Form_Payment_Success,
        Form_Payment_Failed,
        Enquiry,
        Form_Confirmation,
        Form_Rejection,
        Form_Status,
        Event_Scheduling,
        Event_Action,
        Document_Rejection,
        Form_Message,
        Fees_Payment_Success,
        Fees_Payment_Failed,
        Resume_Admission,
        ScheduledCommunication,
        Discount_Coupon,
        Customer_Communication,
        EnquiryAssignment
    }
    public enum EventStatus : int
    {
        Scheduled = 1,
        Completed = 2,
        Not_Reported = 3,
        Cancelled = 4
    }
    public enum DocumentStatus : int
    {
        Pending = 0,
        Approved = 1,
        Rejected = 2,
    }
    public enum ChecklistType : int
    {
        Form_Verification = 1,
        Document_Verification = 2,
        Others = 3,
    }
    public enum ActionObject
    {
        Student,
        Employee,
        User,
        Institute,
        Enquiry,
        EnquiryActivity,
        Module,
        Menu,
        Master,
        Vendor,
        Status_Followups
    }
    public enum DeviceType
    {
        Mobile,
        WebBrowser,
    }

    public enum EnquiryType
    {
        Online,
        Direct,
        Partner
    }

    //public enum EnquiryStatus
    //{
    //    Open = 1,
    //    Converted = 2,
    //    Failed = 3,
    //    Deleted = 4,
    //    Progress = 5
    //}
    public enum Role : int
    {
        Super_Administrator = 1,
        Administrator = 2,
        Student = 3,
        Receptionist = 7,
        Executive_Superintendent = 8
    }
    public enum FieldType : int
    {
        Textbox = 1,
        TextArea = 2,
        Checkbox = 3,
        DropDown = 4,
        RadioButton = 5,
        File = 6,
        Contact = 7,
        Email = 8,
        Date = 9,
        Number = 10,
        Hidden = 11,
        Autocomplete = 12,
        DynamicList = 13
    }
    public enum RadiaButton
    {
        Gender,
        SiblingSameSchool,
        PhysicallyChallenged
    }
    public enum DynamicFiledBelongsTo
    {
        Enquiry,
        Admission,
    }

    public enum DropDownList
    {
        Nationality,
        Qalification,
        FatherQalification,
        MotherQalification,
        Occupation,
        FatherOccupation,
        MotherOccupation,
        BloodGroup,
        SessionId,
        ClassID,
        SourceID,
        Category,
        Profession,
        Branch
    }
    public enum PaymentStatus : int
    {
        Pending = 1,
        Success = 2,
        Failed = 3,
    }
    public enum Quota : int
    {
        General = 1,
        Management = 2,
    }
    public enum NotificationType
    {
        warning,
        success,
        danger,
    }
    public enum GenericAdmissionSettings
    {
        Settings,
        ExtendedSettings,
        Section,
        Field,
        Checklist,
        FormStatus,
        Document,
        EnquiryField,
        EnquirySettings,
        EnquiryStatus,
        Configurations,
        Quota,
        Category,
        Rule,
        FeeSetting,
        FeeStructure,
        FeesDiscount,
        FeesInstallment,
        InstallmentCount,
        Branch,
        VendorCategory,
        VendorType,
        Attachments,
        Tag,
        Source
    }
    public enum FormStatusType : int
    {
        Others = 0,
        Verification = 1,
        Shortlisted = 2,
        Rejected = 3,
        Admitted = 4,
    }
    public enum LetterFormats
    {
        Offer_Letter,
    }
    public enum Recharge
    {
        Email,
        Sms
    }
    public enum CommunicationType
    {
        Sms,
        Email
    }
    public enum CommunicationModule
    {
        Enquiry,
        Form,
        Common,
        Student,
        Fees,
        Vendor
    }
    public enum FormulaSymbol : int
    {
        Equal = 1,
        LessThan = 2,
        GreaterThan = 3
    }
    public enum RuleType : int
    {
        Rule = 1,
        Formula = 2,
    }
    public enum FeesType : int
    {
        Annual = 1,
        Admission = 2,
        Installment = 3,
        Optional = 4
    }
    public enum TransactionType : int
    {
        Online = 1,
        Offline = 2,
    }
    public enum OnlinePaymentType : int
    {
        AdmissionForm = 1,
        OnlineFees = 2
    }
    public enum UserType : int
    {
        User = 1,
        Student = 2
    }
    public enum LateChargeAction : int
    {
        Waive,
        Revert
    }
    public enum PaymentMode
    {
        Cash = 1,
        Cheque = 2,
        DemandDraft = 3,
        Voucher = 4,
        Neft = 5,
        Debit = 7,
        Credit = 8,
        Online = 9
    }
    public enum FineType : int
    {
        Other = 1,
        Late = 2,
        Bounce = 3,
    }
    public enum EnquiryFormType : int
    {
        Online = 1,
        Offline = 2,
        Short = 3,
    }
    public enum LeadType
    {
        Facebook_Lead,
        Twitter_Lead,
        JustDial_Lead,
        Zopim,
        MyOperator,
        JustDial,
        Sulekha,
        Shiksha,
        MagicBricks,
        IndiaMart,
        Olark,
        LiveChat,
        Email,
        TradeIndia
    }
    public enum ResultStatus
    {
        Success,
        Failed,
        Duplicate
    }
    public enum FetchType
    {
        Zopin,
        Olark,
        LiveChat,
        MyOperator,
        Email
    }
    public enum CouponType
    {
        Admission,
        Main
    }

    public enum InstituteType
    {
        School = 1,
        Preschool = 2,
        PreschoolSchool = 3,
        Business = 4
    }
    public enum EnquiryNotificationMethod
    {
        Both = 1,
        Mail = 2,
        Message = 3,
    }
    public enum TargetParameterType
    {
        Course = 1,
        Revenue = 2,
        Collection = 3,
        Walkin = 4,
        Event = 5,
        TalentHunt = 6
    }

    #endregion Public Methods
}
