using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Yakuniy.Domain.Contexts;

namespace Yakuniy.Infrastract.EntityTypeConfigurations;

public class StudentConfiguration : IEntityTypeConfiguration<Student>
{
    public void Configure(EntityTypeBuilder<Student> builder)
    {
        builder.ToTable("Student");

        builder.HasKey(student => student.Id);

        builder
            .Property(student => student.FirstName)
            .HasMaxLength(50)
            .IsRequired(false);

        builder
            .Property(student => student.Pasword)
            .HasMaxLength(10)
            .IsRequired(true);
        builder
            .Property(student => student.emile)
            .HasMaxLength(50)
            .IsRequired(true);


        builder
            .Property(student => student.LastName)
            .HasMaxLength(20)
            .IsRequired(true);

        builder
            .Property(student => student.Cours)
            .IsRequired(true);

        builder
            .Property(student => student.Salt);
            

        

    }
}
