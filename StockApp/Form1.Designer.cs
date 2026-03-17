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
            btn_Settings = new Button();
            btn_Exit = new Button();
            btn_FixedCosts = new Button();
            btn_Stock = new Button();
            btn_Clients = new Button();
            btn_PriceList = new Button();
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
            panel_MainMenu.Controls.Add(btn_Settings);
            panel_MainMenu.Controls.Add(btn_Exit);
            panel_MainMenu.Controls.Add(btn_FixedCosts);
            panel_MainMenu.Controls.Add(btn_Stock);
            panel_MainMenu.Controls.Add(btn_Clients);
            panel_MainMenu.Controls.Add(btn_PriceList);
            panel_MainMenu.Controls.Add(btn_NewOrder);
            panel_MainMenu.Controls.Add(label_AppName);
            panel_MainMenu.Controls.Add(picture_AppLogo);
            panel_MainMenu.Dock = DockStyle.Left;
            panel_MainMenu.Location = new Point(0, 0);
            panel_MainMenu.Name = "panel_MainMenu";
            panel_MainMenu.Size = new Size(202, 789);
            panel_MainMenu.TabIndex = 0;
            // 
            // btn_Settings
            // 
            btn_Settings.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btn_Settings.BackColor = Color.FromArgb(29, 29, 66);
            btn_Settings.FlatAppearance.BorderSize = 0;
            btn_Settings.FlatStyle = FlatStyle.Flat;
            btn_Settings.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Settings.ForeColor = Color.White;
            btn_Settings.Image = Properties.Resources.Settings_2;
            btn_Settings.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Settings.Location = new Point(12, 677);
            btn_Settings.Name = "btn_Settings";
            btn_Settings.Size = new Size(88, 55);
            btn_Settings.TabIndex = 2;
            btn_Settings.Text = "Settings";
            btn_Settings.TextAlign = ContentAlignment.MiddleRight;
            btn_Settings.UseVisualStyleBackColor = false;
            // 
            // btn_Exit
            // 
            btn_Exit.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btn_Exit.BackColor = Color.FromArgb(29, 29, 66);
            btn_Exit.FlatAppearance.BorderSize = 0;
            btn_Exit.FlatStyle = FlatStyle.Flat;
            btn_Exit.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Exit.ForeColor = Color.White;
            btn_Exit.Image = Properties.Resources.Exit;
            btn_Exit.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Exit.Location = new Point(12, 722);
            btn_Exit.Name = "btn_Exit";
            btn_Exit.Size = new Size(72, 55);
            btn_Exit.TabIndex = 2;
            btn_Exit.Text = "Exit";
            btn_Exit.TextAlign = ContentAlignment.MiddleRight;
            btn_Exit.UseVisualStyleBackColor = false;
            // 
            // btn_FixedCosts
            // 
            btn_FixedCosts.BackColor = Color.FromArgb(29, 29, 66);
            btn_FixedCosts.FlatAppearance.BorderSize = 0;
            btn_FixedCosts.FlatStyle = FlatStyle.Flat;
            btn_FixedCosts.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_FixedCosts.ForeColor = Color.White;
            btn_FixedCosts.Image = Properties.Resources.Fixed_Costs;
            btn_FixedCosts.ImageAlign = ContentAlignment.MiddleLeft;
            btn_FixedCosts.Location = new Point(12, 395);
            btn_FixedCosts.Name = "btn_FixedCosts";
            btn_FixedCosts.Size = new Size(230, 56);
            btn_FixedCosts.TabIndex = 2;
            btn_FixedCosts.Text = "Fixed Costs";
            btn_FixedCosts.UseVisualStyleBackColor = false;
            // 
            // btn_Stock
            // 
            btn_Stock.BackColor = Color.FromArgb(29, 29, 66);
            btn_Stock.FlatAppearance.BorderSize = 0;
            btn_Stock.FlatStyle = FlatStyle.Flat;
            btn_Stock.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Stock.ForeColor = Color.White;
            btn_Stock.Image = Properties.Resources.Stock_2;
            btn_Stock.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Stock.Location = new Point(12, 333);
            btn_Stock.Name = "btn_Stock";
            btn_Stock.Size = new Size(230, 56);
            btn_Stock.TabIndex = 2;
            btn_Stock.Text = "Stock";
            btn_Stock.UseVisualStyleBackColor = false;
            // 
            // btn_Clients
            // 
            btn_Clients.BackColor = Color.FromArgb(29, 29, 66);
            btn_Clients.FlatAppearance.BorderSize = 0;
            btn_Clients.FlatStyle = FlatStyle.Flat;
            btn_Clients.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Clients.ForeColor = Color.White;
            btn_Clients.Image = Properties.Resources.Client;
            btn_Clients.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Clients.Location = new Point(12, 271);
            btn_Clients.Name = "btn_Clients";
            btn_Clients.Size = new Size(230, 56);
            btn_Clients.TabIndex = 2;
            btn_Clients.Text = "Clients";
            btn_Clients.UseVisualStyleBackColor = false;
            // 
            // btn_PriceList
            // 
            btn_PriceList.BackColor = Color.FromArgb(29, 29, 66);
            btn_PriceList.FlatAppearance.BorderSize = 0;
            btn_PriceList.FlatStyle = FlatStyle.Flat;
            btn_PriceList.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_PriceList.ForeColor = Color.White;
            btn_PriceList.Image = Properties.Resources.Pricing;
            btn_PriceList.ImageAlign = ContentAlignment.MiddleLeft;
            btn_PriceList.Location = new Point(12, 209);
            btn_PriceList.Name = "btn_PriceList";
            btn_PriceList.Size = new Size(230, 56);
            btn_PriceList.TabIndex = 2;
            btn_PriceList.Text = "Price List";
            btn_PriceList.UseVisualStyleBackColor = false;
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
        private Button btn_Exit;
        private Button btn_FixedCosts;
        private Button btn_Stock;
        private Button btn_Clients;
        private Button btn_PriceList;
        private Button btn_Settings;
        private Panel panel_UserProfile;
        private PictureBox picture_StoreLogo;
        private Label label_StoreName;
    }
}
