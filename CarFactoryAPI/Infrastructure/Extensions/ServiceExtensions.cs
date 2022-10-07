﻿using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Contracts.IServices;
using LoggerService;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Repository.Repositories;

namespace CarFactoryAPI.Infrastructure.Extensions
{
	public static class ServiceExtensions
	{
		public static void ConfigureCors(this IServiceCollection services) =>
		services.AddCors(options =>
		{
			options.AddPolicy("CorsPolicy", builder =>
			builder.AllowAnyOrigin()
					.AllowAnyMethod()
					.AllowAnyHeader());
		});
		public static void ConfigureLoggerService(this IServiceCollection services) => services.AddScoped<ILoggerManager, LoggerManager>();

		public static void ConfigureIISIntegration(this IServiceCollection services) =>
		 services.Configure<IISOptions>(options =>
		 {
		 });
		public static void ConfigureSqlContext(this IServiceCollection services, IConfiguration configuration) =>
						   services.AddDbContext<CarFactoryContext>(opts => opts.UseSqlServer(configuration.GetConnectionString("sqlConnection")));

		public static void ConfigureRepositoryManager(this IServiceCollection services) => services.AddScoped<IRepositoryManager, RepositoryManager>();

	}
}
