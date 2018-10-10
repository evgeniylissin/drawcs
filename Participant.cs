// Decompiled with JetBrains decompiler
// Type: Draw.Participant
// Assembly: Draw, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FD5E856C-6F6B-4BBC-986E-5999C2E1DCD5
// Assembly location: C:\Users\Evgen\Desktop\Draw\Draw.exe

using System.Collections.Generic;

namespace Draw
{
  public class Participant
  {
    private static int autoincrement = 1;
    private List<CategoryType> categories = new List<CategoryType>();
    private int id;
    private string name;
    private int age;
    private double weight;
    private string sex;
    private string team;
    private int ku;

    public Participant()
    {
      this.id = Participant.autoincrement;
      ++Participant.autoincrement;
    }

    public Participant(string name, int age, double weight, string sex, int ku, List<CategoryType> categories)
    {
      this.id = Participant.autoincrement;
      ++Participant.autoincrement;
      this.name = name;
      this.age = age;
      this.weight = weight;
      this.sex = sex;
      this.ku = ku;
      this.categories = categories;
    }

    public string getName()
    {
      return this.name;
    }

    public int getAge()
    {
      return this.age;
    }

    public double getWeight()
    {
      return this.weight;
    }

    public string getSex()
    {
      return this.sex;
    }

    public int getKu()
    {
      return this.ku;
    }

    public List<CategoryType> getCategories()
    {
      return this.categories;
    }

    public string getTeam()
    {
      return this.team;
    }

    public void setTeam(string team)
    {
      this.team = team;
    }

    public void setName(string name)
    {
      this.name = name;
    }

    public void setKu(int ku)
    {
      this.ku = ku;
    }

    public void setCategories(List<CategoryType> categories)
    {
      this.categories = categories;
    }

    public int getId()
    {
      return this.id;
    }

    public void setId(int id)
    {
      this.id = id;
      if (id < Participant.autoincrement)
        return;
      Participant.autoincrement = id;
      ++Participant.autoincrement;
    }

    public bool Equals(Participant p)
    {
      return p.getId() == this.getId();
    }
  }
  
  public class FakeParticipant : Participant {
  }
}
