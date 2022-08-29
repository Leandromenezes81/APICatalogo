using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APICatalogo.Migrations
{
    public partial class PopulaCategorias : Migration
    {
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("INSERT INTO Categorias(Nome, ImagemUrl) Values ('Bebidas', 'bebidas.jpg')");
            mb.Sql("INSERT INTO Categorias(Nome, ImagemUrl) Values ('Lanches', 'lanches.jpg')");
            mb.Sql("INSERT INTO Categorias(Nome, ImagemUrl) Values ('Sobremesas', 'sobremesas.jpg')");
        }

        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("DELETE FROM Categorias");
        }
    }
}
