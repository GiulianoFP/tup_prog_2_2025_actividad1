namespace ej1
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
            btnDescribir = new Button();
            tbDescripcion = new TextBox();
            SuspendLayout();
            // 
            // btnDescribir
            // 
            btnDescribir.Location = new Point(651, 154);
            btnDescribir.Name = "btnDescribir";
            btnDescribir.Size = new Size(137, 109);
            btnDescribir.TabIndex = 0;
            btnDescribir.Text = "Construir y Describir Objetos";
            btnDescribir.UseVisualStyleBackColor = true;
            btnDescribir.Click += btnDescribir_Click;
            // 
            // tbDescripcion
            // 
            tbDescripcion.BorderStyle = BorderStyle.None;
            tbDescripcion.Location = new Point(23, 28);
            tbDescripcion.Multiline = true;
            tbDescripcion.Name = "tbDescripcion";
            tbDescripcion.Size = new Size(610, 394);
            tbDescripcion.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tbDescripcion);
            Controls.Add(btnDescribir);
            Name = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDescribir;
        private TextBox tbDescripcion;
    }
}
