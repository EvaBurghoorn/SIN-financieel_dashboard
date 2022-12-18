using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Case_study.Models;
using Contentful.Core;
using System.Net.Http;



namespace Case_study.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IContentfulClient _client;
        private readonly IContentfulManagementClient _managementClient;


        public HomeController(ILogger<HomeController> logger, IContentfulClient client, IContentfulManagementClient managementClient)
        {
            _client = client;
            _managementClient = managementClient;
            _logger = logger;
        }

		// GET: Home/Create
		public IActionResult Create()
		{
			return View();
		}

        // POST: Courses/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("voornaam,naam,bankrekeningnummer,bic,datumVanOnkosten,categorie,anders,onkosten,totaalBedrag,bijlage")] onkostenNota onkostenNota)
        {
            // klassen en properties met hoofdletters !!
            if (ModelState.IsValid)
            {
                // return Ok(onkostenNota);
                return Ok("Volledige naam: " + onkostenNota.voornaam + " " + onkostenNota.naam + '\n' +
                "Bankrekeningnummer (bic): " + onkostenNota.bankrekeningnummer + " " + onkostenNota.bic + '\n' +
                "Datum van onkosten: " + onkostenNota.datumVanOnkosten + '\n' +
                "Categorie (anders): " + onkostenNota.categorie + " " + onkostenNota.anders + '\n' +
                "Onkosten: " + onkostenNota.onkosten + '\n' +
                "Totaal bedrag: €" + onkostenNota.totaalBedrag + '\n' +
                "Bijlage: " + onkostenNota.bijlage);

                // Hier client call doen om data weg te schrijven naar Contentful
                // ??? await _managementClient.CreateEntry<onkostenNota>(onkostenNota);
            }
            return View();
        }

        //GET: Home/Nota
        public async Task<IActionResult> Nota()
        {
            var onkostenNota = await _client.GetEntries<onkostenNota>();
            return View(onkostenNota);
        }

            //GET: Home/Index
           public IActionResult Index()
        {
            return View();
        }

        
            // GET: Home/OverzichtNota
        public async Task<IActionResult> OverzichtNota()
        {
            var onkostenNota = await _client.GetEntries<onkostenNota>();
            return View(onkostenNota);
        }

            //POST: Home/Nota
        [HttpPost]
        [Route("Home/Nota")]

        public string Nota(onkostenNota onkostenNota)
        {
            if (ModelState.IsValid)
            {
                Console.WriteLine("Succes");

                return "Succes";
                
                
            }
            return "Error";
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
