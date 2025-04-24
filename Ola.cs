using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_tls
{
    internal class Ola
    {
        public void Start()
        {
            Triangulo t1 = new Triangulo(3, 7);
            Triangulo t2 = new Triangulo(4, 8);

            Triangulo[] tris = {t1, t2, new Triangulo(1,1)};
            //tris[3] = new Triangulo(1,2);//error

            List<Triangulo> lista = new List<Triangulo>();
            lista.Add(t1);
            lista.Add(t2);
            lista.Add(new Triangulo(2,3));
            Console.WriteLine(lista.Count);
            lista.Add(new Triangulo(4, 3));
            Console.WriteLine(lista.Count);
            lista.Remove(t1);
            Console.WriteLine(lista.Count);

            foreach (Triangulo tr in lista) { Console.WriteLine(tr.Area()); }
        }
    }
}
