namespace _537_ComplexNumberMultiplication
{
    internal class Solution
    {
        private class ComplexNumber
        {
            public int Real { get; set; }
            public int Complex { get; set; }

            public ComplexNumber(int real, int complex)
            {
                Real = real;
                Complex = complex;
            }

            public static ComplexNumber operator *(ComplexNumber a, ComplexNumber b)
            {
                int real = a.Real * b.Real - a.Complex * b.Complex;
                int complex = a.Real * b.Complex + a.Complex * b.Real;

                return new ComplexNumber(real, complex);
            }

            public override string ToString()
            {
                return $"{Real}+{Complex}i";
            }
        }


        public string ComplexNumberMultiply(string a, string b)
        {
            var c1 = ReadComplexNumber(a);
            var c2 = ReadComplexNumber(b);

            return (c1 * c2).ToString();
        }

        private ComplexNumber ReadComplexNumber(string s)
        {
            int indexPlus = s.IndexOf('+');

            return new ComplexNumber(
                int.Parse(s.Substring(0, indexPlus)),
                int.Parse(s.Substring(indexPlus + 1, s.Length - indexPlus - 2)));
        }
    }
}
