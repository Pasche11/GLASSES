namespace winform1
{
    partial class nuevoCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(nuevoCliente));
            this.lbRazonSocial = new System.Windows.Forms.Label();
            this.lbCuit = new System.Windows.Forms.Label();
            this.lbLocalidad = new System.Windows.Forms.Label();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.txtCuit = new System.Windows.Forms.TextBox();
            this.lstLocalidad = new System.Windows.Forms.ComboBox();
            this.chkbResponsableInscripto = new System.Windows.Forms.CheckBox();
            this.lblAltaCliente = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lblOpcionales = new System.Windows.Forms.Label();
            this.txtPostal = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.pbLocalidad = new System.Windows.Forms.PictureBox();
            this.pbCorreo = new System.Windows.Forms.PictureBox();
            this.pbTelefono = new System.Windows.Forms.PictureBox();
            this.pbNombreApellido = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pbRazonSocial = new System.Windows.Forms.PictureBox();
            this.pbPerfilImage = new System.Windows.Forms.PictureBox();
            this.lblPostal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbLocalidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCorreo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTelefono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNombreApellido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRazonSocial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPerfilImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lbRazonSocial
            // 
            this.lbRazonSocial.AutoSize = true;
            this.lbRazonSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRazonSocial.Location = new System.Drawing.Point(12, 88);
            this.lbRazonSocial.Name = "lbRazonSocial";
            this.lbRazonSocial.Size = new System.Drawing.Size(111, 18);
            this.lbRazonSocial.TabIndex = 0;
            this.lbRazonSocial.Text = "*Razon Social: ";
            // 
            // lbCuit
            // 
            this.lbCuit.AutoSize = true;
            this.lbCuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCuit.Location = new System.Drawing.Point(67, 197);
            this.lbCuit.Name = "lbCuit";
            this.lbCuit.Size = new System.Drawing.Size(56, 18);
            this.lbCuit.TabIndex = 1;
            this.lbCuit.Text = "*CUIT: ";
            // 
            // lbLocalidad
            // 
            this.lbLocalidad.AutoSize = true;
            this.lbLocalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLocalidad.Location = new System.Drawing.Point(38, 118);
            this.lbLocalidad.Name = "lbLocalidad";
            this.lbLocalidad.Size = new System.Drawing.Size(85, 18);
            this.lbLocalidad.TabIndex = 2;
            this.lbLocalidad.Text = "*Localidad: ";
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.AcceptsTab = true;
            this.txtRazonSocial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRazonSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRazonSocial.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtRazonSocial.Location = new System.Drawing.Point(123, 85);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(306, 24);
            this.txtRazonSocial.TabIndex = 1;
            // 
            // txtCuit
            // 
            this.txtCuit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCuit.Enabled = false;
            this.txtCuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCuit.Location = new System.Drawing.Point(123, 194);
            this.txtCuit.Name = "txtCuit";
            this.txtCuit.Size = new System.Drawing.Size(152, 24);
            this.txtCuit.TabIndex = 5;
            // 
            // lstLocalidad
            // 
            this.lstLocalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstLocalidad.FormattingEnabled = true;
            this.lstLocalidad.Items.AddRange(new object[] {
            "Villa María, Córdoba.",
            "Córdoba capital.",
            "CABA, Buenos Aires.",
            "Villa Allende, Córdoba.",
            "La Matanza, Buenos Aires."});
            this.lstLocalidad.Location = new System.Drawing.Point(123, 115);
            this.lstLocalidad.Name = "lstLocalidad";
            this.lstLocalidad.Size = new System.Drawing.Size(306, 26);
            this.lstLocalidad.TabIndex = 2;
            // 
            // chkbResponsableInscripto
            // 
            this.chkbResponsableInscripto.AutoSize = true;
            this.chkbResponsableInscripto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbResponsableInscripto.Location = new System.Drawing.Point(293, 196);
            this.chkbResponsableInscripto.Name = "chkbResponsableInscripto";
            this.chkbResponsableInscripto.Size = new System.Drawing.Size(174, 22);
            this.chkbResponsableInscripto.TabIndex = 4;
            this.chkbResponsableInscripto.Text = "Responsable Inscripto";
            this.chkbResponsableInscripto.UseVisualStyleBackColor = true;
            this.chkbResponsableInscripto.CheckedChanged += new System.EventHandler(this.chkbResponsableInscripto_CheckedChanged);
            // 
            // lblAltaCliente
            // 
            this.lblAltaCliente.AutoSize = true;
            this.lblAltaCliente.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltaCliente.Location = new System.Drawing.Point(153, 38);
            this.lblAltaCliente.Name = "lblAltaCliente";
            this.lblAltaCliente.Size = new System.Drawing.Size(210, 32);
            this.lblAltaCliente.TabIndex = 8;
            this.lblAltaCliente.Text = "ALTA CLIENTE";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCancelar.Image = global::winform1.Properties.Resources.aceptar_block;
            this.btnCancelar.Location = new System.Drawing.Point(413, 393);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(74, 37);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAceptar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAceptar.BackgroundImage")));
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAceptar.Image = global::winform1.Properties.Resources.aceptar_block;
            this.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnAceptar.Location = new System.Drawing.Point(335, 393);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(72, 37);
            this.btnAceptar.TabIndex = 11;
            this.btnAceptar.Text = "ACEPTAR";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblOpcionales
            // 
            this.lblOpcionales.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblOpcionales.AutoSize = true;
            this.lblOpcionales.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblOpcionales.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpcionales.Location = new System.Drawing.Point(140, 268);
            this.lblOpcionales.Name = "lblOpcionales";
            this.lblOpcionales.Size = new System.Drawing.Size(135, 20);
            this.lblOpcionales.TabIndex = 6;
            this.lblOpcionales.Text = "Datos Opcionales";
            this.toolTip1.SetToolTip(this.lblOpcionales, "Datos opcionales de contacto\r\n");
            // 
            // txtPostal
            // 
            this.txtPostal.AcceptsTab = true;
            this.txtPostal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPostal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPostal.Location = new System.Drawing.Point(123, 147);
            this.txtPostal.Name = "txtPostal";
            this.txtPostal.Size = new System.Drawing.Size(78, 24);
            this.txtPostal.TabIndex = 3;
            this.txtPostal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.txtPostal, "Codigo Postal de la localidad del Cliente");
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(58, 302);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(70, 18);
            this.lblNombre.TabIndex = 17;
            this.lblNombre.Text = "Nombre: ";
            // 
            // lblApellido
            // 
            this.lblApellido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(61, 331);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(67, 18);
            this.lblApellido.TabIndex = 18;
            this.lblApellido.Text = "Apellido: ";
            // 
            // txtNombre
            // 
            this.txtNombre.AcceptsTab = true;
            this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtNombre.Location = new System.Drawing.Point(123, 302);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(174, 21);
            this.txtNombre.TabIndex = 7;
            // 
            // txtApellido
            // 
            this.txtApellido.AcceptsTab = true;
            this.txtApellido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtApellido.Location = new System.Drawing.Point(123, 331);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(174, 21);
            this.txtApellido.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 379);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 18);
            this.label1.TabIndex = 24;
            this.label1.Text = "Telefono:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.AcceptsTab = true;
            this.txtTelefono.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtTelefono.Location = new System.Drawing.Point(123, 379);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(174, 21);
            this.txtTelefono.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 406);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 18);
            this.label2.TabIndex = 27;
            this.label2.Text = "Correo:";
            // 
            // txtCorreo
            // 
            this.txtCorreo.AcceptsTab = true;
            this.txtCorreo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtCorreo.Location = new System.Drawing.Point(123, 406);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(174, 21);
            this.txtCorreo.TabIndex = 10;
            // 
            // pbLocalidad
            // 
            this.pbLocalidad.BackgroundImage = global::winform1.Properties.Resources.ubiroja;
            this.pbLocalidad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbLocalidad.Location = new System.Drawing.Point(435, 114);
            this.pbLocalidad.Name = "pbLocalidad";
            this.pbLocalidad.Size = new System.Drawing.Size(26, 27);
            this.pbLocalidad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLocalidad.TabIndex = 31;
            this.pbLocalidad.TabStop = false;
            // 
            // pbCorreo
            // 
            this.pbCorreo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pbCorreo.BackgroundImage = global::winform1.Properties.Resources.correo;
            this.pbCorreo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbCorreo.Location = new System.Drawing.Point(303, 403);
            this.pbCorreo.Name = "pbCorreo";
            this.pbCorreo.Size = new System.Drawing.Size(26, 27);
            this.pbCorreo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCorreo.TabIndex = 29;
            this.pbCorreo.TabStop = false;
            // 
            // pbTelefono
            // 
            this.pbTelefono.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pbTelefono.BackgroundImage = global::winform1.Properties.Resources.telefono;
            this.pbTelefono.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbTelefono.Location = new System.Drawing.Point(303, 375);
            this.pbTelefono.Name = "pbTelefono";
            this.pbTelefono.Size = new System.Drawing.Size(26, 27);
            this.pbTelefono.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTelefono.TabIndex = 26;
            this.pbTelefono.TabStop = false;
            // 
            // pbNombreApellido
            // 
            this.pbNombreApellido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pbNombreApellido.BackgroundImage = global::winform1.Properties.Resources.usuario;
            this.pbNombreApellido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbNombreApellido.Location = new System.Drawing.Point(303, 316);
            this.pbNombreApellido.Name = "pbNombreApellido";
            this.pbNombreApellido.Size = new System.Drawing.Size(26, 27);
            this.pbNombreApellido.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNombreApellido.TabIndex = 22;
            this.pbNombreApellido.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::winform1.Properties.Resources.mano;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox3.Location = new System.Drawing.Point(461, 191);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(26, 27);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            // 
            // pbRazonSocial
            // 
            this.pbRazonSocial.BackgroundImage = global::winform1.Properties.Resources.global;
            this.pbRazonSocial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbRazonSocial.Location = new System.Drawing.Point(435, 85);
            this.pbRazonSocial.Name = "pbRazonSocial";
            this.pbRazonSocial.Size = new System.Drawing.Size(26, 27);
            this.pbRazonSocial.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRazonSocial.TabIndex = 14;
            this.pbRazonSocial.TabStop = false;
            // 
            // pbPerfilImage
            // 
            this.pbPerfilImage.BackgroundImage = global::winform1.Properties.Resources.grupo;
            this.pbPerfilImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbPerfilImage.ImageLocation = "";
            this.pbPerfilImage.Location = new System.Drawing.Point(129, 44);
            this.pbPerfilImage.Name = "pbPerfilImage";
            this.pbPerfilImage.Size = new System.Drawing.Size(22, 22);
            this.pbPerfilImage.TabIndex = 9;
            this.pbPerfilImage.TabStop = false;
            // 
            // lblPostal
            // 
            this.lblPostal.AutoSize = true;
            this.lblPostal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPostal.Location = new System.Drawing.Point(11, 149);
            this.lblPostal.Name = "lblPostal";
            this.lblPostal.Size = new System.Drawing.Size(112, 18);
            this.lblPostal.TabIndex = 32;
            this.lblPostal.Text = "*Código Postal:";
            // 
            // nuevoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(493, 443);
            this.Controls.Add(this.lblPostal);
            this.Controls.Add(this.pbLocalidad);
            this.Controls.Add(this.txtPostal);
            this.Controls.Add(this.pbCorreo);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbTelefono);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.pbNombreApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblOpcionales);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pbRazonSocial);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.pbPerfilImage);
            this.Controls.Add(this.lblAltaCliente);
            this.Controls.Add(this.chkbResponsableInscripto);
            this.Controls.Add(this.lstLocalidad);
            this.Controls.Add(this.txtCuit);
            this.Controls.Add(this.txtRazonSocial);
            this.Controls.Add(this.lbLocalidad);
            this.Controls.Add(this.lbCuit);
            this.Controls.Add(this.lbRazonSocial);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(587, 482);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(509, 482);
            this.Name = "nuevoCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Cliente";
            this.Load += new System.EventHandler(this.nuevoCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLocalidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCorreo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTelefono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNombreApellido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRazonSocial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPerfilImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbRazonSocial;
        private System.Windows.Forms.Label lbCuit;
        private System.Windows.Forms.Label lbLocalidad;
        private System.Windows.Forms.TextBox txtRazonSocial;
        private System.Windows.Forms.TextBox txtCuit;
        private System.Windows.Forms.ComboBox lstLocalidad;
        private System.Windows.Forms.CheckBox chkbResponsableInscripto;
        private System.Windows.Forms.Label lblAltaCliente;
        private System.Windows.Forms.PictureBox pbPerfilImage;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.PictureBox pbRazonSocial;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblOpcionales;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.PictureBox pbNombreApellido;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.PictureBox pbTelefono;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.PictureBox pbCorreo;
        private System.Windows.Forms.TextBox txtPostal;
        private System.Windows.Forms.PictureBox pbLocalidad;
        private System.Windows.Forms.Label lblPostal;
    }
}

