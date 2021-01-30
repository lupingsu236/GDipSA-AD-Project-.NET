using SA51ADWebApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SA51ADWebApp1.Repository
{
    public class Seeder
    {
        public Seeder(Database db)
        {
            Admin admin1 = new Admin();
            admin1.username = "jon";
            admin1.password = "password";
            Admin admin2 = new Admin();
            admin2.username = "zhenli";
            admin2.password = "password";
            Admin admin3 = new Admin();
            admin3.username = "sulp";
            admin3.password = "password";
            Admin admin4 = new Admin();
            admin4.username = "justin";
            admin4.password = "password";
            db.Add(admin1); db.Add(admin2); db.Add(admin3); db.Add(admin4);

            Line yellowLine = new Line();
            yellowLine.lineName = "Circle Line";
            Line redLine = new Line();
            redLine.lineName = "North-South Line";
            Line greenLine = new Line();
            greenLine.lineName = "East-West Line";
            db.Add(yellowLine); db.Add(redLine); db.Add(greenLine);

            Station DhobyGhaut = new Station(); DhobyGhaut.stationName = "Dhoby Ghaut";
            Station BrasBasah = new Station(); BrasBasah.stationName = "Bras Basah";
            Station Esplanade = new Station(); Esplanade.stationName = "Esplanade";
            Station Promenade = new Station(); Promenade.stationName = "Promenade";
            Station NicollHighway = new Station(); NicollHighway.stationName = "Nicoll Highway";
            Station Stadium = new Station(); Stadium.stationName = "Stadium";
            Station Mountbatten = new Station(); Mountbatten.stationName = "Mountbatten";
            Station Dakota = new Station(); Dakota.stationName = "Dakota";
            Station PayaLebar = new Station(); PayaLebar.stationName = "Paya Lebar";
            Station MacPherson = new Station(); MacPherson.stationName = "MacPherson";
            Station TaiSeng = new Station(); TaiSeng.stationName = "Tai Seng";
            Station Bartley = new Station(); Bartley.stationName = "Bartley";
            Station Serangoon = new Station(); Serangoon.stationName = "Serangoon";
            Station LorongChuan = new Station(); LorongChuan.stationName = "Lorong Chuan";
            Station Bishan = new Station(); Bishan.stationName = "Bishan";
            Station Marymount = new Station(); Marymount.stationName = "Marymount";
            Station Caldecott = new Station(); Caldecott.stationName = "Caldecott";
            Station BotanicGardens = new Station(); BotanicGardens.stationName = "Botanic Gardens";
            Station FarrerRoad = new Station(); FarrerRoad.stationName = "Farrer Road";
            Station HollandVillage = new Station(); HollandVillage.stationName = "Holland Village";
            Station BuonaVista = new Station(); BuonaVista.stationName = "Buona Vista";
            Station OneNorth = new Station(); OneNorth.stationName = "one-north";
            Station KentRidge = new Station(); KentRidge.stationName = "Kent Ridge";
            Station HawParVilla = new Station(); HawParVilla.stationName = "Haw Par Villa";
            Station PasirPanjang = new Station(); PasirPanjang.stationName = "Pasir Panjang";
            Station LabradorPark = new Station(); LabradorPark.stationName = "Labrador Park";
            Station TelokBlangah = new Station(); TelokBlangah.stationName = "Telok Blangah";
            Station HarbourFront = new Station(); HarbourFront.stationName = "HarbourFront";
            Station Bayfront = new Station(); Bayfront.stationName = "Bayfront";
            Station MarinaBay = new Station(); MarinaBay.stationName = "Marina Bay";
            db.Add(DhobyGhaut); db.Add(BrasBasah); db.Add(Esplanade); db.Add(Promenade); db.Add(NicollHighway);
            db.Add(Stadium); db.Add(Mountbatten); db.Add(Dakota); db.Add(PayaLebar); db.Add(MacPherson); db.Add(TaiSeng);
            db.Add(Bartley); db.Add(Serangoon); db.Add(LorongChuan); db.Add(Bishan); db.Add(Marymount); db.Add(Caldecott);
            db.Add(BotanicGardens); db.Add(FarrerRoad); db.Add(HollandVillage); db.Add(BuonaVista); db.Add(OneNorth);
            db.Add(KentRidge); db.Add(HawParVilla); db.Add(PasirPanjang); db.Add(LabradorPark); db.Add(TelokBlangah);
            db.Add(HarbourFront); db.Add(Bayfront); db.Add(MarinaBay);

            Station ChangiAirport = new Station(); ChangiAirport.stationName = "Changi Airport";
            Station Expo = new Station(); Expo.stationName = "Expo";
            Station PasirRis = new Station(); PasirRis.stationName = "Pasir Ris";
            Station Tampines = new Station(); Tampines.stationName = "Tampines";
            Station Simei = new Station(); Simei.stationName = "Simei";
            Station TanahMerah = new Station(); TanahMerah.stationName = "Tanah Merah";
            Station Bedok = new Station(); Bedok.stationName = "Bedok";
            Station Kembangan = new Station(); Kembangan.stationName = "Kembangan";
            Station Eunos = new Station(); Eunos.stationName = "Eunos";
            //Station PayaLebar = new Station(); PayaLebar.stationName = "Paya Lebar";
            Station Aljunied = new Station(); Aljunied.stationName = "Aljunied";
            Station Kallang = new Station(); Kallang.stationName = "Kallang";
            Station Lavender = new Station(); Lavender.stationName = "Lavender";
            Station Bugis = new Station(); Bugis.stationName = "Bugis";
            Station CityHall = new Station(); CityHall.stationName = "CityHall";
            Station RafflesPlace = new Station(); RafflesPlace.stationName = "Raffles Place";
            Station TanjongPagar = new Station(); TanjongPagar.stationName = "Tanjong Pagar";
            Station OutramPark = new Station(); OutramPark.stationName = "Outram Park";
            Station TiongBahru = new Station(); TiongBahru.stationName = "Tiong Bahru";
            Station Redhill = new Station(); Redhill.stationName = "Redhill";
            Station Queenstown = new Station(); Queenstown.stationName = "Queenstown";
            Station Commonwealth = new Station(); Commonwealth.stationName = "Commonwealth";
            //Station BuonaVista = new Station(); BuonaVista.stationName = "Buona Vista";
            Station Dover = new Station(); Dover.stationName = "Dover";
            Station Clementi = new Station(); Clementi.stationName = "Clementi";
            Station JurongEast = new Station(); JurongEast.stationName = "Jurong East";
            Station ChineseGarden = new Station(); ChineseGarden.stationName = "Chinese Garden";
            Station Lakeside = new Station(); Lakeside.stationName = "Lakeside";
            Station BoonLay = new Station(); BoonLay.stationName = "Boon Lay";
            Station Pioneer = new Station(); Pioneer.stationName = "Pioneer";
            Station JooKoon = new Station(); JooKoon.stationName = "Joo Koon";
            Station GulCircle = new Station(); GulCircle.stationName = "Gul Circle";
            Station TuasCrescent = new Station(); TuasCrescent.stationName = "Tuas Crescent";
            Station TuasWestRoad = new Station(); TuasWestRoad.stationName = "Tuas West Road";
            Station TuasLink = new Station(); TuasLink.stationName = "Tuas Link";
            db.Add(ChangiAirport); db.Add(Expo); db.Add(PasirRis); db.Add(Tampines); db.Add(Simei); db.Add(TanahMerah);
            db.Add(Bedok); db.Add(Kembangan); db.Add(Eunos); db.Add(Aljunied); db.Add(Kallang); db.Add(Lavender); db.Add(Bugis);
            db.Add(CityHall); db.Add(RafflesPlace); db.Add(TanjongPagar); db.Add(OutramPark); db.Add(TiongBahru); db.Add(Redhill);
            db.Add(Queenstown); db.Add(Commonwealth); db.Add(Dover); db.Add(Clementi); db.Add(JurongEast); db.Add(ChineseGarden);
            db.Add(Lakeside); db.Add(BoonLay); db.Add(Pioneer); db.Add(JooKoon); db.Add(GulCircle); db.Add(TuasCrescent);
            db.Add(TuasWestRoad); db.Add(TuasLink);

            db.SaveChanges();
        }
    }
}
