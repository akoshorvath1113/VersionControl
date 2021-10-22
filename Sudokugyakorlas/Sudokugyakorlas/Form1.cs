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

namespace Sudokugyakorlas
{
    public partial class Form1 : Form
    {
        private Sudoku _Currentquiz = null;
        public Form1()
        {
            InitializeComponent();
            CreatePlayField();
            LoadSudokus();
            NewGame();
        }
        private void CreatePlayField()
        {
            int lineWidth = 5;
            for (int row = 0; row < 9; row++)
            {
                for (int col = 0; col < 9; col++)
                {
                    SudokuField sf = new SudokuField();
                    sf.Left = col * sf.Width + (int)(Math.Floor((double)(col / 3))) * lineWidth;
                    sf.Top = row * sf.Height + (int)(Math.Floor((double)(row / 3))) * lineWidth;
                    panel1.Controls.Add(sf);
                }
            }
        }
        private List<Sudoku> _sudoku = new List<Sudoku>();
        private void LoadSudokus()
        {
            using (StreamReader sr = new StreamReader("sudoku.csv", Encoding.Default))
            {
                sr.ReadLine();
                while (!sr.EndOfStream)
                {
                    string[] line = sr.ReadLine().Split(',');

                    Sudoku s = new Sudoku();
                    s.Quiz = line[0];
                    s.Solution = line[1];
                    _sudoku.Add(s);


                }
            }
        }
        Random rng = new Random();
       
        private Sudoku GetRandomQuiz()
        {
            int RandomNumber = rng.Next(_sudoku.Count);
            return _sudoku[RandomNumber];
        }

        private void NewGame()
        {
            _Currentquiz = GetRandomQuiz();

            int counter = 0;
            foreach (var sf in panel1.Controls.OfType<SudokuField>())
            {
                sf.Value = int.Parse(_Currentquiz.Quiz[counter].ToString());
                sf.Active = sf.Value == 0;
                counter++;
            }
        }
    }
}
