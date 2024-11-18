using ImportCrud.Database;
using ImportCrud.Models.Imports;
using ImportCrud.ViewModel.Imports;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace ImportCrud.Controllers
{
    [Authorize]
    public class ImportController : Controller
    {
        private readonly ImportDbContext _context;

        public ImportController()
        {
            _context = new ImportDbContext();
        }

        public async Task<ActionResult> Index()
        {
            return View(
                await _context.Import
                    .Select(i => new ImportIndexViewModel
                    {
                        Id = i.Id,
                        Code = i.Code,
                        Company = i.Company,
                        Origin = i.Origin,
                        Destination = i.Destination,
                        TotalValue = i.TotalValue,
                        Active = i.Active
                    })
                    .ToListAsync()
            );
        }

        public async Task<ActionResult> Details(int id)
        {
            var import = await _context.Import.FirstOrDefaultAsync(i => i.Id == id);
            if (import == null) return HttpNotFound();

            var viewModel = new ImportDetailsViewModel
            {
                Id = import.Id,
                Code = import.Code,
                Company = import.Company,
                Origin = import.Origin,
                Destination = import.Destination,
                TotalValue = import.TotalValue,
                Active = import.Active,
                ProcessDate = import.ProcessDate,
                EstimatedTimeDeparture = import.EstimatedTimeDeparture,
                EstimatedTimeArrival = import.EstimatedTimeArrival
            };

            return View(viewModel);
        }

        public ActionResult Create()
        {
            return View(new ImportFormViewModel());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(ImportFormViewModel viewModel)
        {
            if (!ModelState.IsValid) return View(viewModel);

            var import = new Import
            {
                Code = viewModel.Code,
                Company = viewModel.Company,
                Origin = viewModel.Origin,
                Destination = viewModel.Destination,
                TotalValue = viewModel.TotalValue,
                Active = viewModel.Active,
                ProcessDate = viewModel.ProcessDate,
                EstimatedTimeDeparture = viewModel.EstimatedTimeDeparture,
                EstimatedTimeArrival = viewModel.EstimatedTimeArrival
            };

            _context.Import.Add(import);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        public async Task<ActionResult> Edit(int id)
        {
            var import = await _context.Import.FirstOrDefaultAsync(i => i.Id == id);
            if (import == null) return HttpNotFound();

            var viewModel = new ImportFormViewModel
            {
                Id = import.Id,
                Code = import.Code,
                Company = import.Company,
                Origin = import.Origin,
                Destination = import.Destination,
                TotalValue = import.TotalValue,
                Active = import.Active,
                ProcessDate = import.ProcessDate,
                EstimatedTimeDeparture = import.EstimatedTimeDeparture,
                EstimatedTimeArrival = import.EstimatedTimeArrival
            };

            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(ImportFormViewModel viewModel)
        {
            if (!ModelState.IsValid) return View(viewModel);

            var import = await _context.Import.SingleOrDefaultAsync(i => i.Id == viewModel.Id);
            if (import == null) return HttpNotFound();

            import.Code = viewModel.Code;
            import.Company = viewModel.Company;
            import.Origin = viewModel.Origin;
            import.Destination = viewModel.Destination;
            import.TotalValue = viewModel.TotalValue;
            import.Active = viewModel.Active;
            import.ProcessDate = viewModel.ProcessDate;
            import.EstimatedTimeDeparture = viewModel.EstimatedTimeDeparture;
            import.EstimatedTimeArrival = viewModel.EstimatedTimeArrival;

            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        public async Task<ActionResult> Delete(int id)
        {
            var import = await _context.Import.FirstOrDefaultAsync(i => i.Id == id);
            if (import == null) return HttpNotFound();

            var viewModel = new ImportDeleteViewModel
            {
                Id = id,
                Code = import.Code,
                Company = import.Company,
            };

            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            var import = await _context.Import.FirstOrDefaultAsync(i => i.Id == id);
            if (import == null) return HttpNotFound();

            _context.Import.Remove(import);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _context.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
