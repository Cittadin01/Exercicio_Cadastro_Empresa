//using CadastroEmpresa.DataBase;
using CadastroEmpresa.Models.Company;
using CadastroEmpresa.ViewModel.Company;
using System;
//using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace CadastroEmpresa.Controllers
{
    public class CompanyController : Controller
    {
        //private readonly CompanyDb _context;

        public CompanyController()
        {
            //_context = new CompanyDb();
        }

        //public async Task<ActionResult> Index()
        //        {
        //            return View(
        //                await _context.Company
        //                    .Select(i => new CompanyIndexModel
        //                    {
        //                        Id = i.Id,
        //                        Cnpj = i.Cnpj,
        //                        Nome = i.Nome,
        //                        País = i.País,
        //                        Endereço = i.Endereço,
        //                        Numero = i.Numero,
        //                        Cep = i.Cep,
        //                        Active = i.Active
        //                    })
        //                    .ToListAsync()
        //            );
        //        }

        //        private ActionResult View(object value)
        //        {
        //            throw new NotImplementedException();
        //        }

        //        public async Task<ActionResult> Details(int id)
        //        {
        //            var company = await _context.Import.FirstOrDefaultAsync(i => i.Id == id);

        //            var viewModel = new CompanyDetailModel
        //            {
        //                Id = company.Id,
        //                Cnpj = company.Cnpj,
        //                Nome = company.Nome,
        //                País = company.País,
        //                Endereço = company.Endereço,
        //                Numero = company.Numero,
        //                Cep = company.Cep,
        //                Active = company.Active,
        //            };

        //            return View(viewModel);
        //        }

        //        public ActionResult Create()
        //        {
        //            return View(new CompanyFormModel());
        //        }

        //        public async Task<ActionResult> Create(CompanyFormModel viewModel)
        //        {

        //            var company = new Company
        //            {
        //                Id = viewModel.Id,
        //                Cnpj = viewModel.Cnpj,
        //                Nome = viewModel.Nome,
        //                País = viewModel.País,
        //                Endereço = viewModel.Endereço,
        //                Numero = viewModel.Numero,
        //                Cep = viewModel.Cep,
        //                Active = viewModel.Active,
        //            };

        //            _context.Company.Add(company);
        //            await _context.SaveChangesAsync();

        //            return RedirectToAction("Index");
        //        }

        //        private ActionResult RedirectToAction(string v)
        //        {
        //            throw new NotImplementedException();
        //        }

        //        public async Task<ActionResult> Edit(int id)
        //        {
        //            var company = await _context.Import.FirstOrDefaultAsync(i => i.Id == id);

        //            var viewModel = new CompanyFormModel
        //            {
        //                Id = company.Id,
        //                Cnpj = company.Code,
        //                Nome = company.Nome,
        //                País = company.País,
        //                Endereço = company.Endereço,
        //                Numero = company.Numero,
        //                Cep = company.Cep,
        //                Active = company.Active,
        //            };

        //            return View(viewModel);
        //        }

        //        public async Task<ActionResult> Edit(CompanyFormModel viewModel)
        //        {
        //            if (!ModelState.IsValid) return View(viewModel);

        //            var company = await _context.Import.SingleOrDefaultAsync(i => i.Id == viewModel.Id);

        //            company.Id = viewModel.Id;
        //            company.Cnpj = viewModel.Cnpj;
        //            company.Nome = viewModel.Nome;
        //            company.País = viewModel.País;
        //            company.Endereço = viewModel.Endereço;
        //            company.Numero = viewModel.Numero;
        //            company.Cep = viewModel.Cep;
        //            company.Active = viewModel.Active;

        //            await _context.SaveChangesAsync();

        //            return RedirectToAction("Index");
        //        }

        //        public async Task<ActionResult> Delete(int id)
        //        {
        //            var company = await _context.Company.FirstOrDefaultAsync(i => i.Id == id);

        //            var viewModel = new CompanyDeleteModel
        //            {
        //                Id = id,
        //                Nome = company.Nome,
        //            };

        //            return View(viewModel);
        //        }

        //        public async Task<ActionResult> DeleteConfirmed(int id)
        //        {
        //            var company = await _context.Company.FirstOrDefaultAsync(i => i.Id == id);

        //            _context.Company.Remove(company);
        //            await _context.SaveChangesAsync();
        //            return RedirectToAction(nameof(Index));
        //        }

        //        protected override void Dispose(bool disposing)
        //        {
        //            if (disposing)
        //            {
        //                _context.Dispose();
        //            }
        //            base.Dispose(disposing);
        //        }
    }
}