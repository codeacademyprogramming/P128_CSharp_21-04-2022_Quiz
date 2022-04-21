using System;
using System.Collections.Generic;
using System.Text;

namespace P128HomeWork.Models
{
    class Student
    {
        private string _fullname;
        public string FullName 
        {
            get => _fullname;
            set
            {
                while (!CheckFullname(value))
                {
                    Console.WriteLine("Duzgun Ad Soyad Daxil Et");
                    value = Console.ReadLine();
                }
                _fullname = value;
            }
        }

        private string _groupNo;
        public string GroupNo 
        {
            get => _groupNo;
            set
            {
                while (!CheckGroupNo(value))
                {
                    Console.WriteLine("Duzgun Daxil Et Qrup Nomresi");
                    value = Console.ReadLine();
                }
                _groupNo = value;
            }
        }

        public byte Age { get; set; }

        public Student(string fullName, string groupNo, byte age)
        {
            FullName = fullName;
            GroupNo = groupNo;
            Age = age;
        }

        public static bool CheckGroupNo(string groupNo)
        {
            if (groupNo.Length == 4 && char.IsUpper(groupNo[0]) && int.TryParse(groupNo.Substring(1), out int no))
                return true;
            return false;

            //if (groupNo.Length == 4)
            //{
            //    if (char.IsUpper(groupNo[0]))
            //    {
            //        int count = 0;

            //        for (int i = 1; i < groupNo.Length; i++)
            //        {
            //            if (char.IsDigit(groupNo[i]))
            //            {
            //                count++;
            //            }
            //        }
            //        if (count == 3)
            //        {
            //            return true;
            //        }
            //        else
            //        {
            //            return false;
            //        }
            //    }
            //    return false;
            //}
            //return false;
        }

        public static bool CheckFullname(string fullName)
        {
            return fullName.Split(' ').Length >= 2;

            //string[] words = fullName.Split(' ');

            //if (words.Length > 2)
            //{
            //    return true;
            //}
            //return false;
        }

        public override string ToString()
        {
            return $"Ad Soyad: {_fullname} Qrup Nomresi: {_groupNo} Yas: {Age}";
        }
    }
}
