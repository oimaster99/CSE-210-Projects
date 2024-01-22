using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");

        Job job1 = new Job("Microsoft", "Front-End Developer", 2015, 2022);
        Job job2 = new Job("McDonalds", "Manager", 1988, 1989);
        Job job3 = new Job("Apple", "Software Developer", 1990, 2014);
        Job job4 = new Job("Google", "Front-End Developer", 2022, 2024);

        Resume resume = new Resume("Josephi");

        resume._jobs.Add(job1);
        resume._jobs.Add(job2);
        resume._jobs.Add(job3);
        resume._jobs.Add(job4);

        job1.Display();
        resume.Display();
    }
}