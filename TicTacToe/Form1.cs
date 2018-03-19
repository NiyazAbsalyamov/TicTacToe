using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicTacToe.Models;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        private string Side => _isX ? "X" : "O";

        private bool _isX;

        private Model _model;

        public Form1()
        {
            InitializeComponent();
            _isX = MessageBox.Show(@"Playing for X?", @"Playing for X?", MessageBoxButtons.YesNo) == DialogResult.Yes;
            _model = new Model();
        }

        private void Key1_Click(object sender, EventArgs e)
        {
            Key1.Text = Side;
        }

        private void Key2_Click(object sender, EventArgs e)
        {
            Key2.Text = Side;
        }

        private void Key3_Click(object sender, EventArgs e)
        {
            Key3.Text = Side;
        }

        private void Key4_Click(object sender, EventArgs e)
        {
            Key4.Text = Side;
        }

        private void Key5_Click(object sender, EventArgs e)
        {
            Key5.Text = Side;
        }

        private void Key6_Click(object sender, EventArgs e)
        {
            Key6.Text = Side;
        }

        private void Key7_Click(object sender, EventArgs e)
        {
            Key7.Text = Side;
        }

        private void Key8_Click(object sender, EventArgs e)
        {
            Key8.Text = Side;
        }

        private void Key9_Click(object sender, EventArgs e)
        {
            Key9.Text = Side;
        }

        private void newGameButton_Click(object sender, EventArgs e)
        {
            var keys = new[] { Key1, Key2, Key3, Key4, Key5, Key6, Key7, Key8, Key9 };
            foreach (var key in keys)
            {
                key.Text = "";
            }
            _isX = MessageBox.Show(@"Playing for X?", @"Playing for X?", MessageBoxButtons.YesNo) == DialogResult.Yes;
        }
    }
}
