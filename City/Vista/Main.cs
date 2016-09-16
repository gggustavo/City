using System;
using System.Windows.Forms;

namespace Vista
{
    public partial class Main : Form
    {

        public Main()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
        }

        private void ciudadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var city = new City();
            city.ShowDialog();
        }

        private void provinciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var state = new State();
            state.ShowDialog();
        }

        private void paisesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var country = new Country();
            country.ShowDialog();
        }
    }
}
