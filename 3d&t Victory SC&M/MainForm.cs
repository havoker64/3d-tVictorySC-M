using MetroFramework.Forms;
using System.Windows.Forms;

namespace _3d_t_Victory_SC_M
{
    public partial class MainForm : MetroForm
    {
        public MainForm()
        {
            InitializeComponent();
            this.Style = MetroFramework.MetroColorStyle.Yellow;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            tlMain.Size = new Size(this.ClientSize.Width, this.ClientSize.Height);
            tlMain.Padding = new Padding(10);
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            this.Hide();

            CreateForm createForm = new CreateForm();

            createForm.Show();
        }
    }
}
