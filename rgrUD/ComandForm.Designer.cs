namespace rgrUD
{
    partial class ComandForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ComandPanel = new System.Windows.Forms.Panel();
            this.comboBoxTable = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.closeButton = new System.Windows.Forms.Label();
            this.tableSex = new System.Windows.Forms.Label();
            this.tablePet = new System.Windows.Forms.Label();
            this.tableOwner = new System.Windows.Forms.Label();
            this.tableVeterinarian = new System.Windows.Forms.Label();
            this.tableDiagnosis = new System.Windows.Forms.Label();
            this.tableTreatment = new System.Windows.Forms.Label();
            this.tableDrug = new System.Windows.Forms.Label();
            this.tableMedCard = new System.Windows.Forms.Label();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.ButtonUpdate = new System.Windows.Forms.Button();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.ButtonSelect = new System.Windows.Forms.Button();
            this.ComandPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ComandPanel
            // 
            this.ComandPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(38)))), ((int)(((byte)(61)))));
            this.ComandPanel.Controls.Add(this.comboBoxTable);
            this.ComandPanel.Controls.Add(this.tableLayoutPanel1);
            this.ComandPanel.Controls.Add(this.closeButton);
            this.ComandPanel.Controls.Add(this.tableSex);
            this.ComandPanel.Controls.Add(this.tablePet);
            this.ComandPanel.Controls.Add(this.tableOwner);
            this.ComandPanel.Controls.Add(this.tableVeterinarian);
            this.ComandPanel.Controls.Add(this.tableDiagnosis);
            this.ComandPanel.Controls.Add(this.tableTreatment);
            this.ComandPanel.Controls.Add(this.tableDrug);
            this.ComandPanel.Controls.Add(this.tableMedCard);
            this.ComandPanel.Controls.Add(this.ButtonDelete);
            this.ComandPanel.Controls.Add(this.ButtonUpdate);
            this.ComandPanel.Controls.Add(this.ButtonAdd);
            this.ComandPanel.Controls.Add(this.ButtonSelect);
            this.ComandPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComandPanel.Location = new System.Drawing.Point(0, 0);
            this.ComandPanel.Name = "ComandPanel";
            this.ComandPanel.Size = new System.Drawing.Size(800, 450);
            this.ComandPanel.TabIndex = 0;
            this.ComandPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ComandPanel_MouseDown);
            this.ComandPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ComandPanel_MouseMove);
            // 
            // comboBoxTable
            // 
            this.comboBoxTable.FormattingEnabled = true;
            this.comboBoxTable.Location = new System.Drawing.Point(174, 226);
            this.comboBoxTable.Name = "comboBoxTable";
            this.comboBoxTable.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTable.TabIndex = 18;
            this.comboBoxTable.SelectedIndexChanged += new System.EventHandler(this.comboBoxTable_SelectedIndexChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(307, 64);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(450, 265);
            this.tableLayoutPanel1.TabIndex = 17;
            // 
            // closeButton
            // 
            this.closeButton.AutoSize = true;
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.Font = new System.Drawing.Font("Castellar", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.Location = new System.Drawing.Point(756, 13);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(31, 25);
            this.closeButton.TabIndex = 16;
            this.closeButton.Text = "X";
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            this.closeButton.MouseEnter += new System.EventHandler(this.closeButton_MouseEnter);
            this.closeButton.MouseLeave += new System.EventHandler(this.closeButton_MouseLeave);
            // 
            // tableSex
            // 
            this.tableSex.AutoSize = true;
            this.tableSex.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tableSex.Font = new System.Drawing.Font("Noto Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tableSex.ForeColor = System.Drawing.Color.White;
            this.tableSex.Location = new System.Drawing.Point(41, 134);
            this.tableSex.Name = "tableSex";
            this.tableSex.Size = new System.Drawing.Size(131, 22);
            this.tableSex.TabIndex = 11;
            this.tableSex.Tag = "2";
            this.tableSex.Text = "ПОЛ ПИТОМЦА";
            this.tableSex.Click += new System.EventHandler(this.label1_Click_1);
            this.tableSex.MouseEnter += new System.EventHandler(this.tableSex_MouseEnter);
            this.tableSex.MouseLeave += new System.EventHandler(this.tableSex_MouseLeave);
            // 
            // tablePet
            // 
            this.tablePet.AutoSize = true;
            this.tablePet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tablePet.Font = new System.Drawing.Font("Noto Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tablePet.ForeColor = System.Drawing.Color.White;
            this.tablePet.Location = new System.Drawing.Point(41, 99);
            this.tablePet.Name = "tablePet";
            this.tablePet.Size = new System.Drawing.Size(91, 22);
            this.tablePet.TabIndex = 10;
            this.tablePet.Tag = "1";
            this.tablePet.Text = "ПИТОМЕЦ";
            this.tablePet.MouseEnter += new System.EventHandler(this.tablePet_MouseEnter);
            this.tablePet.MouseLeave += new System.EventHandler(this.tablePet_MouseLeave);
            // 
            // tableOwner
            // 
            this.tableOwner.AutoSize = true;
            this.tableOwner.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tableOwner.Font = new System.Drawing.Font("Noto Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tableOwner.ForeColor = System.Drawing.Color.White;
            this.tableOwner.Location = new System.Drawing.Point(41, 202);
            this.tableOwner.Name = "tableOwner";
            this.tableOwner.Size = new System.Drawing.Size(74, 22);
            this.tableOwner.TabIndex = 9;
            this.tableOwner.Tag = "4";
            this.tableOwner.Text = "ХОЗЯИН";
            this.tableOwner.MouseEnter += new System.EventHandler(this.tableOwner_MouseEnter);
            this.tableOwner.MouseLeave += new System.EventHandler(this.tableOwner_MouseLeave);
            // 
            // tableVeterinarian
            // 
            this.tableVeterinarian.AutoSize = true;
            this.tableVeterinarian.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tableVeterinarian.Font = new System.Drawing.Font("Noto Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tableVeterinarian.ForeColor = System.Drawing.Color.White;
            this.tableVeterinarian.Location = new System.Drawing.Point(41, 170);
            this.tableVeterinarian.Name = "tableVeterinarian";
            this.tableVeterinarian.Size = new System.Drawing.Size(101, 22);
            this.tableVeterinarian.TabIndex = 8;
            this.tableVeterinarian.Tag = "3";
            this.tableVeterinarian.Text = "ВЕТЕРИНАР";
            this.tableVeterinarian.MouseEnter += new System.EventHandler(this.tableVeterinarian_MouseEnter);
            this.tableVeterinarian.MouseLeave += new System.EventHandler(this.tableVeterinarian_MouseLeave);
            // 
            // tableDiagnosis
            // 
            this.tableDiagnosis.AutoSize = true;
            this.tableDiagnosis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tableDiagnosis.Font = new System.Drawing.Font("Noto Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tableDiagnosis.ForeColor = System.Drawing.Color.White;
            this.tableDiagnosis.Location = new System.Drawing.Point(41, 236);
            this.tableDiagnosis.Name = "tableDiagnosis";
            this.tableDiagnosis.Size = new System.Drawing.Size(84, 22);
            this.tableDiagnosis.TabIndex = 7;
            this.tableDiagnosis.Tag = "5";
            this.tableDiagnosis.Text = "ДИАГНОЗ";
            this.tableDiagnosis.MouseEnter += new System.EventHandler(this.tableDiagnosis_MouseEnter);
            this.tableDiagnosis.MouseLeave += new System.EventHandler(this.tableDiagnosis_MouseLeave);
            // 
            // tableTreatment
            // 
            this.tableTreatment.AutoSize = true;
            this.tableTreatment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tableTreatment.Font = new System.Drawing.Font("Noto Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tableTreatment.ForeColor = System.Drawing.Color.White;
            this.tableTreatment.Location = new System.Drawing.Point(41, 307);
            this.tableTreatment.Name = "tableTreatment";
            this.tableTreatment.Size = new System.Drawing.Size(83, 22);
            this.tableTreatment.TabIndex = 6;
            this.tableTreatment.Tag = "7";
            this.tableTreatment.Text = "ЛЕЧЕНИЕ";
            this.tableTreatment.MouseEnter += new System.EventHandler(this.tableTreatment_MouseEnter);
            this.tableTreatment.MouseLeave += new System.EventHandler(this.tableTreatment_MouseLeave);
            // 
            // tableDrug
            // 
            this.tableDrug.AutoSize = true;
            this.tableDrug.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tableDrug.Font = new System.Drawing.Font("Noto Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tableDrug.ForeColor = System.Drawing.Color.White;
            this.tableDrug.Location = new System.Drawing.Point(41, 272);
            this.tableDrug.Name = "tableDrug";
            this.tableDrug.Size = new System.Drawing.Size(91, 22);
            this.tableDrug.TabIndex = 5;
            this.tableDrug.Tag = "6";
            this.tableDrug.Text = "ПРЕПАРАТ";
            this.tableDrug.Click += new System.EventHandler(this.label1_Click);
            this.tableDrug.MouseEnter += new System.EventHandler(this.tableDrug_MouseEnter);
            this.tableDrug.MouseLeave += new System.EventHandler(this.tableDrug_MouseLeave);
            // 
            // tableMedCard
            // 
            this.tableMedCard.AutoSize = true;
            this.tableMedCard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tableMedCard.Font = new System.Drawing.Font("Noto Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tableMedCard.ForeColor = System.Drawing.Color.White;
            this.tableMedCard.Location = new System.Drawing.Point(41, 64);
            this.tableMedCard.Name = "tableMedCard";
            this.tableMedCard.Size = new System.Drawing.Size(185, 22);
            this.tableMedCard.TabIndex = 4;
            this.tableMedCard.Tag = "0";
            this.tableMedCard.Text = "МЕДИЦИНСКАЯ КАРТА";
            this.tableMedCard.Click += new System.EventHandler(this.tableMedCard_Click);
            this.tableMedCard.MouseEnter += new System.EventHandler(this.tableMedCard_MouseEnter);
            this.tableMedCard.MouseLeave += new System.EventHandler(this.tableMedCard_MouseLeave);
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.Font = new System.Drawing.Font("Noto Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonDelete.Location = new System.Drawing.Point(609, 409);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(188, 38);
            this.ButtonDelete.TabIndex = 12;
            this.ButtonDelete.Text = "УДАЛИТЬ";
            this.ButtonDelete.UseVisualStyleBackColor = true;
            // 
            // ButtonUpdate
            // 
            this.ButtonUpdate.Font = new System.Drawing.Font("Noto Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonUpdate.Location = new System.Drawing.Point(405, 409);
            this.ButtonUpdate.Name = "ButtonUpdate";
            this.ButtonUpdate.Size = new System.Drawing.Size(198, 38);
            this.ButtonUpdate.TabIndex = 13;
            this.ButtonUpdate.Text = "ИЗМЕНИТЬ";
            this.ButtonUpdate.UseVisualStyleBackColor = true;
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Font = new System.Drawing.Font("Noto Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonAdd.Location = new System.Drawing.Point(206, 409);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(193, 38);
            this.ButtonAdd.TabIndex = 14;
            this.ButtonAdd.Text = "ДОБАВИТЬ";
            this.ButtonAdd.UseVisualStyleBackColor = true;
            // 
            // ButtonSelect
            // 
            this.ButtonSelect.Font = new System.Drawing.Font("Noto Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonSelect.Location = new System.Drawing.Point(3, 409);
            this.ButtonSelect.Name = "ButtonSelect";
            this.ButtonSelect.Size = new System.Drawing.Size(197, 38);
            this.ButtonSelect.TabIndex = 15;
            this.ButtonSelect.Text = "ПРОСМОТРЕТЬ";
            this.ButtonSelect.UseVisualStyleBackColor = true;
            this.ButtonSelect.Click += new System.EventHandler(this.button1_Click);
            // 
            // ComandForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ComandPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ComandForm";
            this.Text = "ComandForm";
            this.ComandPanel.ResumeLayout(false);
            this.ComandPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ComandPanel;
        private System.Windows.Forms.Button ButtonSelect;
        private System.Windows.Forms.Button ButtonDelete;
        private System.Windows.Forms.Button ButtonUpdate;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.Label tableSex;
        private System.Windows.Forms.Label tablePet;
        private System.Windows.Forms.Label tableOwner;
        private System.Windows.Forms.Label tableVeterinarian;
        private System.Windows.Forms.Label tableDiagnosis;
        private System.Windows.Forms.Label tableTreatment;
        private System.Windows.Forms.Label tableDrug;
        private System.Windows.Forms.Label tableMedCard;
        private System.Windows.Forms.Label closeButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox comboBoxTable;
    }
}