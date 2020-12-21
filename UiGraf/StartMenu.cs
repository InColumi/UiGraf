using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UiGraf
{
    public partial class StartMenu : Form
    {
        private List<Label> _labels;
        private bool _isMouseDown;
        public StartMenu()
        {
            _labels = new List<Label>();
            InitializeComponent();

            //Graphics gr = e.Graphics;
            //Pen p = new Pen(Color.Blue, 5);// цвет линии и ширина
            //Point p1 = new Point(5, 10);// первая точка
            //Point p2 = new Point(40, 100);// вторая точка
            //gr.DrawLine(p, p1, p2);// рисуем линию
            //gr.Dispose();// освобождаем все ресурсы, связанные с отрисовкой

        }

        private void StartMenu_MouseClick(object sender, MouseEventArgs e)
        {
            AddLable(e);
        }

        private void AddLable(MouseEventArgs e)
        {
            Label label = new Label();
            label.Text = (_labels.Count + 1).ToString();
            label.BackColor = Color.LightGreen;
            label.Location = new Point(e.X, e.Y);
            label.Size = new Size(33, 40);
            label.AutoSize = true;
            label.Font = new Font("Segoe UI", 22, FontStyle.Bold);
            Controls.Add(label);
            _labels.Add(label);
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            _isMouseDown = true;
        }

        private void label1_MouseUp(object sender, MouseEventArgs e)
        {
            Control c = sender as Control;
            if (_isMouseDown)
            {
                c.Location = this.PointToClient(Control.MousePosition);
            }
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            _isMouseDown = false;
        }

    }
}
