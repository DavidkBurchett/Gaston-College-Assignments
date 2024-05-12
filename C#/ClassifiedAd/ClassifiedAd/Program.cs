using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassifiedAd
{
    public class TestClassifiedAd
    {
        public static void Main()
        {
            ClassifiedAd carAd = new ClassifiedAd();
            ClassifiedAd helpWantedAd = new ClassifiedAd();

            carAd.setCategory("Used Cars");
            carAd.setWords(100);

            helpWantedAd.setCategory("Help Wanted");
            helpWantedAd.setWords(60);

            WriteLine("The classified ad with {0} words in category {1} costs ${2}.00", carAd.getWords(), carAd.getCategory(), carAd.getPrice());
            WriteLine("The classified ad with {0} words in category {1} costs ${2}0", helpWantedAd.getWords(), helpWantedAd.getCategory(), helpWantedAd.getPrice());
        }
    }
    class ClassifiedAd
    {
        public String Category;
        public int Words;
        public double Price;
        
        public String getCategory()
        {
            return this.Category;
        }

        public void setCategory(String newCategory)
        {
            this.Category = newCategory;
        }
        public int getWords()
        {
            return this.Words;
        }

        public void setWords(int newWordCount)
        {
            this.Words = newWordCount;
            this.Price = newWordCount * .09;
        }
        public double getPrice()
        {
            return this.Price;
        }
    }
}
