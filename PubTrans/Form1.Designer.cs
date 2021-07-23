namespace PubTrans
{
    partial class window
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);

        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.checkBoxMetro = new System.Windows.Forms.CheckedListBox();
            this.update = new System.Windows.Forms.Button();
            this.metro = new System.Windows.Forms.Label();
            this.autobus = new System.Windows.Forms.Label();
            this.checkBoxAutobus = new System.Windows.Forms.CheckedListBox();
            this.taxi = new System.Windows.Forms.Label();
            this.checkBoxTaxi = new System.Windows.Forms.CheckedListBox();
            this.infoList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // gMapControl1
            // 
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.CanDragMap = true;
            this.gMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl1.LevelsKeepInMemory = 5;
            this.gMapControl1.Location = new System.Drawing.Point(12, 12);
            this.gMapControl1.MarkersEnabled = true;
            this.gMapControl1.MaxZoom = 2;
            this.gMapControl1.MinZoom = 2;
            this.gMapControl1.MouseWheelZoomEnabled = true;
            this.gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionWithoutCenter;
            this.gMapControl1.Name = "gMapControl1";
            this.gMapControl1.NegativeMode = false;
            this.gMapControl1.PolygonsEnabled = true;
            this.gMapControl1.RetryLoadTile = 0;
            this.gMapControl1.RoutesEnabled = true;
            this.gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl1.ShowTileGridLines = false;
            this.gMapControl1.Size = new System.Drawing.Size(1325, 789);
            this.gMapControl1.TabIndex = 0;
            this.gMapControl1.Zoom = 0D;
            // 
            // checkBoxMetro
            // 
            this.checkBoxMetro.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.checkBoxMetro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkBoxMetro.CheckOnClick = true;
            this.checkBoxMetro.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxMetro.FormattingEnabled = true;
            this.checkBoxMetro.Items.AddRange(new object[] {
            "Зелёная ветка",
            "Красная ветка ",
            "Синяя ветка"});
            this.checkBoxMetro.Location = new System.Drawing.Point(1450, 34);
            this.checkBoxMetro.Name = "checkBoxMetro";
            this.checkBoxMetro.Size = new System.Drawing.Size(166, 63);
            this.checkBoxMetro.TabIndex = 2;
            // 
            // update
            // 
            this.update.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.update.Location = new System.Drawing.Point(1472, 610);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(177, 72);
            this.update.TabIndex = 3;
            this.update.Text = "Обновить карту";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.button1_Click);
            // 
            // metro
            // 
            this.metro.AutoSize = true;
            this.metro.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.metro.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.metro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metro.Location = new System.Drawing.Point(1395, 12);
            this.metro.Name = "metro";
            this.metro.Size = new System.Drawing.Size(65, 19);
            this.metro.TabIndex = 4;
            this.metro.Text = "Метро:";
            // 
            // autobus
            // 
            this.autobus.AutoSize = true;
            this.autobus.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.autobus.Location = new System.Drawing.Point(1395, 100);
            this.autobus.Name = "autobus";
            this.autobus.Size = new System.Drawing.Size(96, 19);
            this.autobus.TabIndex = 5;
            this.autobus.Text = "Автобусы:";
            // 
            // checkBoxAutobus
            // 
            this.checkBoxAutobus.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.checkBoxAutobus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkBoxAutobus.CheckOnClick = true;
            this.checkBoxAutobus.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxAutobus.FormattingEnabled = true;
            this.checkBoxAutobus.Items.AddRange(new object[] {
            "35",
            "27",
            "91",
            "14",
            "81",
            "76",
            "102",
            "70",
            "21",
            "59",
            "72"});
            this.checkBoxAutobus.Location = new System.Drawing.Point(1450, 122);
            this.checkBoxAutobus.Name = "checkBoxAutobus";
            this.checkBoxAutobus.Size = new System.Drawing.Size(120, 126);
            this.checkBoxAutobus.TabIndex = 6;
            // 
            // taxi
            // 
            this.taxi.AutoSize = true;
            this.taxi.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.taxi.Location = new System.Drawing.Point(1395, 251);
            this.taxi.Name = "taxi";
            this.taxi.Size = new System.Drawing.Size(106, 19);
            this.taxi.TabIndex = 7;
            this.taxi.Text = "Маршрутки:";
            // 
            // checkBoxTaxi
            // 
            this.checkBoxTaxi.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.checkBoxTaxi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkBoxTaxi.CheckOnClick = true;
            this.checkBoxTaxi.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxTaxi.FormattingEnabled = true;
            this.checkBoxTaxi.Items.AddRange(new object[] {
            "187",
            "151",
            "200K",
            "201",
            "186",
            "250",
            "457",
            "566",
            "222",
            "530",
            "497K"});
            this.checkBoxTaxi.Location = new System.Drawing.Point(1450, 273);
            this.checkBoxTaxi.Name = "checkBoxTaxi";
            this.checkBoxTaxi.Size = new System.Drawing.Size(120, 126);
            this.checkBoxTaxi.TabIndex = 8;
            // 
            // infoList
            // 
            this.infoList.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.infoList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.infoList.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoList.FormattingEnabled = true;
            this.infoList.ItemHeight = 18;
            this.infoList.Location = new System.Drawing.Point(1343, 414);
            this.infoList.Name = "infoList";
            this.infoList.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.infoList.Size = new System.Drawing.Size(420, 180);
            this.infoList.TabIndex = 9;
            // 
            // window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1775, 813);
            this.Controls.Add(this.infoList);
            this.Controls.Add(this.checkBoxTaxi);
            this.Controls.Add(this.taxi);
            this.Controls.Add(this.checkBoxAutobus);
            this.Controls.Add(this.autobus);
            this.Controls.Add(this.metro);
            this.Controls.Add(this.update);
            this.Controls.Add(this.checkBoxMetro);
            this.Controls.Add(this.gMapControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "window";
            this.ShowIcon = false;
            this.Text = "Kiev Transport";
            this.Load += new System.EventHandler(this.window_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.CheckedListBox checkBoxMetro;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Label metro;
        private System.Windows.Forms.Label autobus;
        private System.Windows.Forms.CheckedListBox checkBoxAutobus;
        private System.Windows.Forms.Label taxi;
        private System.Windows.Forms.CheckedListBox checkBoxTaxi;
        private System.Windows.Forms.ListBox infoList;
    }
}

