﻿namespace UI
{
    partial class FrmPrincipal
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
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtNombreP = new MaterialSkin.Controls.MaterialTextBox();
            this.txtCaracteristicaP = new MaterialSkin.Controls.MaterialTextBox();
            this.txtCantidad = new MaterialSkin.Controls.MaterialTextBox();
            this.txtNombreI = new MaterialSkin.Controls.MaterialTextBox();
            this.txtPrecio = new MaterialSkin.Controls.MaterialTextBox();
            this.btnEnviarI = new MaterialSkin.Controls.MaterialButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnCalcular = new MaterialSkin.Controls.MaterialButton();
            this.BtnEliminar = new MaterialSkin.Controls.MaterialButton();
            this.materialTabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.Location = new System.Drawing.Point(3, 64);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(663, 536);
            this.materialTabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnEnviarI);
            this.tabPage2.Controls.Add(this.txtPrecio);
            this.tabPage2.Controls.Add(this.txtCantidad);
            this.tabPage2.Controls.Add(this.txtNombreI);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(655, 508);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ingredientes";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.BtnEliminar);
            this.tabPage1.Controls.Add(this.BtnCalcular);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.txtCaracteristicaP);
            this.tabPage1.Controls.Add(this.txtNombreP);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(655, 508);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Producto";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtNombreP
            // 
            this.txtNombreP.AnimateReadOnly = true;
            this.txtNombreP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombreP.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtNombreP.Depth = 0;
            this.txtNombreP.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNombreP.Hint = "Nombre del producto";
            this.txtNombreP.LeadingIcon = null;
            this.txtNombreP.Location = new System.Drawing.Point(217, 42);
            this.txtNombreP.MaxLength = 50;
            this.txtNombreP.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNombreP.Name = "txtNombreP";
            this.txtNombreP.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.txtNombreP.Size = new System.Drawing.Size(227, 50);
            this.txtNombreP.TabIndex = 0;
            this.txtNombreP.Text = "";
            this.txtNombreP.TrailingIcon = null;
            // 
            // txtCaracteristicaP
            // 
            this.txtCaracteristicaP.AnimateReadOnly = true;
            this.txtCaracteristicaP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCaracteristicaP.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtCaracteristicaP.Depth = 0;
            this.txtCaracteristicaP.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCaracteristicaP.Hint = "Caracteristica";
            this.txtCaracteristicaP.LeadingIcon = null;
            this.txtCaracteristicaP.Location = new System.Drawing.Point(217, 116);
            this.txtCaracteristicaP.MaxLength = 50;
            this.txtCaracteristicaP.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCaracteristicaP.Name = "txtCaracteristicaP";
            this.txtCaracteristicaP.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.txtCaracteristicaP.Size = new System.Drawing.Size(227, 50);
            this.txtCaracteristicaP.TabIndex = 1;
            this.txtCaracteristicaP.Text = "";
            this.txtCaracteristicaP.TrailingIcon = null;
            // 
            // txtCantidad
            // 
            this.txtCantidad.AnimateReadOnly = true;
            this.txtCantidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCantidad.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtCantidad.Depth = 0;
            this.txtCantidad.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCantidad.Hint = "Cantidad";
            this.txtCantidad.LeadingIcon = null;
            this.txtCantidad.Location = new System.Drawing.Point(222, 141);
            this.txtCantidad.MaxLength = 50;
            this.txtCantidad.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.txtCantidad.Size = new System.Drawing.Size(227, 50);
            this.txtCantidad.TabIndex = 3;
            this.txtCantidad.Text = "";
            this.txtCantidad.TrailingIcon = null;
            // 
            // txtNombreI
            // 
            this.txtNombreI.AnimateReadOnly = true;
            this.txtNombreI.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombreI.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtNombreI.Depth = 0;
            this.txtNombreI.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNombreI.Hint = "Nombre del ingrediente";
            this.txtNombreI.LeadingIcon = null;
            this.txtNombreI.Location = new System.Drawing.Point(222, 74);
            this.txtNombreI.MaxLength = 50;
            this.txtNombreI.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNombreI.Name = "txtNombreI";
            this.txtNombreI.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.txtNombreI.Size = new System.Drawing.Size(227, 50);
            this.txtNombreI.TabIndex = 2;
            this.txtNombreI.Text = "";
            this.txtNombreI.TrailingIcon = null;
            // 
            // txtPrecio
            // 
            this.txtPrecio.AnimateReadOnly = true;
            this.txtPrecio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrecio.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtPrecio.Depth = 0;
            this.txtPrecio.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPrecio.Hint = "Precio";
            this.txtPrecio.LeadingIcon = null;
            this.txtPrecio.Location = new System.Drawing.Point(222, 209);
            this.txtPrecio.MaxLength = 50;
            this.txtPrecio.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.txtPrecio.Size = new System.Drawing.Size(227, 50);
            this.txtPrecio.TabIndex = 4;
            this.txtPrecio.Text = "";
            this.txtPrecio.TrailingIcon = null;
            // 
            // btnEnviarI
            // 
            this.btnEnviarI.AutoSize = false;
            this.btnEnviarI.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEnviarI.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Dense;
            this.btnEnviarI.Depth = 0;
            this.btnEnviarI.DrawShadows = false;
            this.btnEnviarI.HighEmphasis = true;
            this.btnEnviarI.Icon = null;
            this.btnEnviarI.Location = new System.Drawing.Point(341, 278);
            this.btnEnviarI.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEnviarI.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEnviarI.Name = "btnEnviarI";
            this.btnEnviarI.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnEnviarI.Size = new System.Drawing.Size(108, 37);
            this.btnEnviarI.TabIndex = 5;
            this.btnEnviarI.Text = "Enviar";
            this.btnEnviarI.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEnviarI.UseAccentColor = true;
            this.btnEnviarI.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(64, 192);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(532, 241);
            this.dataGridView1.TabIndex = 2;
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.AutoSize = false;
            this.BtnCalcular.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnCalcular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCalcular.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Dense;
            this.BtnCalcular.Depth = 0;
            this.BtnCalcular.DrawShadows = false;
            this.BtnCalcular.HighEmphasis = true;
            this.BtnCalcular.Icon = null;
            this.BtnCalcular.Location = new System.Drawing.Point(464, 450);
            this.BtnCalcular.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnCalcular.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BtnCalcular.Size = new System.Drawing.Size(132, 40);
            this.BtnCalcular.TabIndex = 3;
            this.BtnCalcular.Text = "Calcular";
            this.BtnCalcular.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.BtnCalcular.UseAccentColor = true;
            this.BtnCalcular.UseVisualStyleBackColor = true;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.AutoSize = false;
            this.BtnEliminar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEliminar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Dense;
            this.BtnEliminar.Depth = 0;
            this.BtnEliminar.DrawShadows = false;
            this.BtnEliminar.HighEmphasis = true;
            this.BtnEliminar.Icon = null;
            this.BtnEliminar.Location = new System.Drawing.Point(324, 450);
            this.BtnEliminar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnEliminar.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BtnEliminar.Size = new System.Drawing.Size(132, 40);
            this.BtnEliminar.TabIndex = 4;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.BtnEliminar.UseAccentColor = true;
            this.BtnEliminar.UseVisualStyleBackColor = true;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 602);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerTabControl = this.materialTabControl1;
            this.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.Padding = new System.Windows.Forms.Padding(3, 64, 2, 2);
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proyecto";
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private MaterialSkin.Controls.MaterialTextBox txtNombreP;
        private MaterialSkin.Controls.MaterialTextBox txtCaracteristicaP;
        private MaterialSkin.Controls.MaterialTextBox txtPrecio;
        private MaterialSkin.Controls.MaterialTextBox txtCantidad;
        private MaterialSkin.Controls.MaterialTextBox txtNombreI;
        private MaterialSkin.Controls.MaterialButton btnEnviarI;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialButton BtnCalcular;
        private MaterialSkin.Controls.MaterialButton BtnEliminar;
    }
}

