using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IT_PR_9
{
  public partial class Form1 : Form
  {
    Point[] points = new Point[50];
    Pen pen = new Pen(Color.Black, 2);
    public Form1()
    {
      InitializeComponent();
    }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
      Graphics g = e.Graphics; // Объявляется объект Graphics
                               // Далее вставляется код рисования

      g.Clear(Color.White);
      
      g.DrawLine(new Pen(Brushes.Black, 600), 0, 0, 600, 0);
      g.DrawLine(new Pen(Brushes.Blue, 400), 0, 0, 600, 0);
      g.DrawLine(new Pen(Brushes.Red, 200), 0, 0, 600, 0);

      g.DrawEllipse(new Pen(Brushes.Black, 20), 100, 500, 50, 50);
      g.DrawLine(new Pen(Brushes.Black, 10), 500, 530, 150, 530);
      g.DrawEllipse(new Pen(Brushes.Black, 20), 500, 500, 50, 50);
      g.DrawLine(new Pen(Brushes.Black, 10), 550, 530, 550, 400);
      g.DrawLine(new Pen(Brushes.Black, 10), 410, 330, 100, 330);
      g.DrawLine(new Pen(Brushes.Aquamarine, 10), 400, 330, 550, 400);
      g.DrawLine(new Pen(Brushes.Black, 10), 120, 500, 120, 325);
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      Width = 1000;
      Height = 1000;
      for (int i = 0; i < 20; i++)
      {
        int xPos;
        if (i % 2 == 0)
        {
          xPos = 10;
        }
        else
        {
          xPos = 400;
        }
        points[i] = new Point(xPos, 10 * i);
      }
    }
  }
}
