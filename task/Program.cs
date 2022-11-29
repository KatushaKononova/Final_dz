using System;

namespace task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Введите слова (через пробел)");
            string str=Console.ReadLine();
            string[] str_arr=str.Split(' ');
            int size = str_arr.Length;
            FindWords(str_arr, size);
        }

        static void FindWords(string[] string_words, int length){
            int kolvo = 0;
            for(int i=0;i<length;i++){
                if(string_words[i].Length<=3){
                    kolvo++;
                }
            } 
            if(kolvo==0){
                Console.WriteLine("Таких слов нет");
                return;
            }
            else{
                for(int i=0;i<length;i++){
                    if(string_words[i].Length<=3){
                        Console.WriteLine(string_words[i]);
                    }
                } 
            }
            
        }
    }
}
