using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_3._1._1 {
    class Complex : IFormattable {

        public double Real { get; set; }
        public double Imaginary { get; set; }

        public Complex(double real = 0, double imaginary = 0) {
            Real = real;
            Imaginary = imaginary;
        }

        public static Complex operator +(Complex a, Complex b) {
            Complex result = new Complex();
            result.Real = a.Real + b.Real;
            result.Imaginary = a.Imaginary + b.Imaginary;
            return result;
        }

        public static Complex operator -(Complex a, Complex b) {
            Complex result = new Complex();
            result.Real = a.Real - b.Real;
            result.Imaginary = a.Imaginary - b.Imaginary;
            return result;
        }

        public static Complex operator *(Complex a, Complex b) {
            Complex result = new Complex();
            result.Real = a.Real * b.Real - a.Imaginary * b.Imaginary;
            result.Imaginary = a.Real * b.Imaginary + a.Imaginary * b.Real;
            return result;
        }

        public static Complex operator /(Complex a, Complex b) {
            Complex result = new Complex();
            double divisor = b.Real * b.Real - b.Imaginary * b.Imaginary;
            result.Real = a.Real * b.Real + a.Imaginary * b.Imaginary;
            result.Real /= divisor;
            result.Imaginary = a.Real * b.Imaginary - a.Imaginary * b.Real;
            result.Imaginary /= divisor;
            return result;
        }

        public string ToString(string format, IFormatProvider formatProvider) {
            switch (format) {
                case "w":
                    return $"[{Real},{Imaginary}]";
                case "d":
                default:
                    return $"{Real}+{Imaginary}i";
            }
        }
    }
}
