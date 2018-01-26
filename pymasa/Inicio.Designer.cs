namespace pymasa
{
    partial class Inicio
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Cmd_eliminar = new System.Windows.Forms.Button();
            this.Cmd_modificar = new System.Windows.Forms.Button();
            this.Cmd_nuevo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.GridColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgv.Location = new System.Drawing.Point(38, 165);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.Size = new System.Drawing.Size(757, 338);
            this.dgv.TabIndex = 0;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Obtenerid);
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Obtenerid);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(45, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lista de empleados";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Controls.Add(this.Cmd_eliminar);
            this.groupBox1.Controls.Add(this.Cmd_modificar);
            this.groupBox1.Controls.Add(this.Cmd_nuevo);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox1.Location = new System.Drawing.Point(419, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(359, 87);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Acciones";
            // 
            // Cmd_eliminar
            // 
            this.Cmd_eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmd_eliminar.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Cmd_eliminar.Location = new System.Drawing.Point(242, 42);
            this.Cmd_eliminar.Name = "Cmd_eliminar";
            this.Cmd_eliminar.Size = new System.Drawing.Size(82, 25);
            this.Cmd_eliminar.TabIndex = 2;
            this.Cmd_eliminar.Text = "&Eliminar";
            this.Cmd_eliminar.UseVisualStyleBackColor = true;
            this.Cmd_eliminar.Click += new System.EventHandler(this.Cmd_eliminar_Click);
            // 
            // Cmd_modificar
            // 
            this.Cmd_modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmd_modificar.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Cmd_modificar.Location = new System.Drawing.Point(137, 42);
            this.Cmd_modificar.Name = "Cmd_modificar";
            this.Cmd_modificar.Size = new System.Drawing.Size(87, 25);
            this.Cmd_modificar.TabIndex = 1;
            this.Cmd_modificar.Text = "&Modificar";
            this.Cmd_modificar.UseVisualStyleBackColor = true;
            this.Cmd_modificar.Click += new System.EventHandler(this.Cmd_modificar_Click);
            // 
            // Cmd_nuevo
            // 
            this.Cmd_nuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmd_nuevo.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Cmd_nuevo.Location = new System.Drawing.Point(31, 42);
            this.Cmd_nuevo.Name = "Cmd_nuevo";
            this.Cmd_nuevo.Size = new System.Drawing.Size(82, 25);
            this.Cmd_nuevo.TabIndex = 0;
            this.Cmd_nuevo.Text = "&Nuevo";
            this.Cmd_nuevo.UseVisualStyleBackColor = true;
            this.Cmd_nuevo.Click += new System.EventHandler(this.Cmd_nuevo_Click);
            // 
            // Inicio
            // 
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(844, 515);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv);
            this.Name = "Inicio";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

      
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Cmd_eliminar;
        private System.Windows.Forms.Button Cmd_modificar;
        private System.Windows.Forms.Button Cmd_nuevo;
    }
}

