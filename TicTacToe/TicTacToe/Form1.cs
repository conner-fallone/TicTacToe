using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
	public partial class Form1 : Form
	{
		public bool turn = false;
		Button[] buttonHolder = new Button[9];

		public Form1()
		{
			InitializeComponent();
			buttonHolder[0] = button1;
			buttonHolder[1] = button2;
			buttonHolder[2] = button3;
			buttonHolder[3] = button4;
			buttonHolder[4] = button5;
			buttonHolder[5] = button6;
			buttonHolder[6] = button7;
			buttonHolder[7] = button8;
			buttonHolder[8] = button9;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			applyMove(turn, this.button1);
		}

		private void button2_Click(object sender, EventArgs e)
		{
			applyMove(turn, this.button2);
		}

		private void button3_Click(object sender, EventArgs e)
		{
			applyMove(turn, this.button3);
		}

		private void button4_Click(object sender, EventArgs e)
		{
			applyMove(turn, this.button4);
		}

		private void button5_Click(object sender, EventArgs e)
		{
			applyMove(turn, this.button5);
		}

		private void button6_Click(object sender, EventArgs e)
		{
			applyMove(turn, this.button6);
		}

		private void button7_Click(object sender, EventArgs e)
		{
			applyMove(turn, this.button7);
		}

		private void button8_Click(object sender, EventArgs e)
		{
			applyMove(turn, this.button8);
		}

		private void button9_Click(object sender, EventArgs e)
		{
			applyMove(turn, this.button9);
		}

		private void applyMove(bool turn, Button button)
		{
			// Player one turn, else Player two turn
			if (!turn)
			{
				button.Text = "X";
				this.turn = true;
			}
			else
			{
				button.Text = "O";
				this.turn = false;
			}

			checkForWinner();
		}

		private void checkForWinner()
		{
			if (button1.Text.Equals(button2.Text) && button2.Text.Equals(button3.Text)){
				if (string.IsNullOrEmpty(button1.Text)){
					return;
				} else {
					MessageBox.Show("You Win!", "Winner", MessageBoxButtons.OK, MessageBoxIcon.Question);
				}
			}

			if (button4.Text.Equals(button5.Text) && button5.Text.Equals(button6.Text)){
				if (string.IsNullOrEmpty(button4.Text)){
					return;
				} else {
					MessageBox.Show("You Win!", "Winner", MessageBoxButtons.OK, MessageBoxIcon.Question);
				}
			}

			if (button7.Text.Equals(button8.Text) && button8.Text.Equals(button9.Text)){
				if (string.IsNullOrEmpty(button7.Text)){
					return;
				} else {
					MessageBox.Show("You Win!", "Winner", MessageBoxButtons.OK, MessageBoxIcon.Question);
				}
			}

			if (button1.Text.Equals(button4.Text) && button4.Text.Equals(button7.Text)){
				if (string.IsNullOrEmpty(button1.Text)){
					return;
				} else {
					MessageBox.Show("You Win!", "Winner", MessageBoxButtons.OK, MessageBoxIcon.Question);
				}
			}

			if (button2.Text.Equals(button5.Text) && button5.Text.Equals(button8.Text)){
				if (string.IsNullOrEmpty(button2.Text)){
					return;
				} else {
					MessageBox.Show("You Win!", "Winner", MessageBoxButtons.OK, MessageBoxIcon.Question);
				}
			}

			if (button3.Text.Equals(button6.Text) && button6.Text.Equals(button9.Text)){
				if (string.IsNullOrEmpty(button3.Text)){
					return;
				} else {
					MessageBox.Show("You Win!", "Winner", MessageBoxButtons.OK, MessageBoxIcon.Question);
				}
			}

			if (button1.Text.Equals(button5.Text) && button5.Text.Equals(button9.Text)){
				if (string.IsNullOrEmpty(button1.Text)){
					return;
				} else {
					MessageBox.Show("You Win!", "Winner", MessageBoxButtons.OK, MessageBoxIcon.Question);
				}
			}

			if (button3.Text.Equals(button5.Text) && button5.Text.Equals(button7.Text)){
				if (string.IsNullOrEmpty(button3.Text)){
					return;
				} else {
					MessageBox.Show("You Win!", "Winner", MessageBoxButtons.OK, MessageBoxIcon.Question);
				}
			}
		}
	}
}
