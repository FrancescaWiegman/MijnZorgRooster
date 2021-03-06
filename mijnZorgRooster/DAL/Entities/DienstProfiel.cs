﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace mijnZorgRooster.DAL.Entities
{
	// Class: Bedoeld om terugkerende data betreffende de diensten in op te slaan. Diensten hebben vaak dezelfde begin- en eindtijd, etc.
	// Om later het Flyweight pattern op toe te passen, zie: https://en.wikipedia.org/wiki/Flyweight_pattern
	public class DienstProfiel
	{
		[Key]
		public int DienstProfielID { get; set; }
		public int VolgordeNr { get; set; }
		public string Beschrijving { get; set; } // bv. "Vroege dienst", "Avonddienst", etc.
		public TimeSpan Begintijd { get; set; }
		public TimeSpan Eindtijd { get; set; }
		public int MinimaleBezetting { get; set; }
		//TODO: Nadenken over hoe we willen aangeven welke certificaten de personen moeten hebben, die deze diensten gaan vervullen.
	}

	public class RoosterDienstProfiel
	{
		public int DienstProfielId { get; set; }
		public DienstProfiel DienstProfiel { get; set; }
		public int RoosterId { get; set; }
		public Rooster Rooster { get; set; }
	}
}
