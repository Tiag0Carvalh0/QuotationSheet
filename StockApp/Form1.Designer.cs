using System.Drawing.Drawing2D;

namespace StockApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel_MainMenu = new Panel();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            btn_NewOrder = new Button();
            label_AppName = new Label();
            picture_AppLogo = new PictureBox();
            panel_DisplayPage = new Panel();
            panel_UserProfile = new Panel();
            picture_StoreLogo = new PictureBox();
            label_StoreName = new Label();
            panel_MainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picture_AppLogo).BeginInit();
            panel_DisplayPage.SuspendLayout();
            panel_UserProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picture_StoreLogo).BeginInit();
            SuspendLayout();
            // 
            // panel_MainMenu
            // 
            panel_MainMenu.Controls.Add(button6);
            panel_MainMenu.Controls.Add(button5);
            panel_MainMenu.Controls.Add(button4);
            panel_MainMenu.Controls.Add(button3);
            panel_MainMenu.Controls.Add(button2);
            panel_MainMenu.Controls.Add(button1);
            panel_MainMenu.Controls.Add(btn_NewOrder);
            panel_MainMenu.Controls.Add(label_AppName);
            panel_MainMenu.Controls.Add(picture_AppLogo);
            panel_MainMenu.Dock = DockStyle.Left;
            panel_MainMenu.Location = new Point(0, 0);
            panel_MainMenu.Name = "panel_MainMenu";
            panel_MainMenu.Size = new Size(202, 789);
            panel_MainMenu.TabIndex = 0;
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button6.BackColor = Color.FromArgb(29, 29, 66);
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.ForeColor = Color.White;
            button6.Image = Properties.Resources.Settings_2;
            button6.ImageAlign = ContentAlignment.MiddleLeft;
            button6.Location = new Point(12, 677);
            button6.Name = "button6";
            button6.Size = new Size(88, 55);
            button6.TabIndex = 2;
            button6.Text = "Settings";
            button6.TextAlign = ContentAlignment.MiddleRight;
            button6.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button5.BackColor = Color.FromArgb(29, 29, 66);
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.White;
            button5.Image = Properties.Resources.Exit;
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(12, 722);
            button5.Name = "button5";
            button5.Size = new Size(72, 55);
            button5.TabIndex = 2;
            button5.Text = "Exit";
            button5.TextAlign = ContentAlignment.MiddleRight;
            button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(29, 29, 66);
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Image = Properties.Resources.Fixed_Costs;
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(12, 395);
            button4.Name = "button4";
            button4.Size = new Size(230, 56);
            button4.TabIndex = 2;
            button4.Text = "Fixed Costs";
            button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(29, 29, 66);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Image = Properties.Resources.Stock_2;
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(12, 333);
            button3.Name = "button3";
            button3.Size = new Size(230, 56);
            button3.TabIndex = 2;
            button3.Text = "Stock";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(29, 29, 66);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Image = Properties.Resources.Client;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(12, 271);
            button2.Name = "button2";
            button2.Size = new Size(230, 56);
            button2.TabIndex = 2;
            button2.Text = "Clients";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(29, 29, 66);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Image = Properties.Resources.Pricing;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(12, 209);
            button1.Name = "button1";
            button1.Size = new Size(230, 56);
            button1.TabIndex = 2;
            button1.Text = "Price List";
            button1.UseVisualStyleBackColor = false;
            // 
            // btn_NewOrder
            // 
            btn_NewOrder.BackColor = Color.FromArgb(29, 29, 66);
            btn_NewOrder.FlatAppearance.BorderSize = 0;
            btn_NewOrder.FlatStyle = FlatStyle.Flat;
            btn_NewOrder.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_NewOrder.ForeColor = Color.White;
            btn_NewOrder.Image = Properties.Resources.NewOrder_2;
            btn_NewOrder.ImageAlign = ContentAlignment.MiddleLeft;
            btn_NewOrder.Location = new Point(12, 147);
            btn_NewOrder.Name = "btn_NewOrder";
            btn_NewOrder.Size = new Size(230, 56);
            btn_NewOrder.TabIndex = 2;
            btn_NewOrder.Text = "New Order";
            btn_NewOrder.UseVisualStyleBackColor = false;
            // 
            // label_AppName
            // 
            label_AppName.AutoSize = true;
            label_AppName.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_AppName.ForeColor = Color.White;
            label_AppName.ImageAlign = ContentAlignment.MiddleLeft;
            label_AppName.Location = new Point(72, 20);
            label_AppName.Name = "label_AppName";
            label_AppName.Size = new Size(116, 57);
            label_AppName.TabIndex = 1;
            label_AppName.Text = "Orders \r\nManagement\r\n\r\n";
            label_AppName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // picture_AppLogo
            // 
            picture_AppLogo.Image = Properties.Resources.icons8_e_commerce_96;
            picture_AppLogo.Location = new Point(12, 12);
            picture_AppLogo.Name = "picture_AppLogo";
            picture_AppLogo.Size = new Size(54, 65);
            picture_AppLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picture_AppLogo.TabIndex = 0;
            picture_AppLogo.TabStop = false;
            // 
            // panel_DisplayPage
            // 
            panel_DisplayPage.BackColor = Color.FromArgb(20, 20, 50);
            panel_DisplayPage.Controls.Add(panel_UserProfile);
            panel_DisplayPage.Dock = DockStyle.Fill;
            panel_DisplayPage.Location = new Point(202, 0);
            panel_DisplayPage.Name = "panel_DisplayPage";
            panel_DisplayPage.Size = new Size(1068, 789);
            panel_DisplayPage.TabIndex = 1;
            // 
            // panel_UserProfile
            // 
            panel_UserProfile.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel_UserProfile.BackColor = Color.FromArgb(78, 46, 207);
            panel_UserProfile.Controls.Add(picture_StoreLogo);
            panel_UserProfile.Controls.Add(label_StoreName);
            panel_UserProfile.Location = new Point(864, 20);
            panel_UserProfile.Name = "panel_UserProfile";
            panel_UserProfile.Size = new Size(204, 57);
            panel_UserProfile.TabIndex = 0;
            // 
            // picture_StoreLogo
            // 
            picture_StoreLogo.Image = Properties.Resources.DefaultUser;
            picture_StoreLogo.Location = new Point(144, 3);
            picture_StoreLogo.Name = "picture_StoreLogo";
            picture_StoreLogo.Size = new Size(50, 50);
            picture_StoreLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picture_StoreLogo.TabIndex = 1;
            picture_StoreLogo.TabStop = false;
            // 
            // label_StoreName
            // 
            label_StoreName.Dock = DockStyle.Fill;
            label_StoreName.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_StoreName.ForeColor = SystemColors.ButtonHighlight;
            label_StoreName.ImageAlign = ContentAlignment.BottomLeft;
            label_StoreName.Location = new Point(0, 0);
            label_StoreName.Name = "label_StoreName";
            label_StoreName.Padding = new Padding(10, 0, 0, 0);
            label_StoreName.Size = new Size(204, 57);
            label_StoreName.TabIndex = 0;
            label_StoreName.Text = "My Store";
            label_StoreName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoSize = true;
            BackColor = Color.FromArgb(29, 29, 66);
            ClientSize = new Size(1270, 789);
            Controls.Add(panel_DisplayPage);
            Controls.Add(panel_MainMenu);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MinimumSize = new Size(550, 550);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Orders Management";
            panel_MainMenu.ResumeLayout(false);
            panel_MainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picture_AppLogo).EndInit();
            panel_DisplayPage.ResumeLayout(false);
            panel_UserProfile.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picture_StoreLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_MainMenu;
        private PictureBox picture_AppLogo;
        private Panel panel_DisplayPage;
        private Label label_AppName;
        private Button btn_NewOrder;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button button6;
        private Panel panel_UserProfile;
        private PictureBox picture_StoreLogo;
        private Label label_StoreName;
    }
}
