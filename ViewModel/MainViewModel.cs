using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;

namespace Examen_Mvvm.ViewModel
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        private decimal producto1;

        [ObservableProperty]
        private decimal producto2;

        [ObservableProperty]
        private decimal producto3;

        [ObservableProperty]
        private decimal subtotal;

        [ObservableProperty]
        private decimal descuento;

        [ObservableProperty]
        private decimal total;

        public MainViewModel()
        {
            LimpiarCampos();
        }

        [RelayCommand]
        public void CalcularDescuento()
        {
            try
            {
                Subtotal = Producto1 + Producto2 + Producto3;

                if (Subtotal >= 10000)
                {
                    Descuento = Subtotal * 0.30m;
                }
                else if (Subtotal >= 5000)
                {
                    Descuento = Subtotal * 0.20m;
                }
                else if (Subtotal >= 1000)
                {
                    Descuento = Subtotal * 0.10m;
                }
                else
                {
                    Descuento = 0;
                }

                Total = Subtotal - Descuento;
            }
            catch (Exception ex)
            {
                // Manejo de excepciones si se requiere
            }
        }

        [RelayCommand]
        public void LimpiarCampos()
        {
            Producto1 = 0;
            Producto2 = 0;
            Producto3 = 0;
            Subtotal = 0;
            Descuento = 0;
            Total = 0;
        }
    }
}
