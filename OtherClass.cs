using System;

public class OtherClass
{
    public static decimal Run()
    {
        // using static System.Runtime.InteropServices.JavaScript.JSType;
        // 완벽하게 작동하는 Financial_공학용_계산기의_모태_2025.6.20(금)_Made_By_Nam_Seok_With_The_Help_Of_ChatGPT4o.


        Console.WriteLine(" ==== OtherClass의 Run() 메서드 실행됨! ==== ");
        Console.WriteLine($"완벽하게 작동하는 Financial_공학용_계산기의_모태_2025.6.20(금)_Made_By_Nam_Seok_With_The_Help_Of_ChatGPT4o.");

        Console.WriteLine("1. 곱하기원하는 숫자를 최대 28자리 내에서, 입력하세요: ");

        string input;

        while (true)
        {
            //Console.Write("숫자를 입력하세요 (소수점 포함 최대 28자리): ");
            input = Console.ReadLine();

            // 공백 제거하고 null/빈 문자열 방지
            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("❌ 입력이 비어 있습니다. 다시 입력하세요.\n");
                continue;
            }

            // 소수점 포함 전체 자릿수 검사
            string cleanInput = input.Trim();
            int totalLength = cleanInput.Replace("-", "").Length;  // 음수 부호 제외

            if (totalLength > 28)
            {
                Console.WriteLine("❌ 28자 이내로 입력하세요.\n");
                continue;
            }

            // 숫자 유효성 검사
            if (!decimal.TryParse(cleanInput, out decimal number))
            {
                Console.WriteLine("❌ 올바른 숫자가 아닙니다. 다시 입력하세요.\n");
                continue;
            }

            Console.WriteLine($"✅ 입력된 숫자: {number}");

            Console.WriteLine("---------------------");

            decimal num1 = number;

            Console.WriteLine("1. 곱하기원하는 숫자를 최대 28자리 내에서, 입력하세요: ");


            string input2;

            //while (true)
            //{
            //Console.Write("숫자를 입력하세요 (소수점 포함 최대 28자리): ");
            input2 = Console.ReadLine();

            // 공백 제거하고 null/빈 문자열 방지
            if (string.IsNullOrWhiteSpace(input2))
            {
                Console.WriteLine("❌ 입력이 비어 있습니다. 다시 입력하세요.\n");
                continue;
            }

            // 소수점 포함 전체 자릿수 검사
            string cleanInput2 = input2.Trim();
            int totalLength2 = cleanInput2.Replace("-", "").Length;  // 음수 부호 제외

            if (totalLength2 > 28)
            {
                Console.WriteLine("❌ 28자 이내로 입력하세요.\n");
                continue;
            }

            // 숫자 유효성 검사
            if (!decimal.TryParse(cleanInput2, out decimal number2))
            {
                Console.WriteLine("❌ 올바른 숫자가 아닙니다. 다시 입력하세요.\n");
                continue;
            }

            Console.WriteLine($"✅ 입력된 숫자: {number2}");

            decimal num2 = number2;

            Console.WriteLine("---------------------");


            decimal roundDecimalNum01 = Math.Round(num1, 14);
            decimal roundDecimalNum02 = Math.Round(num2, 14);

            decimal product = roundDecimalNum01 * roundDecimalNum02;
            decimal roundedResult = Math.Round(product, 28);

            Console.WriteLine($"\n곱하고 싶은 숫자는 {roundDecimalNum01} 와 {roundDecimalNum02} 이고,");
            Console.WriteLine($"곱한 결과는 {roundedResult} 입니다.");
            Console.WriteLine("---------------------");
            Console.ReadKey();

            return number;

            Console.WriteLine(" ==== OtherClass의 Run() 메서드 실행됨! ==== ");
            Console.WriteLine("완벽하게 작동하는 Financial_공학용_계산기의_모태_2025.6.20(금)_Made_By_Nam_Seok_With_The_Help_Of_ChatGPT4o.");


            // 완벽하게 작동하는 Financial_공학용_계산기의_모태_2025.6.20(금)_Made_By_Nam_Seok_With_The_Help_Of_ChatGPT4o.

            // break;

        }
    }
}

