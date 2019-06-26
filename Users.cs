using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautyShop
{
    class Users
    {
        //получение массива всех пользоваталей
        public static User[] GetAllUsers()
        {
            using (BeautyShopEntities db = new BeautyShopEntities())
            {
                return db.User.OrderBy(user => user.UserName).ToArray();                
            }
        }

        //задел на будущее         
        static void AddUser(User user) 
        {
            using (BeautyShopEntities db = new BeautyShopEntities())
            {
                db.User.Add(user);
                db.SaveChanges();                
            }
        }



        //проверка пароля
        public static bool ValidatePassword(User user, string password)
        {
            //временное решение - нужно будет исправить, когда будем хранить пароли хэшированными
            return (HashPassoword(user.Password).Equals(HashPassoword(password)));            
        }

        private static string HashPassoword(string original) 
        {
            //временное решение - использование стандарной функции
            return original.GetHashCode().ToString();
        }


    }
}
