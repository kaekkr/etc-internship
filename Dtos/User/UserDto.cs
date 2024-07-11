namespace ETC_internship.Dtos.User
{
    public class UserDto
    {
        public int Id { get; set; }
        public int DepartmentId { get; set; }
        public int PositionId { get; set; }
        public int RoleId { get; set; }
        public string FullNameKZ { get; set; } = string.Empty;
        public string FullNameRU { get; set; } = string.Empty;
        public string ShortNameKZ { get; set; } = string.Empty;
        public string ShortNameRU { get; set; } = string.Empty;
        public string FIODatPadejKZ { get; set; } = string.Empty;
        public string FIODatPadejRU { get; set; } = string.Empty;
        public string IIN { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public bool IsActivated { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
