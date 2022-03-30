using System;
using System.Collections.Generic;
using System.Text;

namespace Task
{
    class Student
    {
        private int id;
        private string ad;
        private string soyad;
        private string ixtisas;

        public int ID
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
        public string AD { get
            {
                return ad;
            }
            set
            {
                ad = value;
            }
        }
        public string Soyad { get
            {
                return soyad;
            }
            set
            {
                soyad = value;
            }
        }
        public string Ixtisas { get
            {
                return ixtisas;
            }
            set
            {
                ixtisas = value;
            }

        }
        public void Info()
        {
            Console.WriteLine($"{id}, {ad}, {soyad} {ixtisas}");
        }
        public Student(int id,string ad, string soyad,string ixtisas)
        {
            this.id = id;
            this.ad = ad;
            this.soyad = soyad;
            this.ixtisas = ixtisas;
        } 
    }
    
}
