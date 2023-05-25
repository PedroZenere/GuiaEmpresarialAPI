using Microsoft.EntityFrameworkCore.Migrations;

namespace GuiaEmpresarialAPI.Data.Migrations
{
    public partial class AdicionaTabelaEstado : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Estados",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sigla = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estados", x => x.Id);
                });

            migrationBuilder.Sql(GetEstadoSqlInsert());
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Estados");
        }



        private static string GetEstadoSqlInsert()
        {
            return @"
INSERT INTO dbo.Estados ([Id], [Nome], [Sigla]) VALUES (11, N'RONDÔNIA', N'RO')
INSERT INTO dbo.Estados ([Id], [Nome], [Sigla]) VALUES (12, N'ACRE', N'AC')
INSERT INTO dbo.Estados ([Id], [Nome], [Sigla]) VALUES (13, N'AMAZONAS', N'AM')
INSERT INTO dbo.Estados ([Id], [Nome], [Sigla]) VALUES (14, N'RORAIMA', N'RR')
INSERT INTO dbo.Estados ([Id], [Nome], [Sigla]) VALUES (15, N'PARÁ', N'PA')
INSERT INTO dbo.Estados ([Id], [Nome], [Sigla]) VALUES (16, N'AMAPÁ', N'AP')
INSERT INTO dbo.Estados ([Id], [Nome], [Sigla]) VALUES (17, N'TOCANTINS', N'TO')
INSERT INTO dbo.Estados ([Id], [Nome], [Sigla]) VALUES (21, N'MARANHÃO', N'MA')
INSERT INTO dbo.Estados ([Id], [Nome], [Sigla]) VALUES (22, N'PIAUÍ', N'PI')
INSERT INTO dbo.Estados ([Id], [Nome], [Sigla]) VALUES (23, N'CEARÁ', N'CE')
INSERT INTO dbo.Estados ([Id], [Nome], [Sigla]) VALUES (24, N'RIO GRANDE DO NORTE', N'RN')
INSERT INTO dbo.Estados ([Id], [Nome], [Sigla]) VALUES (25, N'PARAÍBA', N'PB')
INSERT INTO dbo.Estados ([Id], [Nome], [Sigla]) VALUES (26, N'PERNAMBUCO', N'PE')
INSERT INTO dbo.Estados ([Id], [Nome], [Sigla]) VALUES (27, N'ALAGOAS', N'AL')
INSERT INTO dbo.Estados ([Id], [Nome], [Sigla]) VALUES (28, N'SERGIPE', N'SE')
INSERT INTO dbo.Estados ([Id], [Nome], [Sigla]) VALUES (29, N'BAHIA', N'BA')
INSERT INTO dbo.Estados ([Id], [Nome], [Sigla]) VALUES (31, N'MINAS GERAIS', N'MG')
INSERT INTO dbo.Estados ([Id], [Nome], [Sigla]) VALUES (32, N'ESPÍRITO SANTO', N'ES')
INSERT INTO dbo.Estados ([Id], [Nome], [Sigla]) VALUES (33, N'RIO DE JANEIRO', N'RJ')
INSERT INTO dbo.Estados ([Id], [Nome], [Sigla]) VALUES (35, N'SÃO PAULO', N'SP')
INSERT INTO dbo.Estados ([Id], [Nome], [Sigla]) VALUES (41, N'PARANÁ', N'PR')
INSERT INTO dbo.Estados ([Id], [Nome], [Sigla]) VALUES (42, N'SANTA CATARINA', N'SC')
INSERT INTO dbo.Estados ([Id], [Nome], [Sigla]) VALUES (43, N'RIO GRANDE DO SUL', N'RS')
INSERT INTO dbo.Estados ([Id], [Nome], [Sigla]) VALUES (50, N'MATO GROSSO DO SUL', N'MS')
INSERT INTO dbo.Estados ([Id], [Nome], [Sigla]) VALUES (51, N'MATO GROSSO', N'MT')
INSERT INTO dbo.Estados ([Id], [Nome], [Sigla]) VALUES (52, N'GOIÁS', N'GO')
INSERT INTO dbo.Estados ([Id], [Nome], [Sigla]) VALUES (53, N'DISTRITO FEDERAL', N'DF')
";
        }
    }
}
