
namespace Crud_En.NET_Sin_EntityFramework
{
    partial class Form2
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
            this.btnSave = new System.Windows.Forms.Button();
            this.txtSupercopas = new System.Windows.Forms.TextBox();
            this.lblSupercopas = new System.Windows.Forms.Label();
            this.txtCopasRey = new System.Windows.Forms.TextBox();
            this.lblCopasRey = new System.Windows.Forms.Label();
            this.txtLigas = new System.Windows.Forms.TextBox();
            this.lblLigas = new System.Windows.Forms.Label();
            this.txtChampions = new System.Windows.Forms.TextBox();
            this.lblChampions = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(479, 138);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 33;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtSupercopas
            // 
            this.txtSupercopas.Location = new System.Drawing.Point(162, 146);
            this.txtSupercopas.Name = "txtSupercopas";
            this.txtSupercopas.Size = new System.Drawing.Size(141, 20);
            this.txtSupercopas.TabIndex = 32;
            // 
            // lblSupercopas
            // 
            this.lblSupercopas.AutoSize = true;
            this.lblSupercopas.Location = new System.Drawing.Point(26, 149);
            this.lblSupercopas.Name = "lblSupercopas";
            this.lblSupercopas.Size = new System.Drawing.Size(64, 13);
            this.lblSupercopas.TabIndex = 31;
            this.lblSupercopas.Text = "Supercopas";
            // 
            // txtCopasRey
            // 
            this.txtCopasRey.Location = new System.Drawing.Point(479, 91);
            this.txtCopasRey.Name = "txtCopasRey";
            this.txtCopasRey.Size = new System.Drawing.Size(141, 20);
            this.txtCopasRey.TabIndex = 30;
            // 
            // lblCopasRey
            // 
            this.lblCopasRey.AutoSize = true;
            this.lblCopasRey.Location = new System.Drawing.Point(343, 91);
            this.lblCopasRey.Name = "lblCopasRey";
            this.lblCopasRey.Size = new System.Drawing.Size(76, 13);
            this.lblCopasRey.TabIndex = 29;
            this.lblCopasRey.Text = "Copas del Rey";
            // 
            // txtLigas
            // 
            this.txtLigas.Location = new System.Drawing.Point(162, 91);
            this.txtLigas.Name = "txtLigas";
            this.txtLigas.Size = new System.Drawing.Size(141, 20);
            this.txtLigas.TabIndex = 28;
            // 
            // lblLigas
            // 
            this.lblLigas.AutoSize = true;
            this.lblLigas.Location = new System.Drawing.Point(26, 91);
            this.lblLigas.Name = "lblLigas";
            this.lblLigas.Size = new System.Drawing.Size(32, 13);
            this.lblLigas.TabIndex = 27;
            this.lblLigas.Text = "Ligas";
            // 
            // txtChampions
            // 
            this.txtChampions.Location = new System.Drawing.Point(479, 35);
            this.txtChampions.Name = "txtChampions";
            this.txtChampions.Size = new System.Drawing.Size(141, 20);
            this.txtChampions.TabIndex = 26;
            // 
            // lblChampions
            // 
            this.lblChampions.AutoSize = true;
            this.lblChampions.Location = new System.Drawing.Point(343, 35);
            this.lblChampions.Name = "lblChampions";
            this.lblChampions.Size = new System.Drawing.Size(59, 13);
            this.lblChampions.TabIndex = 25;
            this.lblChampions.Text = "Champions";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(162, 35);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(141, 20);
            this.txtNombre.TabIndex = 24;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(26, 35);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(97, 13);
            this.lblNombre.TabIndex = 23;
            this.lblNombre.Text = "Nombre del Equipo";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 209);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtSupercopas);
            this.Controls.Add(this.lblSupercopas);
            this.Controls.Add(this.txtCopasRey);
            this.Controls.Add(this.lblCopasRey);
            this.Controls.Add(this.txtLigas);
            this.Controls.Add(this.lblLigas);
            this.Controls.Add(this.txtChampions);
            this.Controls.Add(this.lblChampions);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtSupercopas;
        private System.Windows.Forms.Label lblSupercopas;
        private System.Windows.Forms.TextBox txtCopasRey;
        private System.Windows.Forms.Label lblCopasRey;
        private System.Windows.Forms.TextBox txtLigas;
        private System.Windows.Forms.Label lblLigas;
        private System.Windows.Forms.TextBox txtChampions;
        private System.Windows.Forms.Label lblChampions;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
    }
}