namespace MauiAppHotel
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            NavigationPage navigationPage = new(new Views.ContratacaoHospedagem());
            MainPage = navigationPage;
        }
        
        protected override Window CreateWindow(IActivationState? activationState)
        {


            var window = base.CreateWindow(activationState);

            window.Width = 400;
            window.Height = 600;

            return window;
           
        }
    }
}