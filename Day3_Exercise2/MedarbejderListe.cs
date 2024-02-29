using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_exercise2
{
    internal class MedarbejderListe<TKey>
    {
        private readonly Dictionary<TKey, Medarbejder> _collection = new Dictionary<TKey, Medarbejder>();

        public void AddElement(TKey k, Medarbejder p)
        {
            _collection.Add(k, p);
        }

        public int size() { return _collection.Count; }
    }
}
