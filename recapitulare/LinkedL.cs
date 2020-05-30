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
                    for (int i = 0; i < size-1; i++)
                    {
                        var currentNode = list.First;
                        var next = currentNode.Next;
                        for (int j = i; j < size-1; j++)
                        {
                            if (currentNode.Value > next.Value)
                            {
                                int temp = currentNode.Value;
                                currentNode.Value = next.Value;
                                next.Value = temp;
                            }
                            currentNode = next;
                            next = next.Next;
                        }
                    }
                }

                return list;
        }
    }
}
