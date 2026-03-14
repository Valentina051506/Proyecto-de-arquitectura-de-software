namespace RedMotorERP
{
    partial class ClientesForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button2 = new Button();
            button1 = new Button();
            txtNombre = new TextBox();
            txtTipoDocumento = new TextBox();
            txtDocumento = new TextBox();
            txtTelefono = new TextBox();
            txtCorreo = new TextBox();
            tablaClientes = new DataGridView();
            buttonActualizar = new Button();
            buttonEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)tablaClientes).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(131, 26);
            label1.TabIndex = 0;
            label1.Text = "CLIENTES";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(29, 79);
            label2.Name = "label2";
            label2.Size = new Size(63, 19);
            label2.TabIndex = 1;
            label2.Text = "Nombre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(29, 166);
            label3.Name = "label3";
            label3.Size = new Size(82, 19);
            label3.TabIndex = 2;
            label3.Text = "Documento:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(28, 206);
            label4.Name = "label4";
            label4.Size = new Size(64, 19);
            label4.TabIndex = 3;
            label4.Text = "Teléfono:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(36, 247);
            label5.Name = "label5";
            label5.Size = new Size(56, 19);
            label5.TabIndex = 10;
            label5.Text = "Correo:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(29, 116);
            label6.Name = "label6";
            label6.Size = new Size(129, 19);
            label6.TabIndex = 11;
            label6.Text = "Tipo de documento:";
            label6.Click += label6_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(381, 310);
            button2.Name = "button2";
            button2.Size = new Size(142, 37);
            button2.TabIndex = 14;
            button2.Text = "Limpiar";
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(12, 310);
            button1.Name = "button1";
            button1.Size = new Size(117, 37);
            button1.TabIndex = 13;
            button1.Text = "Guardar";
            button1.Click += button1_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(98, 75);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(203, 23);
            txtNombre.TabIndex = 15;
            // 
            // txtTipoDocumento
            // 
            txtTipoDocumento.Location = new Point(164, 112);
            txtTipoDocumento.Name = "txtTipoDocumento";
            txtTipoDocumento.Size = new Size(198, 23);
            txtTipoDocumento.TabIndex = 16;
            // 
            // txtDocumento
            // 
            txtDocumento.Location = new Point(117, 162);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(198, 23);
            txtDocumento.TabIndex = 17;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(106, 202);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(195, 23);
            txtTelefono.TabIndex = 18;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(98, 247);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(217, 23);
            txtCorreo.TabIndex = 19;
            // 
            // tablaClientes
            // 
            tablaClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tablaClientes.Location = new Point(12, 368);
            tablaClientes.Name = "tablaClientes";
            tablaClientes.Size = new Size(536, 218);
            tablaClientes.TabIndex = 20;
            tablaClientes.CellContentClick += tablaClientes_CellContentClick;
            // 
            // buttonActualizar
            // 
            buttonActualizar.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonActualizar.Location = new Point(135, 310);
            buttonActualizar.Name = "buttonActualizar";
            buttonActualizar.Size = new Size(117, 37);
            buttonActualizar.TabIndex = 21;
            buttonActualizar.Text = "Actualizar";
            buttonActualizar.Click += buttonActualizar_Click;

            // 
            // buttonEliminar
            // 
            buttonEliminar.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonEliminar.Location = new Point(258, 310);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(117, 37);
            buttonEliminar.TabIndex = 22;
            buttonEliminar.Text = "Eliminar";
            buttonEliminar.Click += buttonEliminar_Click;
            // 
            // ClientesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(763, 598);
            Controls.Add(buttonEliminar);
            Controls.Add(buttonActualizar);
            Controls.Add(tablaClientes);
            Controls.Add(txtCorreo);
            Controls.Add(txtTelefono);
            Controls.Add(txtDocumento);
            Controls.Add(txtTipoDocumento);
            Controls.Add(txtNombre);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ClientesForm";
            Text = "Form2";
            Load += ClientesForm_Load;
            ((System.ComponentModel.ISupportInitialize)tablaClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button2;
        private Button button1;
        private TextBox txtNombre;
        private TextBox txtTipoDocumento;
        private TextBox txtDocumento;
        private TextBox txtTelefono;
        private TextBox txtCorreo;
        private DataGridView tablaClientes;
        private Button buttonActualizar;
        private Button buttonEliminar;
    }
}