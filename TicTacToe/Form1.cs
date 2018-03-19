using System;
using System.Windows.Forms;
using TicTacToe.Models;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        private string Side => _isX ? "X" : "O";

        private bool _isX;

        private readonly Model _model;

        public Form1()
        {
            InitializeComponent();
            _isX = MessageBox.Show(@"Playing for X?", @"Playing for X?", MessageBoxButtons.YesNo) == DialogResult.Yes;
            _model = new Model();
        }

        private void Key1_Click(object sender, EventArgs e)
        {
            Key1.Text = Side;
            _model.Set(1, true, _isX, false);
        }

        private void Key2_Click(object sender, EventArgs e)
        {
            Key2.Text = Side;
            _model.Set(2, true, _isX, false);
        }

        private void Key3_Click(object sender, EventArgs e)
        {
            Key3.Text = Side;
            _model.Set(3, true, _isX, false);
        }

        private void Key4_Click(object sender, EventArgs e)
        {
            Key4.Text = Side;
            _model.Set(4, true, _isX, false);
        }

        private void Key5_Click(object sender, EventArgs e)
        {
            Key5.Text = Side;
            _model.Set(5, true, _isX, false);
        }

        private void Key6_Click(object sender, EventArgs e)
        {
            Key6.Text = Side;
            _model.Set(6, true, _isX, false);
        }

        private void Key7_Click(object sender, EventArgs e)
        {
            Key7.Text = Side;
            _model.Set(7, true, _isX, false);
        }

        private void Key8_Click(object sender, EventArgs e)
        {
            Key8.Text = Side;
            _model.Set(8, true, _isX, false);
        }

        private void Key9_Click(object sender, EventArgs e)
        {
            Key9.Text = Side;
            _model.Set(9, true, _isX, false);
        }

        private void newGameButton_Click(object sender, EventArgs e)
        {
            var keys = new[] { Key1, Key2, Key3, Key4, Key5, Key6, Key7, Key8, Key9 };
            foreach (var key in keys)
            {
                key.Text = "";
            }
            _model.Reset();
            _isX = MessageBox.Show(@"Playing for X?", @"Playing for X?", MessageBoxButtons.YesNo) == DialogResult.Yes;
        }
    }
}
