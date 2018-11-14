namespace Enunmo.Infraestructure
{
    using ViewModels;

        public class InstaceLocator

    {

        #region Properties
        public MainViewModel Main
        {
            get;
            set;
        }
        #endregion

        #region Constructors
        public InstaceLocator()
        {
            this.Main = new MainViewModel();
        }
        
        #endregion
    } 
    
}
