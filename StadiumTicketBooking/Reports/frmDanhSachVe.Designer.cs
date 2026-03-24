namespace StadiumTicketBooking.Reports
{
    partial class frmDanhSachVe
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
            // 
            // reportViewer1
            // 
            reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportViewer1.Location = new System.Drawing.Point(0, 0);
            reportViewer1.Name = "reportViewer1";
            reportViewer1.ServerReport.BearerToken = null;
            reportViewer1.Size = new System.Drawing.Size(1200, 700);
            reportViewer1.TabIndex = 0;
            // 
            // frmDanhSachVe
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1200, 700);
            Controls.Add(reportViewer1);
            Name = "frmDanhSachVe";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Danh sách vé";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            Load += frmDanhSachVe_Load;
            ResumeLayout(false);
        }
    }
}