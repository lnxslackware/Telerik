﻿class MainClass
{
    enum Sex
    {
        Male,
        Female
    };

    class Human
    {
        public Sex Sex { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }

    public void CreateHuman(int age)
    {
        Human human = new Human();
        human.Age = age;
        if (age % 2 == 0)
        {
            human.Name = "Батката";
            human.Sex = Sex.Male;
        }
        else
        {
            human.Name = "Мацето";
            human.Sex = Sex.Female;
        }
    }
}