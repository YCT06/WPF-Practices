using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20241016
{
	public class Station
	{
		public string StationID { get; set; }
		public string StationName { get; set; }
		public bool IsEquipError { get; set; }


		public Station()
		{

		}

		public Station(string stationID, string stationName, bool isEquipError)
		{
			StationID = stationID;
			StationName = stationName;
			IsEquipError = isEquipError;
		}

		public Station(Station source)
		{
			StationID = source.StationID;
			StationName = source.StationName;
			IsEquipError = source.IsEquipError;
		}
	}
}
