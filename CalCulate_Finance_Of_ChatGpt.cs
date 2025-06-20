using System;
using System.Text;

public static class Calculate_Finance
{
    // static decimal globalDecimalValue = 0;

    public static void Run()
    {
        Console.WriteLine("=============== 공학용 / 금융 계산기 ===============");

        decimal num1 = ReadDecimalFromConsole("1. 곱셈 숫자 입력 (정수부 14자리 + 소수부 14자리 이내): ");
        decimal num2 = ReadDecimalFromConsole("2. 곱셈 숫자 입력 (정수부 14자리 + 소수부 14자리 이내): ");

        decimal roundDecimalNum01 = Math.Round(num1, 14);
        decimal roundDecimalNum02 = Math.Round(num2, 14);

        decimal product = roundDecimalNum01 * roundDecimalNum02;
        decimal roundedResult = Math.Round(product, 28);

        Console.WriteLine($"\n곱하고 싶은 숫자는 {roundDecimalNum01} 와 {roundDecimalNum02} 이고,");
        Console.WriteLine($"곱한 결과는 {roundedResult} 입니다.");
        Console.WriteLine("======================================================");
        Console.ReadKey();
    }

    static decimal ReadDecimalFromConsole(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            string input = Console.ReadLine();

            if (decimal.TryParse(input, out decimal result))
            {
                string[] parts = input.Split('.');
                int intDigits = parts[0].TrimStart('-').Length;
                int fracDigits = parts.Length > 1 ? parts[1].Length : 0;

                if (intDigits > 14 || fracDigits > 14)
                {
                    Console.WriteLine("❌ 정수부와 소수부 각각 최대 14자리까지만 입력 가능합니다. 다시 입력하세요.\n");
                    continue;
                }
                return result;
            }
            else
            {
                Console.WriteLine("❌ 숫자를 올바르게 입력하세요. 예: 12345678901234.12345678901234\n");
            }
        }
    }
}
