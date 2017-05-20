using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_4
{
	public partial class CyclicCode : Form
	{
		private int _n;
		private int _k;
		private int[] _generationPol;
		private int[] _checkingPol;

		public CyclicCode()
		{
			InitializeComponent();
		}

		private void BtnEncode_Click(object sender, EventArgs e)
		{
			ReadInput();
			CalculateCheckingPolynomial();
			CalculateCheckingCoefficients();
		}

		private void ReadInput()
		{
			_n = int.Parse(tbN.Text);
			_k = int.Parse(tbK.Text);
			_generationPol = tbGeneration.Text.Select(ch => int.Parse(ch.ToString())).ToArray();
		}

		private void CalculateCheckingPolynomial()
		{
			var dividend = new int[_n + 1];
			for (int i = 1; i < _n; i++)
				dividend[i] = 0;
			dividend[0] = dividend[_n] = 1;

			_checkingPol = Divide(dividend, _generationPol);
			tbToEncode.Text = string.Join(string.Empty, _checkingPol);
		}

		private static int[] Divide(int[] dividend, int[] divisor)
		{
			if (dividend.Length < divisor.Length)
				return new[] {0};

			var result = new List<int>();
			var dividendQueue = new Queue<int>(dividend);
			var chunk = new List<int>();
			while (dividendQueue.Any())
			{
				while (chunk.Count < divisor.Length)
				{
					chunk.Add(dividendQueue.Dequeue());
					if (chunk.First() == 0)
					{
						chunk.RemoveAt(0);
						result.Add(0);
						if (!dividendQueue.Any())
							return result.ToArray();
					}
				}
				chunk = chunk.Zip(divisor, (d1, d2) => d1 ^ d2).ToList();
				chunk.RemoveAt(0);
				result.Add(1);
				while (chunk.Any() && chunk.First() == 0 && dividendQueue.Any())
				{
					chunk.RemoveAt(0);
					result.Add(0);
				}
			}
			return result.ToArray();
		}

		private void CalculateCheckingCoefficients()
		{
		}
	}
}
