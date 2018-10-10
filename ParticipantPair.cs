// Decompiled with JetBrains decompiler
// Type: Draw.ParticipantPair
// Assembly: Draw, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FD5E856C-6F6B-4BBC-986E-5999C2E1DCD5
// Assembly location: C:\Users\Evgen\Desktop\Draw\Draw.exe

namespace Draw
{
	public class ParticipantPairDescription
	{
		public bool aka = true;
		public bool siro = true;

		public ParticipantPairDescription(bool aka, bool siro)
		{
			this.aka = aka;
			this.siro = siro;
		}

		public ParticipantPairDescription setParticipants(bool aka, bool siro)
		{
			this.aka = aka;
			this.siro = siro;
			return this;
		}
	}
	public struct ParticipantPair
	{
		public Participant aka;
		public Participant siro;

		public void addParticipant(Participant p, string position = "")
		{
			if (this.aka == null && position != "siro")
			{
				this.aka = p;
			}
			else
			{
				this.siro = p;
			}
		}
	}
}
