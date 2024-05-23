using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
    /// <summary>
    /// Bu sınıftan türeyen nesne; belirli bir formattaki Excel dosyasını PDF formatında rapora dönüştürür.
    /// </summary>
    public class Report
    {
        private string path;

        public Report(string path)
        {
            //1. path değeri boş olamaz.
            //2. path adresinde excel dosyası olmalı
            //3. path adresinde bulunan excel dosyasının fotmatı standart olmalı.

            checkRules(path);

            this.path = path;
        }

        private void checkRules(string path)
        {
            nullCheck(path);

            fileExistsCheck(path);

            formatAvailableCheck(path);
        }

        private void formatAvailableCheck(string path)
        {
            if (!isExcelFormatAvailable(path))
            {
                throw new Exception("Excel dosyası uygun formatta değil");
            }
        }

        private static void fileExistsCheck(string path)
        {
            if (!File.Exists(path))
            {
                throw new FileNotFoundException("Excel dosyası bulunamadı");
            }
        }

        private static void nullCheck(string path)
        {
            if (string.IsNullOrEmpty(path))
            {
                throw new ArgumentNullException(path);
            }
        }

        private bool isExcelFormatAvailable(string path)
        {
            return true;
        }

        /// <summary>
        /// Raporu oluşturma işlemini başlat
        /// </summary>
        public void Create()
        {

        }
    }
}
