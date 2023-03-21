using System;
using System.Windows.Forms;

namespace app
{
    public partial class Form1 : Form
    {

        int number;
        String convertRoman;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtNumber.Text = "0";
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            try
            {
                // Validamos que no este vacio o nulo
                if (String.IsNullOrEmpty(txtNumber.Text)) throw new Exception("No se aceptan campos vacíos.");
                // Guardamos el número en una variable
                number = int.Parse(txtNumber.Text);
                // Validamos que no sea mayor o igual a 4000
                if (number >= 4000) throw new Exception("No se acepta un número mayor o igual a 4000.");
                else if (number <= 0) throw (new Exception("No se acepta números menores o iguales a 0."));
                // Convertimos esta monda
                String message = $"El resultado de convertir " +
                    $"su número {txtNumber.Text} a números romanos es: ";
                message += converToRoman(number);
                MessageBox.Show(message, "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Convertimos el número a numeros romanos
        public string converToRoman(int num)
        {
            /****************************************
             * Declaramos las variables necesarias *
            ****************************************/
            int units, dec, cent, uMil, temp;
            String result = "";
            /****************************
             * Separamos las U. de mil *
             * Centens y Decenas       *
            ****************************/
            uMil = num / 1000;
            cent = num / 100;
            dec = num / 10;
            /***************************
             * Separamos las unidades *
            ***************************/
            temp = num % 1000; // Por si tiene en unidades
            temp = temp % 100; // Por si tiene en decenas
            units = temp % 10;
            /* Hacemos las validaciones por U. mil */
            switch (uMil) {
                case 1:
                    result = "M";
                    break;
                case 2:
                    result = "MMM";
                    break;
                case 3:
                    result = "MMM";
                    break;
            }
            /* Hacemos las validaciones por Centenas */
            switch (cent) {
                case 1:
                    result += "C";
                    break;
                case 2:
                    result += "CC";
                    break;
                case 3:
                    result += "CC";
                    break;
                case 4:
                    result += "CD";
                    break;
                case 5:
                    result += "D";
                    break;
                case 6:
                    result += "DC";
                    break;
                case 7:
                    result += "DCC";
                    break;
                case 8:
                    result += "DCCC";
                    break;  
                case 9:
                    result += "CM";
                    break;
            }
            /* Hacemos las validaciones por Decenas */
            switch (dec) {
                case 1:
                    result += "X";
                    break;
                case 2:
                    result += "XX";
                    break;
                case 3:
                    result += "XXX";
                    break;
                case 4:
                    result += "XL";
                    break;
                case 5:
                    result += "L";
                    break;
                case 6:
                    result += "LX";
                    break;
                case 7:
                    result += "LXX";
                    break;
                case 8:
                    result += "LXXX";
                    break;
                case 9:
                    result += "XC";
                    break;
            }
            /* Hacemos las validaciones por Unidades */
            switch (units)
            {
                case 1:
                    result += "I";
                    break;
                case 2:
                    result += "II";
                    break;
                case 3:
                    result += "III";
                    break;
                case 4:
                    result += "IV";
                    break;
                case 5:
                    result += "V";
                    break;
                case 6:
                    result += "VI";
                    break;
                case 7:
                    result += "VII";
                    break;
                case 8:
                    result += "VIII";
                    break;
                case 9:
                    result += "IX";
                    break;
            }
            return result;
        }
        // Volver a ceros
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNumber.Text = "0";
        }
    }
}
