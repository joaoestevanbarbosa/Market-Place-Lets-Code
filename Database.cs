using System;
using System.Collections.Generic;


namespace projeto_csharp_2
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