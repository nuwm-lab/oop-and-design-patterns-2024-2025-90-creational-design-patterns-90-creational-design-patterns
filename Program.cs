using System;

namespace LabWork
{
    // Даний проект є шаблоном для виконання лабораторних робіт
    // з курсу "Об'єктно-орієнтоване програмування та патерни проектування"
    // Необхідно змінювати і дописувати код лише в цьому проекті
    // Відео-інструкції щодо роботи з github можна переглянути 
    // за посиланням https://www.youtube.com/@ViktorZhukovskyy/videos 
    public interface ILibrary
    {
        void BuildHospital();
    }

    public class FieldHospital : ILibrary
    {
        public void BuildHospital()
        {
            Console.WriteLine("Building a field hospital...");
        }
    }

    public class CapitalHospital : ILibrary
    {
        public void BuildHospital()
        {
            Console.WriteLine("Building a capital hospital...");
        }
    }

    public abstract class HospitalFactory
    {
        public abstract ILibrary CreateHospital();
    }

    public class FieldHospitalFactory : HospitalFactory
    {
        public override ILibrary CreateHospital()
        {
            return new FieldHospital();  // Створюємо польову лікарню
        }
    }

    public class CapitalHospitalFactory : HospitalFactory
    {
        public override ILibrary CreateHospital()
        {
            return new CapitalHospital();  // Створюємо капітальну лікарню
        }
    }

    public class Program
    {
        public static void Main()
        {
            // Вибір фабрики для створення лікарні
            HospitalFactory factory;

            // Наприклад, вибір варіанту на основі залишку від ділення на 3
            int variant = 6; // Вибір варіанту (можна змінити на 3, 6, 9, 12, щоб використовувати фабрику для польової лікарні)

            if (variant % 3 == 0)
            {
                factory = new FieldHospitalFactory(); // Для варіанту, де залишок від ділення на 3 = 0
            }
            else
            {
                factory = new CapitalHospitalFactory(); // Для інших варіантів
            }

            // Створення лікарні за допомогою абстрактної фабрики
            var hospital = factory.CreateHospital();
            hospital.BuildHospital(); // Будуємо лікарню
        }
    }
}
