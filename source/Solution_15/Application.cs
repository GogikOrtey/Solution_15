using Nice3point.Revit.Toolkit.External;
using Solution_15.Commands;

namespace Solution_15
{
    /// <summary>
    ///     Application entry point
    /// </summary>
    [UsedImplicitly]
    public class Application : ExternalApplication
    {
        public override void OnStartup()
        {
            CreateRibbon();
        }

        private void CreateRibbon()
        {
            var panel = Application.CreatePanel("Commands", "Solution_15");

            panel.AddPushButton<StartupCommand>("Execute")
                .SetImage("/Solution_15;component/Resources/Icons/RibbonIcon16.png")
                .SetLargeImage("/Solution_15;component/Resources/Icons/RibbonIcon32.png");
        }
    }
}