using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;
using DataLayer.Entities;
using DataLayer.UnitOfWork;
using DataLayer.Repository;
using AutoMapper;

namespace Your_WareHouse;

public class Program
{
    [STAThread]
    public static void Main()
    {
        // создаем хост приложения
        var host = Host.CreateDefaultBuilder()
            // внедряем сервисы
            .ConfigureServices(services =>
            {
                services.AddSingleton<App>();
                services.AddSingleton<MainWindow>();

                var mapperConfig = new MapperConfiguration(conf =>
                {
                    conf.AddProfile(new AppMappingProfile());
                });

                services.AddSingleton<IMapper>(sp => new Mapper(mapperConfig));

                services.AddScoped<IUnitOfWork, UnitOfWork>();
                services.AddScoped<IRepository<Entity>, Repository<Entity>>();

            })
            .Build();

        
        // получаем сервис - объект класса App
        var app = host.Services.GetService<App>();
        // запускаем приложения

        app?.Run();
    }
}
