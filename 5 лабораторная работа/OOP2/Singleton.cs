using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP2
{
    public sealed class Singleton
    {
        private static Singleton instance;
        public string settings;
        private Singleton(string settings)
        {
            this.settings = settings;
        }
        public static Singleton GetInstance(string settings)
        {
            if (instance == null)
                instance = new Singleton(settings);
            return instance;
        }
    }

  }

