using System;
using System.Collections.Generic;

namespace RomanNumerals
{
    public class RomanConverter
    {
        // Bảng tra cứu giá trị
        private static readonly Dictionary<char, int> RomanMap = new Dictionary<char, int>
        {
            {'I', 1}, {'V', 5}, {'X', 10}, {'L', 50},
            {'C', 100}, {'D', 500}, {'M', 1000}
        };

        public int Convert(string s)
        {
            if (string.IsNullOrEmpty(s)) return 0;

            s = s.ToUpper(); // Chuyển thành chữ hoa
            int total = 0;
            int length = s.Length;

            for (int i = 0; i < length; i++)
            {
                // Kiểm tra ký tự hợp lệ
                if (!RomanMap.ContainsKey(s[i]))
                {
                    throw new ArgumentException($"Ký tự không hợp lệ: {s[i]}");
                }

                int currentVal = RomanMap[s[i]];

                // Logic chính: Nếu số hiện tại nhỏ hơn số kế tiếp -> Phép Trừ
                if (i < length - 1 && currentVal < RomanMap[s[i + 1]])
                {
                    total -= currentVal;
                }
                else
                {
                    total += currentVal;
                }
            }
            return total;
        }
    }
}