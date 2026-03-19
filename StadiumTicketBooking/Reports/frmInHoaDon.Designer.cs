namespace StadiumTicketBooking.Reports
{
    partial class frmInHoaDon
    {
        private System.ComponentModel.IContainer components = null;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            SuspendLayout();
            reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportViewer1.Location = new System.Drawing.Point(0, 0);
            reportViewer1.Name = "reportViewer1";
            reportViewer1.Size = new System.Drawing.Size(1000, 650);
            reportViewer1.TabIndex = 0;

            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1000, 650);
            Controls.Add(reportViewer1);
            Name = "frmInHoaDon";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "In hóa đơn";
            Load += frmInHoaDon_Load;
            ResumeLayout(false);
        }
    }
}