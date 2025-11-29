using System;

namespace RomanNumerals
{
    class Program
    {
        static void Main(string[] args)
        {
            // Khởi tạo đối tượng xử lý
            RomanConverter converter = new RomanConverter();

            // Danh sách các trường hợp test
            string[] testCases = { "III", "IV", "IX", "LVIII", "MCMXCIV", "ABC" };

            Console.WriteLine("--- KET QUA TEST ROMAN NUMERALS ---\n");

            foreach (var input in testCases)
            {
                try
                {
                    int result = converter.Convert(input);
                    // In kết quả căn chỉnh cột cho đẹp
                    Console.WriteLine($"Input: {input,-10} => Output: {result}");
                }
                catch (Exception ex)
                {
                    // In lỗi nếu có (ví dụ nhập sai ký tự)
                    Console.WriteLine($"Input: {input,-10} => Lỗi: {ex.Message}");
                }
            }

            Console.WriteLine("\nDone. Press any key to exit.");
            Console.ReadKey();
        }
    }
}