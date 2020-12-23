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
        private List<string> _textFromFile;
        private int[,] _matr;
        private int _size;
        private bool[] _visited;
        private Queue<int> _answer;

        public StartMenu()
        {
            _textFromFile = new List<string>();
            _answer = new Queue<int>();
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
                    using (StreamReader reader = new StreamReader(openFileDialog.FileName))
                    {
                        while (reader.EndOfStream == false)
                        {
                            _textFromFile.Add(reader.ReadLine());
                        }
                    }
                    _size = _textFromFile.Count;
                    numericUpDown1.Value = _size;
                    SetStartValue();
                    SetMatrixFromString();
                    SetDataGridFromFile();
                    BlockingMainDiagonal();
                    MessageBox.Show("Теперь выбирая Стартовую вершину, можете увидеть работу алгоритма!");
                }
            }
        }

        private void SetStartValue()
        {
            _visited = new bool[_size];
            SetComboBoxValue();
        }

        private void SetComboBoxValue()
        {
            comboBoxWithStartVertex.Items.Clear();
            for (int i = 1; i <= _size; i++)
            {
                comboBoxWithStartVertex.Items.Add(i);
            }
        }

        private void SetMatrixFromString()
        {
            _matr = new int[_size, _size];
            for (int i = 0; i < _size; i++)
            {
                string[] cells = _textFromFile[i].Split(' ');
                for (int j = 0; j < _size; j++)
                {
                    _matr[i, j] = Convert.ToInt32(cells[j]);
                }
            }
        }

        private void DFS(int st)
        {
            _answer.Enqueue(st + 1);
            _visited[st] = true;
            for (int i = 0; i < _size; i++)
            {
                if (_matr[st, i] != 0 && _visited[i] == false)
                {
                    DFS(i);
                }
            }
        }

        private void ShowWorkAlgorithm()
        {
            DFS(Convert.ToInt32(comboBoxWithStartVertex.SelectedIndex));

            if (_answer.Count != 0)
            {
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < _size; i++)
                {
                    builder.Append(_answer.Dequeue().ToString() + "-");
                }

                labelAnswer.Text = builder.ToString();
                _answer.Clear();
                for (int i = 0; i < _size; i++)
                {
                    _visited[i] = false;
                }
            }
            else
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
            _size = Convert.ToInt32(numericUpDown1.Value);
            SetStartValue();
            dataGridView1.RowCount = _size;
            dataGridView1.ColumnCount = _size;
            SetComboBoxValue();
            BlockingMainDiagonal();
        }

        private void BlockingMainDiagonal()
        {
            for (int i = 0; i < _size; i++)
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

        private void SetMatrixFromDataGrid()
        {
            _matr = new int[_size, _size];
            for (int i = 0; i < _size; i++)
            {
                for (int j = 0; j < _size; j++)
                {
                    _matr[i, j] = Convert.ToInt32(dataGridView1[i, j].Value);
                }
            }
        }

        private void SetDataGridFromFile()
        {
            dataGridView1.RowCount = _size;
            dataGridView1.ColumnCount = _size;

            for (int i = 0; i < _size; i++)
            {
                for (int j = 0; j < _size; j++)
                {
                    dataGridView1[i, j].Value = _matr[i, j].ToString();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBoxWithStartVertex.SelectedIndex != -1)
            {
                SetMatrixFromDataGrid();
                ShowWorkAlgorithm();
            }
            else
            {
                MessageBox.Show("Стартовая вершина пуста!");
            }
        }

    }
}
