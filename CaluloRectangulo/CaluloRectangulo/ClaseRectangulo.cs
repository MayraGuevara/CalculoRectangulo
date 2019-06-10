using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows;

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

        public string BX
        {
            get { return bx; }
            set
            {
                int numero;
                bool resultado = int.TryParse(value, out numero);
                if (resultado) bx = value;
                OnPropertyChanged("BX");
                OnPropertyChanged("Altura");
                OnPropertyChanged("Base");

            }


        }

        public string CX
        {
            get { return cx; }
            set
            {
                int numero;
                bool resultado = int.TryParse(value, out numero);
                if (resultado) cx = value;
                OnPropertyChanged("CX");
                OnPropertyChanged("Altura");
                OnPropertyChanged("Base");

            }


        }

        public string DX
        {
            get { return dx; }
            set
            {
                int numero;
                bool resultado = int.TryParse(value, out numero);
                if (resultado) dx = value;
                OnPropertyChanged("DX");
                OnPropertyChanged("Altura");
                OnPropertyChanged("Base");

            }


        }
        public string AY
        {
            get { return ay; }
            set
            {
                int numero;
                bool resultado = int.TryParse(value, out numero);
                if (resultado) ay = value;
                OnPropertyChanged("AY");
                OnPropertyChanged("Altura");
                OnPropertyChanged("Base");

            }


        }
        public string BY
        {
            get { return by; }
            set
            {
                int numero;
                bool resultado = int.TryParse(value, out numero);
                if (resultado) by = value;
                OnPropertyChanged("BY");
                OnPropertyChanged("Altura");
                OnPropertyChanged("Base");

            }


        }

        public string CY
        {
            get { return cy; }
            set
            {
                int numero;
                bool resultado = int.TryParse(value, out numero);
                if (resultado) cy = value;
                OnPropertyChanged("CY");
                OnPropertyChanged("Altura");
                OnPropertyChanged("Base");

            }


        }

        public string DY
        {
            get { return dy; }
            set
            {
                int numero;
                bool resultado = int.TryParse(value, out numero);
                if (resultado) dy = value;
                    OnPropertyChanged("DY");
                    OnPropertyChanged("Altura");
                    OnPropertyChanged("Base");
            }


        }

        public bool distancia()
        {


            Double ab, dc, da, cb;
            Double ab2, dc2, da2, cd2;

            ab = Math.Pow((int.Parse(AX) - int.Parse(BX)), 2) + Math.Pow((int.Parse(AY) - int.Parse(BY)), 2);
            ab2 = Math.Sqrt(ab);
            dc = Math.Pow((int.Parse(DX) - int.Parse(CX)), 2) + Math.Pow((int.Parse(DY) - int.Parse(CY)), 2);
            dc2 = Math.Sqrt(dc);

            da = Math.Pow((int.Parse(DX) - int.Parse(AX)), 2) + Math.Pow((int.Parse(DY) - int.Parse(AY)), 2);
            da2 = Math.Sqrt(da);

            cb = Math.Pow((int.Parse(CX) - int.Parse(BX)), 2) + Math.Pow((int.Parse(CY) - int.Parse(BY)), 2);
            cd2 = Math.Sqrt(cb);

            if (ab2 != dc2 && da2 != cd2)
            {
                MessageBox.Show("No se puede Crear el Rectangulo!");
                validar = false;
            }
            else
            {
                // MessageBox.Show("Se creo el Rectangulo");
                validar = true;
            }

            return validar;
        }

        public string Base
        {
            get
            {

                if (distancia() != false)
                {
                    double ab, ab2;
                    ab = Math.Pow((int.Parse(AX) - int.Parse(BX)), 2) + Math.Pow((int.Parse(AY) - int.Parse(BY)), 2);

                    ab2 = Math.Sqrt(ab);

                    baseR = ab2.ToString();



                }
                return baseR.ToString();
            }
            set
            {


                if (distancia() != false)
                {
                    Double ab, ab2;

                    ab = Math.Pow((int.Parse(AX) - int.Parse(BX)), 2) + Math.Pow((int.Parse(AY) - int.Parse(BY)), 2);
                    ab2 = Math.Sqrt(ab);

                    baseR = ab2.ToString();
                    OnPropertyChanged("Base");


                }



            }
        }



        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string property)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(property));
        }
    }


}

