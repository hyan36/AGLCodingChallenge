using APD.AGL.Services.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace APD.AGL.Services.Services
{
    public class PeopleServices : IPeopleServices
    {

        protected List<People> _peoples;

        public List<People> Peoples {
            get
            {
                if (_peoples == null)
                {
                    _peoples = LoadData();
                }
                return _peoples;
            }
        }

        public  List<People> LoadData()
        {
            var result = new List<People>();
            using (var webclient = new WebClient())
            {
                var json = webclient.DownloadString("http://agl-developer-test.azurewebsites.net/people.json");
                result = JsonConvert.DeserializeObject<List<People>>(json);
            }
            return result;
        }

        public List<Pet> GetCatByGender(string gender)
        {
            var cats = Peoples.Where(o => gender.Equals(o.Gender) && o.Pets != null&& o.Pets.Any(p => "Cat".Equals(p.Type)))
                .Select(o => o.Pets.Where(p => "Cat".Equals(p.Type)).ToList())
                .ToList();
            var result = new List<Pet>();
            cats.ForEach(o => o.ForEach(x => result.Add(x)));
            return result;
        }
    }
}
