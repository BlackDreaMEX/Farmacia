using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ecommerce.Models
{
    public class Facturas
    {
        public Facturas(int Id, DateTime fecha, string prov, float tot, int estatus)
        {
            this.id = Id;
            this.fechapago = fecha;
            this.proveedor = prov;
            this.total = tot;
            this.estatuspago = estatus;
        }

        public int id { get; set; }
        public DateTime fechapago { get; set; }
        public string proveedor { get; set; }
        public float total { get; set; }
        public int estatuspago { get; set; }

        public virtual ICollection<PagoProveedor> PagoProveedor { get; set; }

    }

    // Collection of Person objects. This class
    // implements IEnumerable so that it can be used
    // with ForEach syntax.
    public class Factura : IEnumerable
    {
        private Facturas[] _people;
        public Factura(Facturas[] pArray)
        {
            _people = new Facturas[pArray.Length];

            for (int i = 0; i < pArray.Length; i++)
            {
                _people[i] = pArray[i];
            }
        }

        // Implementation for the GetEnumerator method.
        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }

        public PeopleEnum GetEnumerator()
        {
            return new PeopleEnum(_people);
        }
    }

    // When you implement IEnumerable, you must also implement IEnumerator.
    public class PeopleEnum : IEnumerator
    {
        public Facturas[] _people;

        // Enumerators are positioned before the first element
        // until the first MoveNext() call.
        int position = -1;

        public PeopleEnum(Facturas[] list)
        {
            _people = list;
        }

        public bool MoveNext()
        {
            position++;
            return (position < _people.Length);
        }

        public void Reset()
        {
            position = -1;
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public Facturas Current
        {
            get
            {
                try
                {
                    return _people[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }
    }

}