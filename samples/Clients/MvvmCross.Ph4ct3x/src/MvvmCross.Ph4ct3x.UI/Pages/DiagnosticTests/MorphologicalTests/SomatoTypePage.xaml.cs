using MvvmCross.Forms.Presenters.Attributes;
using MvvmCross.Forms.Views;
using MvvmCross.Ph4ct3x.Core.ViewModels.DiagnosticTests.MorphologicalTests;
using Xamarin.Forms.Xaml;

namespace MvvmCross.Ph4ct3x.UI.Pages.DiagnosticTests.MorphologicalTests
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    [MvxMasterDetailPagePresentation(Position = MasterDetailPosition.Detail, NoHistory = true, Title = "Somato Type Page")]
    public partial class SomatoTypePage : MvxContentPage<SomatoTypePageViewModel>
    {
        public SomatoTypePage()
        {
            InitializeComponent();
        }
    }
}
