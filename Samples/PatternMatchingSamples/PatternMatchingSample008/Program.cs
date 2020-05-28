using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternMatchingSample008
{
    // C# 8.0
    /// <summary>
    /// recursive pattern
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {

            foreach (var item in GetStudentIsPassedAndMale())
            {
                Console.WriteLine($"學生 {item.name} 的成績是 {item.score}");
            }

            foreach (var item in GetStudentNameLength())
            {
                Console.WriteLine($"學生 {item.name} 的名字長度是是 {item.length}");
            }


            Console.ReadLine();
        }




        static IEnumerable<(string name, int score)> GetStudentIsPassedAndMale()
        {
            var people = Create();
            foreach (var p in people)
            {
               // Student.Name 若為 null 則比對不符合(這是一種 property pattern)
                if (p is Student { Gender: Gender.Male, IsPassed: true, Name: string name, Score: int score })
                {
                    yield return (name, score);
                }

                // 另外一種
                //if (p is Student { Gender: Gender.Male, IsPassed: true, Name: { } name, Score: int score })
                //{
                //    yield return (name, score);
                //}

                // 用 var 的話 Name 即使是 null 也會算比對成功
                //if (p is Student { Gender: Gender.Male, IsPassed: true, Name: var name, Score: int score })
                //{
                //    yield return (name, score);
                //}
            }
        }


        /// <summary>
        /// 取得 Name 的 Length 屬性值並指派給 length 變數
        /// </summary>
        /// <returns></returns>
        static IEnumerable<(string name, int length)> GetStudentNameLength()
        {
            var people = Create();
            foreach (var p in people)
            {

                if (p is Student { Gender: Gender.Male, IsPassed: true, Name: { Length: {  }  length} name, } && length > 0)
                {
                    yield return (name, length);
                }
            }
        }


        //沒有 recursive pattern 的話
        //static IEnumerable<(string name, int score)> GetStudentIsPassedAndMale()
        //{
        //    var people = Create();

        //    return people.Where((x) => x is Student student
        //                        && student.IsPassed == true
        //                        && student.Gender == Gender.Male
        //                        && student.Name != null).Select((y) =>
        //                        {
        //                            Student s = y as Student;
        //                            return (s.Name, s.Score);
        //                        });
        //}


        /// <summary>
        /// 注意有個學生的 Name 是 null
        /// </summary>
        /// <returns></returns>
        static List<IPerson> Create()
        {
            return new List<IPerson>
                   {
                       new Teacher {Name= "Bill" },
                       new Teacher {Name= "David"},
                       new Student{ Name = "魯夫",  Gender = Gender.Male , Score= 60},
                       new Student{ Name = "妮可羅賓",  Gender = Gender.Female , Score= 82},
                       new Student{ Name = "娜美",   Gender = Gender.Female, Score= 70 },
                       new Student{ Name = "騙人布" ,Gender = Gender.Male, Score= 55 },
                       new Student{ Name = "香吉士",  Gender = Gender.Male, Score= 58 },
                       new Student{ Name = "喬巴",   Gender = Gender.Male, Score= 67 },
                       new Student{ Name = "布魯克",  Gender = Gender.Male, Score= 42 },
                       new Student{ Name = "索隆",  Gender = Gender.Male, Score= 80 },
                       new Student{ Gender = Gender.Male , Score= 60},
                       new Student{ Name = string.Empty,  Gender = Gender.Male , Score= 99},
                   };
        }

    }

    interface IPerson
    {
        Guid ID { get; set; }
        string Name { get; set; }
    }

    class Teacher : IPerson
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string Subject { get; set; }
    }

    class Student : IPerson
    {
        public Guid ID { get; set; }
        public string Name { get; set; }

        public bool IsPassed
        {
            get { return Score > 59; }
        }

        public Gender Gender { get; set; }

        public int Score { get; set; }
    }

    public enum Gender
    {
        Male, Female
    }
}
