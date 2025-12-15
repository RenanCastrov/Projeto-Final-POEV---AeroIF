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
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Infra.ConfigureDI.ConfigureServices();
            var mainForm = new MainForm();

            // Obtém a instância única do MaterialSkinManager
            var materialSkinManager = MaterialSkinManager.Instance;

            // Adiciona o formulário principal para que o Manager possa aplicar o tema.
            materialSkinManager.AddFormToManage(mainForm);

            // Define o tema e o esquema de cores que serão usados (Exemplo de Light Theme)
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.BlueGrey800, Primary.BlueGrey900,
                Primary.BlueGrey500, Accent.LightBlue200,
                TextShade.WHITE);
            Application.Run(new MainForm());
        }
    }
}