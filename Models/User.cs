namespace Day_23_Coffee_Shop_Registration_Lab.Models
{
    public class User
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string userEmail { get; set; }
        public string userPassword { get; set; }
        public bool userAgree { get; set; }
        public string favCoffee { get; set; }
        public DateOnly userBirthday { get; set; }


    }
}
