namespace PhuongTrinhBac2
{
    public partial class Form1 : Form
    {
        void solve(double a, double b, double c)
        {
            if (a == 0)
            {
                if (b == 0)
                {
                    if (c == 0)
                    {
                        lblKetQua.Text = $"Phương trình trên vô số nghiệm";
                    }
                    else
                    {
                        lblKetQua.Text = "Phương trình trên vô nghiệm";
                    }
                }
                else
                {
                    double rs = -c / b;
                    if (rs == 0)
                    {
                        rs = 0;
                    }
                    lblKetQua.Text = $"Phương trình trên có nghiệm duy nhất là: {rs}";
                }
            }
            else
            {
                double denta;
                denta = b * b - 4 * a * c;
                if (denta < 0)
                {
                    lblKetQua.Text = "Phương trình trên vô nghiệm";
                }
                else if (denta == 0)
                {
                    lblKetQua.Text = $"Phương trình trên có nghiệm kép: x1 = x2 = {-b / (2 * a)}";
                }
                else
                {
                    double x1 = (-b + Math.Sqrt(denta)) / (-2 * a);
                    double x2 = (-b - Math.Sqrt(denta)) / (-2 * a);
                    lblKetQua.Text = $"Phương trình có 2 nghiệm phân biệt x1 = {x1}, x2 = {x2}";
                }
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSolve_Click(object sender, EventArgs e)
        {
            try
            {
                double a = double.Parse(txtA.Text.Trim());
                double b = double.Parse(txtB.Text.Trim());
                double c = double.Parse(txtC.Text.Trim());
                solve(a, b, c);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtA.Text = "";
            txtB.Text = "";
            txtC.Text = "";
            lblKetQua.Text = "";
            txtA.Focus();
        }

        private void btnSolve_MouseHover(object sender, EventArgs e)
        {
            btnSolve.ForeColor = Color.Red;
        }

        private void btnSolve_MouseLeave(object sender, EventArgs e)
        {
            btnSolve.ForeColor = Color.Black;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Do you want to exit this", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
