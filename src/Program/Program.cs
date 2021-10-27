using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {

            Person Belen = new Person("Belen", 23);
            Person Dana = new Person("Dana", 19);
            Person Joaco = new Person("Joaco", 18);
            Person Juan = new Person("Juan", 20);
            Person Maria = new Person("Maria", 50);
            Person Marcos = new Person("Marcos", 52);
            Person Valentina = new Person("Valentina", 20);
            Person Pepe = new Person("Pepe", 83);
            

            Node n1 = new Node(1, Belen);
            Node n2 = new Node(2, Dana);
            Node n3 = new Node(3, Joaco);
            Node n4 = new Node(4, Juan);
            Node n5 = new Node(5, Maria);
            Node n6 = new Node(6, Marcos);
            Node n7 = new Node(7, Valentina);
            Node n8 = new Node(8, Pepe);

            n5.AddChildren(n2);
            n5.AddChildren(n3);
            n5.AddChildren(n1);

            n6.AddChildren(n4);
            n6.AddChildren(n7);

            n8.AddChildren(n5);
            n8.AddChildren(n6);

            // visitar el árbol aquí
        }
    }
}
