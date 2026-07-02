using PropertyApp.ViewModel;

namespace PropertyApp.View;

public partial class LandingPage : ContentPage
{
    public LandingPage()
    {
        InitializeComponent();
        BindingContext = new LandingViewModel();

        if (SectionList.Children.Count > 0 && SectionList.Children[0] is RadioButton firstSection)
        {
            firstSection.IsChecked = true;
        }
    }
}
