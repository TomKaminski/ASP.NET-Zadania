using System.Collections.Generic;
using System.Linq;
using Zaj02MVC.BLL.Interfaces;
using Zaj02MVC.Infrastructure.Interfaces;
using Zaj02MVC.Models;
using Zaj02MVC.ViewModels;

namespace Zaj02MVC.BLL.Concrete
{
    public class FormService : EntityService<Formularz>, IFormService
    {
        readonly IGenRepository<Formularz> _formRepository;

        public FormService(IGenRepository<Formularz> formRepository, IUnitOfWork unitOfWork)
            : base(unitOfWork,formRepository)
        {
            _formRepository = formRepository;
            UnitOfWork = unitOfWork;
        }

        public IUnitOfWork UnitOfWork;

        public void RegisterForm(AddReportModel model)
        {
            _formRepository.Add(new Formularz
            {
                AuthorEmail = model.AuthorEmail,
                AuthorLastName = model.AuthorLastName,
                AuthorName = model.AuthorName,
                DefenderLastName = model.DefenderLastName,
                DefenderName = model.DefenderName,
                ReportSummary = model.ReportSummary,
                ReportTitle = model.ReportTitle,
                SubAuthorName = model.SubAuthorName,
                SubAuthorLastName = model.SubAuthorLastName,
                UniversityAddress = model.UniversityAddress,
                UniversityName = model.UniversityName
            });
            UnitOfWork.Commit();
        }

        public IList<IndexListModel> GetList(int page = 1, int pageSize = 5)
        {
            return _formRepository.GetAll().Skip(page*pageSize + pageSize).Take(pageSize).Select(x => new IndexListModel
            {
                AuthorLastName = x.AuthorLastName,
                AuthorName = x.AuthorName,
                DefenderLastName = x.DefenderLastName,
                DefenderName = x.DefenderName,
                Email = x.AuthorEmail,
                SubAuthorName = x.SubAuthorName,
                SubAuthorLastName = x.SubAuthorLastName,
                ReportTitle = x.ReportTitle
            }).ToList();
        }

        public int CountForms()
        {
            return _formRepository.GetAll().Count();
        }
    }
}