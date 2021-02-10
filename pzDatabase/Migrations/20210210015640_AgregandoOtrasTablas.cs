using Microsoft.EntityFrameworkCore.Migrations;

namespace pzDatabase.Migrations
{
    public partial class AgregandoOtrasTablas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "tamanio",
                table: "pizza");

            migrationBuilder.DropColumn(
                name: "tipo",
                table: "pizza");

            migrationBuilder.DropColumn(
                name: "variedad",
                table: "pizza");

            migrationBuilder.RenameColumn(
                name: "precio",
                table: "pedido",
                newName: "estado");

            migrationBuilder.RenameColumn(
                name: "hora",
                table: "pedido",
                newName: "fecha");

            migrationBuilder.RenameColumn(
                name: "cliente",
                table: "pedido",
                newName: "nombreCliente");

            migrationBuilder.RenameColumn(
                name: "cantidadPizza",
                table: "pedido",
                newName: "demora");

            migrationBuilder.AddColumn<string>(
                name: "nombre",
                table: "pizza",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "precio",
                table: "pizza",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "detallePedidoid",
                table: "pedido",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "facturaid",
                table: "pedido",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "detallePedido",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    subtotal = table.Column<int>(type: "int", nullable: false),
                    idPizza = table.Column<int>(type: "int", nullable: false),
                    cantidad = table.Column<int>(type: "int", nullable: false),
                    tipo = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    tamaño = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_detallePedido", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "factura",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    formaDePago = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_factura", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ingrediente",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ingrediente", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ingredientepizza",
                columns: table => new
                {
                    ingredienteid = table.Column<int>(type: "int", nullable: false),
                    pizzaid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ingredientepizza", x => new { x.ingredienteid, x.pizzaid });
                    table.ForeignKey(
                        name: "FK_ingredientepizza_ingrediente_ingredienteid",
                        column: x => x.ingredienteid,
                        principalTable: "ingrediente",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ingredientepizza_pizza_pizzaid",
                        column: x => x.pizzaid,
                        principalTable: "pizza",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_pedido_detallePedidoid",
                table: "pedido",
                column: "detallePedidoid");

            migrationBuilder.CreateIndex(
                name: "IX_pedido_facturaid",
                table: "pedido",
                column: "facturaid");

            migrationBuilder.CreateIndex(
                name: "IX_ingredientepizza_pizzaid",
                table: "ingredientepizza",
                column: "pizzaid");

            migrationBuilder.AddForeignKey(
                name: "FK_pedido_detallePedido_detallePedidoid",
                table: "pedido",
                column: "detallePedidoid",
                principalTable: "detallePedido",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_pedido_factura_facturaid",
                table: "pedido",
                column: "facturaid",
                principalTable: "factura",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_pedido_detallePedido_detallePedidoid",
                table: "pedido");

            migrationBuilder.DropForeignKey(
                name: "FK_pedido_factura_facturaid",
                table: "pedido");

            migrationBuilder.DropTable(
                name: "detallePedido");

            migrationBuilder.DropTable(
                name: "factura");

            migrationBuilder.DropTable(
                name: "ingredientepizza");

            migrationBuilder.DropTable(
                name: "ingrediente");

            migrationBuilder.DropIndex(
                name: "IX_pedido_detallePedidoid",
                table: "pedido");

            migrationBuilder.DropIndex(
                name: "IX_pedido_facturaid",
                table: "pedido");

            migrationBuilder.DropColumn(
                name: "nombre",
                table: "pizza");

            migrationBuilder.DropColumn(
                name: "precio",
                table: "pizza");

            migrationBuilder.DropColumn(
                name: "detallePedidoid",
                table: "pedido");

            migrationBuilder.DropColumn(
                name: "facturaid",
                table: "pedido");

            migrationBuilder.RenameColumn(
                name: "nombreCliente",
                table: "pedido",
                newName: "cliente");

            migrationBuilder.RenameColumn(
                name: "fecha",
                table: "pedido",
                newName: "hora");

            migrationBuilder.RenameColumn(
                name: "estado",
                table: "pedido",
                newName: "precio");

            migrationBuilder.RenameColumn(
                name: "demora",
                table: "pedido",
                newName: "cantidadPizza");

            migrationBuilder.AddColumn<string>(
                name: "tamanio",
                table: "pizza",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "tipo",
                table: "pizza",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "variedad",
                table: "pizza",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
