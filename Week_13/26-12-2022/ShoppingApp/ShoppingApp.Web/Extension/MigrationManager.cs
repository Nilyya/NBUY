﻿using Microsoft.EntityFrameworkCore;
using ShoppingApp.Data.Concrete.EfCore.Contexts;

namespace ShoppingApp.Web.Extansion
{
    public static class MigrationManager
    {
        public static IHost UpdateDatabase(this IHost host)
        {
            using (var scope = host.Services.CreateScope())
            {
                using (var shopAppContext = scope.ServiceProvider.GetRequiredService<ShopAppContext>())
                {
                    try
                    {
                        shopAppContext.Database.Migrate();//Bu komut henüz işlenmemiş migration alır ve database update işlemine tabi tutar
                    }
                    catch (Exception)
                    {
                        //Hataların tutulduğu loglar burada hazırlanabilir.
                        throw;
                    }
                }
            }
            return host;
        }
    }
}
