using System ;
using System.Collections ;

namespace Question2
{
    class Program
    {   
        
         static void Main(string[] args)
        {  ArrayList _list = new ArrayList() ;
           ArrayList _list2 = new ArrayList() ;
           ArrayList _list3 = new ArrayList() ;
            for (int i = 0 ; i<20 ; i++)
                {Console.WriteLine("Bir sayi giriniz") ;
                try{
                    int number = Convert.ToInt32(Console.ReadLine()) ;
                    _list.Add(number) ;
                }
                catch (Exception)
                {
                    Console.WriteLine("Sayi algilanamadi") ;
                }
                }
                _list.Sort () ;
                foreach (var item in _list)
                    _list2.Add(item) ;
                int count = _list.Count ;
                Console.WriteLine("En buyuk 3") ;
                Console.WriteLine(_list2[count-1]) ;
                Console.WriteLine(_list2[count-2]) ;
                Console.WriteLine(_list2[count-3]) ;
                
                Console.WriteLine("En kucuk 3") ;
                Console.WriteLine(_list2[0]) ;
                Console.WriteLine(_list2[1]) ;
                Console.WriteLine(_list2[2]) ;
                float minavg = (Convert.ToInt32(_list2[0]) + Convert.ToInt32(_list2[1]) + Convert.ToInt32(_list2[2])) /3 ;
                 
                float maxavg = (Convert.ToInt32(_list2[count-1]) + Convert.ToInt32(_list2[count-2]) + Convert.ToInt32(_list2[count-3])) /3 ;
                Console.WriteLine("Min Avg") ;
                Console.WriteLine(minavg) ;
                Console.WriteLine("Max Avg") ;
                Console.WriteLine(maxavg) ;
                Console.WriteLine("Toplam:" + (maxavg+minavg)) ;
                
        }
    }
    }

