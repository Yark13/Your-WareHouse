using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataLayer.Migrations
{
    /// <inheritdoc />
    public partial class Update2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "FirstName", "LastName", "Login", "PasswordHash" },
                values: new object[,]
                {
                    { 101, "John", "Doe", "johndoe", "ef92b778bafe771e89245b89ecbc08a44a4e166c06659911881f383d4473e94f" },
                    { 102, "Alice", "Smith", "alicesmith", "c6ba91b90d922e159893f46c387e5dc1b3dc5c101a5a4522f03b987177a24a91" },
                    { 103, "Michael", "Johnson", "michaeljohnson", "5efc2b017da4f7736d192a74dde5891369e0685d4d38f2a455b6fcdab282df9c" },
                    { 104, "Sarah", "Williams", "sarahwilliams", "d1482ec79dcd15d6367b8cec022d675a924a2d56c2bb45b274c4c10ccc889a4b" },
                    { 105, "David", "Brown", "davidbrown", "88556c23902a305a45763b7de254e0b2f54df0ffd59a45876f7ba8cd08ea07db" },
                    { 106, "Emily", "Davis", "emilydavis", "a476e1e330b625c4aaad761fa7de68a07fac22cc5c3f6d368f09f402f0d9da9f" },
                    { 107, "Daniel", "Anderson", "danielanderson", "ddcbacdd51e48197a74405c0954864ae8119cfd7656ca9b3e147e0caa327e6d0" },
                    { 108, "Olivia", "Clark", "oliviaclark", "93a76ee864415e527b388672ce4b47533bbb4371d8679c7b640ff6243ca09502" },
                    { 109, "Brian", "Turner", "brianturner", "0158d8b9a56c1c1ca79bbdca04755a9612f80639615efa5203815628f7b561e1" },
                    { 110, "Sophia", "Harris", "sophiaharris", "d8493f1b4791982f4e4f7e601380aa58d8f22679d198f00bd1b50532c6ade369" },
                    { 111, "Kevin", "Turner", "kevinturner", "e851bf45dd4c0b66c9ff7b2042e9431c80c36ca943ccffcc3b44a7ee7ab9f315" },
                    { 112, "Jessica", "Martinez", "jessicamartinez", "8206496b3e93312d1b93c98f32c7336afd758aebc8908999f2f302ead382b175" },
                    { 113, "Andrew", "Wilson", "andrewwilson", "87fdb2c62d504c4ed6b4d3947683a1b9be544e9855b58f3eb888726cf4710487" },
                    { 114, "Christine", "Miller", "christinemiller", "e8fde5293fb1f46c6ef18f19395465b65a058665b88cc124d2b0d187b1d2d3d3" },
                    { 115, "William", "Taylor", "williamtaylor", "9a820068d3c9c8d349ecc14afb8e04368cac2bd85543986593dfbc17e6f71085" }
                });

            migrationBuilder.InsertData(
                table: "FeedBackOrComplains",
                columns: new[] { "Id", "Content", "CustomerId", "DatePublication", "Discriminator", "Title" },
                values: new object[,]
                {
                    { 1, "I wanted to express my gratitude for the exceptional customer service I received. The staff was attentive, helpful, and went above and beyond to assist me. Thank you!", 101, new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "FeedBackOrComplains", "Great Customer Service" },
                    { 2, "While my overall experience was satisfactory, I believe there's room for improvement in the product's quality. Specifically, I'd recommend focusing on enhancing durability for a better customer experience.", 102, new DateTime(2023, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "FeedBackOrComplains", "Quality Improvement Suggestion" },
                    { 3, "I encountered a delay in the delivery of my order, and this caused inconvenience. Timely delivery is crucial for customer satisfaction, and I hope steps are taken to prevent such delays in the future.", 103, new DateTime(2023, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "FeedBackOrComplains", "Issue with Product Delivery" },
                    { 4, "I recently shopped at your store and had an outstanding experience. The layout was organized, and the staff was knowledgeable and helpful. I'll definitely be returning for future purchases.", 104, new DateTime(2023, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "FeedBackOrComplains", "Excellent Shopping Experience" },
                    { 5, "I've noticed an increase in product prices recently, which has made it challenging for me to afford some items. I hope the company considers keeping prices reasonable and accessible for all customers.", 105, new DateTime(2023, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "FeedBackOrComplains", "Concerns Regarding Product Pricing" },
                    { 6, "The recent redesign of your website has greatly improved the user experience. It's more intuitive, visually appealing, and easy to navigate. Keep up the good work!", 106, new DateTime(2023, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "FeedBackOrComplains", "Positive Feedback on Website Redesign" },
                    { 7, "I had an issue with a recent purchase and contacted customer support for assistance. Unfortunately, the response was slow and unhelpful. I believe there's a need for improvement in the customer support department.", 107, new DateTime(2023, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "FeedBackOrComplains", "Dissatisfaction with Customer Support" },
                    { 8, "I've been using your product for a while now, and I'm extremely impressed with its durability and long-lasting quality. It has exceeded my expectations, and I'm a satisfied customer.", 108, new DateTime(2023, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "FeedBackOrComplains", "Praise for Product Durability" },
                    { 9, "I have a suggestion for enhancing your product's functionality by adding specific features. These features would provide more value to users and improve the overall user experience.", 109, new DateTime(2023, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "FeedBackOrComplains", "Suggestion for New Product Features" },
                    { 10, "While I'm satisfied with the product itself, I believe the packaging can be improved to be more environmentally friendly. Sustainable packaging would align better with current environmental concerns.", 110, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "FeedBackOrComplains", "Feedback on Product Packaging" },
                    { 11, "During my recent visit to your establishment, I experienced a prolonged wait time for service. Efficient service is crucial for customer satisfaction, and I hope measures are taken to minimize wait times.", 111, new DateTime(2023, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "FeedBackOrComplains", "Complaint Regarding Service Wait Time" },
                    { 12, "I wanted to express my appreciation for the innovative features of your product. The recent updates have significantly enhanced its usability and usefulness. Keep up the good work!", 112, new DateTime(2023, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "FeedBackOrComplains", "Appreciation for Product Innovation" },
                    { 13, "I encountered a billing error in my recent invoice. I appreciate the swift response from your team in resolving the issue and providing clarification. Thank you for your prompt action.", 113, new DateTime(2023, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "FeedBackOrComplains", "Billing Error Resolution" },
                    { 14, "I have safety concerns about one of your products and believe there's a potential risk. It's crucial to address this issue promptly and ensure the safety of your customers.", 114, new DateTime(2023, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "FeedBackOrComplains", "Concerns Regarding Product Safety" },
                    { 15, "I recently navigated your website and identified some areas for improvement in terms of user interface and responsiveness. Implementing these suggestions could enhance the overall user experience.", 115, new DateTime(2023, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "FeedBackOrComplains", "Suggestions for Website Improvement" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FeedBackOrComplains",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "FeedBackOrComplains",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "FeedBackOrComplains",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "FeedBackOrComplains",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "FeedBackOrComplains",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "FeedBackOrComplains",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "FeedBackOrComplains",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "FeedBackOrComplains",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "FeedBackOrComplains",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "FeedBackOrComplains",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "FeedBackOrComplains",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "FeedBackOrComplains",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "FeedBackOrComplains",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "FeedBackOrComplains",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "FeedBackOrComplains",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 115);
        }
    }
}
