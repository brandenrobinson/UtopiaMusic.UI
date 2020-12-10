using Microsoft.EntityFrameworkCore;

namespace UtopiaMusicAPI.Models
{
    public class UtopiaMusicContext : DbContext
    {
        public UtopiaMusicContext(DbContextOptions<UtopiaMusicContext> options) : base(options)
        {

        }
    }
}
