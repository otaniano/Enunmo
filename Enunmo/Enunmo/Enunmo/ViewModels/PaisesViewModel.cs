namespace Enunmo.ViewModels
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Windows.Input;
    using GalaSoft.MvvmLight.Command;
    using Models;
    using Services;
    using Xamarin.Forms;

    public class PaisesViewModel : BaseViewModel
    {
        #region Services
        private ApiService apiService;
        #endregion
        #region Attributes
        private ObservableCollection<Pais> paises;
        private bool isRefreshing;
        #endregion

        #region Properties
        public ObservableCollection<Pais> Paises

        {
            get { return this.paises; }
            set { SetValue(ref paises, value); }
        }

        public bool IsRefreshing

        {
            get { return this.isRefreshing; }
            set { SetValue(ref isRefreshing, value); }
        }
        #endregion
        #region Constuctors
        public PaisesViewModel()
        {
            this.apiService = new ApiService();
            this.LoadPaises();
        }
        #endregion
        #region Methods

        private async void LoadPaises()
        {
            this.IsRefreshing = true;
            var connection = await this.apiService.CheckConnection();
            if (!connection.IsSuccess)
            {
                this.IsRefreshing = false;
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    connection.Message,
                    "Aceptar");
                await Application.Current.MainPage.Navigation.PopAsync();
                return;
            }

            var response = await this.apiService.GetList<Pais>(
                "http://restcountries.eu",
                "/rest",
                "/v2/all");
            if (!response.IsSuccess)
            {

                this.IsRefreshing = false;
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    response.Message,
                    "Aceptar");
                await Application.Current.MainPage.Navigation.PopAsync();

                return;
            }

            var list = (List<Pais>)response.Result;
            this.Paises = new ObservableCollection<Pais>(list);
            this.IsRefreshing = false;
        }

        #endregion
        #region Commands
        public ICommand RefreshCommand
        {
            get
            { 
                return new RelayCommand(LoadPaises);
            }
        }
        #endregion
    }
}
