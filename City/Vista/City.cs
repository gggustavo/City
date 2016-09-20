using System;
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

       
        private void filterName_KeyPress(object sender, KeyPressEventArgs e)
        {
            cityBindingSource.DataSource = _cityController.GetAllByName(filterName.Text);
        }

        private void remove_Click(object sender, EventArgs e)
        {
            if (cityBindingSource.Current == null) return;

            var idCity = ((Modelo.City) cityBindingSource.Current).IdCity;
            _cityController.Remove(idCity);
            cityBindingSource.DataSource = _cityController.GetAll();
        }
    }
}
