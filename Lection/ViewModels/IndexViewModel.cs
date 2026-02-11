using Lection.Models;

namespace Lection.ViewModels
{
    public class IndexViewModel
    {
        public IEnumerable<Phone> Phones { get; set; }
        public IEnumerable<CompanyViewModel> Companies { get; set; }
        public int? SelectedCompanyId { get; set; }


    }
}