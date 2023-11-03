namespace app_2_igjen
{
    partial class Form1
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
            this.blåknapp = new System.Windows.Forms.Button();
            this.grønnknapp = new System.Windows.Forms.Button();
            this.resetknapp = new System.Windows.Forms.Button();
            this.exitknapp = new System.Windows.Forms.Button();
            this.colorChangeBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.colorChangeBox)).BeginInit();
            this.SuspendLayout();
            // 
            // blåknapp
            // 
            this.blåknapp.Location = new System.Drawing.Point(506, 78);
            this.blåknapp.Name = "blåknapp";
            this.blåknapp.Size = new System.Drawing.Size(204, 45);
            this.blåknapp.TabIndex = 0;
            this.blåknapp.Text = "blå";
            this.blåknapp.UseVisualStyleBackColor = true;
            this.blåknapp.Click += new System.EventHandler(this.blåknapp_Click);
            // 
            // grønnknapp
            // 
            this.grønnknapp.Location = new System.Drawing.Point(506, 150);
            this.grønnknapp.Name = "grønnknapp";
            this.grønnknapp.Size = new System.Drawing.Size(204, 45);
            this.grønnknapp.TabIndex = 1;
            this.grønnknapp.Text = "grønn";
            this.grønnknapp.UseVisualStyleBackColor = true;
            this.grønnknapp.Click += new System.EventHandler(this.grønnknapp_Click);
            // 
            // resetknapp
            // 
            this.resetknapp.Location = new System.Drawing.Point(506, 231);
            this.resetknapp.Name = "resetknapp";
            this.resetknapp.Size = new System.Drawing.Size(204, 45);
            this.resetknapp.TabIndex = 2;
            this.resetknapp.Text = "reset";
            this.resetknapp.UseVisualStyleBackColor = true;
            this.resetknapp.Click += new System.EventHandler(this.resetknapp_Click);
            // 
            // exitknapp
            // 
            this.exitknapp.Location = new System.Drawing.Point(506, 321);
            this.exitknapp.Name = "exitknapp";
            this.exitknapp.Size = new System.Drawing.Size(204, 45);
            this.exitknapp.TabIndex = 3;
            this.exitknapp.Text = "exit";
            this.exitknapp.UseVisualStyleBackColor = true;
            this.exitknapp.Click += new System.EventHandler(this.exitknapp_Click);
            // 
            // colorChangeBox
            // 
            this.colorChangeBox.Location = new System.Drawing.Point(48, 78);
            this.colorChangeBox.Name = "colorChangeBox";
            this.colorChangeBox.Size = new System.Drawing.Size(392, 310);
            this.colorChangeBox.TabIndex = 4;
            this.colorChangeBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.colorChangeBox);
            this.Controls.Add(this.exitknapp);
            this.Controls.Add(this.resetknapp);
            this.Controls.Add(this.grønnknapp);
            this.Controls.Add(this.blåknapp);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.colorChangeBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button blåknapp;
        private System.Windows.Forms.Button grønnknapp;
        private System.Windows.Forms.Button resetknapp;
        private System.Windows.Forms.Button exitknapp;
        private System.Windows.Forms.PictureBox colorChangeBox;
    }
}

