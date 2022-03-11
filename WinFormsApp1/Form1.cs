using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        Registrodedatos registrodedatos = new Registrodedatos();

        public Form1()
        {
            InitializeComponent();
            button1.Enabled = false;             
        }

        private void button1_Acept(object sender, EventArgs e)
        {
            registrodedatos.Name = txtName.Text;
            registrodedatos.Lastname = txttLastName.Text;
            registrodedatos.DateOfBirth = DateTime.Parse(DateOfBirth.Text);
            registrodedatos.Country = CountrySelector.Text;  
            registrodedatos.Age = registrodedatos.AgeCalculator(DateTime.Parse(DateOfBirth.Text));

            MessageBox.Show("los datos se han guardado exitosamente");           
        }     
     

        private void radioButtonYes_CheckedChanged(object sender, EventArgs e)
        {
            registrodedatos.Studies = radioButtonYes.Text;
            ControlInputs.Validar(Form, button1);
        }


        private void radioButtonNo_CheckedChanged(object sender, EventArgs e)
        {
            registrodedatos.Studies = radioButtonNo.Text;
            ControlInputs.Validar(Form, button1);
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txttLastName.Clear();
            txtAge.Clear();
            DateOfBirth.ResetText();
            CountrySelector.ResetText();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            ControlInputs.ErrorHandler(txtName, error1);
        }

        private void txttLastName_TextChanged(object sender, EventArgs e)
        {
            ControlInputs.ErrorHandler(txttLastName, error1);
        }

        private void btnCalcAge_Click(object sender, EventArgs e)
        {
            txtAge.Text = registrodedatos.AgeCalculator(DateTime.Parse(DateOfBirth.Text)).ToString();           
        }      
    }
}
