namespace Projeto_1Bim
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.DrawButton = new System.Windows.Forms.Button();
            this.b_box = new System.Windows.Forms.TextBox();
            this.m_box = new System.Windows.Forms.TextBox();
            this.FunctionLabel = new System.Windows.Forms.Label();
            this.x_box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.x2_box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DrawButton
            // 
            this.DrawButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.DrawButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.DrawButton.Location = new System.Drawing.Point(500, 401);
            this.DrawButton.Name = "DrawButton";
            this.DrawButton.Size = new System.Drawing.Size(126, 30);
            this.DrawButton.TabIndex = 0;
            this.DrawButton.Text = "Draw";
            this.DrawButton.UseVisualStyleBackColor = true;
            this.DrawButton.Click += new System.EventHandler(this.DrawButton_Click);
            // 
            // b_box
            // 
            this.b_box.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.b_box.Location = new System.Drawing.Point(278, 403);
            this.b_box.Name = "b_box";
            this.b_box.Size = new System.Drawing.Size(33, 26);
            this.b_box.TabIndex = 1;
            // 
            // m_box
            // 
            this.m_box.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.m_box.Location = new System.Drawing.Point(206, 405);
            this.m_box.Name = "m_box";
            this.m_box.Size = new System.Drawing.Size(32, 26);
            this.m_box.TabIndex = 2;
            // 
            // FunctionLabel
            // 
            this.FunctionLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.FunctionLabel.AutoSize = true;
            this.FunctionLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FunctionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FunctionLabel.Location = new System.Drawing.Point(327, 401);
            this.FunctionLabel.Name = "FunctionLabel";
            this.FunctionLabel.Size = new System.Drawing.Size(150, 28);
            this.FunctionLabel.TabIndex = 3;
            this.FunctionLabel.Text = "f(x) = mx + b";
            // 
            // x_box
            // 
            this.x_box.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.x_box.Location = new System.Drawing.Point(99, 353);
            this.x_box.Name = "x_box";
            this.x_box.Size = new System.Drawing.Size(32, 26);
            this.x_box.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 356);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "X1:";
            // 
            // x2_box
            // 
            this.x2_box.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.x2_box.Location = new System.Drawing.Point(99, 401);
            this.x2_box.Name = "x2_box";
            this.x2_box.Size = new System.Drawing.Size(32, 26);
            this.x2_box.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 404);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "X2:";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(174, 408);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "m:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(250, 408);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "b:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.x2_box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.x_box);
            this.Controls.Add(this.FunctionLabel);
            this.Controls.Add(this.m_box);
            this.Controls.Add(this.b_box);
            this.Controls.Add(this.DrawButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DrawButton;
        private System.Windows.Forms.TextBox b_box;
        private System.Windows.Forms.TextBox m_box;
        private System.Windows.Forms.Label FunctionLabel;
        private System.Windows.Forms.TextBox x_box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox x2_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

