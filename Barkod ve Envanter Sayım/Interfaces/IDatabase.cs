using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barkod_ve_Envanter_Sayım.Classes
{
    interface IDatabase
    {
        void Baglan();
        void BaglantiyiKes();
        void AddProduct(UrunlerMapping urunlerMapping);
        void DeleteProduct(string productBarcode);
        void EditProduct(UrunlerMapping urunlerMapping);
        UrunlerMapping ReturnProduct(string barcode);
        List<UrunlerMapping> ShowInventory();
        void ReduceInventory(Dictionary<string, double> dictionary);
        string GetBarcodeCode(string query);
        List<UrunlerMapping> GetTurnoverbyDay(int day);
        void addShopping(string barcode);
        string getShoppingID(string barcode);
        string getTurnoverID();
        void addTurnover();
        void addUrun_Adet(string shoppingID, string productID, string piece, string turnoverID);
        string getProductID(string barcode);

    }
}
