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
			throw new NotImplementedException();
		}

		private void CalculateCheckingPolynomial()
		{
			throw new NotImplementedException();
		}

		private void CalculateCheckingCoefficients()
		{
			throw new NotImplementedException();
		}
	}
}
