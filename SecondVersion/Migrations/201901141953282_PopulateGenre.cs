namespace SecondVersion.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenre : DbMigration
    {
        public override void Up()
        {
            Sql("Set Identity_Insert Genres ON");
            Sql("Insert into Genres (Id , MovieType) Values (1 , 'Action')");
            Sql("Insert into Genres (Id , MovieType) Values (2, 'Comdey')");
            Sql("Insert into Genres (Id , MovieType) Values (3, 'Useless')");

        }

        public override void Down()
        {
        }
    }
}
