using FoxClub.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoxClub.Services
{
    public class FoxService
    {
        private List<Fox> Foxes { get; set; }

        public FoxService()
        {
            Foxes = new List<Fox>();
        }

        public void AddFoxToList(string name)
        {
            Foxes.Add(new Fox(name)); 
        }

        public Fox GetFox(string name)
        {        
            return Foxes.FirstOrDefault(f => f.Name == name);
        }
    }
}
