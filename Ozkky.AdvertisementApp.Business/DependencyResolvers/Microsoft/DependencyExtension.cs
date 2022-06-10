using AutoMapper;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Ozkky.AdvertisementApp.Business.Interfaces;
using Ozkky.AdvertisementApp.Business.Mappings;
using Ozkky.AdvertisementApp.Business.Mappings.AutoMapper;
using Ozkky.AdvertisementApp.Business.Services;
using Ozkky.AdvertisementApp.Business.ValidationRules;
using Ozkky.AdvertisementApp.DataAccess.Contexts;
using Ozkky.AdvertisementApp.DataAccess.UnitOfWork;
using Ozkky.AdvertisementApp.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.AdvertisementApp.Business.Services;

namespace Ozkky.AdvertisementApp.Business.DependencyResolvers.Microsoft
{
    public static class DependencyExtension
    {
        public static void AddDependencies(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AdvertisementContext>(opt =>
            {
                opt.UseSqlServer(configuration.GetConnectionString("Local"));
            });

            var mapperConfiguration = new MapperConfiguration(opt =>
              {
                  opt.AddProfile(new ProvidedServiceProfile());
                  opt.AddProfile(new AdvertisementProfile());
              });

            var mapper = mapperConfiguration.CreateMapper();
            services.AddSingleton(mapper);

            services.AddScoped<IUow, Uow>();

            services.AddTransient<IValidator<ProvidedServiceCreateDto>, ProvidedServiceCreateDtoValidator>();
            services.AddTransient<IValidator<ProvidedServiceUpdateDto>, ProvidedServiceUpdateDtoValidator>();
            services.AddTransient<IValidator<AdvertisementCreateDto>, AdvertisementCreateDtoValidator>();
            services.AddTransient<IValidator<AdvertisementUpdateDto>, AdvertisementUpdateDtoValidator>();


            services.AddScoped<IProvidedServiceService, ProvidedServiceService>();
            services.AddScoped<IAdvertisementService, AdvertisementService>();
        }
    }
}
