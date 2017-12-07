using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapSOLID
{
    public class Maybe<T> : IEnumerable<T>
    {
        private readonly IEnumerable<T> _values;

        public Maybe()
        {
            this._values = new T[0];
        }

        public Maybe(T value)
        {
            if (value != null)
            {
                this._values = new[] { value };
            }
            else
            {
                this._values = new T[0];
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            return this._values.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
