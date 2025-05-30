using MauiAppHotel.Models;

namespace MauiAppHotel
{
    public partial class App : Application
    {
        public List<Quarto> Lista_quartos = new List<Quarto>


        {

            new Quarto()
            {
                Descrição= "Suíte Super Luxo",
                ValorDiariaAdulto= 110.0,
                ValorDiariaCrianca= 55.0


            },

             new Quarto()
            {
                Descrição= "Suíte Luxo",
                ValorDiariaAdulto= 80.0,
                ValorDiariaCrianca= 40.0


            },

              new Quarto()
            {
                Descrição= "Suíte Single",
                ValorDiariaAdulto= 50.0,
                ValorDiariaCrianca= 25


            },
               new Quarto()
            {
                Descrição= "Suíte Crise",
                ValorDiariaAdulto= 25,
                ValorDiariaCrianca= 12.5


            }
        };
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