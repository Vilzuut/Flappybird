namespace FlappyBirb_Peli
{
    partial class Kirjautuminen
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
            this.txtsalasana = new System.Windows.Forms.TextBox();
            this.kayttajatunnus = new System.Windows.Forms.Label();
            this.salasana = new System.Windows.Forms.Label();
            this.txtkayttaja = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonKirjaudu = new System.Windows.Forms.Button();
            this.txtvirheellinen = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtsalasana
            // 
            this.txtsalasana.Location = new System.Drawing.Point(398, 323);
            this.txtsalasana.Multiline = true;
            this.txtsalasana.Name = "txtsalasana";
            this.txtsalasana.Size = new System.Drawing.Size(221, 29);
            this.txtsalasana.TabIndex = 0;
            this.txtsalasana.UseSystemPasswordChar = true;
            // 
            // kayttajatunnus
            // 
            this.kayttajatunnus.AutoSize = true;
            this.kayttajatunnus.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kayttajatunnus.Location = new System.Drawing.Point(211, 246);
            this.kayttajatunnus.Name = "kayttajatunnus";
            this.kayttajatunnus.Size = new System.Drawing.Size(181, 29);
            this.kayttajatunnus.TabIndex = 2;
            this.kayttajatunnus.Text = "Käyttäjätunnus";
            // 
            // salasana
            // 
            this.salasana.AutoSize = true;
            this.salasana.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salasana.Location = new System.Drawing.Point(272, 323);
            this.salasana.Name = "salasana";
            this.salasana.Size = new System.Drawing.Size(120, 29);
            this.salasana.TabIndex = 3;
            this.salasana.Text = "Salasana";
            // 
            // txtkayttaja
            // 
            this.txtkayttaja.Location = new System.Drawing.Point(398, 246);
            this.txtkayttaja.Multiline = true;
            this.txtkayttaja.Name = "txtkayttaja";
            this.txtkayttaja.Size = new System.Drawing.Size(221, 29);
            this.txtkayttaja.TabIndex = 4;
            this.txtkayttaja.TextChanged += new System.EventHandler(this.txtkayttaja_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(252, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 47);
            this.label1.TabIndex = 5;
            this.label1.Text = "KIRJAUDU SISÄÄN";
            // 
            // ButtonKirjaudu
            // 
            this.ButtonKirjaudu.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ButtonKirjaudu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonKirjaudu.Location = new System.Drawing.Point(398, 379);
            this.ButtonKirjaudu.Name = "ButtonKirjaudu";
            this.ButtonKirjaudu.Size = new System.Drawing.Size(148, 34);
            this.ButtonKirjaudu.TabIndex = 6;
            this.ButtonKirjaudu.Text = "Kirjaudu sisään";
            this.ButtonKirjaudu.UseVisualStyleBackColor = false;
            this.ButtonKirjaudu.Click += new System.EventHandler(this.ButtonKirjaudu_Click);
            // 
            // txtvirheellinen
            // 
            this.txtvirheellinen.AutoSize = true;
            this.txtvirheellinen.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtvirheellinen.ForeColor = System.Drawing.Color.Maroon;
            this.txtvirheellinen.Location = new System.Drawing.Point(231, 189);
            this.txtvirheellinen.Name = "txtvirheellinen";
            this.txtvirheellinen.Size = new System.Drawing.Size(0, 26);
            this.txtvirheellinen.TabIndex = 7;
            // 
            // Kirjautuminen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(882, 537);
            this.Controls.Add(this.txtvirheellinen);
            this.Controls.Add(this.ButtonKirjaudu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtkayttaja);
            this.Controls.Add(this.salasana);
            this.Controls.Add(this.kayttajatunnus);
            this.Controls.Add(this.txtsalasana);
            this.Name = "Kirjautuminen";
            this.Text = "Kirjautuminen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtsalasana;
        private System.Windows.Forms.Label kayttajatunnus;
        private System.Windows.Forms.Label salasana;
        private System.Windows.Forms.TextBox txtkayttaja;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonKirjaudu;
        private System.Windows.Forms.Label txtvirheellinen;
    }
}