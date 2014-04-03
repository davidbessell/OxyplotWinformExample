namespace OxyplotColumnExample
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
            this.btnBroken = new System.Windows.Forms.Button();
            this.btnWorking = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBroken
            // 
            this.btnBroken.Location = new System.Drawing.Point(141, 64);
            this.btnBroken.Name = "btnBroken";
            this.btnBroken.Size = new System.Drawing.Size(175, 31);
            this.btnBroken.TabIndex = 0;
            this.btnBroken.Text = "Broken Example";
            this.btnBroken.UseVisualStyleBackColor = true;
            this.btnBroken.Click += new System.EventHandler(this.btnBroken_Click);
            // 
            // btnWorking
            // 
            this.btnWorking.Location = new System.Drawing.Point(141, 125);
            this.btnWorking.Name = "btnWorking";
            this.btnWorking.Size = new System.Drawing.Size(175, 31);
            this.btnWorking.TabIndex = 1;
            this.btnWorking.Text = "Working Example";
            this.btnWorking.UseVisualStyleBackColor = true;
            this.btnWorking.Click += new System.EventHandler(this.btnWorking_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 323);
            this.Controls.Add(this.btnWorking);
            this.Controls.Add(this.btnBroken);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBroken;
        private System.Windows.Forms.Button btnWorking;

    }
}

