namespace robot_routing
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gmap = new GMap.NET.WindowsForms.GMapControl();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.txt_Lat = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.txt_Lang = new System.Windows.Forms.ToolStripTextBox();
            this.btn_Zoom = new System.Windows.Forms.ToolStripButton();
            this.btn_UnFit = new System.Windows.Forms.ToolStripButton();
            this.btn_Cache = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gmap
            // 
            this.gmap.Bearing = 0F;
            this.gmap.CanDragMap = true;
            this.gmap.EmptyTileColor = System.Drawing.Color.Navy;
            this.gmap.GrayScaleMode = false;
            this.gmap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gmap.LevelsKeepInMemmory = 5;
            this.gmap.Location = new System.Drawing.Point(0, -1);
            this.gmap.Margin = new System.Windows.Forms.Padding(2);
            this.gmap.MarkersEnabled = true;
            this.gmap.MaxZoom = 2;
            this.gmap.MinZoom = 2;
            this.gmap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gmap.Name = "gmap";
            this.gmap.NegativeMode = false;
            this.gmap.PolygonsEnabled = true;
            this.gmap.RetryLoadTile = 0;
            this.gmap.RoutesEnabled = true;
            this.gmap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gmap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gmap.ShowTileGridLines = false;
            this.gmap.Size = new System.Drawing.Size(898, 723);
            this.gmap.TabIndex = 7;
            this.gmap.Zoom = 0D;
            this.gmap.Load += new System.EventHandler(this.gmap_Load);
            this.gmap.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gmap_MouseClick);
            this.gmap.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gmap_MouseMove);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.txt_Lat,
            this.toolStripLabel2,
            this.txt_Lang,
            this.btn_Zoom,
            this.btn_UnFit,
            this.btn_Cache});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(900, 25);
            this.toolStrip1.TabIndex = 22;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(23, 22);
            this.toolStripLabel1.Text = "Lat";
            // 
            // txt_Lat
            // 
            this.txt_Lat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Lat.ForeColor = System.Drawing.Color.Red;
            this.txt_Lat.Name = "txt_Lat";
            this.txt_Lat.Size = new System.Drawing.Size(100, 25);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(33, 22);
            this.toolStripLabel2.Text = "Lang";
            // 
            // txt_Lang
            // 
            this.txt_Lang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Lang.ForeColor = System.Drawing.Color.Red;
            this.txt_Lang.Name = "txt_Lang";
            this.txt_Lang.Size = new System.Drawing.Size(100, 25);
            // 
            // btn_Zoom
            // 
            this.btn_Zoom.Checked = true;
            this.btn_Zoom.CheckState = System.Windows.Forms.CheckState.Checked;
            this.btn_Zoom.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_Zoom.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Zoom.Name = "btn_Zoom";
            this.btn_Zoom.Size = new System.Drawing.Size(114, 22);
            this.btn_Zoom.Text = "Fit To Selected Area";
            this.btn_Zoom.Click += new System.EventHandler(this.btn_Zoom_Click);
            // 
            // btn_UnFit
            // 
            this.btn_UnFit.Checked = true;
            this.btn_UnFit.CheckState = System.Windows.Forms.CheckState.Checked;
            this.btn_UnFit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_UnFit.Image = ((System.Drawing.Image)(resources.GetObject("btn_UnFit.Image")));
            this.btn_UnFit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_UnFit.Name = "btn_UnFit";
            this.btn_UnFit.Size = new System.Drawing.Size(39, 22);
            this.btn_UnFit.Text = "UnFit";
            this.btn_UnFit.Click += new System.EventHandler(this.btn_UnFit_Click);
            // 
            // btn_Cache
            // 
            this.btn_Cache.Checked = true;
            this.btn_Cache.CheckState = System.Windows.Forms.CheckState.Checked;
            this.btn_Cache.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_Cache.Image = ((System.Drawing.Image)(resources.GetObject("btn_Cache.Image")));
            this.btn_Cache.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Cache.Name = "btn_Cache";
            this.btn_Cache.Size = new System.Drawing.Size(44, 22);
            this.btn_Cache.Text = "Cache";
            this.btn_Cache.Click += new System.EventHandler(this.btn_Cache_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(900, 583);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.gmap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Map";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private GMap.NET.WindowsForms.GMapControl gmap;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox txt_Lat;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripTextBox txt_Lang;
        private System.Windows.Forms.ToolStripButton btn_Zoom;
        private System.Windows.Forms.ToolStripButton btn_Cache;
        private System.Windows.Forms.ToolStripButton btn_UnFit;
    }
}

