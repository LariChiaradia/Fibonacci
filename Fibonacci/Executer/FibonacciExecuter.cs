namespace Fibonacci.Executer
{
    public static class FibonacciExecuter
    {
        public static bool IsFibonacciNumber(int number)
        {
            int num1 = 0, num2 = 1, aux;

            for (int i = 0; i​​​​​​​ <= number; i++)
            {
                aux = num1;
                num1 = num2;
                num2 = num1 + aux;

                if (number == num1 || number == num2 || number == aux)
                    return true;
            }

            return false;
        }
    }
}
