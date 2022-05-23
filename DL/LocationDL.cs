using Entities;

namespace DL
{
    public class LocationDL:ILocationDL
    {
        public static List<Location> MyLocations = new List<Location>();

        public List<Location> GetAll()
        {
            return MyLocations;

        }
        public List<Location> GetByCity(string city)
        {
           
            List<Location> foundLocations = MyLocations.FindAll(obj => obj.City.Equals(city));
            return foundLocations;
        }

          public List<Location> GetByPatientId(string PatientId)
        {
            List<Location> foundLocations = MyLocations.FindAll(obj => obj.PatientId.Equals(PatientId));

            return foundLocations;
        }
          public Location AddLocation(Location location)
        {
            MyLocations.Add(location);
            return location;

        }
    }
}