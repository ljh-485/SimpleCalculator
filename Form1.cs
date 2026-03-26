namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        private string expression = string.Empty;
        private string currentOperand = string.Empty;

        public Form1()
        {
            InitializeComponent();
        }

        private void txtInsert_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRssult_TextChanged(object sender, EventArgs e)
        {

        }

        private void butCe_Click(object sender, EventArgs e)
        {

        }


        private void butC_Click(object sender, EventArgs e)
        {
            // C: Clear all
            expression = string.Empty;
            currentOperand = string.Empty;
            txtInsert.Text = string.Empty;
            txtRssult.Text = string.Empty;
            // reset title and focus to input to restore initial UI state
            txtTitle.Text = "Simple Calculator";
            txtInsert.Focus();
        }


        private void butDel_Click(object sender, EventArgs e)
        {
            // DEL: Backspace (remove last character)
            if (!string.IsNullOrEmpty(currentOperand))
            {
                currentOperand = currentOperand.Substring(0, currentOperand.Length - 1);
                expression = expression.Substring(0, expression.Length - 1);
                txtInsert.Text = expression;
                txtRssult.Text = currentOperand;
            }
            else if (!string.IsNullOrEmpty(expression))
            {
                // remove trailing operator
                expression = expression.Substring(0, expression.Length - 1);
                txtInsert.Text = expression;
                txtRssult.Text = string.Empty;
            }
        }


        private void butDivision_Click(object sender, EventArgs e)
        {
            // legacy: treat as operator click (designer originally wired this)
            OperatorButton_Click(sender, e);
        }

        private void NumberButton_Click(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                string digit = btn.Text;
                expression += digit;
                currentOperand += digit;
                txtInsert.Text = expression;
                txtRssult.Text = currentOperand;
            }
        }

        private void Dot_Click(object sender, EventArgs e)
        {
            // prevent multiple dots in the current operand
            if (currentOperand.Contains('.')) return;
            if (string.IsNullOrEmpty(currentOperand))
            {
                // start with 0.
                expression += "0.";
                currentOperand = "0.";
            }
            else
            {
                expression += ".";
                currentOperand += ".";
            }
            txtInsert.Text = expression;
            txtRssult.Text = currentOperand;
        }

        private void OperatorButton_Click(object sender, EventArgs e)
        {
            if (!(sender is Button btn)) return;
            string op = btn.Text;
            // normalize multiplication sign 'x' to 'x' kept as-is for display; evaluation will translate
            if (string.IsNullOrEmpty(currentOperand))
            {
                // replace trailing operator if exists
                if (!string.IsNullOrEmpty(expression))
                {
                    char last = expression[expression.Length - 1];
                    if ("+-x%".Contains(last))
                    {
                        expression = expression.Substring(0, expression.Length - 1) + op;
                    }
                }
            }
            else
            {
                expression += op;
                currentOperand = string.Empty;
                txtRssult.Text = string.Empty;
            }
            txtInsert.Text = expression;
        }

        private void butEqual_Click(object sender, EventArgs e)
        {
            // Evaluate expression and show result only in txtRssult
            try
            {
                if (string.IsNullOrEmpty(expression)) return;
                // prepare expression for DataTable.Compute: replace 'x' with '*', '%' (designer used as division) -> '/'
                string eval = expression.Replace("x", "*").Replace("%", "/");
                var dt = new System.Data.DataTable();
                var val = dt.Compute(eval, string.Empty);
                txtRssult.Text = val.ToString();
                // keep txtInsert showing the original input expression
            }
            catch
            {
                txtRssult.Text = "Error";
            }
        }

        private void butPlMi_Click(object sender, EventArgs e)
        {
            // toggle sign of current operand
            if (string.IsNullOrEmpty(currentOperand)) return;
            int start = expression.Length - currentOperand.Length;
            if (currentOperand.StartsWith("-"))
            {
                // remove leading -
                currentOperand = currentOperand.Substring(1);
            }
            else
            {
                currentOperand = "-" + currentOperand;
            }
            expression = expression.Substring(0, start) + currentOperand;
            txtInsert.Text = expression;
            txtRssult.Text = currentOperand;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
