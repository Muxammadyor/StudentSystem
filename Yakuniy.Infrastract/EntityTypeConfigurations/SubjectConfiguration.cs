using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Yakuniy.Domain.Contexts;

namespace Yakuniy.Infrastract.EntityTypeConfigurations;

public class SubjectConfiguration : IEntityTypeConfiguration<Subject>
{
    public void Configure(EntityTypeBuilder<Subject> builder)
    {
        builder.ToTable("Subject");

        builder.HasKey(subject => subject.Id);

        builder
            .Property(subject => subject.SubjectName)
            .HasMaxLength(20)
            .IsRequired(true);
        builder
            .Property(subject => subject.Credit)
            .IsRequired(true);

        builder.HasMany(subject => subject.Students)
            .WithOne(student => student.Subject)
            .HasForeignKey(student => student.Id);

    }
}
