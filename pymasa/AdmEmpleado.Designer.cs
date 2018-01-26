namespace pymasa
{
    partial class AdmEmpleado
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
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_nombre = new System.Windows.Forms.TextBox();
            this.Txt_appaterno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_apmaterno = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Cbx_departamento = new System.Windows.Forms.ComboBox();
            this.Txt_sueldo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Txt_fecha = new System.Windows.Forms.DateTimePicker();
            this.CMD_guardar = new System.Windows.Forms.Button();
            this.tipo = new System.Windows.Forms.TextBox();
            this.CMD_cancelar = new System.Windows.Forms.Button();
            this.Txt_id = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(30, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // Txt_nombre
            // 
            this.Txt_nombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_nombre.Location = new System.Drawing.Point(138, 45);
            this.Txt_nombre.Name = "Txt_nombre";
            this.Txt_nombre.Size = new System.Drawing.Size(213, 20);
            this.Txt_nombre.TabIndex = 2;
            this.Txt_nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sololetras);
            // 
            // Txt_appaterno
            // 
            this.Txt_appaterno.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_appaterno.Location = new System.Drawing.Point(171, 84);
            this.Txt_appaterno.Name = "Txt_appaterno";
            this.Txt_appaterno.Size = new System.Drawing.Size(180, 20);
            this.Txt_appaterno.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(30, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Apellido paterno:";
            // 
            // Txt_apmaterno
            // 
            this.Txt_apmaterno.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_apmaterno.Location = new System.Drawing.Point(171, 121);
            this.Txt_apmaterno.Name = "Txt_apmaterno";
            this.Txt_apmaterno.Size = new System.Drawing.Size(180, 20);
            this.Txt_apmaterno.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(30, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Apellido materno:";
            // 
            // Cbx_departamento
            // 
            this.Cbx_departamento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Cbx_departamento.FormattingEnabled = true;
            this.Cbx_departamento.Location = new System.Drawing.Point(171, 165);
            this.Cbx_departamento.Name = "Cbx_departamento";
            this.Cbx_departamento.Size = new System.Drawing.Size(180, 21);
            this.Cbx_departamento.TabIndex = 7;
            // 
            // Txt_sueldo
            // 
            this.Txt_sueldo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_sueldo.Location = new System.Drawing.Point(100, 211);
            this.Txt_sueldo.Name = "Txt_sueldo";
            this.Txt_sueldo.Size = new System.Drawing.Size(97, 20);
            this.Txt_sueldo.TabIndex = 8;
            this.Txt_sueldo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.solonumeros);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(30, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Departamento";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(30, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Sueldo:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Location = new System.Drawing.Point(30, 249);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Fecha de nacimiento:";
            // 
            // Txt_fecha
            // 
            this.Txt_fecha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_fecha.CustomFormat = "";
            this.Txt_fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Txt_fecha.Location = new System.Drawing.Point(203, 249);
            this.Txt_fecha.Name = "Txt_fecha";
            this.Txt_fecha.Size = new System.Drawing.Size(147, 20);
            this.Txt_fecha.TabIndex = 12;
            // 
            // CMD_guardar
            // 
            this.CMD_guardar.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMD_guardar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.CMD_guardar.Location = new System.Drawing.Point(34, 299);
            this.CMD_guardar.Name = "CMD_guardar";
            this.CMD_guardar.Size = new System.Drawing.Size(121, 42);
            this.CMD_guardar.TabIndex = 13;
            this.CMD_guardar.Text = "Guardar";
            this.CMD_guardar.UseVisualStyleBackColor = true;
            this.CMD_guardar.Click += new System.EventHandler(this.CMD_guardar_Click);
            // 
            // tipo
            // 
            this.tipo.Location = new System.Drawing.Point(237, 12);
            this.tipo.Name = "tipo";
            this.tipo.Size = new System.Drawing.Size(100, 20);
            this.tipo.TabIndex = 15;
            this.tipo.Visible = false;
            // 
            // CMD_cancelar
            // 
            this.CMD_cancelar.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMD_cancelar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.CMD_cancelar.Location = new System.Drawing.Point(203, 299);
            this.CMD_cancelar.Name = "CMD_cancelar";
            this.CMD_cancelar.Size = new System.Drawing.Size(121, 42);
            this.CMD_cancelar.TabIndex = 16;
            this.CMD_cancelar.Text = "Cancelar";
            this.CMD_cancelar.UseVisualStyleBackColor = true;
            this.CMD_cancelar.Click += new System.EventHandler(this.CMD_cancelar_Click_1);
            // 
            // Txt_id
            // 
            this.Txt_id.Location = new System.Drawing.Point(131, 12);
            this.Txt_id.Name = "Txt_id";
            this.Txt_id.Size = new System.Drawing.Size(100, 20);
            this.Txt_id.TabIndex = 17;
            this.Txt_id.Visible = false;
            this.Txt_id.TextChanged += new System.EventHandler(this.Txt_id_TextChanged);
            // 
            // AdmEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(377, 380);
            this.ControlBox = false;
            this.Controls.Add(this.Txt_id);
            this.Controls.Add(this.CMD_cancelar);
            this.Controls.Add(this.tipo);
            this.Controls.Add(this.CMD_guardar);
            this.Controls.Add(this.Txt_fecha);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Txt_sueldo);
            this.Controls.Add(this.Cbx_departamento);
            this.Controls.Add(this.Txt_apmaterno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Txt_appaterno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Txt_nombre);
            this.Controls.Add(this.label1);
            this.Name = "AdmEmpleado";
            this.Text = "Administración de empleados";
            this.Load += new System.EventHandler(this.AdmEmpleado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button CMD_guardar;
        public System.Windows.Forms.TextBox Txt_sueldo;
        public System.Windows.Forms.TextBox Txt_nombre;
        public System.Windows.Forms.TextBox Txt_appaterno;
        public System.Windows.Forms.TextBox Txt_apmaterno;
        public System.Windows.Forms.ComboBox Cbx_departamento;
        public System.Windows.Forms.DateTimePicker Txt_fecha;
        public System.Windows.Forms.TextBox tipo;
        private System.Windows.Forms.Button CMD_cancelar;
        public System.Windows.Forms.TextBox Txt_id;
    }
}