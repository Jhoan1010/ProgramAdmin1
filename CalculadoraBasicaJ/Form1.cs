using NCalc;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CalculadoraBasicaJ
{
    public partial class FormBase : Form
    {   

        public FormBase() 
        {
            InitializeComponent();
            this.Paint += new PaintEventHandler(FormBase_Paint);

        }
        private void FormBase_Load(object sender, EventArgs e)
        {
            // Inicializando variables
            textBoxIntoResult.Text = string.Empty;
            IngresoEspecial = true;
            CharActual = String.Empty;
            EspecialSQRT = false;

        }
        // VARIABLES DE CAMPO DEL FORMBASE: //////////////////////////////
        private string  CharActual;
        private bool IngresoEspecial, EspecialSQRT;
        private double ResultadoOperacion, Ans;



       //METODOS DEL FORMBASE ////////////////////////////////////////////

        // Metodo Paint del Formulario actual
        private void FormBase_Paint(object sender, PaintEventArgs e)
        {
            // Diujando el borde del textbox
            // Definiendo limintes del borde
            Rectangle rect = new Rectangle(textBoxIntoResult.Location.X - 1, textBoxIntoResult.Location.Y - 1, textBoxIntoResult.Width + 1, textBoxIntoResult.Height + 1);
            e.Graphics.DrawRectangle(Pens.Red, rect); //dibujandolo y dando su color Pens.
        }

        //EVENTOS DE FORMULARIO ////////////////////////////////////////////

        //evento que identifica la pulsacion de la tecla Enter - Intro dentro de textBoxIntoResult
        private void textBoxIntoResult_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                MetodoCalcular();
                FocusTextBox();

            }
        }

        private void FocusTextBox()
        {
            textBoxIntoResult.Focus();
            textBoxIntoResult.SelectionStart = textBoxIntoResult.Text.Length;
            textBoxIntoResult.SelectionLength = 0;
        }


        private void VerificarAddEspeciales()
        {
            if (EspecialSQRT)
            {
                if (CharActual == ")")
                {
                    textBoxIntoResult.Text += "))";
                    IngresoEspecial = true;
                    EspecialSQRT = false;
                }
                else
                {
                    textBoxIntoResult.Text += CharActual;
                  
                }
            }
        }

        private void MetodoCalcular()
        {
            try
            {
                Expression expr = new Expression(textBoxIntoResult.Text);
                ResultadoOperacion = Math.Round(Convert.ToDouble(expr.Evaluate()), 4);
                textBoxIntoResult.Text = ResultadoOperacion.ToString();
                textBoxIntoResult.Text = ResultadoOperacion.ToString();
                Ans += ResultadoOperacion;
            }
            catch (Exception ex)
            {
                textBoxIntoResult.Text = "Error";
            }
        }

        

        //Boton que calculara la operación---------------------
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            MetodoCalcular(); 
        }

        
        private void btn1_Click(object sender, EventArgs e)
        {
            if (IngresoEspecial) { textBoxIntoResult.Text += "1"; FocusTextBox(); FocusTextBox(); }
            CharActual = "";
            CharActual = "1"; VerificarAddEspeciales();


        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (IngresoEspecial) { textBoxIntoResult.Text += "2"; FocusTextBox(); };
            CharActual = "";
            CharActual = "2"; VerificarAddEspeciales();

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if ( IngresoEspecial) { textBoxIntoResult.Text += "3"; FocusTextBox(); };
            CharActual = "";
            CharActual = "3"; VerificarAddEspeciales();

        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (IngresoEspecial) { textBoxIntoResult.Text += "4"; FocusTextBox(); };
            CharActual = "";
            CharActual = "4";
            VerificarAddEspeciales();

        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (IngresoEspecial) { textBoxIntoResult.Text += "5"; FocusTextBox(); };
            CharActual = "";
            CharActual = "5"; VerificarAddEspeciales();

        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (IngresoEspecial) { textBoxIntoResult.Text += "6"; FocusTextBox(); };
            CharActual = "";
            CharActual = "6"; VerificarAddEspeciales();

        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (IngresoEspecial) { textBoxIntoResult.Text += "7"; FocusTextBox(); };
            CharActual = "";
            CharActual = "7"; VerificarAddEspeciales();

        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (IngresoEspecial) { textBoxIntoResult.Text += "8"; FocusTextBox(); };
            CharActual = "";
            CharActual = "8"; VerificarAddEspeciales();

        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (IngresoEspecial)
            {
                textBoxIntoResult.Text += "9"; FocusTextBox();
            };
            CharActual = "";
            CharActual = "9"; VerificarAddEspeciales();

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (IngresoEspecial)
            {
                textBoxIntoResult.Text += "0"; FocusTextBox();
            };
            CharActual = "";
            CharActual = "0"; VerificarAddEspeciales();

        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            if (IngresoEspecial)
            {
                textBoxIntoResult.Text += "."; FocusTextBox();
            }
                CharActual = "";
            CharActual = "."; VerificarAddEspeciales();

        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            if (IngresoEspecial)
            {
                textBoxIntoResult.Text += "-"; FocusTextBox();
            };
            CharActual = "";
            CharActual = "-"; VerificarAddEspeciales();

        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            if (IngresoEspecial)
            {
                textBoxIntoResult.Text += "+"; FocusTextBox();
            };
            CharActual = "";
            CharActual = "+"; VerificarAddEspeciales();

        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            if (IngresoEspecial) { textBoxIntoResult.Text += "*"; FocusTextBox(); };
            CharActual = "";
            CharActual = "*"; VerificarAddEspeciales();

        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            if (IngresoEspecial)
            {
                textBoxIntoResult.Text += "/"; FocusTextBox();
            };
            CharActual = "";
            CharActual = "/"; VerificarAddEspeciales();

        }

        private void btnPorciento_Click(object sender, EventArgs e)
        {
            if (IngresoEspecial)
            {
                textBoxIntoResult.Text += "/100"; FocusTextBox();
            };
            CharActual = "";
            CharActual = "/100"; VerificarAddEspeciales();

        }

        private void btnParentesisAb_Click(object sender, EventArgs e)
        {
            if (IngresoEspecial)
            {
                textBoxIntoResult.Text += "("; FocusTextBox();
            };
            CharActual = "";
            CharActual = "("; VerificarAddEspeciales();

        }

        private void btnParentesisCe_Click(object sender, EventArgs e)
        {
            if (IngresoEspecial)
            {
                textBoxIntoResult.Text += ")"; FocusTextBox();
            }; 
            CharActual = "";
            CharActual = ")";
            VerificarAddEspeciales();
        }

       

        private void btnSQRT_Click(object sender, EventArgs e)
        {

            if (IngresoEspecial)
            {
                textBoxIntoResult.Text += "(Sqrt("; FocusTextBox();
                IngresoEspecial = false;
                EspecialSQRT=true; 
            }
            
        }

        private void btnAns_Click(object sender, EventArgs e)
        {
            textBoxIntoResult.Text += Ans.ToString(); FocusTextBox();
        }

       

        private void btneExp2_Click(object sender, EventArgs e)
        {
            if (!IngresoEspecial)
            {
                // Algoritmo que calcula el ultimo par de parentesis  ......(...)
                int primerParent = -1;
                int ultimoParent = -1;
                string ecuacionExp2;

                for (int i = textBoxIntoResult.Text.Length - 1; i >= 0; i--)
                {
                    if (textBoxIntoResult.Text[i] == ')')
                    {
                        ultimoParent = i;
                        break;
                    }
                }

                for (int i = textBoxIntoResult.Text.Length - 1; i >= 0; i--)
                {
                    if (textBoxIntoResult.Text[i] == '(')
                    {
                        primerParent = i;
                        break;
                    }
                }

                //comprobar si se encontraron los paentesis ( ) 
                if (primerParent != -1 && ultimoParent != -1)
                {
                    // Calcular ecuacion a elevar al exponente 2:  
                    ecuacionExp2 = textBoxIntoResult.Text.Substring(primerParent + 1, ultimoParent - primerParent - 1);

                    // concatenar el resultado a la variale de campo 
                    textBoxIntoResult.Text += Math.Pow(double.Parse(ecuacionExp2), 2).ToString();
                };
                FocusTextBox();
            };
        }

       
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (textBoxIntoResult.Text.Length > 0)
            {
                textBoxIntoResult.Text =
                    textBoxIntoResult.Text.Remove(textBoxIntoResult.Text.Length - 1, 1);
                FocusTextBox();
            }
            else if ( textBoxIntoResult.Text.Length <= 1)
            {
                textBoxIntoResult.Text = ""; FocusTextBox();

            }
          
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            textBoxIntoResult.Text = string.Empty; 
            IngresoEspecial = true;
            CharActual = String.Empty;
            EspecialSQRT = false;
            Ans = 0;
            FocusTextBox();

        }

      

        private void textBoxIntoResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void panelBtnsFunc_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
