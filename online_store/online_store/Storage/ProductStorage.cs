using online_store.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace online_store.Storage
{
    static class ProductStorage
    {
        public static List<Product> Products { get; set; }
        //public static List<Product> Products { get; set; } = new List<Product>()
        //{
        //    new Product( 1,"Телевизор LG 49UM7020 49",1225.99,0,"-Resolution: 4K UHD (3840x2160)\n-HDR Screen diagonal: 55"),
        //    new Product(2,"Смартфон Apple iPhone 11 128GB",1799.99,17,"-Screen: 6.1 (1792x828)\n-Built -in memory: 128 GB"),
        //    new Product(3,"Смартфон Apple iPhone 11 64GB",1499.99,52,"-Screen: 6.1 (1792x828)\n-Built -in memory: 64 GB"),
        //    new Product(4,"Смартфон Apple iPhone 12 128GB ",3899.99,62,"-Screen: 6.1 (2532x1170)\n-Built -in memory: 128 GB"),
        //    new Product(5,"Смартфон Apple iPhone 12 64GB",2544.99,7,"-Screen: 6.1 (2532x1170)\n-Built -in memory: 64 GB"),
        //    new Product(6,"Смартфон Apple iPhone 13 PRO 128 ГБ",4250.99,0,"-Screen: 6.1 (2532x1170)\n-Built -in memory: 128 GB"),
        //    new Product(7,"Стиральная машина с сушкой LG ",1343.99,22,"-Installation: stand-alone\n-Loading: 7 kg"),
        //    new Product(8,"Стиральная машина с сушкой Weissgauff",1599.99,37,"-Installation: stand-alone\n-Loading: 9 kg"),
        //    new Product(9,"Стиральная машина с сушкой Samsung",1543.99,46,"-Installation: stand-alone\n-Loading: 9 kg"),
        //    new Product(10,"Холодильник Hotpoint-Ariston HTR 4180 M",1543.99,34,"-Total volume: 298 liters\n-Refrigerator capacity: 220 liters"),
        //    new Product(11,"Видеокарта GIGABYTE GeForce RTX 3060 ",3100.0,15,"-Core/memory frequency: 1837 MHz/15000 MHz\n-Video memory capacity: 12288 MB GDDR6"),
        //    new Product(12,"Видеокарта AFOX Radeon RX 560 4GB",699.99,35,"-Core/memory frequency: 1830 MHz/8002 MHz\n-Video memory capacity: 6144 MB GDDR5"),
        //    new Product(13,"Ноутбук Apple MacBook Air 13 Late",2744.99,1,"-Screen: 13.3(1024x768)\n-IPSprocessor: Apple M1(8x3.20 GHz)"),
        //    new Product(14,"Ноутбук Lenovo IdeaPad 3 15ADA05",810.0,75,"-Screen: 14(1920x1080)\n-IPSprocessor: Intel Core i3 1115G4(2x3 GHz)"),
        //    new Product(15,"Умный браслет Xiaomi Mi Smart Band 6",89.99,7,"-Screen: 1.56(152x486) AMOLED\n-Compatibility: iOS,Android"),
        //    new Product(16,"Умные часы Apple Watch Series 6 ",999.99,0,"-Compatibility: iOS\n-Water resistance: WR50(5 atm)")
        //};
    }
}
