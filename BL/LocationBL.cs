using DL;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BL
{
    public class LocationBL:ILocationBL
    {
        ILocationDL locationDL;
        public LocationBL (ILocationDL locationDL)
	{
            this.locationDL = locationDL;
	}
          public  List<Location> GetAll()
        {
            return  locationDL.GetAll();
        }
          public  List<Location> GetByCity(string city)
        {
            return  locationDL.GetByCity(city);
        }
          public  List<Location> GetByPatientId(string PatientId)
        {
            return  locationDL.GetByPatientId(PatientId);
        }
          public Location AddLocation(Location location)
        {
            return locationDL.AddLocation(location);
        }
    }
}