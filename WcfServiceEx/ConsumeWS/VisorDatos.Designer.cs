﻿namespace ConsumeWS
{
    partial class VisorDatos
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
            this.btAceptar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbAPaterno = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbAMaterno = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbArea = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.dtTimeDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btAceptar
            // 
            this.btAceptar.Location = new System.Drawing.Point(249, 96);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(75, 37);
            this.btAceptar.TabIndex = 0;
            this.btAceptar.Text = "Aceptar";
            this.btAceptar.UseVisualStyleBackColor = true;
            this.btAceptar.Click += new System.EventHandler(this.btAceptar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Datos del Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(12, 64);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(100, 20);
            this.tbNombre.TabIndex = 3;
            // 
            // tbAPaterno
            // 
            this.tbAPaterno.Location = new System.Drawing.Point(118, 64);
            this.tbAPaterno.Name = "tbAPaterno";
            this.tbAPaterno.Size = new System.Drawing.Size(100, 20);
            this.tbAPaterno.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "A. Paterno";
            // 
            // tbAMaterno
            // 
            this.tbAMaterno.Location = new System.Drawing.Point(224, 64);
            this.tbAMaterno.Name = "tbAMaterno";
            this.tbAMaterno.Size = new System.Drawing.Size(100, 20);
            this.tbAMaterno.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(224, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "A. Materno";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Fecha de Nac";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(210, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Status";
            // 
            // tbArea
            // 
            this.tbArea.Location = new System.Drawing.Point(118, 107);
            this.tbArea.Name = "tbArea";
            this.tbArea.Size = new System.Drawing.Size(100, 20);
            this.tbArea.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(120, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Area";
            // 
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "Alta",
            "Baja"});
            this.cbStatus.Location = new System.Drawing.Point(253, 6);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(71, 21);
            this.cbStatus.TabIndex = 14;
            // 
            // dtTimeDate
            // 
            this.dtTimeDate.Checked = false;
            this.dtTimeDate.CustomFormat = "";
            this.dtTimeDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTimeDate.Location = new System.Drawing.Point(12, 107);
            this.dtTimeDate.Name = "dtTimeDate";
            this.dtTimeDate.Size = new System.Drawing.Size(100, 20);
            this.dtTimeDate.TabIndex = 15;
            this.dtTimeDate.Value = new System.DateTime(2020, 6, 15, 0, 0, 0, 0);
            // 
            // VisorDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 145);
            this.Controls.Add(this.dtTimeDate);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.tbArea);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbAMaterno);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbAPaterno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btAceptar);
            this.Name = "VisorDatos";
            this.Text = "VisorDatos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btAceptar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbAPaterno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbAMaterno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbArea;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.DateTimePicker dtTimeDate;
    }
}