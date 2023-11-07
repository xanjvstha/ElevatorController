using ElevatorController;
using System.ComponentModel;
using System.Data;

namespace ElevatorControl
{
    enum ElevatorState
    {
        MovingUp, MovingDown, Stopped, Idle, ClosingDoors, BellButtonPressed
    }

    public partial class Form1 : Form
    {
        //variables
        int lift_up = 1;
        int lift_down = 500;

        bool lift_go_up = false;
        bool lift_go_down = false;

        bool display_G = false;
        bool display_1 = false;

        private BackgroundWorker elevatorWorker;
        private BackgroundWorker doorOpenWorker;
        private BackgroundWorker doorCloseWorker;

        private static ElevatorState currentState = ElevatorState.Stopped;
        private ElevatorState currentElevatorState = ElevatorState.Idle;

        private DatabaseCommand dc = new DatabaseCommand();

        private int increment = 0;
        public Form1()
        {
            InitializeComponent();

            // Initialize BackgroundWorkers
            elevatorWorker = new BackgroundWorker();
            doorOpenWorker = new BackgroundWorker();
            doorCloseWorker = new BackgroundWorker();
        }

        static int i = 1;
        static int j = 1;

        private void elevatorWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (e.ProgressPercentage == 1)
            {
                // Perform actions when the elevator stops moving down.
                // This includes disabling/enabling buttons, changing colors, and updating images.
                timer_lift_down.Enabled = false;
                call_up.Enabled = true;
                first_floor_btn.Enabled = true;
                door_close_btn.Enabled = true;
                door_open_btn.Enabled = true;
                call_down.BackColor = Color.White;
                ground_floor_btn.BackColor = Color.White;
                door_open_down();
                display_G = true;

                picture_lift.Image = ElevatorController.Properties.Resources.inner_lift;
                display_panel.Image = ElevatorController.Properties.Resources.display_G;
                display_top.Image = ElevatorController.Properties.Resources.display_G;
                display_bottom.Image = ElevatorController.Properties.Resources.display_G;
            }
        }

        private void timer_lift_down_Tick(object sender, EventArgs e)
        {
            switch (currentState)
            {
                case ElevatorState.MovingDown:
                    if (picture_lift.Top <= lift_down)
                    {
                        picture_lift.Top += 1;
                    }
                    else
                    {
                        currentState = ElevatorState.Stopped;
                        // Perform actions when the elevator stops moving down.
                        // This includes disabling/enabling buttons, changing colors, and updating images.

                        timer_lift_down.Enabled = false;
                        call_up.Enabled = true;
                        first_floor_btn.Enabled = true;
                        door_close_btn.Enabled = true;
                        door_open_btn.Enabled = true;
                        call_down.BackColor = Color.White;
                        ground_floor_btn.BackColor = Color.White;
                        door_open_down();
                        display_G = true;

                        picture_lift.Image = ElevatorController.Properties.Resources.inner_lift;
                        display_panel.Image = ElevatorController.Properties.Resources.display_G;
                        display_top.Image = ElevatorController.Properties.Resources.display_G;
                        display_bottom.Image = ElevatorController.Properties.Resources.display_G;
                    }
                    break;

                default:
                    // Handle unexpected or undefined states.
                    break;
            }
        }

        private void timer_lift_up_Tick(object sender, EventArgs e)
        {
            switch (currentState)
            {
                case ElevatorState.MovingUp:
                    if (picture_lift.Top >= lift_up)
                    {
                        picture_lift.Top -= 1;
                    }
                    else
                    {
                        currentState = ElevatorState.Stopped;
                        // Perform actions when the elevator stops moving up.
                        // This includes disabling/enabling buttons, changing colors, and updating images.

                        timer_lift_up.Enabled = false;
                        call_down.Enabled = true;
                        ground_floor_btn.Enabled = true;
                        door_close_btn.Enabled = true;
                        door_open_btn.Enabled = true;
                        call_up.BackColor = Color.White;
                        first_floor_btn.BackColor = Color.White;
                        door_open_up();
                        display_1 = true;

                        picture_lift.Image = ElevatorController.Properties.Resources.inner_lift;
                        display_panel.Image = ElevatorController.Properties.Resources.display_1;
                        display_top.Image = ElevatorController.Properties.Resources.display_1;
                        display_bottom.Image = ElevatorController.Properties.Resources.display_1;
                    }
                    break;

                default:
                    // Handle unexpected or undefined states.
                    break;
            }
        }

        private void timer_door_open_down_Tick(object sender, EventArgs e)
        {
            increment = 0;
            if (i < 13)
            {
                door_left_down.Left -= i;
                door_right_down.Left += i;
                i++;
            }
            else
            {
                timer_auto_door_close.Enabled = true;
                timer_door_open_down.Enabled = false;

                call_up.Enabled = true;
                call_down.Enabled = true;
            }
        }

        private void timer_door_close_down_Tick(object sender, EventArgs e)
        {
            if (i > 1)
            {
                i--;
                door_left_down.Left += i;
                door_right_down.Left -= i;
            }
            else
            {
                increment = 0;
                timer_auto_door_close.Enabled = false;
                timer_door_close_down.Enabled = false;

                if (lift_go_up == true)
                {
                    picture_lift.Image = ElevatorController.Properties.Resources.lift_transparent;

                    display_panel.Image = ElevatorController.Properties.Resources.up;
                    display_top.Image = ElevatorController.Properties.Resources.up;
                    display_bottom.Image = ElevatorController.Properties.Resources.up;

                    timer_lift_up.Enabled = true;
                    lift_go_up = false;
                }
            }
        }

        private void timer_door_open_up_Tick(object sender, EventArgs e)
        {
            if (j < 13)
            {
                door_left_up.Left -= j;
                door_right_up.Left += j;
                j++;
            }
            else
            {
                timer_auto_door_close.Enabled = true;
                timer_door_open_up.Enabled = false;

                call_down.Enabled = true;
            }
        }

        private void timer_door_close_up_Tick(object sender, EventArgs e)
        {
            if (j > 1)
            {
                j--;
                door_left_up.Left += j;
                door_right_up.Left -= j;
                Console.WriteLine(j);
            }
            else
            {
                timer_auto_door_close.Enabled = false;
                increment = 0;

                timer_door_close_up.Enabled = false;

                if (lift_go_down == true)
                {
                    timer_auto_door_close.Enabled = false;
                    increment = 0;

                    timer_door_close_up.Enabled = false;

                    picture_lift.Image = ElevatorController.Properties.Resources.lift_transparent;
                    display_panel.Image = ElevatorController.Properties.Resources.down;
                    display_top.Image = ElevatorController.Properties.Resources.down;
                    display_bottom.Image = ElevatorController.Properties.Resources.down;

                    timer_lift_down.Enabled = true;
                    lift_go_down = false;
                }
            }
        }

        private void door_close_down()
        {
            timer_door_close_down.Enabled = true;
            timer_door_open_down.Enabled = false;
        }

        private void door_open_down()
        {
            timer_door_close_down.Enabled = false;
            timer_door_open_down.Enabled = true;

            DateTime currentDateTime = DateTime.Now;
            dc.InsertData("Ground Floor Lift Door Opening", currentDateTime);
            LoadData();

            if (!doorOpenWorker.IsBusy)
            {
                doorOpenWorker.RunWorkerAsync();
            }
        }

        private void door_close_up()
        {
            timer_door_close_up.Enabled = true;
            timer_door_open_up.Enabled = false;

            if (!doorCloseWorker.IsBusy)
            {
                doorCloseWorker.RunWorkerAsync();

            }
        }

        private void door_open_up()
        {
            timer_door_close_up.Enabled = false;
            timer_door_open_up.Enabled = true;

            DateTime currentDateTime = DateTime.Now;
            dc.InsertData("First Floor Lift Door Opening", currentDateTime);
            LoadData();
        }

        private void going_up()
        {
            lift_go_up = true;
            door_close_down();

            ground_floor_btn.Enabled = false;
            call_down.Enabled = false;
            door_close_btn.Enabled = false;
            door_open_btn.Enabled = false;
            display_G = false;
        }

        private void going_down()
        {
            lift_go_down = true;
            door_close_up();

            first_floor_btn.Enabled = false;
            call_up.Enabled = false;
            door_close_btn.Enabled = false;
            door_open_btn.Enabled = false;
            display_1 = false;
        }

        private void call_down_Click(object sender, EventArgs e)
        {
            call_down.BackColor = Color.Red;
            currentState = ElevatorState.MovingDown;
            going_down();

            DateTime currentDateTime = DateTime.Now;
            dc.InsertData("Lift Coming to Ground Floor", currentDateTime);
            LoadData();
            if (!elevatorWorker.IsBusy)
            {
                elevatorWorker.RunWorkerAsync();
            }
        }

        private void call_up_Click(object sender, EventArgs e)
        {
            call_up.BackColor = Color.Red;
            currentState = ElevatorState.MovingUp;
            going_up();

            DateTime currentDateTime = DateTime.Now;
            dc.InsertData("Lift Coming to First Floor", currentDateTime);
            LoadData();
        }

        private void first_floor_btn_Click(object sender, EventArgs e)
        {
            first_floor_btn.BackColor = Color.Red;
            currentState = ElevatorState.MovingUp;
            going_up();

            DateTime currentDateTime = DateTime.Now;
            dc.InsertData("Lift Going to First Floor", currentDateTime);
            LoadData();
        }

        private void ground_floor_btn_Click(object sender, EventArgs e)
        {
            ground_floor_btn.BackColor = Color.Red;
            currentState = ElevatorState.MovingDown;
            going_down();

            DateTime currentDateTime = DateTime.Now;
            dc.InsertData("Lift Going To Ground Floor", currentDateTime);
            LoadData();
        }

        private void door_close_btn_Click(object sender, EventArgs e)
        {
            if (display_G == true)
            {
                door_close_down();

                DateTime currentDateTime = DateTime.Now;
                dc.InsertData("Ground Floor Door Closing", currentDateTime);
                LoadData();
            }
            else if (display_1 == true)
            {
                door_close_up();
                DateTime currentDateTime = DateTime.Now;
                dc.InsertData("First Floor Door Closing", currentDateTime);
                LoadData();
            }
        }

        private void door_open_btn_Click(object sender, EventArgs e)
        {
            if (display_G == true)
            {
                timer_door_open_down.Enabled = true;
                timer_door_close_down.Enabled = false;

                DateTime currentDateTime = DateTime.Now;
                dc.InsertData("Ground Floor Door Opening", currentDateTime);
                LoadData();

                if (!doorOpenWorker.IsBusy)
                {
                    doorOpenWorker.RunWorkerAsync();
                }
            }
            else if (display_1 == true)
            {
                timer_door_close_up.Enabled = false;
                timer_door_open_up.Enabled = true;

                DateTime currentDateTime = DateTime.Now;
                dc.InsertData("First Floor Door Opening", currentDateTime);
                LoadData();
            }
        }

        private void bell_button_Click(object sender, EventArgs e)
        {
            switch (currentElevatorState)
            {
                case ElevatorState.Idle:
                    bell_button.BackColor = Color.Red;
                    timer_lift_down.Enabled = false;
                    timer_lift_up.Enabled = false;
                    timer_door_open_down.Enabled = true;
                    timer_door_open_up.Enabled = true;
                    currentElevatorState = ElevatorState.BellButtonPressed;
                    break;

                case ElevatorState.BellButtonPressed:
                    // Close both doors
                    timer_door_close_down.Enabled = true;
                    timer_door_close_up.Enabled = true;
                    currentElevatorState = ElevatorState.ClosingDoors;
                    bell_button.BackColor = Color.White;

                    // Insert message and update data
                    DateTime dateTime = DateTime.Now;
                    dc.InsertData("Emergency Lift Door Closing", dateTime);
                    LoadData();
                    
                    break;
                
                default:
                    // Handle unexpected or undefined states.
                    break;
            }

            display_panel.Image = ElevatorController.Properties.Resources.bell_button;
            display_top.Image = ElevatorController.Properties.Resources.bell_button;
            display_bottom.Image = ElevatorController.Properties.Resources.bell_button;

            DateTime currentDateTime = DateTime.Now;
            dc.InsertData("Emergency Lift Stopped", currentDateTime);
            LoadData();
        }

        private void timer_auto_door_close_Tick(object sender, EventArgs e)
        {
            increment++;

            if (increment >= 260 && display_G == true)
            {
                timer_door_close_down.Enabled = true;                              
            }
            else if (increment >= 260 && display_1 == true)
            {
                timer_door_close_up.Enabled = true;
            }
        }

        private void btn_clearlog_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null; // clears the data of datagrid view
            dataGridView1.Rows.Clear();
        }
        public void LoadData()
        {
            try
            {
                DataTable dt = dc.SelectData();
                dataGridView1.DataSource = dt; //import data in datagrid view
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Elevator Control");
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}