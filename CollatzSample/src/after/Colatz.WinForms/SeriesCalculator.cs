using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Collatz.Core;

namespace Collatz.WinForms
{
    public partial class SeriesCalculator : Form
    {
        public SeriesCalculator()
        {
            InitializeComponent();
        }

        private void SeriesCalculator_Load(object sender, EventArgs e)
        {
            SeriesGridView.Visible = false;
            ErrorLabel.Visible = false;
            InitialValueTextBox.Select();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(InitialValueTextBox.Text, out int initialValue) && initialValue < 1)
            {
                string msg = "The value must be a natural number.";
                ShowErrorMessage(msg);
                return;
            }

            PopulateForm(initialValue);
        }

        public void PopulateForm(int initialValue)
        {
            var series = new CollatzSeries(initialValue);
            var steps = series.Steps;

            SeriesGridView.DataSource = steps;
            SeriesGridView.Parent.Visible = true;
            SeriesGridView.Visible = true;
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            InitialValueTextBox.Clear();
            SeriesGridView.DataSource = null;
            SeriesGridView.Visible = false;
            InitialValueTextBox.Select();
        }

        private void ShowErrorMessage(string msg)
        {
            ErrorLabel.Text = $"{msg} \n\nClick 'Clear' and try again.";
            ErrorLabel.Visible = true;
        }
    }
}
