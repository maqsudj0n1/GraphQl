using GraphQl.Data;
using GraphQl.Services;
using Microsoft.EntityFrameworkCore;

namespace GraphQl
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddGraphQLServer().AddMutationType<MutationType>().AddQueryType(x=> x.Name("method")).AddType<Query>().AddType<QueryType>();
            builder.Services.AddDbContext<ApplicationDbContext>(context => context.UseNpgsql(builder.Configuration.GetConnectionString("DbConnection")));
            var app = builder.Build();

            app.MapGraphQL();

            app.Run();
        } 
    }
}