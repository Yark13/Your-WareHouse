﻿// <auto-generated />
using System;
using DataLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataLayer.Migrations
{
    [DbContext(typeof(StateDbContext))]
    [Migration("20231017071001_Update3_1")]
    partial class Update3_1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DataLayer.Entities.Article", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DatePublication")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Articles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Content = "A recent study published in a leading medical journal has highlighted the potential health benefits of consuming dark chocolate in moderation. The study found that dark chocolate, when consumed in appropriate amounts, could have a positive impact on heart health and may help reduce the risk of certain cardiovascular diseases.",
                            DatePublication = new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "New Research Reveals Surprising Benefits of Chocolate"
                        },
                        new
                        {
                            Id = 2,
                            Content = "Unprecedented rainfall in the coastal regions has led to severe flooding, displacing thousands of residents and causing significant damage to infrastructure. Emergency services are working tirelessly to rescue stranded individuals and provide relief to those affected by this natural disaster.",
                            DatePublication = new DateTime(2023, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Record-Breaking Rainfall Causes Flooding in Coastal Regions"
                        },
                        new
                        {
                            Id = 3,
                            Content = "In a groundbreaking move, a leading technology company has unveiled a cutting-edge virtual reality gaming console, promising an immersive gaming experience like never before. Gamers are eagerly anticipating the release of this next-generation gaming system, which is expected to revolutionize the gaming industry.",
                            DatePublication = new DateTime(2023, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Tech Giant Launches Innovative Virtual Reality Gaming Console"
                        },
                        new
                        {
                            Id = 4,
                            Content = "Archaeologists have unearthed a treasure trove of historic artifacts dating back centuries at an ancient archaeological site. These discoveries shed new light on the cultural and historical practices of the civilization that once thrived in this region, captivating historians and enthusiasts alike.",
                            DatePublication = new DateTime(2023, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Historic Artifacts Discovered in Ancient Ruins"
                        },
                        new
                        {
                            Id = 5,
                            Content = "Raging wildfires in the western regions continue to wreak havoc, destroying vast stretches of forests and threatening wildlife habitats. The uncontrolled spread of the fires has prompted urgent calls for additional firefighting resources and coordinated efforts to contain the infernos.",
                            DatePublication = new DateTime(2023, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Wildfire Devastation Continues to Worsen in Western Regions"
                        },
                        new
                        {
                            Id = 6,
                            Content = "Researchers have made a significant breakthrough in cancer treatment with the development of a novel drug that demonstrates promising results in early-stage clinical trials. This breakthrough offers hope to patients and oncologists, potentially revolutionizing cancer therapies in the near future.",
                            DatePublication = new DateTime(2023, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "New Breakthrough Drug Shows Promise in Cancer Treatment"
                        },
                        new
                        {
                            Id = 7,
                            Content = "A major city has taken a significant step towards sustainability by implementing new transportation initiatives aimed at reducing carbon emissions and promoting eco-friendly commuting options. These efforts align with global goals to combat climate change and create a cleaner, more sustainable urban environment.",
                            DatePublication = new DateTime(2023, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "City Implements Sustainable Transportation Initiatives"
                        },
                        new
                        {
                            Id = 8,
                            Content = "A much-anticipated high-speed train project has encountered unexpected technical challenges, causing delays in its completion. Engineers and project teams are working diligently to address these issues and ensure the successful implementation of this transformative transportation initiative.",
                            DatePublication = new DateTime(2023, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "High-Speed Train Project Faces Delays Due to Technical Challenges"
                        },
                        new
                        {
                            Id = 9,
                            Content = "Marine biologists have made a remarkable discovery in the deep ocean—a previously unknown species of marine life with unique characteristics and behaviors. This finding underscores the importance of continued exploration and research to unlock the mysteries of our oceans and preserve biodiversity.",
                            DatePublication = new DateTime(2023, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Scientists Discover New Species of Marine Life in the Deep Ocean"
                        },
                        new
                        {
                            Id = 10,
                            Content = "Recent shifts in global economic policies have sparked a reaction in financial markets, with fluctuations observed in various sectors. Investors and analysts are closely monitoring the situation, assessing potential impacts and adjusting strategies accordingly to navigate the evolving economic landscape.",
                            DatePublication = new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Financial Markets React to Global Economic Policy Changes"
                        },
                        new
                        {
                            Id = 11,
                            Content = "In an unexpected announcement, a well-known celebrity has revealed plans for a comeback tour, delighting fans and generating excitement across the entertainment industry. The tour is expected to showcase new music and provide a memorable experience for devoted followers.",
                            DatePublication = new DateTime(2023, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Prominent Celebrity Announces Surprise Comeback Tour"
                        },
                        new
                        {
                            Id = 12,
                            Content = "Educational authorities have unveiled a comprehensive set of reforms aimed at integrating digital learning into school curricula. The initiatives seek to equip students with essential digital skills and enhance the overall learning experience by leveraging technology in the classroom.",
                            DatePublication = new DateTime(2023, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Education Reforms Aim to Enhance Digital Learning in Schools"
                        },
                        new
                        {
                            Id = 13,
                            Content = "Astronomers have made a groundbreaking discovery—an exoplanet located within the habitable zone of its star, suggesting conditions conducive to liquid water and potential for life. This finding opens up new avenues for the search for extraterrestrial life beyond our solar system.",
                            DatePublication = new DateTime(2023, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Astronomers Discover Exoplanet with Potential for Habitable Conditions"
                        },
                        new
                        {
                            Id = 14,
                            Content = "Residents of a local community joined forces for a successful charity fundraiser, raising substantial funds for a noble cause. The event demonstrated the power of collective action and compassion, leaving a positive impact on the community and those in need.",
                            DatePublication = new DateTime(2023, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Local Community Comes Together for Charity Fundraiser"
                        },
                        new
                        {
                            Id = 15,
                            Content = "An innovative startup focused on clean energy solutions has secured a significant round of funding, propelling their efforts to develop and implement sustainable technologies. The investment reflects a growing commitment to addressing environmental challenges through innovative and sustainable practices.",
                            DatePublication = new DateTime(2023, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Innovative Startup Receives Funding to Develop Clean Energy Solutions"
                        });
                });

            modelBuilder.Entity("DataLayer.Entities.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            Id = 101,
                            FirstName = "John",
                            LastName = "Doe",
                            Login = "johndoe",
                            PasswordHash = "ef92b778bafe771e89245b89ecbc08a44a4e166c06659911881f383d4473e94f"
                        },
                        new
                        {
                            Id = 102,
                            FirstName = "Alice",
                            LastName = "Smith",
                            Login = "alicesmith",
                            PasswordHash = "c6ba91b90d922e159893f46c387e5dc1b3dc5c101a5a4522f03b987177a24a91"
                        },
                        new
                        {
                            Id = 103,
                            FirstName = "Michael",
                            LastName = "Johnson",
                            Login = "michaeljohnson",
                            PasswordHash = "5efc2b017da4f7736d192a74dde5891369e0685d4d38f2a455b6fcdab282df9c"
                        },
                        new
                        {
                            Id = 104,
                            FirstName = "Sarah",
                            LastName = "Williams",
                            Login = "sarahwilliams",
                            PasswordHash = "d1482ec79dcd15d6367b8cec022d675a924a2d56c2bb45b274c4c10ccc889a4b"
                        },
                        new
                        {
                            Id = 105,
                            FirstName = "David",
                            LastName = "Brown",
                            Login = "davidbrown",
                            PasswordHash = "88556c23902a305a45763b7de254e0b2f54df0ffd59a45876f7ba8cd08ea07db"
                        },
                        new
                        {
                            Id = 106,
                            FirstName = "Emily",
                            LastName = "Davis",
                            Login = "emilydavis",
                            PasswordHash = "a476e1e330b625c4aaad761fa7de68a07fac22cc5c3f6d368f09f402f0d9da9f"
                        },
                        new
                        {
                            Id = 107,
                            FirstName = "Daniel",
                            LastName = "Anderson",
                            Login = "danielanderson",
                            PasswordHash = "ddcbacdd51e48197a74405c0954864ae8119cfd7656ca9b3e147e0caa327e6d0"
                        },
                        new
                        {
                            Id = 108,
                            FirstName = "Olivia",
                            LastName = "Clark",
                            Login = "oliviaclark",
                            PasswordHash = "93a76ee864415e527b388672ce4b47533bbb4371d8679c7b640ff6243ca09502"
                        },
                        new
                        {
                            Id = 109,
                            FirstName = "Brian",
                            LastName = "Turner",
                            Login = "brianturner",
                            PasswordHash = "0158d8b9a56c1c1ca79bbdca04755a9612f80639615efa5203815628f7b561e1"
                        },
                        new
                        {
                            Id = 110,
                            FirstName = "Sophia",
                            LastName = "Harris",
                            Login = "sophiaharris",
                            PasswordHash = "d8493f1b4791982f4e4f7e601380aa58d8f22679d198f00bd1b50532c6ade369"
                        },
                        new
                        {
                            Id = 111,
                            FirstName = "Kevin",
                            LastName = "Turner",
                            Login = "kevinturner",
                            PasswordHash = "e851bf45dd4c0b66c9ff7b2042e9431c80c36ca943ccffcc3b44a7ee7ab9f315"
                        },
                        new
                        {
                            Id = 112,
                            FirstName = "Jessica",
                            LastName = "Martinez",
                            Login = "jessicamartinez",
                            PasswordHash = "8206496b3e93312d1b93c98f32c7336afd758aebc8908999f2f302ead382b175"
                        },
                        new
                        {
                            Id = 113,
                            FirstName = "Andrew",
                            LastName = "Wilson",
                            Login = "andrewwilson",
                            PasswordHash = "87fdb2c62d504c4ed6b4d3947683a1b9be544e9855b58f3eb888726cf4710487"
                        },
                        new
                        {
                            Id = 114,
                            FirstName = "Christine",
                            LastName = "Miller",
                            Login = "christinemiller",
                            PasswordHash = "e8fde5293fb1f46c6ef18f19395465b65a058665b88cc124d2b0d187b1d2d3d3"
                        },
                        new
                        {
                            Id = 115,
                            FirstName = "William",
                            LastName = "Taylor",
                            Login = "williamtaylor",
                            PasswordHash = "9a820068d3c9c8d349ecc14afb8e04368cac2bd85543986593dfbc17e6f71085"
                        });
                });

            modelBuilder.Entity("DataLayer.Entities.FeedbackOrComplains", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DatePublication")
                        .HasColumnType("datetime2");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("FeedBackOrComplains");

                    b.HasDiscriminator<string>("Discriminator").HasValue("FeedBackOrComplains");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Content = "I wanted to express my gratitude for the exceptional customer service I received. The staff was attentive, helpful, and went above and beyond to assist me. Thank you!",
                            CustomerId = 101,
                            DatePublication = new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Great Customer Service"
                        },
                        new
                        {
                            Id = 2,
                            Content = "While my overall experience was satisfactory, I believe there's room for improvement in the product's quality. Specifically, I'd recommend focusing on enhancing durability for a better customer experience.",
                            CustomerId = 102,
                            DatePublication = new DateTime(2023, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Quality Improvement Suggestion"
                        },
                        new
                        {
                            Id = 3,
                            Content = "I encountered a delay in the delivery of my order, and this caused inconvenience. Timely delivery is crucial for customer satisfaction, and I hope steps are taken to prevent such delays in the future.",
                            CustomerId = 103,
                            DatePublication = new DateTime(2023, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Issue with Product Delivery"
                        },
                        new
                        {
                            Id = 4,
                            Content = "I recently shopped at your store and had an outstanding experience. The layout was organized, and the staff was knowledgeable and helpful. I'll definitely be returning for future purchases.",
                            CustomerId = 104,
                            DatePublication = new DateTime(2023, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Excellent Shopping Experience"
                        },
                        new
                        {
                            Id = 5,
                            Content = "I've noticed an increase in product prices recently, which has made it challenging for me to afford some items. I hope the company considers keeping prices reasonable and accessible for all customers.",
                            CustomerId = 105,
                            DatePublication = new DateTime(2023, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Concerns Regarding Product Pricing"
                        },
                        new
                        {
                            Id = 6,
                            Content = "The recent redesign of your website has greatly improved the user experience. It's more intuitive, visually appealing, and easy to navigate. Keep up the good work!",
                            CustomerId = 106,
                            DatePublication = new DateTime(2023, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Positive Feedback on Website Redesign"
                        },
                        new
                        {
                            Id = 7,
                            Content = "I had an issue with a recent purchase and contacted customer support for assistance. Unfortunately, the response was slow and unhelpful. I believe there's a need for improvement in the customer support department.",
                            CustomerId = 107,
                            DatePublication = new DateTime(2023, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Dissatisfaction with Customer Support"
                        },
                        new
                        {
                            Id = 8,
                            Content = "I've been using your product for a while now, and I'm extremely impressed with its durability and long-lasting quality. It has exceeded my expectations, and I'm a satisfied customer.",
                            CustomerId = 108,
                            DatePublication = new DateTime(2023, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Praise for Product Durability"
                        },
                        new
                        {
                            Id = 9,
                            Content = "I have a suggestion for enhancing your product's functionality by adding specific features. These features would provide more value to users and improve the overall user experience.",
                            CustomerId = 109,
                            DatePublication = new DateTime(2023, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Suggestion for New Product Features"
                        },
                        new
                        {
                            Id = 10,
                            Content = "While I'm satisfied with the product itself, I believe the packaging can be improved to be more environmentally friendly. Sustainable packaging would align better with current environmental concerns.",
                            CustomerId = 110,
                            DatePublication = new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Feedback on Product Packaging"
                        },
                        new
                        {
                            Id = 11,
                            Content = "During my recent visit to your establishment, I experienced a prolonged wait time for service. Efficient service is crucial for customer satisfaction, and I hope measures are taken to minimize wait times.",
                            CustomerId = 111,
                            DatePublication = new DateTime(2023, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Complaint Regarding Service Wait Time"
                        },
                        new
                        {
                            Id = 12,
                            Content = "I wanted to express my appreciation for the innovative features of your product. The recent updates have significantly enhanced its usability and usefulness. Keep up the good work!",
                            CustomerId = 112,
                            DatePublication = new DateTime(2023, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Appreciation for Product Innovation"
                        },
                        new
                        {
                            Id = 13,
                            Content = "I encountered a billing error in my recent invoice. I appreciate the swift response from your team in resolving the issue and providing clarification. Thank you for your prompt action.",
                            CustomerId = 113,
                            DatePublication = new DateTime(2023, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Billing Error Resolution"
                        },
                        new
                        {
                            Id = 14,
                            Content = "I have safety concerns about one of your products and believe there's a potential risk. It's crucial to address this issue promptly and ensure the safety of your customers.",
                            CustomerId = 114,
                            DatePublication = new DateTime(2023, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Concerns Regarding Product Safety"
                        },
                        new
                        {
                            Id = 15,
                            Content = "I recently navigated your website and identified some areas for improvement in terms of user interface and responsiveness. Implementing these suggestions could enhance the overall user experience.",
                            CustomerId = 115,
                            DatePublication = new DateTime(2023, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Suggestions for Website Improvement"
                        });
                });

            modelBuilder.Entity("DataLayer.Entities.Good", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("GoodType")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.ToTable("Goods");
                });

            modelBuilder.Entity("DataLayer.Entities.Manager", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Managers");
                });

            modelBuilder.Entity("DataLayer.Entities.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CommentOfCustomer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CommentOfmanager")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("DataLayer.Entities.FeedbackOrComplains", b =>
                {
                    b.HasOne("DataLayer.Entities.Customer", "Customer")
                        .WithMany("FeedBacks")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("DataLayer.Entities.Good", b =>
                {
                    b.HasOne("DataLayer.Entities.Order", "Order")
                        .WithMany("Goods")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");
                });

            modelBuilder.Entity("DataLayer.Entities.Order", b =>
                {
                    b.HasOne("DataLayer.Entities.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("DataLayer.Entities.Customer", b =>
                {
                    b.Navigation("FeedBacks");

                    b.Navigation("Orders");
                });

            modelBuilder.Entity("DataLayer.Entities.Order", b =>
                {
                    b.Navigation("Goods");
                });
#pragma warning restore 612, 618
        }
    }
}
