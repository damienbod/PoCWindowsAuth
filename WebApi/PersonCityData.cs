﻿using System.Collections.Generic;

namespace WebApi
{
    public static class PersonCityData
    {

        public static List<PersonCity> Data = new List<PersonCity>();

        public static void CreateTestData()
        {
            Data.Add(new PersonCity
            {
                Id = "1",
                Name = "Damien",
                FamilyName = "Bowden",
                CityCountry = "Switzerland",
                Metadata = "ASP.NET Core Azure OAuth FIDO2 OIDC EFCore SQLite  Typescript Javascript Angular",
                Info = "I am an engineer, Microsoft MVP, living in Switzerland interested in web development. I am living in Switzerland interested in web development, application security and Azure. My favourite technologies/specifications are ASP.NET Core, OpenID Connect, OAuth, FIDO2, SQL, EF Core, Angular, Typescript.",
                Web = "https://damienbod.com",
                Twitter = "https://twitter.com/damien_bod",
                Github = "https://github.com/damienbod",
                Mvp = "https://mvp.microsoft.com/en-us/PublicProfile/5002218"
            });

            Data.Add(new PersonCity
            {
                Id = "2",
                Name = "Fabian",
                FamilyName = "Grossbrink",
                CityCountry = "Switzerland St Gallen",
                Metadata = "Angular ASP.NET Core Typescript Javascript",
                Info = "Fabian Gosebrink is Microsoft MVP, Google Developer Expert. Pluralsight author and Angular & ASP.NET Core web developer. As a software engineer, consultant, speaker and trainer, he supports customers building web applications with more than 10 years of experience.",
                Web = "http://fabian-gosebrink.com/",
                Twitter = "https://twitter.com/FabianGosebrink",
                Github = "https://github.com/FabianGosebrink",
                Mvp = "https://mvp.microsoft.com/en-us/PublicProfile/5001666?fullName=Fabian%20%20Gosebrink"
            });

            Data.Add(new PersonCity
            {
                Id = "3",
                Name = "Jürgen",
                FamilyName = "Gutsch",
                CityCountry = "Switzerland Basel",
                Metadata = "ASP.NET Core Angular Typescript javascript Azure",
                Info = "Jürgen Gutsch is software developer, consultant and trainer at the YooApplications AG (yooapps.com) in Basel (Switzerland). Along with family and job, he is a free author trainer und consultant, writes about ASP.NET, .NET, web technologies and Community in a blog on http://asp.net-hacker.rocks und leads the .NET user group in Basel (Switzerland)",
                Web = "http://asp.net-hacker.rocks/",
                Twitter = "https://twitter.com/sharpcms",
                Github = "https://github.com/JuergenGutsch",
                Mvp = "https://mvp.microsoft.com/en-us/PublicProfile/5001508?fullName=J%C3%BCrgen%20%20Gutsch"
            });

            Data.Add(new PersonCity
            {
                Id = "4",
                Name = "Benjamin",
                FamilyName = "Abt",
                CityCountry = "Germany",
                Metadata = "ASP.NET Core Azure Angular TypeScript",
                Info = "Benjamin Abt is a software architect and developer focused on .NET, ASP.NET, Azure, AngularJS and TypeScript. He became an ASP.NET/IIS MVP on July, 2015. Studio is his second home. He's an administrator and moderator of the largest german-speaking C# forum, www.mycsharp.de and he spends a lot of time supporting other users on their problems and projects. His blog SCHWABENCODE.com is well known in the german - speaking community. It's focused on german, because he thinks the DACH region has great developers, is a great location for research and development but still there are a lot of developers who do easier with their native language. On GitHub you can follow him on https://github.com/SchwabenCode/ for releases and https://github.com/BenjaminAbt for samples. Ben currently works as Software Architect focused on.NET and Cloud technologies.",
                Web = "http://www.benjamin-abt.com",
                Twitter = "https://twitter.com/SCHWABENCODEcom",
                Github = "https://github.com/BenjaminAbt",
                Mvp = "https://mvp.microsoft.com/en-us/PublicProfile/5001507?fullName=Benjamin%20%20Abt"
            });

            Data.Add(new PersonCity
            {
                Id = "5",
                Name = "Alexander",
                FamilyName = "Zeitler",
                CityCountry = "Germany Karlsruhe, BW",
                Metadata = "ASP.NET MVC Web API",
                Info = "Alexander Zeitler is a self-employed Web Developer who has spent 17 years working mainly for the tooling and machining industry as well as plant manufacturing, where he works mainly with ASP.NET MVC and now ASP.NET Web API on the server side and HTML5, CSS3 and JavaScript on the client side. He has been rewarded repeatedly with the Microsoft MVP award in ASP.NET for his engagement with the German.NET community and he maintains a blog at http://blog.alexonasp.net, which he has kept since 2003.",
                Web = "https://alexanderzeitler.com/",
                Twitter = "https://twitter.com/alexzeitler_",
                Github = "https://github.com/alexzeitler",
                Mvp = "https://mvp.microsoft.com/en-us/PublicProfile/10225?fullName=Alexander%20%20Zeitler"
            });

            Data.Add(new PersonCity
            {
                Id = "6",
                Name = "Christos",
                FamilyName = "Sakellarios",
                CityCountry = "Greece Athens Attica",
                Metadata = "ASP.NET MVC  Web API Typescript security",
                Info = "Senior Web Developer Blogger ",
                Web = "https://chsakell.com/",
                Twitter = "https://twitter.com/chsakellsblog",
                Github = "https://github.com/chsakell",
                Mvp = "https://mvp.microsoft.com/en-us/PublicProfile/5002193?fullName=Christos%20%20Sakellarios"
            });

            Data.Add(new PersonCity
            {
                Id = "7",
                Name = "Ali Tugberk",
                FamilyName = "Ugurlu",
                CityCountry = "United Kingdom Cambridge",
                Metadata = "ASP.NET MVC Web API",
                Info = "I am a web guy, Microsoft MVP and software developer specialized mainly on .NET Web technologies. I've worked at the tourism industry to build tourism software services and products for long time and now, I am working at Redgate Software as a Software Engineer helping people do database delivery in a joyful way. I am also a very involved member in the community and try my way to expose my knowledge to others through my blog, webcasts, authoring books, giving talks on various topics and so on. I live in lovely and green Cambridge, UK and I am married to a lovely woman.",
                Web = "http://www.tugberkugurlu.com",
                Twitter = "https://twitter.com/tourismgeek",
                Github = "https://github.com/tugberkugurlu",
                Mvp = "https://mvp.microsoft.com/en-us/PublicProfile/4039968?fullName=Ali%20Tugberk%20%20Ugurlu"
            });

            Data.Add(new PersonCity
            {
                Id = "8",
                Name = "Scott",
                FamilyName = "Hanselman",
                CityCountry = "USA",
                Metadata = "ASP.NET Core Web API Azure",
                Info = "My name is Scott Hanselman. I'm a programmer, teacher, and speaker. I work out of my home office in Portland, Oregon for the Web Platform Team at Microsoft, but this blog, its content and opinions are my own. I blog about technology, culture, gadgets, diversity, code, the web, where we're going and where we've been. I'm excited about community, social equity, media, entrepreneurship and above all, the open web.",
                Web = "http://www.hanselman.com/",
                Twitter = "https://twitter.com/shanselman",
                Github = "https://github.com/shanselman",
                Mvp = ""
            });

            Data.Add(new PersonCity
            {
                Id = "9",
                Name = "Roberto",
                FamilyName = "Simonetti",
                CityCountry = "Italy",
                Metadata = ".NET TypeScript Angular ASP.NET Core",
                Info = "My passion was born with Basic on TI-99/4A & Commodore. At school I discovered Turbo Pascal & Java. I loved Visual Basic, .NET, and now TypeScript & Angular.",
                Web = "https://github.com/robisim74",
                Twitter = "https://twitter.com/robisim74",
                Github = "https://github.com/robisim74",
                Mvp = ""
            });

            Data.Add(new PersonCity
            {
                Id = "10",
                Name = "John",
                FamilyName = "Papa",
                CityCountry = "USA",
                Metadata = "Angular Vue.js Javascript",
                Info = "Hi, I'm John Papa. I author this blog, create courses for Pluralsight and am a Google Developer Expert and Microsoft Regional Director. I speak at events and train technology thought leaders",
                Web = "https://johnpapa.net/about/",
                Twitter = "https://twitter.com/john_papa",
                Github = "https://github.com/johnpapa",
                Mvp = "https://mvp.microsoft.com/en-us/PublicProfile/4040095?fullName=John%20%20Papa"
            });

            Data.Add(new PersonCity
            {
                Id = "11",
                Name = "Dan",
                FamilyName = "Wahlin",
                CityCountry = "USA",
                Metadata = "JavaScript Angular Node.js, C# ASP.NET MVC Web API Docker",
                Info = "Dan Wahlin founded Wahlin Consulting which provides consulting and training services on Web technologies such as JavaScript, Angular, Node.js, C#, ASP.NET MVC, Web API, and Docker. He’s also published over 10 developer courses on Pluralsight.com and Udemy.com including the new Docker for Web Developers course. Dan is a Microsoft MVP and Regional Director and speaks at conferences and user groups around the world.  Dan has written several books on Web technologies, hundreds of technical articles and blog posts (http://blog.codewithdan.com) and runs the Web Weekly newsletter - a great way to stay up on the latest technologies. Follow Dan on Twitter @DanWahlin.",
                Web = "https://blog.codewithdan.com/",
                Twitter = "https://twitter.com/danwahlin",
                Github = "https://github.com/danwahlin",
                Mvp = "https://mvp.microsoft.com/en-us/PublicProfile/7586?fullName=Dan%20%20Wahlin"
            });

            Data.Add(new PersonCity
            {
                Id = "12",
                Name = "Jeremy",
                FamilyName = "Likness",
                CityCountry = "USA",
                Metadata = "Entity Framework EFCore Azure JavaScript Angular C# ASP.NET",
                Info = "Jeremy Likness leads the application development practice for Atlanta-based iVision and is an experienced entrepreneur and technology executive who has successfully helped ship commercial enterprise software for 20 years. He specializes in catalyzing growth, developing ideas and creating value through delivering software in technical enterprises. His roles as business owner, technology executive and hands-on developer provided unique opportunities to directly impact the bottom line of multiple businesses by helping them grow and increase their organizational capacity while improving operational efficiency. He has worked with several initially small companies like Manhattan Associates and AirWatch before they grew large and experienced their transition from good to great while helping direct vision and strategy to embrace changing technology and markets. Jeremy is capable of quickly adapting to new paradigms and helps technology teams endure change by providing strong leadership, working with team members “in the trenches” and mentoring them in the soft skills that are key for engineers to bridge the gap between business and technology.",
                Web = "http://csharperimage.jeremylikness.com/",
                Twitter = "https://twitter.com/jeremylikness",
                Github = "https://github.com/jeremylikness",
                Mvp = "https://mvp.microsoft.com/en-us/PublicProfile/4028936?fullName=Jeremy%20%20Likness"
            });

            Data.Add(new PersonCity
            {
                Id = "13",
                Name = "Julie",
                FamilyName = "Lerman",
                CityCountry = "USA Vermont",
                Metadata = "Entity Framework EFCore C# ASP.NET PostgreSQL DDD Microsoft MVP",
                Info = "Vermont Geekette, DDD, .NET (& EF) Mentor, Author, MS MVP, MS Regional Director, VTdotNET, Pluralsight, MSDN Mag. Talk to me about mentoring your dev team!",
                Web = "http://thedatafarm.com/blog/",
                Twitter = "https://twitter.com/julielerman",
                Github = "https://github.com/julielerman",
                Mvp = "https://mvp.microsoft.com/en-us/PublicProfile/8987?fullName=Julie%20%20Lerman"
            });

            Data.Add(new PersonCity
            {
                Id = "14",
                Name = "Kurata",
                FamilyName = "Deborah",
                CityCountry = "Pleasanton, CA",
                Metadata = "Angular",
                Info = "Software developer, independent consultant, Pluralsight author, speaker, Microsoft MVP, Google GDE. Co-chair of Eastbay .NET, which meets in Berkeley.",
                Web = "http://blogs.msmvps.com/deborahk/",
                Twitter = "https://twitter.com/DeborahKurata",
                Github = "https://github.com/DeborahK",
                Mvp = "https://mvp.microsoft.com/en-us/PublicProfile/10169?fullName=Deborah%20%20Kurata"
            });

            Data.Add(new PersonCity
            {
                Id = "15",
                Name = "Andrew",
                FamilyName = "Lock",
                CityCountry = "Plymouth, UK",
                Metadata = "ASP.NET Core .NET",
                Info = "My name is Andrew Lock, though everyone knows me as ‘Sock’. I am a full-time developer, working predominantly in full stack ASP.NET development in Devon, UK. I graduated with an MEng in Engineering from Cambridge University in 2008, and completed my PhD in Medical Image Processing in 2014. I have experience primarily with C# and VB ASP.NET, working both in MVC and WebForms, but have also worked professionally with C++ and WinForms. ",
                Web = "http://andrewlock.net/",
                Twitter = "https://twitter.com/andrewlocknet",
                Github = "https://github.com/andrewlock",
                Mvp = ""
            });

            Data.Add(new PersonCity
            {
                Id = "16",
                Name = "Brock",
                FamilyName = "Allen",
                CityCountry = "Barrington, RI USA",
                Metadata = "ASP.NET Core security identityserver oidc javascript",
                Info = "Currently Brock is an independent consultant specializing in .NET, web development, and web - based security with 20 years of industry experience.Brock is the co - author of many security - related open source frameworks including IdentityServer, IdentityManager, and MembershipReboot.He also frequently posts to the ASP.NET forums, is a MVP for ASP.NET / IIS, a member of ASPInsiders and a contributor to the ASP.NET platform. Brock lives in Barrington, RI and can be reached at brockallen@gmail.com.",
                Web = "https://brockallen.com/",
                Twitter = "https://twitter.com/brocklallen",
                Github = "https://github.com/brockallen",
                Mvp = "https://mvp.microsoft.com/en-us/PublicProfile/4039969?fullName=Brock%20%20Allen"
            });

            Data.Add(new PersonCity
            {
                Id = "17",
                Name = "Dominick",
                FamilyName = "Baier",
                CityCountry = "Germany",
                Metadata = "ASP.NET Core security identityserver",
                Info = "I am an independent consultant specializing in identity & access control. I help companies around the world designing & implementing authentication and authorization for their distributed web and native applications. I am the co-author of the popular OpenID Connect & OAuth 2.0 framework called IdentityServer (http://identityserver.io) , have written a couple of books and tweet as @leastprivilege.",
                Web = "https://leastprivilege.com/",
                Twitter = "https://twitter.com/leastprivilege",
                Github = "https://github.com/leastprivilege",
                Mvp = "https://mvp.microsoft.com/en-us/PublicProfile/21554?fullName=Dominick%20%20Baier"
            });

            Data.Add(new PersonCity
            {
                Id = "18",
                Name = "Scott",
                FamilyName = "Brady",
                CityCountry = "Bristol, United Kingdom",
                Metadata = "ASP.NET Core security identityserver",
                Info = "I am a Senior Software Engineer at Rock Solid Knowledge. We offer software development consultancy, development and training services with myself specialising in all things Identity Server. I work predominantly in C# back-end and middleware systems with the beginnings of a specialisation in web security. I have had a focus on cloud computing since my MSc dissertation in 2013, gaining experience using various cloud based PaaS and IaaS offerings ever since. ",
                Web = "https://www.scottbrady91.com/",
                Twitter = "https://twitter.com/scottbrady91",
                Github = "https://github.com/scottbrady91",
                Mvp = ""
            });

            Data.Add(new PersonCity
            {
                Id = "19",
                Name = "Shawn",
                FamilyName = "Wildermuth",
                CityCountry = "USA",
                Metadata = "ASP.NET Core .NET C# Vue.JS",
                Info = "Shawn Wildermuth is a fourteen-time Microsoft MVP (ASP.NET/IIS) and is involved with Microsoft as an ASP.NET Insider, ClientDev Insider and Windows Phone Insider. You may have taken one of his more than twenty courses for Pluralsight including Building a Web App with ASP.NET Core, MVC, EF and Angular and Bootstrap 3. He is also the author of eight books and dozens of articles on software development. He has been seen speaking at a variety of international conferences including TechEd, Oredev, SDC, VSLive, DevIntersection, MIX, DevTeach, DevConnections and DevReach. He is one of the Wilder Minds LLC.",
                Web = "http://wildermuth.com/",
                Twitter = "https://twitter.com/shawnwildermuth",
                Github = "https://github.com/shawnwildermuth",
                Mvp = "https://mvp.microsoft.com/en-us/PublicProfile/9072?fullName=Shawn%20%20Wildermuth"
            });

            Data.Add(new PersonCity
            {
                Id = "20",
                Name = "Minko",
                FamilyName = "Gechev",
                CityCountry = "San Francisco, California USA",
                Metadata = "Angular JavaScript",
                Info = "I created a JavaScript user group in Sofia, which has (had) regular Beer.js meet-ups. For about fifteen years I’ve been training karate (since 1999) and since 2005 I’ve been using different programming languages (including Pascal, Haskell, C, C++, PHP, JavaScript, Io, Java, AspectJ, C#, VisualBasic, Ruby, Python, Perl, ActionScript, Prolog…even Clips) so as you might see I’ve met different programming paradigms – functional, object-oriented, prototype-based oo, aspect-oriented, logical programming, procedural…I just don’t have a patience to see what’s coming next after the OO “dictatorship” :-).",
                Web = "http://blog.mgechev.com/",
                Twitter = "https://twitter.com/mgechev",
                Github = "https://github.com/mgechev",
                Mvp = ""
            });

            Data.Add(new PersonCity
            {
                Id = "21",
                Name = "Mike",
                FamilyName = "Brind",
                CityCountry = "Rochester  United Kingdom",
                Metadata = "ASP.NET Core MVC EFCore SQL",
                Info = "Despite that (or perhaps because of it) I have been awarded Microsoft MVP for ASP/ASP.NET each year since 2008. I wrote a book for Wrox that covers the ASP.NET Web Pages framework and working with WebMatrix. It's called Beginning ASP.NET Web Pages With WebMatrix. I have been developing web sites since 2002, and am completely self-taught. I live in Rochester in the UK.",
                Web = "http://www.mikesdotnetting.com/",
                Twitter = "https://twitter.com/mikesdotnetting",
                Github = "",
                Mvp = "https://mvp.microsoft.com/en-us/PublicProfile/4015684?fullName=Mike%20%20Brind"
            });

            Data.Add(new PersonCity
            {
                Id = "22",
                Name = "Rion",
                FamilyName = "Williams",
                CityCountry = "Lake Charles, Louisiana USA",
                Metadata = "ASP.NET Core MVC EFCore SQL javascript",
                Info = "Rion is an experienced, Full Stack Software Developer and Designer from Lake Charles, Louisiana. He is currently the Senior Software Developer at Structure X, a Systems Integrator and Software Development firm focusing in Healthcare. Rion graduated with three degrees (Computer Science, Mathematics and Visual Arts) from McNeese State University and has been building applications in the industrial and healthcare arenas ever since.",
                Web = "http://rion.io/",
                Twitter = "https://twitter.com/rionmonster",
                Github = "https://github.com/rionmonster",
                Mvp = "http://mvp.microsoft.com/en-us/MVP/Rion%20Williams-5000660"
            });

            Data.Add(new PersonCity
            {
                Id = "23",
                Name = "Shayne",
                FamilyName = "Boyer",
                CityCountry = "Florida, USA",
                Metadata = "ASP.NET Core Node.js JavaScript TypeScript Microsoft Azure Angular Mobile Development Microsoft MVP",
                Info = "Hi, I'm Shayne Boyer, I write this site, am a Microsoft MVP and Telerik Developer Expert who speaks at national and community events while helping teams architect web and cloud applications",
                Web = "http://tattoocoder.com/",
                Twitter = "https://twitter.com/spboyer",
                Github = "https://github.com/tattoocoder",
                Mvp = "https://mvp.microsoft.com/en-us/PublicProfile/5000582?fullName=Shayne%20%20Boyer"
            });

            Data.Add(new PersonCity
            {
                Id = "24",
                Name = "Torgeir",
                FamilyName = "Helgevold",
                CityCountry = "New York USA",
                Metadata = "Angular React Javascript",
                Info = "Software Engineer. Focusing on Angular 2.0 these days ",
                Web = "http://www.syntaxsuccess.com/",
                Twitter = "https://twitter.com/helgevold",
                Github = "https://github.com/thelgevold/",
                Mvp = ""
            });

            Data.Add(new PersonCity
            {
                Id = "25",
                Name = "Rob",
                FamilyName = "Wormald",
                CityCountry = "Mountain View CA",
                Metadata = "Angular",
                Info = "I’m a Javascripter, currently spending most of my time working on Angular2. ",
                Web = "http://www.roblog.io/",
                Twitter = "https://twitter.com/robwormald",
                Github = "https://github.com/robwormald",
                Mvp = ""
            });

            Data.Add(new PersonCity
            {
                Id = "26",
                Name = "Brad",
                FamilyName = "Green",
                CityCountry = "Mountain View CA",
                Metadata = "Angular",
                Info = "Engineering director at Google where I manage AngularJS and GreenTea (CRM). Also, I have 2 children and 4 chickens. Chickens are easier. ",
                Web = "https://plus.google.com/+BradGreen",
                Twitter = "https://twitter.com/bradlygreen",
                Github = "https://github.com/bradlygreen",
                Mvp = ""
            });

            Data.Add(new PersonCity
            {
                Id = "27",
                Name = "Victor",
                FamilyName = "Savkin",
                CityCountry = "Mountain View CA",
                Metadata = "Angular",
                Info = "Victor toys with eclectic programming technologies and obsesses over fonts and keyboard layouts. He also makes Angular.",
                Web = "https://vsavkin.com/",
                Twitter = "https://twitter.com/victorsavkin",
                Github = "https://github.com/vsavkin",
                Mvp = ""
            });

            Data.Add(new PersonCity
            {
                Id = "28",
                Name = "Todd",
                FamilyName = "Motto",
                CityCountry = "England UK",
                Metadata = "Angular",
                Info = "I’m Todd, a 26 year old front-end engineer from England, UK, working as a Developer Advocate at Telerik. Co-Founder of Ultimate Angular, a project to bring the Angular 1.x and Angular 2 ecosystem to developers through online courses. I’m also a Developer Expert at Google, conference speaker and open source lover.",
                Web = "https://toddmotto.com",
                Twitter = "https://twitter.com/toddmotto",
                Github = "https://github.com/toddmotto",
                Mvp = ""
            });

            Data.Add(new PersonCity
            {
                Id = "29",
                Name = "Pascal",
                FamilyName = "Precht",
                CityCountry = "Hanover Germany ",
                Metadata = "Angular",
                Info = "I like headphones, art, skateboarding and coding. Angular GDE at @Google, @thoughtram co-founder and creator of @5thingsAngular.",
                Web = "http://thoughtram.io/",
                Twitter = "https://twitter.com/PascalPrecht",
                Github = "https://github.com/PascalPrecht",
                Mvp = ""
            });

            Data.Add(new PersonCity
            {
                Id = "30",
                Name = "Martijn",
                FamilyName = "Laarman",
                CityCountry = "Amsterdam, Netherlands ",
                Metadata = "elasticsearch nest C# .NET",
                Info = "I work for Elasticsearch as .NET developer. ",
                Web = "http://localghost.io/",
                Twitter = "https://twitter.com/mpdreamz",
                Github = "https://github.com/Mpdreamz",
                Mvp = ""
            });

            Data.Add(new PersonCity
            {
                Id = "31",
                Name = "Troy",
                FamilyName = "Hunt",
                CityCountry = " Australia",
                Metadata = "security .NET",
                Info = "I'm Troy Hunt, an Australian Microsoft Regional Director and also a Microsoft Most Valuable Professional for Developer Security. I don't work for Microsoft, but they're kind enough to recognise my community contributions by way of their award programs which I've been an awardee of since 2011. I get to interact with some fantastic people building their best products and then share what I know about creating secure applications for the web with the broader community.",
                Web = "https://www.troyhunt.com/",
                Twitter = "https://twitter.com/troyhunt",
                Github = "",
                Mvp = "https://mvp.microsoft.com/en-us/PublicProfile/4031649?fullName=Troy%20%20Hunt"
            });

            Data.Add(new PersonCity
            {
                Id = "32",
                Name = "Rick",
                FamilyName = "Strahl",
                CityCountry = " Paia, HI ",
                Metadata = " ASPNET, C#, HTML5, Mobile, JavaScript, Angular",
                Info = "Wind, waves, code and everything in between... ASP.NET • C# • HTML5 • JavaScript • AngularJs ",
                Web = "https://weblog.west-wind.com/",
                Twitter = "https://twitter.com/RickStrahl",
                Github = "https://github.com/RickStrahl",
                Mvp = "https://mvp.microsoft.com/en-us/PublicProfile/5000249?fullName=Rick%20Strahl"
            });

            Data.Add(new PersonCity
            {
                Id = "33",
                Name = "Taiseer",
                FamilyName = "Joudeh",
                CityCountry = "Jordan",
                Metadata = " ASPNET, C#, HTML5, JavaScript, Angular Microsoft",
                Info = "My name is Taiseer Joudeh and this is my professional blog. I consider myself a passionate software engineer who is always willing to learn and explore new technologies, then apply it in real world scenarios and share this knowledge with the community. I have more than 10 years of experience spent in developing and managing different software solutions for finance, transportation, logistics, and e - commerce sectors.I’ve been deeply involved in .NET development since early framework versions and currently I work on different technologies on the ASP.NET stack with deep passion for Web API, and Microsoft Azure.Recently I’ve been focusing on building Single Page Applications, Hybrid Mobile Solutions using AngularJS, and focusing on the building identity solutions for modern apps. I have been awarded the Microsoft Most Valuable Professional(MVP) Award for the years 2015 and 2016 in the Visual Studio and Development Technologies, also I’m a regular speaker in local events and Dev user groups.",
                Web = "http://bitoftech.net/",
                Twitter = "https://twitter.com/TJoudeh",
                Github = "https://github.com/tjoudeh",
                Mvp = ""
            });

            Data.Add(new PersonCity
            {
                Id = "34",
                Name = "Simon",
                FamilyName = "Rigby",
                CityCountry = "USA",
                Metadata = " ASPNET, C#, HTML5, JavaScript, Angular Microsoft responsive design",
                Info = "Hey there. Nice to meet you. Let me introduce myself. My name is Simon Rigby. I've been working in the web industry since the end of that first dotcom boom. In that time I've been lucky enough to work for/with some great companies. I've rubbed shoulders with some top notch techies and savvy business owners. I've learned a lot of great things along the way, from keys to success to mistakes to avoid. And I bring all that experience to the table in every project I work on. Which means, if we work together, you get that benefit too. ",
                Web = "http://levelnis.co.uk/blog",
                Twitter = "https://twitter.com/levelnis",
                Github = "https://github.com/levelnis",
                Mvp = ""
            });

            Data.Add(new PersonCity
            {
                Id = "35",
                Name = "Scott",
                FamilyName = "Addie",
                CityCountry = "Verona, WI USA",
                Metadata = " ASP.NET Core, C# Microsoft MVP JavaScript  OSS",
                Info = "Scott Addie is an ambitious, self-driven software architect & technical evangelist specializing in JavaScript and the modern Microsoft web stack. He is a Microsoft Certified Solutions Developer (MCSD – Web Applications), a Microsoft MVP (Visual Studio and Development Technologies), a frequent conference, code camp, and user group attendee, an ASP.NET and JavaScript blogger, and a technical speaker who has been developing enterprise web applications professionally since 2005. Scott lives in Madison, WI with his wife and 3 children.When not hacking away at an ASP.NET Core side project or slinging code on the latest JavaScript libraries / frameworks, he can be found spending time with his family. ",
                Web = "https://scottaddie.com/",
                Twitter = "https://twitter.com/Scott_Addie",
                Github = "https://github.com/scottaddie",
                Mvp = "https://mvp.microsoft.com/en-us/PublicProfile/5001850?fullName=Scott%20%20Addie"
            });

            Data.Add(new PersonCity
            {
                Id = "36",
                Name = "Jon",
                FamilyName = "Galloway",
                CityCountry = "Rancho San Diego, CA  USA",
                Metadata = " ASP.NET Core C# Microsoft JavaScript",
                Info = "Jon works at Microsoft as a Technical Evangelist focused on ASP.NET and Windows Azure. He’s co-author of Wrox Professional ASP.NET MVC, writes samples and tutorials like the MVC Music Store and is a frequent speaker at conferences and international Web Camps events. Jon’s been doing professional web development for 17 years, including high scale applications in financial, entertainment and healthcare analytics. He’s part of the Herding Code podcast, Twitters as @jongalloway and blogs at http://weblogs.asp.net/jongalloway. He likes to travel, but spends most of his time in San Diego with his amazingly patient wife Rachel, three wonderful daughters, a dozen avocado trees and the occasional rattlesnake.",
                Web = "https://weblogs.asp.net/jongalloway/",
                Twitter = "https://twitter.com/jongalloway",
                Github = "https://github.com/jongalloway",
                Mvp = ""
            });

            Data.Add(new PersonCity
            {
                Id = "37",
                Name = "David",
                FamilyName = "Fowler",
                CityCountry = "Redmond USA",
                Metadata = " ASP.NET Core C# Microsoft SignalR",
                Info = "Software Developer at Microsoft on the http://ASP.NET  team, Creator of SignalR, http://ASP.NET  Core Architect, Tennis Player, Father and Husband",
                Web = "http://davidfowl.com/",
                Twitter = "https://twitter.com/davidfowl",
                Github = "https://github.com/davidfowl",
                Mvp = ""
            });

            Data.Add(new PersonCity
            {
                Id = "38",
                Name = "Steve",
                FamilyName = "Smith",
                CityCountry = "Kent OH USA",
                Metadata = " ASP.NET Core C# Microsoft DDD",
                Info = "Speaker, Author, and Software Craftsman. Microsoft MVP. Available for training / mentoring on DDD, ASPNET Core, and quality software: http://ardalis.com",
                Web = "http://ardalis.com/",
                Twitter = "https://twitter.com/ardalis",
                Github = "https://github.com/davidfowl",
                Mvp = ""
            });

            Data.Add(new PersonCity
            {
                Id = "39",
                Name = "Barry",
                FamilyName = "Dorrans",
                CityCountry = "Redmond USA",
                Metadata = " ASP.NET Core C# Microsoft Security",
                Info = "Sweary Security Snark. Microsoft's .NET security person. Opinions here are mine and not speaking on behalf of Microsoft or Microsoft Security.",
                Web = "https://idunno.org/",
                Twitter = "https://twitter.com/blowdart",
                Github = "https://github.com/blowdart",
                Mvp = ""
            });

            Data.Add(new PersonCity
            {
                Id = "40",
                Name = "Brice",
                FamilyName = "Lambson",
                CityCountry = "Redmond USA",
                Metadata = " ASP.NET Core C# Microsoft Entity Framework EFCore",
                Info = "Hello, my name is Brice Lambson. I’m a senior software engineer on the Entity Framework team at Microsoft. In my spare time, I enjoy giving back to the community through blogging and open source.",
                Web = "http://www.bricelam.net/",
                Twitter = "https://twitter.com/bricelambs",
                Github = "https://github.com/bricelam",
                Mvp = ""
            });

            Data.Add(new PersonCity
            {
                Id = "41",
                Name = "Mark",
                FamilyName = "Allibone",
                CityCountry = "Switzerland",
                Metadata = "Certified Xamarin Developer & Mobile Consultant",
                Info = "Mark Allibone is a qualified expert and enthusiast for mobile technologies at Rey Automation and a Microsoft MVP. He supports many well-known companies with their mobile ambitions in the fields of healthcare, industry, tourism and public transport apps that integrate seamlessly with other systems and devices. With a passion for efficient cross-platform solutions and a heart for the user, Mark does not solely aim to build functionally complete apps, but apps that enable the user.",
                Web = "https://mallibone.com/",
                Twitter = "https://twitter.com/mallibone",
                Github = "https://github.com/mallibone",
                Mvp = "https://mvp.microsoft.com/en-us/PublicProfile/5002881?fullName=Mark%20Allibone"
            });

            Data.Add(new PersonCity
            {
                Id = "42",
                Name = "Matteo",
                FamilyName = "Locker",
                CityCountry = "Switzerland",
                Metadata = "ASP.NET Core Azure ",
                Info = "I am a software engineer based in Bern, Switzerland. I work in a medium size company and focus on developing business web applications using .NET technologies like ASP.NET Core MVC, Entity Framework Core and some client frameworks like Bootstrap and jQuery. I am a tech enthusiast and I really like to try out the newest ASP.NET Core stuff and share my learnings with the community.",
                Web = "https://ml-software.ch/",
                Twitter = "https://twitter.com/matteolocher",
                Github = "https://github.com/Franklin89",
                Mvp = ""
            });

            Data.Add(new PersonCity
            {
                Id = "43",
                Name = "Laurent",
                FamilyName = "Bugnion",
                CityCountry = "Switzerland",
                Metadata = "Azure MVVM Xamarin",
                Info = "Laurent works as Senior Cloud Developer Advocate for Microsoft Azure after almost 10 years spent working for IdentityMine and Valorem, two leading firms in Microsoft technologies. He codes in Azure, .NET, Windows, WPF, Xamarin (iOS and Android), ASP.NET (Core and Classic). On his free time, he writes for technical publications such as MSDN Magazine, publishes technical videos on YouTube and Microsoft Channel 9, and his blog is on blog.galasoft.ch. He is a frequent speaker at conferences such as Microsoft Ignite, Microsoft Build, TechEd, VS Live, Techorama and many other international events. Prior to joining Microsoft, he was a Microsoft Most Valuable Professional for Windows development from 2007 to 2017, a Microsoft Regional Director from 2013 and a Xamarin Most Valuable Professional from 2015. He is also the author of the well-known open source framework MVVM Light for Windows, WPF and Xamarin.",
                Web = "https://galasoft.ch/",
                Twitter = "https://twitter.com/LBugnion",
                Github = "https://github.com/lbugnion",
                Mvp = ""
            });

            Data.Add(new PersonCity
            {
                Id = "44",
                Name = "Steve",
                FamilyName = "Gordon",
                CityCountry = "East Sussex United Kingdom",
                Metadata = ".NET Core ASP.NET Core AWS elasticsearch nest C#",
                Info = "Steve Gordon is a senior developer based in Brighton, UK and Microsoft MVP. He works for Madgex (www.madgex.com) developing and supporting their new product portfolio built on ASP.NET Core technologies. Madgex Ltd are a market-leading SaaS provider of Job Board and Course Board platforms, relied upon by the world's most successful media owners, online recruitment businesses and associations. Steve is passionate about all things .NET related and has worked with ASP.NET on and off for over 15 years. He is currently most focused on ASP.NET Core and Docker to build microservice APIs. He enjoys sharing his knowledge through his blog and at by giving talks at user groups and conferences. Steve is excited by the .NET community and has recently founded .NET South East, a Brighton based, .NET User Group. He enjoys contributing to and maintaining OSS projects, most actively to the Humanitarian Toolbox (https://github.com/htbox/allready). You can find Steve online at his blog www.stevejgordon.co.uk and on Twitter @stevejgordon.",
                Web = "https://www.stevejgordon.co.uk/",
                Twitter = "https://twitter.com/stevejgordon",
                Github = "https://github.com/stevejgordon",
                Mvp = "https://mvp.microsoft.com/en-us/PublicProfile/5002866"
            });

            Data.Add(new PersonCity
            {
                Id = "45",
                Name = "Manuel",
                FamilyName = "Meyer",
                CityCountry = "Zurich Switzerland",
                Metadata = "Azure ",
                Info = "Manuel Meyer is a principal consultant and trainer for .NET. He works for Trivadis AG (www.trivadis.com), a Switzerland based consulting company.  He regularly shares his knowledge in technical articles or as a speaker at conferences. He has a deep interest in technology. You can find him at www.manuelmeyer.net. He organizes the Azure Zurich User Group (www.azurezurichusergroup.com) and the .NET Day Switzerland (www.dotnetday.ch).",
                Web = "https://manuelmeyer.net/",
                Twitter = "https://twitter.com/manumeyer1",
                Github = "https://github.com/manuelmeyer1",
                Mvp = "https://mvp.microsoft.com/en-us/PublicProfile/5001968?fullName=Manuel%20Meyer"
            });

            Data.Add(new PersonCity
            {
                Id = "46",
                Name = "Emanuele",
                FamilyName = "Bartolesi",
                CityCountry = "Zurich Switzerland",
                Metadata = "Azure Blazor ASP.NET Core Web",
                Info = "I'm a Full Stack Web Developer and I'm passionate about frontend technologies and everything related to the cloud, especially Microsoft Azure. I currently live in Zurich and actively participate in local and international community activities and events.",
                Web = "https://dev.to/kasuken",
                Twitter = "https://twitter.com/kasuken",
                Github = "https://github.com/kasuken",
                Mvp = "https://mvp.microsoft.com/en-us/PublicProfile/5000868?fullName=Emanuele%20Bartolesi"
            });

            Data.Add(new PersonCity
            {
                Id = "47",
                Name = "Rico",
                FamilyName = "Suter",
                CityCountry = "Switzerland",
                Metadata = "ASP.NET Core NSwag",
                Info = "Independent Software Engineer and Architect focusing on .NET and Microsoft technologies. Creator of NSwag, NJsonSchema and MyToolkit for .NET",
                Web = "https://blog.rsuter.com/",
                Twitter = "https://twitter.com/RicoSuter",
                Github = "https://github.com/RicoSuter",
                Mvp = "https://mvp.microsoft.com/en-us/PublicProfile/5002807?fullName=Rico%20Suter"
            });

            Data.Add(new PersonCity
            {
                Id = "48",
                Name = "Robert",
                FamilyName = "Muehsig",
                CityCountry = "Switzerland",
                Metadata = "ASP.NET Core",
                Info = "Robert Muehsig is a Senior Software Developer at Sevitec Informatik AG. He is a passionate web developer and loves ASP.NET, Javascript and the web.",
                Web = "https://blog.codeinside.eu/",
                Twitter = "https://twitter.com/robert0muehsig",
                Github = "https://github.com/robertmuehsig",
                Mvp = "https://mvp.microsoft.com/en-us/PublicProfile/4020675?fullName=Robert%20Muehsig"
            });

            //Data.Add(new PersonCity
            //{
            //    Id = "49",
            //    Name = "",
            //    FamilyName = "",
            //    CityCountry = "",
            //    Metadata = "",
            //    Info = "",
            //    Web = "",
            //    Twitter = "",
            //    Github = "",
            //    Mvp = ""
            //});

        }
    }
}
