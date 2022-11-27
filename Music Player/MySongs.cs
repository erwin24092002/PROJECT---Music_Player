using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Music_Player
{

    public class MySongs
    {
        public DataTable Songs;
        
        public MySongs()
        {
            Songs = new DataTable();
        }
    }
}
