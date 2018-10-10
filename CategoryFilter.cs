// Decompiled with JetBrains decompiler
// Type: Draw.CategoryFilter
// Assembly: Draw, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FD5E856C-6F6B-4BBC-986E-5999C2E1DCD5
// Assembly location: C:\Users\Evgen\Desktop\Draw\Draw.exe

namespace Draw
{
  public struct CategoryFilter
  {
    public int ageMin;
    public int ageMax;
    public double weightMin;
    public double weightMax;
    public string sex;
    public int kuMin;
    public int kuMax;
    public CategoryType type;

    public CategoryFilter(int ageMin, int ageMax, double weightMin, double weightMax, string sex, CategoryType type, int kuMin, int kuMax)
    {
      this.ageMin = ageMin;
      this.ageMax = ageMax;
      this.weightMin = weightMin;
      this.weightMax = weightMax;
      this.sex = sex;
      this.kuMin = kuMin;
      this.kuMax = kuMax;
      this.type = type;
    }

    public bool participantMatch(Participant p)
    {
      return p.getAge() >= this.ageMin && p.getAge() <= this.ageMax && (this.sex == p.getSex() && this.kuMin >= p.getKu()) && this.kuMax <= p.getKu() && (this.type == CategoryType.Kata && p.getCategories().Contains(CategoryType.Kata) || this.type == CategoryType.Fukugo && p.getCategories().Contains(CategoryType.Fukugo) || (this.type == CategoryType.Kumite && p.getCategories().Contains(CategoryType.Kumite) || this.type == CategoryType.Irigumi && p.getCategories().Contains(CategoryType.Irigumi)) && p.getWeight() >= this.weightMin && p.getWeight() <= this.weightMax);
    }
  }
}
