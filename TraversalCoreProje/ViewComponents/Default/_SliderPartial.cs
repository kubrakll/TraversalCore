using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace TraversalCoreProje.ViewComponents.Default
{
    public class _SliderPartial : ViewComponent
    {
        //.net core da olan bir özellik IViewComponentResult
        //ViewCompenentlere direkt erişim sağlanamıyor.

        /*
        Yapısı itibariyle partial view, ihtiyacımızı büyük ölçüde gideren bir özellik olmasına rağmen server işlemlerine ihtiyaç duyulduğu noktada MVC paternine fazladan yük bindirmekte ve lüzumsuz bir maliyet israfına sebebiyet verebilmekte.MVC’de partial view’in bu yükünü ortadan kaldırabilmek için View Component yapıları bir alternatif olarak vardır.
        Yani herhangi bir server tabanlı işlemde olduğu gibi ufak bir veritabanı işleminde Controller’a bağlanma gereği duymaksızın direkt olarak ilgili katmana erişim sağlayarak işlemi gerçekleştirebilir ve sonuç alabilirz.
         */

        public IViewComponentResult Invoke()
        {
            return View();
        }

    }
}
