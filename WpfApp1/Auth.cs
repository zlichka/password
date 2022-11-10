using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using static System.Net.Mime.MediaTypeNames;

namespace WpfApp1
{
    public class Auth
    {
        public string TestPassword(string password)
        {

            //варианты для тестирования пароля:

            //1. fj3#Lp - короткий пароль
            if (password.Length < 7)
            {
                return "Пароль короткий!";
            }
            //2. lfT#35glox4 - длинный пароль
            if (password.Length > 10)
            {
                return "Пароль длинный!";
            }
            //3. ok#hjkKJH - пароль не содержит цифры
            bool IsDigit = false;
            //4. fkjg03k# - пароль не содержит символы в верхнем регистре
            bool IsUpper = false;
            //5. HGJ34LKJ# - пароль не содержит символы в нижнем регистре
            bool IsLower = false;
            //6. df3gdF8GD - пароль не содержит спецсимволы
            bool IsSpec = false;
            foreach (var item in password)
            {
                if (char.IsDigit(item))
                {
                    IsDigit = true;
                }
                if (char.IsUpper(item))
                {
                    IsUpper = true;
                }
                if (char.IsLower(item))
                {
                    IsLower = true;
                }
                if ("@#$%^&".Contains(item))
                {
                    IsSpec = true;
                }
            }
            if (!IsDigit)
            {
                return "Пароль должен содержать цифры!";
            }
            if (!IsLower)
            {
                return "Пароль должен содержать символы в нижнем регистре!";
            }
            if (!IsUpper)
            {
                return "Пароль должен содержать символы в верхнем регистре!";
            }
            if (!IsSpec)
            {
                return "Пароль должен содержать спецсимволы!";
            }
            //7. Kt@@bj7F - пароль содержит повторяющиеся символы
            for (int i = 0; i < password.Length - 1; i++)
            {
                if (password[i] == password[i + 1])
                {
                    return "В пароле не должно быть подряд идущих повторяющихся символов!";
                }

            }
            //8. GT$k8f74 - пароль соответствует всем требованиям
            return "Пароль отличный!";
        }
    }
}
