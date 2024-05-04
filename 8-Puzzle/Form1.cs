using System;
using System.Linq;
using System.Windows.Forms;

namespace _8_Puzzle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblCont.Text = movimientos.ToString(); //Actualizar la cantidad de movimientos hechos
        }

        //Variables que indican que botón fue presionado
        private bool boton1 = false;
        private bool boton2 = false;
        private bool boton3 = false;
        private bool boton4 = false;
        private bool boton5 = false;
        private bool boton6 = false;
        private bool boton7 = false;
        private bool boton8 = false;
        private bool boton9 = false;

        int movimientos = 0;    //Contar la cantidad de intentos

        //Metodo para realizar el intercambio del botón presionado con el blanco
        public void Intercambio(Button origen, Button destino)
        {
            string aux; //Variable para realizar en intercambio

            if(origen.Text != "") //Si el boton presionado no esta vacio
            {
                if(destino.Text == "")  //Si el boton destino esta vacio, se hará el cambio
                {
                    aux = origen.Text;
                    origen.Text = "";
                    destino.Text = aux;
                }
            }
        }

        public void EstadoFinal()
        {
            //Evalua si se ha llegado al estado objetivo
            if (btn1.Text == "1" && btn2.Text == "2" && btn3.Text == "3"
                && btn4.Text == "8" && btn5.Text == "" && btn6.Text == "4" 
                && btn7.Text == "7" && btn8.Text == "6" && btn9.Text =="5") 
            {
                MessageBox.Show("Felicidades, lograste completar el Puzzle en: "+movimientos+" movimientos");
            }
        }

        public static class Prompt
        {
            //Clase que permite crear una ventana para que el usuario ingrese datos
            public static string ShowDialog(string text, string caption)
            {
                Form prompt = new Form()
                {
                    Width = 500,
                    Height = 150,
                    FormBorderStyle = FormBorderStyle.FixedDialog,
                    Text = caption,
                    StartPosition = FormStartPosition.CenterScreen
                };
                Label textLabel = new Label() { Left = 50, Top = 20, Text = text };
                TextBox textBox = new TextBox() { Left = 50, Top = 50, Width = 400 };
                Button confirmation = new Button() { Text = "Ok", Left = 350, Width = 100, Top = 70, DialogResult = DialogResult.OK };
                confirmation.Click += (sender, e) => { prompt.Close(); };
                prompt.Controls.Add(textBox);
                prompt.Controls.Add(confirmation);
                prompt.Controls.Add(textLabel);
                prompt.AcceptButton = confirmation;

                return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            boton1 = true; //se ha presionado el botón 1

            movimientos++; //actualizar la cantidad de movimientos
            lblCont.Text = movimientos.ToString();

            /*Indica los movimientos permitidos en este boton en especifico.
             El primer boton indicado es el boton en si y el siguiente es por el que se puede intercambiar*/
            Intercambio(btn1, btn2);
            Intercambio(btn1, btn4);

            //Cada que se realiza un movimiento, se verifica si se ha llegado al estado objetivo
            EstadoFinal();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            boton2 = true; //Se presionó el botón 2

            movimientos++;
            lblCont.Text = movimientos.ToString();

            Intercambio(btn2, btn1);
            Intercambio(btn2, btn3);
            Intercambio(btn2, btn5);
            EstadoFinal();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            boton3 = true;

            movimientos++;
            lblCont.Text = movimientos.ToString();

            Intercambio(btn3, btn6);
            Intercambio (btn3, btn2);
            EstadoFinal();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            boton4 = true;

            movimientos++;
            lblCont.Text = movimientos.ToString();

            Intercambio(btn4, btn1);
            Intercambio(btn4, btn5);
            Intercambio(btn4, btn7);
            EstadoFinal();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            boton5 = true;

            movimientos++;
            lblCont.Text = movimientos.ToString();

            Intercambio(btn5, btn2);
            Intercambio(btn5, btn4);
            Intercambio(btn5, btn6);
            Intercambio(btn5, btn8);
            EstadoFinal();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            boton6 = true;

            movimientos++;
            lblCont.Text = movimientos.ToString();

            Intercambio(btn6, btn3);
            Intercambio(btn6, btn5);
            Intercambio(btn6, btn9);
            EstadoFinal();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            boton7 = true;

            movimientos++;
            lblCont.Text = movimientos.ToString();

            Intercambio(btn7, btn4);
            Intercambio(btn7, btn8);
            EstadoFinal();
        }
        private void btn8_Click(object sender, EventArgs e)
        {
            boton8 = true;

            movimientos++;
            lblCont.Text = movimientos.ToString();

            Intercambio(btn8, btn5);
            Intercambio(btn8, btn7);
            Intercambio(btn8, btn9);
            EstadoFinal();
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            boton9 = true;

            movimientos++;
            lblCont.Text = movimientos.ToString();

            Intercambio(btn9, btn6);
            Intercambio (btn9, btn8);
            EstadoFinal();
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            //Al presionar el boton de "reasignar botones", se ejecuta uno por uno una ventana que permite al usuario darle un valor a los botones
            string promptValue1 = Prompt.ShowDialog("Boton 1", "");
            btn1.Text = promptValue1;
            string promptValue2 = Prompt.ShowDialog("Boton 2", "");
            btn2.Text = promptValue2;
            string promptValue3 = Prompt.ShowDialog("Boton 3", "");
            btn3.Text = promptValue3;
            string promptValue4 = Prompt.ShowDialog("Boton 4", "");
            btn4.Text = promptValue4;
            string promptValue5 = Prompt.ShowDialog("Boton 5", "");
            btn5.Text = promptValue5;
            string promptValue6 = Prompt.ShowDialog("Boton 6", "");
            btn6.Text = promptValue6;
            string promptValue7 = Prompt.ShowDialog("Boton 7", "");
            btn7.Text = promptValue7;
            string promptValue8 = Prompt.ShowDialog("Boton 8", "");
            btn8.Text = promptValue8;
            string promptValue9 = Prompt.ShowDialog("Boton 9", "");
            btn9.Text = promptValue9;
        }

        private void btnrst_Click(object sender, EventArgs e)
        {
            //Reinicia la ventana a su estado original
            while (Controls.Count > 0)
            {
                //Reinicia el numero de movimientos
                movimientos = 0;

                Controls[0].Dispose();
            }
            InitializeComponent();
        }
    }
}
