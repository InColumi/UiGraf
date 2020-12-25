using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace UiGraf
{
    class Graf
    {
        private int[,] _matr;
        private bool[] _visited;
        private Queue<int> _answer;
        public int Size { get; private set; }
        public int LengthAnswer { get; private set; }

        public Graf(List<string> matrixInSrtings)
        {
            Size = matrixInSrtings.Count;
            SetInitialValue();
            for (int i = 0; i < Size; i++)
            {
                string[] cells = matrixInSrtings[i].Split(' ');
                for (int j = 0; j < Size; j++)
                {
                    _matr[i, j] = Convert.ToInt32(cells[j]);
                }
            }
        }

        public Graf(DataGridView dataGridView)
        {
            Size = dataGridView.RowCount;
            SetInitialValue();
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    _matr[i, j] = Convert.ToInt32(dataGridView[i, j].Value);
                }
            }
        }

        public int GetValue(int i, int j)
        {
            return _matr[i, j];
        }

        void SetInitialValue()
        {
            _matr = new int[Size, Size];
            _visited = new bool[Size];
            _answer = new Queue<int>();
        }

        public void SolveDFS(int numberStartVertex)
        {
            DFS(numberStartVertex);

        }

        public string GetAnswer()
        {
            LengthAnswer = _answer.Count;
            if (LengthAnswer > 0)
            {
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < Size - 1; i++)
                {
                    builder.Append(_answer.Dequeue().ToString() + "-");
                    _visited[i] = false;
                }
                _visited[Size - 1] = false;
                builder.Append(_answer.Dequeue().ToString());
                return builder.ToString();
            }
            else
            {
                throw new Exception("Path is empty!");
            }
        }

        private void DFS(int st)
        {
            _answer.Enqueue(st + 1);
            _visited[st] = true;
            for (int i = 0; i < Size; i++)
            {
                if (_matr[st, i] != 0 && _visited[i] == false)
                {
                    DFS(i);
                }
            }
        }
    }
}
