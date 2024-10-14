namespace Wordtoimages
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            windowBar1 = new AntdUI.WindowBar();
            parrotFormHandle1 = new ReaLTaiizor.Controls.ParrotFormHandle();
            panel1 = new AntdUI.Panel();
            panel6 = new AntdUI.Panel();
            panel5 = new AntdUI.Panel();
            label4 = new AntdUI.Label();
            iconComplete1 = new AntdUI.Icon.IconComplete();
            panel4 = new AntdUI.Panel();
            label3 = new AntdUI.Label();
            iconError1 = new AntdUI.Icon.IconError();
            panel3 = new AntdUI.Panel();
            label2 = new AntdUI.Label();
            iconWarn1 = new AntdUI.Icon.IconWarn();
            panel2 = new AntdUI.Panel();
            label1 = new AntdUI.Label();
            poisonProgressSpinner1 = new ReaLTaiizor.Controls.PoisonProgressSpinner();
            rdoTIFF = new AntdUI.Radio();
            rdoPNG = new AntdUI.Radio();
            rdoJPG = new AntdUI.Radio();
            uiImageButton2 = new Sunny.UI.UIImageButton();
            uiImageButton1 = new Sunny.UI.UIImageButton();
            uiPanel3 = new Sunny.UI.UIPanel();
            uiTreeView1 = new Sunny.UI.UITreeView();
            txtFilePath = new AntdUI.Label();
            materialDivider1 = new ReaLTaiizor.Controls.MaterialDivider();
            uiPanel2 = new Sunny.UI.UIPanel();
            tree1 = new AntdUI.Image3D();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)uiImageButton2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)uiImageButton1).BeginInit();
            uiPanel3.SuspendLayout();
            uiPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // windowBar1
            // 
            windowBar1.BackColor = Color.Silver;
            windowBar1.CancelButton = true;
            windowBar1.Dock = DockStyle.Top;
            windowBar1.Font = new Font("Roboto Condensed", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            windowBar1.ForeColor = Color.FromArgb(128, 128, 255);
            windowBar1.Icon = (Image)resources.GetObject("windowBar1.Icon");
            windowBar1.IsMax = false;
            windowBar1.Location = new Point(0, 0);
            windowBar1.Name = "windowBar1";
            windowBar1.RightToLeft = RightToLeft.No;
            windowBar1.Size = new Size(1538, 47);
            windowBar1.SubText = "";
            windowBar1.TabIndex = 0;
            windowBar1.Text = "DocI";
            // 
            // parrotFormHandle1
            // 
            parrotFormHandle1.DockAtTop = true;
            parrotFormHandle1.HandleControl = this;
            // 
            // panel1
            // 
            panel1.BorderColor = Color.Crimson;
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(rdoTIFF);
            panel1.Controls.Add(rdoPNG);
            panel1.Controls.Add(rdoJPG);
            panel1.Controls.Add(uiImageButton2);
            panel1.Controls.Add(uiImageButton1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 47);
            panel1.Name = "panel1";
            panel1.Radius = 10;
            panel1.Size = new Size(352, 752);
            panel1.TabIndex = 1;
            panel1.Text = "panel1";
            // 
            // panel6
            // 
            panel6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel6.Location = new Point(352, 3);
            panel6.Name = "panel6";
            panel6.Size = new Size(781, 749);
            panel6.TabIndex = 1;
            panel6.Text = "panel6";
            // 
            // panel5
            // 
            panel5.Controls.Add(label4);
            panel5.Controls.Add(iconComplete1);
            panel5.Dock = DockStyle.Bottom;
            panel5.Location = new Point(0, 539);
            panel5.Name = "panel5";
            panel5.Size = new Size(352, 48);
            panel5.TabIndex = 8;
            panel5.Text = "panel5";
            // 
            // label4
            // 
            label4.BackColor = Color.White;
            label4.Font = new Font("Roboto Condensed", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Green;
            label4.Location = new Point(56, 1);
            label4.Name = "label4";
            label4.Size = new Size(277, 44);
            label4.TabIndex = 5;
            label4.Text = "successfly converted ";
            label4.TooltipConfig = null;
            // 
            // iconComplete1
            // 
            iconComplete1.BackColor = Color.Transparent;
            iconComplete1.Location = new Point(3, 0);
            iconComplete1.Name = "iconComplete1";
            iconComplete1.Size = new Size(47, 42);
            iconComplete1.TabIndex = 0;
            iconComplete1.Text = "iconComplete1";
            // 
            // panel4
            // 
            panel4.Controls.Add(label3);
            panel4.Controls.Add(iconError1);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 587);
            panel4.Name = "panel4";
            panel4.Size = new Size(352, 55);
            panel4.TabIndex = 7;
            panel4.Text = "panel4";
            // 
            // label3
            // 
            label3.BackColor = Color.White;
            label3.Font = new Font("Roboto Condensed", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(56, 6);
            label3.Name = "label3";
            label3.Size = new Size(277, 44);
            label3.TabIndex = 4;
            label3.Text = "Unfortunetly we can't convert this file";
            label3.TooltipConfig = null;
            // 
            // iconError1
            // 
            iconError1.BackColor = Color.Transparent;
            iconError1.Location = new Point(9, 6);
            iconError1.Name = "iconError1";
            iconError1.Size = new Size(41, 44);
            iconError1.TabIndex = 0;
            iconError1.Text = "iconError1";
            // 
            // panel3
            // 
            panel3.Controls.Add(label2);
            panel3.Controls.Add(iconWarn1);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 642);
            panel3.Name = "panel3";
            panel3.Size = new Size(352, 52);
            panel3.TabIndex = 6;
            panel3.Text = "panel3";
            // 
            // label2
            // 
            label2.BackColor = Color.White;
            label2.Font = new Font("Roboto Condensed", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Gold;
            label2.Location = new Point(56, 4);
            label2.Name = "label2";
            label2.Size = new Size(277, 42);
            label2.TabIndex = 3;
            label2.Text = "Please select format";
            label2.TooltipConfig = null;
            // 
            // iconWarn1
            // 
            iconWarn1.BackColor = Color.White;
            iconWarn1.Location = new Point(9, 3);
            iconWarn1.Name = "iconWarn1";
            iconWarn1.Size = new Size(41, 42);
            iconWarn1.TabIndex = 0;
            iconWarn1.Text = "iconWarn1";
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Controls.Add(poisonProgressSpinner1);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 694);
            panel2.Name = "panel2";
            panel2.Size = new Size(352, 58);
            panel2.TabIndex = 5;
            panel2.Text = "panel2";
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.Font = new Font("Roboto Condensed", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(128, 128, 255);
            label1.Location = new Point(56, 13);
            label1.Name = "label1";
            label1.Size = new Size(277, 42);
            label1.TabIndex = 2;
            label1.Text = "Converting...";
            label1.TooltipConfig = null;
            // 
            // poisonProgressSpinner1
            // 
            poisonProgressSpinner1.BackColor = Color.FromArgb(224, 224, 224);
            poisonProgressSpinner1.Location = new Point(10, 12);
            poisonProgressSpinner1.Maximum = 100;
            poisonProgressSpinner1.Name = "poisonProgressSpinner1";
            poisonProgressSpinner1.Size = new Size(40, 38);
            poisonProgressSpinner1.TabIndex = 1;
            poisonProgressSpinner1.Text = "poisonProgressSpinner1";
            poisonProgressSpinner1.UseSelectable = true;
            // 
            // rdoTIFF
            // 
            rdoTIFF.AutoCheck = true;
            rdoTIFF.ForeColor = Color.FromArgb(128, 128, 255);
            rdoTIFF.Location = new Point(237, 64);
            rdoTIFF.Name = "rdoTIFF";
            rdoTIFF.Size = new Size(109, 34);
            rdoTIFF.TabIndex = 4;
            rdoTIFF.Text = "TIFF";
            // 
            // rdoPNG
            // 
            rdoPNG.AutoCheck = true;
            rdoPNG.ForeColor = Color.FromArgb(128, 128, 255);
            rdoPNG.Location = new Point(121, 64);
            rdoPNG.Name = "rdoPNG";
            rdoPNG.Size = new Size(112, 34);
            rdoPNG.TabIndex = 3;
            rdoPNG.Text = "PNG";
            // 
            // rdoJPG
            // 
            rdoJPG.AutoCheck = true;
            rdoJPG.ForeColor = Color.FromArgb(128, 128, 255);
            rdoJPG.Location = new Point(3, 64);
            rdoJPG.Name = "rdoJPG";
            rdoJPG.Size = new Size(112, 34);
            rdoJPG.TabIndex = 2;
            rdoJPG.Text = "JPG";
            // 
            // uiImageButton2
            // 
            uiImageButton2.Font = new Font("Microsoft Sans Serif", 12F);
            uiImageButton2.ForeColor = Color.FromArgb(128, 128, 255);
            uiImageButton2.Location = new Point(3, 104);
            uiImageButton2.Name = "uiImageButton2";
            uiImageButton2.Size = new Size(343, 52);
            uiImageButton2.TabIndex = 1;
            uiImageButton2.TabStop = false;
            uiImageButton2.Text = "Convert";
            uiImageButton2.Click += btnConvert_Click;
            // 
            // uiImageButton1
            // 
            uiImageButton1.Font = new Font("Microsoft Sans Serif", 12F);
            uiImageButton1.ForeColor = Color.FromArgb(128, 128, 255);
            uiImageButton1.Location = new Point(3, 6);
            uiImageButton1.Name = "uiImageButton1";
            uiImageButton1.Size = new Size(343, 52);
            uiImageButton1.TabIndex = 0;
            uiImageButton1.TabStop = false;
            uiImageButton1.Text = "Open document";
            uiImageButton1.Click += radButton1_Click;
            // 
            // uiPanel3
            // 
            uiPanel3.Controls.Add(uiTreeView1);
            uiPanel3.Controls.Add(txtFilePath);
            uiPanel3.Controls.Add(materialDivider1);
            uiPanel3.Dock = DockStyle.Right;
            uiPanel3.FillColor = Color.FromArgb(64, 64, 64);
            uiPanel3.Font = new Font("Microsoft Sans Serif", 12F);
            uiPanel3.Location = new Point(781, 0);
            uiPanel3.Margin = new Padding(4, 5, 4, 5);
            uiPanel3.MinimumSize = new Size(1, 1);
            uiPanel3.Name = "uiPanel3";
            uiPanel3.Size = new Size(405, 752);
            uiPanel3.TabIndex = 0;
            uiPanel3.Text = null;
            uiPanel3.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // uiTreeView1
            // 
            uiTreeView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            uiTreeView1.FillColor = Color.FromArgb(64, 64, 64);
            uiTreeView1.Font = new Font("Microsoft Sans Serif", 12F);
            uiTreeView1.ForeColor = Color.White;
            uiTreeView1.Location = new Point(6, 79);
            uiTreeView1.Margin = new Padding(4, 5, 4, 5);
            uiTreeView1.MinimumSize = new Size(1, 1);
            uiTreeView1.Name = "uiTreeView1";
            uiTreeView1.ScrollBarStyleInherited = false;
            uiTreeView1.ShowText = false;
            uiTreeView1.Size = new Size(395, 668);
            uiTreeView1.TabIndex = 2;
            uiTreeView1.Text = "uiTreeView1";
            uiTreeView1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // txtFilePath
            // 
            txtFilePath.BackColor = Color.Transparent;
            txtFilePath.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFilePath.ForeColor = Color.LightYellow;
            txtFilePath.Location = new Point(6, 3);
            txtFilePath.Name = "txtFilePath";
            txtFilePath.Size = new Size(396, 55);
            txtFilePath.TabIndex = 1;
            txtFilePath.Text = "";
            txtFilePath.TooltipConfig = null;
            // 
            // materialDivider1
            // 
            materialDivider1.BackColor = Color.FromArgb(30, 0, 0, 0);
            materialDivider1.Depth = 0;
            materialDivider1.Location = new Point(3, 64);
            materialDivider1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialDivider1.Name = "materialDivider1";
            materialDivider1.Size = new Size(399, 10);
            materialDivider1.TabIndex = 0;
            materialDivider1.Text = "materialDivider1";
            // 
            // uiPanel2
            // 
            uiPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            uiPanel2.Controls.Add(tree1);
            uiPanel2.Controls.Add(uiPanel3);
            uiPanel2.FillColor = Color.FromArgb(224, 224, 224);
            uiPanel2.FillColor2 = Color.FromArgb(238, 251, 250);
            uiPanel2.Font = new Font("Microsoft Sans Serif", 12F);
            uiPanel2.Location = new Point(352, 47);
            uiPanel2.Margin = new Padding(4, 5, 4, 5);
            uiPanel2.MinimumSize = new Size(1, 1);
            uiPanel2.Name = "uiPanel2";
            uiPanel2.RectColor = Color.FromArgb(0, 190, 172);
            uiPanel2.Size = new Size(1186, 752);
            uiPanel2.Style = Sunny.UI.UIStyle.Custom;
            uiPanel2.TabIndex = 3;
            uiPanel2.Text = null;
            uiPanel2.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // tree1
            // 
            tree1.Dock = DockStyle.Fill;
            tree1.ForeColor = Color.White;
            tree1.ImageFit = AntdUI.TFit.Contain;
            tree1.Location = new Point(0, 0);
            tree1.Name = "tree1";
            tree1.Radius = 5;
            tree1.Size = new Size(781, 752);
            tree1.TabIndex = 1;
            tree1.Text = "image3d1";
            tree1.Vertical = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1538, 799);
            Controls.Add(uiPanel2);
            Controls.Add(panel1);
            Controls.Add(windowBar1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(1920, 1020);
            MinimumSize = new Size(190, 40);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)uiImageButton2).EndInit();
            ((System.ComponentModel.ISupportInitialize)uiImageButton1).EndInit();
            uiPanel3.ResumeLayout(false);
            uiPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.WindowBar windowBar1;
        private ReaLTaiizor.Controls.ParrotFormHandle parrotFormHandle1;
        private AntdUI.Panel panel1;
        private Sunny.UI.UIImageButton uiImageButton2;
        private Sunny.UI.UIImageButton uiImageButton1;
        private AntdUI.Radio rdoTIFF;
        private AntdUI.Radio rdoPNG;
        private AntdUI.Radio rdoJPG;
        private ReaLTaiizor.Controls.PoisonProgressSpinner poisonProgressSpinner1;
        private AntdUI.Panel panel2;
        private AntdUI.Label label1;
        private AntdUI.Panel panel3;
        private AntdUI.Label label2;
        private AntdUI.Icon.IconWarn iconWarn1;
        private AntdUI.Panel panel4;
        private AntdUI.Label label3;
        private AntdUI.Icon.IconError iconError1;
        private AntdUI.Panel panel5;
        private AntdUI.Label label4;
        private AntdUI.Icon.IconComplete iconComplete1;
        private Sunny.UI.UIPanel uiPanel2;
        private Sunny.UI.UIPanel uiPanel3;
        private AntdUI.Label txtFilePath;
        private ReaLTaiizor.Controls.MaterialDivider materialDivider1;
        private AntdUI.Panel panel6;
        private AntdUI.Image3D tree1;
        private Sunny.UI.UITreeView uiTreeView1;
    }
}
