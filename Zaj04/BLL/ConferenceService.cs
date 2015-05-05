using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Zaj04.Models;
using Zaj04.Models.EF;
using Zaj04.Repository.Concrete;
using Zaj04.Repository.Interfaces;
using Zaj04.ViewModels;

namespace Zaj04.BLL
{
    [DataObject]
    public class ConferenceService
    {
        private readonly IConferenceRepository _conferenceRepository;

        public ConferenceService()
        {
            _conferenceRepository = new EfConferenceRepository();
        }

        public void Register(ConferenceViewModel conferenceViewModel)
        {
            _conferenceRepository.Add(new Conference
            {
                AuthorFirstName = conferenceViewModel.AuthorFirstName,
                Email = conferenceViewModel.Email,
                AuthorLastName = conferenceViewModel.AuthorLastName,
                ArticleTitle = conferenceViewModel.ArticleTitle,
                ArticleAbstract = conferenceViewModel.ArticleAbstract
            });
        }

        public IList<ConferenceViewModel> Get()
        {
            return _conferenceRepository.GetAll().Select(x => new ConferenceViewModel
            {
                Email = x.Email,
                AuthorLastName = x.AuthorLastName,
                AuthorFirstName = x.AuthorFirstName,
                ArticleAbstract = x.ArticleAbstract,
                ArticleTitle = x.ArticleTitle
            }).ToList();
        }

        public IList<ConferenceViewModel> Get(int maximumRows,int startRowIndex)
        {
            return Get().Skip(startRowIndex).Take(maximumRows).ToList();
        }

        public int GetCount()
        {
            return _conferenceRepository.GetAll().Count();
        }
    }
}