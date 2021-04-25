using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace generator
{
    public class CharGenerator 
    {
        private string syms = "абвгдеёжзийклмнопрстуфхцчшщьыъэюя"; 
        private int[,] data;
        private int size;
        private Random random = new Random();
		private int summ;
		
		public CharGenerator(string file, string file_2 int num_l, int num_w)
		{
			data = int[num_l, num_l];
			using (StreamReader r = new StreamReader(file))
			{
				for (int i = 0; i < num_l; i++)
				{
					string L = r.ReadLine();
                    string[] W = line.Split(new Char[] { ' ' });
					for (int j = 0; j < num_l; j++)
					{
						arr[i, j] = Int32.Parse(W[j]);
					}
				}
			}
			for (int i =0; i< num_l; i++)
			{
				for (int j =0; j <num_l; j++)
				{
					summ += arr[i, j];
				}
			}
			using (StreamWriter w = new StreamWriter(file_2)
			{
				for (int i = 0; i < num_w; i++)
				{
					bool flag = false;
					int random_num = random.Next(0, summ);
					int current_summ = 0;
					for (int j = 0; j<num_l; j++)
					{
						for (int k = 0; k < num_l; k++)
						{
							if (data[j,k] != 0)
							{
								current_summ+= data[j,k];
								if (current_summ>= random_num)
								{
									w.Write(syms[j]);
									w.Write(syms[k]);
									flag = true;
								}
							}
							if (flag)
								break;
						}
						if (flag)
							break;
					}
				}
			}
		}
		
		
		
		
       
    }
	public class WordsGenerator 
    {
		private string[] words;
		private string[] nums;
		private int summ;
		public WordsGenerator(string file, string file_2, int num_w, int num_l)
		{
			words = int[num_l];
			nums = int[num_l];
			summ = 0;
			using (StreamReader r = new StreamReader(file))
			{
				for (int i = 0; i < num_l; i++)
				{
					string L = r.ReadLine();
                    string[] W = line.Split(new Char[] { ' ' });
					words[i] = W[1];
					float temp = Int32.Parse(W[3])/Int32.Parse(W[2]);
					nums[i] = temp;
					summ+= nums[i];
				}
			}
			int summ_arr = int[summ];
			for (int i = 0; i < num_l; i++)
			{
				for (int j = 0; j < nums[i]; j++)
				{
					summ_arr = i;
				}
			}
			using (StreamWriter w = new StreamWriter(file_2)
			{
				for (int i = 0; i < num_w; i++)
				{
					int random_num = random.Next(0, summ);
					w.Write(words[nums[summ_arr[random_num]]]);
				}
			}
		}
	}
	public class WordsGenerator_1 
    {
		private string[] words_1;
		private string[] words_2;
		private string[] nums;
		private int summ;
		public WordsGenerator_1(string file, string file_2, int num_w, int num_l)
		{
			words = int[num_l];
			nums = int[num_l];
			summ = 0;
			using (StreamReader r = new StreamReader(file))
			{
				for (int i = 0; i < num_l; i++)
				{
					string L = r.ReadLine();
                    string[] W = line.Split(new Char[] { ' ' });
					words_1[i] = W[1];
					words_2[i] = W[2];
					float temp = Int32.Parse(W[4])/Int32.Parse(W[3]);
					nums[i] = temp;
					summ+= nums[i];
				}
			}
			int summ_arr = int[summ];
			for (int i = 0; i < num_l; i++)
			{
				for (int j = 0; j < nums[i]; j++)
				{
					summ_arr = i;
				}
			}
			using (StreamWriter w = new StreamWriter(file_2)
			{
				for (int i = 0; i < num_w; i++)
				{
					int random_num = random.Next(0, summ);
					w.Write(words_1[nums[summ_arr[random_num]]]);
					w.Write(words_2[nums[summ_arr[random_num]]]);
				}
			}
		}
	}
    class Program
    {
        static void Main(string[] args)
        {
			CharGenerator ch = new CharGenerator("table_1", "test1", 31, 1000);
			WordsGenerator W_1 = new WordsGenerator("dictionary_1.txt", "test2", 1000, 100);
			WordsGenerator_1 W_2 = new WordsGenerator_1("dictionary_2.txt", "test3", 1000, 100);
	}
    }
}
