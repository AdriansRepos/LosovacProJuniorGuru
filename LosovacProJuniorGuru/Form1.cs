namespace LosovacProJuniorGuru
{
    public partial class Form1 : Form
    {
        private readonly Soutez soutez;
        public Form1()
        {
            InitializeComponent();
            this.AcceptButton = btnPridat;
            this.CancelButton = btnKonec;
            soutez = new Soutez();
            timerLosovani.Tick += timerLosovani_Tick;
        }

        private void btnPridat_Click(object sender, EventArgs e)
        {
            string jmeno = txtJmeno.Text.Trim();
            if (jmeno.Length == 0)
                return;

            soutez.PridejSouteziciho(jmeno);
            listSoutezici.Items.Add(jmeno);

            txtJmeno.Clear();
        }

        private void btnOdebrat_Click(object sender, EventArgs e)
        {
            if (listSoutezici.SelectedIndex == -1)
            {
                MessageBox.Show("Nejprve vyber soutìžícího ze seznamu.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string? jmeno = listSoutezici?.SelectedItem?.ToString();
            if (jmeno is null)
                return;

            soutez.OdeberSouteziciho(jmeno);
            if (listSoutezici?.SelectedItem != null)
            {
                listSoutezici.Items.Remove(listSoutezici.SelectedItem);
            }
        }

        private int _timerKroky = 0;

        private void btnLosovat_Click(object sender, EventArgs e)
        {
            if (soutez.VratVsechny().Length == 0)
            {
                MessageBox.Show("Nejprve pøidej soutìžící.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (numericVyherci.Value == 0)
            {
                MessageBox.Show("Poèet výhercù musí být alespoò 1.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (numericVyherci.Value > soutez.VratVsechny().Length)
            {
                MessageBox.Show("Poèet výhercù nemùže být vìtší než poèet soutìžících.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int pocet = (int)numericVyherci.Value;
            soutez.Losuj(pocet);

            listVyherci.Items.Clear();
            progressBarLosovani.Value = 0;
            _timerKroky = 0;
            btnLosovat.Enabled = false;
            timerLosovani.Start();
        }

        private void timerLosovani_Tick(object? sender, EventArgs e)
        {
            _timerKroky++;
            progressBarLosovani.Value = Math.Min(_timerKroky * 5, 100);  // fills over ~50 ticks

            if (progressBarLosovani.Value >= 100)
            {
                timerLosovani.Stop();
                btnLosovat.Enabled = true;
                foreach (var v in soutez.VratVyherce())
                    listVyherci.Items.Add(v.Jmeno);
            }
        }

        private void btnKonec_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}