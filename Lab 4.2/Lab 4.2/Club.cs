using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using System.Windows.Forms;

namespace Lab_4._2
{
    [Serializable]
    public class Club
    {
        public string ClubName { get; set; }     
        public string FacultyName { get; set; }  
        public string CathedraName { get; set; }  
        public string Day { get; set; } 
        public string Time { get; set; }    
        public string Chief { get; set; }
        public string Orientation { get; set; }
        public string HeadFullName { get; set; }  

    }
}
