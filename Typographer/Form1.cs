using System;
using System.Windows.Forms;

namespace Typographer
{
    public partial class Form1 : Form
    {
        private readonly Typographer typographer;

        public Form1()
        {
            InitializeComponent();

            typographer = new Typographer(UserTextField);
        }


        private void Correctbutton_Click(object sender, EventArgs e)
        {
            this.OutputTextField.Text = typographer.GetCorrectText();
        }
    }
}
