namespace PAVTP04.Presentacion
{
    partial class ProductosGestion
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.Codigo = new System.Windows.Forms.TextBox();
            this.ProductoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Descripcion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PrecioSinIva = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PorcentajeIva = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Existencia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Guardar = new System.Windows.Forms.Button();
            this.Cancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ProductoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // Codigo
            // 
            this.Codigo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ProductoBindingSource, "Codigo", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "00000000"));
            this.Codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Codigo.Location = new System.Drawing.Point(131, 39);
            this.Codigo.Name = "Codigo";
            this.Codigo.Size = new System.Drawing.Size(291, 31);
            this.Codigo.TabIndex = 1;
            this.Codigo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Codigo_KeyDown);
            // 
            // ProductoBindingSource
            // 
            this.ProductoBindingSource.DataSource = typeof(PAVTP04.Dominio.Producto);
            // 
            // Descripcion
            // 
            this.Descripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Descripcion.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ProductoBindingSource, "Descripcion", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Descripcion.Location = new System.Drawing.Point(131, 91);
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Size = new System.Drawing.Size(441, 31);
            this.Descripcion.TabIndex = 3;
            this.Descripcion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Codigo_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descripción";
            // 
            // PrecioSinIva
            // 
            this.PrecioSinIva.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ProductoBindingSource, "PrecionSinIva", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "C2"));
            this.PrecioSinIva.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrecioSinIva.Location = new System.Drawing.Point(131, 146);
            this.PrecioSinIva.Name = "PrecioSinIva";
            this.PrecioSinIva.Size = new System.Drawing.Size(166, 31);
            this.PrecioSinIva.TabIndex = 5;
            this.PrecioSinIva.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.PrecioSinIva.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Codigo_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Precio S/ IVA";
            // 
            // PorcentajeIva
            // 
            this.PorcentajeIva.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ProductoBindingSource, "PorcentajeIva", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "p2"));
            this.PorcentajeIva.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PorcentajeIva.Location = new System.Drawing.Point(131, 202);
            this.PorcentajeIva.Name = "PorcentajeIva";
            this.PorcentajeIva.Size = new System.Drawing.Size(166, 31);
            this.PorcentajeIva.TabIndex = 7;
            this.PorcentajeIva.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.PorcentajeIva.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Codigo_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "IVA %";
            // 
            // Existencia
            // 
            this.Existencia.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ProductoBindingSource, "Existencia", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Existencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Existencia.Location = new System.Drawing.Point(131, 261);
            this.Existencia.Name = "Existencia";
            this.Existencia.Size = new System.Drawing.Size(166, 31);
            this.Existencia.TabIndex = 9;
            this.Existencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Existencia.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Codigo_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Existencia";
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ProductoBindingSource, "PrecionConIva", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "C2"));
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(371, 202);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(201, 31);
            this.textBox1.TabIndex = 11;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(424, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "Precio Final";
            // 
            // Guardar
            // 
            this.Guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guardar.Location = new System.Drawing.Point(50, 356);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(136, 51);
            this.Guardar.TabIndex = 12;
            this.Guardar.Text = "Guardar";
            this.Guardar.UseVisualStyleBackColor = true;
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // Cancelar
            // 
            this.Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancelar.Location = new System.Drawing.Point(436, 356);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(136, 51);
            this.Cancelar.TabIndex = 13;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = true;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // ProductosGestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.ControlBox = false;
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.Guardar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Existencia);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PorcentajeIva);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PrecioSinIva);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Descripcion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Codigo);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ProductosGestion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta";
            ((System.ComponentModel.ISupportInitialize)(this.ProductoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Codigo;
        private System.Windows.Forms.TextBox Descripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PrecioSinIva;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PorcentajeIva;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Existencia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.BindingSource ProductoBindingSource;
    }
}