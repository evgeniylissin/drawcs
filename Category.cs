// Decompiled with JetBrains decompiler
// Type: Draw.Category
// Assembly: Draw, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FD5E856C-6F6B-4BBC-986E-5999C2E1DCD5
// Assembly location: C:\Users\Evgen\Desktop\Draw\Draw.exe

using System.Collections.Generic;

namespace Draw
{
  public class Category
  {
    private List<Participant> participants = new List<Participant>();
    private string name;
    private CategoryFilter filter;

    public Category()
    {
    }

    public Category(string name, List<Participant> participants, CategoryFilter filter)
    {
      this.name = name;
      this.participants = participants;
      this.filter = filter;
    }

    public Category(string name, CategoryFilter filter)
    {
      this.name = name;
      this.filter = filter;
    }

    public List<Participant> getParticipants()
    {
      return this.participants;
    }

    public void setParticipants(List<Participant> participants)
    {
      this.participants = participants;
    }

    public void setName(string name)
    {
      this.name = name;
    }

    public string getName()
    {
      return this.name;
    }

    public CategoryFilter getFilter()
    {
      return this.filter;
    }

    public void setFilter(CategoryFilter filter)
    {
      this.filter = filter;
    }
  }
}
