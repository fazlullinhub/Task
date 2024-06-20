using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp22
{
    
    public class MyList
    {
        public List<int> list = new List<int>();
        public void Add()
        {
            List<int> tmp = new List<int>(list); 
            tmp.Add(0); 
            list = tmp; 
        }

        public void Pop()
        {
            if (list.Count > 0) 
            {
                list.RemoveAt(list.Count - 1); 
            }
            else
            {
                Console.WriteLine("List is empty"); 
            }
        }

        public void Show()
        {
            foreach (var item in list)
            {
                Console.WriteLine(item); 
            }
        }
    }
}
