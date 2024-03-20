using AutoMapper;
using IMobile.Business.Abstract;
using IMobile.Business.AutoMapper;
using IMobile.Business.Concrete;
using IMobile.DataAccess.Abstract;
using IMobile.DataAccess.Concrete.EntityFramework;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMobile.Business.DependencyResolver.DependencyRegister
{
    public static class ServiceRegisteration
    {
        public static void Create(this IServiceCollection services)
        {
            services.AddScoped<ICategoryService, CategoryManager>();
            services.AddScoped<ICategoryDal, EfCategoryDal>();

            services.AddScoped<IProductService, ProductManager>();
            services.AddScoped<IProductDal, EfProductDal>();

            services.AddScoped<ISpecificationService, SpecificationManager>();
            services.AddScoped<ISpecificationDal, EfSpecificationDal>();

            services.AddScoped<IAppUserService, AppUserManager>();
            services.AddScoped<IAppUserDal, EfAppUserDal>();

            //services.AddScoped<IDataSeeder, EfDataSeeder>();

            services.AddScoped<AppDbContext>();

            var mapperConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MappingProfile());
            });

            IMapper mapper = mapperConfig.CreateMapper();
            services.AddSingleton(mapper);
        }
    }
}
