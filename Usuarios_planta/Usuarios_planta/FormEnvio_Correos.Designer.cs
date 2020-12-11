namespace Usuarios_planta
{
    partial class FormEnvio_Correos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Txtcod_convenio = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.dgvCorreos_Pendientes = new System.Windows.Forms.DataGridView();
            this.label38 = new System.Windows.Forms.Label();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtDestinatario_Correo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtAsunto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Btnbuscar = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtpHora_Envio = new System.Windows.Forms.DateTimePicker();
            this.label34 = new System.Windows.Forms.Label();
            this.lblfecha = new System.Windows.Forms.Label();
            this.TxtCorreo_Gic = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDescargar_Excel = new FontAwesome.Sharp.IconButton();
            this.btnEnviar_Correo = new FontAwesome.Sharp.IconButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtNombre_Archivo = new System.Windows.Forms.TextBox();
            this.btnVer_pte_Correos = new FontAwesome.Sharp.IconButton();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpfecha = new System.Windows.Forms.DateTimePicker();
            this.Btn_Actualizadb = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCorreos_Pendientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btnbuscar)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // Txtcod_convenio
            // 
            this.Txtcod_convenio.BackColor = System.Drawing.SystemColors.Window;
            this.Txtcod_convenio.Enabled = false;
            this.Txtcod_convenio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtcod_convenio.Location = new System.Drawing.Point(15, 27);
            this.Txtcod_convenio.Multiline = true;
            this.Txtcod_convenio.Name = "Txtcod_convenio";
            this.Txtcod_convenio.Size = new System.Drawing.Size(133, 28);
            this.Txtcod_convenio.TabIndex = 31;
            this.Txtcod_convenio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Txtcod_convenio.TextChanged += new System.EventHandler(this.Txtcod_convenio_TextChanged);
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(84)))));
            this.label30.Location = new System.Drawing.Point(423, 27);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(292, 25);
            this.label30.TabIndex = 248;
            this.label30.Text = "Gestion Correos VoBo Digital";
            // 
            // dgvCorreos_Pendientes
            // 
            this.dgvCorreos_Pendientes.AllowUserToAddRows = false;
            this.dgvCorreos_Pendientes.BackgroundColor = System.Drawing.Color.White;
            this.dgvCorreos_Pendientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvCorreos_Pendientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCorreos_Pendientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvCorreos_Pendientes.Location = new System.Drawing.Point(1135, 122);
            this.dgvCorreos_Pendientes.Name = "dgvCorreos_Pendientes";
            this.dgvCorreos_Pendientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvCorreos_Pendientes.RowHeadersVisible = false;
            this.dgvCorreos_Pendientes.Size = new System.Drawing.Size(212, 289);
            this.dgvCorreos_Pendientes.TabIndex = 251;
            this.dgvCorreos_Pendientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCorreos_Pendientes_CellClick);
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label38.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(84)))));
            this.label38.Location = new System.Drawing.Point(1169, 35);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(189, 18);
            this.label38.TabIndex = 250;
            this.label38.Text = "Pendientes Envio Convenio";
            // 
            // dgvDatos
            // 
            this.dgvDatos.AllowUserToAddRows = false;
            this.dgvDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDatos.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(101)))), ((int)(((byte)(124)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.EnableHeadersVisualStyles = false;
            this.dgvDatos.Location = new System.Drawing.Point(15, 82);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            this.dgvDatos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDatos.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvDatos.RowHeadersVisible = false;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvDatos.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvDatos.Size = new System.Drawing.Size(908, 244);
            this.dgvDatos.TabIndex = 253;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(84)))));
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 16);
            this.label1.TabIndex = 252;
            this.label1.Text = "Codigo Convenio";
            // 
            // TxtDestinatario_Correo
            // 
            this.TxtDestinatario_Correo.BackColor = System.Drawing.SystemColors.Window;
            this.TxtDestinatario_Correo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDestinatario_Correo.Location = new System.Drawing.Point(24, 446);
            this.TxtDestinatario_Correo.Multiline = true;
            this.TxtDestinatario_Correo.Name = "TxtDestinatario_Correo";
            this.TxtDestinatario_Correo.Size = new System.Drawing.Size(290, 76);
            this.TxtDestinatario_Correo.TabIndex = 255;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(84)))));
            this.label2.Location = new System.Drawing.Point(21, 427);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 256;
            this.label2.Text = "Destinatario";
            // 
            // TxtAsunto
            // 
            this.TxtAsunto.BackColor = System.Drawing.SystemColors.Window;
            this.TxtAsunto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAsunto.Location = new System.Drawing.Point(556, 28);
            this.TxtAsunto.Multiline = true;
            this.TxtAsunto.Name = "TxtAsunto";
            this.TxtAsunto.Size = new System.Drawing.Size(367, 28);
            this.TxtAsunto.TabIndex = 257;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(84)))));
            this.label4.Location = new System.Drawing.Point(12, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 259;
            this.label4.Text = "Datos";
            // 
            // Btnbuscar
            // 
            this.Btnbuscar.BackColor = System.Drawing.SystemColors.Window;
            this.Btnbuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btnbuscar.Image = global::Usuarios_planta.Properties.Resources.search_26px;
            this.Btnbuscar.Location = new System.Drawing.Point(123, 28);
            this.Btnbuscar.Name = "Btnbuscar";
            this.Btnbuscar.Size = new System.Drawing.Size(23, 26);
            this.Btnbuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Btnbuscar.TabIndex = 32;
            this.Btnbuscar.TabStop = false;
            this.Btnbuscar.Click += new System.EventHandler(this.Btnbuscar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(187)))), ((int)(((byte)(33)))));
            this.panel1.Location = new System.Drawing.Point(1059, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(312, 16);
            this.panel1.TabIndex = 263;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(101)))), ((int)(((byte)(124)))));
            this.panel2.Location = new System.Drawing.Point(607, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(455, 16);
            this.panel2.TabIndex = 264;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(84)))));
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(607, 16);
            this.panel3.TabIndex = 265;
            // 
            // dtpHora_Envio
            // 
            this.dtpHora_Envio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpHora_Envio.CustomFormat = "HH:mm";
            this.dtpHora_Envio.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F);
            this.dtpHora_Envio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHora_Envio.Location = new System.Drawing.Point(170, 28);
            this.dtpHora_Envio.Name = "dtpHora_Envio";
            this.dtpHora_Envio.Size = new System.Drawing.Size(109, 27);
            this.dtpHora_Envio.TabIndex = 266;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(84)))));
            this.label34.Location = new System.Drawing.Point(167, 7);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(85, 16);
            this.label34.TabIndex = 267;
            this.label34.Text = "Hora Envio";
            // 
            // lblfecha
            // 
            this.lblfecha.AutoSize = true;
            this.lblfecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(84)))));
            this.lblfecha.Location = new System.Drawing.Point(1295, 128);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(0, 16);
            this.lblfecha.TabIndex = 268;
            // 
            // TxtCorreo_Gic
            // 
            this.TxtCorreo_Gic.BackColor = System.Drawing.SystemColors.Window;
            this.TxtCorreo_Gic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCorreo_Gic.Location = new System.Drawing.Point(351, 443);
            this.TxtCorreo_Gic.Multiline = true;
            this.TxtCorreo_Gic.Name = "TxtCorreo_Gic";
            this.TxtCorreo_Gic.Size = new System.Drawing.Size(298, 79);
            this.TxtCorreo_Gic.TabIndex = 269;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(84)))));
            this.label5.Location = new System.Drawing.Point(349, 424);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 16);
            this.label5.TabIndex = 271;
            this.label5.Text = "Correo Gic";
            // 
            // btnDescargar_Excel
            // 
            this.btnDescargar_Excel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(84)))));
            this.btnDescargar_Excel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDescargar_Excel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDescargar_Excel.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnDescargar_Excel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDescargar_Excel.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDescargar_Excel.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            this.btnDescargar_Excel.IconColor = System.Drawing.Color.Gainsboro;
            this.btnDescargar_Excel.IconSize = 25;
            this.btnDescargar_Excel.Location = new System.Drawing.Point(938, 82);
            this.btnDescargar_Excel.Name = "btnDescargar_Excel";
            this.btnDescargar_Excel.Rotation = 0D;
            this.btnDescargar_Excel.Size = new System.Drawing.Size(137, 52);
            this.btnDescargar_Excel.TabIndex = 274;
            this.btnDescargar_Excel.Text = "Exp. Excel";
            this.btnDescargar_Excel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDescargar_Excel.UseVisualStyleBackColor = false;
            this.btnDescargar_Excel.Click += new System.EventHandler(this.btnDescargar_Excel_Click);
            // 
            // btnEnviar_Correo
            // 
            this.btnEnviar_Correo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(84)))));
            this.btnEnviar_Correo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnviar_Correo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviar_Correo.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnEnviar_Correo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar_Correo.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnEnviar_Correo.IconChar = FontAwesome.Sharp.IconChar.MailBulk;
            this.btnEnviar_Correo.IconColor = System.Drawing.Color.Gainsboro;
            this.btnEnviar_Correo.IconSize = 25;
            this.btnEnviar_Correo.Location = new System.Drawing.Point(938, 172);
            this.btnEnviar_Correo.Name = "btnEnviar_Correo";
            this.btnEnviar_Correo.Rotation = 0D;
            this.btnEnviar_Correo.Size = new System.Drawing.Size(137, 52);
            this.btnEnviar_Correo.TabIndex = 276;
            this.btnEnviar_Correo.Text = "Enviar Correo";
            this.btnEnviar_Correo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEnviar_Correo.UseVisualStyleBackColor = false;
            this.btnEnviar_Correo.Click += new System.EventHandler(this.btnEnviar_Correo_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gainsboro;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.Btn_Actualizadb);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.btnEnviar_Correo);
            this.panel4.Controls.Add(this.TxtNombre_Archivo);
            this.panel4.Controls.Add(this.Btnbuscar);
            this.panel4.Controls.Add(this.btnDescargar_Excel);
            this.panel4.Controls.Add(this.dgvDatos);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.Txtcod_convenio);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.label34);
            this.panel4.Controls.Add(this.TxtAsunto);
            this.panel4.Controls.Add(this.dtpHora_Envio);
            this.panel4.Location = new System.Drawing.Point(24, 72);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1086, 341);
            this.panel4.TabIndex = 277;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(84)))));
            this.label8.Location = new System.Drawing.Point(553, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 16);
            this.label8.TabIndex = 281;
            this.label8.Text = "Asunto Correo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(84)))));
            this.label6.Location = new System.Drawing.Point(301, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 16);
            this.label6.TabIndex = 280;
            this.label6.Text = "Nombre Archivo";
            // 
            // TxtNombre_Archivo
            // 
            this.TxtNombre_Archivo.BackColor = System.Drawing.SystemColors.Window;
            this.TxtNombre_Archivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombre_Archivo.Location = new System.Drawing.Point(303, 29);
            this.TxtNombre_Archivo.Multiline = true;
            this.TxtNombre_Archivo.Name = "TxtNombre_Archivo";
            this.TxtNombre_Archivo.Size = new System.Drawing.Size(210, 28);
            this.TxtNombre_Archivo.TabIndex = 279;
            this.TxtNombre_Archivo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnVer_pte_Correos
            // 
            this.btnVer_pte_Correos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(84)))));
            this.btnVer_pte_Correos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVer_pte_Correos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVer_pte_Correos.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnVer_pte_Correos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVer_pte_Correos.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnVer_pte_Correos.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.btnVer_pte_Correos.IconColor = System.Drawing.Color.Gainsboro;
            this.btnVer_pte_Correos.IconSize = 19;
            this.btnVer_pte_Correos.Location = new System.Drawing.Point(1255, 89);
            this.btnVer_pte_Correos.Name = "btnVer_pte_Correos";
            this.btnVer_pte_Correos.Rotation = 0D;
            this.btnVer_pte_Correos.Size = new System.Drawing.Size(70, 27);
            this.btnVer_pte_Correos.TabIndex = 278;
            this.btnVer_pte_Correos.Text = "Ver";
            this.btnVer_pte_Correos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVer_pte_Correos.UseVisualStyleBackColor = false;
            this.btnVer_pte_Correos.Click += new System.EventHandler(this.btnVer_pte_Correos_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(84)))));
            this.label7.Location = new System.Drawing.Point(1132, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 16);
            this.label7.TabIndex = 280;
            this.label7.Text = "Seleccionar Fecha";
            // 
            // dtpfecha
            // 
            this.dtpfecha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpfecha.CustomFormat = "dd/MM/yyyy";
            this.dtpfecha.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F);
            this.dtpfecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpfecha.Location = new System.Drawing.Point(1135, 89);
            this.dtpfecha.Name = "dtpfecha";
            this.dtpfecha.Size = new System.Drawing.Size(114, 27);
            this.dtpfecha.TabIndex = 279;
            // 
            // Btn_Actualizadb
            // 
            this.Btn_Actualizadb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(84)))));
            this.Btn_Actualizadb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Actualizadb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Actualizadb.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.Btn_Actualizadb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Actualizadb.ForeColor = System.Drawing.Color.Gainsboro;
            this.Btn_Actualizadb.IconChar = FontAwesome.Sharp.IconChar.MailBulk;
            this.Btn_Actualizadb.IconColor = System.Drawing.Color.Gainsboro;
            this.Btn_Actualizadb.IconSize = 25;
            this.Btn_Actualizadb.Location = new System.Drawing.Point(938, 274);
            this.Btn_Actualizadb.Name = "Btn_Actualizadb";
            this.Btn_Actualizadb.Rotation = 0D;
            this.Btn_Actualizadb.Size = new System.Drawing.Size(137, 52);
            this.Btn_Actualizadb.TabIndex = 282;
            this.Btn_Actualizadb.Text = "Actualizar Base";
            this.Btn_Actualizadb.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Actualizadb.UseVisualStyleBackColor = false;
            this.Btn_Actualizadb.Click += new System.EventHandler(this.Btn_Actualizadb_Click);
            // 
            // FormEnvio_Correos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1370, 560);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpfecha);
            this.Controls.Add(this.btnVer_pte_Correos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtCorreo_Gic);
            this.Controls.Add(this.lblfecha);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtDestinatario_Correo);
            this.Controls.Add(this.dgvCorreos_Pendientes);
            this.Controls.Add(this.label38);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.panel4);
            this.MinimizeBox = false;
            this.Name = "FormEnvio_Correos";
            this.Text = "FormEnvio_Correos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormEnvio_Correos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCorreos_Pendientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btnbuscar)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Btnbuscar;
        private System.Windows.Forms.TextBox Txtcod_convenio;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.DataGridView dgvCorreos_Pendientes;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtDestinatario_Correo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtAsunto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker dtpHora_Envio;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label lblfecha;
        private System.Windows.Forms.TextBox TxtCorreo_Gic;
        private System.Windows.Forms.Label label5;
        private FontAwesome.Sharp.IconButton btnDescargar_Excel;
        private FontAwesome.Sharp.IconButton btnEnviar_Correo;
        private System.Windows.Forms.Panel panel4;
        private FontAwesome.Sharp.IconButton btnVer_pte_Correos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtNombre_Archivo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpfecha;
        private System.Windows.Forms.Label label8;
        private FontAwesome.Sharp.IconButton Btn_Actualizadb;
    }
}