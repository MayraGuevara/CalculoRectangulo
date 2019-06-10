using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CaluloRectangulo
{
    public class ClaseRectangulo : INotifyPropertyChanged
    {
        private string ax;
        private string ay;

        private string bx;
        private string by;

        private string cx;
        private string cy;

        private string dx;
        private string dy;

        private string altura;
        private string baseR;
        private string perimetro;
        private string area;
        private bool validar;
        private string resultado;

        public string AX
        {
            get { return ax; }
            set
            {
                int numero;
                bool resultado = int.TryParse(value, out numero);
                if (resultado) ax = value;
                OnPropertyChanged("AX");
                OnPropertyChanged("Altura");
                OnPropertyChanged("Base");
            }
        }

        
    }



    {
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
