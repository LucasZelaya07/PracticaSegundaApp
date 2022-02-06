namespace SegundaApp
{
    partial class FrmSegundaApp
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
            this.TxtBxApellido = new System.Windows.Forms.TextBox();
            this.TxtBxNombre = new System.Windows.Forms.TextBox();
            this.TxtBxEdad = new System.Windows.Forms.TextBox();
            this.TxtBxDireccion = new System.Windows.Forms.TextBox();
            this.LblApellido = new System.Windows.Forms.Label();
            this.LblNombre = new System.Windows.Forms.Label();
            this.LblEdad = new System.Windows.Forms.Label();
            this.LblDireccion = new System.Windows.Forms.Label();
            this.RTxtBxResultado = new System.Windows.Forms.RichTextBox();
            this.LblResultado = new System.Windows.Forms.Label();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtBxApellido
            // 
            this.TxtBxApellido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtBxApellido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtBxApellido.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxApellido.Location = new System.Drawing.Point(256, 12);
            this.TxtBxApellido.MaxLength = 20;
            this.TxtBxApellido.Name = "TxtBxApellido";
            this.TxtBxApellido.Size = new System.Drawing.Size(195, 25);
            this.TxtBxApellido.TabIndex = 0;
            // 
            // TxtBxNombre
            // 
            this.TxtBxNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtBxNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtBxNombre.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxNombre.Location = new System.Drawing.Point(256, 48);
            this.TxtBxNombre.MaxLength = 20;
            this.TxtBxNombre.Name = "TxtBxNombre";
            this.TxtBxNombre.Size = new System.Drawing.Size(195, 25);
            this.TxtBxNombre.TabIndex = 1;
            // 
            // TxtBxEdad
            // 
            this.TxtBxEdad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtBxEdad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtBxEdad.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxEdad.Location = new System.Drawing.Point(256, 88);
            this.TxtBxEdad.MaxLength = 3;
            this.TxtBxEdad.Name = "TxtBxEdad";
            this.TxtBxEdad.Size = new System.Drawing.Size(86, 25);
            this.TxtBxEdad.TabIndex = 2;
            this.TxtBxEdad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBxEdad_KeyPress);
            // 
            // TxtBxDireccion
            // 
            this.TxtBxDireccion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtBxDireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtBxDireccion.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxDireccion.Location = new System.Drawing.Point(256, 124);
            this.TxtBxDireccion.MaxLength = 20;
            this.TxtBxDireccion.Name = "TxtBxDireccion";
            this.TxtBxDireccion.Size = new System.Drawing.Size(195, 25);
            this.TxtBxDireccion.TabIndex = 3;
            // 
            // LblApellido
            // 
            this.LblApellido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblApellido.AutoSize = true;
            this.LblApellido.Enabled = false;
            this.LblApellido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblApellido.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblApellido.Location = new System.Drawing.Point(147, 17);
            this.LblApellido.Name = "LblApellido";
            this.LblApellido.Size = new System.Drawing.Size(72, 20);
            this.LblApellido.TabIndex = 4;
            this.LblApellido.Text = "APELLIDO";
            // 
            // LblNombre
            // 
            this.LblNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblNombre.AutoSize = true;
            this.LblNombre.Enabled = false;
            this.LblNombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblNombre.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombre.Location = new System.Drawing.Point(147, 53);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(64, 20);
            this.LblNombre.TabIndex = 5;
            this.LblNombre.Text = "NOMBRE";
            // 
            // LblEdad
            // 
            this.LblEdad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblEdad.AutoSize = true;
            this.LblEdad.Enabled = false;
            this.LblEdad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblEdad.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEdad.Location = new System.Drawing.Point(147, 93);
            this.LblEdad.Name = "LblEdad";
            this.LblEdad.Size = new System.Drawing.Size(45, 20);
            this.LblEdad.TabIndex = 6;
            this.LblEdad.Text = "EDAD";
            // 
            // LblDireccion
            // 
            this.LblDireccion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblDireccion.AutoSize = true;
            this.LblDireccion.Enabled = false;
            this.LblDireccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblDireccion.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDireccion.Location = new System.Drawing.Point(147, 129);
            this.LblDireccion.Name = "LblDireccion";
            this.LblDireccion.Size = new System.Drawing.Size(78, 20);
            this.LblDireccion.TabIndex = 7;
            this.LblDireccion.Text = "DIRECCION";
            // 
            // RTxtBxResultado
            // 
            this.RTxtBxResultado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RTxtBxResultado.Enabled = false;
            this.RTxtBxResultado.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RTxtBxResultado.Location = new System.Drawing.Point(151, 178);
            this.RTxtBxResultado.Name = "RTxtBxResultado";
            this.RTxtBxResultado.Size = new System.Drawing.Size(300, 151);
            this.RTxtBxResultado.TabIndex = 8;
            this.RTxtBxResultado.Text = "";
            // 
            // LblResultado
            // 
            this.LblResultado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblResultado.AutoSize = true;
            this.LblResultado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblResultado.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblResultado.Location = new System.Drawing.Point(147, 155);
            this.LblResultado.Name = "LblResultado";
            this.LblResultado.Size = new System.Drawing.Size(87, 20);
            this.LblResultado.TabIndex = 9;
            this.LblResultado.Text = "RESULTADO";
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnAceptar.Location = new System.Drawing.Point(151, 336);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(75, 23);
            this.BtnAceptar.TabIndex = 10;
            this.BtnAceptar.Text = "Aceptar";
            this.BtnAceptar.UseVisualStyleBackColor = true;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnCancelar.Location = new System.Drawing.Point(376, 335);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(75, 23);
            this.BtnCancelar.TabIndex = 11;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // FrmSegundaApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(this.LblResultado);
            this.Controls.Add(this.RTxtBxResultado);
            this.Controls.Add(this.LblDireccion);
            this.Controls.Add(this.LblEdad);
            this.Controls.Add(this.LblNombre);
            this.Controls.Add(this.LblApellido);
            this.Controls.Add(this.TxtBxDireccion);
            this.Controls.Add(this.TxtBxEdad);
            this.Controls.Add(this.TxtBxNombre);
            this.Controls.Add(this.TxtBxApellido);
            this.Name = "FrmSegundaApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datos personales";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmSegundaApp_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtBxApellido;
        private System.Windows.Forms.TextBox TxtBxNombre;
        private System.Windows.Forms.TextBox TxtBxEdad;
        private System.Windows.Forms.TextBox TxtBxDireccion;
        private System.Windows.Forms.Label LblApellido;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Label LblEdad;
        private System.Windows.Forms.Label LblDireccion;
        private System.Windows.Forms.RichTextBox RTxtBxResultado;
        private System.Windows.Forms.Label LblResultado;
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.Button BtnCancelar;
    }
}

