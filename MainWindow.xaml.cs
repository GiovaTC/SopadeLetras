using System;
using System.Windows;
using System.Windows.Controls;

namespace WordSearchGame
{
    public partial class MainWindow : Window
    {
        private char[,] wordGrid;
        private string[] wordsToFind = { "CSharp", "Code", "Game", "DotNet", "Puzzle" };

        public MainWindow()
        {
            InitializeComponent();
            GenerateWordGrid(10, 10);
            PopulateWordGrid();
        }

        private void GenerateWordGrid(int rows, int columns)
        {
            wordGrid = new char[rows, columns];
            Random random = new Random();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    wordGrid[i, j] = (char)random.Next('A', 'Z' + 1);
                    Button letterButton = new Button
                    {
                        Content = wordGrid[i, j].ToString(),
                        FontSize = 16
                    };
                    WordGrid.Children.Add(letterButton);
                }
            }
        }

        private void PopulateWordGrid()
        {
            // Lógica para colocar las palabras en el tablero
            // Por ejemplo, insertar las palabras horizontalmente o verticalmente
            // y actualizar el contenido del botón correspondiente
        }
    }
}
