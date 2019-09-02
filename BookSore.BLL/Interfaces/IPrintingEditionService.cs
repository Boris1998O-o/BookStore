using BookStore.BLL.ViewModels.PrintingEditions;

namespace BookStore.BLL.Interfaces
{
    public interface IPrintingEditionService
    {
        GetValuePrintingEditionViewModel PrintingFind(int? id);
    }
}