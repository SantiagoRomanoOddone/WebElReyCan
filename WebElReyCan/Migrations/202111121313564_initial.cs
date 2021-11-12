namespace WebElReyCan.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Turno",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Fecha = c.DateTime(nullable: false, storeType: "date"),
                        Hora = c.String(),
                        NombreMascota = c.String(nullable: false, maxLength: 50),
                        Raza = c.String(maxLength: 50),
                        Edad = c.Int(nullable: false),
                        NombreDueño = c.String(nullable: false, maxLength: 50),
                        Celular = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Turno");
        }
    }
}
