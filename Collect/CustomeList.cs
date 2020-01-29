using System;
using System.Collections;
//using System.Collections.Generic;//.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace Collect
{
    public class CustomeList : IEnumerable, ICustomeLink
    {
        
        public Node Head { get; private set; }
        public Node Tail { get; private set; }
        public Notebook this[int index]
        {
            get
            {
                Node currentNode = Head;
                int i = 0;

                while (currentNode != null && i != index)
                {
                    currentNode = currentNode.NextElement;
                    i++;
                }
                return currentNode.Element;
            }
        }
        //=> throw new NotImplementedException();

        public   void Add(Notebook value)
        {
            Node node = new Node (value);
            if (Head == null) 
                Head = node;
            else
                Tail.NextElement = node;
            Tail = node;
            //throw new NotImplementedException();
        }

        public bool Delete(Notebook value)
        {

            Node predNode = null;
            Node currentNode = Head;

            while (currentNode != null)
            {
                if (currentNode.Element.Equals(value))
                {
                    if (predNode != null)
                    {
                        predNode.NextElement = currentNode.NextElement;
                        {
                            if (currentNode.NextElement == null)
                            {
                                Tail = predNode;
                            }
                        }
                    }
                    else
                    {
                        Head = Head.NextElement;
                        if (Head == null)
                        {
                            Tail = null;
                        }
                    }
                    return true;
                }
                predNode = currentNode;
                currentNode = currentNode.NextElement;
            }
            return false;
            //throw new NotImplementedException();
        }


        public IEnumerator GetEnumerator()
        {
            Node current = Head;
            while (current != null)
            {
                yield return current.Element;
                
                current = current.NextElement;
            }
            //return new CustomeListIEnumerator();
            //throw new NotImplementedException();
        }
    }
}
