using System;
using System.Collections;//.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace Collect
{
    public class CustomeListIEnumerator : IEnumerator
    {
        private readonly object Head;

        public object Current => throw new NotImplementedException();

        public bool MoveNext()
        {
            Node current = (Node) Head;
            while (current != null)
            {
                //yield return current.Element;
                if (current.Element.Equals(current.Element))
                    return true;
                current = current.NextElement;
            }
            return false;
            //throw new NotImplementedException();
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }
}
