using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace greenlife1
{
    public class Image
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public void Open()
        {
           OpenFileDialog open = new OpenFileDialog();
           open.ShowDialog();
        }
         
    }
 


    

    
    
   
    
    
    
    
    
    
   
   
}
