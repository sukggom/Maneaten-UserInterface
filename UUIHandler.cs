using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UG.Framework
{
    public class UUIHandler
    {
        private static int Count = 0;

        private int Handle;

        internal UUIHandler()
        {
            Handle = ++Count;
        }

        public int Get()
        {
            return Handle;
        }
        public override string ToString()
        {
            return Handle.ToString();
        }

        public static bool operator ==(UUIHandler a, UUIHandler b)
        {
          
            return a.Handle.Equals(b.Handle);
        }

        public static bool operator !=(UUIHandler a, UUIHandler b)
        {
            return !a.Handle.Equals(b.Handle);
        }

        public override int GetHashCode()
        {
            return Handle.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            return this.Equals((UUIHandler)obj);
        }

        public bool Equals(UUIHandler b)
        {
            if (this.Handle.Equals(b.Handle) == true)
            {
                return true;
            }

            return false;
        }

        public static readonly UUIHandler Invalid = new UUIHandler() { Handle = -1 };
    }
}
