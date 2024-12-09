namespace SantasListGenerator.Address
{
    public class HomeAdress
    {
        switch (homeAdress)
        {
            //Good neighbourhoods \/
            case "Kalfarveien";
            case "Abels gate";
            case "Absalon Beyers gate";
            case "Allégaten";
            case "Allehelgens gate";
            case "Amalie Skrams vei";
            case "Arbeidergaten";
            case "Armauer Hansens vei";
            case "Arne Garborgs gate";
            case "Arnoldus Reimers' gate";
            case "Asbjørnsens gate";
            case "Astrups vei";
            case "Bispengsgaten";
            case "Bjerregårds gate";
            case "Blaauws vei";
            case "Bredsgården";
            case "Breistølen";
            case "Breiviksveien";
            case "Bryggen";
            case "C. Sundts gate";
            case "Christian Michelsens gate";
            case "";
            case "";
            case "";
            case "";
            case "";
            case "";
            case "";
                naughtyOrNice += 10;
                break;
            //bad neighbourhoods \/
            case "Aad Gjelles gate";
            case "Adolph Bergs vei";
            case "Agnes Mowinckels gate";
            case "Asylplassen";
            case "Baglergaten";
            case "Baneveien";
            case "Bankgaten";
            case "Bjørnsons gate";
            case "Bontelabo";
            case "Bradbenken";
            case "Bredalsmarken";
            case "Bøhmergaten";
            case "";
            case "";
            case "";
                naughtyOrNice -= 10;
                break;
        }
}
}