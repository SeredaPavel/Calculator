using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    public interface InterfaceCalculator
    {
        void Put_A(double a);

        void Clear_A();

        double Multiplication(double b);

        double Divicion(double b);

        double Sum(double b);

        double Subtraction(double b);

        double SqrtX(double b);

        double DegreeY(double b);

        double Sqrt();

        double Square();

        double MemoryShow();

        void Memory_Clear();

        void M_Multiplication(double b);

        void M_Division(double b);

        void M_Sun(double b);

        void M_Substraction(double b);
    }
}