using Autodesk.Revit.Attributes;
using Nice3point.Revit.Toolkit.External;
using SolutionModule_1.ViewModels;
using SolutionModule_1.Views;

namespace Solution_15.Commands
{
    [UsedImplicitly]
    [Transaction(TransactionMode.Manual)]
    public class StartupCommand : ExternalCommand
    {
        public override void Execute()
        {
            var viewModel = new SolutionModule_1ViewModel();
            var view = new SolutionModule_1View(viewModel);
            view.ShowDialog();
        }
    }
}