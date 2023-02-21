using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace combo_box_differentiate_user_input
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            comboBox.Items.AddRange(
                new object[] 
                { 
                    Color.Red, 
                    Color.Green, 
                    Color.Blue, 
                });
            comboBox.SelectedIndex = 0;

            // Programmatically change CB
            numericUpDown.Maximum = 2;
            numericUpDown.ValueChanged += (sender, e) => 
                comboBox.SelectedIndex = (int)numericUpDown.Value;

            comboBox.SelectionChangeCommitted += (sender, e) =>
            {
                _isUserChange= true;
            };

            comboBox.SelectedIndexChanged += (sender, e) =>
            {
                string msg = _isUserChange ? "USER CHANGE" : "PGM CHANGE";

                richTextBox.SelectionColor = (Color)comboBox.SelectedItem;
                richTextBox.AppendText($"{msg}{Environment.NewLine}");

                numericUpDown.Value = (int)comboBox.SelectedIndex;
                _isUserChange= false;
            };
        }
        bool _isUserChange = false;
    }
}
