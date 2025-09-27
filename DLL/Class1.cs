using System;
using System.Collections.Generic;
using System.Text;

namespace DLL
{
    public class Class1
    {
        public string PlainText { get; set; }
        public string CipherText { get; set; }
        public string DecryptedText { get; private set; }

        // Encrypt: xoay từng block 3x3 theo chiều kim đồng hồ
        public void Encrypt()
        {
            if (string.IsNullOrEmpty(PlainText))
                throw new ArgumentException("PlainText cannot be empty!");

            StringBuilder result = new StringBuilder();

            for (int i = 0; i < PlainText.Length; i += 9)
            {
                string block = GetBlock(PlainText, i, 9);
                char[,] matrix = ToMatrix(block);
                char[,] rotated = RotateClockwise(matrix);
                result.Append(MatrixToString(rotated));
            }

            CipherText = result.ToString();
        }

        // Decrypt: xoay từng block 3x3 ngược chiều kim đồng hồ
        public void Decrypt()
        {
            if (string.IsNullOrEmpty(CipherText))
                throw new ArgumentException("CipherText cannot be empty!");

            StringBuilder result = new StringBuilder();

            for (int i = 0; i < CipherText.Length; i += 9)
            {
                string block = GetBlock(CipherText, i, 9);
                char[,] matrix = ToMatrix(block);
                char[,] rotated = RotateCounterClockwise(matrix);
                result.Append(MatrixToString(rotated));
            }

            DecryptedText = result.ToString().TrimEnd('_'); // bỏ padding
        }

        // Helper: cắt block
        private string GetBlock(string text, int start, int size)
        {
            string block = "";
            for (int i = start; i < start + size; i++)
            {
                if (i < text.Length) block += text[i];
                else block += "_"; // padding nếu thiếu ký tự
            }
            return block;
        }

        // Convert block (9 ký tự) thành ma trận 3x3
        private char[,] ToMatrix(string block)
        {
            char[,] matrix = new char[3, 3];
            int idx = 0;
            for (int r = 0; r < 3; r++)
                for (int c = 0; c < 3; c++)
                    matrix[r, c] = block[idx++];
            return matrix;
        }

        // Convert ma trận 3x3 về chuỗi
        private string MatrixToString(char[,] matrix)
        {
            StringBuilder sb = new StringBuilder();
            for (int r = 0; r < 3; r++)
                for (int c = 0; c < 3; c++)
                    sb.Append(matrix[r, c]);
            return sb.ToString();
        }

        // Xoay ma trận theo chiều kim đồng hồ
        private char[,] RotateClockwise(char[,] matrix)
        {
            char[,] rotated = new char[3, 3];
            for (int r = 0; r < 3; r++)
                for (int c = 0; c < 3; c++)
                    rotated[c, 2 - r] = matrix[r, c];
            return rotated;
        }

        // Xoay ma trận ngược chiều kim đồng hồ
        private char[,] RotateCounterClockwise(char[,] matrix)
        {
            char[,] rotated = new char[3, 3];
            for (int r = 0; r < 3; r++)
                for (int c = 0; c < 3; c++)
                    rotated[2 - c, r] = matrix[r, c];
            return rotated;
        }
    }
}
