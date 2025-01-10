using SolutionModule_1.ViewModels;

namespace SolutionModule_1.Views
{
    public sealed partial class SolutionModule_1View
    {
        public SolutionModule_1View(SolutionModule_1ViewModel viewModel)
        {
            DataContext = viewModel;
            InitializeComponent();
        }
    }
}