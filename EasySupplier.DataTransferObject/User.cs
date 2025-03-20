namespace BoilerSupplier.DataTransferObject
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public decimal UserRole { get; set; }
        public string Email { get; set; }
        public string EmailId { get; set; }
        public decimal MobileNo { get; set; }
        public string PasswordHash { get; set; }
        public string Password { get; set; }
        public string UserId { get; set; }
        public bool Active { get; set; }
        public bool Exists { get; set; }

        public int PageSize { get; set; }
        public int CurrentPage { get; set; }
        public string MODE { get; set; }

        //vinod added 15-3-2021
        public string EmailAddress { get; set; }
        public string PreferredUserID { get; set; }

        //26-7-2021
        public string InviteID { get; set; }
        public string SubmitFlag { get; set; }

        //-----------------------Tabfields--------


        public int RelationID { get; set; }
        public int OrganisationID { get; set; }
        public int TabID { get; set; }
        public int FieldID { get; set; }

        public string Label { get; set; }
        public bool Required { get; set; }
        public string Placeholder { get; set; }
        public string Tooltip { get; set; }
        public bool Status { get; set; }
        public bool Enabled { get; set; }
        public decimal Ordering { get; set; }
        public string ContainerCssClass { get; set; }

        public bool Show { get; set; }
        public bool Public { get; set; }
        public bool Short { get; set; }

    }
}
