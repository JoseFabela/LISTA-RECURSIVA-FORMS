namespace LISTA_RECURSIVA_FORMS
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
            this.resultListBox = new System.Windows.Forms.ListBox();
            this.explore = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // resultListBox
            // 
            this.resultListBox.FormattingEnabled = true;
            this.resultListBox.Location = new System.Drawing.Point(221, 29);
            this.resultListBox.Name = "resultListBox";
            this.resultListBox.Size = new System.Drawing.Size(546, 407);
            this.resultListBox.TabIndex = 1;
            // 
            // explore
            // 
            this.explore.Location = new System.Drawing.Point(83, 80);
            this.explore.Name = "explore";
            this.explore.Size = new System.Drawing.Size(75, 23);
            this.explore.TabIndex = 2;
            this.explore.Text = "explore";
            this.explore.UseVisualStyleBackColor = true;
            this.explore.Click += new System.EventHandler(this.explore_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.explore);
            this.Controls.Add(this.resultListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox resultListBox;
        private System.Windows.Forms.Button explore;
    }
}

