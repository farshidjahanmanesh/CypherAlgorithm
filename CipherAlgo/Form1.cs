using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CipherAlgo
{
    public partial class Form1 : Form
    {
        private static readonly Dictionary<char, char> SubStitution = new Dictionary<char, char>();
        public Form1()
        {
            InitializeComponent();
           // TestProject();
        }

        private void RefreshLabels()
        {
            EncodeLabel.Text = "";
            EncodeSubStitution.Text = "";
        }
        //private int TestProject()
        //{
        //    int counter = 0;
        //    Random rand = new Random();
        //    UseForEncodeSubStitution.Checked = true;
        //    TranspositionCheckBox.Checked = true;
        //    UseForDecodeTransposition.Checked = true;
        //    UseForDecodeSubStitution.Checked = true;
        //    for (int i = 0; i < 10000; i++)
        //    {
        //        SubStitution.Clear();
        //        var randNumber = rand.Next(0, 1000);

        //        var sub = rand.Next(0, 2);
        //        UseForEncodeSubStitution.Checked = Convert.ToBoolean(sub);
        //        UseForDecodeSubStitution.Checked = Convert.ToBoolean(sub);
        //        var tr = rand.Next(0, 2);
        //        TranspositionCheckBox.Checked = Convert.ToBoolean(tr);
        //        UseForDecodeTransposition.Checked = Convert.ToBoolean(tr);

        //        var testString = Guid.NewGuid().ToString();
        //        var enc = Encoding(testString, randNumber);
        //        var value = Decode(enc, randNumber);
        //        if (!testString.Equals(value))
        //            counter++;
        //    }
        //    return counter;
        //}

        private void EncodeButton_Click(object sender, EventArgs e)
        {
            RefreshLabels();
            if (string.IsNullOrEmpty(inputTextBox.Text))
            {
                EncodeLabel.Text = "لطفا فیلد ها را پر کنید";
                EncodeLabel.Visible = true;
                return;
            }

            Encoding(inputTextBox.Text, (int)KeyInput.Value);

        }
        private void DecodeButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(CypherTextBox.Text))
            {
                DecodeKey.Text = "لطفا فیلد ها را پر کنید";
                DecodeKey.Visible = true;
                return;
            }

            Decode(CypherTextBox.Text, (int)DecodeKeyTextBox.Value);
        }

        #region WithKey
        private string EncodeWithKey(string text, int key)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in text)
            {
                sb.Append((char)(item + key));
            }
            return sb.ToString();
        }

        private string DecodeWithKey(string codeText, int key)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in codeText)
            {
                sb.Append((char)(item - key));
            }
            return sb.ToString();
        }

        #endregion

        #region WithSubStitution
        private string EncodeWithSubStitution(string text)
        {
            Random rand = new Random();
            StringBuilder sb = new StringBuilder();
            foreach (var item in text)
            {
                int randNum = 0;
                do
                {
                    randNum = rand.Next(0, 1000);
                } while (SubStitution.ContainsValue((char)randNum));

                if (SubStitution.ContainsKey(item))
                {
                    sb.Append((char)SubStitution.First(c => c.Key == item).Value);
                    continue;
                }
                SubStitution.Add((char)item, (char)randNum);
                sb.Append((char)randNum);
            }
            return sb.ToString();
        }
        private string DecodeWithSubStitution(string text)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in text)
            {
                char coded = ' ';
                try
                {
                    coded = SubStitution.First(c => c.Value == item).Key;
                }
                catch (Exception)
                {
                    Random rand = new Random();
                    var ch = (char)rand.Next(0, 255);
                    coded = ch;
                }

                sb.Append(coded);
            }
            return sb.ToString();
        }
        #endregion

        #region Transposition
        private string EncodeWithTransposition(string text, int key)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < text.Length; i++)
            {
                sb.Append((char)(key ^ text[i]));
            }

            return sb.ToString();
        }

        private string DecodeWithTransposition(string text, int key)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < text.Length; i++)
            {
                sb.Append((char)(text[i] ^ key));
            }
            return sb.ToString();
        }
        #endregion

        #region LabelEvents
        private void EncodeLabel_Click(object sender, EventArgs e)
        {
            EncodeLabel.Focus();
        }

        private void EncodeLabel_MouseDown(object sender, MouseEventArgs e)
        {
            Clipboard.SetText(EncodeLabel.Text);
        }

        private void EncodeSubStitution_MouseDown(object sender, MouseEventArgs e)
        {
            Clipboard.SetText(EncodeSubStitution.Text);
        }
        private void EncodeWithTranspositionLabel_MouseDown(object sender, MouseEventArgs e)
        {
            Clipboard.SetText(EncodeWithTranspositionLabel.Text);
        }

        #endregion

        private string Encoding(string text, int key)
        {
            var withKey = EncodeWithKey(text, key);
            EncodeLabel.Text = withKey;
            EncodeLabel.Visible = true;
            if (UseForEncodeSubStitution.Checked)
            {
                withKey = EncodeWithSubStitution(withKey);
                EncodeSubStitution.Text = withKey;
                EncodeSubStitution.Visible = true;
            }
            if (TranspositionCheckBox.Checked)
            {
                withKey = EncodeWithTransposition(withKey, key);
                EncodeWithTranspositionLabel.Text = withKey;
                EncodeWithTranspositionLabel.Visible = true;
            }
            return withKey;

        }
        private string Decode(string text, int key)
        {
            var plain = "";
            if (UseForDecodeTransposition.Checked)
            {
                plain = DecodeWithTransposition(text, key);
            }
            if (UseForDecodeSubStitution.Checked)
            {
                var withSubStitution = DecodeWithSubStitution(plain == "" ? text : plain);
                plain = withSubStitution;
            }
            var withKey = DecodeWithKey(plain == "" ? text : plain, key);
            DecodeKey.Text = withKey;
            DecodeKey.Visible = true;
            return withKey;
        }

    }
}
