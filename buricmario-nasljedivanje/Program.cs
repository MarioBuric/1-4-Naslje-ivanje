using buricmario_nasljedivanje;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buricmario_nasljedivanje
{
    interface IControl

    {
        void Metoda();
        int Brojac{ get; set; }
    }


    class ListBox : IControl
    {
        private int brojac;
        public void Metoda()
        {
            Console.WriteLine("Metoda List");
        }
        public int Brojac
        {
            get { return brojac; }
            set { brojac = value; }
        }
    }
    
    class ComboBox : IControl
    {
        public int Brojac { get; set; }

        public void Metoda()
        {

        }
    }
    
   

    }
class Program
{
    static void Main(string[]args)
    {
        ListBox x = new ListBox();
        ComboBox y = new ComboBox();
        x.Metoda();
        y.Metoda();
    }

}



    
    

