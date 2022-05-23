using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
namespace BL
{
    public interface ILocationBL
    {
           List<Location> GetAll();
           List<Location> GetByCity(string city);
           List<Location> GetByPatientId(string PatientId);
           Location AddLocation(Location location);
    }
}
