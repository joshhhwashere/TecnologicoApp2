namespace TecnologicoApp.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void OnLoginButtonClicked(object sender, EventArgs e)
        {
            string email = emailEntry.Text;
            string password = passwordEntry.Text;

            // Realizar validaciones de correo electrónico y contraseña aquí
            if (!IsValidEmail(email))
            {
                DisplayAlert("Error", "Por favor, ingrese un correo electrónico válido.", "OK");
                return;
            }

            if (!IsValidPassword(password))
            {
                DisplayAlert("Error", "La contraseña debe contener al menos una letra, un número y un símbolo.", "OK");
                return;
            }

            // Lógica para iniciar sesión
            // Por ejemplo, navegar a la siguiente página
            Navigation.PushAsync(new NextPage());
        }

        private bool IsValidEmail(string email)
        {
            // Implementar lógica de validación de correo electrónico
            // Puede utilizar expresiones regulares o bibliotecas de validación de correo electrónico
            // Aquí se proporciona un ejemplo simple:
            return !string.IsNullOrEmpty(email) && email.Contains("@") && email.Contains(".");
        }

        private bool IsValidPassword(string password)
        {
            // Implementar lógica de validación de contraseña
            // Aquí se proporciona un ejemplo simple:
            return !string.IsNullOrEmpty(password) && password.Length >= 8 && ContainsLetter(password) && ContainsNumber(password) && ContainsSymbol(password);
        }

        private bool ContainsLetter(string str)
        {
            // Implementar lógica para verificar si la cadena contiene al menos una letra
            foreach (char c in str)
            {
                if (char.IsLetter(c))
                {
                    return true;
                }
            }
            return false;
        }

        private bool ContainsNumber(string str)
        {
            // Implementar lógica para verificar si la cadena contiene al menos un número
            foreach (char c in str)
            {
                if (char.IsDigit(c))
                {
                    return true;
                }
            }
            return false;
        }

        private bool ContainsSymbol(string str)
        {
            // Implementar lógica para verificar si la cadena contiene al menos un símbolo
            // Puede utilizar expresiones regulares o una lista de símbolos permitidos
            // Aquí se proporciona un ejemplo simple:
            foreach (char c in str)
            {
                if (!char.IsLetterOrDigit(c))
                {
                    return true;
                }
            }
            return false;
        }
    }

}
