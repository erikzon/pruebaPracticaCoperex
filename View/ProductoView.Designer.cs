﻿namespace pruebaPracticaCoperex.View
{
    partial class ProductoView
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonGuardarCambios = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.lbael = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(545, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.lbael);
            this.tabPage1.Controls.Add(this.txtBusqueda);
            this.tabPage1.Controls.Add(this.buttonEliminar);
            this.tabPage1.Controls.Add(this.buttonEditar);
            this.tabPage1.Controls.Add(this.buttonAgregar);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(537, 400);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Lectura Productos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtStock);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.txtPrecio);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.txtDescripcion);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.txtNombre);
            this.tabPage2.Controls.Add(this.buttonGuardarCambios);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(537, 400);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Agregar / Editar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(537, 400);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Entradas y Salidas";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(537, 400);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Reporte - Cardex";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(525, 364);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // buttonGuardarCambios
            // 
            this.buttonGuardarCambios.Location = new System.Drawing.Point(206, 337);
            this.buttonGuardarCambios.Name = "buttonGuardarCambios";
            this.buttonGuardarCambios.Size = new System.Drawing.Size(153, 23);
            this.buttonGuardarCambios.TabIndex = 1;
            this.buttonGuardarCambios.Text = "Guardar Cambios";
            this.buttonGuardarCambios.UseVisualStyleBackColor = true;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(98, 59);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(174, 20);
            this.txtNombre.TabIndex = 3;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(98, 113);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(174, 20);
            this.txtDescripcion.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Descripcion";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(98, 173);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(174, 20);
            this.txtPrecio.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Precio";
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(98, 240);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(174, 20);
            this.txtStock.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(95, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Stock";
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.Location = new System.Drawing.Point(290, 4);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(75, 23);
            this.buttonAgregar.TabIndex = 1;
            this.buttonAgregar.Text = "Agregar";
            this.buttonAgregar.UseVisualStyleBackColor = true;
            // 
            // buttonEditar
            // 
            this.buttonEditar.Location = new System.Drawing.Point(371, 4);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(75, 23);
            this.buttonEditar.TabIndex = 2;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(452, 4);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(75, 23);
            this.buttonEliminar.TabIndex = 3;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(105, 6);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(124, 20);
            this.txtBusqueda.TabIndex = 4;
            // 
            // lbael
            // 
            this.lbael.AutoSize = true;
            this.lbael.Location = new System.Drawing.Point(6, 9);
            this.lbael.Name = "lbael";
            this.lbael.Size = new System.Drawing.Size(101, 13);
            this.lbael.TabIndex = 5;
            this.lbael.Text = "Encontrar producto:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(235, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "🔍";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ProductoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "ProductoView";
            this.Text = "Productos";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button buttonGuardarCambios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.Label lbael;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.Button button1;
    }
}