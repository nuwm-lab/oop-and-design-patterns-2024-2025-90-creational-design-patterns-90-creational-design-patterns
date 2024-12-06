using System;
using System.Collections.Generic;

namespace LabWork
{
    // Даний проект є шаблоном для виконання лабораторних робіт
    // з курсу "Об'єктно-орієнтоване програмування та патерни проектування"
    // Необхідно змінювати і дописувати код лише в цьому проекті
    // Відео-інструкції щодо роботи з github можна переглянути 
    // за посиланням https://www.youtube.com/@ViktorZhukovskyy/videos 

    public enum Complexity { Easy, Middle, Hard };
    public class Curriculum
    {
        public List<string> Subjects { get; set; }
        public int Duration { get; set; }
        public Complexity Complexity { get; set; }

        public Curriculum()
        {
            Subjects = new List<string>();
        }
        public void GetInformation()
        {
            
            Console.Write("Subjects : ");
            int xPos = Console.GetCursorPosition().Left;
            foreach (string s in Subjects)
            {
                Console.CursorLeft = xPos;
                Console.WriteLine(s);
            }
            Console.WriteLine($"Duration : {Duration} hours");
            Console.WriteLine($"Complexity : {Complexity}");
        }
    }

    public class Builder
    {
        private Curriculum Curriculum;

        public Builder()
        {
            Curriculum = new Curriculum();
        }

        public Builder SetSubjects(string subject)
        {
            this.Curriculum.Subjects.Add(subject);
            return this;
        }

        public Builder SetDurationOfCurriculum(int duration)
        {
            this.Curriculum.Duration = duration;
            return this;
        }

        public Builder SetComplexityOfCurriculum(Complexity complexity)
        {
            this.Curriculum.Complexity = complexity;
            return this;
        }
        public Curriculum Build() 
        {
            return this.Curriculum;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Builder builder = new Builder();
            Curriculum curriculumForProgrammers = builder
                                                  .SetSubjects("Theories of algorithms")
                                                  .SetSubjects("Object-oriented programming")
                                                  .SetSubjects("Automated control systems")
                                                  .SetDurationOfCurriculum(112)
                                                  .SetComplexityOfCurriculum(Complexity.Middle)
                                                  .Build();
            curriculumForProgrammers.GetInformation();
        }
    }
}
