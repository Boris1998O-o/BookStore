using AutoMapper;
using BookStore.BLL.Interfaces;
using BookStore.BLL.ViewModels.PrintingEditions;
using BookStore.DAL.Interfaces;
using System.Collections.Generic;

namespace BookStore.BLL.Services
{
    public class PrintingEditionService : IPrintingEditionService
    {
        private IUnitOfWork _db;
        private readonly IMapper _mapper;
        public PrintingEditionService(IUnitOfWork db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }
        public GetValuePrintingEditionViewModel PrintingFind(int? id)
        {
            _db.PrintingEditions.Find(id);
            return new GetValuePrintingEditionViewModel();
        }
        public IEnumerable<GetValuePrintingEditionViewModel> GetAllEditions()
        {
            var editions = _db.PrintingEditions.GetAll();
            var getValuePrintingEditionViewModel = _mapper.Map<IEnumerable<GetValuePrintingEditionViewModel>>(editions);
            return getValuePrintingEditionViewModel;
        }
    }
}
