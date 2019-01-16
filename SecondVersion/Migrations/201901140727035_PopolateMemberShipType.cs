namespace SecondVersion.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopolateMemberShipType : DbMigration
    {
        public override void Up()
        {
            Sql("Set Identity_insert MemberShipTypes  ON");
            Sql("insert into MemberShipTypes (Id , SignUpFee , DurationInMonths , DiscountRate) VALUES (1,20,1,0)");
            Sql("insert into MemberShipTypes (Id , SignUpFee , DurationInMonths , DiscountRate) VALUES (2,50,3,10)");
            Sql("insert into MemberShipTypes (Id , SignUpFee , DurationInMonths , DiscountRate) VALUES (3,100,6,15)");
            Sql("insert into MemberShipTypes (Id , SignUpFee , DurationInMonths , DiscountRate) VALUES (4,200,12,20)");
        }
        
        public override void Down()
        {
        }
    }
}
