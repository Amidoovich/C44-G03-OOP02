using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace S2
{
    internal struct PhoneNoteBook
    {
        #region Attributes

        private string[]? Names;

        private int[]? Numbers;

        //private int size;

        public int Size { get; set; }

        #endregion

        #region consturctors

        public PhoneNoteBook(int size)
        {
            Names = new string[size];
            Numbers = new int[size];
            Size = size;
        }




        #endregion

        #region Methods

        public void AddPerson(int Position , string name , int number)
        {
            if (Names is not null && Numbers is not null)
            {
                if (Position < Size && Position >= 0)
                {
                    Names[Position] = name;
                    Numbers[Position] = number;
                }

            }
        }

        #endregion

        #region Getter And Setter

        public int GetNumber (string name)
        {
            if(Names is not null && Numbers is not null)
            {
                if(name is not null)
                {
                    for(int i = 0;i<Names.Length;i++)
                    {
                        if (Names[i] == name)
                        {
                            return Numbers[i]; 
                        }
                    }
                }
            }
            return -1;
        }

        public void SetNumber(string name,int newNumber)
        {
            if (Names is not null && Numbers is not null)
                if (name is not null)
                    for (int i = 0; i < Names.Length; i++)
                        if (Names[i] == name)
                        {
                            Numbers[i] = newNumber;
                            //break
                            return;
                        }

        }

        #endregion

        #region Indexer

        //public int Size
        //{
        //    get { return size; }
        //    set { size = value; }
        //}


        public int this[string name]
        {
            get 
            {
                if (Names is not null && Numbers is not null)
                    if (name is not null)
                        for (int i = 0; i < Names.Length; i++)
                            if (Names[i] == name)
                                return Numbers[i];
                return -1;

            }
            set
            {
                if (Names is not null && Numbers is not null)
                    if (name is not null)
                        for (int i = 0; i < Names.Length; i++)
                            if (Names[i] == name)
                            {
                                Numbers[i] = value;
                                //break
                                return;
                            }
            }
        }

        public string this[int index]
        {
            get
            {
                return $"Index : {index} , Name : {Names[index]} , Number : {Numbers[index]}";
            }
        }


        #endregion
    }
}
