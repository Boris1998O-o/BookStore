using AutoMapper;
using BookStore.BLL.ViewModels.PrintingEditions;
using BookStore.DAL.Entities;

namespace BookStore.BLL.Configurations
{
    public class BLLProfile:Profile
    {
        public BLLProfile()
        {
            CreateMap<GetValuePrintingEditionViewModel, PrintingEdition>();
        }
    }
}