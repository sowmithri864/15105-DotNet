using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Type_Collection_demo
{
    class CollectionDemo
    {
        static void Main(string[] args)
        {
            //Array
            //datatype[] name = new datatype[size];




            //int[] numberArray = new int[3];
            //numberArray[0] = 454;
            //numberArray[1] = 44754;
            //numberArray[2] = 23;

            //for(int i=0;i<numberArray.Length;i++)
            //{
            //Console.WriteLine(numberArray[i]);
            //}

            //#region System.Collections classes

            //ArrayList countyList = new ArrayList();
            //countyList.Add("India");         //0
            //countyList.Add("USA");           //2
            //countyList.Insert(1, "France");  //1

            //countyList.Add(100);   //int - 3
            //countyList.Add(true);  //bool - 4

            ////object initializer { }
            //Person person = new Person() { FirstName = "sowmithri", LastName = "chirala" };

            //Console.WriteLine(person.FirstName + " " + person.LastName);

            //Console.WriteLine("-------------------------------\n");

            //countyList.Add(person);  //5

            ////from countryList collection for item no 5 (person object) print only FirstName

            ////Type conversion

            //Console.WriteLine(((Person)countyList[5]).FirstName);

            //Console.WriteLine("------------------------\n");

            //for(int i=0;i<countyList.Count;i++)
            //{
            //    Console.WriteLine(countyList[i]);
            //}

            //#endregion

            //#region Genric Collection classes

            //List<string> countryList = new List<string>();
            //countryList.Add("India");
            //countryList.Add(100);

            //List<int> numbers = new List<int>();
            //numbers.Add(100);

            //List<Person> personList = new List<Person>();
            //personList.Add(new Person() { FirstName = "sowmithri", LastName = "chirala" });

            //Console.WriteLine(personList[0].FirstName);

            //#endregion

            #region Nullable Type
            //int i=null;

            Nullable<int> x = null;
            x = 100;
            x = null;


            //datatype?           ----numable type
            int? y = null;

            #endregion


        }
    }
}
