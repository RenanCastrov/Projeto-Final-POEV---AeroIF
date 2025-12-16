using MaterialSkin;

namespace AeroIF.App
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Infra.ConfigureDI.ConfigureServices();
            var mainForm = new MainForm();

            var materialSkinManager = MaterialSkinManager.Instance;

            materialSkinManager.AddFormToManage(mainForm);

            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.BlueGrey800, Primary.BlueGrey900,
                Primary.BlueGrey500, Accent.LightBlue200,
                TextShade.WHITE);
            Application.Run(new MainForm());
        }
    }
}