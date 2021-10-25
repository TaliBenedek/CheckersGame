
namespace CheckersGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.redButton = new System.Windows.Forms.RadioButton();
            this.whiteButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.startButton = new System.Windows.Forms.Button();
            this.whitePiece = new System.Windows.Forms.PictureBox();
            this.redPiece = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.whitePiece)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redPiece)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(99, 29);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(667, 625);
            this.panel1.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Easy",
            "Medium",
            "Hard"});
            this.comboBox1.Location = new System.Drawing.Point(869, 201);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(262, 33);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // redButton
            // 
            this.redButton.AutoSize = true;
            this.redButton.Checked = true;
            this.redButton.Location = new System.Drawing.Point(3, 31);
            this.redButton.Name = "redButton";
            this.redButton.Size = new System.Drawing.Size(74, 29);
            this.redButton.TabIndex = 2;
            this.redButton.TabStop = true;
            this.redButton.Text = "red";
            this.redButton.UseVisualStyleBackColor = true;
            // 
            // whiteButton
            // 
            this.whiteButton.AutoSize = true;
            this.whiteButton.Location = new System.Drawing.Point(94, 31);
            this.whiteButton.Name = "whiteButton";
            this.whiteButton.Size = new System.Drawing.Size(93, 29);
            this.whiteButton.TabIndex = 3;
            this.whiteButton.Text = "white";
            this.whiteButton.UseVisualStyleBackColor = true;
            this.whiteButton.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(898, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 51);
            this.label1.TabIndex = 4;
            this.label1.Text = "Difficulty:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(873, 330);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(257, 37);
            this.label2.TabIndex = 5;
            this.label2.Text = "Choose a color:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.whiteButton);
            this.panel2.Controls.Add(this.redButton);
            this.panel2.Location = new System.Drawing.Point(892, 370);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 7;
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Tahoma", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(926, 529);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(135, 67);
            this.startButton.TabIndex = 8;
            this.startButton.Text = "START";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // whitePiece
            // 
            this.whitePiece.Image = ((System.Drawing.Image)(resources.GetObject("whitePiece.Image")));
            this.whitePiece.Location = new System.Drawing.Point(799, 623);
            this.whitePiece.Name = "whitePiece";
            this.whitePiece.Size = new System.Drawing.Size(97, 46);
            this.whitePiece.TabIndex = 9;
            this.whitePiece.TabStop = false;
            this.whitePiece.Visible = false;
            // 
            // redPiece
            // 
            this.redPiece.Image = ((System.Drawing.Image)(resources.GetObject("redPiece.Image")));
            this.redPiece.Location = new System.Drawing.Point(1008, 623);
            this.redPiece.Name = "redPiece";
            this.redPiece.Size = new System.Drawing.Size(100, 50);
            this.redPiece.TabIndex = 10;
            this.redPiece.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 681);
            this.Controls.Add(this.redPiece);
            this.Controls.Add(this.whitePiece);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.whitePiece)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redPiece)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RadioButton redButton;
        private System.Windows.Forms.RadioButton whiteButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.PictureBox whitePiece;
        private System.Windows.Forms.PictureBox redPiece;
    }
}

