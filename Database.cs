using System;


namespace projeto_csharp_2
{
    public class Database
    {
        public static class Database
         {
        public static List<User> Users { get; set; }
            static Database()
            {
                 Users = new List<User>();
            }
         }
    }
}