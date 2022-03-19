/*
 * Created by SharpDevelop.
 * User: Gabriel
 * Date: 17/03/2022
 * Time: 21:45
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Quizz_da_sorte
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		               int acerto=0;
		void Button1Click(object sender, EventArgs e)
		{
            	button1.BackColor=Color.Green;
				button2.Enabled=false;
				button3.Enabled=false;
				button4.Enabled=false;
				acerto++;
				label2.Text=acerto.ToString();
				button5.Enabled=true;
				MessageBox.Show("Acerto Mizeravi!");
		}
		void Button2Click(object sender, EventArgs e)
		{
	
			    button1.Enabled=false;
				button2.BackColor=Color.Red;
				button3.Enabled=false;
				button4.Enabled=false;
				button5.Enabled=true;
				MessageBox.Show("Errouu!");
		}
		void Button3Click(object sender, EventArgs e)
		{
	  button1.Enabled=false;
				button2.Enabled=false;
				button3.BackColor=Color.Red;
				button4.Enabled=false;
				button5.Enabled=true;
				MessageBox.Show("Errouu!");
		}
		void Button4Click(object sender, EventArgs e)
		{
	 button1.Enabled=false;
				button2.Enabled=false;
				button3.Enabled=false;
				button4.BackColor=Color.Red;
				button5.Enabled=true;
				MessageBox.Show("Errouu!");
		}
		void Button5Click(object sender, EventArgs e)
		{
	
			panel1.Visible= false;
			panel2.Visible=true;
		
		}
		
		
		
		
		
		
		
		
		
		
		
		
		void Button10Click(object sender, EventArgs e)
		{
	            button10.Enabled=false;
				button9.Enabled=false;
				button8.BackColor=Color.Red;
				button7.Enabled=false;
				button6.Enabled=true;
				MessageBox.Show("Errouu!");
		}
		void Button9Click(object sender, EventArgs e)
		{
	            button10.Enabled=false;
				button9.Enabled=false;
				button8.BackColor=Color.Red;
				button7.Enabled=false;
				button6.Enabled=true;
				MessageBox.Show("Errouu!");
		}
		void Button8Click(object sender, EventArgs e)
		{
	            button10.Enabled=false;
				button9.Enabled=false;
				button8.BackColor=Color.Green;
				button7.Enabled=false;
				button6.Enabled=true;
				acerto++;
				label2.Text=acerto.ToString();
				MessageBox.Show("Acerto mizeravi");
		}
		void Button7Click(object sender, EventArgs e)
		{
	            button10.Enabled=false;
				button9.Enabled=false;
				button8.Enabled=false;
				button7.BackColor=Color.Red;
				button6.Enabled=true;
				MessageBox.Show("Errouu!");
		}
		void Button6Click(object sender, EventArgs e)
		{
			panel2.Visible=false;
			panel3.Visible=true;
		}
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		void Button15Click(object sender, EventArgs e)
		{
	 
			    button15.BackColor=Color.Red;
				button14.Enabled=false;
				button13.Enabled=false;
				button12.Enabled=false;
				button11.Enabled=true;
				MessageBox.Show("Errouu!");
		}
		void Button14Click(object sender, EventArgs e)
		{
	
			    button15.Enabled=false;
				button14.BackColor=Color.Red;
				button13.Enabled=false;
				button12.Enabled=false;
				button11.Enabled=true;
				MessageBox.Show("Errouu!");
		}
		void Button13Click(object sender, EventArgs e)
		{
	            button15.Enabled=false;
				button14.Enabled=false;
				button13.BackColor=Color.Red;
				button12.Enabled=false;
				button11.Enabled=true;
				MessageBox.Show("Errouu!");
		}
		void Button12Click(object sender, EventArgs e)
		{
	            button15.Enabled=false;
				button14.Enabled=false;
				button13.Enabled=false;
				button12.BackColor=Color.Green;
				button11.Enabled=true;
				acerto++;
				label2.Text=acerto.ToString();
				MessageBox.Show("Acerto mzeravi");
		}
		void Button11Click(object sender, EventArgs e)
		{
	        panel3.Visible=false;
			panel4.Visible=true;
		}
		
		
		
		
		
		
		
		
		
		
		
		
		
		void Button20Click(object sender, EventArgs e)
		{
	            button20.BackColor=Color.Red;
				button19.Enabled=false;
				button18.Enabled=false;
				button17.Enabled=false;
				button16.Enabled=true;
				MessageBox.Show("Errouu!");
		}
		void Button19Click(object sender, EventArgs e)
		{
	            button20.Enabled=false;
				button19.BackColor=Color.Red;
				button18.Enabled=false;
				button17.Enabled=false;
				button16.Enabled=true;
				MessageBox.Show("Errouu!");
		}
		void Button18Click(object sender, EventArgs e)
		{
	            button20.Enabled=false;
				button19.Enabled=false;
				button18.BackColor=Color.Green;
				button17.Enabled=false;
				button16.Enabled=true;
				acerto++;
				label2.Text=acerto.ToString();
				MessageBox.Show("Acerto mizeravi");
		}
		void Button17Click(object sender, EventArgs e)
		{
	            button20.Enabled=false;
				button19.Enabled=false;
				button18.Enabled=false;
				button17.BackColor=Color.Red;
				button16.Enabled=true;
				MessageBox.Show("Errouu!");
		}
		void Button16Click(object sender, EventArgs e)
		{
	        panel4.Visible=false;
			panel5.Visible=true;
		}
		
		
		
		
		
		
		
		
		
		
		
		void Button25Click(object sender, EventArgs e)
		{
	            button25.BackColor=Color.Green;
				button24.Enabled=false;
				button23.Enabled=false;
				button22.Enabled=false;
				button21.Enabled=true;
				acerto++;
				label2.Text=acerto.ToString();
				MessageBox.Show("Acerto mizeavi!");
		}
		void Button24Click(object sender, EventArgs e)
		{
	            button25.Enabled=false;
				button24.BackColor=Color.Red;
				button23.Enabled=false;
				button22.Enabled=false;
				button21.Enabled=true;
				MessageBox.Show("Errouu!");
		}
		void Button23Click(object sender, EventArgs e)
		{
	            button25.Enabled=false;
				button24.Enabled=false;
				button23.BackColor=Color.Red;
				button22.Enabled=false;
				button21.Enabled=true;
				MessageBox.Show("Errouu!");
		}
		void Button22Click(object sender, EventArgs e)
		{
	            button25.Enabled=false;
				button24.Enabled=false;
				button23.Enabled=false;
				button22.BackColor=Color.Red;
				button21.Enabled=true;
				MessageBox.Show("Errouu!");
		}
		void Button21Click(object sender, EventArgs e)
		{
	        panel5.Visible=false;
			panel6.Visible=true;
		}
		
		
		
		
		
		
		
		
		
		
		
		
		void Button30Click(object sender, EventArgs e)
		{
	            button30.BackColor=Color.Red;
				button28.Enabled=false;
				button27.Enabled=false;
				button26.BackColor=Color.Red;
				button25.Enabled=true;
				MessageBox.Show("Errouu!");
		}
		void Button29Click(object sender, EventArgs e)
		{
	 button30.Enabled=false;
				button28.BackColor=Color.Red;
				button27.Enabled=false;
				button26.Enabled=false;
				button25.Enabled=true;
				MessageBox.Show("Errouu!");
		}
		void Button28Click(object sender, EventArgs e)
		{
	 button30.Enabled=false;
				button28.Enabled=false;
				button27.BackColor=Color.Red;
				button26.Enabled=false;
				button25.Enabled=true;
				MessageBox.Show("Errouu!");
		}
		void Button27Click(object sender, EventArgs e)
	 	{
	 button30.Enabled=false;
				button28.Enabled=false;
				button27.Enabled=false;
				button26.BackColor=Color.Green;
				button25.Enabled=true;
				
			
		}
		void Button26Click(object sender, EventArgs e)
		{
	panel6.Visible=false;
			panel7.Visible=true;
		}
		
		
		

		
		
		
		
		
		
		
		void Button35Click(object sender, EventArgs e)
		{
	            button35.BackColor=Color.Red;
				button34.Enabled=false;
				button33.Enabled=false;
				button32.Enabled=false;
				button31.Enabled=true;
				MessageBox.Show("Errouu!");
		}
		void Button34Click(object sender, EventArgs e)
		{
	            button35.Enabled=false;
				button34.BackColor=Color.Green;
				button33.Enabled=false;
				button32.Enabled=false;
				acerto++;
				label2.Text=acerto.ToString();
				button25.Enabled=true;
				MessageBox.Show("Acerto Mizeravi!!");
		}
		void Button33Click(object sender, EventArgs e)
		{
	            button35.Enabled=false;
				button34.Enabled=false;
				button33.BackColor=Color.Red;
				button32.Enabled=false;
				button31.Enabled=true;
				MessageBox.Show("Errouu!");
		}
		void Button32Click(object sender, EventArgs e)
		{
	            button35.Enabled=false;
				button34.Enabled=false;
				button33.Enabled=false;
				button32.BackColor=Color.Red;
				button31.Enabled=true;
				MessageBox.Show("Errouu!");
		}
		void Button31Click(object sender, EventArgs e)
		{
	       panel6.Visible=false;
			panel7.Visible=true;
		}
		
		
		
		
		
		}
	}

