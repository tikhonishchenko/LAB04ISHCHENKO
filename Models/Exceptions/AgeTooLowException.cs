using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace LAB03ISHCHENKO.Models.Exceptions
{
    internal class AgeTooLowException : Exception
    {
        public AgeTooLowException(string message) : base(message)
        {
            MessageBox.Show("Та ти точно не такий старий, давай пиши справжній");
        }


    }
}
