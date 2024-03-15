using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tractorCompany.Model;

namespace tractorCompany.ViewModel
{
    internal class TractorsVM : Utilities.ViewModelBase
    {
        private readonly TractorModel _tractorModel;
        
        public string TractorName
        {
            get
            {
                return _tractorModel.Name;
            }
            set
            {
                _tractorModel.Name = value;
                onPropertyChanged();
            }
        }

        public int TractorPrice
        {
            get
            {
                return _tractorModel.Price;
            }
            set
            {
                _tractorModel.Price = value;
                onPropertyChanged();
            }
        }

        public int TractorPower
        {
            get
            {
                return _tractorModel.Power;
            }
            set
            {
                _tractorModel.Power = value;
                onPropertyChanged();
            }
        }
        public string TractorImage
        {
            get { return _tractorModel.Image; }
            set
            {
                _tractorModel.Image = value;
                onPropertyChanged();
            }
        }

        public TractorsVM()
        {
            _tractorModel = new TractorModel();

            TractorName = "МТЗ-8";
            TractorPrice = 1000000;
            TractorPower = 100;
            TractorImage = "/Images/MTZ-8.jpg";
        }
        
    }
}
