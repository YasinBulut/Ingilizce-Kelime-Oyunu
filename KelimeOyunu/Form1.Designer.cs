
namespace KelimeOyunu
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtingilizce = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtturkce = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblsure = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblkelime = new System.Windows.Forms.Label();
            this.lblcevap = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "İNGİLİZCE:";
            // 
            // txtingilizce
            // 
            this.txtingilizce.Enabled = false;
            this.txtingilizce.Location = new System.Drawing.Point(132, 230);
            this.txtingilizce.Name = "txtingilizce";
            this.txtingilizce.Size = new System.Drawing.Size(276, 30);
            this.txtingilizce.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(26, 278);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "TÜRKÇE:";
            // 
            // txtturkce
            // 
            this.txtturkce.Location = new System.Drawing.Point(132, 278);
            this.txtturkce.Name = "txtturkce";
            this.txtturkce.Size = new System.Drawing.Size(276, 30);
            this.txtturkce.TabIndex = 1;
            this.txtturkce.TextChanged += new System.EventHandler(this.txtturkce_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Mistral", 55F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(160, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(527, 110);
            this.label3.TabIndex = 4;
            this.label3.Text = "KELİME OYUNU";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(559, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "SÜRE:";
            // 
            // lblsure
            // 
            this.lblsure.AutoSize = true;
            this.lblsure.BackColor = System.Drawing.Color.Transparent;
            this.lblsure.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblsure.ForeColor = System.Drawing.Color.White;
            this.lblsure.Location = new System.Drawing.Point(652, 230);
            this.lblsure.Name = "lblsure";
            this.lblsure.Size = new System.Drawing.Size(36, 25);
            this.lblsure.TabIndex = 6;
            this.lblsure.Text = "90";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(540, 280);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 25);
            this.label6.TabIndex = 7;
            this.label6.Text = "KELİME:";
            // 
            // lblkelime
            // 
            this.lblkelime.AutoSize = true;
            this.lblkelime.BackColor = System.Drawing.Color.Transparent;
            this.lblkelime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblkelime.ForeColor = System.Drawing.Color.White;
            this.lblkelime.Location = new System.Drawing.Point(663, 280);
            this.lblkelime.Name = "lblkelime";
            this.lblkelime.Size = new System.Drawing.Size(24, 25);
            this.lblkelime.TabIndex = 8;
            this.lblkelime.Text = "0";
            // 
            // lblcevap
            // 
            this.lblcevap.AutoSize = true;
            this.lblcevap.BackColor = System.Drawing.Color.Transparent;
            this.lblcevap.ForeColor = System.Drawing.Color.White;
            this.lblcevap.Location = new System.Drawing.Point(727, 283);
            this.lblcevap.Name = "lblcevap";
            this.lblcevap.Size = new System.Drawing.Size(64, 25);
            this.lblcevap.TabIndex = 9;
            this.lblcevap.Text = "label5";
            this.lblcevap.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(828, 321);
            this.Controls.Add(this.lblcevap);
            this.Controls.Add(this.lblkelime);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblsure);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtturkce);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtingilizce);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtingilizce;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtturkce;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblsure;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblkelime;
        private System.Windows.Forms.Label lblcevap;
        private System.Windows.Forms.Timer timer1;
    }
}

