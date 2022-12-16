using Microsoft.EntityFrameworkCore;



namespace CV_Projektet.Models;
public class dataBaseContext : DbContext
{

    public dataBaseContext(DbContextOptions<dataBaseContext> options) : base(options)
    {

    }
}

