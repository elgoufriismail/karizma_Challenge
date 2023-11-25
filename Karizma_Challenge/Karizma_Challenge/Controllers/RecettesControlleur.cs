using Karizma_Challenge.Data;
using Karizma_Challenge.Models;
using Karizma_Challenge.Models.Domain;
using Microsoft.AspNetCore.Mvc;

namespace Karizma_Challenge.Controllers
{
    public class RecettesControlleur : Controller
    {
        private readonly KarizmaChallengeDbContext karizmaChallengeDbContext;

        public RecettesControlleur( KarizmaChallengeDbContext karizmaChallengeDbContext) {
            this.karizmaChallengeDbContext = karizmaChallengeDbContext;
        }
        [HttpGet]
        [Route("Recettes/ajouter")]
        public IActionResult ajouter()
        {
            return View();
        }

        [HttpPost]
        [Route("Recettes/ajouter")]
        public async Task<IActionResult> ajouter(AjouterRecetteViewModel ajouterRecetteRequest)
        {


            var recette = new Recette()
            {
                Id = Guid.NewGuid(),
                Name = ajouterRecetteRequest.Name,
                duree = ajouterRecetteRequest.duree,
                etape = ajouterRecetteRequest.etape
            };

            await karizmaChallengeDbContext.AddAsync(recette);
            await karizmaChallengeDbContext.SaveChangesAsync();
            return RedirectToAction("ajouter");
        }

    }
}
