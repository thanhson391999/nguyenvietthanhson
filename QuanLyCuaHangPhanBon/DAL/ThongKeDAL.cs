﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface ThongKeDAL
    {
        DataTable BaoCaoChiTietBanHang(string fromDate, string toDate);
        DataTable BaoCaoChiTietNhapHang(string fromDate, string toDate);
        DataTable BaoCaoHoaDonBanHang(string fromDate, string toDate);
        DataTable BaoCaoHoaDonNhapHang(string fromDate, string toDate);
        DataTable BaoCaoXuatKho(string fromDate, string toDate);
        DataTable BaoCaoNhapKho(string fromDate, string toDate);
        DataTable BaoCaoTonKho();
        DataTable BaoCaoSoNoKH();
    }
}
