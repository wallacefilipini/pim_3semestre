using System;


namespace DAL.Model
{
    public class Usuario
    {
        public int User_id { get; set; }
        public String Name { get; set; }
        public String Email { get; set; }
        public String Password { get; set; }
        public DateTime Created_at { get; set; }
        public DateTime Update_at { get; set; }
        public DateTime Deleted_at { get; set; }
    }
}
