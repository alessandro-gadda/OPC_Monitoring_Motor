﻿namespace OPC_CTPACK_Software
{
    partial class Form0
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form0));
            this.butAnalisi = new System.Windows.Forms.Button();
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.comboBoxFormato = new System.Windows.Forms.ComboBox();
            this.butPath = new System.Windows.Forms.Button();
            this.butAvanti = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // butAnalisi
            // 
            this.butAnalisi.Enabled = false;
            this.butAnalisi.Location = new System.Drawing.Point(52, 45);
            this.butAnalisi.Name = "butAnalisi";
            this.butAnalisi.Size = new System.Drawing.Size(249, 144);
            this.butAnalisi.TabIndex = 0;
            this.butAnalisi.Text = "Start Analisi";
            this.butAnalisi.UseVisualStyleBackColor = true;
            // 
            // textBoxPath
            // 
            this.textBoxPath.Enabled = false;
            this.textBoxPath.Location = new System.Drawing.Point(358, 155);
            this.textBoxPath.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.Size = new System.Drawing.Size(330, 31);
            this.textBoxPath.TabIndex = 1;
            this.textBoxPath.Text = "Inserire dove salvare il file .CSV";
            this.textBoxPath.TextChanged += new System.EventHandler(this.textBoxPath_TextChanged);
            // 
            // comboBoxFormato
            // 
            this.comboBoxFormato.BackColor = System.Drawing.Color.LightGreen;
            this.comboBoxFormato.FormattingEnabled = true;
            this.comboBoxFormato.Items.AddRange(new object[] {
            "Catena Choco Rolles formato 1",
            "Masse Choco Rolles formato 1"});
            this.comboBoxFormato.Location = new System.Drawing.Point(358, 45);
            this.comboBoxFormato.Name = "comboBoxFormato";
            this.comboBoxFormato.Size = new System.Drawing.Size(390, 33);
            this.comboBoxFormato.TabIndex = 2;
            this.comboBoxFormato.Text = "Selezionare Cinematismo/Formato";
            this.comboBoxFormato.SelectedIndexChanged += new System.EventHandler(this.comboBoxFormato_SelectedIndexChanged);
            // 
            // butPath
            // 
            this.butPath.Enabled = false;
            this.butPath.Location = new System.Drawing.Point(698, 155);
            this.butPath.Name = "butPath";
            this.butPath.Size = new System.Drawing.Size(52, 34);
            this.butPath.TabIndex = 3;
            this.butPath.Text = "...";
            this.butPath.UseVisualStyleBackColor = true;
            this.butPath.Click += new System.EventHandler(this.butPath_Click);
            // 
            // butAvanti
            // 
            this.butAvanti.Location = new System.Drawing.Point(638, 200);
            this.butAvanti.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.butAvanti.Name = "butAvanti";
            this.butAvanti.Size = new System.Drawing.Size(112, 36);
            this.butAvanti.TabIndex = 8;
            this.butAvanti.Text = "Avanti >";
            this.butAvanti.UseVisualStyleBackColor = true;
            this.butAvanti.Click += new System.EventHandler(this.butAvanti_Click);
            // 
            // Form0
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 750);
            this.Controls.Add(this.butAvanti);
            this.Controls.Add(this.butPath);
            this.Controls.Add(this.comboBoxFormato);
            this.Controls.Add(this.textBoxPath);
            this.Controls.Add(this.butAnalisi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form0";
            this.Text = "OPC";
            this.Load += new System.EventHandler(this.Form0_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butAnalisi;
        private System.Windows.Forms.TextBox textBoxPath;
        private System.Windows.Forms.ComboBox comboBoxFormato;
        private System.Windows.Forms.Button butPath;
        private System.Windows.Forms.Button butAvanti;
        public System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}