﻿
namespace PetAsService
{
    partial class FrmBuscarRacas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBuscarRacas));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbRaca = new System.Windows.Forms.ComboBox();
            this.lblTemperamento = new System.Windows.Forms.Label();
            this.lblOrigem = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.pbGato = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbGato)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(775, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "_________________________________________________________________________________" +
    "_______________________________________________";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(32, 38);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(689, 38);
            this.textBox1.TabIndex = 3;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "Ultilize a caixa de seleção de raças para buscar caracteristicas sobre determinad" +
    "o gatinho e descobrir qual é a sua raça favorita.";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Control;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(32, 3);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(299, 29);
            this.textBox2.TabIndex = 4;
            this.textBox2.TabStop = false;
            this.textBox2.Text = "Encontre Sua Raça Favorita";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(206, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Raça do Gato";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(199, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Temperamento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(233, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Origem";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(218, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Descrição";
            // 
            // cbRaca
            // 
            this.cbRaca.FormattingEnabled = true;
            this.cbRaca.Location = new System.Drawing.Point(287, 108);
            this.cbRaca.Name = "cbRaca";
            this.cbRaca.Size = new System.Drawing.Size(244, 21);
            this.cbRaca.TabIndex = 0;
            this.cbRaca.Text = "Selecione uma Raça";
            // 
            // lblTemperamento
            // 
            this.lblTemperamento.AutoSize = true;
            this.lblTemperamento.Location = new System.Drawing.Point(284, 140);
            this.lblTemperamento.Name = "lblTemperamento";
            this.lblTemperamento.Size = new System.Drawing.Size(64, 13);
            this.lblTemperamento.TabIndex = 10;
            this.lblTemperamento.Text = "Resultado...";
            // 
            // lblOrigem
            // 
            this.lblOrigem.AutoSize = true;
            this.lblOrigem.Location = new System.Drawing.Point(284, 165);
            this.lblOrigem.Name = "lblOrigem";
            this.lblOrigem.Size = new System.Drawing.Size(64, 13);
            this.lblOrigem.TabIndex = 11;
            this.lblOrigem.Text = "Resultado...";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(284, 193);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(64, 13);
            this.lblDescricao.TabIndex = 12;
            this.lblDescricao.Text = "Resultado...";
            // 
            // pbGato
            // 
            this.pbGato.Image = ((System.Drawing.Image)(resources.GetObject("pbGato.Image")));
            this.pbGato.Location = new System.Drawing.Point(155, 230);
            this.pbGato.Name = "pbGato";
            this.pbGato.Size = new System.Drawing.Size(469, 244);
            this.pbGato.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGato.TabIndex = 13;
            this.pbGato.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 529);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(804, 32);
            this.panel1.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(636, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(717, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Favoritar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // FrmBuscarRacas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 561);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pbGato);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.lblOrigem);
            this.Controls.Add(this.lblTemperamento);
            this.Controls.Add(this.cbRaca);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBuscarRacas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Raças";
            ((System.ComponentModel.ISupportInitialize)(this.pbGato)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbRaca;
        private System.Windows.Forms.Label lblTemperamento;
        private System.Windows.Forms.Label lblOrigem;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.PictureBox pbGato;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}