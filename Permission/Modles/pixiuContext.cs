using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage;

namespace Permission.Modles
{
    public partial class PixiuContext : DbContext
    {
        public PixiuContext()
        {
        }

        public PixiuContext(DbContextOptions<PixiuContext> options)
            : base(options)
        {
        }

        public virtual DbSet<PixiuGroup> PixiuGroup { get; set; }
        public virtual DbSet<PixiuGroupPermission> PixiuGroupPermission { get; set; }
        
        public virtual DbSet<PixiuPermission> PixiuPermission { get; set; }
        
        public virtual DbSet<PixiuRole> PixiuRole { get; set; }
        public virtual DbSet<PixiuRolePermission> PixiuRolePermission { get; set; }
        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseMySql("server=Localhost;uid=root;pwd=12345678;database=pixiu;TreatTinyAsBoolean=False;");
		}

	    public override DbSet<TEntity> Set<TEntity>()
	    {
		    return new MySqlInternalDbSet<TEntity>(this);
	    }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<PixiuGroup>(entity =>
            {
                entity.ToTable("pixiu_group");

                entity.HasIndex(e => e.GroupCode)
                    .HasName("group_code")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.DeletedAt).HasColumnName("deleted_at");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .HasColumnType("longtext");

                entity.Property(e => e.Extra01)
                    .IsRequired()
                    .HasColumnName("extra_01")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Extra02)
                    .IsRequired()
                    .HasColumnName("extra_02")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Extra03)
                    .IsRequired()
                    .HasColumnName("extra_03")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Extra04)
                    .IsRequired()
                    .HasColumnName("extra_04")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.GroupCode)
                    .IsRequired()
                    .HasColumnName("group_code")
                    .HasColumnType("varchar(128)");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("is_deleted")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
            });

            modelBuilder.Entity<PixiuGroupPermission>(entity =>
            {
                entity.ToTable("pixiu_group_permission");

                entity.HasIndex(e => e.GroupCode)
                    .HasName("pixiu_group_permission_group_code_d97b8fad");

                entity.HasIndex(e => e.PermissionCode)
                    .HasName("pixiu_group_permission_permission_code_f0b9f4c2");

                entity.HasIndex(e => new { e.GroupCode, e.PermissionCode })
                    .HasName("pixiu_group_permission_group_code_permission_code_c0b04e8a_uniq")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.DeletedAt).HasColumnName("deleted_at");

                entity.Property(e => e.Extra01)
                    .IsRequired()
                    .HasColumnName("extra_01")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Extra02)
                    .IsRequired()
                    .HasColumnName("extra_02")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Extra03)
                    .IsRequired()
                    .HasColumnName("extra_03")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Extra04)
                    .IsRequired()
                    .HasColumnName("extra_04")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.GroupCode)
                    .IsRequired()
                    .HasColumnName("group_code")
                    .HasColumnType("varchar(128)");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("is_deleted")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.PermissionCode)
                    .IsRequired()
                    .HasColumnName("permission_code")
                    .HasColumnType("varchar(128)");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
            });

            modelBuilder.Entity<PixiuPermission>(entity =>
            {
                entity.ToTable("pixiu_permission");

                entity.HasIndex(e => e.PermissionCode)
                    .HasName("permission_code")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.DeletedAt).HasColumnName("deleted_at");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .HasColumnType("longtext");

                entity.Property(e => e.Extra01)
                    .IsRequired()
                    .HasColumnName("extra_01")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Extra02)
                    .IsRequired()
                    .HasColumnName("extra_02")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Extra03)
                    .IsRequired()
                    .HasColumnName("extra_03")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Extra04)
                    .IsRequired()
                    .HasColumnName("extra_04")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.HttpMethod)
                    .HasColumnName("http_method")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IsAllowAny)
                    .HasColumnName("is_allow_any")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("is_deleted")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.ParentPermissionCode)
                    .IsRequired()
                    .HasColumnName("parent_permission_code")
                    .HasColumnType("varchar(128)");

                entity.Property(e => e.PermissionCode)
                    .IsRequired()
                    .HasColumnName("permission_code")
                    .HasColumnType("varchar(128)");

                entity.Property(e => e.RoutePath)
                    .IsRequired()
                    .HasColumnName("route_path")
                    .HasColumnType("varchar(128)");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
            });

            modelBuilder.Entity<PixiuRole>(entity =>
            {
                entity.ToTable("pixiu_role");

                entity.HasIndex(e => e.GroupCode)
                    .HasName("pixiu_role_group_code_75ef92cb");

                entity.HasIndex(e => e.RoleCode)
                    .HasName("pixiu_role_role_code_0ad2ee32");

                entity.HasIndex(e => new { e.GroupCode, e.RoleCode })
                    .HasName("pixiu_role_group_code_role_code_d9b2003e_uniq")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.DeletedAt).HasColumnName("deleted_at");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .HasColumnType("longtext");

                entity.Property(e => e.Extra01)
                    .IsRequired()
                    .HasColumnName("extra_01")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Extra02)
                    .IsRequired()
                    .HasColumnName("extra_02")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Extra03)
                    .IsRequired()
                    .HasColumnName("extra_03")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Extra04)
                    .IsRequired()
                    .HasColumnName("extra_04")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.GroupCode)
                    .IsRequired()
                    .HasColumnName("group_code")
                    .HasColumnType("varchar(128)");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("is_deleted")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.RoleCode)
                    .IsRequired()
                    .HasColumnName("role_code")
                    .HasColumnType("varchar(128)");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
            });

            modelBuilder.Entity<PixiuRolePermission>(entity =>
            {
                entity.ToTable("pixiu_role_permission");

                entity.HasIndex(e => e.GroupCode)
                    .HasName("pixiu_role_permission_group_code_b84d982b");

                entity.HasIndex(e => e.PermissionCode)
                    .HasName("pixiu_role_permission_permission_code_3613d778");

                entity.HasIndex(e => e.RoleCode)
                    .HasName("pixiu_role_permission_role_code_cc7af8fa");

                entity.HasIndex(e => new { e.GroupCode, e.RoleCode, e.PermissionCode })
                    .HasName("pixiu_role_permission_group_code_role_code_per_35f7bd2c_uniq")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.DeletedAt).HasColumnName("deleted_at");

                entity.Property(e => e.Extra01)
                    .IsRequired()
                    .HasColumnName("extra_01")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Extra02)
                    .IsRequired()
                    .HasColumnName("extra_02")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Extra03)
                    .IsRequired()
                    .HasColumnName("extra_03")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Extra04)
                    .IsRequired()
                    .HasColumnName("extra_04")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.GroupCode)
                    .IsRequired()
                    .HasColumnName("group_code")
                    .HasColumnType("varchar(128)");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("is_deleted")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.PermissionCode)
                    .IsRequired()
                    .HasColumnName("permission_code")
                    .HasColumnType("varchar(128)");

                entity.Property(e => e.RoleCode)
                    .IsRequired()
                    .HasColumnName("role_code")
                    .HasColumnType("varchar(128)");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
            });

        }
    }

	public class MySqlInternalDbSet<TEntity> : InternalDbSet<TEntity> where TEntity : class
	{
		public MySqlInternalDbSet(DbContext context) : base(context)
		{
		}


		public TEntity SetDefaultValue(TEntity entity)
		{
			var typeProperties = entity.GetType().GetProperties();
			var propertyInfo = typeProperties.FirstOrDefault(e => e.Name == "CreatedAt");
			if (propertyInfo != null)
			{
				propertyInfo.SetValue(entity, DateTime.Now);
			}
			propertyInfo = typeProperties.FirstOrDefault(e => e.Name == "UpdatedAt");
			if (propertyInfo != null)
			{
				propertyInfo.SetValue(entity, DateTime.Now);
			}
			propertyInfo = typeProperties.FirstOrDefault(e => e.Name == "Extra01");
			if (propertyInfo != null)
			{
				propertyInfo.SetValue(entity, "");
			}
			propertyInfo = typeProperties.FirstOrDefault(e => e.Name == "Extra02");
			if (propertyInfo != null)
			{
				propertyInfo.SetValue(entity, "");
			}
			propertyInfo = typeProperties.FirstOrDefault(e => e.Name == "Extra03");
			if (propertyInfo != null)
			{
				propertyInfo.SetValue(entity, "");
			}
			propertyInfo = typeProperties.FirstOrDefault(e => e.Name == "Extra04");
			if (propertyInfo != null)
			{
				propertyInfo.SetValue(entity, "");
			}
			propertyInfo = typeProperties.FirstOrDefault(e => e.Name == "IsDeleted");
			if (propertyInfo != null)
			{
				propertyInfo.SetValue(entity, false);
			}
			propertyInfo = typeProperties.FirstOrDefault(e => e.Name == "DeletedAt");
			if (propertyInfo != null)
			{
				propertyInfo.SetValue(entity, null);
			}


			return entity;
		}

		public override EntityEntry<TEntity> Add(TEntity entity)
		{
			SetDefaultValue(entity);
			return base.Add(entity);
		}

		public override Task<EntityEntry<TEntity>> AddAsync(TEntity entity, CancellationToken cancellationToken = new CancellationToken())
		{
			SetDefaultValue(entity);
			return base.AddAsync(entity, cancellationToken);
		}

		public override void AddRange(IEnumerable<TEntity> entities)
		{
			foreach (var entity in entities)
			{
				SetDefaultValue(entity);
			}
			base.AddRange(entities);
		}

		public override void AddRange(params TEntity[] entities)
		{
			foreach (var entity in entities)
			{
				SetDefaultValue(entity);
			}
			base.AddRange(entities);
		}

		public override Task AddRangeAsync(IEnumerable<TEntity> entities, CancellationToken cancellationToken = new CancellationToken())
		{
			foreach (var entity in entities)
			{
				SetDefaultValue(entity);
			}
			return base.AddRangeAsync(entities, cancellationToken);
		}

		public override Task AddRangeAsync(params TEntity[] entities)
		{
			foreach (var entity in entities)
			{
				SetDefaultValue(entity);
			}
			return base.AddRangeAsync(entities);
		}
	}
}
