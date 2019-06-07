using System;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace DiceForCOC
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Text += " " + Application.ProductVersion;
        }

        private int GetRandomDiceResult(int count, int dice, int adjust)
        {
            byte[] bytes = new byte[4];
            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
            rng.GetBytes(bytes);

            Random rnd = new Random(BitConverter.ToInt32(bytes, 0));

            for (int i = 0; i < count; i++)
            {
                adjust += rnd.Next(dice) + 1;
            }

            return adjust;
        }
        
        private int GetRandomString(int count, int dice, int adjust)
        {
            decimal maxValue = long.MaxValue;
            byte[] array = new byte[dice];
            new RNGCryptoServiceProvider().GetBytes(array);

            return (int)(Math.Abs(BitConverter.ToInt64(array, 0)) / maxValue * 10);
        }

        private String GetResultStr(int count, int dice, int adjust, int diceResult)
        {
            String result = "D" + dice;

            if (count > 1)
            {
                result = count + "*" + result;
            }

            if (adjust > 0)
            {
                result += "+" + adjust;
            }
            else if (adjust < 0)
            {
                result += adjust;
            }

            return result + ": " + diceResult;
        }

        private void InsertLastResult(String lastResult)
        {
            logTxt.Text += lastResult;
            logTxt.Text += "\r\n";

            logTxt.Focus();
            logTxt.Select(logTxt.TextLength, 0);
            logTxt.ScrollToCaret();
        }

        private void D4Btn_MouseClick(object sender, MouseEventArgs e)
        {
            int count = (int)d4CountNud.Value;
            int adjust = (int)d4AdjustNud.Value;
            
            InsertLastResult(GetResultStr(count, 4, adjust, GetRandomDiceResult(count, 4, adjust)));
        }

        private void D6Btn_MouseClick(object sender, MouseEventArgs e)
        {
            int count = (int)d6CountNud.Value;
            int adjust = (int)d6AdjustNud.Value;

            InsertLastResult(GetResultStr(count, 6, adjust, GetRandomDiceResult(count, 6, adjust)));
        }

        private void D8Btn_MouseClick(object sender, MouseEventArgs e)
        {
            int count = (int)d8CountNud.Value;
            int adjust = (int)d8AdjustNud.Value;

            InsertLastResult(GetResultStr(count, 8, adjust, GetRandomDiceResult(count, 8, adjust)));
        }

        private void D20Btn_MouseClick(object sender, MouseEventArgs e)
        {
            int count = (int)d20CountNud.Value;
            int adjust = (int)d20AdjustNud.Value;

            InsertLastResult(GetResultStr(count, 20, adjust, GetRandomDiceResult(count, 20, adjust)));
        }

        private void D100Btn_MouseClick(object sender, MouseEventArgs e)
        {
            int count = (int)d100CountNud.Value;
            int adjust = (int)d100AdjustNud.Value;

            InsertLastResult(GetResultStr(count, 100, adjust, GetRandomDiceResult(count, 100, adjust)));
        }

        private void DCustomBtn_MouseClick(object sender, MouseEventArgs e)
        {
            int count = (int)d100CountNud.Value;
            int dice = Convert.ToInt32(dCustomCombo.Text);
            int adjust = (int)d100AdjustNud.Value;

            InsertLastResult(GetResultStr(count, dice, adjust, GetRandomDiceResult(count, dice, adjust)));
        }

        private void ResetBtn_MouseClick(object sender, MouseEventArgs e)
        {
            d4CountNud.Value = 1;
            d6CountNud.Value = 1;
            d8CountNud.Value = 1;
            d20CountNud.Value = 1;
            d100CountNud.Value = 1;
            dCustomCountNud.Value = 1;

            d4AdjustNud.Value = 0;
            d6AdjustNud.Value = 0;
            d8AdjustNud.Value = 0;
            d20AdjustNud.Value = 0;
            d100AdjustNud.Value = 0;
            dCustomAdjustNud.Value = 0;

            dCustomCombo.SelectedIndex = 98;
        }

        private void ClearBtn_MouseClick(object sender, MouseEventArgs e)
        {
            logTxt.Text = "";
        }
    }
}
