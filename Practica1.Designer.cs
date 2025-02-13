namespace appPractica1
{
    partial class frmPedido
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbProducto = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textDocena = new System.Windows.Forms.TextBox();
            this.textIVA = new System.Windows.Forms.TextBox();
            this.textCant = new System.Windows.Forms.TextBox();
            this.btnFacturar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.grbApagar = new System.Windows.Forms.GroupBox();
            this.lblVrIVA = new System.Windows.Forms.Label();
            this.lblVrDscto = new System.Windows.Forms.Label();
            this.lbtPorcDsto = new System.Windows.Forms.Label();
            this.lbtSubTott = new System.Windows.Forms.Label();
            this.lblTotAPagar = new System.Windows.Forms.Label();
            this.BtnTerminar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.grbApagar.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Baskerville Old Face", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(172, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(425, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "Piñata las Orquídeas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Baskerville Old Face", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(233, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "Producto:";
            // 
            // cmbProducto
            // 
            this.cmbProducto.Font = new System.Drawing.Font("Baskerville Old Face", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProducto.FormattingEnabled = true;
            this.cmbProducto.Items.AddRange(new object[] {
            "Producto 1",
            "Producto 2",
            "Producto 3",
            "Producto 4",
            "Producto 4",
            "Producto 5",
            "Producto 6"});
            this.cmbProducto.Location = new System.Drawing.Point(371, 101);
            this.cmbProducto.Name = "cmbProducto";
            this.cmbProducto.Size = new System.Drawing.Size(171, 29);
            this.cmbProducto.TabIndex = 2;
            this.cmbProducto.SelectedIndexChanged += new System.EventHandler(this.cmbProducto_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Baskerville Old Face", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(261, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 34);
            this.label3.TabIndex = 3;
            this.label3.Text = "% IVA:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Baskerville Old Face", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(117, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(248, 34);
            this.label4.TabIndex = 4;
            this.label4.Text = "Cantidad (Unidad):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Baskerville Old Face", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(212, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 34);
            this.label5.TabIndex = 5;
            this.label5.Text = "Vr.Docena:";
            // 
            // textDocena
            // 
            this.textDocena.Location = new System.Drawing.Point(371, 154);
            this.textDocena.Name = "textDocena";
            this.textDocena.Size = new System.Drawing.Size(100, 22);
            this.textDocena.TabIndex = 6;
            // 
            // textIVA
            // 
            this.textIVA.Location = new System.Drawing.Point(371, 243);
            this.textIVA.Name = "textIVA";
            this.textIVA.Size = new System.Drawing.Size(100, 22);
            this.textIVA.TabIndex = 7;
            // 
            // textCant
            // 
            this.textCant.Location = new System.Drawing.Point(371, 200);
            this.textCant.Name = "textCant";
            this.textCant.Size = new System.Drawing.Size(100, 22);
            this.textCant.TabIndex = 8;
            // 
            // btnFacturar
            // 
            this.btnFacturar.Font = new System.Drawing.Font("Baskerville Old Face", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacturar.Location = new System.Drawing.Point(384, 310);
            this.btnFacturar.Name = "btnFacturar";
            this.btnFacturar.Size = new System.Drawing.Size(228, 50);
            this.btnFacturar.TabIndex = 9;
            this.btnFacturar.Text = "FACTURAR";
            this.btnFacturar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFacturar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Baskerville Old Face", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(93, 310);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(233, 50);
            this.btnLimpiar.TabIndex = 10;
            this.btnLimpiar.Text = "LIMPIAR";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // grbApagar
            // 
            this.grbApagar.BackColor = System.Drawing.Color.White;
            this.grbApagar.Controls.Add(this.textBox5);
            this.grbApagar.Controls.Add(this.textBox4);
            this.grbApagar.Controls.Add(this.textBox3);
            this.grbApagar.Controls.Add(this.textBox2);
            this.grbApagar.Controls.Add(this.textBox1);
            this.grbApagar.Controls.Add(this.lblVrIVA);
            this.grbApagar.Controls.Add(this.lblVrDscto);
            this.grbApagar.Controls.Add(this.lbtPorcDsto);
            this.grbApagar.Controls.Add(this.lbtSubTott);
            this.grbApagar.Controls.Add(this.lblTotAPagar);
            this.grbApagar.Font = new System.Drawing.Font("Kristen ITC", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbApagar.Location = new System.Drawing.Point(43, 395);
            this.grbApagar.Name = "grbApagar";
            this.grbApagar.Size = new System.Drawing.Size(669, 272);
            this.grbApagar.TabIndex = 11;
            this.grbApagar.TabStop = false;
            this.grbApagar.Text = "A Pagar";
            this.grbApagar.Visible = false;
            // 
            // lblVrIVA
            // 
            this.lblVrIVA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblVrIVA.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblVrIVA.Font = new System.Drawing.Font("Baskerville Old Face", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVrIVA.Location = new System.Drawing.Point(26, 170);
            this.lblVrIVA.Name = "lblVrIVA";
            this.lblVrIVA.Size = new System.Drawing.Size(120, 26);
            this.lblVrIVA.TabIndex = 21;
            this.lblVrIVA.Text = "Vr.IVA:";
            // 
            // lblVrDscto
            // 
            this.lblVrDscto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblVrDscto.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblVrDscto.Font = new System.Drawing.Font("Baskerville Old Face", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVrDscto.Location = new System.Drawing.Point(26, 124);
            this.lblVrDscto.Name = "lblVrDscto";
            this.lblVrDscto.Size = new System.Drawing.Size(140, 26);
            this.lblVrDscto.TabIndex = 20;
            this.lblVrDscto.Text = "Valor.Dscto:";
            // 
            // lbtPorcDsto
            // 
            this.lbtPorcDsto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbtPorcDsto.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lbtPorcDsto.Font = new System.Drawing.Font("Baskerville Old Face", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtPorcDsto.Location = new System.Drawing.Point(26, 76);
            this.lbtPorcDsto.Name = "lbtPorcDsto";
            this.lbtPorcDsto.Size = new System.Drawing.Size(140, 26);
            this.lbtPorcDsto.TabIndex = 19;
            this.lbtPorcDsto.Text = "Porc.Dscto:";
            // 
            // lbtSubTott
            // 
            this.lbtSubTott.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbtSubTott.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lbtSubTott.Font = new System.Drawing.Font("Baskerville Old Face", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtSubTott.Location = new System.Drawing.Point(26, 32);
            this.lbtSubTott.Name = "lbtSubTott";
            this.lbtSubTott.Size = new System.Drawing.Size(120, 26);
            this.lbtSubTott.TabIndex = 18;
            this.lbtSubTott.Text = "Sub Total:";
            // 
            // lblTotAPagar
            // 
            this.lblTotAPagar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotAPagar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblTotAPagar.Font = new System.Drawing.Font("Baskerville Old Face", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotAPagar.Location = new System.Drawing.Point(26, 221);
            this.lblTotAPagar.Name = "lblTotAPagar";
            this.lblTotAPagar.Size = new System.Drawing.Size(149, 33);
            this.lblTotAPagar.TabIndex = 17;
            this.lblTotAPagar.Text = "Total a pagar:";
            // 
            // BtnTerminar
            // 
            this.BtnTerminar.Font = new System.Drawing.Font("Baskerville Old Face", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTerminar.Location = new System.Drawing.Point(505, 706);
            this.BtnTerminar.Name = "BtnTerminar";
            this.BtnTerminar.Size = new System.Drawing.Size(233, 50);
            this.BtnTerminar.TabIndex = 12;
            this.BtnTerminar.Text = "TERMINAR";
            this.BtnTerminar.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.RosyBrown;
            this.textBox1.Location = new System.Drawing.Point(186, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(190, 31);
            this.textBox1.TabIndex = 22;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.RosyBrown;
            this.textBox2.Location = new System.Drawing.Point(238, 221);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(190, 31);
            this.textBox2.TabIndex = 23;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.RosyBrown;
            this.textBox3.Location = new System.Drawing.Point(238, 165);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(190, 31);
            this.textBox3.TabIndex = 24;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.RosyBrown;
            this.textBox4.Location = new System.Drawing.Point(224, 119);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(190, 31);
            this.textBox4.TabIndex = 25;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.RosyBrown;
            this.textBox5.Location = new System.Drawing.Point(196, 71);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(190, 31);
            this.textBox5.TabIndex = 26;
            // 
            // frmPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(800, 768);
            this.Controls.Add(this.BtnTerminar);
            this.Controls.Add(this.grbApagar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnFacturar);
            this.Controls.Add(this.textCant);
            this.Controls.Add(this.textIVA);
            this.Controls.Add(this.textDocena);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbProducto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmPedido";
            this.Text = "Practica #1";
            this.grbApagar.ResumeLayout(false);
            this.grbApagar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbProducto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textDocena;
        private System.Windows.Forms.TextBox textIVA;
        private System.Windows.Forms.TextBox textCant;
        private System.Windows.Forms.Button btnFacturar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.GroupBox grbApagar;
        private System.Windows.Forms.Label lblVrIVA;
        private System.Windows.Forms.Label lblVrDscto;
        private System.Windows.Forms.Label lbtPorcDsto;
        private System.Windows.Forms.Label lbtSubTott;
        private System.Windows.Forms.Label lblTotAPagar;
        private System.Windows.Forms.Button BtnTerminar;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
    }
}

