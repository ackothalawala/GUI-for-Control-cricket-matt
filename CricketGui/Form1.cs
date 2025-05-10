using System;
using System.Windows.Forms;
using System.IO.Ports;
using System.Windows.Forms.DataVisualization.Charting;

namespace CricketGui
{
    public partial class Form1 : Form
    {
        private SerialPort SerialPort1;

        public Form1()
        {
            InitializeComponent();
            FB.Value = 90; // Front-Back trackbar
            LR.Value = 90; // Left-Right trackbar
            textBoxFB.Text = "90"; // Initialize Front-Back textbox
            textBoxLR.Text = "90"; // Initialize Left-Right textbox
            SerialPort1 = new SerialPort(); // Initialize without specific port

            // Initialize Pie Chart
            InitializePieChart();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            String[] ports = SerialPort.GetPortNames();
            cBoxPort.Items.AddRange(ports);

            // Set default baud rate
            textBoxBaudRate.Text = "9600";
        }

        private void InitializePieChart()
        {
            chart1.Series.Clear();
            chart1.Titles.Clear();
            chart1.Titles.Add("Servo Movement Distribution");

            Series series = new Series
            {
                Name = "Directions",
                ChartType = SeriesChartType.Pie
            };

            series.Points.AddXY("Front", 25);
            series.Points.AddXY("Back", 25);
            series.Points.AddXY("Left", 25);
            series.Points.AddXY("Right", 25);

            chart1.Series.Add(series);
            SetPieChartColors();
            UpdatePieChart();  // Ensure the chart updates properly
        }

        private void UpdatePieChart()
        {
            int frontBackValue = FB.Value; // Trackbar value for Front-Back
            int leftRightValue = LR.Value; // Trackbar value for Left-Right

            double front = 90, back = 90, left = 90, right = 90;

            // Front-Back Calculation (Swapped Front and Back)
            back = 180 - frontBackValue;
            front = frontBackValue;

            // Left-Right Calculation (0-180 scale)
            left = 180 - leftRightValue;
            right = leftRightValue;

            // Update Pie Chart Values
            chart1.Series["Directions"].Points[0].SetValueY(front); // Front (now swapped)
            chart1.Series["Directions"].Points[1].SetValueY(back);  // Back (now swapped)
            chart1.Series["Directions"].Points[2].SetValueY(left);  // Left
            chart1.Series["Directions"].Points[3].SetValueY(right); // Right

            // Ensure colors are applied correctly
            SetPieChartColors();
        }


        private void SetPieChartColors()
        {
            chart1.Series["Directions"].Points[0].Color = System.Drawing.Color.Purple; // Front
            chart1.Series["Directions"].Points[1].Color = System.Drawing.Color.Orange; // Back
            chart1.Series["Directions"].Points[2].Color = System.Drawing.Color.Green;  // Left
            chart1.Series["Directions"].Points[3].Color = System.Drawing.Color.Blue;   // Right
        }

        private void FB_Scroll(object sender, EventArgs e)
        {
            int sliderValue = FB.Value;
            textBoxFB.Text = sliderValue.ToString(); // Update textbox
            if (SerialPort1.IsOpen)
            {
                SerialPort1.Write($"F{sliderValue}\n");
            }
            UpdatePieChart();
        }

        private void LR_Scroll(object sender, EventArgs e)
        {
            int sliderValue = LR.Value;
            textBoxLR.Text = sliderValue.ToString(); // Update textbox
            if (SerialPort1.IsOpen)
            {
                SerialPort1.Write($"L{sliderValue}\n");
            }
            UpdatePieChart();
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            FB.Value = 90;
            LR.Value = 90;
            textBoxFB.Text = "90";
            textBoxLR.Text = "90";

            if (SerialPort1.IsOpen)
            {
                SerialPort1.WriteLine("R\n");
            }

            UpdatePieChart();
        }

        private void ServoAngleFB_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxFB.Text, out int value) && value >= 0 && value <= 180)
            {
                FB.Value = value;
                if (SerialPort1.IsOpen)
                {
                    SerialPort1.Write($"F{value}\n");
                }
                UpdatePieChart();
            }
        }

        private void ServoAngleLR_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxLR.Text, out int value) && value >= 0 && value <= 180)
            {
                LR.Value = value;
                if (SerialPort1.IsOpen)
                {
                    SerialPort1.Write($"L{value}\n");
                }
                UpdatePieChart();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (SerialPort1.IsOpen)
            {
                SerialPort1.Close();
            }
        }

        private void textBoxLR_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxFB_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBoxBaudRate_TextChanged(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {
                    }

        private void ConnectButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (!SerialPort1.IsOpen)
                {
                    SerialPort1.PortName = cBoxPort.SelectedItem.ToString();
                    SerialPort1.BaudRate = int.Parse(textBoxBaudRate.Text);
                    SerialPort1.Open();
                    MessageBox.Show("Connection Opened", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Already Connected", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisconnectButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (SerialPort1.IsOpen)
                {
                    SerialPort1.Close();
                    MessageBox.Show("Connection Closed", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Port is not open", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Disconnection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
