﻿namespace _4._1F
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
            this.b = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.N = new System.Windows.Forms.TextBox();
            this.V = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // b
            // 
            this.b.Location = new System.Drawing.Point(25, 114);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(75, 23);
            this.b.TabIndex = 0;
            this.b.Text = "Жми";
            this.b.UseVisualStyleBackColor = true;
            this.b.Click += new System.EventHandler(this.b_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-3, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Количетсво повторов N";
            // 
            // N
            // 
            this.N.Location = new System.Drawing.Point(0, 88);
            this.N.Name = "N";
            this.N.Size = new System.Drawing.Size(124, 20);
            this.N.TabIndex = 2;
            // 
            // V
            // 
            this.V.Location = new System.Drawing.Point(130, 88);
            this.V.Multiline = true;
            this.V.Name = "V";
            this.V.Size = new System.Drawing.Size(136, 49);
            this.V.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.V);
            this.Controls.Add(this.N);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.b);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox N;
        private System.Windows.Forms.TextBox V;
    }
}

