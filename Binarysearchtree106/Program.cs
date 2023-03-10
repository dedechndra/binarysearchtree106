using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binarysearchtree106
{
    class Program
    {
        /*A node class consi
         * 
         */
        class node
        {
            public string info;
            public node lchild;
            public node rchild;
            //constructor for the node class

            public node(string i, node l, node r)
            {
                info = i;
                lchild = l;
                rchild = r;
            }
        }

        class BinaryTree
        {
            public node ROOT;
            public BinaryTree()
            {
                ROOT = null; // intializing root to null
            }

            public void insert(string element)// insert a node in the binary 
            {
                node tmp, parent  = null, currentnode = null;
                find(element, ref parent, ref currentnode);
                if (currentnode != null) //
                {
                    Console.WriteLine("duplicate words not allowed");
                    return;
                }
                else //if rhe specified node is not present
                {
                   tmp =  new node(element, null, null);
                   if (parent == null)
                    {
                        ROOT = temp;
                    }
                   else if (string.Compare(element, parent.info) <0)
                    {
                        if (string.Compare(element, parent.info) < 0)
                            parent.lchild = tmp;
                    }
                   else
                    {
                        parent.rchild = temp;
                    }
                }
            }
            public void find(string element, ref node parent, ref node currentnode)
            {
                currentnode = ROOT;
                parent = null;
                while ((currentnode != null) && (currentnode.info != element))
                {
                    parent = currentnode;
                    if (string.Compare(element, currentnode.info) < 0)
                        currentnode = currentnode.lchild;
                    else
                        currentnode = currentnode.rchild;
                }
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

  
}
