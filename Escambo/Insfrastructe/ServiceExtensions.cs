namespace Escambo.Pesistence.Infrastructe;

public static class ServiceExtensions{
    public static  void ConfigurePersistenceEscambo(this IServiceCollection services, IConfiguration configuration){
        
        var connectionString = configuration.GetConnectionString("MySqlConnection");
        services.AddDbContext<EscamboDBContext>(options => options.UserMySql(connectionString));
        services.AddScoped<IUnitOfWork,UnitOfWork>();
    
    }
}