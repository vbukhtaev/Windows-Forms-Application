using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class AdminMenu : Form
    {
        private bool frms;
        public AdminMenu()
        {
            InitializeComponent();
        }

        private void citiesButton_Click(object sender, EventArgs e)
        {
            frms = Application.OpenForms.Cast<Form>().Select(x => x.Name).Contains("Cities");
            if (!frms)
            {
                Cities citiesForm = new Cities();
                citiesForm.Show();
            }
        }

        private void manufacturersButton_Click(object sender, EventArgs e)
        {
            frms = Application.OpenForms.Cast<Form>().Select(x => x.Name).Contains("Manufacturers");
            if (!frms)
            {
                Manufacturers manufacturersForm = new Manufacturers();
                manufacturersForm.Show();
            }
        }

        private void airportsButton_Click(object sender, EventArgs e)
        {
            frms = Application.OpenForms.Cast<Form>().Select(x => x.Name).Contains("Airports");
            if (!frms)
            {
                Airports airportsForm = new Airports();
                airportsForm.Show();
            }
        }

        private void planesButton_Click(object sender, EventArgs e)
        {
            frms = Application.OpenForms.Cast<Form>().Select(x => x.Name).Contains("Planes");
            if (!frms)
            {
                Planes planesForm = new Planes();
                planesForm.Show();
            }
        }

        private void flightsButton_Click(object sender, EventArgs e)
        {
            frms = Application.OpenForms.Cast<Form>().Select(x => x.Name).Contains("Flights");
            if (!frms)
            {
                Flights flightsForm = new Flights();
                flightsForm.Show();
            }
        }

        private void ticketsButton_Click(object sender, EventArgs e)
        {
            frms = Application.OpenForms.Cast<Form>().Select(x => x.Name).Contains("Tickets");
            if (!frms)
            {
                Tickets ticketsForm = new Tickets();
                ticketsForm.Show();
            }
        }
    }
}
