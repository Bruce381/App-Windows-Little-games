// ********************************************************************
// Project: First exam
// Author: (WANG YONGJI) Bruce
// Date Created: 2024-11-14
// Description: A Windows Forms application to manage student data.
// License: MIT License
// ********************************************************************




using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;

namespace School_APP
{
    public partial class Data : Form
    {
        // Create three lists
        List<string> names = new List<string>();       // Store names
        List<string> classes = new List<string>();     // Store class information
        List<string> result = new List<string>();      // Store results

        public Data(string username)
        {
            InitializeComponent();
            show_user.Text = $"Hello {char.ToUpper(username[0]) + username.Substring(1)}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Check if any text box is empty
            if (string.IsNullOrWhiteSpace(textBox_name.Text) ||
                string.IsNullOrWhiteSpace(comboBox_class.Text) ||
                string.IsNullOrWhiteSpace(textBox_resalt.Text))
            {
                // Display error message
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // If there are empty fields, stop execution
            }

            // Check if the score is a valid number and doesn't exceed 100
            if (double.TryParse(textBox_resalt.Text, out double score))
            {
                if (score < 0 || score > 100)
                {
                    MessageBox.Show("Please enter a valid score between 0 and 100.", "Invalid Score", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid number for the score.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Add new data
            names.Add(textBox_name.Text);
            classes.Add(comboBox_class.Text);
            result.Add(textBox_resalt.Text);

            // Refresh the list display
            fresh_list();

            // Clear input fields
            textBox_name.Text = string.Empty;
            textBox_resalt.Text = string.Empty;

            // Focus on the name input field
            textBox_name.Focus();
        }

        private void fresh_list()
        {
            // Clear the existing ListBox items
            show_data_name.Items.Clear();
            show_data_class.Items.Clear();
            show_data_result.Items.Clear();

            // Add the data to the corresponding ListBox controls
            foreach (var name in names)
            {
                show_data_name.Items.Add(name);
            }

            foreach (var classNumber in classes)
            {
                show_data_class.Items.Add(classNumber.ToString());
            }

            foreach (var resultValue in result)
            {
                show_data_result.Items.Add(resultValue);
            }
        }

        private void Data_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void set_Click(object sender, EventArgs e)
        {
            // Get the current selected item from ComboBox
            var selectedItem = choose_type.SelectedItem.ToString();

            // Use if statement to determine the selected item
            if (selectedItem == "Scores from low to high")
            {
                // Combine the three lists into a tuple list
                var combinedList = names
                    .Select((name, index) => (name: name, classNumber: classes[index], result: result[index]))
                    .ToList();

                // Sort by score from low to high
                var sortedListAsc = combinedList
                    .OrderBy(item => double.Parse(item.result))  // Convert score from string to number and sort in ascending order
                    .ToList();

                // Update ListBox
                UpdateListBox(sortedListAsc);
            }
            else if (selectedItem == "Scores from high to low")
            {
                // Combine the three lists into a tuple list
                var combinedList = names
                    .Select((name, index) => (name: name, classNumber: classes[index], result: result[index]))
                    .ToList();

                // Sort by score from high to low
                var sortedListDesc = combinedList
                    .OrderByDescending(item => double.Parse(item.result))  // Sort in descending order
                    .ToList();

                // Update ListBox
                UpdateListBox(sortedListDesc);
            }
        }

        private void UpdateListBox(List<(string name, string classes, string result)> sortedList)
        {
            // Clear the existing ListBox items
            show_data_name.Items.Clear();
            show_data_class.Items.Clear();
            show_data_result.Items.Clear();

            // Update the sorted data into ListBox
            foreach (var item in sortedList)
            {
                show_data_name.Items.Add(item.name);
                show_data_class.Items.Add(item.classes);
                show_data_result.Items.Add(item.result);
            }
        }

        private void statistics_Click(object sender, EventArgs e)
        {
            // Check if the result list is empty
            if (result.Count == 0)
            {
                MessageBox.Show("No data available.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Exit the method early if there's no data
            }

            // Convert result list from string to double
            List<double> scores = result.Select(double.Parse).ToList();

            // Calculate statistical information
            double maxScore = scores.Max();
            double minScore = scores.Min();
            double averageScore = scores.Average();
            double sumScore = scores.Sum();
            double aboveAveragePercentage = (double)scores.Count(score => score > averageScore) / scores.Count * 100;
            double belowAveragePercentage = (double)scores.Count(score => score < averageScore) / scores.Count * 100;

            // Build the message content
            string message = $"1) Maximum score: {maxScore:F2}\n" +
                             $"2) Minimum score: {minScore:F2}\n" +
                             $"3) Average score: {averageScore:F2}\n" +
                             $"4) Total score: {sumScore}\n" +
                             $"5) Percentage of students above average: {aboveAveragePercentage:F2}%\n" +
                             $"6) Percentage of students below average: {belowAveragePercentage:F2}%";

            // Display the message box
            MessageBox.Show(message, "Statistics", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void textBox_resalt_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the input character is a number, control key, or decimal point
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true; // Prevent non-numeric or decimal input
            }

            // If there is already a decimal point, prevent entering another one
            if (e.KeyChar == '.' && textBox_resalt.Text.Contains("."))
            {
                e.Handled = true; // Prevent entering a second decimal point
            }

            // If the input text length is 5 characters (maximum of three digits and two decimals), prevent further input
            if (textBox_resalt.Text.Length >= 5 && !char.IsControl(e.KeyChar)) // Allow two decimal places and one decimal point
            {
                e.Handled = true;  // Prevent input
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            // Pop up a confirmation dialog for exiting
            DialogResult result = MessageBox.Show("Are you sure to exit?", "Yes", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // If the user selects "Yes", exit the application
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                return;
            }
        }

        // Use OnPaintBackground to draw the background
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);

            // Get the size of the form
            int width = this.ClientSize.Width;
            int height = this.ClientSize.Height;

            // Fixed gradient colors
            Color color1 = Color.FromArgb(0, 128, 255); // For example: blue
            Color color2 = Color.FromArgb(255, 0, 0);    // Red color

            // Create a linear gradient brush
            using (LinearGradientBrush brush = new LinearGradientBrush(
                new Rectangle(0, 0, width, height),
                color1,
                color2,
                LinearGradientMode.Vertical)) // Gradient direction
            {
                // Fill the entire form background with the gradient
                e.Graphics.FillRectangle(brush, 0, 0, width, height);
            }
        }

        private void Data_Load(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;  // Enable double buffering to reduce flickering
            choose_type.SelectedIndex = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label_show_time.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }
    }
}
