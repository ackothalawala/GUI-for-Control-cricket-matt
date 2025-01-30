using System;
using System.Windows.Forms;
using System.IO.Ports;

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
            SerialPort1 = new SerialPort("COM7"); // Initialize with appropriate port name
            SerialPort1.Open();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            String[] ports = SerialPort.GetPortNames();
            cBoxPort.Items.AddRange(ports);
            // Send initial commands to set servo positions
            SerialPort1.WriteLine("F90\n");
            SerialPort1.WriteLine("L90\n");
        }

        private void FB_Scroll(object sender, EventArgs e)
        {
            int sliderValue = FB.Value;
            textBoxFB.Text = sliderValue.ToString(); // Update textbox
            SerialPort1.Write($"F{sliderValue}\n");
        }

        private void LR_Scroll(object sender, EventArgs e)
        {
            int sliderValue = LR.Value;
            textBoxLR.Text = sliderValue.ToString(); // Update textbox
            SerialPort1.Write($"L{sliderValue}\n");
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            SerialPort1.WriteLine("R\n");

            // Reset the trackbars to their initial positions
            FB.Value = 90;
            LR.Value = 90;

            // Update textboxes
            textBoxFB.Text = "90";
            textBoxLR.Text = "90";
        }

        private void ServoAngleFB_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxFB.Text, out int value) && value >= 0 && value <= 180)
            {
                FB.Value = value; // Sync trackbar with textbox
                SerialPort1.Write($"F{value}\n");
            }
        }

        private void ServoAngleLR_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxLR.Text, out int value) && value >= 0 && value <= 180)
            {
                LR.Value = value; // Sync trackbar with textbox
                SerialPort1.Write($"L{value}\n");
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (SerialPort1.IsOpen)
            {
                SerialPort1.Close(); // Ensure the serial port is closed when the form closes
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
    }
}
