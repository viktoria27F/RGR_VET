using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rgrUD
{
    public partial class ComandForm : Form
    {
        public ComandForm()
        {
            InitializeComponent();

            
        }

        public ComandForm (List<string> listAllTables)
        {
            comboBoxTable.Items.AddRange(listAllTables.Cast<object>().ToArray());
        }
     
        
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

    
        private void tablePet_MouseEnter(object sender, EventArgs e)
        {
            tablePet.BackColor = Color.White;
            tablePet.ForeColor = Color.DarkSlateBlue;
        }

        private void tablePet_MouseLeave(object sender, EventArgs e)
        {
            tablePet.BackColor = ColorTranslator.FromHtml("#20263d");
            tablePet.ForeColor = Color.White;
        }

        private void tableOwner_MouseEnter(object sender, EventArgs e)
        {
            tableOwner.BackColor = Color.White;
            tableOwner.ForeColor = Color.DarkSlateBlue;
        }

        private void tableOwner_MouseLeave(object sender, EventArgs e)
        {
            tableOwner.BackColor = ColorTranslator.FromHtml("#20263d");
            tableOwner.ForeColor = Color.White;
        }

        private void tableVeterinarian_MouseEnter(object sender, EventArgs e)
        {
            tableVeterinarian.BackColor = Color.White;
            tableVeterinarian.ForeColor = Color.DarkSlateBlue;
        }

        private void tableVeterinarian_MouseLeave(object sender, EventArgs e)
        {
            tableVeterinarian.BackColor = ColorTranslator.FromHtml("#20263d");
            tableVeterinarian.ForeColor = Color.White;
        }

        private void tableDiagnosis_MouseEnter(object sender, EventArgs e)
        {
            tableDiagnosis.BackColor = Color.White;
            tableDiagnosis.ForeColor = Color.DarkSlateBlue;
        }

        private void tableDiagnosis_MouseLeave(object sender, EventArgs e)
        {
            tableDiagnosis.BackColor = ColorTranslator.FromHtml("#20263d");
            tableDiagnosis.ForeColor = Color.White;
        }

        private void tableDrug_MouseEnter(object sender, EventArgs e)
        {
            tableDrug.BackColor = Color.White;
            tableDrug.ForeColor = Color.DarkSlateBlue;
        }

        private void tableDrug_MouseLeave(object sender, EventArgs e)
        {
            tableDrug.BackColor = ColorTranslator.FromHtml("#20263d");
            tableDrug.ForeColor = Color.White;
        }

        private void tableTreatment_MouseEnter(object sender, EventArgs e)
        {
            tableTreatment.BackColor = Color.White;
            tableTreatment.ForeColor = Color.DarkSlateBlue;
        }

        private void tableTreatment_MouseLeave(object sender, EventArgs e)
        {
            tableTreatment.BackColor = ColorTranslator.FromHtml("#20263d");
            tableTreatment.ForeColor = Color.White;
        }

        private void tableSex_MouseEnter(object sender, EventArgs e)
        {
            tableSex.BackColor = Color.White;
            tableSex.ForeColor = Color.DarkSlateBlue;
        }

        private void tableSex_MouseLeave(object sender, EventArgs e)
        {
            tableSex.BackColor = ColorTranslator.FromHtml("#20263d");
            tableSex.ForeColor = Color.White;
        }

        private void tableMedCard_MouseEnter(object sender, EventArgs e)
        {
            tableMedCard.BackColor = Color.White;
            tableMedCard.ForeColor = Color.DarkSlateBlue;
        }

        private void tableMedCard_MouseLeave(object sender, EventArgs e)
        {
            tableMedCard.BackColor = ColorTranslator.FromHtml("#20263d");
            tableMedCard.ForeColor = Color.White;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void closeButton_MouseEnter(object sender, EventArgs e)
        {
            closeButton.BackColor = Color.White;
            closeButton.ForeColor = Color.DarkSlateBlue;
        }

        private void closeButton_MouseLeave(object sender, EventArgs e)
        {
            closeButton.BackColor = ColorTranslator.FromHtml("#20263d");
            closeButton.ForeColor = Color.White;
        }

        Point lastPoint;
        private void ComandPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void ComandPanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void tableMedCard_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxTable_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    
}
