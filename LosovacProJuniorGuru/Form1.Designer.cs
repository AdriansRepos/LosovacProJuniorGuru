namespace LosovacProJuniorGuru
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            listSoutezici = new ListBox();
            listVyherci = new ListBox();
            txtJmeno = new TextBox();
            labelJmenoSouteziciho = new Label();
            btnPridat = new Button();
            labelPocetVyhercu = new Label();
            numericVyherci = new NumericUpDown();
            btnLosovat = new Button();
            btnKonec = new Button();
            pictureLogoJuniorGuru = new PictureBox();
            labelLosovacNazev = new Label();
            labelTvurce = new Label();
            labelSoutezici = new Label();
            labelVyherci = new Label();
            btnOdebrat = new Button();
            progressBarLosovani = new ProgressBar();
            timerLosovani = new System.Windows.Forms.Timer(components);
            labelPrubehLosovani = new Label();
            ((System.ComponentModel.ISupportInitialize)numericVyherci).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureLogoJuniorGuru).BeginInit();
            SuspendLayout();
            // 
            // listSoutezici
            // 
            listSoutezici.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            listSoutezici.FormattingEnabled = true;
            listSoutezici.ItemHeight = 22;
            listSoutezici.Location = new Point(40, 172);
            listSoutezici.Margin = new Padding(3, 4, 3, 4);
            listSoutezici.Name = "listSoutezici";
            listSoutezici.Size = new Size(224, 268);
            listSoutezici.TabIndex = 0;
            // 
            // listVyherci
            // 
            listVyherci.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            listVyherci.FormattingEnabled = true;
            listVyherci.ItemHeight = 22;
            listVyherci.Location = new Point(645, 172);
            listVyherci.Margin = new Padding(3, 4, 3, 4);
            listVyherci.Name = "listVyherci";
            listVyherci.Size = new Size(225, 268);
            listVyherci.TabIndex = 1;
            // 
            // txtJmeno
            // 
            txtJmeno.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            txtJmeno.Location = new Point(361, 178);
            txtJmeno.Margin = new Padding(3, 4, 3, 4);
            txtJmeno.Name = "txtJmeno";
            txtJmeno.Size = new Size(200, 28);
            txtJmeno.TabIndex = 2;
            // 
            // labelJmenoSouteziciho
            // 
            labelJmenoSouteziciho.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            labelJmenoSouteziciho.Location = new Point(358, 145);
            labelJmenoSouteziciho.Name = "labelJmenoSouteziciho";
            labelJmenoSouteziciho.Size = new Size(200, 29);
            labelJmenoSouteziciho.TabIndex = 3;
            labelJmenoSouteziciho.Text = "Jméno soutěžícího";
            // 
            // btnPridat
            // 
            btnPridat.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            btnPridat.Location = new Point(361, 220);
            btnPridat.Margin = new Padding(3, 4, 3, 4);
            btnPridat.Name = "btnPridat";
            btnPridat.Size = new Size(95, 44);
            btnPridat.TabIndex = 4;
            btnPridat.Text = "Přidat";
            btnPridat.UseVisualStyleBackColor = true;
            btnPridat.Click += btnPridat_Click;
            // 
            // labelPocetVyhercu
            // 
            labelPocetVyhercu.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            labelPocetVyhercu.Location = new Point(358, 290);
            labelPocetVyhercu.Name = "labelPocetVyhercu";
            labelPocetVyhercu.Size = new Size(133, 29);
            labelPocetVyhercu.TabIndex = 5;
            labelPocetVyhercu.Text = "Počet výherců";
            // 
            // numericVyherci
            // 
            numericVyherci.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            numericVyherci.Location = new Point(501, 290);
            numericVyherci.Margin = new Padding(3, 4, 3, 4);
            numericVyherci.Name = "numericVyherci";
            numericVyherci.Size = new Size(60, 24);
            numericVyherci.TabIndex = 6;
            // 
            // btnLosovat
            // 
            btnLosovat.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            btnLosovat.Location = new Point(410, 328);
            btnLosovat.Margin = new Padding(3, 4, 3, 4);
            btnLosovat.Name = "btnLosovat";
            btnLosovat.Size = new Size(95, 45);
            btnLosovat.TabIndex = 7;
            btnLosovat.Text = "Losuj";
            btnLosovat.UseVisualStyleBackColor = true;
            btnLosovat.Click += btnLosovat_Click;
            // 
            // btnKonec
            // 
            btnKonec.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            btnKonec.Location = new Point(410, 505);
            btnKonec.Margin = new Padding(3, 4, 3, 4);
            btnKonec.Name = "btnKonec";
            btnKonec.Size = new Size(95, 42);
            btnKonec.TabIndex = 8;
            btnKonec.Text = "Konec";
            btnKonec.UseVisualStyleBackColor = true;
            btnKonec.Click += btnKonec_Click;
            // 
            // pictureLogoJuniorGuru
            // 
            pictureLogoJuniorGuru.BackColor = Color.Yellow;
            pictureLogoJuniorGuru.Image = Properties.Resources.logo;
            pictureLogoJuniorGuru.Location = new Point(40, 16);
            pictureLogoJuniorGuru.Margin = new Padding(3, 4, 3, 4);
            pictureLogoJuniorGuru.Name = "pictureLogoJuniorGuru";
            pictureLogoJuniorGuru.Size = new Size(224, 104);
            pictureLogoJuniorGuru.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureLogoJuniorGuru.TabIndex = 9;
            pictureLogoJuniorGuru.TabStop = false;
            // 
            // labelLosovacNazev
            // 
            labelLosovacNazev.Font = new Font("Microsoft Sans Serif", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 238);
            labelLosovacNazev.Location = new Point(322, 16);
            labelLosovacNazev.Name = "labelLosovacNazev";
            labelLosovacNazev.Size = new Size(548, 80);
            labelLosovacNazev.TabIndex = 10;
            labelLosovacNazev.Text = "Losovač soutěží";
            labelLosovacNazev.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelTvurce
            // 
            labelTvurce.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            labelTvurce.Location = new Point(519, 96);
            labelTvurce.Name = "labelTvurce";
            labelTvurce.Size = new Size(222, 24);
            labelTvurce.TabIndex = 11;
            labelTvurce.Text = "Pro Junior.Guru od ©Adrian";
            // 
            // labelSoutezici
            // 
            labelSoutezici.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            labelSoutezici.Location = new Point(40, 145);
            labelSoutezici.Name = "labelSoutezici";
            labelSoutezici.Size = new Size(151, 24);
            labelSoutezici.TabIndex = 12;
            labelSoutezici.Text = "Soutěžící";
            // 
            // labelVyherci
            // 
            labelVyherci.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            labelVyherci.Location = new Point(645, 145);
            labelVyherci.Name = "labelVyherci";
            labelVyherci.Size = new Size(169, 24);
            labelVyherci.TabIndex = 13;
            labelVyherci.Text = "Výherci";
            // 
            // btnOdebrat
            // 
            btnOdebrat.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            btnOdebrat.Location = new Point(463, 222);
            btnOdebrat.Margin = new Padding(3, 4, 3, 4);
            btnOdebrat.Name = "btnOdebrat";
            btnOdebrat.Size = new Size(95, 41);
            btnOdebrat.TabIndex = 14;
            btnOdebrat.Text = "Odebrat";
            btnOdebrat.UseVisualStyleBackColor = true;
            btnOdebrat.Click += btnOdebrat_Click;
            // 
            // progressBarLosovani
            // 
            progressBarLosovani.Location = new Point(361, 424);
            progressBarLosovani.Margin = new Padding(3, 4, 3, 4);
            progressBarLosovani.Name = "progressBarLosovani";
            progressBarLosovani.Size = new Size(197, 29);
            progressBarLosovani.TabIndex = 15;
            // 
            // labelPrubehLosovani
            // 
            labelPrubehLosovani.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            labelPrubehLosovani.Location = new Point(358, 391);
            labelPrubehLosovani.Name = "labelPrubehLosovani";
            labelPrubehLosovani.Size = new Size(200, 29);
            labelPrubehLosovani.TabIndex = 16;
            labelPrubehLosovani.Text = "Průběh Losování";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(911, 596);
            Controls.Add(labelPrubehLosovani);
            Controls.Add(progressBarLosovani);
            Controls.Add(btnOdebrat);
            Controls.Add(labelVyherci);
            Controls.Add(labelSoutezici);
            Controls.Add(labelTvurce);
            Controls.Add(labelLosovacNazev);
            Controls.Add(pictureLogoJuniorGuru);
            Controls.Add(btnKonec);
            Controls.Add(btnLosovat);
            Controls.Add(numericVyherci);
            Controls.Add(labelPocetVyhercu);
            Controls.Add(btnPridat);
            Controls.Add(labelJmenoSouteziciho);
            Controls.Add(txtJmeno);
            Controls.Add(listVyherci);
            Controls.Add(listSoutezici);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Losovač soutěží";
            ((System.ComponentModel.ISupportInitialize)numericVyherci).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureLogoJuniorGuru).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listSoutezici;
        private System.Windows.Forms.ListBox listVyherci;
        private System.Windows.Forms.TextBox txtJmeno;
        private System.Windows.Forms.Label labelJmenoSouteziciho;
        private System.Windows.Forms.Button btnPridat;
        private System.Windows.Forms.Label labelPocetVyhercu;
        private System.Windows.Forms.NumericUpDown numericVyherci;
        private System.Windows.Forms.Button btnLosovat;
        private System.Windows.Forms.Button btnKonec;
        private System.Windows.Forms.PictureBox pictureLogoJuniorGuru;
        private System.Windows.Forms.Label labelLosovacNazev;
        private System.Windows.Forms.Label labelTvurce;
        private System.Windows.Forms.Label labelSoutezici;
        private System.Windows.Forms.Label labelVyherci;
        private System.Windows.Forms.Button btnOdebrat;
        private System.Windows.Forms.ProgressBar progressBarLosovani;
        private System.Windows.Forms.Timer timerLosovani;
        private System.Windows.Forms.Label labelPrubehLosovani;
    }
}