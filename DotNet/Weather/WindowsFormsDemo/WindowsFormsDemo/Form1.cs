﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisualBasicLuokkaKirjasto;

namespace WindowsFormsDemo
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {
      int luku1 = int.Parse(textBox1.Text);
      int luku2 = int.Parse(textBox2.Text);

      Laskin laskin = new Laskin();
      int summa = laskin.Summa(luku1, luku2);
      MessageBox.Show(summa.ToString());

      textBox2.BackColor = Color.Navy;

      MessageBox.Show((luku1 + luku2).ToString());
    }
  }
}
