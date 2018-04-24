using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolBinario
{
    class Node<T>
    {
        private T nodo = default (T);
        private Node<T> HijoDerechoNodo = default(Node<T>);
        private Node<T> HijoIzquierdoNodo = default(Node<T>);
        private Node<T> NodoPadre = default(Node<T>);

        public Node ()
        {
            nodo = default(T);
            HijoDerechoNodo = null;
            HijoIzquierdoNodo = null;
        }

        public Node (T node)
        {
            nodo = node;
            HijoIzquierdoNodo = null;
            HijoDerechoNodo = null;
        }

        public T Value
        {
            get { return nodo; }
            set { nodo = value; }
        }

        public Node<T> HijoIzquierdo
        {
            get {return HijoIzquierdoNodo; }
            set { HijoIzquierdoNodo = value; }
        }

        public Node<T> HijoDerecho
        {
            get { return HijoDerechoNodo; }
            set { HijoDerechoNodo = value; }
        }

        public int Count
        {
            get { return count(); }
        }

        private int count()
        {
            if (HijoIzquierdoNodo == null && HijoDerechoNodo == null)
                return 1;
            if (HijoIzquierdoNodo == null)
                return 1 + HijoDerechoNodo.count();
            if (HijoDerechoNodo == null)
                return 1 + HijoIzquierdoNodo.count();
            else
                return 1 + HijoIzquierdoNodo.count() + HijoDerechoNodo.count();
        }
        public void AddRight(Node<T> rightBranch)
        {
            HijoDerechoNodo = rightBranch;
        }

        public void AddLeft (Node<T> leftBranch)
        {
            HijoIzquierdoNodo = leftBranch;
        }


    }
}