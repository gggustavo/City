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
    public partial class City : Form
    {

        private readonly StateController _stateController = new StateController();
        private readonly CityController _cityController = new CityController();

        public City()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            stateBindingSource.DataSource = _stateController.GetAll();
            cityBindingSource.DataSource = _cityController.GetAll();
            base.OnLoad(e);
        }


        private void add_Click(object sender, EventArgs e)
        {
            var city = new Modelo.City
            {
                IdState = ((Modelo.State)stateBindingSource.Current).IdState,
                Name = name.Text
            };

            _cityController.Add(city);
            cityBindingSource.DataSource = _cityController.GetAll();
        }
    }
}
