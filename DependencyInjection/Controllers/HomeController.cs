﻿using DependencyInjection.Infrastructure;
using DependencyInjection.Models;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjection.Controllers
{
    public class HomeController : Controller
    {
        public IRepository Repository { get; } = TypeBroker.Repository;
        public ViewResult Index() => View(Repository.Products);
    }
}
