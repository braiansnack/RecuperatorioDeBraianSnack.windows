
using System;

namespace ParcialDeBraianSnack
{
    partial class frmCubo
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
            this.RellenoComboBox = new System.Windows.Forms.ComboBox();
            this.AristaTextBox = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PuntoTrazoButton = new System.Windows.Forms.RadioButton();
            this.RayasTrazoButton = new System.Windows.Forms.RadioButton();
            this.ContinuoTrazoButton = new System.Windows.Forms.RadioButton();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // RellenoComboBox
            // 
            this.RellenoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RellenoComboBox.FormattingEnabled = true;
            this.RellenoComboBox.Location = new System.Drawing.Point(113, 50);
            this.RellenoComboBox.Name = "RellenoComboBox";
            this.RellenoComboBox.Size = new System.Drawing.Size(279, 21);
            this.RellenoComboBox.TabIndex = 58;
            // 
            // AristaTextBox
            // 
            this.AristaTextBox.Location = new System.Drawing.Point(113, 21);
            this.AristaTextBox.MaxLength = 50;
            this.AristaTextBox.Name = "AristaTextBox";
            this.AristaTextBox.Size = new System.Drawing.Size(279, 20);
            this.AristaTextBox.TabIndex = 53;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(31, 164);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(84, 61);
            this.btnOK.TabIndex = 54;
            this.btnOK.Text = "OK";
            this.btnOK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 57;
            this.label4.Text = "Relleno:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 56;
            this.label5.Text = "Ingresar Árista:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PuntoTrazoButton);
            this.groupBox1.Controls.Add(this.RayasTrazoButton);
            this.groupBox1.Controls.Add(this.ContinuoTrazoButton);
            this.groupBox1.Location = new System.Drawing.Point(113, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 65);
            this.groupBox1.TabIndex = 60;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Trazo ";
            // 
            // PuntoTrazoButton
            // 
            this.PuntoTrazoButton.AutoSize = true;
            this.PuntoTrazoButton.Location = new System.Drawing.Point(140, 19);
            this.PuntoTrazoButton.Name = "PuntoTrazoButton";
            this.PuntoTrazoButton.Size = new System.Drawing.Size(58, 17);
            this.PuntoTrazoButton.TabIndex = 1;
            this.PuntoTrazoButton.Text = "Puntos";
            this.PuntoTrazoButton.UseVisualStyleBackColor = true;
            // 
            // RayasTrazoButton
            // 
            this.RayasTrazoButton.AutoSize = true;
            this.RayasTrazoButton.Location = new System.Drawing.Point(79, 19);
            this.RayasTrazoButton.Name = "RayasTrazoButton";
            this.RayasTrazoButton.Size = new System.Drawing.Size(55, 17);
            this.RayasTrazoButton.TabIndex = 1;
            this.RayasTrazoButton.Text = "Rayas";
            this.RayasTrazoButton.UseVisualStyleBackColor = true;
            // 
            // ContinuoTrazoButton
            // 
            this.ContinuoTrazoButton.AutoSize = true;
            this.ContinuoTrazoButton.Checked = true;
            this.ContinuoTrazoButton.Location = new System.Drawing.Point(6, 19);
            this.ContinuoTrazoButton.Name = "ContinuoTrazoButton";
            this.ContinuoTrazoButton.Size = new System.Drawing.Size(67, 17);
            this.ContinuoTrazoButton.TabIndex = 0;
            this.ContinuoTrazoButton.TabStop = true;
            this.ContinuoTrazoButton.Text = "Continuo";
            this.ContinuoTrazoButton.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(326, 164);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(88, 61);
            this.btnCancelar.TabIndex = 61;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmCubo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 241);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.RellenoComboBox);
            this.Controls.Add(this.AristaTextBox);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Name = "frmCubo";
            this.Text = "frmCubo";
            this.Load += new System.EventHandler(this.frmCubo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void frmCubo_Load(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.ComboBox RellenoComboBox;
        private System.Windows.Forms.TextBox AristaTextBox;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton PuntoTrazoButton;
        private System.Windows.Forms.RadioButton RayasTrazoButton;
        private System.Windows.Forms.RadioButton ContinuoTrazoButton;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}