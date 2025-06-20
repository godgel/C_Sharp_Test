



using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Program의 Main() 시작");
        Console.WriteLine(" ======== Program의 Main() =========== ");

        // ✅ 다른 클래스의 메서드 호출
        OtherClass.Run();

        Console.WriteLine("Program의 Main() 끝");
        Console.WriteLine(" ======== Program의 Main() =========== ");

        Console.ReadKey();

    }
}
















//// See https://aka.ms/new-console-template for more information
////using System;

////Console.WriteLine("Hello, World!");

////Console.WriteLine("Enter Somthing :");

////string your_Input  = Console.ReadLine();

////Console.WriteLine("You Entered " +  your_Input);

////Console.ReadKey();
////// Key가 입력 될때까지, 프로그램이 종료되지 않고 기다린다. ( 입력 받기를... )

//// Program.cs

//using System;

////Console.WriteLine("당신의 숫자를 입력 하시요...!!! : ");

////string strNum = Console.ReadLine();

////int intNum = Convert.ToInt32(strNum);
////Console.WriteLine($"당신이 입력한 숫자는 {intNum} 입니다.");
////Console.WriteLine("당신의 숫자는 : " + intNum + " 입니데이, 두번째 출력.");

////Console.WriteLine($"strNum {strNum+2}, + 기호는 문자는 그냥 붙이기 실행함");
////Console.WriteLine($"intNum {intNum+2}, + 기호는 숫자는 진짜로 더하기 연산함");


////Console.WriteLine("C# 에서는 파이선 처럼, 문자형 숫자를 바로 곱하기 못하고, int 로 변경후 가능함");

//// Console.ReadKey();


//// Console.WriteLine(" ============================================= ");

////Console.WriteLine("곱하고 싶은 첫번째 숫자를 입력 하시요 : ");
////string strNum01 = Console.ReadLine();
////int intNum01 = int.Parse(strNum01);

////Console.WriteLine("곱하고 싶은 두번째 숫자를 입력 하시요 : ");
////string strNum02 = Console.ReadLine();
////int intNum02 = int.Parse(strNum02);

////int sumNums = intNum01 * intNum02;

//////console.writeline("당신이 곱하고 싶은 숫자는 " + intnum01 + " 과 " + intnum02 + " 이고 " + " 곱한수는 " + sumnums + " 입니다. ");

////Console.WriteLine($"당신이 곱하고 싶은 숫자는 {intNum01} 과 {intNum02} 이고, 곱한수는 {sumNums} 입니다. ");

////Console.ReadKey();


//Console.WriteLine(" ==================================== ");
//// Console.Write("1. 곱셈숫자 입력하세요, 최대 28자(천경단위) ");

//public static class Calculate_Finance
//{
//    static int globalVar = 0;

//    string maxDigits = Console.ReadLine();
//    int maxDigits = int.Parse(maxDigits);

//    int ReadIntFromConsole( maxDigits = 28)
//    {
//        string input = "";
//        // int input = int.Parse(input);

//        // input = maxDigits;

//        while (true)
//        {
//            var key = Console.ReadKey(intercept: true);

//            if (key.Key == ConsoleKey.Enter)
//            {
//                Console.WriteLine();
//                break;
//            }

//            if (key.Key == ConsoleKey.Backspace && input.Length > 0)
//            {
//                input = input.Substring(0, input.Length - 1);
//                Console.Write("\b \b");
//                continue;
//            }

//            if (char.IsDigit(key.KeyChar) && input.Length < maxDigits)
//            {
//                input += key.KeyChar;
//                Console.Write(key.KeyChar);
//            }
//        }

//        return int.Parse(input);  // 입력이 숫자만 들어왔기 때문에 안전
//    }



//    Console.WriteLine(" ================================== ");

////string input = "123456";
//int intValue = input;
//    decimal decimalValue = (decimal)intValue;  // int → decimal
//    Console.WriteLine(decimalValue);  // 출력: 123456

//Console.WriteLine(" ================================== ");
//// 사용 예
////Console.Write("숫자를 입력하세요 (최대 10자리): ");
////int number = ReadIntFromConsole();
////Console.WriteLine($"입력된 숫자: {number}");


////Console.Write("곱셈숫자 입력하세요, 최대 28자(천경단위) ");
////double number1 = double.Parse(input);  // 예외 발생 가능
////Console.WriteLine($"\n입력된 number1의 값: {number1}");
////double dblNum01 = number1;

////Console.Write("2. 곱셈숫자 입력하세요, 최대 28자(천경단위) ");
////string input2 = Console.ReadLine();
////double number2 = double.Parse(input2);  // 예외 발생 가능
////Console.WriteLine($"\n입력된 number2의 값: {number2}");
////double dblNum02 = number2;

//int ReadIntFromConsole(int maxDigits2 = 28)
//    {
//        string input2 = "";

//        while (true)
//        {
//            var key = Console.ReadKey(intercept: true);

//            if (key.Key == ConsoleKey.Enter)
//            {
//                Console.WriteLine();
//                break;
//            }

//            if (key.Key == ConsoleKey.Backspace && input2.Length > 0)
//            {
//                input2 = input2.Substring(0, input2.Length - 1);
//                Console.Write("\b \b");
//                continue;
//            }

//            if (char.IsDigit(key.KeyChar) && input2.Length < maxDigits2)
//            {
//                input += key.KeyChar;
//                Console.Write(key.KeyChar);
//            }
//        }

//        return int.Parse(input2);  // 입력이 숫자만 들어왔기 때문에 안전
//    }

//    Console.WriteLine(" ================================== ");

////string input = "123456";
//int intValue2 = input2;
//    decimal decimalValue2 = (decimal)intValue2;  // int → decimal
//    Console.WriteLine(decimalValue2);  // 출력: 123456

//Console.WriteLine(" ================================== ");


//decimal roundDecimalNum01 = Math.Round(decimalValue1, 5);
//    decimal roundDecimalNum02 = Math.Round(decimalValue2, 5);

//    decimal RoundedSumNums = roundDecimalNum01 * roundDecimalNum02;
//    decimal rounded28CutNums = Math.Round(RoundedSumNums, 28);


//    //console.writeline("당신이 곱하고 싶은 숫자는 " + intnum01 + " 과 " + intnum02 + " 이고 " + " 곱한수는 " + sumnums + " 입니다. ");

//    Console.WriteLine($"당신이 곱하고 싶은 숫자는 {roundDecimalNum01:##############.#############} 와 {roundDecimalNum02:##############.#############} 이고, 곱한수는 {rounded28CutNums:###############.###########} 입니다. ");

//        Console.ReadKey();

//        Console.WriteLine(" ==================================== ");
//}




////try
////{
////    decimal a = 12345678901234.56m;
////    decimal b = 98765432101234.56m;
////    decimal result = a * b;
////    Console.WriteLine($"곱셈 결과: {result}");
////}
////catch (OverflowException)
////{
////    Console.WriteLine("❌ 곱셈 결과가 decimal 범위를 초과했습니다!");
////}


////decimal positive = 12345678901234.56789012345678m;  // 정수부 14자리, 소수부 14자리
////decimal negative = -12345678901234.56789012345678m; // 동일한 수의 음수

////Console.WriteLine($"양수: {positive}");
////Console.WriteLine($"음수: {negative}");
////Console.WriteLine(" ==================================== ");

////Console.Write("숫자를 입력하세요: ");
////string input = Console.ReadLine();

////decimal value = decimal.Parse(input);  // 예외 가능성 있음
////Console.WriteLine($"입력된 값: {value}");
////Console.WriteLine(" ==================================== ");
////double a = 0.1;
////double b = 0.2;
////Console.WriteLine(a + b);  // 출력: 0.30000000000000004 ❌

////decimal da = 0.1m;
////decimal db = 0.2m;
////Console.WriteLine(da + db);  // 출력: 0.3 ✅
////Console.WriteLine(" ==================================== ");












