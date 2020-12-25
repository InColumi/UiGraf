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

namespace UiGraf
{
    public partial class StartMenu : Form
    {
        private Graf _graf;
        public StartMenu()
        {
            InitializeComponent();
        }

        private void openFileToolStrip_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = Environment.SpecialFolder.Desktop.ToString();
                openFileDialog.DefaultExt = "txt";
                openFileDialog.Filter = "|*.txt";
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    List<string> _textFromFile = new List<string>();
                    using (StreamReader reader = new StreamReader(openFileDialog.FileName))
                    {
                        while (reader.EndOfStream == false)
                        {
                            _textFromFile.Add(reader.ReadLine());
                        }
                    }
                    _graf = new Graf(_textFromFile);
                    numericUpDown1.Value = _graf.Size;
                    SetComboBoxValue();
                    SetDataGridFromFile();
                    BlockingMainDiagonal();
                    MessageBox.Show("Теперь выбирая Стартовую вершину, можете увидеть работу алгоритма!");
                }
            }
        }

        private void SetComboBoxValue()
        {
            comboBoxWithStartVertex.Items.Clear();
            for (int i = 1; i <= _graf.Size; i++)
            {
                comboBoxWithStartVertex.Items.Add(i);
            }
        }

        private void ShowWorkAlgorithm()
        {
            try
            {
                _graf.SolveDFS(comboBoxWithStartVertex.SelectedIndex);
                labelAnswer.Text = _graf.GetAnswer();
            }
            catch (Exception)
            {
                MessageBox.Show("Путь не найдет, проверьте данные!");
            }
        }

        private void saveToolStrip_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveFileDialog.FileName, labelAnswer.Text);
                }
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int size = Convert.ToInt32(numericUpDown1.Value);
            dataGridView1.RowCount = size;
            dataGridView1.ColumnCount = size;
            if (_graf == null)
            {
                _graf = new Graf(dataGridView1);
            }
           
            SetComboBoxValue();
            BlockingMainDiagonal();
        }

        private void BlockingMainDiagonal()
        {
            for (int i = 0; i < _graf.Size; i++)
            {
                dataGridView1.Rows[i].Cells[i].Style.BackColor = Color.FromArgb(205, 92, 92);
                dataGridView1.Rows[i].Cells[i].ReadOnly = true;
            }
        }

        private void dataGridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char key = e.KeyChar;
            if ((key == 48 || key == 49) && key != 8)
            {
                e.Handled = true;
            }
        }

        private void SetDataGridFromFile()
        {
            dataGridView1.RowCount = _graf.Size;
            dataGridView1.ColumnCount = _graf.Size;

            for (int i = 0; i < _graf.Size; i++)
            {
                for (int j = 0; j < _graf.Size; j++)
                {
                    dataGridView1[i, j].Value = _graf.GetValue(i, j).ToString();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBoxWithStartVertex.SelectedIndex != -1)
            {
                ShowWorkAlgorithm();
            }
            else
            {
                MessageBox.Show("Стартовая вершина пуста!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.RowCount = 0;
            dataGridView1.ColumnCount = 0;
            numericUpDown1.Value = numericUpDown1.Minimum;
            comboBoxWithStartVertex.Items.Clear();
            _graf = null;
        }
    }
}
