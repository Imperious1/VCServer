namespace VControlWClient
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
            this.connectedDevices = new System.Windows.Forms.ListView();
            this.port = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ipaddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // connectedDevices
            // 
            this.connectedDevices.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.connectedDevices.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.port,
            this.ipaddress});
            this.connectedDevices.GridLines = true;
            this.connectedDevices.Location = new System.Drawing.Point(-9, 171);
            this.connectedDevices.Name = "connectedDevices";
            this.connectedDevices.Size = new System.Drawing.Size(399, 542);
            this.connectedDevices.TabIndex = 1;
            this.connectedDevices.UseCompatibleStateImageBehavior = false;
            this.connectedDevices.View = System.Windows.Forms.View.Details;
            // 
            // port
            // 
            this.port.Text = "Port";
            this.port.Width = 84;
            // 
            // ipaddress
            // 
            this.ipaddress.Text = "IP Address";
            this.ipaddress.Width = 236;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(127, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Status: offline";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(387, 706);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.connectedDevices);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximumSize = new System.Drawing.Size(413, 766);
            this.Name = "Form1";
            this.Text = "VControl Server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView connectedDevices;
        private System.Windows.Forms.ColumnHeader port;
        private System.Windows.Forms.ColumnHeader ipaddress;
        private System.Windows.Forms.Label label1;
    }
}

