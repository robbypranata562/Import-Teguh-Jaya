using LinqToExcel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImportTeguhJaya
{
    public partial class ImportBarang : Form
    {

        public class ItemImportModel
        {
            public string NamaBarang { get; set; }
            public string JenisBarang { get; set; }
            public string SupplierBarang { get; set; }
            public string Modal { get; set; }
            public string HargaAtas { get; set; }
            public string HargaBawah { get; set; }
            public string JumlahDus { get; set; }
            public string SatuanKonversi { get; set; }
            public string Stock { get; set; }
            public string MinStock { get; set; }
            public string UmurBarangMaksimal { get; set; }
            public string UmurBarangNormal { get; set; }
            public string TanggalMasuk { get; set; }

        }

        private string pathExcel = "";
        private List<ItemImportModel> itemImports = new List<ItemImportModel>();
        public ImportBarang()
        {
            InitializeComponent();
        }

        private void BtnPilihFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.InitialDirectory = "C:\\Users";
            dialog.RestoreDirectory = false;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                pathExcel = dialog.FileName;
                var _sourceImport = ReadExcel(pathExcel);
                if (_sourceImport != null)
                {
                    DGImport.DataSource = _sourceImport;
                }
            }
        }

        public List<ItemImportModel> ReadExcel(string filePath)
        {
            var source = new ExcelQueryFactory(filePath);
            try
            {
                itemImports = (from x in source.Worksheet().Where(x=>x["Nama Barang"] != "")

                                     select new ItemImportModel()
                                     {
                                         NamaBarang = x["Nama Barang"],
                                         JenisBarang = x["Jenis Barang"],
                                         SupplierBarang = x["Suplier Barang"],
                                         Modal = x["Modal"],
                                         HargaAtas = x["Harga Atas"],
                                         HargaBawah = x["Harga Bawah"],
                                         JumlahDus = x["Jumlah Dus"],
                                         SatuanKonversi = x["Satuan Konversi"],
                                         Stock = x["Stok"],
                                         MinStock = x["Min Stock"],
                                         UmurBarangMaksimal = x["Umur Barang Maksimal"],
                                         UmurBarangNormal = x["Umur Barang Normal"],
                                         TanggalMasuk = x["Tanggal Masuk"]

                                     }).ToList();
                return itemImports;
            }
            catch (Exception LinqEx)
            {
                if (LinqEx.Message.Contains("Sheet1"))
                {
                    MessageBox.Show("Please Change Name Sheeet To Sheet1");
                    
                }
                else
                {
                    MessageBox.Show(LinqEx.Message.ToString());
                }
                return null;
            }
        }

        private void BtnImport_Click(object sender, EventArgs e)
        {
            try
            {
                grosirEntities grosirEntities = new grosirEntities();
                int count = itemImports.Count;
                int current = 0;
                if (MessageBox.Show("Apakah Anda Yakin Akan Mengimport Data Ini ?", "Information", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    foreach (var itemImport in itemImports)
                    {
                        item item = new item();
                        item.NamaBarang = itemImport.NamaBarang;
                        item.JenisBarang = itemImport.JenisBarang;
                        item.SupplierBarang = itemImport.SupplierBarang;
                        item.Modal = Convert.ToDouble(itemImport.Modal);
                        item.HargaAtas = Convert.ToDouble(itemImport.HargaAtas);
                        item.HargaBawah = Convert.ToDouble(itemImport.HargaBawah);
                        item.JumlahDus = Convert.ToInt32(itemImport.JumlahDus);
                        item.SatuanKonversi = Convert.ToInt32(itemImport.SatuanKonversi);
                        item.Stok = Convert.ToInt32(itemImport.Stock);
                        item.MinStock = Convert.ToInt32(itemImport.MinStock);
                        item.UmurBarangMaksimal = Convert.ToInt32(itemImport.UmurBarangMaksimal);
                        item.UmurBarangNormal = Convert.ToInt32(itemImport.UmurBarangNormal);
                        item.TanggalMasuk = Convert.ToDateTime(itemImport.TanggalMasuk);
                        grosirEntities.items.Add(item);
                        current++;
                        PBData.Value = current / count * 30 + 70;
                    }
                    grosirEntities.SaveChanges();
                    MessageBox.Show("Import Selesai");
                    grosirEntities.Dispose();
                }
            }
            catch (Exception ex)
            {
                var a = ex.Message.ToString();
                //throw new ArgumentException(ex.Message.ToString());
            }
            
            }
        }
    }

