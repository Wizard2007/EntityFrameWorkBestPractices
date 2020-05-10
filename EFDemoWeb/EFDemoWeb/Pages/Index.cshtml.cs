using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFDataAccessLibrary.DataAccess;
using EFDataAccessLibrary.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;


namespace EFDemoWeb.Pages
{
    public class IndexModel : PageModel
    {
        private readonly PeopleContext _db;

        public IndexModel(PeopleContext db)
        {
            _db = db;
        }
        public void OnGet()
        {
            LoadSampleData();

            var people = _db.People
                .Include(p => p.Addresses)
                .Include(p => p.EmailAddresses)
                .ToList();
        }

        private void LoadSampleData()
        {
            if(!_db.People.Any())
            {
                var fileName = "generated.json";
                if (System.IO.File.Exists(fileName))
                {
                    string json = System.IO.File.ReadAllText(fileName);
                    var people = JsonConvert.DeserializeObject<List<Person>>(json);
                    _db.AddRange(people);
                    _db.SaveChanges();
                }
            }
        }
    }
}
