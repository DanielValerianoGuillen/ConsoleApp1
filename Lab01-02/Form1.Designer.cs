namespace Lab01_02
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            checkBox1 = new CheckBox();
            label7 = new Label();
            label8 = new Label();
            txtNombre = new TextBox();
            txtDNI = new TextBox();
            texttxtApellido = new TextBox();
            txtDireccion = new TextBox();
            txtTelefono = new TextBox();
            txtEmail = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            button1 = new Button();
            label9 = new Label();
            dataGridView1 = new DataGridView();
            Codigo = new DataGridViewTextBoxColumn();
            DNI = new DataGridViewTextBoxColumn();
            NOMBRE = new DataGridViewTextBoxColumn();
            APELLIDO = new DataGridViewTextBoxColumn();
            DIRECCION = new DataGridViewTextBoxColumn();
            TELEFONO = new DataGridViewTextBoxColumn();
            EMAIL = new DataGridViewTextBoxColumn();
            FECHA_NACIMIENTO = new DataGridViewTextBoxColumn();
            DEPARTAMENTO = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            label12 = new Label();
            comboBoxCargo = new ComboBox();
            comboBoxDepartamento = new ComboBox();
            label11 = new Label();
            label10 = new Label();
            groupBox2 = new GroupBox();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            fileSystemWatcher1 = new FileSystemWatcher();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 33);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 0;
            label1.Text = "Codigo";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 56);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 84);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 2;
            label3.Text = "Apellido";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 113);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 3;
            label4.Text = "Dirrecion";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(274, 54);
            label5.Name = "label5";
            label5.Size = new Size(27, 15);
            label5.TabIndex = 4;
            label5.Text = "DNI";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 142);
            label6.Name = "label6";
            label6.Size = new Size(52, 15);
            label6.TabIndex = 5;
            label6.Text = "Telefono";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(296, 197);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(60, 19);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "Activo";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(16, 172);
            label7.Name = "label7";
            label7.Size = new Size(36, 15);
            label7.TabIndex = 7;
            label7.Text = "Email";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 197);
            label8.Name = "label8";
            label8.Size = new Size(56, 15);
            label8.TabIndex = 8;
            label8.Text = "Fecha Na";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(68, 51);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(200, 23);
            txtNombre.TabIndex = 9;
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(314, 51);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(100, 23);
            txtDNI.TabIndex = 10;
            // 
            // texttxtApellido
            // 
            texttxtApellido.Location = new Point(68, 76);
            texttxtApellido.Name = "texttxtApellido";
            texttxtApellido.Size = new Size(200, 23);
            texttxtApellido.TabIndex = 11;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(68, 110);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(200, 23);
            txtDireccion.TabIndex = 12;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(68, 142);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(200, 23);
            txtTelefono.TabIndex = 13;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(68, 171);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(200, 23);
            txtEmail.TabIndex = 14;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(68, 195);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 15;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.HotTrack;
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(381, 275);
            button1.Name = "button1";
            button1.Size = new Size(130, 58);
            button1.TabIndex = 16;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = SystemColors.InactiveBorder;
            label9.BorderStyle = BorderStyle.FixedSingle;
            label9.ForeColor = SystemColors.HotTrack;
            label9.Location = new Point(68, 31);
            label9.Name = "label9";
            label9.Size = new Size(44, 17);
            label9.TabIndex = 17;
            label9.Text = "UI0000";
            label9.Click += label9_Click_1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Codigo, DNI, NOMBRE, APELLIDO, DIRECCION, TELEFONO, EMAIL, FECHA_NACIMIENTO, DEPARTAMENTO });
            dataGridView1.Location = new Point(30, 358);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1052, 130);
            dataGridView1.TabIndex = 18;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Codigo
            // 
            Codigo.HeaderText = "CODIGO";
            Codigo.Name = "Codigo";
            // 
            // DNI
            // 
            DNI.HeaderText = "DNI";
            DNI.Name = "DNI";
            // 
            // NOMBRE
            // 
            NOMBRE.HeaderText = "NOMBRE";
            NOMBRE.Name = "NOMBRE";
            // 
            // APELLIDO
            // 
            APELLIDO.HeaderText = "APELLIDO";
            APELLIDO.Name = "APELLIDO";
            // 
            // DIRECCION
            // 
            DIRECCION.HeaderText = "DIRECCION";
            DIRECCION.Name = "DIRECCION";
            // 
            // TELEFONO
            // 
            TELEFONO.HeaderText = "TELEFONO";
            TELEFONO.Name = "TELEFONO";
            // 
            // EMAIL
            // 
            EMAIL.HeaderText = "EMAIL";
            EMAIL.Name = "EMAIL";
            // 
            // FECHA_NACIMIENTO
            // 
            FECHA_NACIMIENTO.HeaderText = "FECHA NACIMIENTO";
            FECHA_NACIMIENTO.Name = "FECHA_NACIMIENTO";
            // 
            // DEPARTAMENTO
            // 
            DEPARTAMENTO.HeaderText = "DEPARTAMENTO";
            DEPARTAMENTO.Name = "DEPARTAMENTO";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ButtonHighlight;
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(comboBoxCargo);
            groupBox1.Controls.Add(comboBoxDepartamento);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label10);
            groupBox1.Location = new Point(502, 31);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(317, 224);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informacion Personal";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(28, 115);
            label12.Name = "label12";
            label12.Size = new Size(0, 15);
            label12.TabIndex = 6;
            // 
            // comboBoxCargo
            // 
            comboBoxCargo.FormattingEnabled = true;
            comboBoxCargo.Location = new Point(140, 64);
            comboBoxCargo.Name = "comboBoxCargo";
            comboBoxCargo.Size = new Size(121, 23);
            comboBoxCargo.TabIndex = 5;
            // 
            // comboBoxDepartamento
            // 
            comboBoxDepartamento.FormattingEnabled = true;
            comboBoxDepartamento.Items.AddRange(new object[] { "1" });
            comboBoxDepartamento.Location = new Point(140, 31);
            comboBoxDepartamento.Name = "comboBoxDepartamento";
            comboBoxDepartamento.Size = new Size(121, 23);
            comboBoxDepartamento.TabIndex = 4;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(28, 72);
            label11.Name = "label11";
            label11.Size = new Size(39, 15);
            label11.TabIndex = 3;
            label11.Text = "Cargo";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(28, 34);
            label10.Name = "label10";
            label10.Size = new Size(83, 15);
            label10.TabIndex = 2;
            label10.Text = "Departamento";
            label10.Click += label10_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ButtonHighlight;
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(txtNombre);
            groupBox2.Controls.Add(checkBox1);
            groupBox2.Controls.Add(txtDNI);
            groupBox2.Controls.Add(dateTimePicker1);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(txtEmail);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(texttxtApellido);
            groupBox2.Controls.Add(txtTelefono);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(txtDireccion);
            groupBox2.Controls.Add(label6);
            groupBox2.Location = new Point(24, 28);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(420, 227);
            groupBox2.TabIndex = 20;
            groupBox2.TabStop = false;
            groupBox2.Text = "Datos Personales";
            // 
            // button2
            // 
            button2.Location = new Point(520, 275);
            button2.Name = "button2";
            button2.Size = new Size(104, 58);
            button2.TabIndex = 21;
            button2.Text = "Modifcar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(632, 275);
            button3.Name = "button3";
            button3.Size = new Size(104, 58);
            button3.TabIndex = 22;
            button3.Text = "Eliminar";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(742, 275);
            button4.Name = "button4";
            button4.Size = new Size(104, 58);
            button4.TabIndex = 23;
            button4.Text = "Buscar";
            button4.UseVisualStyleBackColor = true;
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1215, 649);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private CheckBox checkBox1;
        private Label label7;
        private Label label8;
        private TextBox txtNombre;
        private TextBox txtDNI;
        private TextBox texttxtApellido;
        private TextBox txtDireccion;
        private TextBox txtTelefono;
        private TextBox txtEmail;
        private DateTimePicker dateTimePicker1;
        private Button button1;
        private Label label9;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn DNI;
        private DataGridViewTextBoxColumn NOMBRE;
        private DataGridViewTextBoxColumn APELLIDO;
        private DataGridViewTextBoxColumn DIRECCION;
        private DataGridViewTextBoxColumn TELEFONO;
        private DataGridViewTextBoxColumn EMAIL;
        private DataGridViewTextBoxColumn FECHA_NACIMIENTO;
        private DataGridViewTextBoxColumn DEPARTAMENTO;
        private GroupBox groupBox1;
        private Label label11;
        private Label label10;
        private GroupBox groupBox2;
        private Button button2;
        private Label label12;
        private ComboBox comboBoxCargo;
        private ComboBox comboBoxDepartamento;
        private Button button3;
        private Button button4;
        private FileSystemWatcher fileSystemWatcher1;
    }
}