using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace _3d_t_Victory_SC_M
{
    public partial class CreateForm : MetroForm
    {
        public CreateForm()
        {
            InitializeComponent();
            this.Style = MetroFramework.MetroColorStyle.Yellow;
        }

        private void CreateForm_Load(object sender, EventArgs e)
        {

        }

        private void CreateForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }

        private void CreateForm_Resize(object sender, EventArgs e)
        {
            tlCcreate.Size = new Size(this.ClientSize.Width, this.ClientSize.Height);
            tlCcreate.Padding = new Padding(10);
        }

        private void btnDisadv_Click(object sender, EventArgs e)
        {
            DisadvantagesForm disadvantagesForm = new DisadvantagesForm();
            disadvantagesForm.Show();
        }

        private void btnAdv_Click(object sender, EventArgs e)
        {
            AdvantagesForm advantagesForm = new AdvantagesForm();
            advantagesForm.Show();
        }

        private void btnTechniques_Click(object sender, EventArgs e)
        {
            TechniquesForm techniquesForm = new TechniquesForm();
            techniquesForm.Show();
        }

        private void btnArtifact_Click(object sender, EventArgs e)
        {
            ArtifactForm artifactForm = new ArtifactForm();
            artifactForm.Show();
        }

        private void btnKit_Click(object sender, EventArgs e)
        {
            KitForm kitForm = new KitForm();   
            kitForm.Show();
        }
    }
}
