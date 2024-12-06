﻿using System.Text.Json;

namespace SantasListGenerator;

class Program
{

    static void Main(string[] args)
    {

        // Tulle test
        var randomizer = new Randomiser();
        UserInfo[] randomUsers = new UserInfo[100];
        for (int i = 0; i < randomUsers.Length; i++)
        {
            randomUsers[i] = new UserInfo()
            {
                Id = Guid.NewGuid(),
                Name = randomizer.GetRandomName(),
                ToiletPaperOutward = randomizer.CoinFlip(),
                DonatesToCharity = randomizer.CoinFlip(),
                WashesHands = randomizer.CoinFlip(),
                MusicGenres = randomizer.GetRandomMusicGenres(),
                HomeAdress = randomizer.GetRandomStreetName(),
                CarModel = randomizer.GetRandomCarModel()
            };
        }
        JsonSerializerOptions options = new()
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase
        };
        var jsonString = JsonSerializer.Serialize(randomUsers, options);
        File.WriteAllText("randomPeople.json", jsonString);
    }

    public class UserInfo
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public bool ToiletPaperOutward { get; set; }
        public bool DonatesToCharity { get; set; }
        public bool WashesHands { get; set; }
        public string[] MusicGenres { get; set; }
        public string HomeAdress { get; set; }
        public string CarModel { get; set; }
    }
    public class Randomiser
    {
        private readonly string[] Names = [
        "Liam", "Noah", "Oliver", "Elijah", "William",
        "James", "Benjamin", "Lucas", "Henry", "Alexander",
        "Mason", "Michael", "Ethan", "Daniel", "Jacob",
        "Logan", "Jackson", "Levi", "Sebastian", "Mateo",
        "Jack", "Owen", "Theodore", "Aiden", "Samuel",
        "Joseph", "John", "David", "Wyatt", "Matthew",
        "Luke", "Asher", "Carter", "Julian", "Grayson",
        "Leo", "Jayden", "Gabriel", "Isaac", "Lincoln",
        "Anthony", "Hudson", "Dylan", "Ezra", "Thomas",
        "Charles", "Christopher", "Jaxon", "Maverick", "Josiah",
        "Olivia", "Emma", "Charlotte", "Amelia", "Sophia",
        "Isabella", "Ava", "Mia", "Evelyn", "Luna",
        "Harper", "Camila", "Gianna", "Elizabeth", "Eleanor",
        "Ella", "Abigail", "Sofia", "Avery", "Scarlett",
        "Emily", "Aria", "Penelope", "Chloe", "Layla",
        "Mila", "Nora", "Hazel", "Madison", "Ellie",
        "Lily", "Nova", "Isla", "Grace", "Violet",
        "Aurora", "Riley", "Zoey", "Willow", "Emilia",
        "Stella", "Zoe", "Victoria", "Hannah", "Addison",
        "Leah", "Lucy", "Eliana", "Ivy", "Everly"
        ];
        private readonly string[] CarModels = ["Ford Fiesta", "Volkswagen Golf", "Toyota Corolla", "Honda Civic", "Chevrolet Cruze",
        "BMW 3 Series", "Audi A4", "Mercedes-Benz C-Class", "Hyundai Elantra", "Nissan Altima",
        "Kia Optima", "Mazda3", "Subaru Impreza", "Volkswagen Passat", "Toyota Camry",
        "Honda Accord", "Chevrolet Malibu", "Ford Fusion", "Nissan Maxima", "Hyundai Sonata",
        "Kia Stinger", "BMW 5 Series", "Audi A6", "Mercedes-Benz E-Class", "Lexus ES",
        "Jaguar XF", "Volvo S60", "Alfa Romeo Giulia", "Tesla Model 3", "Porsche Panamera",
        "Chevrolet Impala", "Chrysler 300", "Dodge Charger", "Ford Mustang", "Chevrolet Camaro",
        "Dodge Challenger", "Toyota Supra", "Nissan 370Z", "BMW Z4", "Audi TT",
        "Mercedes-Benz SLK", "Mazda MX-5 Miata", "Subaru BRZ", "Hyundai Veloster", "Kia Forte",
        "Volkswagen Jetta", "Honda Fit", "Toyota Yaris", "Ford Focus", "Chevrolet Spark"];
        private readonly string[] MusicGenres = [ "Pop", "Rock", "Hip Hop", "Jazz", "Classical",
        "Electronic", "Country", "R&B", "Reggae", "Blues",
        "Metal", "Soul", "Funk", "Disco", "Punk",
        "Folk", "Gospel", "Latin", "Ska", "House",
        "Techno", "Trance", "Dubstep", "Ambient", "Indie",
        "Grunge", "K-Pop", "J-Pop", "Opera", "Swing",
        "Bluegrass", "Afrobeat", "Salsa", "Merengue", "Bossa Nova",
        "Flamenco", "Reggaeton", "Zouk", "Calypso", "Dancehall",
        "Electro", "Synthpop", "New Wave", "Post-Punk", "Shoegaze",
        "Emo", "Hardcore", "Industrial", "Trip-Hop", "World Music"];
        private readonly string[] StreetNames = ["Aad Gjelles gate", "Abels gate", "Absalon Beyers gate", "Adolph Bergs vei", "Agnes Mowinckels gate",
        "Allégaten", "Allehelgens gate", "Amalie Skrams vei", "Arbeidergaten", "Armauer Hansens vei",
        "Arne Garborgs gate", "Arnoldus Reimers' gate", "Asbjørnsens gate", "Astrups vei", "Asylplassen",
        "Baglergaten", "Baneveien", "Bankgaten", "Bispengsgaten", "Bjerregårds gate",
        "Bjørnsons gate", "Blaauws vei", "Bontelabo", "Bradbenken", "Bredalsmarken",
        "Bredsgården", "Breistølen", "Breiviksveien", "Bryggen", "Bøhmergaten",
        "C. Sundts gate", "Christian Michelsens gate", "Christies gate", "Cort Piil-Smauet", "Damsgårdsveien",
        "Dreggsallmenningen", "Engen", "Fabrikkgaten", "Finnegårdsgaten", "Fjøsangerveien",
        "Fortunen", "Hans Hauges gate", "Haugeveien", "Hollendergaten", "Jonas Lies vei",
        "Kaigaten", "Kalfarveien", "Kirkegaten", "Klosteret", "Kong Oscars gate"];
        private readonly int[] StreetNumbers = Enumerable.Range(1, 200).ToArray();
        private readonly Random _random = new Random();
        public string GetRandomName()
        {
            return Names[_random.Next(0, Names.Length)];
        }
        public string GetRandomStreetName()
        {
            return StreetNames[_random.Next(0, StreetNames.Length)] + " " + StreetNumbers[_random.Next(0, StreetNumbers.Length)].ToString();
        }
        public bool CoinFlip()
        {
            return Convert.ToBoolean(_random.Next(0, 2));
        }
        public string[] GetRandomMusicGenres()
        {
            return MusicGenres.OrderBy(_ => Guid.NewGuid()).Take(3).ToArray();
        }
        public string GetRandomCarModel()
        {
            return CarModels[_random.Next(0, CarModels.Length)];
        }


    }
}