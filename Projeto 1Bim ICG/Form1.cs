/********************************************************************
 *Colegio Técnico Antônio Teixeira Fernandes (Univap)
 *Curso Técnico em Informática - Data de Entrega: 27 / 03 / 2024
 * Autores do Projeto: Vitor Lucas Kohls Correa
 *                     Isabelly Pacheco Marino
 *
 * Turma: 2F
 * Atividade Proposta em aula
 * Observação:
 * 
 * 
 ********************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_1Bim
{
    public partial class Form1 : Form
    {
        int WIDTH;
        int HEIGHT;

        int m;
        int b;

        int retas_count = 1;

        int offset = -25;

        bool draw_line;

        public Form1()
        {
            InitializeComponent();
        }


        Pen GetColor(int r, int g, int b)
        {
            Color color = Color.FromArgb(r, g, b);
            return new Pen(color);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            WIDTH = ActiveForm.Size.Width;
            HEIGHT = ActiveForm.Size.Height;
        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            int[] MouseCoords = Form2PlaneCoords(MousePosition.X, MousePosition.Y);
            Form1.ActiveForm.Text = "Plane Coords: {" + MouseCoords[0] + ", " + MouseCoords[1] + "} ";

            MouseCoords = Plane2FormsCoords(MouseCoords[0], MouseCoords[1]);
            Form1.ActiveForm.Text += "  Form Coords: {" + MouseCoords[0] + ", " + MouseCoords[1] + "} ";
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            DrawAxis(e);

            if (draw_line)
            {
                Pen pen = GetColor(0, 0, 0);
                PrepareLine(pen, e);
                draw_line = false;
            }
        }


        int f(int x)
        {
            return m * x + b;
        }
        int[] Plane2FormsCoords(int x, int y)
        {
            y *= -1;
            x += WIDTH / 2;
            y += HEIGHT / 2;

            return new int[] { x, y };
        }
        int[] Form2PlaneCoords(int x, int y)
        { 
            x -= WIDTH / 2;
            y -= HEIGHT / 2;

            return new int[] { x, y * -1 };
        }


        //Desenhos 
        void DrawXMarks(PaintEventArgs e, Pen pen, int x)
        {
            int y1 = Plane2FormsCoords(0, 1)[1] + offset;
            int y2 = Plane2FormsCoords(0, -1)[1] + offset;
            DrawLine(e,pen, x, y1, x, y2);
        }
        void DrawYMarks(PaintEventArgs e, Pen pen, int y)
        {
            int x1 = Plane2FormsCoords(1, 0)[0];
            int x2 = Plane2FormsCoords(-1, 0)[0];
            DrawLine(e,pen, x1, y, x2, y);
        }
        void DrawAxis(PaintEventArgs e)
        {
            //Desenha as retas do exio X e do eixo Y
            Pen pen = GetColor(0, 0, 0);

            int xOrigin = WIDTH / 2;
            int yOrigin = HEIGHT / 2;

            DrawLine(e, pen, 0, yOrigin + offset, WIDTH, yOrigin + offset);// Eixo X
            DrawLine(e, pen, xOrigin, 0, xOrigin, HEIGHT); // Eixo Y

            for (int i = 0; i <= WIDTH; i += 10)
                DrawXMarks(e,pen,i);

            for(int i =0; i <= HEIGHT; i += 10)
                DrawYMarks(e,pen,i);
        }
        void DrawLine(PaintEventArgs e, Pen pen,int x0,int y0, int x1, int y1)
        {
            e.Graphics.DrawLine(pen,x0,y0,x1,y1);
        }
        

        void PrepareLine(Pen pen, PaintEventArgs e)
        {
            int x1 = int.Parse(x_box.Text);
            int y1 = f(x1);
            int x2 = int.Parse(x2_box.Text);
            int y2 = f(x2);
    
            //Escreve no JSON os dados da reta
            writeJSON(x1,y1,x2,y2);

            int[] NewCoords = Plane2FormsCoords(x1, y1);
            x1 = NewCoords[0];
            y1 = NewCoords[1] +offset;

            NewCoords = Plane2FormsCoords(x2, y2);
            x2 = NewCoords[0];
            y2 = NewCoords[1] + offset;

            DrawLine(e,pen, x1, y1, x2, y2);
        }
        void writeJSON(int x1, int y1, int x2, int y2)
        {
            draw_line = false;
            String[] lines = { };

            if (retas_count != 1)
            {
                StreamReader file_read = new StreamReader("arquivo.json");

                lines = new string[retas_count];

                for (int i = 0; i < retas_count; i++)
                    lines[i] = file_read.ReadLine();

                file_read.Close();
            }

            StreamWriter file = new StreamWriter("file.json");

            if (retas_count == 1)
                file.WriteLine("{\"Pontos\":[");
            
            for (int i = 0; i < lines.Length; i++)
                file.WriteLine(lines[i]);

            String line = "\t{\"Line"+ retas_count+ "\":\"X1\",\"Y1\":“X2”,”Y2”:["+x1+","+y1+","+x2+","+y2+"]},";
            file.WriteLine(line);

            file.Write("]}");
            file.Close();

            retas_count++;
        }
        private void DrawButton_Click(object sender, EventArgs e)
        {
            if (m_box.Text == "")
                m = 0;
            else
                m = int.Parse(m_box.Text);

            if (b_box.Text == "")
                b = 0;
            else
                b = int.Parse(b_box.Text);

            if (x_box.Text == "" || x2_box.Text == "")
            {
                MessageBox.Show("Fill all fields");
                return;
            }

            if(x_box.Text == x2_box.Text)
            {
                MessageBox.Show("X1 and X2 are equal, change one of it´s values");
                return;
            }
                
            draw_line = true;
            Invalidate();

            if (b < 0)
                FunctionLabel.Text = "f(x) = " + m + "x -" + Math.Abs(b);
            else
                FunctionLabel.Text = "f(x) = " + m + "x +" + b;
        }
    }
}
