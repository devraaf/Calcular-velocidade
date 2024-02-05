/*
 * Criado por SharpDevelop.
 * Usuário: Rafinha
 * Data: 16/03/2023
 * Hora: 16:14
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CalculadoraVelocidade
{
	
	public partial class MainForm : Form
	{
		public MainForm()
		{
			
			InitializeComponent();
			
			
		}
		void Button1Click(object sender, EventArgs e)
		{
			float d;
			d = float.Parse (textBox1.Text);
			float t;
			t = float.Parse(textBox2.Text);
			float v;
			v = d / t;
			label7.Text = v.ToString();
			
		}
	}
}
