﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace lab2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            //TODO: return to Form1
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string input1 = textBox1.Text;
            string input2 = textBox2.Text;
            string input3 = textBox3.Text;
            if (!IsValidDouble(input2))
            {
                MessageBox.Show("Ошибка: Введите корректное значение денежного формата (формат 0.00).");
                return;
            }

            string article = input1.ToString();
            string name = input2.ToString();
            double price;

            if (double.TryParse(input3, out price))
            {
                Item i = new Item(article, name, price);
                //TODO: in json
            }
            else
            {
                MessageBox.Show("Ошибка: Проверьте введенные данные.");
            }
        }
        private bool IsValidDouble(string input)
        {
            //TODO: huita ne robit
            string pattern = @"^\d+(\.\d{1,2})?$";
            return Regex.IsMatch(input, pattern);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
