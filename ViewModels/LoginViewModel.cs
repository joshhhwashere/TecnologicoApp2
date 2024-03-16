using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace TecnologicoApp.ViewModels
{
    internal class LoginViewModel
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public string Email { get; set; }
        public string Password { get; set; }

        public ICommand LoginCommand { get; }

        public LoginViewModel()
        {
            LoginCommand = new Command<string>(OnLogin);
        }

        void OnLogin(string email)
        {
            // Validaciones de correo electrónico y contraseña aquí
            if (IsValidEmail(email) && IsValidPassword(Password))
            {
                // Procesar inicio de sesión
                Console.WriteLine("Inicio de sesión exitoso");
            }
            else
            {
                Console.WriteLine("Inicio de sesión fallido");
            }
        }

        bool IsValidEmail(string email)
        {
            // Validar formato de correo electrónico
            // (puede implementar una validación más robusta según sus requisitos)
            return !string.IsNullOrWhiteSpace(email) && email.Contains("@") && email.Contains(".");
        }

        bool IsValidPassword(string password)
        {
            // Validar la contraseña
            // (puede implementar una validación más robusta según sus requisitos)
            return !string.IsNullOrWhiteSpace(password) &&
                   password.Length >= 8 &&
                   ContainsLetter(password) &&
                   ContainsNumber(password) &&
                   ContainsSymbol(password);
        }

        bool ContainsLetter(string input)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(input, "[a-zA-Z]");
        }

        bool ContainsNumber(string input)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(input, @"\d");
        }

        bool ContainsSymbol(string input)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(input, @"[^\w\d\s]");
        }
    }
}
