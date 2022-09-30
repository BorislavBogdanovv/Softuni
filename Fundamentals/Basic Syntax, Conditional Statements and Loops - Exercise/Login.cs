using System;

namespace Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = string.Empty;                     //празен стринг

            for (int i = username.Length-1; i >= 0; i--)        //четем дължината на стринга наобратно, като .Length - 1 ни дава последния индекс от username
            {
                char currentCharacter = username[i];            
                password += currentCharacter;                   //добавяме всеки символ от username към password
            }

            int invalidTries = 1;                               //брояч за брой въведени грешни пароли
            string enteredPassword;                             // = null - няма стойност, не е и празен стринг! (празна променлива)
            while ((enteredPassword = Console.ReadLine()) != password)   //1во - чете се ред от конзолата, 2ро - записва се в enteredPassword
            {

                if (invalidTries >= 4)
                {
                    Console.WriteLine($"User {username} blocked!");      //ако въведем 4 пъти грешна парола, изписваме че юсъра е блокиран
                    return;
                }
                else
                {
                    Console.WriteLine("Incorrect password. Try again.");                                  
                }

                invalidTries++; 
            }

            Console.WriteLine($"User {username} logged in.");
        }
    }
}
