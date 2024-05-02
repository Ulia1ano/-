namespace PZ16
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblPacketCount = new System.Windows.Forms.Label();
            this.lblCurrentPing = new System.Windows.Forms.Label();
            this.btnPing = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPacketCount
            // 
            this.lblPacketCount.AutoSize = true;
            this.lblPacketCount.Location = new System.Drawing.Point(177, 99);
            this.lblPacketCount.Name = "lblPacketCount";
            this.lblPacketCount.Size = new System.Drawing.Size(49, 16);
            this.lblPacketCount.TabIndex = 0;
            this.lblPacketCount.Text = "Клієнт";
            // 
            // lblCurrentPing
            // 
            this.lblCurrentPing.AutoSize = true;
            this.lblCurrentPing.Location = new System.Drawing.Point(302, 99);
            this.lblCurrentPing.Name = "lblCurrentPing";
            this.lblCurrentPing.Size = new System.Drawing.Size(34, 16);
            this.lblCurrentPing.TabIndex = 1;
            this.lblCurrentPing.Text = "Ping";
            // 
            // btnPing
            // 
            this.btnPing.Location = new System.Drawing.Point(180, 160);
            this.btnPing.Name = "btnPing";
            this.btnPing.Size = new System.Drawing.Size(145, 50);
            this.btnPing.TabIndex = 2;
            this.btnPing.Text = "Перевірити Ping і клієнт";
            this.btnPing.UseVisualStyleBackColor = true;
            this.btnPing.Click += new System.EventHandler(this.btnPing_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPing);
            this.Controls.Add(this.lblCurrentPing);
            this.Controls.Add(this.lblPacketCount);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPacketCount;
        private System.Windows.Forms.Label lblCurrentPing;
        private System.Windows.Forms.Button btnPing;
    }
}

