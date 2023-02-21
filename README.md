What has worked for me is to set a flag on the `SelectionChangeCommitted` event which is only fired when the change is cause by user input.

[![differentiate changes][1]][1]

***
**Example**

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


  [1]: https://i.stack.imgur.com/zRGXC.png