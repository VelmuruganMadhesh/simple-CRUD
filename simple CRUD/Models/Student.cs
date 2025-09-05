namespace simple_CRUD.Models
{
    public class Student
    {
        public int id { get; set; }
        public string name { get; set; } = string.Empty;
        public int age { get; set; }
        public string email { get; set; }= string.Empty;
        public string phone { get; set; } = string.Empty;
        public string password { get; set; } = string.Empty;
        public bool isactive { get; set; }
        public DateTime DOB { get; set; }
    }
}
