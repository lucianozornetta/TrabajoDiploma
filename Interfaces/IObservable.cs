using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IObservable
    {
        void AgregarObservador(IObserver observer);

        void EliminarObservador(IObserver observer);

        void NotificarObservadores();

        List<IObserver> Lista { get; set; }


    }
}
