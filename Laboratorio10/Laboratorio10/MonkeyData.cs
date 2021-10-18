using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio10
{
    public static class MonkeyData
    {
        public static IList<Monkey> Monkeys { get; private set; }

        static MonkeyData()
        {
            Monkeys = new List<Monkey>();

            Monkeys.Add(new Monkey
            {
                Name = "Baboon",
                Location = "Africa & Asia",
                Details = "Baboons are African and Arabian Old World monkeys belonging to the genus Papio, part of the subfamily Cercopithecinae.",
                ImageUrl = "https://images.theconversation.com/files/29599/original/gywmhcy8-1377006315.jpg?ixlib=rb-1.1.0&q=45&auto=format&w=1200&h=900.0&fit=crop"
            });

            Monkeys.Add(new Monkey
            {
                Name = "Capuchin Monkey",
                Location = "Central & South America",
                Details = "The capuchin monkeys are New World monkeys of the subfamily Cebinae. Prior to 2011, the subfamily contained only a single genus, Cebus.",
                ImageUrl = "https://cdn.britannica.com/05/181805-050-C9682415/capuchin-monkey.jpg"
            });

            Monkeys.Add(new Monkey
            {
                Name = "Blue Monkey",
                Location = "Central and East Africa",
                Details = "The blue monkey or diademed monkey is a species of Old World monkey native to Central and East Africa, ranging from the upper Congo River basin east to the East African Rift and south to northern Angola and Zambia",
                ImageUrl = "https://media.istockphoto.com/photos/blue-monkey-tanzania-africa-picture-id1191500517?k=20&m=1191500517&s=170667a&w=0&h=GhG3VeGNMCDLI6bThfNBbFzt8PhDeB5zGH3wlxXVqrw="
            });

            Monkeys.Add(new Monkey
            {
                Name = "Squirrel Monkey",
                Location = "Central & South America",
                Details = "The squirrel monkeys are the New World monkeys of the genus Saimiri. They are the only genus in the subfamily Saimirinae. The name of the genus Saimiri is of Tupi origin, and was also used as an English name by early researchers.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/1/1c/Common.squirrel.monkey.arp.jpg"
            });

            Monkeys.Add(new Monkey
            {
                Name = "Golden Lion Tamarin",
                Location = "Brazil",
                Details = "The golden lion tamarin also known as the golden marmoset, is a small New World monkey of the family Callitrichidae.",
                ImageUrl = "https://www.explorica.com/blog/wp-content/uploads/2020/06/Monkey1.jpg"
            });

            Monkeys.Add(new Monkey
            {
                Name = "Howler Monkey",
                Location = "South America",
                Details = "Howler monkeys are among the largest of the New World monkeys. Fifteen species are currently recognised. Previously classified in the family Cebidae, they are now placed in the family Atelidae.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/2/2f/Howler_monkey.jpg/1024px-Howler_monkey.jpg"
            });

            Monkeys.Add(new Monkey
            {
                Name = "Japanese Macaque",
                Location = "Japan",
                Details = "The Japanese macaque, is a terrestrial Old World monkey species native to Japan. They are also sometimes known as the snow monkey because they live in areas where snow covers the ground for months each",
                ImageUrl = "https://cdn.britannica.com/41/75641-050-32026A25/Grooming-Members-group-Japanese-macaques-each-other.jpg"
            });

            Monkeys.Add(new Monkey
            {
                Name = "Mandrill",
                Location = "Southern Cameroon, Gabon, Equatorial Guinea, and Congo",
                Details = "The mandrill is a primate of the Old World monkey family, closely related to the baboons and even more closely to the drill. It is found in southern Cameroon, Gabon, Equatorial Guinea, and Congo.",
                ImageUrl = "https://static.educalingo.com/img/en/800/mandrill.jpg"
            });

            Monkeys.Add(new Monkey
            {
                Name = "Proboscis Monkey",
                Location = "Borneo",
                Details = "The proboscis monkey or long-nosed monkey, known as the bekantan in Malay, is a reddish-brown arboreal Old World monkey that is endemic to the south-east Asian island of Borneo.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/3/32/Proboscis_monkey_%28Nasalis_larvatus%29_male_head.jpg/2560px-Proboscis_monkey_%28Nasalis_larvatus%29_male_head.jpg"
            });

            Monkeys.Add(new Monkey
            {
                Name = "Red-shanked Douc",
                Location = "Vietnam, Laos",
                Details = "The red-shanked douc is a species of Old World monkey, among the most colourful of all primates. This monkey is sometimes called the \"costumed ape\" for its extravagant appearance. From its knees to its ankles it sports maroon-red \"stockings\", and it appears to wear white forearm length gloves. Its attire is finished with black hands and feet. The golden face is framed by a white ruff, which is considerably fluffier in males. The eyelids are a soft powder blue. The tail is white with a triangle of white hair at the base. Males of all ages have a white spot on both sides of the corners of the rump patch, and red and white genitals.",
                ImageUrl = "https://www.worldlifeexpectancy.com/images/a/w/b/pygathrix-nemaeus/pygathrix-nemaeus.jpg"
            });

            Monkeys.Add(new Monkey
            {
                Name = "Gray-shanked Douc",
                Location = "Vietnam",
                Details = "The gray-shanked douc langur is a douc species native to the Vietnamese provinces of Quảng Nam, Quảng Ngãi, Bình Định, Kon Tum, and Gia Lai. The total population is estimated at 550 to 700 individuals. In 2016, Dr Benjamin Rawson, Country Director of Fauna & Flora International - Vietnam Programme, announced a discovery of an additional population of more than 500 individuals found in Central Vietnam, bringing the total population up to approximately 1000 individuals.",
                ImageUrl = "https://www.eprc.asia/wp-content/uploads/2019/06/Grey-Shanked-Douc-Langur-620x420-2.jpg"
            });

            Monkeys.Add(new Monkey
            {
                Name = "Golden Snub-nosed Monkey",
                Location = "China",
                Details = "The golden snub-nosed monkey is an Old World monkey in the Colobinae subfamily. It is endemic to a small area in temperate, mountainous forests of central and Southwest China. They inhabit these mountainous forests of Southwestern China at elevations of 1,500-3,400 m above sea level. The Chinese name is Sichuan golden hair monkey. It is also widely referred to as the Sichuan snub-nosed monkey. Of the three species of snub-nosed monkeys in China, the golden snub-nosed monkey is the most widely distributed throughout China.",
                ImageUrl = "https://media.istockphoto.com/photos/golden-snubnosed-monkey-china-picture-id1071263726?k=20&m=1071263726&s=612x612&w=0&h=7u1dcRmBydQm_pioDMvo2-SO4CTlJqrynv_1t2Pfykw="
            });

            Monkeys.Add(new Monkey
            {
                Name = "Black Snub-nosed Monkey",
                Location = "China",
                Details = "The black snub-nosed monkey, also known as the Yunnan snub-nosed monkey, is an endangered species of primate in the family Cercopithecidae. It is endemic to China, where it is known to the locals as the Yunnan golden hair monkey and the black golden hair monkey. It is threatened by habitat loss. It was named after Bishop Félix Biet.",
                ImageUrl = "https://www.fabionodariphoto.com/wp-content/uploads/2018/04/male-yunnan-black-snub-nosed-monkey1-750x500.jpg"
            });

            Monkeys.Add(new Monkey
            {
                Name = "Tonkin Snub-nosed Monkey",
                Location = "Vietnam",
                Details = "The Tonkin snub-nosed monkey or Dollman's snub-nosed monkey is a slender-bodied arboreal Old World monkey, endemic to northern Vietnam. It is a black and white monkey with a pink nose and lips and blue patches round the eyes. It is found at altitudes of 200 to 1,200 m (700 to 3,900 ft) on fragmentary patches of forest on craggy limestone areas. First described in 1912, the monkey was rediscovered in 1990 but is exceedingly rare. In 2008, fewer than 250 individuals were thought to exist, and the species was the subject of intense conservation effort. The main threats faced by these monkeys is habitat loss and hunting, and the International Union for Conservation of Nature has rated the species as \"critically endangered\".",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/9/9c/Tonkin_snub-nosed_monkeys_%28Rhinopithecus_avunculus%29.jpg"
            });

            Monkeys.Add(new Monkey
            {
                Name = "Thomas's Langur",
                Location = "Indonesia",
                Details = "Thomas's langur is a species of primate in the family Cercopithecidae. It is endemic to North Sumatra, Indonesia. Its natural habitat is subtropical or tropical dry forests. It is threatened by habitat loss. Its native names are reungkah in Acehnese and kedih in Alas.",
                ImageUrl = "https://as1.ftcdn.net/v2/jpg/01/41/56/92/500_F_141569251_j1Gj644sWKnANJG0ZbrXDU8KBN9m71Gh.jpg"
            });

            Monkeys.Add(new Monkey
            {
                Name = "Purple-faced Langur",
                Location = "Sri Lanka",
                Details = "The purple-faced langur, also known as the purple-faced leaf monkey, is a species of Old World monkey that is endemic to Sri Lanka. The animal is a long-tailed arboreal species, identified by a mostly brown appearance, dark face (with paler lower face) and a very shy nature. The species was once highly prevalent, found in suburban Colombo and the \"wet zone\" villages (areas with high temperatures and high humidity throughout the year, whilst rain deluges occur during the monsoon seasons), but rapid urbanization has led to a significant decrease in the population level of the monkeys.",
                ImageUrl = "https://www.neprimateconservancy.org/uploads/1/5/3/8/15380094/editor/purple-faced-langur-sri-lanka-istock-1065830028-resize.jpg?1557250780"
            });

            Monkeys.Add(new Monkey
            {
                Name = "Gelada",
                Location = "Ethiopia",
                Details = "The gelada, sometimes called the bleeding-heart monkey or the gelada baboon, is a species of Old World monkey found only in the Ethiopian Highlands, with large populations in the Semien Mountains. Theropithecus is derived from the Greek root words for \"beast-ape.\" Like its close relatives the baboons, it is largely terrestrial, spending much of its time foraging in grasslands.",
                ImageUrl = "https://lh3.googleusercontent.com/proxy/8FCsUtVl2qKJElKncEQaKibw1dEvggV9YFImzdsiRrdirnqtqT2qfAnLB0h98bCGMA4S3cUNEiWMkqjQXPs0JePuOH-k0ubacaskH10"
            });
        }
    }

}
