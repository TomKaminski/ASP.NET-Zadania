using System.Collections.Generic;
using Zaj02MVC.Models;
using Zaj02MVC.ViewModels;

namespace Zaj02MVC.BLL.Interfaces
{
    public interface IFormService: IEntityService<Formularz>
    {
        void RegisterForm(AddReportModel model);
        IList<IndexListModel> GetList(int page = 1, int pageSize = 5);
        int CountForms();
    }
}
