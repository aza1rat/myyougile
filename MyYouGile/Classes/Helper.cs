using MyYouGile.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyYouGile.Classes
{
    public static class Helper
    {
        public static User CurrentUser;
        public enum Role { Разработчик, Заказчик, Менеджер };
        public static Role UserRole;
        public static ModelDB ModelDB = new ModelDB();
        public static void GetRole(string role)
        {
            UserRole = (Role)Enum.Parse(UserRole.GetType(), role);
        }

      
    }
}
