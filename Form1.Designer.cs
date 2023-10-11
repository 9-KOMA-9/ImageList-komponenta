namespace ImageList_Komponenta
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.slika1 = new System.Windows.Forms.ImageList(this.components);
            this.slike = new System.Windows.Forms.PictureBox();
            this.promjeni = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.slike)).BeginInit();
            this.SuspendLayout();
            // 
            // slika1
            // 
            this.slika1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("slika1.ImageStream")));
            this.slika1.TransparentColor = System.Drawing.Color.Transparent;
            this.slika1.Images.SetKeyName(0, "IMG-2333.jpg");
            this.slika1.Images.SetKeyName(1, "IMG-2334.jpg");
            // 
            // slike
            // 
            this.slike.Location = new System.Drawing.Point(195, 42);
            this.slike.Name = "slike";
            this.slike.Size = new System.Drawing.Size(372, 202);
            this.slike.TabIndex = 0;
            this.slike.TabStop = false;
            // 
            // promjeni
            // 
            this.promjeni.Location = new System.Drawing.Point(318, 296);
            this.promjeni.Name = "promjeni";
            this.promjeni.Size = new System.Drawing.Size(120, 52);
            this.promjeni.TabIndex = 1;
            this.promjeni.Text = "Promjeni sliku";
            this.promjeni.UseVisualStyleBackColor = true;
            this.promjeni.Click += new System.EventHandler(this.promjeni_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.promjeni);
            this.Controls.Add(this.slike);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.slike)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList slika1;
        private System.Windows.Forms.PictureBox slike;
        private System.Windows.Forms.Button promjeni;
    }
}

