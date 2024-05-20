

using library.DataAccess.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace library.DataAccess.Configurations
{
	public class BookConfiguration : IEntityTypeConfiguration<BookEntity>
	{
		public void Configure(EntityTypeBuilder<BookEntity> builder)
		{
			builder.HasKey(x => x.id);

			builder.Property(b => b.name)
				.HasMaxLength(50)
				.IsRequired();

			builder.Property(b => b.price)
				.IsRequired();

			builder.Property(b => b.shortDesc)
				.HasMaxLength(250)
				.IsRequired();

		}
	}
}
