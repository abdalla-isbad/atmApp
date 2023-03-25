namespace atmApp
{
    partial class Summon
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
            this.summonBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // summonBtn
            // 
            this.summonBtn.Location = new System.Drawing.Point(202, 155);
            this.summonBtn.Name = "summonBtn";
            this.summonBtn.Size = new System.Drawing.Size(390, 142);
            this.summonBtn.TabIndex = 0;
            this.summonBtn.Text = "Summon ATMs";
            this.summonBtn.UseVisualStyleBackColor = true;
            this.summonBtn.Click += new System.EventHandler(this.summonBtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(271, 358);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Summon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.summonBtn);
            this.Name = "Summon";
            this.Text = "Summon";
            this.Load += new System.EventHandler(this.Summon_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button summonBtn;
        private Button button1;
    }
}