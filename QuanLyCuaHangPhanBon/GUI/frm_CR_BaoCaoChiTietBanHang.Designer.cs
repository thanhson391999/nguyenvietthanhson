﻿namespace GUI
{
    partial class frm_CR_BaoCaoChiTietBanHang
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
            this.cryBaoCao = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.cryBaoCaoChiTietBanHang1 = new GUI.cryBaoCaoChiTietBanHang();
            this.SuspendLayout();
            // 
            // cryBaoCao
            // 
            this.cryBaoCao.ActiveViewIndex = -1;
            this.cryBaoCao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cryBaoCao.Cursor = System.Windows.Forms.Cursors.Default;
            this.cryBaoCao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cryBaoCao.Location = new System.Drawing.Point(0, 0);
            this.cryBaoCao.Name = "cryBaoCao";
            this.cryBaoCao.Size = new System.Drawing.Size(1106, 519);
            this.cryBaoCao.TabIndex = 0;
            // 
            // frm_CR_BaoCaoChiTietBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 519);
            this.Controls.Add(this.cryBaoCao);
            this.Name = "frm_CR_BaoCaoChiTietBanHang";
            this.Text = "Báo cáo chi tiết bán hàng";
            this.Load += new System.EventHandler(this.frm_CR_BaoCaoChiTietBanHang_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer cryBaoCao;
        private cryBaoCaoChiTietBanHang cryBaoCaoChiTietBanHang1;
    }
}