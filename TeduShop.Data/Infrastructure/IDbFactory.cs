using System;

namespace TeduShop.Data.Infranstructure
{
    public interface IDbFactory : IDisposable
    {
        TeduShopDbContext Init();
    }
}