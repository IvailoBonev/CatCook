﻿// <auto-generated />
using System;
using CatCook.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CatCook.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20241217221508_Seed")]
    partial class Seed
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CatCook.Infrastructure.Data.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("AvatarImageUrl")
                        .HasMaxLength(800)
                        .HasColumnType("nvarchar(800)")
                        .HasComment("The user avatar image");

                    b.Property<string>("City")
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)")
                        .HasComment("The city of the user");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(35)
                        .HasColumnType("nvarchar(35)")
                        .HasComment("The user's first name");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)")
                        .HasComment("The user's last name");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<int>("Points")
                        .HasColumnType("int")
                        .HasComment("How many cooking points does the user have");

                    b.Property<string>("ProfileName")
                        .IsRequired()
                        .HasMaxLength(18)
                        .HasColumnType("nvarchar(18)")
                        .HasComment("The user's profile name");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .HasMaxLength(120)
                        .HasColumnType("nvarchar(120)")
                        .HasComment("The user's status for today");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "0464d803-7820-4ec4-bb42-d75b5a1fcb7c",
                            AccessFailedCount = 0,
                            City = "Sofia",
                            ConcurrencyStamp = "c3edc41a-3689-4022-afa9-722be079c3ba",
                            Email = "guest@mail.com",
                            EmailConfirmed = false,
                            FirstName = "Guest",
                            LastName = "User",
                            LockoutEnabled = false,
                            NormalizedEmail = "guest@mail.com",
                            NormalizedUserName = "guest@mail.com",
                            PasswordHash = "AQAAAAIAAYagAAAAEIwnJGGawB1s3QFVbTuszjaRZUz95fnQREjdZu3mPNH7T/N5SvADFGyD6/z+sGSusg==",
                            PhoneNumberConfirmed = false,
                            Points = 0,
                            ProfileName = "Guest",
                            SecurityStamp = "22450535-0a36-4d37-8cb3-265411165548",
                            TwoFactorEnabled = false,
                            UserName = "guest@mail.com"
                        },
                        new
                        {
                            Id = "36998a40-6007-4cea-ac6e-c191880fa9e8",
                            AccessFailedCount = 0,
                            City = "Burgas",
                            ConcurrencyStamp = "7acca806-700c-4041-ab04-916c07f47b34",
                            Email = "ivan.georgiev@example.com",
                            EmailConfirmed = false,
                            FirstName = "Ivan",
                            LastName = "Georgiev",
                            LockoutEnabled = false,
                            NormalizedEmail = "ivan.georgiev@example.com",
                            NormalizedUserName = "ivan.georgiev@example.com",
                            PasswordHash = "AQAAAAIAAYagAAAAEPEmx5VjFuisLxeyv7/fo5ZhvcI1RYIXNA0cABIzy4IKUMapqHyuywM5r2Gw8d1oVw==",
                            PhoneNumberConfirmed = false,
                            Points = 0,
                            ProfileName = "Ivan_G",
                            SecurityStamp = "14e79d07-b43a-4a7b-bab5-aebacb4e78f9",
                            TwoFactorEnabled = false,
                            UserName = "ivan.georgiev@example.com"
                        });
                });

            modelBuilder.Entity("CatCook.Infrastructure.Data.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasComment("Category identifier");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)")
                        .HasComment("Category name");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Предястия"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Салати"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Торти"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Риба"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Сладкиши"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Основно"
                        });
                });

            modelBuilder.Entity("CatCook.Infrastructure.Data.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasComment("Comment identifier");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateAdded")
                        .HasColumnType("datetime2");

                    b.Property<int>("ForumId")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit")
                        .HasComment("Is the comment deleted (soft delete)");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasMaxLength(1400)
                        .HasColumnType("nvarchar(1400)")
                        .HasComment("The comment content");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasComment("Title of comment");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("ForumId");

                    b.HasIndex("UserId");

                    b.ToTable("Comments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DateAdded = new DateTime(2024, 12, 18, 0, 15, 7, 418, DateTimeKind.Local).AddTicks(6243),
                            ForumId = 1,
                            IsDeleted = false,
                            Text = "You might want to add a dash of Worcestershire sauce—it enhances the umami without overpowering. For balance, try adjusting the lemon juice and Parmesan quantities. Also, emulsifying the dressing with a blender can help achieve a smooth, creamy texture. Let us know how it turns out!",
                            Title = "Try Adding Worcestershire Sauce",
                            UserId = "0464d803-7820-4ec4-bb42-d75b5a1fcb7c"
                        },
                        new
                        {
                            Id = 2,
                            DateAdded = new DateTime(2024, 12, 18, 0, 15, 7, 418, DateTimeKind.Local).AddTicks(6958),
                            ForumId = 2,
                            IsDeleted = false,
                            Text = "Using a water bath can really help with preventing cracks and keeping the texture smooth. Wrap your springform pan in foil to avoid leaks, and bake it in a roasting pan with hot water. Also, don’t overmix the batter, as that can introduce air bubbles. Good luck with your cheesecake!",
                            Title = "Might have a solution",
                            UserId = "0464d803-7820-4ec4-bb42-d75b5a1fcb7c"
                        });
                });

            modelBuilder.Entity("CatCook.Infrastructure.Data.Difficulty", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasComment("Difficulty identifier");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)")
                        .HasComment("The name of the difficulty");

                    b.HasKey("Id");

                    b.ToTable("Difficulties");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Лесно"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Средно"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Трудно"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Много трудно"
                        });
                });

            modelBuilder.Entity("CatCook.Infrastructure.Data.Forum", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasComment("Forum identifier");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateAdded")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit")
                        .HasComment("Is the forum deleted (soft delete)");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasMaxLength(1500)
                        .HasColumnType("nvarchar(1500)")
                        .HasComment("The content of the forum");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasComment("The title of the forum");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Forums");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DateAdded = new DateTime(2024, 12, 18, 0, 15, 7, 419, DateTimeKind.Local).AddTicks(812),
                            IsDeleted = false,
                            Text = "Hi everyone! I'm trying to make a classic Caesar salad at home, but I’m struggling with the dressing. My main issue is getting the right balance of flavors—it’s either too tangy or too mild. I’m using anchovies, garlic, Dijon mustard, olive oil, lemon juice, and Parmesan, but something feels off. Should I adjust the ratios, or am I missing a key ingredient? Also, any tips for getting the texture just right? Thanks in advance!",
                            Title = "Need Help Perfecting My Caesar Salad Dressing!",
                            UserId = "36998a40-6007-4cea-ac6e-c191880fa9e8"
                        },
                        new
                        {
                            Id = 2,
                            DateAdded = new DateTime(2024, 12, 18, 0, 15, 7, 419, DateTimeKind.Local).AddTicks(1246),
                            IsDeleted = false,
                            Text = "Hey yall! I’m trying to make a classic cheesecake, but I’m running into a few issues. My main problem is getting the texture right—it’s either too dense or ends up cracking on top. I’m using cream cheese, eggs, sugar, and a graham cracker crust. Should I adjust baking time or temperature? Also, do I need to use a water bath, or is there another trick to keep it smooth? Any advice would be greatly appreciated. Thanks!",
                            Title = "Help Needed with Cheesecake Recipe!",
                            UserId = "36998a40-6007-4cea-ac6e-c191880fa9e8"
                        });
                });

            modelBuilder.Entity("CatCook.Infrastructure.Data.Recipe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasComment("Recipe identifier");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateAdded")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descipriton")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasComment("A description of the recipe");

                    b.Property<int>("DifficultyId")
                        .HasColumnType("int");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasComment("Images used for the recipe");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit")
                        .HasComment("Is the recipe deleted (soft delete)");

                    b.Property<bool>("IsPrivate")
                        .HasColumnType("bit")
                        .HasComment("Is the recipe private or public");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(90)
                        .HasColumnType("nvarchar(90)")
                        .HasComment("The recipe name");

                    b.Property<int>("PortionsCount")
                        .HasColumnType("int")
                        .HasComment("How many portions the recipe provides");

                    b.Property<double>("Rating")
                        .HasPrecision(18, 2)
                        .HasColumnType("float(18)")
                        .HasComment("The ratings of the recipe by users");

                    b.Property<int>("TimeForCooking")
                        .HasColumnType("int")
                        .HasComment("Time needed for cooking");

                    b.Property<int>("TimeForPreparation")
                        .HasColumnType("int")
                        .HasComment("Time needed for preparation for cooking");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("DifficultyId");

                    b.HasIndex("UserId");

                    b.ToTable("Recipes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 2,
                            DateAdded = new DateTime(2024, 12, 18, 0, 15, 7, 414, DateTimeKind.Local).AddTicks(6364),
                            Descipriton = "A Caesar salad is a timeless dish known for its crisp romaine, creamy dressing, and bold flavors. Here’s how to make it step-by-step:\r\n\r\n    Prepare the Croutons: Preheat your oven to 375°F. Cut a baguette or bread into small cubes, toss with olive oil, garlic powder, and a pinch of salt, then bake for 10-15 minutes until golden and crispy.\r\n\r\n    Make the Dressing: In a bowl, whisk together 1 minced garlic clove, 2 anchovy fillets (mashed), 1 teaspoon Dijon mustard, 1 tablespoon fresh lemon juice, and 1 teaspoon Worcestershire sauce. Slowly whisk in ½ cup olive oil until emulsified. Stir in ½ cup grated Parmesan cheese for a creamy texture. Adjust seasoning with salt and pepper to taste.\r\n\r\n    Assemble the Salad: Wash and dry fresh romaine lettuce, then tear it into bite-sized pieces. Toss the lettuce with the dressing until evenly coated.\r\n\r\n    Add Toppings: Top with the homemade croutons and more grated Parmesan cheese for a finishing touch.\r\n\r\nServe immediately for the best texture and flavor. This classic Caesar salad pairs wonderfully with grilled chicken, shrimp, or as a standalone starter. Enjoy your fresh and flavorful creation!",
                            DifficultyId = 2,
                            ImageUrl = "https://natashaskitchen.com/wp-content/uploads/2019/01/Caesar-Salad-Recipe-3.jpg",
                            IsDeleted = false,
                            IsPrivate = false,
                            Name = "Classic Caesar Salad",
                            PortionsCount = 2,
                            Rating = 4.5,
                            TimeForCooking = 15,
                            TimeForPreparation = 10,
                            UserId = "36998a40-6007-4cea-ac6e-c191880fa9e8"
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 3,
                            DateAdded = new DateTime(2024, 12, 18, 0, 15, 7, 417, DateTimeKind.Local).AddTicks(479),
                            Descipriton = "Making a creamy, decadent cheesecake at home is easier than you think. Here’s a step-by-step guide to create the perfect cheesecake:\r\n\r\n    Prepare the Crust: Preheat your oven to 325°F. In a food processor, pulse 1 ½ cups of graham crackers with ¼ cup of sugar and ½ teaspoon of cinnamon. Add 6 tablespoons of melted butter and mix until combined. Press the mixture into the bottom of a greased 9-inch springform pan. Bake for 10 minutes, then set aside to cool.\r\n\r\n    Make the Filling: In a large mixing bowl, beat 4 packages (32 ounces) of cream cheese at room temperature until smooth. Add 1 cup of granulated sugar and beat until combined. Add 1 teaspoon of vanilla extract and 4 large eggs, one at a time, mixing well after each addition. Finally, blend in 1 cup of sour cream for richness.\r\n\r\n    Bake the Cheesecake: Pour the cream cheese mixture onto the cooled crust. Bake at 325°F for 55-60 minutes, or until the center is just set. Let it cool in the oven with the door slightly ajar for 1 hour, then refrigerate for at least 4 hours.\r\n\r\n    Serve: Top with fresh fruit, fruit compote, or a drizzle of caramel for extra flavor. Enjoy your homemade cheesecake!",
                            DifficultyId = 1,
                            ImageUrl = "https://natashaskitchen.com/wp-content/uploads/2019/01/Caesar-Salad-Recipe-3.jpg",
                            IsDeleted = false,
                            IsPrivate = false,
                            Name = "Classic Cheesecake",
                            PortionsCount = 0,
                            Rating = 4.7000000000000002,
                            TimeForCooking = 60,
                            TimeForPreparation = 20,
                            UserId = "36998a40-6007-4cea-ac6e-c191880fa9e8"
                        });
                });

            modelBuilder.Entity("CatCook.Infrastructure.Data.Tip", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateAdded")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit")
                        .HasComment("Is the tip deleted (soft delete)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Tips");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DateAdded = new DateTime(2024, 12, 18, 0, 15, 7, 417, DateTimeKind.Local).AddTicks(4582),
                            Description = "When cooking fish, lemons can be a game-changer for flavor! A great tip is to use lemon in layers throughout your cooking process. Start by marinating your fish with a mixture of lemon juice, olive oil, and your favorite herbs—this not only enhances the flavor but also tenderizes the fish.\r\n\r\nDuring cooking, add thin slices of lemon directly on top of the fish. This allows the zest and oils to seep in as it cooks, giving it a bright, citrusy aroma. Finally, finish with a squeeze of fresh lemon juice just before serving to add a vibrant, tangy kick.",
                            IsDeleted = false,
                            Title = "Elevate Your Fish Dishes with Lemon: A Simple Tip",
                            UserId = "36998a40-6007-4cea-ac6e-c191880fa9e8"
                        },
                        new
                        {
                            Id = 2,
                            DateAdded = new DateTime(2024, 12, 18, 0, 15, 7, 417, DateTimeKind.Local).AddTicks(4838),
                            Description = "Want to bake cupcakes that are fluffy, moist, and perfectly domed? Here's a simple tip: start with room-temperature ingredients. Let your eggs, butter, and milk sit out for about 30 minutes before mixing. This ensures the batter blends smoothly, creating a light and even texture.\r\n\r\nAnother key is not to overmix your batter—stop as soon as the ingredients are combined. Overmixing can make your cupcakes dense and tough. For beautifully domed tops, fill your liners about two-thirds full and bake at a slightly higher temperature (around 375°F) for the first 5 minutes, then reduce to 350°F to finish baking.",
                            IsDeleted = false,
                            Title = "The Secret to Perfect Cupcakes Every Time",
                            UserId = "36998a40-6007-4cea-ac6e-c191880fa9e8"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("CatCook.Infrastructure.Data.Comment", b =>
                {
                    b.HasOne("CatCook.Infrastructure.Data.Forum", "Forum")
                        .WithMany("Comments")
                        .HasForeignKey("ForumId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CatCook.Infrastructure.Data.ApplicationUser", "User")
                        .WithMany("Comments")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Forum");

                    b.Navigation("User");
                });

            modelBuilder.Entity("CatCook.Infrastructure.Data.Forum", b =>
                {
                    b.HasOne("CatCook.Infrastructure.Data.ApplicationUser", "User")
                        .WithMany("Forums")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("CatCook.Infrastructure.Data.Recipe", b =>
                {
                    b.HasOne("CatCook.Infrastructure.Data.Category", "Category")
                        .WithMany("Recipes")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CatCook.Infrastructure.Data.Difficulty", "Difficulty")
                        .WithMany("Recipes")
                        .HasForeignKey("DifficultyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CatCook.Infrastructure.Data.ApplicationUser", "User")
                        .WithMany("UserRecipes")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Difficulty");

                    b.Navigation("User");
                });

            modelBuilder.Entity("CatCook.Infrastructure.Data.Tip", b =>
                {
                    b.HasOne("CatCook.Infrastructure.Data.ApplicationUser", "User")
                        .WithMany("Tips")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("CatCook.Infrastructure.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("CatCook.Infrastructure.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CatCook.Infrastructure.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("CatCook.Infrastructure.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CatCook.Infrastructure.Data.ApplicationUser", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("Forums");

                    b.Navigation("Tips");

                    b.Navigation("UserRecipes");
                });

            modelBuilder.Entity("CatCook.Infrastructure.Data.Category", b =>
                {
                    b.Navigation("Recipes");
                });

            modelBuilder.Entity("CatCook.Infrastructure.Data.Difficulty", b =>
                {
                    b.Navigation("Recipes");
                });

            modelBuilder.Entity("CatCook.Infrastructure.Data.Forum", b =>
                {
                    b.Navigation("Comments");
                });
#pragma warning restore 612, 618
        }
    }
}
