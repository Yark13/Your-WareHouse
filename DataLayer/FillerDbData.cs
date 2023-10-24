using DataLayer.Entities;

namespace DataLayer;

public class FillerDbData
{
    private Customer[] DBCustomers = new Customer[]
{
    new Customer
    {
        Id = 1,
        LastName = "Melnyk",
        FirstName = "Yaroslav",
        Login = "Melnyk.Yaroslav56",
        PasswordHash =  new MyCoder().ComputeSHA256Hash("YaroMeln65")
    },
    new Customer
    {
        Id = 2,
        LastName = "Ketsyk",
        FirstName = "Dmytro",
        Login = "ketsyk.dmytro18",
        PasswordHash =  new MyCoder().ComputeSHA256Hash("dmyttsyk81")
    },
    new Customer
    {
        Id = 101,
        LastName = "Doe",
        FirstName = "John",
        Login = "johndoe",
        PasswordHash =  new MyCoder().ComputeSHA256Hash("password123")
    },
    new Customer
    {
        Id = 102,
        LastName = "Smith",
        FirstName = "Alice",
        Login = "alicesmith",
        PasswordHash = new MyCoder().ComputeSHA256Hash("password456")
    },
    new Customer
    {
        Id = 103,
        LastName = "Johnson",
        FirstName = "Michael",
        Login = "michaeljohnson",
        PasswordHash =new MyCoder().ComputeSHA256Hash("password789")
    },
    new Customer
    {
        Id = 104,
        LastName = "Williams",
        FirstName = "Sarah",
        Login = "sarahwilliams",
        PasswordHash = new MyCoder().ComputeSHA256Hash("password101112")
    },
    new Customer
    {
        Id = 105,
        LastName = "Brown",
        FirstName = "David",
        Login = "davidbrown",
        PasswordHash = new MyCoder().ComputeSHA256Hash("password131415")
    },
    new Customer
    {
        Id = 106,
        LastName = "Davis",
        FirstName = "Emily",
        Login = "emilydavis",
        PasswordHash = new MyCoder().ComputeSHA256Hash("password161718")
    },
    new Customer
    {
        Id = 107,
        LastName = "Anderson",
        FirstName = "Daniel",
        Login = "danielanderson",
        PasswordHash = new MyCoder().ComputeSHA256Hash("password192021")
    },
    new Customer
    {
        Id = 108,
        LastName = "Clark",
        FirstName = "Olivia",
        Login = "oliviaclark",
        PasswordHash = new MyCoder().ComputeSHA256Hash("password222324")
    },
    new Customer
    {
        Id = 109,
        LastName = "Turner",
        FirstName = "Brian",
        Login = "brianturner",
        PasswordHash = new MyCoder().ComputeSHA256Hash("password252627")
    },
    new Customer
    {
        Id = 110,
        LastName = "Harris",
        FirstName = "Sophia",
        Login = "sophiaharris",
        PasswordHash = new MyCoder().ComputeSHA256Hash("password282930")
    },
    new Customer
    {
        Id = 111,
        LastName = "Turner",
        FirstName = "Kevin",
        Login = "kevinturner",
        PasswordHash = new MyCoder().ComputeSHA256Hash("password313233")
    },
    new Customer
    {
        Id = 112,
        LastName = "Martinez",
        FirstName = "Jessica",
        Login = "jessicamartinez",
        PasswordHash = new MyCoder().ComputeSHA256Hash("password343536")
    },
    new Customer
    {
        Id = 113,
        LastName = "Wilson",
        FirstName = "Andrew",
        Login = "andrewwilson",
        PasswordHash = new MyCoder().ComputeSHA256Hash("password373839")
    },
    new Customer
    {
        Id = 114,
        LastName = "Miller",
        FirstName = "Christine",
        Login = "christinemiller",
        PasswordHash = new MyCoder().ComputeSHA256Hash("password404142")
    },
    new Customer
    {
        Id = 115,
        LastName = "Taylor",
        FirstName = "William",
        Login = "williamtaylor",
        PasswordHash = new MyCoder().ComputeSHA256Hash("password434445")
    },
};


    private Manager[] DBManagers = new Manager[]
    {
        new Manager
        {
            Id = 1,
            LastName = "",
            FirstName = "",
            Login = "Manager_001",
            PasswordHash = new MyCoder().ComputeSHA256Hash("Password334582")
        }
    };

    private Order[] DBOrders = new Order[]
    {
        new Order
        {
            Id = 1,
            CustomerId = 2,
            StartReservation = DateTime.Now,
            EndReservation = DateTime.Today,
            OrderStatus = StatusOrder.InQueue
        },
        new Order
        {
            Id = 2,
            CustomerId = 2,
            StartReservation = new DateTime(2023,10,17),
            EndReservation = new DateTime(2023,10,18),
            OrderStatus = StatusOrder.CurrentlyRunning,
            GoodName = "Chair",
            GoodNumber = 100,
            GoodType = UnitOfMeasurement.Thinks,
        },
        new Order
        {
            Id = 3,
            CustomerId = 2,
            StartReservation = new DateTime(2023,10,17),
            EndReservation = new DateTime(2023,10,30),
            OrderStatus = StatusOrder.InQueue,
            GoodName = "Sofa",
            GoodNumber = 50,
            GoodType = UnitOfMeasurement.Thinks,
        },
        new Order
        {
            Id = 4,
            CustomerId = 2,
            StartReservation = new DateTime(2023,10,17),
            EndReservation = new DateTime(2023,10,30),
            OrderStatus = StatusOrder.InQueue,
            GoodName = "Oil",
            GoodNumber = 1000,
            GoodType = UnitOfMeasurement.Barrels,
        },
        new Order
        {
            Id = 5,
            CustomerId = 2,
            StartReservation = new DateTime(2023,12,17),
            EndReservation = new DateTime(2024,10,30),
            OrderStatus = StatusOrder.InQueue,
            GoodName = "Weapon",
            GoodNumber = 300,
            GoodType = UnitOfMeasurement.Sets,
        },
        new Order
        {
            Id = 6,
            CustomerId = 2,
            StartReservation = new DateTime(2023,12,17),
            EndReservation = new DateTime(2024,10,30),
            OrderStatus = StatusOrder.InQueue,
            GoodName = "Car",
            GoodNumber = 10,
            GoodType = UnitOfMeasurement.Thinks,
        }
    };

    private Article[] DBArticles = new Article[]
    {
        new Article
        {
            Id = 1,
            Title = "New Research Reveals Surprising Benefits of Chocolate",
            Content = "A recent study published in a leading medical journal has highlighted the potential health benefits of consuming dark chocolate in moderation. The study found that dark chocolate, when consumed in appropriate amounts, could have a positive impact on heart health and may help reduce the risk of certain cardiovascular diseases.",
            DatePublication = DateTime.Parse("October 1, 2023")
        },
        new Article
        {
            Id = 2,
            Title = "Record-Breaking Rainfall Causes Flooding in Coastal Regions",
            Content = "Unprecedented rainfall in the coastal regions has led to severe flooding, displacing thousands of residents and causing significant damage to infrastructure. Emergency services are working tirelessly to rescue stranded individuals and provide relief to those affected by this natural disaster.",
            DatePublication = DateTime.Parse("September 28, 2023")
        },
        new Article
        {
            Id = 3,
            Title = "Tech Giant Launches Innovative Virtual Reality Gaming Console",
            Content = "In a groundbreaking move, a leading technology company has unveiled a cutting-edge virtual reality gaming console, promising an immersive gaming experience like never before. Gamers are eagerly anticipating the release of this next-generation gaming system, which is expected to revolutionize the gaming industry.",
            DatePublication = DateTime.Parse("October 5, 2023")
        },
        new Article
        {
            Id = 4,
            Title = "Historic Artifacts Discovered in Ancient Ruins",
            Content = "Archaeologists have unearthed a treasure trove of historic artifacts dating back centuries at an ancient archaeological site. These discoveries shed new light on the cultural and historical practices of the civilization that once thrived in this region, captivating historians and enthusiasts alike.",
            DatePublication = DateTime.Parse("October 10, 2023")
        },
        new Article
        {
            Id = 5,
            Title = "Wildfire Devastation Continues to Worsen in Western Regions",
            Content = "Raging wildfires in the western regions continue to wreak havoc, destroying vast stretches of forests and threatening wildlife habitats. The uncontrolled spread of the fires has prompted urgent calls for additional firefighting resources and coordinated efforts to contain the infernos.",
            DatePublication = DateTime.Parse("October 8, 2023")
        },
        new Article
        {
            Id = 6,
            Title = "New Breakthrough Drug Shows Promise in Cancer Treatment",
            Content = "Researchers have made a significant breakthrough in cancer treatment with the development of a novel drug that demonstrates promising results in early-stage clinical trials. This breakthrough offers hope to patients and oncologists, potentially revolutionizing cancer therapies in the near future.",
            DatePublication = DateTime.Parse("October 2, 2023")
        },
        new Article
        {
            Id = 7,
            Title = "City Implements Sustainable Transportation Initiatives",
            Content = "A major city has taken a significant step towards sustainability by implementing new transportation initiatives aimed at reducing carbon emissions and promoting eco-friendly commuting options. These efforts align with global goals to combat climate change and create a cleaner, more sustainable urban environment.",
            DatePublication = DateTime.Parse("October 6, 2023")
        },
        new Article
        {
            Id = 8,
            Title = "High-Speed Train Project Faces Delays Due to Technical Challenges",
            Content = "A much-anticipated high-speed train project has encountered unexpected technical challenges, causing delays in its completion. Engineers and project teams are working diligently to address these issues and ensure the successful implementation of this transformative transportation initiative.",
            DatePublication = DateTime.Parse("October 4, 2023")
        },
        new Article
        {
            Id = 9,
            Title = "Scientists Discover New Species of Marine Life in the Deep Ocean",
            Content = "Marine biologists have made a remarkable discovery in the deep ocean—a previously unknown species of marine life with unique characteristics and behaviors. This finding underscores the importance of continued exploration and research to unlock the mysteries of our oceans and preserve biodiversity.",
            DatePublication = DateTime.Parse("October 7, 2023")
        },
        new Article
        {
            Id = 10,
            Title = "Financial Markets React to Global Economic Policy Changes",
            Content = "Recent shifts in global economic policies have sparked a reaction in financial markets, with fluctuations observed in various sectors. Investors and analysts are closely monitoring the situation, assessing potential impacts and adjusting strategies accordingly to navigate the evolving economic landscape.",
            DatePublication = DateTime.Parse("October 9, 2023")
        },
        new Article
        {
            Id = 11,
            Title = "Prominent Celebrity Announces Surprise Comeback Tour",
            Content = "In an unexpected announcement, a well-known celebrity has revealed plans for a comeback tour, delighting fans and generating excitement across the entertainment industry. The tour is expected to showcase new music and provide a memorable experience for devoted followers.",
            DatePublication = DateTime.Parse("October 3, 2023")
        },
        new Article
        {
            Id = 12,
            Title = "Education Reforms Aim to Enhance Digital Learning in Schools",
            Content = "Educational authorities have unveiled a comprehensive set of reforms aimed at integrating digital learning into school curricula. The initiatives seek to equip students with essential digital skills and enhance the overall learning experience by leveraging technology in the classroom.",
            DatePublication = DateTime.Parse("October 11, 2023")
        },
        new Article
        {
            Id = 13,
            Title = "Astronomers Discover Exoplanet with Potential for Habitable Conditions",
            Content = "Astronomers have made a groundbreaking discovery—an exoplanet located within the habitable zone of its star, suggesting conditions conducive to liquid water and potential for life. This finding opens up new avenues for the search for extraterrestrial life beyond our solar system.",
            DatePublication = DateTime.Parse("October 12, 2023")
        },
        new Article
        {
            Id = 14,
            Title = "Local Community Comes Together for Charity Fundraiser",
            Content = "Residents of a local community joined forces for a successful charity fundraiser, raising substantial funds for a noble cause. The event demonstrated the power of collective action and compassion, leaving a positive impact on the community and those in need.",
            DatePublication = DateTime.Parse("October 13, 2023")
        },
        new Article
        {
            Id = 15,
            Title = "Innovative Startup Receives Funding to Develop Clean Energy Solutions",
            Content = "An innovative startup focused on clean energy solutions has secured a significant round of funding, propelling their efforts to develop and implement sustainable technologies. The investment reflects a growing commitment to addressing environmental challenges through innovative and sustainable practices.",
            DatePublication = DateTime.Parse("October 14, 2023")
        },
    };

    private FeedbackOrComplains[] DBFeedBacks = new FeedbackOrComplains[]
{
    new FeedbackOrComplains
    {
        Id = 1,
        Title = "Great Customer Service",
        Content = "I wanted to express my gratitude for the exceptional customer service I received. The staff was attentive, helpful, and went above and beyond to assist me. Thank you!",
        DatePublication = DateTime.Parse("October 1, 2023"),
        CustomerId = 101
    },
    new FeedbackOrComplains
    {
        Id = 2,
        Title = "Quality Improvement Suggestion",
        Content = "While my overall experience was satisfactory, I believe there's room for improvement in the product's quality. Specifically, I'd recommend focusing on enhancing durability for a better customer experience.",
        DatePublication = DateTime.Parse("September 28, 2023"),
        CustomerId = 102
    },
    new FeedbackOrComplains
    {
        Id = 3,
        Title = "Issue with Product Delivery",
        Content = "I encountered a delay in the delivery of my order, and this caused inconvenience. Timely delivery is crucial for customer satisfaction, and I hope steps are taken to prevent such delays in the future.",
        DatePublication = DateTime.Parse("October 5, 2023"),
        CustomerId = 103
    },
    new FeedbackOrComplains
    {
        Id = 4,
        Title = "Excellent Shopping Experience",
        Content = "I recently shopped at your store and had an outstanding experience. The layout was organized, and the staff was knowledgeable and helpful. I'll definitely be returning for future purchases.",
        DatePublication = DateTime.Parse("October 10, 2023"),
        CustomerId = 104
    },
    new FeedbackOrComplains
    {
        Id = 5,
        Title = "Concerns Regarding Product Pricing",
        Content = "I've noticed an increase in product prices recently, which has made it challenging for me to afford some items. I hope the company considers keeping prices reasonable and accessible for all customers.",
        DatePublication = DateTime.Parse("October 8, 2023"),
        CustomerId = 105
    },
    new FeedbackOrComplains
    {
        Id = 6,
        Title = "Positive Feedback on Website Redesign",
        Content = "The recent redesign of your website has greatly improved the user experience. It's more intuitive, visually appealing, and easy to navigate. Keep up the good work!",
        DatePublication = DateTime.Parse("October 2, 2023"),
        CustomerId = 106
    },
    new FeedbackOrComplains
    {
        Id = 7,
        Title = "Dissatisfaction with Customer Support",
        Content = "I had an issue with a recent purchase and contacted customer support for assistance. Unfortunately, the response was slow and unhelpful. I believe there's a need for improvement in the customer support department.",
        DatePublication = DateTime.Parse("October 6, 2023"),
        CustomerId = 107
    },
    new FeedbackOrComplains
    {
        Id = 8,
        Title = "Praise for Product Durability",
        Content = "I've been using your product for a while now, and I'm extremely impressed with its durability and long-lasting quality. It has exceeded my expectations, and I'm a satisfied customer.",
        DatePublication = DateTime.Parse("October 4, 2023"),
        CustomerId = 108
    },
    new FeedbackOrComplains
    {
        Id = 9,
        Title = "Suggestion for New Product Features",
        Content = "I have a suggestion for enhancing your product's functionality by adding specific features. These features would provide more value to users and improve the overall user experience.",
        DatePublication = DateTime.Parse("October 7, 2023"),
        CustomerId = 109
    },
    new FeedbackOrComplains
    {
        Id = 10,
        Title = "Feedback on Product Packaging",
        Content = "While I'm satisfied with the product itself, I believe the packaging can be improved to be more environmentally friendly. Sustainable packaging would align better with current environmental concerns.",
        DatePublication = DateTime.Parse("October 9, 2023"),
        CustomerId = 110
    },
    new FeedbackOrComplains
    {
        Id = 11,
        Title = "Complaint Regarding Service Wait Time",
        Content = "During my recent visit to your establishment, I experienced a prolonged wait time for service. Efficient service is crucial for customer satisfaction, and I hope measures are taken to minimize wait times.",
        DatePublication = DateTime.Parse("October 3, 2023"),
        CustomerId = 111
    },
    new FeedbackOrComplains
    {
        Id = 12,
        Title = "Appreciation for Product Innovation",
        Content = "I wanted to express my appreciation for the innovative features of your product. The recent updates have significantly enhanced its usability and usefulness. Keep up the good work!",
        DatePublication = DateTime.Parse("October 11, 2023"),
        CustomerId = 112
    },
    new FeedbackOrComplains
    {
        Id = 13,
        Title = "Billing Error Resolution",
        Content = "I encountered a billing error in my recent invoice. I appreciate the swift response from your team in resolving the issue and providing clarification. Thank you for your prompt action.",
        DatePublication = DateTime.Parse("October 12, 2023"),
        CustomerId = 113
    },
    new FeedbackOrComplains
    {
        Id = 14,
        Title = "Concerns Regarding Product Safety",
        Content = "I have safety concerns about one of your products and believe there's a potential risk. It's crucial to address this issue promptly and ensure the safety of your customers.",
        DatePublication = DateTime.Parse("October 13, 2023"),
        CustomerId = 114
    },
    new FeedbackOrComplains
    {
        Id = 15,
        Title = "Suggestions for Website Improvement",
        Content = "I recently navigated your website and identified some areas for improvement in terms of user interface and responsiveness. Implementing these suggestions could enhance the overall user experience.",
        DatePublication = DateTime.Parse("October 14, 2023"),
        CustomerId = 115
    },
};

    private Good[] DBGoods = new Good[]
    {

    };

    public Good[] Goods
    {
        get { return DBGoods; }
    }

    public Customer[] Cusomers
    {
        get { return DBCustomers; }
    }

    public Manager[] Managers
    {
        get { return DBManagers; }
    }
    public Order[] Orders
    {
        get { return DBOrders; }
    }

    public Article[] Articles
    {
        get { return DBArticles; }
    }

    public FeedbackOrComplains[] FeedBacks
    {
        get { return DBFeedBacks; }
    }
}

