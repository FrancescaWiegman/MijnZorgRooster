﻿using System;
using System.Threading.Tasks;
using mijnZorgRooster.Models;
using mijnZorgRooster.DAL;

namespace mijnZorgRooster.Services
{
    public class CalculationsService : ICalculationsService
    {
        private readonly double vakantieUren = 237.4;
        const int fulltime = 36;

        public int BerekenLeeftijdInJaren(DateTime geboortedatum)
        {
            int leeftijdInJaren = 0;
            DateTime vandaag = DateTime.Today;

            DateTime beginDatum = new DateTime(1, 1, 1);
            TimeSpan span = vandaag.Subtract(geboortedatum);
            leeftijdInJaren = (beginDatum + span).Year - 1;

            return leeftijdInJaren;
        }

        public int BerekenMaandenInDienst(ContractDTO contract)
        {
            int year = DateTime.Now.Year;
            DateTime lastDay = new DateTime(DateTime.Now.Year, 12, 31);
            DateTime firstDay = new DateTime(DateTime.Now.Year, 1,1);

            if (contract.Einddatum == DateTime.MinValue)
            {
                contract.Einddatum = lastDay;
            }

            if (contract.BeginDatum < DateTime.Now)
            {
                contract.BeginDatum = firstDay;
            }

			//int maandenApart = 12 * (contract.BeginDatum.Year - contract.Einddatum.Year) + contract.BeginDatum.Month - contract.Einddatum.Month;
			//return Math.Abs(maandenApart);
            int maandenInDienst = contract.Einddatum.Month - contract.BeginDatum.Month + 1;
            return maandenInDienst;
        }

        public int BerekenParttimePercentage(int contractUren)
        {
			var uitslag = (double)contractUren / (double)fulltime * 100; // TODO: Dit casten is niet zo mooi, maar wel nodig. Misschien nog wat beters zoeken
			return (int)uitslag;
		}

        public double BerekenVakantieDagen(ContractDTO contract)
        {
            int maandenInDienst = BerekenMaandenInDienst(contract);
            double x =(maandenInDienst *100);
            double y = (x / 1200);

            double vakantieUrenFulltime = y;
            double vakantieUrenFulltimeDitJaar = y * vakantieUren;
            double vakantieDagenFulltime = vakantieUrenFulltimeDitJaar / 8;
            

            return vakantieDagenFulltime;
        }

    }
}
