// See https://aka.ms/new-console-template for more information
using Persistence;

Console.WriteLine("Hello, World!");

var dbContext = new ApplicationDbContext();

dbContext.Database.EnsureDeleted();
dbContext.Database.EnsureCreated();

