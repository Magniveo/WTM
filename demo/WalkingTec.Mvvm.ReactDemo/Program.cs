using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.SpaServices.ReactDevelopmentServer;
using Microsoft.Extensions.DependencyInjection;
using Swashbuckle.AspNetCore.Swagger;
using System.Collections.Generic;
using WalkingTec.Mvvm.ReactDemo.Models;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Mvc;
using WalkingTec.Mvvm.TagHelpers.LayUI;
using Microsoft.OpenApi.Models;

namespace WalkingTec.Mvvm.ReactDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .ConfigureServices(x =>
                {
                    var pris = new List<IDataPrivilege>
                        {
                            new DataPrivilegeInfo<FrameworkRole>("测试角色", y => y.RoleName),
                        };
                    x.AddFrameworkService(dataPrivilegeSettings: pris);
                    x.AddLayui();
                    x.AddSwaggerGen(c =>
                    {
                        c.SwaggerDoc("v1", new OpenApiInfo{ Title = "My API", Version = "v1" });
                        c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme()
                        {
                            Description = "JWT Bearer",
                            Name = "Authorization",
                            In = ParameterLocation.Header,
                            Type = SecuritySchemeType.ApiKey,
                        });
                        c.AddSecurityRequirement(new OpenApiSecurityRequirement
                        {
                            {
                                new OpenApiSecurityScheme
                                {
                                    Reference = new OpenApiReference
                                    {
                                        Type = ReferenceType.SecurityScheme,
                                        Id = "Bearer"
                                    }
                                }, new List<string>()
                            }
                        });
                        //c.AddSecurityRequirement(new Dictionary<string, IEnumerable<string>>
                        //    {
                        //        { "Bearer", new string[] { } }
                        //    });
                    });
                    x.AddMvc(option => option.EnableEndpointRouting = false);
                    //x.AddControllers();
                    x.AddSpaStaticFiles(configuration =>
                    {
                        configuration.RootPath = "ClientApp/build";
                    });
                })
                .Configure(x =>
                {
                    var env = x.ApplicationServices.GetService<IHostingEnvironment>();
                    x.UseSwagger();
                    x.UseSwaggerUI(c =>
                    {
                        c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
                    });
                    x.UseSpaStaticFiles();
                    x.UseFrameworkService();
                    x.UseSpa(spa =>
                    {
                        spa.Options.SourcePath = "ClientApp";                        
                        if (env.IsDevelopment())
                        {
                            spa.UseReactDevelopmentServer(npmScript: "start");
                        }
                    });

                })
                .Build();

    }
}
