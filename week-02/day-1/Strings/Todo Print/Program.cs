using System;
using System.Text;

namespace Todo_Print
{
    class Program
    {
        static void Main(string[] args)
        {
            string todoText = " - Buy milk\n";
            // Add "My todo:" to the beginning of the todoText
            // Add " - Download games" to the end of the todoText
            // Add " - Diablo" to the end of the todoText applying indentation

            // Expected output:

            // My todo:
            //  - Buy milk
            //  - Download games
            //      - Diablo

            StringBuilder sb = new StringBuilder(todoText);
            sb.Insert(0, "My todo:\n");
            sb.Insert(sb.Length, " - Download games\n");
            sb.Insert(sb.Length, "        - Diablo\n");

            Console.Write(sb);
        }
    }
}
