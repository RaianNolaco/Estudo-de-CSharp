﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo.CursoUdemy.Secao13.ExemploAula
{
    public class PrintService
    {
        private int[] _values = new int[10];
        private int _count = 0;
        public void addValue(int valor)
        {
            if (_count == 10)
                throw new InvalidOperationException("Print service is full");

            _values[_count] = valor;
            _count++;
        }

        public void first()
        {
            if (_count == 0)
                throw new InvalidOperationException("Print service is empty");

            Console.WriteLine("First: " + _values[0]);
        }

        public void print()
        {
            string valorPirnt = "[";
            for (int i = 0; i < _count-1; i++)
            {
                valorPirnt += _values[i] + ", ";
            }
            
            if(_count > 0)
            {
                valorPirnt += _values[_count - 1];
            }

            Console.WriteLine(valorPirnt + "]");

        }
    }
}
