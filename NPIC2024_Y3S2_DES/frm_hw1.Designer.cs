
namespace NPIC2024_Y3S2_DES
{
    partial class frm_hw1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtdtp = new System.Windows.Forms.DateTimePicker();
            this.txtname = new System.Windows.Forms.TextBox();
            this.rafood = new System.Windows.Forms.RadioButton();
            this.btnsend = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.radrink = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.btnreset = new System.Windows.Forms.Button();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.Price = new System.Windows.Forms.Label();
            this.txtqty = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.txtqty)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product Name";
            // 
            // txtdtp
            // 
            this.txtdtp.Location = new System.Drawing.Point(171, 171);
            this.txtdtp.Name = "txtdtp";
            this.txtdtp.Size = new System.Drawing.Size(327, 30);
            this.txtdtp.TabIndex = 1;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(171, 31);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(327, 30);
            this.txtname.TabIndex = 2;
            // 
            // rafood
            // 
            this.rafood.AutoSize = true;
            this.rafood.Location = new System.Drawing.Point(171, 95);
            this.rafood.Name = "rafood";
            this.rafood.Size = new System.Drawing.Size(72, 26);
            this.rafood.TabIndex = 3;
            this.rafood.TabStop = true;
            this.rafood.Text = "Food";
            this.rafood.UseVisualStyleBackColor = true;
            // 
            // btnsend
            // 
            this.btnsend.Location = new System.Drawing.Point(171, 418);
            this.btnsend.Name = "btnsend";
            this.btnsend.Size = new System.Drawing.Size(86, 45);
            this.btnsend.TabIndex = 4;
            this.btnsend.Text = "Send";
            this.btnsend.UseVisualStyleBackColor = true;
            this.btnsend.Click += new System.EventHandler(this.btnsend_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Type Of Product";
            // 
            // radrink
            // 
            this.radrink.AutoSize = true;
            this.radrink.Location = new System.Drawing.Point(364, 95);
            this.radrink.Name = "radrink";
            this.radrink.Size = new System.Drawing.Size(76, 26);
            this.radrink.TabIndex = 6;
            this.radrink.TabStop = true;
            this.radrink.Text = "Drink";
            this.radrink.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "Date";
            // 
            // btnreset
            // 
            this.btnreset.Location = new System.Drawing.Point(412, 418);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(86, 45);
            this.btnreset.TabIndex = 8;
            this.btnreset.Text = "Reset";
            this.btnreset.UseVisualStyleBackColor = true;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // txtphone
            // 
            this.txtphone.Location = new System.Drawing.Point(171, 236);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(327, 30);
            this.txtphone.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 22);
            this.label4.TabIndex = 9;
            this.label4.Text = "Phone ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 359);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 22);
            this.label5.TabIndex = 11;
            this.label5.Text = "QTY";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(171, 293);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(327, 30);
            this.txtPrice.TabIndex = 14;
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.Location = new System.Drawing.Point(28, 296);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(52, 22);
            this.Price.TabIndex = 13;
            this.Price.Text = "Price";
            // 
            // txtqty
            // 
            this.txtqty.Location = new System.Drawing.Point(171, 351);
            this.txtqty.Name = "txtqty";
            this.txtqty.Size = new System.Drawing.Size(327, 30);
            this.txtqty.TabIndex = 15;
            // 
            // frm_hw1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 498);
            this.Controls.Add(this.txtqty);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtphone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.radrink);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnsend);
            this.Controls.Add(this.rafood);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtdtp);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_hw1";
            this.Text = "frm_hw1";
            this.Load += new System.EventHandler(this.frm_hw1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtqty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker txtdtp;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.RadioButton rafood;
        private System.Windows.Forms.Button btnsend;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radrink;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label Price;
        private System.Windows.Forms.NumericUpDown txtqty;
    }
}