﻿using SA51ADWebApp1.Models;
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

            //Station JurongEast = new Station(); JurongEast.stationName = "Jurong East";
            Station BukitBatok = new Station(); BukitBatok.stationName = "Bukit Batok";
            Station BukitGombak = new Station(); BukitGombak.stationName = "Bukit Gombak";
            Station ChoaChuKang = new Station(); ChoaChuKang.stationName = "Choa Chu Kang";
            Station YewTee = new Station(); YewTee.stationName = "Yew Tee ";
            Station Kranji = new Station(); Kranji.stationName = "Kranji";
            Station Marsiling = new Station(); Marsiling.stationName = "Marsiling";
            Station Woodlands = new Station(); Woodlands.stationName = "Woodlands";
            Station Admiralty = new Station(); Admiralty.stationName = "Admiralty";
            Station Sembawang = new Station(); Sembawang.stationName = "Sembawang";
            Station Canberra = new Station(); Canberra.stationName = "Canberra";
            Station Yishun = new Station(); Yishun.stationName = "Yishun";
            Station Khatib = new Station(); Khatib.stationName = "Khatib";
            Station YioChuKang = new Station(); YioChuKang.stationName = "Yio Chu Kang";
            Station AngMoKio = new Station(); AngMoKio.stationName = "Ang Mo Kio";
            //Station Bishan = new Station(); Bishan.stationName = "Bishan";
            Station Braddell = new Station(); Braddell.stationName = "Braddell";
            Station ToaPayoh = new Station(); ToaPayoh.stationName = "Toa Payoh";
            Station Novena = new Station(); Novena.stationName = "Novena";
            Station Newton = new Station(); Newton.stationName = "Newton";
            Station Orchard = new Station(); Orchard.stationName = "Orchard";
            Station Somerset = new Station(); Somerset.stationName = "Somerset";
            //Station DhobyGhaut = new Station(); DhobyGhaut.stationName = "Dhoby Ghaut";
            //Station CityHall = new Station(); CityHall.stationName = "City Hall";
            //Station RafflesPlace = new Station(); RafflesPlace.stationName = "Raffles Place";
            //Station MarinaBay = new Station(); MarinaBay.stationName = "Marina Bay";
            Station MarinaSouthPier = new Station(); MarinaSouthPier.stationName = "Marina South Pier";
            db.Add(BukitBatok); db.Add(BukitGombak); db.Add(ChoaChuKang); db.Add(YewTee); db.Add(Kranji); db.Add(Marsiling);
            db.Add(Woodlands); db.Add(Admiralty); db.Add(Sembawang); db.Add(Canberra); db.Add(Yishun); db.Add(Khatib);
            db.Add(YioChuKang); db.Add(AngMoKio); db.Add(Braddell); db.Add(ToaPayoh); db.Add(Novena); db.Add(Newton);
            db.Add(Orchard); db.Add(Somerset); db.Add(MarinaSouthPier);

            db.SaveChanges();

            StationOnLine NS1 = new StationOnLine(); NS1.LineId = redLine.Id; NS1.StationId = JurongEast.Id; NS1.stationCode = "NS1"; 
            NS1.status = "Operational"; NS1.timeToNextStation = 0; NS1.timeToNextStationOpp = 3;
            db.Add(NS1);
            StationOnLine NS2 = new StationOnLine(); NS2.LineId = redLine.Id; NS2.StationId = BukitBatok.Id; NS2.stationCode = "NS2";
            NS2.status = "Operational"; NS2.timeToNextStation = 3; NS2.timeToNextStationOpp = 2;
            db.Add(NS2);
            StationOnLine NS3 = new StationOnLine(); NS3.LineId = redLine.Id; NS3.StationId = BukitGombak.Id; NS3.stationCode = "NS3";
            NS3.status = "Operational"; NS3.timeToNextStation = 2; NS3.timeToNextStationOpp = 4;
            db.Add(NS3);
            StationOnLine NS4 = new StationOnLine(); NS4.LineId = redLine.Id; NS4.StationId = ChoaChuKang.Id; NS4.stationCode = "NS4";
            NS4.status = "Operational"; NS4.timeToNextStation = 4; NS4.timeToNextStationOpp = 3;
            db.Add(NS4);
            StationOnLine NS5 = new StationOnLine(); NS5.LineId = redLine.Id; NS5.StationId = YewTee.Id; NS5.stationCode = "NS5";
            NS5.status = "Operational"; NS5.timeToNextStation = 3; NS5.timeToNextStationOpp = 5;
            db.Add(NS5);
            StationOnLine NS7 = new StationOnLine(); NS7.LineId = redLine.Id; NS7.StationId = Kranji.Id; NS7.stationCode = "NS7";
            NS7.status = "Operational"; NS7.timeToNextStation = 5; NS7.timeToNextStationOpp = 3;
            db.Add(NS7);
            StationOnLine NS8 = new StationOnLine(); NS8.LineId = redLine.Id; NS8.StationId = Marsiling.Id; NS8.stationCode = "NS8";
            NS8.status = "Operational"; NS8.timeToNextStation = 3; NS8.timeToNextStationOpp = 2;
            db.Add(NS8);
            StationOnLine NS9 = new StationOnLine(); NS9.LineId = redLine.Id; NS9.StationId = Woodlands.Id; NS9.stationCode = "NS9";
            NS9.status = "Operational"; NS9.timeToNextStation = 2; NS9.timeToNextStationOpp = 3;
            db.Add(NS9);
            StationOnLine NS10 = new StationOnLine(); NS10.LineId = redLine.Id; NS10.StationId = Admiralty.Id; NS10.stationCode = "NS10";
            NS10.status = "Operational"; NS10.timeToNextStation = 3; NS10.timeToNextStationOpp = 3;
            db.Add(NS10);
            StationOnLine NS11 = new StationOnLine(); NS11.LineId = redLine.Id; NS11.StationId = Sembawang.Id; NS11.stationCode = "NS11";
            NS11.status = "Operational"; NS11.timeToNextStation = 3; NS11.timeToNextStationOpp = 3;
            db.Add(NS11);
            StationOnLine NS12 = new StationOnLine(); NS12.LineId = redLine.Id; NS12.StationId = Canberra.Id; NS12.stationCode = "NS12";
            NS12.status = "Operational"; NS12.timeToNextStation = 3; NS12.timeToNextStationOpp = 3;
            db.Add(NS12);
            StationOnLine NS13 = new StationOnLine(); NS13.LineId = redLine.Id; NS13.StationId = Yishun.Id; NS13.stationCode = "NS13";
            NS13.status = "Operational"; NS13.timeToNextStation = 3; NS13.timeToNextStationOpp = 2;
            db.Add(NS13);
            StationOnLine NS14 = new StationOnLine(); NS14.LineId = redLine.Id; NS14.StationId = Khatib.Id; NS14.stationCode = "NS14";
            NS14.status = "Operational"; NS14.timeToNextStation = 2; NS14.timeToNextStationOpp = 6;
            db.Add(NS14);
            StationOnLine NS15 = new StationOnLine(); NS15.LineId = redLine.Id; NS15.StationId = YioChuKang.Id; NS15.stationCode = "NS15";
            NS15.status = "Operational"; NS15.timeToNextStation = 6; NS15.timeToNextStationOpp = 2;
            db.Add(NS15);
            StationOnLine NS16 = new StationOnLine(); NS16.LineId = redLine.Id; NS16.StationId = AngMoKio.Id; NS16.stationCode = "NS16";
            NS16.status = "Operational"; NS16.timeToNextStation = 2; NS16.timeToNextStationOpp = 4;
            db.Add(NS16);
            StationOnLine NS17 = new StationOnLine(); NS17.LineId = redLine.Id; NS17.StationId = Bishan.Id; NS17.stationCode = "NS17";
            NS17.status = "Operational"; NS17.timeToNextStation = 4; NS17.timeToNextStationOpp = 2;
            db.Add(NS17);
            StationOnLine NS18 = new StationOnLine(); NS18.LineId = redLine.Id; NS18.StationId = Braddell.Id; NS18.stationCode = "NS18";
            NS18.status = "Operational"; NS18.timeToNextStation = 2; NS18.timeToNextStationOpp = 2;
            db.Add(NS18);
            StationOnLine NS19 = new StationOnLine(); NS19.LineId = redLine.Id; NS19.StationId = ToaPayoh.Id; NS19.stationCode = "NS19";
            NS19.status = "Operational"; NS19.timeToNextStation = 2; NS19.timeToNextStationOpp = 3;
            db.Add(NS19);
            StationOnLine NS20 = new StationOnLine(); NS20.LineId = redLine.Id; NS20.StationId = Novena.Id; NS20.stationCode = "NS20";
            NS20.status = "Operational"; NS20.timeToNextStation = 3; NS20.timeToNextStationOpp = 2;
            db.Add(NS20);
            StationOnLine NS21 = new StationOnLine(); NS21.LineId = redLine.Id; NS21.StationId = Newton.Id; NS21.stationCode = "NS21";
            NS21.status = "Operational"; NS21.timeToNextStation = 2; NS21.timeToNextStationOpp = 3;
            db.Add(NS21);
            StationOnLine NS22 = new StationOnLine(); NS22.LineId = redLine.Id; NS22.StationId = Orchard.Id; NS22.stationCode = "NS22";
            NS22.status = "Operational"; NS22.timeToNextStation = 3; NS22.timeToNextStationOpp = 2;
            db.Add(NS22);
            StationOnLine NS23 = new StationOnLine(); NS23.LineId = redLine.Id; NS23.StationId = Somerset.Id; NS23.stationCode = "NS23";
            NS23.status = "Operational"; NS23.timeToNextStation = 2; NS23.timeToNextStationOpp = 2;
            db.Add(NS23);
            StationOnLine NS24 = new StationOnLine(); NS24.LineId = redLine.Id; NS24.StationId = DhobyGhaut.Id; NS24.stationCode = "NS24";
            NS24.status = "Operational"; NS24.timeToNextStation = 2; NS24.timeToNextStationOpp = 3;
            db.Add(NS24);
            StationOnLine NS25 = new StationOnLine(); NS25.LineId = redLine.Id; NS25.StationId = CityHall.Id; NS25.stationCode = "NS25";
            NS25.status = "Operational"; NS25.timeToNextStation = 3; NS25.timeToNextStationOpp = 2;
            db.Add(NS25);
            StationOnLine NS26 = new StationOnLine(); NS26.LineId = redLine.Id; NS26.StationId = RafflesPlace.Id; NS26.stationCode = "NS26";
            NS26.status = "Operational"; NS26.timeToNextStation = 2; NS26.timeToNextStationOpp = 2;
            db.Add(NS26);
            StationOnLine NS27 = new StationOnLine(); NS27.LineId = redLine.Id; NS27.StationId = MarinaBay.Id; NS27.stationCode = "NS27";
            NS27.status = "Operational"; NS27.timeToNextStation = 2; NS27.timeToNextStationOpp = 3;
            db.Add(NS27);
            StationOnLine NS28 = new StationOnLine(); NS28.LineId = redLine.Id; NS28.StationId = MarinaSouthPier.Id; NS28.stationCode = "NS28";
            NS28.status = "Operational"; NS28.timeToNextStation = 3; NS28.timeToNextStationOpp = 0;
            db.Add(NS28);

            StationOnLine CG1 = new StationOnLine(); CG1.LineId = greenLine.Id; CG1.StationId = Expo.Id; CG1.stationCode = "CG1";
            CG1.status = "Operational"; CG1.timeToNextStation = 4; CG1.timeToNextStationOpp = 3;
            db.Add(CG1);
            StationOnLine CG2 = new StationOnLine(); CG2.LineId = greenLine.Id; CG2.StationId = ChangiAirport.Id; CG2.stationCode = "CG2";
            CG2.status = "Operational"; CG2.timeToNextStation = 0; CG2.timeToNextStationOpp = 4;
            db.Add(CG2);
            StationOnLine EW1 = new StationOnLine(); EW1.LineId = greenLine.Id; EW1.StationId = PasirRis.Id; EW1.stationCode = "EW1";
            EW1.status = "Operational"; EW1.timeToNextStation = 0; EW1.timeToNextStationOpp = 3;
            db.Add(EW1);
            StationOnLine EW2 = new StationOnLine(); EW2.LineId = greenLine.Id; EW2.StationId = Tampines.Id; EW2.stationCode = "EW2";
            EW2.status = "Operational"; EW2.timeToNextStation = 3; EW2.timeToNextStationOpp = 3;
            db.Add(EW2);
            StationOnLine EW3 = new StationOnLine(); EW3.LineId = greenLine.Id; EW3.StationId = Simei.Id; EW3.stationCode = "EW3";
            EW3.status = "Operational"; EW3.timeToNextStation = 3; EW3.timeToNextStationOpp = 3;
            db.Add(EW3);
            StationOnLine EW4 = new StationOnLine(); EW4.LineId = greenLine.Id; EW4.StationId = TanahMerah.Id; EW4.stationCode = "EW4";
            EW4.status = "Operational"; EW4.timeToNextStation = 3; EW4.timeToNextStationOpp = 3;
            db.Add(EW4);
            StationOnLine EW5 = new StationOnLine(); EW5.LineId = greenLine.Id; EW5.StationId = Bedok.Id; EW5.stationCode = "EW5";
            EW5.status = "Operational"; EW5.timeToNextStation = 3; EW5.timeToNextStationOpp = 3;
            db.Add(EW5);
            StationOnLine EW6 = new StationOnLine(); EW6.LineId = greenLine.Id; EW6.StationId = Kembangan.Id; EW6.stationCode = "EW6";
            EW6.status = "Operational"; EW6.timeToNextStation = 3; EW6.timeToNextStationOpp = 3;
            db.Add(EW6);
            StationOnLine EW7 = new StationOnLine(); EW7.LineId = greenLine.Id; EW7.StationId = Eunos.Id; EW7.stationCode = "EW7";
            EW7.status = "Operational"; EW7.timeToNextStation = 3; EW7.timeToNextStationOpp = 2;
            db.Add(EW7);
            StationOnLine EW8 = new StationOnLine(); EW8.LineId = greenLine.Id; EW8.StationId = PayaLebar.Id; EW8.stationCode = "EW8";
            EW8.status = "Operational"; EW8.timeToNextStation = 2; EW8.timeToNextStationOpp = 2;
            db.Add(EW8);
            StationOnLine EW9 = new StationOnLine(); EW9.LineId = greenLine.Id; EW9.StationId = Aljunied.Id; EW9.stationCode = "EW9";
            EW9.status = "Operational"; EW9.timeToNextStation = 2; EW9.timeToNextStationOpp = 3;
            db.Add(EW9);
            StationOnLine EW10 = new StationOnLine(); EW10.LineId = greenLine.Id; EW10.StationId = Kallang.Id; EW10.stationCode = "EW10";
            EW10.status = "Operational"; EW10.timeToNextStation = 3; EW10.timeToNextStationOpp = 2;
            db.Add(EW10);
            StationOnLine EW11 = new StationOnLine(); EW11.LineId = greenLine.Id; EW11.StationId = Lavender.Id; EW11.stationCode = "EW11";
            EW11.status = "Operational"; EW11.timeToNextStation = 2; EW11.timeToNextStationOpp = 2;
            db.Add(EW11);
            StationOnLine EW12 = new StationOnLine(); EW12.LineId = greenLine.Id; EW12.StationId = Bugis.Id; EW12.stationCode = "EW12";
            EW12.status = "Operational"; EW12.timeToNextStation = 2; EW12.timeToNextStationOpp = 3;
            db.Add(EW12);
            StationOnLine EW13 = new StationOnLine(); EW13.LineId = greenLine.Id; EW13.StationId = CityHall.Id; EW13.stationCode = "EW13";
            EW13.status = "Operational"; EW13.timeToNextStation = 3; EW13.timeToNextStationOpp = 2;
            db.Add(EW13);
            StationOnLine EW14 = new StationOnLine(); EW14.LineId = greenLine.Id; EW14.StationId = RafflesPlace.Id; EW14.stationCode = "EW14";
            EW14.status = "Operational"; EW14.timeToNextStation = 2; EW14.timeToNextStationOpp = 3;
            db.Add(EW14);
            StationOnLine EW15 = new StationOnLine(); EW15.LineId = greenLine.Id; EW15.StationId = TanjongPagar.Id; EW15.stationCode = "EW15";
            EW15.status = "Operational"; EW15.timeToNextStation = 3; EW15.timeToNextStationOpp = 2;
            db.Add(EW15);
            StationOnLine EW16 = new StationOnLine(); EW16.LineId = greenLine.Id; EW16.StationId = OutramPark.Id; EW16.stationCode = "EW16";
            EW16.status = "Operational"; EW16.timeToNextStation = 2; EW16.timeToNextStationOpp = 3;
            db.Add(EW16);
            StationOnLine EW17 = new StationOnLine(); EW17.LineId = greenLine.Id; EW17.StationId = TiongBahru.Id; EW17.stationCode = "EW17";
            EW17.status = "Operational"; EW17.timeToNextStation = 3; EW17.timeToNextStationOpp = 2;
            db.Add(EW17);
            StationOnLine EW18 = new StationOnLine(); EW18.LineId = greenLine.Id; EW18.StationId = Redhill.Id; EW18.stationCode = "EW18";
            EW18.status = "Operational"; EW18.timeToNextStation = 2; EW18.timeToNextStationOpp = 3;
            db.Add(EW18);
            StationOnLine EW19 = new StationOnLine(); EW19.LineId = greenLine.Id; EW19.StationId = Queenstown.Id; EW19.stationCode = "EW19";
            EW19.status = "Operational"; EW19.timeToNextStation = 3; EW19.timeToNextStationOpp = 2;
            db.Add(EW19);
            StationOnLine EW20 = new StationOnLine(); EW20.LineId = greenLine.Id; EW20.StationId = Commonwealth.Id; EW20.stationCode = "EW20";
            EW20.status = "Operational"; EW20.timeToNextStation = 2; EW20.timeToNextStationOpp = 2;
            db.Add(EW20);
            StationOnLine EW21 = new StationOnLine(); EW21.LineId = greenLine.Id; EW21.StationId = BuonaVista.Id; EW21.stationCode = "EW21";
            EW21.status = "Operational"; EW21.timeToNextStation = 2; EW21.timeToNextStationOpp = 3;
            db.Add(EW21);
            StationOnLine EW22 = new StationOnLine(); EW22.LineId = greenLine.Id; EW22.StationId = Dover.Id; EW22.stationCode = "EW22";
            EW22.status = "Operational"; EW22.timeToNextStation = 3; EW22.timeToNextStationOpp = 3;
            db.Add(EW22);
            StationOnLine EW23 = new StationOnLine(); EW23.LineId = greenLine.Id; EW23.StationId = Clementi.Id; EW23.stationCode = "EW23";
            EW23.status = "Operational"; EW23.timeToNextStation = 3; EW23.timeToNextStationOpp = 4;
            db.Add(EW23);
            StationOnLine EW24 = new StationOnLine(); EW24.LineId = greenLine.Id; EW24.StationId = JurongEast.Id; EW24.stationCode = "EW24";
            EW24.status = "Operational"; EW24.timeToNextStation = 4; EW24.timeToNextStationOpp = 3;
            db.Add(EW24);
            StationOnLine EW25 = new StationOnLine(); EW25.LineId = greenLine.Id; EW25.StationId = ChineseGarden.Id; EW25.stationCode = "EW25";
            EW25.status = "Operational"; EW25.timeToNextStation = 3; EW25.timeToNextStationOpp = 2;
            db.Add(EW25);
            StationOnLine EW26 = new StationOnLine(); EW26.LineId = greenLine.Id; EW26.StationId = Lakeside.Id; EW26.stationCode = "EW26";
            EW26.status = "Operational"; EW26.timeToNextStation = 2; EW26.timeToNextStationOpp = 3;
            db.Add(EW26);
            StationOnLine EW27 = new StationOnLine(); EW27.LineId = greenLine.Id; EW27.StationId = BoonLay.Id; EW27.stationCode = "EW27";
            EW27.status = "Operational"; EW27.timeToNextStation = 3; EW27.timeToNextStationOpp = 2;
            db.Add(EW27);
            StationOnLine EW28 = new StationOnLine(); EW28.LineId = greenLine.Id; EW28.StationId = Pioneer.Id; EW28.stationCode = "EW28";
            EW28.status = "Operational"; EW28.timeToNextStation = 2; EW28.timeToNextStationOpp = 4;
            db.Add(EW28);
            StationOnLine EW29 = new StationOnLine(); EW29.LineId = greenLine.Id; EW29.StationId = JooKoon.Id; EW29.stationCode = "EW29";
            EW29.status = "Operational"; EW29.timeToNextStation = 4; EW29.timeToNextStationOpp = 3;
            db.Add(EW29);
            StationOnLine EW30 = new StationOnLine(); EW30.LineId = greenLine.Id; EW30.StationId = GulCircle.Id; EW30.stationCode = "EW30";
            EW30.status = "Operational"; EW30.timeToNextStation = 3; EW30.timeToNextStationOpp = 3;
            db.Add(EW30);
            StationOnLine EW31 = new StationOnLine(); EW31.LineId = greenLine.Id; EW31.StationId = TuasCrescent.Id; EW31.stationCode = "EW31";
            EW31.status = "Operational"; EW31.timeToNextStation = 3; EW31.timeToNextStationOpp = 8;
            db.Add(EW31);
            StationOnLine EW32 = new StationOnLine(); EW32.LineId = greenLine.Id; EW32.StationId = TuasWestRoad.Id; EW32.stationCode = "EW32";
            EW32.status = "Operational"; EW32.timeToNextStation = 8; EW32.timeToNextStationOpp = 12;
            db.Add(EW32);
            StationOnLine EW33 = new StationOnLine(); EW33.LineId = greenLine.Id; EW33.StationId = TuasLink.Id; EW33.stationCode = "EW33";
            EW33.status = "Operational"; EW33.timeToNextStation = 12; EW33.timeToNextStationOpp = 0;
            db.Add(EW33);

            StationOnLine CC1 = new StationOnLine(); CC1.LineId = yellowLine.Id; CC1.StationId = DhobyGhaut.Id; CC1.stationCode = "CC1";
            CC1.status = "Operational"; CC1.timeToNextStation = 0; CC1.timeToNextStationOpp = 2;
            db.Add(CC1);
            StationOnLine CC2 = new StationOnLine(); CC2.LineId = yellowLine.Id; CC2.StationId = BrasBasah.Id; CC2.stationCode = "CC2";
            CC2.status = "Operational"; CC2.timeToNextStation = 2; CC2.timeToNextStationOpp = 2;
            db.Add(CC2);
            StationOnLine CC3 = new StationOnLine(); CC3.LineId = yellowLine.Id; CC3.StationId = Esplanade.Id; CC3.stationCode = "CC3";
            CC3.status = "Operational"; CC3.timeToNextStation = 2; CC3.timeToNextStationOpp = 2;
            db.Add(CC3);
            StationOnLine CC4 = new StationOnLine(); CC4.LineId = yellowLine.Id; CC4.StationId = Promenade.Id; CC4.stationCode = "CC4";
            CC4.status = "Operational"; CC4.timeToNextStation = 2; CC4.timeToNextStationOpp = 2;
            db.Add(CC4);
            StationOnLine CC5 = new StationOnLine(); CC5.LineId = yellowLine.Id; CC5.StationId = NicollHighway.Id; CC5.stationCode = "CC5";
            CC5.status = "Operational"; CC5.timeToNextStation = 2; CC5.timeToNextStationOpp = 2;
            db.Add(CC5);
            StationOnLine CC6 = new StationOnLine(); CC6.LineId = yellowLine.Id; CC6.StationId = Stadium.Id; CC6.stationCode = "CC6";
            CC6.status = "Operational"; CC6.timeToNextStation = 2; CC6.timeToNextStationOpp = 2;
            db.Add(CC6);
            StationOnLine CC7 = new StationOnLine(); CC7.LineId = yellowLine.Id; CC7.StationId = Mountbatten.Id; CC7.stationCode = "CC7";
            CC7.status = "Operational"; CC7.timeToNextStation = 2; CC7.timeToNextStationOpp = 2;
            db.Add(CC7);
            StationOnLine CC8 = new StationOnLine(); CC8.LineId = yellowLine.Id; CC8.StationId = Dakota.Id; CC8.stationCode = "CC8";
            CC8.status = "Operational"; CC8.timeToNextStation = 2; CC8.timeToNextStationOpp = 2;
            db.Add(CC8);
            StationOnLine CC9 = new StationOnLine(); CC9.LineId = yellowLine.Id; CC9.StationId = PayaLebar.Id; CC9.stationCode = "CC9";
            CC9.status = "Operational"; CC9.timeToNextStation = 2; CC9.timeToNextStationOpp = 2;
            db.Add(CC9);
            StationOnLine CC10 = new StationOnLine(); CC10.LineId = yellowLine.Id; CC10.StationId = MacPherson.Id; CC10.stationCode = "CC10";
            CC10.status = "Operational"; CC10.timeToNextStation = 2; CC10.timeToNextStationOpp = 2;
            db.Add(CC10);
            StationOnLine CC11 = new StationOnLine(); CC11.LineId = yellowLine.Id; CC11.StationId = TaiSeng.Id; CC11.stationCode = "CC11";
            CC11.status = "Operational"; CC11.timeToNextStation = 2; CC11.timeToNextStationOpp = 2;
            db.Add(CC11);
            StationOnLine CC12 = new StationOnLine(); CC12.LineId = yellowLine.Id; CC12.StationId = Bartley.Id; CC12.stationCode = "CC12";
            CC12.status = "Operational"; CC12.timeToNextStation = 2; CC12.timeToNextStationOpp = 3;
            db.Add(CC12);
            StationOnLine CC13 = new StationOnLine(); CC13.LineId = yellowLine.Id; CC13.StationId = Serangoon.Id; CC13.stationCode = "CC13";
            CC13.status = "Operational"; CC13.timeToNextStation = 3; CC13.timeToNextStationOpp = 2;
            db.Add(CC13);
            StationOnLine CC14 = new StationOnLine(); CC14.LineId = yellowLine.Id; CC14.StationId = LorongChuan.Id; CC14.stationCode = "CC14";
            CC14.status = "Operational"; CC14.timeToNextStation = 2; CC14.timeToNextStationOpp = 2;
            db.Add(CC14);
            StationOnLine CC15 = new StationOnLine(); CC15.LineId = yellowLine.Id; CC15.StationId = Bishan.Id; CC15.stationCode = "CC15";
            CC15.status = "Operational"; CC15.timeToNextStation = 2; CC15.timeToNextStationOpp = 3;
            db.Add(CC15);
            StationOnLine CC16 = new StationOnLine(); CC16.LineId = yellowLine.Id; CC16.StationId = Marymount.Id; CC16.stationCode = "CC16";
            CC16.status = "Operational"; CC16.timeToNextStation = 3; CC16.timeToNextStationOpp = 2;
            db.Add(CC16);
            StationOnLine CC17 = new StationOnLine(); CC17.LineId = yellowLine.Id; CC17.StationId = Caldecott.Id; CC17.stationCode = "CC17";
            CC17.status = "Operational"; CC17.timeToNextStation = 2; CC17.timeToNextStationOpp = 5;
            db.Add(CC17);
            StationOnLine CC19 = new StationOnLine(); CC19.LineId = yellowLine.Id; CC19.StationId = BotanicGardens.Id; CC19.stationCode = "CC19";
            CC19.status = "Operational"; CC19.timeToNextStation = 5; CC19.timeToNextStationOpp = 2;
            db.Add(CC19);
            StationOnLine CC20 = new StationOnLine(); CC20.LineId = yellowLine.Id; CC20.StationId = FarrerRoad.Id; CC20.stationCode = "CC20";
            CC20.status = "Operational"; CC20.timeToNextStation = 2; CC20.timeToNextStationOpp = 3;
            db.Add(CC20);
            StationOnLine CC21 = new StationOnLine(); CC21.LineId = yellowLine.Id; CC21.StationId = HollandVillage.Id; CC21.stationCode = "CC21";
            CC21.status = "Operational"; CC21.timeToNextStation = 3; CC21.timeToNextStationOpp = 2;
            db.Add(CC21);
            StationOnLine CC22 = new StationOnLine(); CC22.LineId = yellowLine.Id; CC22.StationId = BuonaVista.Id; CC22.stationCode = "CC22";
            CC22.status = "Operational"; CC22.timeToNextStation = 2; CC22.timeToNextStationOpp = 2;
            db.Add(CC22);
            StationOnLine CC23 = new StationOnLine(); CC23.LineId = yellowLine.Id; CC23.StationId = OneNorth.Id; CC23.stationCode = "CC23";
            CC23.status = "Operational"; CC23.timeToNextStation = 2; CC23.timeToNextStationOpp = 2;
            db.Add(CC23);
            StationOnLine CC24 = new StationOnLine(); CC24.LineId = yellowLine.Id; CC24.StationId = KentRidge.Id; CC24.stationCode = "CC24";
            CC24.status = "Operational"; CC24.timeToNextStation = 2; CC24.timeToNextStationOpp = 2;
            db.Add(CC24);
            StationOnLine CC25 = new StationOnLine(); CC25.LineId = yellowLine.Id; CC25.StationId = HawParVilla.Id; CC25.stationCode = "CC25";
            CC25.status = "Operational"; CC25.timeToNextStation = 2; CC25.timeToNextStationOpp = 2;
            db.Add(CC25);
            StationOnLine CC26 = new StationOnLine(); CC26.LineId = yellowLine.Id; CC26.StationId = PasirPanjang.Id; CC26.stationCode = "CC26";
            CC26.status = "Operational"; CC26.timeToNextStation = 2; CC26.timeToNextStationOpp = 3;
            db.Add(CC26);
            StationOnLine CC27 = new StationOnLine(); CC27.LineId = yellowLine.Id; CC27.StationId = LabradorPark.Id; CC27.stationCode = "CC27";
            CC27.status = "Operational"; CC27.timeToNextStation = 3; CC27.timeToNextStationOpp = 2;
            db.Add(CC27);
            StationOnLine CC28 = new StationOnLine(); CC28.LineId = yellowLine.Id; CC28.StationId = TelokBlangah.Id; CC28.stationCode = "CC28";
            CC28.status = "Operational"; CC28.timeToNextStation = 2; CC28.timeToNextStationOpp = 2;
            db.Add(CC28);
            StationOnLine CC29 = new StationOnLine(); CC29.LineId = yellowLine.Id; CC29.StationId = HarbourFront.Id; CC29.stationCode = "CC29";
            CC29.status = "Operational"; CC29.timeToNextStation = 2; CC29.timeToNextStationOpp = 0;
            db.Add(CC29);
            StationOnLine CE1 = new StationOnLine(); CE1.LineId = yellowLine.Id; CE1.StationId = Bayfront.Id; CE1.stationCode = "CE1";
            CE1.status = "Operational"; CE1.timeToNextStation = 2; CE1.timeToNextStationOpp = 2;
            db.Add(CE1);
            StationOnLine CE2 = new StationOnLine(); CE2.LineId = yellowLine.Id; CE2.StationId = MarinaBay.Id; CE2.stationCode = "CE2";
            CE2.status = "Operational"; CE2.timeToNextStation = 2; CE2.timeToNextStationOpp = 0;
            db.Add(CE2);

            //find a way to stream from CVS in to this.
            //object item = inputstream....
            //createStationOnLine(item.Id, time,timeOpp)
            db.SaveChanges();
        }
    }
}
