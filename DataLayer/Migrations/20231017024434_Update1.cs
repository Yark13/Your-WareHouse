using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataLayer.Migrations
{
    /// <inheritdoc />
    public partial class Update1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "Content", "DatePublication", "Title" },
                values: new object[,]
                {
                    { 1, "A recent study published in a leading medical journal has highlighted the potential health benefits of consuming dark chocolate in moderation. The study found that dark chocolate, when consumed in appropriate amounts, could have a positive impact on heart health and may help reduce the risk of certain cardiovascular diseases.", new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "New Research Reveals Surprising Benefits of Chocolate" },
                    { 2, "Unprecedented rainfall in the coastal regions has led to severe flooding, displacing thousands of residents and causing significant damage to infrastructure. Emergency services are working tirelessly to rescue stranded individuals and provide relief to those affected by this natural disaster.", new DateTime(2023, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Record-Breaking Rainfall Causes Flooding in Coastal Regions" },
                    { 3, "In a groundbreaking move, a leading technology company has unveiled a cutting-edge virtual reality gaming console, promising an immersive gaming experience like never before. Gamers are eagerly anticipating the release of this next-generation gaming system, which is expected to revolutionize the gaming industry.", new DateTime(2023, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tech Giant Launches Innovative Virtual Reality Gaming Console" },
                    { 4, "Archaeologists have unearthed a treasure trove of historic artifacts dating back centuries at an ancient archaeological site. These discoveries shed new light on the cultural and historical practices of the civilization that once thrived in this region, captivating historians and enthusiasts alike.", new DateTime(2023, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Historic Artifacts Discovered in Ancient Ruins" },
                    { 5, "Raging wildfires in the western regions continue to wreak havoc, destroying vast stretches of forests and threatening wildlife habitats. The uncontrolled spread of the fires has prompted urgent calls for additional firefighting resources and coordinated efforts to contain the infernos.", new DateTime(2023, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wildfire Devastation Continues to Worsen in Western Regions" },
                    { 6, "Researchers have made a significant breakthrough in cancer treatment with the development of a novel drug that demonstrates promising results in early-stage clinical trials. This breakthrough offers hope to patients and oncologists, potentially revolutionizing cancer therapies in the near future.", new DateTime(2023, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "New Breakthrough Drug Shows Promise in Cancer Treatment" },
                    { 7, "A major city has taken a significant step towards sustainability by implementing new transportation initiatives aimed at reducing carbon emissions and promoting eco-friendly commuting options. These efforts align with global goals to combat climate change and create a cleaner, more sustainable urban environment.", new DateTime(2023, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "City Implements Sustainable Transportation Initiatives" },
                    { 8, "A much-anticipated high-speed train project has encountered unexpected technical challenges, causing delays in its completion. Engineers and project teams are working diligently to address these issues and ensure the successful implementation of this transformative transportation initiative.", new DateTime(2023, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "High-Speed Train Project Faces Delays Due to Technical Challenges" },
                    { 9, "Marine biologists have made a remarkable discovery in the deep ocean—a previously unknown species of marine life with unique characteristics and behaviors. This finding underscores the importance of continued exploration and research to unlock the mysteries of our oceans and preserve biodiversity.", new DateTime(2023, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Scientists Discover New Species of Marine Life in the Deep Ocean" },
                    { 10, "Recent shifts in global economic policies have sparked a reaction in financial markets, with fluctuations observed in various sectors. Investors and analysts are closely monitoring the situation, assessing potential impacts and adjusting strategies accordingly to navigate the evolving economic landscape.", new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Financial Markets React to Global Economic Policy Changes" },
                    { 11, "In an unexpected announcement, a well-known celebrity has revealed plans for a comeback tour, delighting fans and generating excitement across the entertainment industry. The tour is expected to showcase new music and provide a memorable experience for devoted followers.", new DateTime(2023, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Prominent Celebrity Announces Surprise Comeback Tour" },
                    { 12, "Educational authorities have unveiled a comprehensive set of reforms aimed at integrating digital learning into school curricula. The initiatives seek to equip students with essential digital skills and enhance the overall learning experience by leveraging technology in the classroom.", new DateTime(2023, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Education Reforms Aim to Enhance Digital Learning in Schools" },
                    { 13, "Astronomers have made a groundbreaking discovery—an exoplanet located within the habitable zone of its star, suggesting conditions conducive to liquid water and potential for life. This finding opens up new avenues for the search for extraterrestrial life beyond our solar system.", new DateTime(2023, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Astronomers Discover Exoplanet with Potential for Habitable Conditions" },
                    { 14, "Residents of a local community joined forces for a successful charity fundraiser, raising substantial funds for a noble cause. The event demonstrated the power of collective action and compassion, leaving a positive impact on the community and those in need.", new DateTime(2023, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Local Community Comes Together for Charity Fundraiser" },
                    { 15, "An innovative startup focused on clean energy solutions has secured a significant round of funding, propelling their efforts to develop and implement sustainable technologies. The investment reflects a growing commitment to addressing environmental challenges through innovative and sustainable practices.", new DateTime(2023, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Innovative Startup Receives Funding to Develop Clean Energy Solutions" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 15);
        }
    }
}
