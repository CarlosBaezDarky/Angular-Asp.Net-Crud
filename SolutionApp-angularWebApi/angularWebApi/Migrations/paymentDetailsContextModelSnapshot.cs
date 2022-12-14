// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using angularWebApi.Model;

namespace angularWebApi.Migrations
{
    [DbContext(typeof(paymentDetailsContext))]
    partial class paymentDetailsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("angularWebApi.Model.paymentDetails", b =>
                {
                    b.Property<int>("paymentDetail_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("CardNumber")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("CardOwerName")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("ExpirationDate")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("SecurityCode")
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("paymentDetail_Id");

                    b.ToTable("paymentDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
