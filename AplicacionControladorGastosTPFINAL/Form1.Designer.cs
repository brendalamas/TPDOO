namespace AplicacionControladorGastosTPFINAL
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
            this.erpError = new System.Windows.Forms.ErrorProvider(this.components);
            this.tcRegistro = new System.Windows.Forms.TabControl();
            this.tpRegistro = new System.Windows.Forms.TabPage();
            this.buttonRegistrar = new System.Windows.Forms.Button();
            this.checkGasto = new System.Windows.Forms.RadioButton();
            this.checkIngreso = new System.Windows.Forms.RadioButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.erpError)).BeginInit();
            this.tcRegistro.SuspendLayout();
            this.tpRegistro.SuspendLayout();
            this.SuspendLayout();
            // 
            // erpError
            // 
            this.erpError.ContainerControl = this;
            // 
            // tcRegistro
            // 
            this.tcRegistro.Controls.Add(this.tpRegistro);
            this.tcRegistro.Controls.Add(this.tabPage2);
            this.tcRegistro.Location = new System.Drawing.Point(4, 0);
            this.tcRegistro.Name = "tcRegistro";
            this.tcRegistro.SelectedIndex = 0;
            this.tcRegistro.Size = new System.Drawing.Size(795, 452);
            this.tcRegistro.TabIndex = 18;
            // 
            // tpRegistro
            // 
            this.tpRegistro.Controls.Add(this.buttonRegistrar);
            this.tpRegistro.Controls.Add(this.checkGasto);
            this.tpRegistro.Controls.Add(this.checkIngreso);
            this.tpRegistro.Controls.Add(this.dateTimePicker1);
            this.tpRegistro.Controls.Add(this.label5);
            this.tpRegistro.Controls.Add(this.label4);
            this.tpRegistro.Controls.Add(this.cmbCategoria);
            this.tpRegistro.Controls.Add(this.label3);
            this.tpRegistro.Controls.Add(this.label2);
            this.tpRegistro.Controls.Add(this.txtMonto);
            this.tpRegistro.Controls.Add(this.label1);
            this.tpRegistro.Location = new System.Drawing.Point(4, 25);
            this.tpRegistro.Name = "tpRegistro";
            this.tpRegistro.Padding = new System.Windows.Forms.Padding(3);
            this.tpRegistro.Size = new System.Drawing.Size(787, 423);
            this.tpRegistro.TabIndex = 0;
            this.tpRegistro.Text = "Registro";
            this.tpRegistro.UseVisualStyleBackColor = true;
            // 
            // buttonRegistrar
            // 
            this.buttonRegistrar.Location = new System.Drawing.Point(629, 296);
            this.buttonRegistrar.Name = "buttonRegistrar";
            this.buttonRegistrar.Size = new System.Drawing.Size(91, 41);
            this.buttonRegistrar.TabIndex = 29;
            this.buttonRegistrar.Text = "Agregar";
            this.buttonRegistrar.UseVisualStyleBackColor = true;
            this.buttonRegistrar.Click += new System.EventHandler(this.buttonRegistrar_Click);
            // 
            // checkGasto
            // 
            this.checkGasto.AutoSize = true;
            this.checkGasto.Location = new System.Drawing.Point(464, 147);
            this.checkGasto.Name = "checkGasto";
            this.checkGasto.Size = new System.Drawing.Size(64, 20);
            this.checkGasto.TabIndex = 28;
            this.checkGasto.TabStop = true;
            this.checkGasto.Text = "Gasto";
            this.checkGasto.UseVisualStyleBackColor = true;
            this.checkGasto.CheckedChanged += new System.EventHandler(this.checkGasto_CheckedChanged);
            // 
            // checkIngreso
            // 
            this.checkIngreso.AutoSize = true;
            this.checkIngreso.Location = new System.Drawing.Point(342, 147);
            this.checkIngreso.Name = "checkIngreso";
            this.checkIngreso.Size = new System.Drawing.Size(73, 20);
            this.checkIngreso.TabIndex = 27;
            this.checkIngreso.TabStop = true;
            this.checkIngreso.Text = "Ingreso";
            this.checkIngreso.UseVisualStyleBackColor = true;
            this.checkIngreso.CheckedChanged += new System.EventHandler(this.checkIngreso_CheckedChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(342, 232);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(253, 32);
            this.dateTimePicker1.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(206, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 23);
            this.label5.TabIndex = 25;
            this.label5.Text = "Fecha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(206, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 23;
            this.label4.Text = "Categoria";
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(342, 184);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(167, 31);
            this.cmbCategoria.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(247, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 23);
            this.label3.TabIndex = 21;
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(247, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 23);
            this.label2.TabIndex = 20;
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtMonto
            // 
            this.txtMonto.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonto.Location = new System.Drawing.Point(342, 100);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(167, 32);
            this.txtMonto.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(206, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 23);
            this.label1.TabIndex = 18;
            this.label1.Text = "Monto";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(787, 423);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tcRegistro);
            this.Name = "Form1";
            this.Text = "Controlador de Gastos";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.erpError)).EndInit();
            this.tcRegistro.ResumeLayout(false);
            this.tpRegistro.ResumeLayout(false);
            this.tpRegistro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ErrorProvider erpError;
        private System.Windows.Forms.TabControl tcRegistro;
        private System.Windows.Forms.TabPage tpRegistro;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button buttonRegistrar;
        private System.Windows.Forms.RadioButton checkGasto;
        private System.Windows.Forms.RadioButton checkIngreso;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label label1;
    }
}

