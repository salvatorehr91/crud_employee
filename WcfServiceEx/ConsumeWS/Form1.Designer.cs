namespace ConsumeWS
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btAceptar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.tbContra = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btNewData = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            //this.desarrolloDataSet = new ConsumeWS.DesarrolloDataSet();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            //this.employeeTableAdapter = new ConsumeWS.DesarrolloDataSetTableAdapters.employeeTableAdapter();
            this.fIUNICODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fCCONTRASENADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fCNOMBREDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fCAPATERNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fCAMATERNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fDNACIMIENTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fCSTATUSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fCAREAEMPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.btEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            //((System.ComponentModel.ISupportInitialize)(this.desarrolloDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btAceptar
            // 
            this.btAceptar.Location = new System.Drawing.Point(149, 74);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(75, 23);
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
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Validacion de Empleado";
            // 
            // tbUser
            // 
            this.tbUser.Location = new System.Drawing.Point(12, 48);
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(106, 20);
            this.tbUser.TabIndex = 3;
            // 
            // tbContra
            // 
            this.tbContra.Location = new System.Drawing.Point(124, 48);
            this.tbContra.Name = "tbContra";
            this.tbContra.Size = new System.Drawing.Size(100, 20);
            this.tbContra.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(121, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Contraseña";
            // 
            // btNewData
            // 
            this.btNewData.AutoSize = true;
            this.btNewData.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNewData.Location = new System.Drawing.Point(12, 79);
            this.btNewData.Name = "btNewData";
            this.btNewData.Size = new System.Drawing.Size(81, 13);
            this.btNewData.TabIndex = 7;
            this.btNewData.Text = "Nuevo Registro";
            this.btNewData.Click += new System.EventHandler(this.btNewData_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fIUNICODataGridViewTextBoxColumn,
            this.fCCONTRASENADataGridViewTextBoxColumn,
            this.fCNOMBREDataGridViewTextBoxColumn,
            this.fCAPATERNODataGridViewTextBoxColumn,
            this.fCAMATERNODataGridViewTextBoxColumn,
            this.fDNACIMIENTODataGridViewTextBoxColumn,
            this.fCSTATUSDataGridViewTextBoxColumn,
            this.fCAREAEMPDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.employeeBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 132);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(862, 150);
            this.dataGridView1.TabIndex = 9;
            // 
            // desarrolloDataSet
            // 
            //this.desarrolloDataSet.DataSetName = "DesarrolloDataSet";
            //this.desarrolloDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "employee";
            //this.employeeBindingSource.DataSource = this.desarrolloDataSet;
            // 
            // employeeTableAdapter
            // 
            //this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // fIUNICODataGridViewTextBoxColumn
            // 
            this.fIUNICODataGridViewTextBoxColumn.DataPropertyName = "FIUNICO";
            this.fIUNICODataGridViewTextBoxColumn.HeaderText = "FIUNICO";
            this.fIUNICODataGridViewTextBoxColumn.Name = "fIUNICODataGridViewTextBoxColumn";
            this.fIUNICODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fCCONTRASENADataGridViewTextBoxColumn
            // 
            this.fCCONTRASENADataGridViewTextBoxColumn.DataPropertyName = "FCCONTRASENA";
            this.fCCONTRASENADataGridViewTextBoxColumn.HeaderText = "FCCONTRASENA";
            this.fCCONTRASENADataGridViewTextBoxColumn.Name = "fCCONTRASENADataGridViewTextBoxColumn";
            this.fCCONTRASENADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fCNOMBREDataGridViewTextBoxColumn
            // 
            this.fCNOMBREDataGridViewTextBoxColumn.DataPropertyName = "FCNOMBRE";
            this.fCNOMBREDataGridViewTextBoxColumn.HeaderText = "FCNOMBRE";
            this.fCNOMBREDataGridViewTextBoxColumn.Name = "fCNOMBREDataGridViewTextBoxColumn";
            // 
            // fCAPATERNODataGridViewTextBoxColumn
            // 
            this.fCAPATERNODataGridViewTextBoxColumn.DataPropertyName = "FCAPATERNO";
            this.fCAPATERNODataGridViewTextBoxColumn.HeaderText = "FCAPATERNO";
            this.fCAPATERNODataGridViewTextBoxColumn.Name = "fCAPATERNODataGridViewTextBoxColumn";
            // 
            // fCAMATERNODataGridViewTextBoxColumn
            // 
            this.fCAMATERNODataGridViewTextBoxColumn.DataPropertyName = "FCAMATERNO";
            this.fCAMATERNODataGridViewTextBoxColumn.HeaderText = "FCAMATERNO";
            this.fCAMATERNODataGridViewTextBoxColumn.Name = "fCAMATERNODataGridViewTextBoxColumn";
            // 
            // fDNACIMIENTODataGridViewTextBoxColumn
            // 
            this.fDNACIMIENTODataGridViewTextBoxColumn.DataPropertyName = "FDNACIMIENTO";
            this.fDNACIMIENTODataGridViewTextBoxColumn.HeaderText = "FDNACIMIENTO";
            this.fDNACIMIENTODataGridViewTextBoxColumn.Name = "fDNACIMIENTODataGridViewTextBoxColumn";
            // 
            // fCSTATUSDataGridViewTextBoxColumn
            // 
            this.fCSTATUSDataGridViewTextBoxColumn.DataPropertyName = "FCSTATUS";
            this.fCSTATUSDataGridViewTextBoxColumn.HeaderText = "FCSTATUS";
            this.fCSTATUSDataGridViewTextBoxColumn.Name = "fCSTATUSDataGridViewTextBoxColumn";
            // 
            // fCAREAEMPDataGridViewTextBoxColumn
            // 
            this.fCAREAEMPDataGridViewTextBoxColumn.DataPropertyName = "FCAREAEMP";
            this.fCAREAEMPDataGridViewTextBoxColumn.HeaderText = "FCAREAEMP";
            this.fCAREAEMPDataGridViewTextBoxColumn.Name = "fCAREAEMPDataGridViewTextBoxColumn";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(799, 103);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Actualizar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btEliminar
            // 
            this.btEliminar.Location = new System.Drawing.Point(149, 103);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(75, 23);
            this.btEliminar.TabIndex = 11;
            this.btEliminar.Text = "Eliminar";
            this.btEliminar.UseVisualStyleBackColor = true;
            this.btEliminar.Click += new System.EventHandler(this.btEliminar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 294);
            this.Controls.Add(this.btEliminar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btNewData);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbContra);
            this.Controls.Add(this.tbUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btAceptar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            //((System.ComponentModel.ISupportInitialize)(this.desarrolloDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btAceptar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.TextBox tbContra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label btNewData;
        private System.Windows.Forms.DataGridView dataGridView1;
        //private DesarrolloDataSet desarrolloDataSet;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        //private DesarrolloDataSetTableAdapters.employeeTableAdapter employeeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIUNICODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fCCONTRASENADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fCNOMBREDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fCAPATERNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fCAMATERNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fDNACIMIENTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fCSTATUSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fCAREAEMPDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btEliminar;
    }
}

