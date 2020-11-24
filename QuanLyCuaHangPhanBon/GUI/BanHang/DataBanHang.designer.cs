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

namespace GUI.BanHang
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
	public partial class DataBanHang : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertHangHoa(HangHoa instance);
    partial void UpdateHangHoa(HangHoa instance);
    partial void DeleteHangHoa(HangHoa instance);
    partial void InsertKhachHang(KhachHang instance);
    partial void UpdateKhachHang(KhachHang instance);
    partial void DeleteKhachHang(KhachHang instance);
    partial void InsertCTHDBanHang(CTHDBanHang instance);
    partial void UpdateCTHDBanHang(CTHDBanHang instance);
    partial void DeleteCTHDBanHang(CTHDBanHang instance);
    partial void InsertHoaDonBanHang(HoaDonBanHang instance);
    partial void UpdateHoaDonBanHang(HoaDonBanHang instance);
    partial void DeleteHoaDonBanHang(HoaDonBanHang instance);
    #endregion
		
		public DataBanHang() : 
				base(global::GUI.Properties.Settings.Default.QuanLyCuaHangPhanBonConnectionString1, mappingSource)
		{
			OnCreated();
		}
		
		public DataBanHang(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataBanHang(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataBanHang(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataBanHang(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
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
		
		public System.Data.Linq.Table<KhachHang> KhachHangs
		{
			get
			{
				return this.GetTable<KhachHang>();
			}
		}
		
		public System.Data.Linq.Table<CTHDBanHang> CTHDBanHangs
		{
			get
			{
				return this.GetTable<CTHDBanHang>();
			}
		}
		
		public System.Data.Linq.Table<HoaDonBanHang> HoaDonBanHangs
		{
			get
			{
				return this.GetTable<HoaDonBanHang>();
			}
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_BillBanHang")]
		public ISingleResult<sp_BillBanHangResult> sp_BillBanHang()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<sp_BillBanHangResult>)(result.ReturnValue));
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.KhachHang")]
	public partial class KhachHang : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaKH;
		
		private string _TenKH;
		
		private string _SDT;
		
		private string _DiaChi;
		
		private System.Nullable<double> _SoNo;
		
		private string _GhiChu;
		
		private System.Nullable<bool> _TinhTrang;
		
		private EntitySet<HoaDonBanHang> _HoaDonBanHangs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaKHChanging(int value);
    partial void OnMaKHChanged();
    partial void OnTenKHChanging(string value);
    partial void OnTenKHChanged();
    partial void OnSDTChanging(string value);
    partial void OnSDTChanged();
    partial void OnDiaChiChanging(string value);
    partial void OnDiaChiChanged();
    partial void OnSoNoChanging(System.Nullable<double> value);
    partial void OnSoNoChanged();
    partial void OnGhiChuChanging(string value);
    partial void OnGhiChuChanged();
    partial void OnTinhTrangChanging(System.Nullable<bool> value);
    partial void OnTinhTrangChanged();
    #endregion
		
		public KhachHang()
		{
			this._HoaDonBanHangs = new EntitySet<HoaDonBanHang>(new Action<HoaDonBanHang>(this.attach_HoaDonBanHangs), new Action<HoaDonBanHang>(this.detach_HoaDonBanHangs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaKH", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int MaKH
		{
			get
			{
				return this._MaKH;
			}
			set
			{
				if ((this._MaKH != value))
				{
					this.OnMaKHChanging(value);
					this.SendPropertyChanging();
					this._MaKH = value;
					this.SendPropertyChanged("MaKH");
					this.OnMaKHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenKH", DbType="NVarChar(50)")]
		public string TenKH
		{
			get
			{
				return this._TenKH;
			}
			set
			{
				if ((this._TenKH != value))
				{
					this.OnTenKHChanging(value);
					this.SendPropertyChanging();
					this._TenKH = value;
					this.SendPropertyChanged("TenKH");
					this.OnTenKHChanged();
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
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="KhachHang_HoaDonBanHang", Storage="_HoaDonBanHangs", ThisKey="MaKH", OtherKey="KhachHang")]
		public EntitySet<HoaDonBanHang> HoaDonBanHangs
		{
			get
			{
				return this._HoaDonBanHangs;
			}
			set
			{
				this._HoaDonBanHangs.Assign(value);
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
		
		private void attach_HoaDonBanHangs(HoaDonBanHang entity)
		{
			this.SendPropertyChanging();
			entity.KhachHang1 = this;
		}
		
		private void detach_HoaDonBanHangs(HoaDonBanHang entity)
		{
			this.SendPropertyChanging();
			entity.KhachHang1 = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.CTHDBanHang")]
	public partial class CTHDBanHang : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaHDB;
		
		private int _SanPham;
		
		private System.Nullable<int> _SL;
		
		private System.Nullable<double> _DonGia;
		
		private System.Nullable<double> _CK;
		
		private System.Nullable<bool> _TinhTrang;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaHDBChanging(int value);
    partial void OnMaHDBChanged();
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
		
		public CTHDBanHang()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaHDB", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int MaHDB
		{
			get
			{
				return this._MaHDB;
			}
			set
			{
				if ((this._MaHDB != value))
				{
					this.OnMaHDBChanging(value);
					this.SendPropertyChanging();
					this._MaHDB = value;
					this.SendPropertyChanged("MaHDB");
					this.OnMaHDBChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.HoaDonBanHang")]
	public partial class HoaDonBanHang : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaHDB;
		
		private System.Nullable<int> _KhachHang;
		
		private System.Nullable<int> _NhanVienLap;
		
		private System.Nullable<System.DateTime> _NgayLap;
		
		private System.Nullable<double> _CK;
		
		private System.Nullable<double> _NoCu;
		
		private System.Nullable<double> _TienTra;
		
		private string _GhiChu;
		
		private System.Nullable<bool> _TinhTrang;
		
		private EntityRef<KhachHang> _KhachHang1;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaHDBChanging(int value);
    partial void OnMaHDBChanged();
    partial void OnKhachHangChanging(System.Nullable<int> value);
    partial void OnKhachHangChanged();
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
		
		public HoaDonBanHang()
		{
			this._KhachHang1 = default(EntityRef<KhachHang>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaHDB", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int MaHDB
		{
			get
			{
				return this._MaHDB;
			}
			set
			{
				if ((this._MaHDB != value))
				{
					this.OnMaHDBChanging(value);
					this.SendPropertyChanging();
					this._MaHDB = value;
					this.SendPropertyChanged("MaHDB");
					this.OnMaHDBChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_KhachHang", DbType="Int")]
		public System.Nullable<int> KhachHang
		{
			get
			{
				return this._KhachHang;
			}
			set
			{
				if ((this._KhachHang != value))
				{
					if (this._KhachHang1.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnKhachHangChanging(value);
					this.SendPropertyChanging();
					this._KhachHang = value;
					this.SendPropertyChanged("KhachHang");
					this.OnKhachHangChanged();
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
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="KhachHang_HoaDonBanHang", Storage="_KhachHang1", ThisKey="KhachHang", OtherKey="MaKH", IsForeignKey=true)]
		public KhachHang KhachHang1
		{
			get
			{
				return this._KhachHang1.Entity;
			}
			set
			{
				KhachHang previousValue = this._KhachHang1.Entity;
				if (((previousValue != value) 
							|| (this._KhachHang1.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._KhachHang1.Entity = null;
						previousValue.HoaDonBanHangs.Remove(this);
					}
					this._KhachHang1.Entity = value;
					if ((value != null))
					{
						value.HoaDonBanHangs.Add(this);
						this._KhachHang = value.MaKH;
					}
					else
					{
						this._KhachHang = default(Nullable<int>);
					}
					this.SendPropertyChanged("KhachHang1");
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
	
	public partial class sp_BillBanHangResult
	{
		
		private int _MaHDB;
		
		private string _TenKH;
		
		private string _SDT;
		
		private string _DiaChi;
		
		private System.Nullable<double> _NoCu;
		
		private System.Nullable<double> _TienTra;
		
		private string _TenNV;
		
		private System.Nullable<double> _CK;
		
		private string _TenHH;
		
		private System.Nullable<int> _SL;
		
		private System.Nullable<double> _DonGia;
		
		private System.Nullable<double> _ThanhTien;
		
		public sp_BillBanHangResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaHDB", DbType="Int NOT NULL")]
		public int MaHDB
		{
			get
			{
				return this._MaHDB;
			}
			set
			{
				if ((this._MaHDB != value))
				{
					this._MaHDB = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenKH", DbType="NVarChar(50)")]
		public string TenKH
		{
			get
			{
				return this._TenKH;
			}
			set
			{
				if ((this._TenKH != value))
				{
					this._TenKH = value;
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