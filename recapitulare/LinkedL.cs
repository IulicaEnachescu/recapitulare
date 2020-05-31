using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recapitulare
{
    public class LinkedL
    {
        public LinkedList<int> BubleSort(LinkedList<int> list)
        {
            var size = list.Count;
            if (size > 1)
            {
                if (list.First.Value>list.First.Next.Value)
                {
                    ChangeValues(list.First,list.First.Next);
                }
                var node = list.First;              
                bool flag = true;
                     while (flag)
                      { 
                        flag = false;
                        var currentNode = node;
                        var next = currentNode.Next;
                        for (int j = 0; j < size-1; j++)
                        {
                            if (currentNode.Value > next.Value)
                            {
                                ChangeValues(currentNode, next);
                                flag = true;
                            }
                            currentNode = next;
                            next = next.Next;
                        }
                    }
                    
                }

                return list;
        }

        private static void ChangeValues(LinkedListNode<int> currentNode, LinkedListNode<int> next)
        {
            int temp = currentNode.Value;
            currentNode.Value = next.Value;
            next.Value = temp;
        }
    }
}
