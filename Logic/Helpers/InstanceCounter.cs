using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Helpers
{
    public static class InstanceCounter
    {
        private static Dictionary<Type, int> _instanceCounts = new Dictionary<Type, int>();

        public static void Add(Type type)
        {
            int count;
            if (!_instanceCounts.TryGetValue(type, out count))
            {
                count = 0;
            }

            _instanceCounts[type] = count + 1;
        }

        public static int GetCount(Type type)
        {
            int count;
            if (!_instanceCounts.TryGetValue(type, out count))
            {
                count = 0;
            }

            return count;
        }

        public static void DumpCounts()
        {
            foreach (Type type in _instanceCounts.Keys.OrderBy(k => k.Name))
            {
                Console.WriteLine(string.Format("{0}: {1}", type.Name, _instanceCounts[type]));
            }
        }
    }
}
