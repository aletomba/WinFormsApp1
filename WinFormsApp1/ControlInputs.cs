using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    class ControlInputs
    {
        public static void Validar(Control formulario, Button button)
        {
            bool vacio = false;
            foreach (Control oControls in formulario.Controls) 
            {
                if (oControls is TextBox & oControls.Text == String.Empty) 
                {
                    vacio = true; 
                }
            }
            if (vacio == true)
            {
                MessageBox.Show("Favor de llenar todos los campos."); 
                vacio = false;
            }
            else
            {
                button.Enabled = true;
                _ = button.BackColor.B;
            }
        }

        public static void ErrorHandler(TextBox textBox,  ErrorProvider error1)
        {
            if (textBox.Text == "" || textBox.Text.Any(char.IsDigit))
            {         
                error1.SetError(textBox, "debe ingresar un nombre");
                textBox.Focus();
                return;
            }
            else
            {
                error1.SetError(textBox, "");
            }

        }
    }
}
