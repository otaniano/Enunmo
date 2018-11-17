namespace Enunmo.ViewModels
{
    using GalaSoft.MvvmLight.Command;
    using System;
    using System.ComponentModel;
    using System.Windows.Input;
    using Xamarin.Forms;
    using Views;

    public class LoginViewModel : BaseViewModel
    {
        #region Attributes
        private string usuario;
        private string contrasena;
        private bool isRunning;
        private bool isEnabled;
        private Color BackgroundColor;

        #endregion

        #region Properties
        public string Usuario
        {
            get { return this.usuario; }
            set { SetValue(ref usuario, value); }
        }
        public string Contrasena
        {
            get { return contrasena; }
            set { SetValue(ref contrasena, value); }
        }
        public bool IsRunning
        {
            get { return isRunning; }
            set { SetValue(ref isRunning, value); }
        }
        public bool Recordado
        {
            get;
            set;
        }
        public bool IsEnabled
        {
            get { return isEnabled; }
            set { SetValue(ref isEnabled, value); }

        }
       
        #endregion

        #region Constructors
        public LoginViewModel()
        {
            this.Recordado = true;
            this.IsEnabled = true;

            this.Usuario = "1234";
            this.Contrasena = "1234";
        }
        #endregion
        #region Commands
        public ICommand DomiCommand
        {
            get
            {
                return new RelayCommand(Paises);
            }
        }
        private async void Paises()
        {
            if (string.IsNullOrEmpty(this.Usuario))
            {
                await Application.Current.MainPage.DisplayAlert
                    ("Error",
                        "Algo anda mal con el usuario!!!! Revisa que la digitalización de tu usuario y contraseña sea correcta y vuelve a intentarlo.",

                        "Aceptar");
                return;
            }

            if (string.IsNullOrEmpty(this.Contrasena))
            {
                await Application.Current.MainPage.DisplayAlert
                    ("Error",
                        "Algo Anda Mal con la contraseña!!!!Revisa que la digitalización de tu usuario y contraseña sea el correcto y vuelve a intentarlo.",
                        "Aceptar");
                return;
            }


            this.IsRunning = true;
            this.IsEnabled = false;

            if (this.Usuario != "4567" || this.Contrasena != "4567")
            {
                this.IsRunning = false;
                this.IsEnabled = true;

                await Application.Current.MainPage.DisplayAlert
                    ("Error",
                        "Algo Anda Mal con la contraseña!!!!Revisa que la digitalización de tu usuario sea el correcto y vuelve a intentarlo.",
                        "Aceptar");
                this.Contrasena = string.Empty;
                return;
            }

            this.IsRunning = false;
            this.IsEnabled = true;

            this.Usuario = string.Empty;
            this.Contrasena = string.Empty;

            MainViewModel.GetInstance().Paises = new PaisesViewModel();

            await Application.Current.MainPage.Navigation.PushAsync(new PaisesPage());
        
    }
                public ICommand IngresarCommand
                {
                    get
                    {
                        return new RelayCommand(Login);
                    }
                }

                private async void Login()
                {
                    if (string.IsNullOrEmpty(this.Usuario))
            {
                await Application.Current.MainPage.DisplayAlert
                    ("Error",
                        "Algo anda mal con el usuario!!!! Revisa que la digitalización de tu usuario y contraseña sea correcta y vuelve a intentarlo.",

                        "Aceptar");
                return;
            }

                if (string.IsNullOrEmpty(this.Contrasena))
            {
                await Application.Current.MainPage.DisplayAlert
                    ("Error",
                        "Algo Anda Mal con la contraseña!!!!Revisa que la digitalización de tu usuario y contraseña sea el correcto y vuelve a intentarlo.",
                        "Aceptar");
                return;
            }


                this.IsRunning = true;
                this.IsEnabled = false;

                if (this.Usuario != "1234" || this.Contrasena != "1234")
            {
                this.IsRunning = false;
                this.IsEnabled = true;

                await Application.Current.MainPage.DisplayAlert
                    ("Error",
                        "Algo Anda Mal con la contraseña!!!!Revisa que la digitalización de tu usuario sea el correcto y vuelve a intentarlo.",
                        "Aceptar");
                this.Contrasena = string.Empty;
                return;
            }

                this.IsRunning = false;
                this.IsEnabled = true;
                    
                this.Usuario = string.Empty;
                this.Contrasena = string.Empty;

                MainViewModel.GetInstance().Principal = new PrincipalViewModel();

                await Application.Current.MainPage.Navigation.PushAsync(new PrincipalPage());
                }

        #endregion

    }
}
