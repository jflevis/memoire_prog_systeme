
namespace Memoire
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnMemoire = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMemoire
            // 
            this.btnMemoire.Location = new System.Drawing.Point(273, 102);
            this.btnMemoire.Name = "btnMemoire";
            this.btnMemoire.Size = new System.Drawing.Size(252, 172);
            this.btnMemoire.TabIndex = 0;
            this.btnMemoire.Text = "exercices données en mémoire";
            this.btnMemoire.UseVisualStyleBackColor = true;
            this.btnMemoire.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMemoire);
            this.Name = "Form1";
            this.Text = "frmExerciceMem";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMemoire;
    }
}

