/*
 * Created by SharpDevelop.
 * User: dk
 * Date: 3/1/2022
 * Time: 2:13 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Tugas_Andri_Hasudungan_201401036
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			
			InitializeComponent();
		}
		
		private void insertBarang_Click(object sender,EventArgs e){
			listBarang.Items.Add(teksbarang.Text);
		}
		
	}
}
