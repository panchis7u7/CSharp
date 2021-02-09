using System;
using System.Windows.Forms;

namespace U1_01_HolaMundo
{
    class Program
    {
        static Button btnDivertido = new Button();
        static Button btnDivertido2 = new Button();
        static Random rand = new Random();
        static int ancho = 500;
        static int alto = 500;
        static void Main(string[] args)
        {
            Form V = new Form();

            btnDivertido.Text = "No";
            btnDivertido2.Text = "Si!";
            btnDivertido.Top = alto / 2;
            btnDivertido.Left = ancho / 4;
            btnDivertido2.Top = alto / 2;
            btnDivertido2.Left = 2 * ancho / 3;
            V.Height = alto;
            V.Width = ancho;
            Label preg = new Label();
            preg.Width = 500;
            preg.Text = "Quieres ser mi novia?";
            preg.Font = new System.Drawing.Font(preg.Font.Name, 14F);
            preg.Top = alto / 4;
            preg.Left = ancho / 4;
            btnDivertido.MouseMove += mouseHoverInvoked;
            btnDivertido2.MouseClick += (s, e) =>
            {
                for (int i = 0; i < 400; i++)
                {
                    TextBox tx = new TextBox();
                    tx.Text = "Me compras makis?";
                    tx.Show();
                    tx.Top = rand.Next(0, alto - 50);
                    tx.Left = rand.Next(0, ancho - 50);
                    V.Controls.Add(tx);
                }
            };
            V.Controls.Add(preg);
            V.Controls.Add(btnDivertido);
            V.Controls.Add(btnDivertido2);
            Application.Run(V);
        }

        static void mouseHoverInvoked(object sender, MouseEventArgs e)
        {
            var btn = sender as Button;
            btn.Top = rand.Next(0, alto - 50);
            btn.Left = rand.Next(0, ancho - 50);
            //Console.Beep(440,500);
        }
    }
}
