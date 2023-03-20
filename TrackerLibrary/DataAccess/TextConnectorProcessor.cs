﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess.TextHelpers
{
	public static class TextConnectorProcessor
	{
		public static string FullFilePath(this string fileName)
		{
			string test = $"{ConfigurationManager.AppSettings["filePath"]}\\{fileName}";
			return $"{ConfigurationManager.AppSettings["filePath"]}\\{fileName}";
		}

		public static List<string> LoadFile(this string file) 
		{
			if(!File.Exists(file)) 
			{
				return new List<string>();
			}

			return File.ReadLines(file).ToList() ;
		}

		public static List<PrizeModel> ConvertToPrizeModels(this List<string> lines)
		{
			List<PrizeModel> output = new List<PrizeModel>();

			foreach (string line in lines) 
			{
				string[] parts = line.Split(',');

				PrizeModel p = new PrizeModel
				{
					Id = int.Parse(parts[0]),
					PlaceNumber = int.Parse(parts[1]),
					PlaceName = parts[2],
					PrizeAmount = decimal.Parse(parts[3]),
					PrizePercentage = double.Parse(parts[4])
				};
				output.Add(p);
			}
			return output ;
		}
		public static void SaveToPrizeFile(this List<PrizeModel> models, string fileName)
		{
			List<string> lines = new List<string>();

			foreach (PrizeModel p in models) 
			{
				lines.Add($"{p.Id},{p.PlaceNumber},{p.PlaceName},{p.PrizeAmount},{p.PrizePercentage}");
			}

			File.WriteAllLines(fileName.FullFilePath(), lines);
		}
	}
}
