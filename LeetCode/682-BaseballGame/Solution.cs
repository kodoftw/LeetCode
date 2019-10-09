using System;
using System.Collections.Generic;

namespace _682_BaseballGame
{
    internal class Solution
    {
        private enum OpType
        {
            Integer,
            Sum,
            Double,
            Invalid
        }

        public int CalPoints(string[] ops)
        {
            int sum = 0;
            var validValues = new List<int>() { 0, 0 };

            foreach (var op in ops)
            {
                int value;
                var opType = GetOpType(op);

                switch (opType)
                {
                    case OpType.Integer:
                        value = Int32.Parse(op);
                        sum += value;
                        validValues.Add(value);
                        break;

                    case OpType.Sum:
                        value = LastValidValue(validValues) + SecondLastValidValue(validValues);
                        sum += value;
                        validValues.Add(value);
                        break;

                    case OpType.Double:
                        value = 2 * LastValidValue(validValues);
                        sum += value;
                        validValues.Add(value);
                        break;

                    case OpType.Invalid:
                        value = LastValidValue(validValues);
                        sum -= value;
                        RemoveLastValidValue(validValues);
                        break;
                }
            }

            return sum;
        }

        private OpType GetOpType(string op)
        {
            if (op == "+")
                return OpType.Sum;

            if (op == "D")
                return OpType.Double;

            if (op == "C")
                return OpType.Invalid;

            return OpType.Integer;
        }

        private int LastValidValue(List<int> validValues)
        {
            return validValues[validValues.Count - 1];
        }

        private int SecondLastValidValue(List<int> validValues)
        {
            return validValues[validValues.Count - 2];
        }

        private void RemoveLastValidValue(List<int> validValues)
        {
            validValues.RemoveAt(validValues.Count - 1);
        }
    }
}
