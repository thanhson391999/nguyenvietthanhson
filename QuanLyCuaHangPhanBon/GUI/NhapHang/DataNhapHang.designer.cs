﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GUI.NhapHang
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="QuanLyCuaHangPhanBon")]
	public partial class DataNhapHang : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertHangHoa(HangHoa instance);
    partial void UpdateHangHoa(HangHoa instance);
    partial void DeleteHangHoa(HangHoa instance);
    partial void InsertNhaCungCap(NhaCungCap instance);
    partial void UpdateNhaCungCap(NhaCungCap instance);
    partial void DeleteNhaCungCap(NhaCungCap instance);
    partial void InsertCTHDNhapHang(CTHDNhapHang instance);
    partial void UpdateCTHDNhapHang(CTHDNhapHang instance);
    partial void DeleteCTHDNhapHang(CTHDNhapHang instance);
    partial void InsertHoaDonNhapHang(HoaDonNhapHang instance);
    partial void UpdateHoaDonNhapHang(HoaDonNhapHang instance);
    partial void DeleteHoaDonNhapHang(HoaDonNhapHang instance);
    #endregion
		
		public DataNhapHang() : 
				base(global::GUI.Properties.Settings.Default.QuanLyCuaHangPhanBonConnectionString1, mappingSource)
		{
			OnCreated();
		}
		
		public DataNhapHang(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataNhapHang(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataNhapHang(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataNhapHang(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<HangHoa> HangHoas
		{
			get
			{
				return this.GetTable<HangHoa>();
			}
		}
		
		public System.Data.Linq.Table<NhaCungCap> NhaCungCaps
		{
			get
			{
				return this.GetTable<NhaCungCap>();
			}
		}
		
		public System.Data.Linq.Table<CTHDNhapHang> CTHDNhapHangs
		{
			get
			{
				return this.GetTable<CTHDNhapHang>();
			}
		}
		
		public System.Data.Linq.Table<HoaDonNhapHang> HoaDonNhapHangs
		{
			get
			{
				return this.GetTable<HoaDonNhapHang>();
			}
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_BillNhapHang")]
		public ISingleResult<sp_BillNhapHangResult> sp_BillNhapHang()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<sp_BillNhapHangResult>)(result.ReturnValue));
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.HangHoa")]
	public partial class HangHoa : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaHH;
		
		private string _TenHH;
		
		private string _DonViTinh;
		
		private System.Nullable<double> _GiaBan;
		
		private System.Nullable<double> _GiaMua;
		
		private System.Nullable<int> _SoLuong;
		
		private string _GhiChu;
		
		private System.Nullable<bool> _TinhTrang;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaHHChanging(int value);
    partial void OnMaHHChanged();
    partial void OnTenHHChanging(string value);
    partial void OnTenHHChanged();
    partial void OnDonViTinhChanging(string value);
    partial void OnDonViTinhChanged();
    partial void OnGiaBanChanging(System.Nullable<double> value);
    partial void OnGiaBanChanged();
    partial void OnGiaMuaChanging(System.Nullable<double> value);
    partial void OnGiaMuaChanged();
    partial void OnSoLuongChanging(System.Nullable<int> value);
    partial void OnSoLuongChanged();
    partial void OnGhiChuChanging(string value);
    partial void OnGhiChuChanged();
    partial void OnTinhTrangChanging(System.Nullable<bool> value);
    partial void OnTinhTrangChanged();
    #endregion
		
		public HangHoa()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaHH", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int MaHH
		{
			get
			{
				return this._MaHH;
			}
			set
			{
				if ((this._MaHH != value))
				{
					this.OnMaHHChanging(value);
					this.SendPropertyChanging();
					this._MaHH = value;
					this.SendPropertyChanged("MaHH");
					this.OnMaHHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenHH", DbType="NVarChar(50)")]
		public string TenHH
		{
			get
			{
				return this._TenHH;
			}
			set
			{
				if ((this._TenHH != value))
				{
					this.OnTenHHChanging(value);
					this.SendPropertyChanging();
					this._TenHH = value;
					this.SendPropertyChanged("TenHH");
					this.OnTenHHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DonViTinh", DbType="NVarChar(20)")]
		public string DonViTinh
		{
			get
			{
				return this._DonViTinh;
			}
			set
			{
				if ((this._DonViTinh != value))
				{
					this.OnDonViTinhChanging(value);
					this.SendPropertyChanging();
					this._DonViTinh = value;
					this.SendPropertyChanged("DonViTinh");
					this.OnDonViTinhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GiaBan", DbType="Float")]
		public System.Nullable<double> GiaBan
		{
			get
			{
				return this._GiaBan;
			}
			set
			{
				if ((this._GiaBan != value))
				{
					this.OnGiaBanChanging(value);
					this.SendPropertyChanging();
					this._GiaBan = value;
					this.SendPropertyChanged("GiaBan");
					this.OnGiaBanChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GiaMua", DbType="Float")]
		public System.Nullable<double> GiaMua
		{
			get
			{
				return this._GiaMua;
			}
			set
			{
				if ((this._GiaMua != value))
				{
					this.OnGiaMuaChanging(value);
					this.SendPropertyChanging();
					this._GiaMua = value;
					this.SendPropertyChanged("GiaMua");
					this.OnGiaMuaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoLuong", DbType="Int")]
		public System.Nullable<int> SoLuong
		{
			get
			{
				return this._SoLuong;
			}
			set
			{
				if ((this._SoLuong != value))
				{
					this.OnSoLuongChanging(value);
					this.SendPropertyChanging();
					this._SoLuong = value;
					this.SendPropertyChanged("SoLuong");
					this.OnSoLuongChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GhiChu", DbType="NVarChar(50)")]
		public string GhiChu
		{
			get
			{
				return this._GhiChu;
			}
			set
			{
				if ((this._GhiChu != value))
				{
					this.OnGhiChuChanging(value);
					this.SendPropertyChanging();
					this._GhiChu = value;
					this.SendPropertyChanged("GhiChu");
					this.OnGhiChuChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TinhTrang", DbType="Bit")]
		public System.Nullable<bool> TinhTrang
		{
			get
			{
				return this._TinhTrang;
			}
			set
			{
				if ((this._TinhTrang != value))
				{
					this.OnTinhTrangChanging(value);
					this.SendPropertyChanging();
					this._TinhTrang = value;
					this.SendPropertyChanged("TinhTrang");
					this.OnTinhTrangChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.NhaCungCap")]
	public partial class NhaCungCap : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaNCC;
		
		private string _TenNCC;
		
		private string _DiaChi;
		
		private string _SDT;
		
		private System.Nullable<double> _SoNo;
		
		private string _GhiChu;
		
		private System.Nullable<bool> _TinhTrang;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaNCCChanging(int value);
    partial void OnMaNCCChanged();
    partial void OnTenNCCChanging(string value);
    partial void OnTenNCCChanged();
    partial void OnDiaChiChanging(string value);
    partial void OnDiaChiChanged();
    partial void OnSDTChanging(string value);
    partial void OnSDTChanged();
    partial void OnSoNoChanging(System.Nullable<double> value);
    partial void OnSoNoChanged();
    partial void OnGhiChuChanging(string value);
    partial void OnGhiChuChanged();
    partial void OnTinhTrangChanging(System.Nullable<bool> value);
    partial void OnTinhTrangChanged();
    #endregion
		
		public NhaCungCap()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaNCC", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int MaNCC
		{
			get
			{
				return this._MaNCC;
			}
			set
			{
				if ((this._MaNCC != value))
				{
					this.OnMaNCCChanging(value);
					this.SendPropertyChanging();
					this._MaNCC = value;
					this.SendPropertyChanged("MaNCC");
					this.OnMaNCCChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenNCC", DbType="NVarChar(50)")]
		public string TenNCC
		{
			get
			{
				return this._TenNCC;
			}
			set
			{
				if ((this._TenNCC != value))
				{
					this.OnTenNCCChanging(value);
					this.SendPropertyChanging();
					this._TenNCC = value;
					this.SendPropertyChanged("TenNCC");
					this.OnTenNCCChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DiaChi", DbType="NVarChar(50)")]
		public string DiaChi
		{
			get
			{
				return this._DiaChi;
			}
			set
			{
				if ((this._DiaChi != value))
				{
					this.OnDiaChiChanging(value);
					this.SendPropertyChanging();
					this._DiaChi = value;
					this.SendPropertyChanged("DiaChi");
					this.OnDiaChiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SDT", DbType="Char(10)")]
		public string SDT
		{
			get
			{
				return this._SDT;
			}
			set
			{
				if ((this._SDT != value))
				{
					this.OnSDTChanging(value);
					this.SendPropertyChanging();
					this._SDT = value;
					this.SendPropertyChanged("SDT");
					this.OnSDTChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoNo", DbType="Float")]
		public System.Nullable<double> SoNo
		{
			get
			{
				return this._SoNo;
			}
			set
			{
				if ((this._SoNo != value))
				{
					this.OnSoNoChanging(value);
					this.SendPropertyChanging();
					this._SoNo = value;
					this.SendPropertyChanged("SoNo");
					this.OnSoNoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GhiChu", DbType="NVarChar(50)")]
		public string GhiChu
		{
			get
			{
				return this._GhiChu;
			}
			set
			{
				if ((this._GhiChu != value))
				{
					this.OnGhiChuChanging(value);
					this.SendPropertyChanging();
					this._GhiChu = value;
					this.SendPropertyChanged("GhiChu");
					this.OnGhiChuChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TinhTrang", DbType="Bit")]
		public System.Nullable<bool> TinhTrang
		{
			get
			{
				return this._TinhTrang;
			}
			set
			{
				if ((this._TinhTrang != value))
				{
					this.OnTinhTrangChanging(value);
					this.SendPropertyChanging();
					this._TinhTrang = value;
					this.SendPropertyChanged("TinhTrang");
					this.OnTinhTrangChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.CTHDNhapHang")]
	public partial class CTHDNhapHang : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaHDN;
		
		private int _SanPham;
		
		private System.Nullable<int> _SL;
		
		private System.Nullable<double> _DonGia;
		
		private System.Nullable<double> _CK;
		
		private System.Nullable<bool> _TinhTrang;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaHDNChanging(int value);
    partial void OnMaHDNChanged();
    partial void OnSanPhamChanging(int value);
    partial void OnSanPhamChanged();
    partial void OnSLChanging(System.Nullable<int> value);
    partial void OnSLChanged();
    partial void OnDonGiaChanging(System.Nullable<double> value);
    partial void OnDonGiaChanged();
    partial void OnCKChanging(System.Nullable<double> value);
    partial void OnCKChanged();
    partial void OnTinhTrangChanging(System.Nullable<bool> value);
    partial void OnTinhTrangChanged();
    #endregion
		
		public CTHDNhapHang()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaHDN", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int MaHDN
		{
			get
			{
				return this._MaHDN;
			}
			set
			{
				if ((this._MaHDN != value))
				{
					this.OnMaHDNChanging(value);
					this.SendPropertyChanging();
					this._MaHDN = value;
					this.SendPropertyChanged("MaHDN");
					this.OnMaHDNChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SanPham", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int SanPham
		{
			get
			{
				return this._SanPham;
			}
			set
			{
				if ((this._SanPham != value))
				{
					this.OnSanPhamChanging(value);
					this.SendPropertyChanging();
					this._SanPham = value;
					this.SendPropertyChanged("SanPham");
					this.OnSanPhamChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SL", DbType="Int")]
		public System.Nullable<int> SL
		{
			get
			{
				return this._SL;
			}
			set
			{
				if ((this._SL != value))
				{
					this.OnSLChanging(value);
					this.SendPropertyChanging();
					this._SL = value;
					this.SendPropertyChanged("SL");
					this.OnSLChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DonGia", DbType="Float")]
		public System.Nullable<double> DonGia
		{
			get
			{
				return this._DonGia;
			}
			set
			{
				if ((this._DonGia != value))
				{
					this.OnDonGiaChanging(value);
					this.SendPropertyChanging();
					this._DonGia = value;
					this.SendPropertyChanged("DonGia");
					this.OnDonGiaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CK", DbType="Float")]
		public System.Nullable<double> CK
		{
			get
			{
				return this._CK;
			}
			set
			{
				if ((this._CK != value))
				{
					this.OnCKChanging(value);
					this.SendPropertyChanging();
					this._CK = value;
					this.SendPropertyChanged("CK");
					this.OnCKChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TinhTrang", DbType="Bit")]
		public System.Nullable<bool> TinhTrang
		{
			get
			{
				return this._TinhTrang;
			}
			set
			{
				if ((this._TinhTrang != value))
				{
					this.OnTinhTrangChanging(value);
					this.SendPropertyChanging();
					this._TinhTrang = value;
					this.SendPropertyChanged("TinhTrang");
					this.OnTinhTrangChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.HoaDonNhapHang")]
	public partial class HoaDonNhapHang : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaHDN;
		
		private System.Nullable<int> _NCC;
		
		private System.Nullable<int> _NhanVienLap;
		
		private System.Nullable<System.DateTime> _NgayLap;
		
		private System.Nullable<double> _CK;
		
		private System.Nullable<double> _NoCu;
		
		private System.Nullable<double> _TienTra;
		
		private string _GhiChu;
		
		private System.Nullable<bool> _TinhTrang;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaHDNChanging(int value);
    partial void OnMaHDNChanged();
    partial void OnNCCChanging(System.Nullable<int> value);
    partial void OnNCCChanged();
    partial void OnNhanVienLapChanging(System.Nullable<int> value);
    partial void OnNhanVienLapChanged();
    partial void OnNgayLapChanging(System.Nullable<System.DateTime> value);
    partial void OnNgayLapChanged();
    partial void OnCKChanging(System.Nullable<double> value);
    partial void OnCKChanged();
    partial void OnNoCuChanging(System.Nullable<double> value);
    partial void OnNoCuChanged();
    partial void OnTienTraChanging(System.Nullable<double> value);
    partial void OnTienTraChanged();
    partial void OnGhiChuChanging(string value);
    partial void OnGhiChuChanged();
    partial void OnTinhTrangChanging(System.Nullable<bool> value);
    partial void OnTinhTrangChanged();
    #endregion
		
		public HoaDonNhapHang()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaHDN", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int MaHDN
		{
			get
			{
				return this._MaHDN;
			}
			set
			{
				if ((this._MaHDN != value))
				{
					this.OnMaHDNChanging(value);
					this.SendPropertyChanging();
					this._MaHDN = value;
					this.SendPropertyChanged("MaHDN");
					this.OnMaHDNChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NCC", DbType="Int")]
		public System.Nullable<int> NCC
		{
			get
			{
				return this._NCC;
			}
			set
			{
				if ((this._NCC != value))
				{
					this.OnNCCChanging(value);
					this.SendPropertyChanging();
					this._NCC = value;
					this.SendPropertyChanged("NCC");
					this.OnNCCChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NhanVienLap", DbType="Int")]
		public System.Nullable<int> NhanVienLap
		{
			get
			{
				return this._NhanVienLap;
			}
			set
			{
				if ((this._NhanVienLap != value))
				{
					this.OnNhanVienLapChanging(value);
					this.SendPropertyChanging();
					this._NhanVienLap = value;
					this.SendPropertyChanged("NhanVienLap");
					this.OnNhanVienLapChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgayLap", DbType="DateTime")]
		public System.Nullable<System.DateTime> NgayLap
		{
			get
			{
				return this._NgayLap;
			}
			set
			{
				if ((this._NgayLap != value))
				{
					this.OnNgayLapChanging(value);
					this.SendPropertyChanging();
					this._NgayLap = value;
					this.SendPropertyChanged("NgayLap");
					this.OnNgayLapChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CK", DbType="Float")]
		public System.Nullable<double> CK
		{
			get
			{
				return this._CK;
			}
			set
			{
				if ((this._CK != value))
				{
					this.OnCKChanging(value);
					this.SendPropertyChanging();
					this._CK = value;
					this.SendPropertyChanged("CK");
					this.OnCKChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NoCu", DbType="Float")]
		public System.Nullable<double> NoCu
		{
			get
			{
				return this._NoCu;
			}
			set
			{
				if ((this._NoCu != value))
				{
					this.OnNoCuChanging(value);
					this.SendPropertyChanging();
					this._NoCu = value;
					this.SendPropertyChanged("NoCu");
					this.OnNoCuChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TienTra", DbType="Float")]
		public System.Nullable<double> TienTra
		{
			get
			{
				return this._TienTra;
			}
			set
			{
				if ((this._TienTra != value))
				{
					this.OnTienTraChanging(value);
					this.SendPropertyChanging();
					this._TienTra = value;
					this.SendPropertyChanged("TienTra");
					this.OnTienTraChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GhiChu", DbType="NVarChar(50)")]
		public string GhiChu
		{
			get
			{
				return this._GhiChu;
			}
			set
			{
				if ((this._GhiChu != value))
				{
					this.OnGhiChuChanging(value);
					this.SendPropertyChanging();
					this._GhiChu = value;
					this.SendPropertyChanged("GhiChu");
					this.OnGhiChuChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TinhTrang", DbType="Bit")]
		public System.Nullable<bool> TinhTrang
		{
			get
			{
				return this._TinhTrang;
			}
			set
			{
				if ((this._TinhTrang != value))
				{
					this.OnTinhTrangChanging(value);
					this.SendPropertyChanging();
					this._TinhTrang = value;
					this.SendPropertyChanged("TinhTrang");
					this.OnTinhTrangChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	public partial class sp_BillNhapHangResult
	{
		
		private int _MaHDN;
		
		private string _TenNCC;
		
		private string _SDT;
		
		private string _DiaChi;
		
		private System.Nullable<double> _NoCu;
		
		private string _TenNV;
		
		private System.Nullable<double> _CK;
		
		private string _TenHH;
		
		private System.Nullable<double> _TienTra;
		
		private System.Nullable<int> _SL;
		
		private System.Nullable<double> _DonGia;
		
		private System.Nullable<double> _ThanhTien;
		
		public sp_BillNhapHangResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaHDN", DbType="Int NOT NULL")]
		public int MaHDN
		{
			get
			{
				return this._MaHDN;
			}
			set
			{
				if ((this._MaHDN != value))
				{
					this._MaHDN = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenNCC", DbType="NVarChar(50)")]
		public string TenNCC
		{
			get
			{
				return this._TenNCC;
			}
			set
			{
				if ((this._TenNCC != value))
				{
					this._TenNCC = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SDT", DbType="Char(10)")]
		public string SDT
		{
			get
			{
				return this._SDT;
			}
			set
			{
				if ((this._SDT != value))
				{
					this._SDT = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DiaChi", DbType="NVarChar(50)")]
		public string DiaChi
		{
			get
			{
				return this._DiaChi;
			}
			set
			{
				if ((this._DiaChi != value))
				{
					this._DiaChi = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NoCu", DbType="Float")]
		public System.Nullable<double> NoCu
		{
			get
			{
				return this._NoCu;
			}
			set
			{
				if ((this._NoCu != value))
				{
					this._NoCu = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenNV", DbType="NVarChar(50)")]
		public string TenNV
		{
			get
			{
				return this._TenNV;
			}
			set
			{
				if ((this._TenNV != value))
				{
					this._TenNV = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CK", DbType="Float")]
		public System.Nullable<double> CK
		{
			get
			{
				return this._CK;
			}
			set
			{
				if ((this._CK != value))
				{
					this._CK = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenHH", DbType="NVarChar(50)")]
		public string TenHH
		{
			get
			{
				return this._TenHH;
			}
			set
			{
				if ((this._TenHH != value))
				{
					this._TenHH = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TienTra", DbType="Float")]
		public System.Nullable<double> TienTra
		{
			get
			{
				return this._TienTra;
			}
			set
			{
				if ((this._TienTra != value))
				{
					this._TienTra = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SL", DbType="Int")]
		public System.Nullable<int> SL
		{
			get
			{
				return this._SL;
			}
			set
			{
				if ((this._SL != value))
				{
					this._SL = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DonGia", DbType="Float")]
		public System.Nullable<double> DonGia
		{
			get
			{
				return this._DonGia;
			}
			set
			{
				if ((this._DonGia != value))
				{
					this._DonGia = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ThanhTien", DbType="Float")]
		public System.Nullable<double> ThanhTien
		{
			get
			{
				return this._ThanhTien;
			}
			set
			{
				if ((this._ThanhTien != value))
				{
					this._ThanhTien = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
