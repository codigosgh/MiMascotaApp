using MiMascotaMaui.Models;
using MiMascotaMaui.PageModels;

namespace MiMascotaMaui.Pages
{
    public partial class MainPage : ContentPage
    {
        public MainPage(MainPageModel model)
        {
            InitializeComponent();
            BindingContext = model;
        }
    }
}