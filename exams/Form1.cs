using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exams
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void maskedTBPredmet_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
           
        }

        private void maskedTBPredmet_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void maskedTBPredmet_Leave(object sender, EventArgs e)
        {
            maskedTBPredmet.MaxLength = 70;

            if (maskedTBPredmet.TextLength < 10)
            {
                MessageBox.Show("Название не может быть короче 10 символов!");
            }
            else
            if (maskedTBPredmet.TextLength > 70) {
                MessageBox.Show("Название не может превышать 70 символов!");
            }
        }
    }
}
