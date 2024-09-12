using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bebebebababa
{
    public class MainVM:BaseVM
    {
        private List<Mob> _mobs;
        public List<Mob> Mobs
        {
            get => _mobs;
            set
            {
                _mobs = value;
            }
        }

        private List<Abillity> _abillities;
        public List<Abillity> Abillities
        {
            get=> _abillities;
            set
            {
                _abillities = value;
            }
        }


    }
}
