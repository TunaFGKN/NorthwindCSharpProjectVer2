using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages // Static classları newlemeye gerek kalmaz
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        internal static string ProductsListed = "Ürünler listelendi";
        internal static string ProductUpdated = "Ürün güncellendi";
        internal static string ProductCategoryCountError = "Bu kategoride max 10 ürün olabilir";
        internal static string ProductNameNotUnique = "Product name is not unique";
        internal static string CategoryLimitExceded = "Kategori limiti aşıldı";
        internal static string AuthorizationDenied = "Yetkiniz yok!";
    }
}
