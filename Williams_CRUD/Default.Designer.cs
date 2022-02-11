
namespace Williams_CRUD
{
    partial class Default
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
            this.Customer_Btn = new System.Windows.Forms.Button();
            this.Products_Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Customer_Btn
            // 
            this.Customer_Btn.Location = new System.Drawing.Point(12, 12);
            this.Customer_Btn.Name = "Customer_Btn";
            this.Customer_Btn.Size = new System.Drawing.Size(159, 130);
            this.Customer_Btn.TabIndex = 0;
            this.Customer_Btn.Text = "Customer";
            this.Customer_Btn.UseVisualStyleBackColor = true;
            this.Customer_Btn.Click += new System.EventHandler(this.Customer_Btn_Click);
            // 
            // Products_Btn
            // 
            this.Products_Btn.Location = new System.Drawing.Point(177, 12);
            this.Products_Btn.Name = "Products_Btn";
            this.Products_Btn.Size = new System.Drawing.Size(159, 130);
            this.Products_Btn.TabIndex = 1;
            this.Products_Btn.Text = "Products";
            this.Products_Btn.UseVisualStyleBackColor = true;
            this.Products_Btn.Click += new System.EventHandler(this.Products_Btn_Click);
            // 
            // Default
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 164);
            this.Controls.Add(this.Products_Btn);
            this.Controls.Add(this.Customer_Btn);
            this.Name = "Default";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Customer_Btn;
        private System.Windows.Forms.Button Products_Btn;
    }
}

