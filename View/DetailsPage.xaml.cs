using PropertyApp.Model;

namespace PropertyApp.View;

public partial class DetailsPage : ContentPage
{
    public DetailsPage()
    {
        InitializeComponent();
    }

    public DetailsPage(Property property) : this()
    {
        BindingContext = property;
    }
}
