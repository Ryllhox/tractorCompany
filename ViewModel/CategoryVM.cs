using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tractorCompany.Utilities;
using System.Windows.Input;

namespace tractorCompany.ViewModel
{
    internal class CategoryVM : ViewModelBase
    {
        private object _currentView;
        public object CurrentView
        {
            get { return _currentView; }
            set
            {
                _currentView = value;
                onPropertyChanged();
            }
        }
        public ICommand TractorCommand { get; set; }
        public ICommand SpecialTechnicsCommand {  get; set; }
        public ICommand AdditionalEquipmentCommand {  get; set; }

        private void Tractors(object obj) => CurrentView = new TractorsVM();
        private void SpecialTechnics(object obj)=>CurrentView=new SpecialTechnicsVM();
        private void AdditionalEquipment(object obj)=>CurrentView=new AdditionalEquipmentVM();

        public CategoryVM()
        {
            TractorCommand = new RelayCommand(Tractors);
            SpecialTechnicsCommand = new RelayCommand(SpecialTechnics);
            AdditionalEquipmentCommand = new RelayCommand(AdditionalEquipment);

            CurrentView = new CategoryVM();
        }

    }
}
