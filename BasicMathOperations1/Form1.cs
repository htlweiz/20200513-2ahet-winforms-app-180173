using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicMathOperations1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int number1, number2, result;

            /* Version 1 (Runtime Error)
            number1 = Convert.ToInt32(txtNumber1.Text);
            number2 = Convert.ToInt32(txtNumber2.Text);
            result = number1 + number2;
            lblResult.Text = Convert.ToString(result);
            lblResultType.Text = "Summe";
            */

            /* Version 2 (Wert wird 0 gesetzt)
            Int32.TryParse(txtNumber1.Text, out number1);
            Int32.TryParse(txtNumber2.Text, out number2);
            result = number1 + number2;
            lblResult.Text = Convert.ToString(result);
            lblResultType.Text = "Summe";
            */

            try
            {
                number1 = Convert.ToInt32(txtNumber1.Text);
                number2 = Convert.ToInt32(txtNumber2.Text);
                result = number1 + number2;
                lblResult.Text = Convert.ToString(result);
                lblResultType.Text = "Summe";
            }
            catch (Exception ex)
            {
                lblResultType.Text = "Fehler";
                lblResult.Text = "Kein numerischer Wert!";

                MessageBox.Show(ex.Message, "Eingabefehler", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtNumber1.Focus();
                txtNumber1.SelectAll();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear textboxes  and set  focus

            txtNumber1.Text = "0";
            txtNumber2.Text = "0";
            lblResultType.Text = "Ergebnis";
            lblResult.Text = "";
            txtNumber1.Focus();
            txtNumber1.SelectAll();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            int number1, number2, result;
            try
            {
                number1 = Convert.ToInt32(txtNumber1.Text);
                number2 = Convert.ToInt32(txtNumber2.Text);
                result = number1 - number2;
                lblResult.Text = Convert.ToString(result);
                lblResultType.Text = "Differenz";
            }
            catch (Exception ex)
            {
                lblResultType.Text = "Fehler";
                lblResult.Text = "Kein numerischer Wert!";

                MessageBox.Show(ex.Message, "Eingabefehler", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtNumber1.Focus();
                txtNumber1.SelectAll();
            }
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            int number1, number2, result;
            try
            {
                number1 = Convert.ToInt32(txtNumber1.Text);
                number2 = Convert.ToInt32(txtNumber2.Text);
                result = number1 * number2;
                lblResult.Text = Convert.ToString(result);
                lblResultType.Text = "Produkt";
            }
            catch (Exception ex)
            {
                lblResultType.Text = "Fehler";
                lblResult.Text = "Kein numerischer Wert!";

                MessageBox.Show(ex.Message, "Eingabefehler", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtNumber1.Focus();
                txtNumber1.SelectAll();
            }
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            int number1, number2, result;
            try
            {
                number1 = Convert.ToInt32(txtNumber1.Text);
                number2 = Convert.ToInt32(txtNumber2.Text);
                result = number1 / number2;
                lblResult.Text = Convert.ToString(result);
                lblResultType.Text = "Quotient";
            }
            catch (Exception ex)
            {
                lblResultType.Text = "Fehler";
                lblResult.Text = "Kein numerischer Wert!";

                MessageBox.Show(ex.Message, "Eingabefehler", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtNumber1.Focus();
                txtNumber1.SelectAll();
            }
        }

        private void btnPotenz_Click(object sender, EventArgs e)
        {
            double number1, number2, result;
            try
            {
                number1 = Convert.ToDouble(txtNumber1.Text);
                number2 = Convert.ToDouble(txtNumber2.Text);
                if ((number1 == 0) && (number2 <= 0))
                {
                    MessageBox.Show("Ergebnis nicht definiert!", "Eingabefehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    result = Math.Pow(number1, number2);
                    lblResult.Text = Convert.ToString(result);
                    lblResultType.Text = "Ergebnis";
                }
            }
            catch (Exception ex)
            {
                lblResultType.Text = "Fehler";
                lblResult.Text = "Kein numerischer Wert!";
                MessageBox.Show(ex.Message, "Eingabefehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumber1.Focus();
                txtNumber1.SelectAll();
            }
            
            
        }

        private void btnWurzel_Click(object sender, EventArgs e)
        {
            int number1, number2;
            double result;

            try
            {
                number1 = Convert.ToInt32(txtNumber1.Text);
                number2 = Convert.ToInt32(txtNumber2.Text);

                if (number1 == 0) throw new ArgumentException("Division durch Null");
                else if (number2 < 0) throw new ArgumentException("Negativer Radikand");

                result = Math.Pow(number2, ((double)1 / number1));
                lblResult.Text = result.ToString("n12");
                lblResultType.Text = "Wurzel";
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumber1.Focus();
                txtNumber1.SelectAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Eingabefehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumber1.Focus();
                txtNumber1.SelectAll();
            }
        }
    }
}
