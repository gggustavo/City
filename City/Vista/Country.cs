using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controladora;

namespace Vista
{
    public partial class Country : Form
    {
        private readonly CountryController _countryController = new CountryController();

        public Country()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            countryBindingSource.DataSource = _countryController.GetAll();
            base.OnLoad(e);
        }

        private void add_Click(object sender, EventArgs e)
        {
            _countryController.Add(new Modelo.Country { Name = name.Text });

            countryBindingSource.DataSource = _countryController.GetAll();
        }

        private void remove_Click(object sender, EventArgs e)
        {
            if (countryBindingSource.Current == null) return;

            var idCountry= ((Modelo.Country)countryBindingSource.Current).IdCountry;
            _countryController.Remove(idCountry);
            countryBindingSource.DataSource = _countryController.GetAll();
        }
    }
}
