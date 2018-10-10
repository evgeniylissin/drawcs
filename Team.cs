// Decompiled with JetBrains decompiler
// Type: Draw.Team
// Assembly: Draw, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FD5E856C-6F6B-4BBC-986E-5999C2E1DCD5
// Assembly location: C:\Users\Evgen\Desktop\Draw\Draw.exe

using System.Collections.Generic;

namespace Draw
{
  public class Team
  {
    private string name;
    private List<Participant> participants;

    public Team()
    {
    }

    public Team(string name, List<Participant> participants)
    {
      this.name = name;
      this.participants = participants;
    }

    public string getName()
    {
      return this.name;
    }

    public List<Participant> getParticipants()
    {
      return this.participants;
    }

    public void setName(string name)
    {
      this.name = name;
    }

    public void setParticipants(List<Participant> participants)
    {
      this.participants = participants;
    }
  }
}
