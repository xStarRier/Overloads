
using System.Reflection.Emit;

namespace ShowPlaces
{
    class Program
    {

        static void Main(string[] args)
        {
            ShowSeperateRow();
            var labelWidth = 20;
            ShowFieldNameAndValue("Navn", labelWidth, "Stavern");
            ShowFieldNameAndValue("Kommune", labelWidth, "Larvik");
            ShowFieldNameAndValue("Fylke", labelWidth, "Vestfold");
            ShowSeperateRow();



        }

        static void ShowFieldNameAndValue(string label, int labelWidth, string fieldValue)
        {
            labelWidth -= label.Length;
            Console.WriteLine("  " + label + ":" + string.Empty.PadLeft(labelWidth, ' ') + fieldValue);


        }

        static void ShowSeperateRow()
        {
            Console.WriteLine("------------------");
          

        }



    }


}
