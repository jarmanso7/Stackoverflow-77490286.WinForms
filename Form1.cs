namespace Stackoverflow_77490286.WinForms
{
    public partial class Form1 : Form
    {
        bool serialPortIsOpen = true;

        int currentIndex = 0;

        string command = "";

        public Form1()
        {
            InitializeComponent();

            //Move the visual avatar to the starting position
            MoveAvatar(listBox1.Items[0].ToString());
        }

        private void MoveAvatar(string point)
        {
            var currentCoordinates = point.Split('.');
            var current_x = Convert.ToInt32(currentCoordinates[0]);
            var current_y = Convert.ToInt32(currentCoordinates[1]);
            btnAvatar.Location = new System.Drawing.Point(current_x, current_y);
        }

        private void btnSendData_Click(object sender, EventArgs e)
        {
            if (serialPortIsOpen && listBox1.Items.Count > 1)
            {
                currentIndex = 0; // Reset the index to start from the first item
                timer1.Interval = 750;  // in mili-second
                timer1.Start();

            }
            else
            {
                MessageBox.Show("Port Closed or Not Enough Data");
            }
        }

        private void btnCalculatePattern_Click(object sender, EventArgs e)
        {
            // The first item of the pattern is always (0,0)
            listBox2.Items.Add($"0.0");

            for (int i = 0; i < listBox1.Items.Count - 1; i++)
            {
                var currentCoordinates = listBox1.Items[i].ToString().Split('.');
                var current_x = Convert.ToInt32(currentCoordinates[0]);
                var current_y = Convert.ToInt32(currentCoordinates[1]);

                var nextCoordinates = listBox1.Items[i + 1].ToString().Split('.');
                var next_x = Convert.ToInt32(nextCoordinates[0]);
                var next_y = Convert.ToInt32(nextCoordinates[1]);

                var x = next_x - current_x;
                var y = next_y - current_y;

                listBox2.Items.Add($"{x}.{y}");
            }

            btnCalculatePattern.Enabled = false;
            btnSendData.Enabled = true;
        }
        private void UpdateCoordinates(string startingPoint)
        {
            // The startingPoint is the ending point of the last iteration
            listBox1.Items[0] = startingPoint;

            var startingPointSplit = startingPoint.Split(".");
            var startingPoint_x = Convert.ToInt32(startingPointSplit[0]);
            var startingPoint_y = Convert.ToInt32(startingPointSplit[1]);

            // Calculate the rest of the coordinates for this iteration from
            // the starting point and the pattern

            var x = startingPoint_x;
            var y = startingPoint_y;

            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                var pattern = listBox2.Items[i].ToString().Split('.');
                var pattern_x = Convert.ToInt32(pattern[0]);
                var pattern_y = Convert.ToInt32(pattern[1]);

                x += pattern_x;
                y += pattern_y;

                listBox1.Items[i] = $"{x}.{y}";
            }
        }

        private void SendDataToArduino()
        {
            // Send commands with the current state of Coordinates

            if (currentIndex < listBox1.Items.Count)
            {
                command = listBox1.Items[currentIndex].ToString();
                command = command.Replace(": ", ""); // Remove the colon
                command = command.Replace(",", ""); // Remove comma if needed

                //We move the visual avatar and print the coordinates to the console
                // to simulate the motor receiving the commands 
                // serialPort1.WriteLine(command);
                Console.WriteLine(command);
                MoveAvatar(command);

                textBox3.Text = command;

                currentIndex++; // Move to the next item

            }
            else
            {
                // Tüm veriler gönderildi, işlemi yeniden başlat
                currentIndex = 0;

                // Update the Coordinates in the listBox with the Pattern information
                // passing the last point of the current iteration
                // as the starting point of the next iteration.
                UpdateCoordinates(command);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            SendDataToArduino();
        }
    }
}