using AeroIF.App.Infra;
using AeroIF.App.Other;
using AeroIF.App.Register;
using AeroIF.Domain.Base;
using AeroIF.Domain.Entities;
using MaterialSkin;
using MaterialSkin.Controls;
using Microsoft.Extensions.DependencyInjection;
using ReaLTaiizor.Forms;

namespace AeroIF.App
{
    public partial class MainForm : MaterialSkin.Controls.MaterialForm
    {
        public static User User { get; internal set; }

        public MainForm()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.ColorScheme = new ColorScheme(
                // Primary: Define a cor da Barra de Título. Use um tom de Verde (Green 700 e 800 são boas escolhas)
                Primary.Green700,
                Primary.Green800,
                // LightPrimary: Tom mais claro usado em alguns elementos de fundo
                Primary.Green500,
                // Accent: Define a cor de destaque (botões, sliders, etc.)
                Accent.LightGreen200,
                // TextShade: Cor do texto (WHITE ou BLACK)
                TextShade.WHITE
            );
            LoadLogin();
        }

        public MainForm(IBaseService<User> baseService, IServiceProvider sp)
        {
        }

        private void LoadLogin()
        {
            var login = ConfigureDI.serviceProvider!.GetService<Login>();
            if (login != null && !login.IsDisposed)
            {
                if (login.ShowDialog() != DialogResult.OK)
                {
                    Environment.Exit(0);
                }
                else
                {
                    MessageBox.Show($"Welcome, {User.Name}!", "AeroIF", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void ExibeFormulario<TFormulario>() where TFormulario : Form
        {
            if (ConfigureDI.serviceProvider == null)
            {
                MessageBox.Show("O Service Provider não foi inicializado!", "Erro de DI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                var cad = ConfigureDI.serviceProvider.GetRequiredService<TFormulario>();

                if (!cad.IsDisposed)
                {
                    cad.MdiParent = this;
                    cad.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Falha: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExibeFormulario<UserForm>();
        }

        private void pilotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExibeFormulario<PilotForm>();
        }

        private void cityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExibeFormulario<CityForm>();
        }

        private void airportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExibeFormulario<AirportForm>();
        }

        private void aircraftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExibeFormulario<AircraftForm>();
        }

        private void flightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExibeFormulario<FlightForm>();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void toolStripAboutButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Developed by Renan Avelino de Castro Andrade\n2025 © AeroIF", "About AeroIF", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
