﻿using System;
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
        Random rt = new Random();

        public FCFS(int size)
        {
            _process = new int[size];
            _waitingtime = new int[size];
        }

        /*public void getProcess(int max)
        {
            for (int i = 0; i < _process.Length; i++)
            {
                _process[i] = rt.Next(1, max + 1);
            }
        }*/
        int tat = 0;

        public float Waitedtime(int max)
        {
           for(int i = 0; i < _process.Length; i++)
            {
                    _process[i] = rt.Next(1, max + 1);
            }
           for(int i = 0; i < _process.Length; i++)
            {
                _waitingtime[i] = tat + _process[i];
                tat += _waitingtime[i];
            }
            return (float)tat / _process.Length;
        }
         /// <summary>
        /// Se supone que estos son mis metodos perrones, que le van al crusazul Xds
        /// </summary>
        public void FillingShortest()
        {
            for(int j = 0; j<_process.Length; j++){
                FindingShortest();
            }
        }
        public void FindingShortest()
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
        ///oraleeeeeeeeeeeeeeeeeeeee


        public string show()
        {
            string processes = "";
            for (int i = 0; i < _process.Length; i++)
            {
                processes += "Proceso " + (i + 1) + " es: " + _process[i] + "\r\n";
            }
            return processes;
        }
        
        
    }
}

