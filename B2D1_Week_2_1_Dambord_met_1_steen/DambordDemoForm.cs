using System;
using System.Windows.Forms;

namespace B2D1_Week_2_1_Dambord_met_1_steen
{
    public partial class DambordDemoForm : Form
    {
        private Dambord mijnDambord;

        public DambordDemoForm()
        {
            InitializeComponent();
        }

        private void btnInitialiseer_Click(object sender, EventArgs e)
        {
            if (nudPositie.Value < nudAfmetingBord.Value * nudAfmetingBord.Value)
            {
                mijnDambord = new Dambord((int) nudAfmetingBord.Value, (int) nudPositie.Value);
            }
        }

        private string ToonPositie(int positie)
        {
            if (positie == -1)
            {
                return "";
            }
            else
            {
                return positie.ToString();
            }
        }

        private void btnToonPosities_Click(object sender, EventArgs e)
        {
            if (mijnDambord != null)
            {
                tbRechts.Text = ToonPositie(mijnDambord.ToonRechts());
                tbLinks.Text = ToonPositie(mijnDambord.ToonLinks());
                tbOnder.Text = ToonPositie(mijnDambord.ToonOnder());
                tbBoven.Text = ToonPositie(mijnDambord.ToonBoven());

                tbRechtsOnder.Text = ToonPositie(mijnDambord.ToonRechtsOnder());
                tbLinksBoven.Text = ToonPositie(mijnDambord.ToonLinksBoven());
                tbLinksOnder.Text = ToonPositie(mijnDambord.ToonLinksOnder());
                tbRechtsBoven.Text = ToonPositie(mijnDambord.ToonRechtsBoven());
            }
        }
    }
}
