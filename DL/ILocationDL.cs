using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DL
{
    public interface ILocationDL
    {
                public List<Location> GetAll();
                public List<Location> GetByCity(string city);
                public List<Location> GetByPatientId(string PatientId);
                public Location AddLocation(Location location);
        
    }
}
