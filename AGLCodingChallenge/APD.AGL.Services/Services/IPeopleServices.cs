using System.Collections.Generic;
using System.Threading.Tasks;
using APD.AGL.Services.Models;

namespace APD.AGL.Services.Services
{
    public interface IPeopleServices
    {
        List<People> Peoples { get; }

        List<Pet> GetCatByGender(string gender);

        List<People> LoadData();
    }
}