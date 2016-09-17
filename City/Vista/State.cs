using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Forms;
using Controladora;

namespace Vista
{
    public partial class State : Form
    {
        private readonly CountryController _countryController = new CountryController();
        private readonly StateController _stateController = new StateController();
        private readonly ICollection<Modelo.City> _cities = new Collection<Modelo.City>(); 

        public State()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            countryBindingSource.DataSource = _countryController.GetAll();
            stateBindingSource.DataSource = _stateController.GetAll();
            base.OnLoad(e);
        }

        private void add_Click(object sender, EventArgs e)
        {
            var state = new Modelo.State
            {
                Name =  name.Text,
                IdCountry = ((Modelo.Country)countryBindingSource.Current).IdCountry             
            };

            _stateController.Add(state);
            stateBindingSource.DataSource = _stateController.GetAll();
        }

        private void addCity_Click(object sender, EventArgs e)
        {
            var newCity = new Modelo.City
            {
                Name = city.Text
            };
            _cities.Add(newCity);

            cityBindingSource.DataSource = _cities.ToList();
        }

        private void addWithCity_Click(object sender, EventArgs e)
        {
            var state = new Modelo.State
            {
                Name = name.Text,
                IdCountry = ((Modelo.Country)countryBindingSource.Current).IdCountry,
                Cities = _cities
            };

            _stateController.Add(state);
            stateBindingSource.DataSource = _stateController.GetAll();
        }
    }
}
