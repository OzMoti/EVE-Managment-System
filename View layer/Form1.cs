using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace EVE_Managment_System
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();

        }

        public void Display()
        {
            DBHelper.ShowAndSearch("SELECT * FROM eve.orders order by ORD_ID desc", dataGridView1);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this);
            form2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BarcodeLib.Barcode b = new BarcodeLib.Barcode();
            string PCBBarcode = dataGridView1.SelectedRows[0].Cells[1].Value.ToString() + "/" + dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            Image brimg = b.Encode(BarcodeLib.TYPE.CODE93, PCBBarcode, Color.Black, Color.White, 330, 60);
            Clipboard.SetDataObject(brimg);
            
        }

        private void Dashboard_Shown(object sender, EventArgs e)
        {
            Display();
        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {

        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow Myrow in dataGridView1.Rows)
            {
                if (Myrow.Cells[9].Value.ToString() == "EX")
                {
                    Myrow.DefaultCellStyle.BackColor = Color.Orange;
                }

            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                string PCBBarcode = row.Cells[1].Value.ToString() + "/" + dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                BarcodeLib.Barcode b = new BarcodeLib.Barcode();
                Image brimg = b.Encode(BarcodeLib.TYPE.CODE93, PCBBarcode, Color.Black, Color.White, 330, 60);
                pictureBox1.Image = brimg;
                label7.Text = PCBBarcode;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DBHelper.DeletePCB(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()));
            Display();
        }
    }
}
