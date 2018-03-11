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
        int[] _waitingtime;
        int[] _responsetime;
        Random rt = new Random();

        public FCFS(int size)
        {
            _process = new int[size];
            _waitingtime = new int[size];
            _responsetime = new int[size];
        }

        int tat = 0;
        int ret = 0;
        int temp = 0;

        public float Waitedtime(int max)
        {
           for(int i = 0; i < _process.Length; i++)
            {
                    _process[i] = rt.Next(1, max + 1);
            }
           for(int i = 0; i < _process.Length-1; i++)
            {
                _waitingtime[i] = temp + _process[i];
                temp += _process[i];
                tat += _waitingtime[i];
            }
            return (float)tat / _process.Length;
        }

        public float Responetime()
        {
            temp = 0;
            for (int i = 0; i < _process.Length; i++)
            {
                _responsetime[i] = temp + _process[i];
                temp += _process[i];
                ret += _responsetime[i];
            }
            return (float)ret / _process.Length;
        }
        public string show()
        {
            string processes = "";
            for (int i = 0; i < _process.Length; i++)
            {
                processes += "Proceso " + (i + 1) + " es: " + _process[i] + "\r\n";
            }
            return processes;
        }

        public void FillingShortest()
        {
            for (int j = 0; j < _process.Length; j++)
            {
                for (int i = 0; i < _process.Length; i++)
                {
                    if (_process[i] > _process[i + 1])
                    {
                        int shortest = _process[i];
                        _process[i] = _process[i + 1];
                        _process[i + 1] = shortest;
                    }
                }
            }
        }
    }
}

