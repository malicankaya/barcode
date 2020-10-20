using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using System.Linq.Expressions;
using System.Windows.Forms;
using System.Collections;
using Barkod_ve_Envanter_Sayım.Classes;

namespace Barkod_ve_Envanter_Sayım
{
    class Database : IDatabase
    {
        MySqlConnection mySqlConnection;
        public void Baglan() 
        {
            mySqlConnection = new MySqlConnection("Server=localhost;Database=barcode;Uid=root;Pwd='root';");

            try
            {
                mySqlConnection.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show("BİR HATA OLUŞTU, LÜTFEN ÜRETİCİYLE İLETİŞİME GEÇİN. \n HATA: Database Connection Error");
                throw;
            }
        }
        public void BaglantiyiKes()
        {
            mySqlConnection.Close();
        }
        public void AddProduct(UrunlerMapping urunlerMapping) 
        {
            string query1 = "select * from urunler where barcode = '"+urunlerMapping.barcode+"'";
            MySqlCommand mySqlCommand = new MySqlCommand(query1, mySqlConnection);
            MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
            if (mySqlDataReader.Read() == true)
            {
                MessageBox.Show("Ürün mevcuttur.", "UYARI");
            }
            else 
            {
                //aşağıdaki tekrar bağlantı istediği için datareader'ı kapatmak zorundayız
                mySqlDataReader.Close();
                runNonQuery("insert into urunler(barcode,isim,fiyat,stok,shortname,kdv) values('" + urunlerMapping.barcode + "','" + urunlerMapping.isim + "','" + urunlerMapping.fiyat + "','" + urunlerMapping.stok + "','" + urunlerMapping.shortName + "','" + urunlerMapping.kdv + "')");
                MessageBox.Show("ÜRÜN EKLENDİ");
            }

        }
        public void DeleteProduct(string productBarcode)
        {
            string query = "delete from urunler where barcode = '" + productBarcode + "'";
            MySqlCommand mySqlCommand = new MySqlCommand(query, mySqlConnection);

            if (mySqlCommand.ExecuteNonQuery() == 0) 
            {
                MessageBox.Show("Böyle bir ürün bulunmamaktadır.","UYARI");
            }
            else 
            {
                MessageBox.Show("Ürün başarıyla silindi.", "UYARI");
            }
        }
        public void EditProduct(UrunlerMapping urunlerMapping)
        {
            try
            {
                float.Parse(urunlerMapping.fiyat);
                float.Parse(urunlerMapping.stok);
                runNonQuery("update urunler set isim ='" + urunlerMapping.isim + "', fiyat ='" + urunlerMapping.fiyat + "', stok ='" + urunlerMapping.stok + "', kdv = '" + urunlerMapping.kdv + "' where barcode ='" + urunlerMapping.barcode + "'");
                MessageBox.Show("Ürün güncellendi.","UYARI");
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen geçerli bir sayı giriniz.","UYARI");
            }

}
        public UrunlerMapping ReturnProduct(string barcode) 
        {
            UrunlerMapping mapping = new UrunlerMapping();
            string query = "select isim,fiyat,stok,shortname,kdv from urunler where barcode ='" + barcode + "'";
            MySqlCommand myCommand = new MySqlCommand(query, mySqlConnection);
            MySqlDataReader myReader= myCommand.ExecuteReader();
            try
            {
                //düzenle, birden fazla ürün bulursa son ürünü alır
                while (myReader.Read())
                {
                    mapping.isim = (string)myReader.GetString(0);
                    mapping.fiyat = (string)myReader.GetString(1);
                    mapping.stok = (string)myReader.GetString(2);
                    mapping.shortName = (string)myReader.GetString(3);
                    mapping.kdv = (string)myReader.GetString(4);
                }
            }
            catch (Exception)
            {
                throw;
            }

            myReader.Close();
            return mapping;
        }
        public List<UrunlerMapping> ShowInventory()
        { 
            List<UrunlerMapping> urunlerMappingList = new List<UrunlerMapping>();
            UrunlerMapping urunlerMapping;
            string query = "select isim,stok from urunler order by stok+0 asc";
            MySqlCommand mySqlCommand = new MySqlCommand(query , mySqlConnection);
            MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();

            try
            {
                while (mySqlDataReader.Read())
                {
                    urunlerMapping = new UrunlerMapping();
                    urunlerMapping.isim = (string)mySqlDataReader.GetString(0);
                    urunlerMapping.stok = (string)mySqlDataReader.GetString(1);
                    urunlerMappingList.Add(urunlerMapping);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Bağlantı Hatası.");
                throw;
            }

            mySqlDataReader.Close();
            return urunlerMappingList;
        }
        public void ReduceInventory(Dictionary<string,double> dictionary)
        {
            foreach (KeyValuePair<string, double> entry in dictionary)
            {
                string barcode = entry.Key;
                double piece = entry.Value;
                string inventory;
                //stoktan azaltma için
                string query1 = "select stok,id from urunler where barcode = '"+ barcode + "'";
                MySqlCommand mySqlCommand = new MySqlCommand(query1, mySqlConnection);
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                mySqlDataReader.Read();
                inventory = mySqlDataReader.GetString(0);
                mySqlDataReader.Close();
                runNonQuery("update urunler set stok = '" + (float.Parse(inventory) - piece).ToString("0.00") + "' where barcode = '" + barcode + "'");
            }
        }
        public string GetBarcodeCode(string query) 
        {
            return getID(query);
        }
        public List<UrunlerMapping> GetTurnoverbyDay(int day)
        {
            List<UrunlerMapping> urunlerMappingList = new List<UrunlerMapping>();
            UrunlerMapping urunlerMapping;
            string query = "select urunler.id,isim,sum(adet),fiyat from urunler,urun_adet where ciro_id = (select id from cirolar order by id desc limit "+day+") group by urunler.id";
            MySqlCommand mySqlCommand = new MySqlCommand(query, mySqlConnection);
            MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();

            //try
            //{
                while (mySqlDataReader.Read())
                {
                    urunlerMapping = new UrunlerMapping();
                    urunlerMapping.id = int.Parse(mySqlDataReader.GetString(0));
                    urunlerMapping.isim = mySqlDataReader.GetString(1);
                    urunlerMapping.adet = mySqlDataReader.GetString(2);
                    urunlerMapping.fiyat = mySqlDataReader.GetString(3);
                    urunlerMappingList.Add(urunlerMapping);
                }
            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("Ürünler getirilirken bir hata oluştu");
            //}
            mySqlDataReader.Close();
            return urunlerMappingList;
        }
        public void addShopping(string barcode) 
        {
            try
            {
                runNonQuery("insert into alisverisler(barcode) values ('" + barcode + "')");
            }
            catch (Exception)
            {
                MessageBox.Show("Alışveriş Eklenirken Bir Hata Oluştu.");
            }
        }
        //güne başla butonuna tıklandığında çalışacak
        public void addTurnover()
        {
            string date = getID("select date from cirolar order by id desc limit 1");
            try
            {
                if (date == DateTime.Now.ToString("dd.MM.yyyy"))
                {
                    MessageBox.Show("Tarih Mevcuttur.");
                }
                else 
                {
                    runNonQuery("insert into cirolar(date) values('" + DateTime.Now.ToString("dd.MM.yyyy") + "')");
                    MessageBox.Show("Gün başarıyla eklendi.");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Gün eklenirken bir hata oluştu.");
            }
            
        }
        //ürün_adet tablosuna veri ekleme
        public void addUrun_Adet(string shoppingID, string productID, string piece, string turnoverID)
        {
            try
            {
                runNonQuery("insert into urun_adet(alisveris_id,urun_id,adet,ciro_id) values('" + shoppingID + "','" + productID + "','" + piece + "','" + turnoverID + "')");
            }
            catch (Exception)
            {
                MessageBox.Show("Urun_Adet eklenirken hata oluştu.");
            }
            
        }
        public string getShoppingID(string barcode)
        {
            return getID("select id from alisverisler where barcode = ('" + barcode + "')");
        }
        //urun_adet tablosuna urun eklerken gerekli
        public string getTurnoverID()
        {
            return getID("select id from cirolar order by id desc limit 1");
        }
        public string getProductID(string barcode) 
        {
            return getID("select id from urunler where barcode = '" + barcode + "'");
        }

        public List<UrunlerMapping> readReceipt(string barcode) 
        {
            Database dbConnection = new Database();
            List<UrunlerMapping> urunlerMappingList = new List<UrunlerMapping>();
            UrunlerMapping urunlerMapping;
            string query1 = "select urun_id,adet from urun_adet where alisveris_id = '" + getShoppingID(barcode) + "'";
            string productBarcode;
            MySqlCommand mySqlCommand = new MySqlCommand(query1, mySqlConnection);
            MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
            try
            {
                while (mySqlDataReader.Read())
                {
                    urunlerMapping = new UrunlerMapping();
                    dbConnection.Baglan();
                    productBarcode = dbConnection.getID("select barcode from urunler where id = '"+mySqlDataReader.GetString(0)+"'");
                    urunlerMapping = dbConnection.ReturnProduct(productBarcode);
                    urunlerMapping.adet = mySqlDataReader.GetString(1);
                    urunlerMappingList.Add(urunlerMapping);
                    dbConnection.BaglantiyiKes();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Fiş okutulurken bir hata oluştu");
            }
            return urunlerMappingList;
        }
        //tekrar eden kod satırlarını önlemek için
        public string getID(string query) 
        {
            string value = "";
            try
            {
                MySqlCommand mySqlCommand = new MySqlCommand(query, mySqlConnection);
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                if (mySqlDataReader.Read())
                {
                    value = mySqlDataReader.GetString(0);
                }
                mySqlDataReader.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("ID alınırken bir hata oluştu.");
            }
            return value;
        }
        //tekrar edern satırları önlemek için
        public void runNonQuery(string query) 
        {
                MySqlCommand mySqlCommand = new MySqlCommand(query, mySqlConnection);
                mySqlCommand.ExecuteNonQuery();
        }
    }
}
