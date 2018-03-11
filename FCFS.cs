using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planificador_de_Procesos
{
    class FCFS
    {
        private int[] _process;
        Random rt = new Random();

        public FCFS(int size)
        {
            _process = new int[size];
        }

        public void getProcess(int max)
        {
            for (int i = 0; i < _process.Length; i++)
            {
                _process[i] = rt.Next(1, max + 1);
            }
        }

        public string show()
        {

            string processes = "";
            for (int i = 0; i < _process.Length; i++)
            {
                processes += "Proceso " + (i + 1) + " es: " + _process[i] + "time " + "\r\n";
            }
            return processes;
        }
    }
}

