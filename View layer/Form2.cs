using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EVE_Managment_System
{
    public partial class Form2 : Form
    {

        private readonly Dashboard _Parent;

        string priority = "N";
        string type = "FR4";

        string startDate = DateTime.Now.ToString("yyyy-MM-d");
        string endDate = DateTime.Now.ToString("yyyy-MM-d");


        public Form2(Dashboard parent)
        {
            InitializeComponent();
            _Parent = parent;
            
        
        }

        public void Clear()
        {
            name_textbox.Text = customer_textbox.Text = string.Empty;
        }
        

        private void radioButtonN_CheckedChanged(object sender, EventArgs e)
        {
            radioButtonN.Checked = true;
            radioButtonEX.Checked = false;
            priority = radioButtonN.Text;
            
        }

        private void radioButtonEX_CheckedChanged(object sender, EventArgs e)
        {
            radioButtonEX.Checked = true;
            radioButtonN.Checked = false;
            priority = radioButtonEX.Text;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (name_textbox.TextLength < 3)
            {
                MessageBox.Show("No Name !");
                return;
            }
            if (customer_textbox.TextLength < 3)
            {
                MessageBox.Show("No customer Name !");
                return;
            }
            PCB order = new PCB(name_textbox.Text.Trim(), customer_textbox.Text.Trim(), startDate, endDate, type, pnum, ppnum, priority);
            DBHelper.AddOrder(order);
            Clear();
            _Parent.Display();
        }

        

        private void radioButtonFR4_CheckedChanged(object sender, EventArgs e)
        {
            type = radioButtonFR4.Text;
        }

        private void RadioButtonCEM1_CheckedChanged(object sender, EventArgs e)
        {
            type = RadioButtonCEM1.Text;
        }

        private void radioButtonAL_CheckedChanged(object sender, EventArgs e)
        {
            type = radioButtonAL.Text;
        }

        private void date_start_ValueChanged(object sender, EventArgs e)
        {
            startDate = date_start.Value.ToString("yyyy-MM-d");
        }

        private void date_end_ValueChanged(object sender, EventArgs e)
        {
            endDate = date_end.Value.ToString("yyyy-MM-d");
        }

        
    }
}

