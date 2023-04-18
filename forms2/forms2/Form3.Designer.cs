namespace forms2
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.txtNomePlano = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.btnCadastrarPlanos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNomePlano
            // 
            this.txtNomePlano.Location = new System.Drawing.Point(122, 116);
            this.txtNomePlano.Name = "txtNomePlano";
            this.txtNomePlano.Size = new System.Drawing.Size(100, 20);
            this.txtNomePlano.TabIndex = 0;
            this.txtNomePlano.Text = "nome";
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(122, 151);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(100, 20);
            this.txtDesc.TabIndex = 1;
            this.txtDesc.Text = "desc";
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(122, 188);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(100, 20);
            this.txtPreco.TabIndex = 2;
            this.txtPreco.Text = "preco";
            // 
            // btnCadastrarPlanos
            // 
            this.btnCadastrarPlanos.BackColor = System.Drawing.Color.Red;
            this.btnCadastrarPlanos.ForeColor = System.Drawing.Color.White;
            this.btnCadastrarPlanos.Location = new System.Drawing.Point(138, 225);
            this.btnCadastrarPlanos.Name = "btnCadastrarPlanos";
            this.btnCadastrarPlanos.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrarPlanos.TabIndex = 3;
            this.btnCadastrarPlanos.Text = "Cadastrar";
            this.btnCadastrarPlanos.UseVisualStyleBackColor = false;
            this.btnCadastrarPlanos.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(91, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cadastrar Planos";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(389, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(205, 278);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(651, 344);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCadastrarPlanos);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.txtNomePlano);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNomePlano;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Button btnCadastrarPlanos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}