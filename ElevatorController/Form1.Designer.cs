namespace ElevatorControl
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            timer_lift_down = new System.Windows.Forms.Timer(components);
            timer_lift_up = new System.Windows.Forms.Timer(components);
            timer_door_open_down = new System.Windows.Forms.Timer(components);
            timer_door_close_down = new System.Windows.Forms.Timer(components);
            timer_door_open_up = new System.Windows.Forms.Timer(components);
            timer_door_close_up = new System.Windows.Forms.Timer(components);
            btn_clearlog = new Button();
            groupBox2 = new GroupBox();
            display_panel = new PictureBox();
            control_panel = new PictureBox();
            bell_button = new Button();
            door_open_btn = new Button();
            door_close_btn = new Button();
            ground_floor_btn = new Button();
            first_floor_btn = new Button();
            eventslog_box = new GroupBox();
            dataGridView1 = new DataGridView();
            elevatorEventsLogBindingSource = new BindingSource(components);
            lift_frame = new PictureBox();
            display_top = new PictureBox();
            display_bottom = new PictureBox();
            door_right_down = new PictureBox();
            door_left_down = new PictureBox();
            call_up = new Button();
            call_down = new Button();
            panel1 = new Panel();
            door_left_up = new PictureBox();
            door_right_up = new PictureBox();
            picture_lift = new PictureBox();
            concrete = new PictureBox();
            timer_auto_door_close = new System.Windows.Forms.Timer(components);
            btn_exit = new Button();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)display_panel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)control_panel).BeginInit();
            eventslog_box.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)elevatorEventsLogBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lift_frame).BeginInit();
            ((System.ComponentModel.ISupportInitialize)display_top).BeginInit();
            ((System.ComponentModel.ISupportInitialize)display_bottom).BeginInit();
            ((System.ComponentModel.ISupportInitialize)door_right_down).BeginInit();
            ((System.ComponentModel.ISupportInitialize)door_left_down).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)door_left_up).BeginInit();
            ((System.ComponentModel.ISupportInitialize)door_right_up).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picture_lift).BeginInit();
            ((System.ComponentModel.ISupportInitialize)concrete).BeginInit();
            SuspendLayout();
            // 
            // timer_lift_down
            // 
            timer_lift_down.Interval = 15;
            timer_lift_down.Tick += timer_lift_down_Tick;
            // 
            // timer_lift_up
            // 
            timer_lift_up.Interval = 15;
            timer_lift_up.Tick += timer_lift_up_Tick;
            // 
            // timer_door_open_down
            // 
            timer_door_open_down.Interval = 200;
            timer_door_open_down.Tick += timer_door_open_down_Tick;
            // 
            // timer_door_close_down
            // 
            timer_door_close_down.Interval = 150;
            timer_door_close_down.Tick += timer_door_close_down_Tick;
            // 
            // timer_door_open_up
            // 
            timer_door_open_up.Interval = 200;
            timer_door_open_up.Tick += timer_door_open_up_Tick;
            // 
            // timer_door_close_up
            // 
            timer_door_close_up.Interval = 200;
            timer_door_close_up.Tick += timer_door_close_up_Tick;
            // 
            // btn_clearlog
            // 
            btn_clearlog.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_clearlog.Location = new Point(956, 81);
            btn_clearlog.Margin = new Padding(4, 5, 4, 5);
            btn_clearlog.Name = "btn_clearlog";
            btn_clearlog.Size = new Size(179, 64);
            btn_clearlog.TabIndex = 21;
            btn_clearlog.Text = "Clear Log";
            btn_clearlog.UseVisualStyleBackColor = true;
            btn_clearlog.Click += btn_clearlog_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ControlDark;
            groupBox2.Controls.Add(display_panel);
            groupBox2.Controls.Add(control_panel);
            groupBox2.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            groupBox2.Location = new Point(1145, 49);
            groupBox2.Margin = new Padding(4, 5, 4, 5);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 5, 4, 5);
            groupBox2.Size = new Size(236, 778);
            groupBox2.TabIndex = 28;
            groupBox2.TabStop = false;
            groupBox2.Text = "Elevator Controller";
            // 
            // display_panel
            // 
            display_panel.BackColor = Color.Black;
            display_panel.BackgroundImage = (Image)resources.GetObject("display_panel.BackgroundImage");
            display_panel.Location = new Point(79, 89);
            display_panel.Margin = new Padding(4, 5, 4, 5);
            display_panel.Name = "display_panel";
            display_panel.Size = new Size(84, 90);
            display_panel.SizeMode = PictureBoxSizeMode.StretchImage;
            display_panel.TabIndex = 10;
            display_panel.TabStop = false;
            // 
            // control_panel
            // 
            control_panel.Image = (Image)resources.GetObject("control_panel.Image");
            control_panel.Location = new Point(12, 44);
            control_panel.Margin = new Padding(4, 5, 4, 5);
            control_panel.Name = "control_panel";
            control_panel.Size = new Size(214, 699);
            control_panel.SizeMode = PictureBoxSizeMode.StretchImage;
            control_panel.TabIndex = 4;
            control_panel.TabStop = false;
            // 
            // bell_button
            // 
            bell_button.BackgroundImage = (Image)resources.GetObject("bell_button.BackgroundImage");
            bell_button.BackgroundImageLayout = ImageLayout.Zoom;
            bell_button.Location = new Point(1223, 659);
            bell_button.Margin = new Padding(4, 5, 4, 5);
            bell_button.Name = "bell_button";
            bell_button.Size = new Size(80, 85);
            bell_button.TabIndex = 15;
            bell_button.UseVisualStyleBackColor = true;
            bell_button.Click += bell_button_Click;
            // 
            // door_open_btn
            // 
            door_open_btn.BackColor = Color.White;
            door_open_btn.BackgroundImage = (Image)resources.GetObject("door_open_btn.BackgroundImage");
            door_open_btn.BackgroundImageLayout = ImageLayout.Zoom;
            door_open_btn.Location = new Point(1272, 526);
            door_open_btn.Margin = new Padding(4, 5, 4, 5);
            door_open_btn.Name = "door_open_btn";
            door_open_btn.Size = new Size(80, 85);
            door_open_btn.TabIndex = 14;
            door_open_btn.UseVisualStyleBackColor = false;
            door_open_btn.Click += door_open_btn_Click;
            // 
            // door_close_btn
            // 
            door_close_btn.BackColor = Color.White;
            door_close_btn.BackgroundImage = (Image)resources.GetObject("door_close_btn.BackgroundImage");
            door_close_btn.BackgroundImageLayout = ImageLayout.Zoom;
            door_close_btn.Location = new Point(1178, 526);
            door_close_btn.Margin = new Padding(4, 5, 4, 5);
            door_close_btn.Name = "door_close_btn";
            door_close_btn.Size = new Size(80, 85);
            door_close_btn.TabIndex = 13;
            door_close_btn.UseVisualStyleBackColor = false;
            door_close_btn.Click += door_close_btn_Click;
            // 
            // ground_floor_btn
            // 
            ground_floor_btn.BackColor = Color.White;
            ground_floor_btn.BackgroundImage = (Image)resources.GetObject("ground_floor_btn.BackgroundImage");
            ground_floor_btn.BackgroundImageLayout = ImageLayout.Zoom;
            ground_floor_btn.Location = new Point(1225, 396);
            ground_floor_btn.Margin = new Padding(4, 5, 4, 5);
            ground_floor_btn.Name = "ground_floor_btn";
            ground_floor_btn.Size = new Size(80, 85);
            ground_floor_btn.TabIndex = 12;
            ground_floor_btn.UseVisualStyleBackColor = false;
            ground_floor_btn.Click += ground_floor_btn_Click;
            // 
            // first_floor_btn
            // 
            first_floor_btn.BackColor = Color.White;
            first_floor_btn.BackgroundImage = (Image)resources.GetObject("first_floor_btn.BackgroundImage");
            first_floor_btn.BackgroundImageLayout = ImageLayout.Zoom;
            first_floor_btn.Location = new Point(1225, 271);
            first_floor_btn.Margin = new Padding(4, 5, 4, 5);
            first_floor_btn.Name = "first_floor_btn";
            first_floor_btn.Size = new Size(80, 85);
            first_floor_btn.TabIndex = 11;
            first_floor_btn.UseVisualStyleBackColor = false;
            first_floor_btn.Click += first_floor_btn_Click;
            // 
            // eventslog_box
            // 
            eventslog_box.Controls.Add(dataGridView1);
            eventslog_box.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            eventslog_box.Location = new Point(13, 14);
            eventslog_box.Margin = new Padding(4, 5, 4, 5);
            eventslog_box.Name = "eventslog_box";
            eventslog_box.Padding = new Padding(4, 5, 4, 5);
            eventslog_box.Size = new Size(920, 978);
            eventslog_box.TabIndex = 27;
            eventslog_box.TabStop = false;
            eventslog_box.Text = "Elevator Events Log";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(15, 35);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 24;
            dataGridView1.Size = new Size(880, 921);
            dataGridView1.TabIndex = 27;
            // 
            // elevatorEventsLogBindingSource
            // 
            elevatorEventsLogBindingSource.DataMember = "ElevatorEventsLog";
            // 
            // lift_frame
            // 
            lift_frame.BackColor = Color.Transparent;
            lift_frame.Image = (Image)resources.GetObject("lift_frame.Image");
            lift_frame.Location = new Point(1393, 0);
            lift_frame.Margin = new Padding(4, 5, 4, 5);
            lift_frame.Name = "lift_frame";
            lift_frame.Size = new Size(530, 992);
            lift_frame.SizeMode = PictureBoxSizeMode.StretchImage;
            lift_frame.TabIndex = 0;
            lift_frame.TabStop = false;
            // 
            // display_top
            // 
            display_top.BackColor = Color.Black;
            display_top.BackgroundImage = (Image)resources.GetObject("display_top.BackgroundImage");
            display_top.Location = new Point(1619, 32);
            display_top.Margin = new Padding(4, 5, 4, 5);
            display_top.Name = "display_top";
            display_top.Size = new Size(89, 52);
            display_top.SizeMode = PictureBoxSizeMode.StretchImage;
            display_top.TabIndex = 8;
            display_top.TabStop = false;
            // 
            // display_bottom
            // 
            display_bottom.BackColor = Color.Transparent;
            display_bottom.BackgroundImage = (Image)resources.GetObject("display_bottom.BackgroundImage");
            display_bottom.Location = new Point(1619, 536);
            display_bottom.Margin = new Padding(4, 5, 4, 5);
            display_bottom.Name = "display_bottom";
            display_bottom.Size = new Size(89, 49);
            display_bottom.SizeMode = PictureBoxSizeMode.StretchImage;
            display_bottom.TabIndex = 9;
            display_bottom.TabStop = false;
            // 
            // door_right_down
            // 
            door_right_down.Image = (Image)resources.GetObject("door_right_down.Image");
            door_right_down.Location = new Point(99, 499);
            door_right_down.Margin = new Padding(4, 5, 4, 5);
            door_right_down.Name = "door_right_down";
            door_right_down.Size = new Size(100, 294);
            door_right_down.SizeMode = PictureBoxSizeMode.StretchImage;
            door_right_down.TabIndex = 17;
            door_right_down.TabStop = false;
            // 
            // door_left_down
            // 
            door_left_down.BackColor = SystemColors.Control;
            door_left_down.Image = (Image)resources.GetObject("door_left_down.Image");
            door_left_down.Location = new Point(-1, 499);
            door_left_down.Margin = new Padding(4, 5, 4, 5);
            door_left_down.Name = "door_left_down";
            door_left_down.Size = new Size(100, 294);
            door_left_down.SizeMode = PictureBoxSizeMode.StretchImage;
            door_left_down.TabIndex = 16;
            door_left_down.TabStop = false;
            // 
            // call_up
            // 
            call_up.BackColor = Color.Transparent;
            call_up.BackgroundImage = ElevatorController.Properties.Resources.call_down;
            call_up.BackgroundImageLayout = ImageLayout.Zoom;
            call_up.Location = new Point(1844, 200);
            call_up.Margin = new Padding(4, 5, 4, 5);
            call_up.Name = "call_up";
            call_up.Size = new Size(60, 65);
            call_up.TabIndex = 29;
            call_up.UseVisualStyleBackColor = false;
            call_up.Click += call_up_Click;
            // 
            // call_down
            // 
            call_down.BackColor = Color.Transparent;
            call_down.BackgroundImage = ElevatorController.Properties.Resources.call_up;
            call_down.BackgroundImageLayout = ImageLayout.Zoom;
            call_down.Location = new Point(1844, 701);
            call_down.Margin = new Padding(4, 5, 4, 5);
            call_down.Name = "call_down";
            call_down.Size = new Size(60, 65);
            call_down.TabIndex = 30;
            call_down.UseVisualStyleBackColor = false;
            call_down.Click += call_down_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(door_left_down);
            panel1.Controls.Add(door_left_up);
            panel1.Controls.Add(door_right_down);
            panel1.Controls.Add(door_right_up);
            panel1.Controls.Add(picture_lift);
            panel1.Location = new Point(1565, 120);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(199, 793);
            panel1.TabIndex = 31;
            // 
            // door_left_up
            // 
            door_left_up.BackColor = SystemColors.Control;
            door_left_up.Image = (Image)resources.GetObject("door_left_up.Image");
            door_left_up.Location = new Point(-1, -1);
            door_left_up.Margin = new Padding(4, 5, 4, 5);
            door_left_up.Name = "door_left_up";
            door_left_up.Size = new Size(100, 291);
            door_left_up.SizeMode = PictureBoxSizeMode.StretchImage;
            door_left_up.TabIndex = 18;
            door_left_up.TabStop = false;
            // 
            // door_right_up
            // 
            door_right_up.Image = (Image)resources.GetObject("door_right_up.Image");
            door_right_up.Location = new Point(99, -1);
            door_right_up.Margin = new Padding(4, 5, 4, 5);
            door_right_up.Name = "door_right_up";
            door_right_up.Size = new Size(100, 291);
            door_right_up.SizeMode = PictureBoxSizeMode.StretchImage;
            door_right_up.TabIndex = 19;
            door_right_up.TabStop = false;
            // 
            // picture_lift
            // 
            picture_lift.BackColor = Color.Transparent;
            picture_lift.Image = (Image)resources.GetObject("picture_lift.Image");
            picture_lift.Location = new Point(0, 0);
            picture_lift.Margin = new Padding(4, 5, 4, 5);
            picture_lift.Name = "picture_lift";
            picture_lift.Size = new Size(199, 290);
            picture_lift.SizeMode = PictureBoxSizeMode.StretchImage;
            picture_lift.TabIndex = 3;
            picture_lift.TabStop = false;
            // 
            // concrete
            // 
            concrete.Image = (Image)resources.GetObject("concrete.Image");
            concrete.Location = new Point(1393, 405);
            concrete.Margin = new Padding(4, 5, 4, 5);
            concrete.Name = "concrete";
            concrete.Size = new Size(530, 215);
            concrete.SizeMode = PictureBoxSizeMode.StretchImage;
            concrete.TabIndex = 2;
            concrete.TabStop = false;
            // 
            // timer_auto_door_close
            // 
            timer_auto_door_close.Interval = 5;
            timer_auto_door_close.Tick += timer_auto_door_close_Tick;
            // 
            // btn_exit
            // 
            btn_exit.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_exit.Location = new Point(956, 180);
            btn_exit.Margin = new Padding(4, 5, 4, 5);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(179, 64);
            btn_exit.TabIndex = 32;
            btn_exit.Text = "Exit";
            btn_exit.UseVisualStyleBackColor = true;
            btn_exit.Click += btn_exit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(1924, 1009);
            Controls.Add(btn_exit);
            Controls.Add(call_down);
            Controls.Add(display_bottom);
            Controls.Add(concrete);
            Controls.Add(panel1);
            Controls.Add(call_up);
            Controls.Add(display_top);
            Controls.Add(btn_clearlog);
            Controls.Add(lift_frame);
            Controls.Add(bell_button);
            Controls.Add(door_open_btn);
            Controls.Add(door_close_btn);
            Controls.Add(ground_floor_btn);
            Controls.Add(first_floor_btn);
            Controls.Add(eventslog_box);
            Controls.Add(groupBox2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Elevator Control ";
            WindowState = FormWindowState.Maximized;
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)display_panel).EndInit();
            ((System.ComponentModel.ISupportInitialize)control_panel).EndInit();
            eventslog_box.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)elevatorEventsLogBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)lift_frame).EndInit();
            ((System.ComponentModel.ISupportInitialize)display_top).EndInit();
            ((System.ComponentModel.ISupportInitialize)display_bottom).EndInit();
            ((System.ComponentModel.ISupportInitialize)door_right_down).EndInit();
            ((System.ComponentModel.ISupportInitialize)door_left_down).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)door_left_up).EndInit();
            ((System.ComponentModel.ISupportInitialize)door_right_up).EndInit();
            ((System.ComponentModel.ISupportInitialize)picture_lift).EndInit();
            ((System.ComponentModel.ISupportInitialize)concrete).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Timer timer_lift_down;
        private PictureBox control_panel;
        private System.Windows.Forms.Timer timer_lift_up;
        private Button first_floor_btn;
        private Button ground_floor_btn;
        private Button door_close_btn;
        private Button door_open_btn;
        private Button bell_button;
        private System.Windows.Forms.Timer timer_door_open_down;
        private System.Windows.Forms.Timer timer_door_close_down;
        private System.Windows.Forms.Timer timer_door_open_up;
        private System.Windows.Forms.Timer timer_door_close_up;
        private Button btn_clearlog;
        private GroupBox groupBox2;
        private GroupBox eventslog_box;
        private PictureBox lift_frame;
        private PictureBox display_top;
        private PictureBox display_bottom;
        private PictureBox door_right_down;
        private PictureBox door_left_down;
        private Button call_up;
        private Button call_down;
        private PictureBox display_panel;
        private Panel panel1;
        private PictureBox picture_lift;
        private PictureBox door_right_up;
        private PictureBox door_left_up;
        private PictureBox concrete;
        private System.Windows.Forms.Timer timer_auto_door_close;
        private BindingSource elevatorEventsLogBindingSource;
        private Button btn_exit;
        private DataGridView dataGridView1;
    }
}