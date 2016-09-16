using System;
using System.Windows.Forms;
using Controladora;

namespace Vista
{
    public partial class State : Form
    {
        private readonly CountryController _countryController = new CountryController();
        private readonly StateController _stateController = new StateController();

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
                IdCountry = ((Modelo.Country)countryBindingSource.Current).IdCountry,
            };

            _stateController.Add(state);
            stateBindingSource.DataSource = _stateController.GetAll();
        }
    }
}
