// Decompiled with JetBrains decompiler
// Type: Draw.Competition
// Assembly: Draw, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FD5E856C-6F6B-4BBC-986E-5999C2E1DCD5
// Assembly location: C:\Users\Evgen\Desktop\Draw\Draw.exe

using System;
using System.Collections.Generic;
using System.Linq;

namespace Draw
{
	internal class Competition
	{
		private List<Team> teams = new List<Team>();
		private List<Category> categories = new List<Category>();
		private string title;
		private DateTime date;
		private string place;
		private string mainReferee;
		private string mainSecretary;

		private Dictionary<int, List<ParticipantPairDescription>> firstRound = new Dictionary<int, List<ParticipantPairDescription>>();

		public event Competition.CompetitionChangeHandler CompetitionChange;

		public event Competition.TeamsChangeHandler TeamsChange;

		public event Competition.CategoriesChangeHandler CategoriesChange;

		public event Competition.CategoryAddedHandler CategoryAdded;

		public Competition()
		{
			this.OnCompetitionChange();
			this.OnCategoriesChange();
			this.OnTeamsChange();
			this.fillFirstRound();
		}

		public Competition(string title, DateTime date, string place, string referee, string secretary)
		{
			this.title = title;
			this.date = date;
			this.place = place;
			this.mainReferee = referee;
			this.mainSecretary = secretary;
			this.OnCompetitionChange();
			this.OnCategoriesChange();
			this.OnTeamsChange();
			this.fillFirstRound();
		}

		private void fillFirstRound()
		{
			List<ParticipantPairDescription> participantPairs = new List<ParticipantPairDescription>();
			for (int i = 5; i <= 32; ++i)
			{
				switch (i)
				{
					case 5:
						participantPairs.Add(new ParticipantPairDescription(true, true));
						participantPairs.Add(new ParticipantPairDescription(false, true));
						participantPairs.Add(new ParticipantPairDescription(true, true));
						break;
					case 6:
						participantPairs.Add(new ParticipantPairDescription(true, true));
						participantPairs.Add(new ParticipantPairDescription(false, true));
						participantPairs.Add(new ParticipantPairDescription(true, true));
						participantPairs.Add(new ParticipantPairDescription(false, true));
						break;
					case 7:
						participantPairs.Add(new ParticipantPairDescription(true, true));
						participantPairs.Add(new ParticipantPairDescription(true, true));
						participantPairs.Add(new ParticipantPairDescription(true, true));
						participantPairs.Add(new ParticipantPairDescription(false, true));
						break;
					case 9:
						participantPairs.Add(new ParticipantPairDescription(true, true));
						participantPairs.Add(new ParticipantPairDescription(false, true));
						participantPairs.Add(new ParticipantPairDescription(true, true));
						participantPairs.Add(new ParticipantPairDescription(true, true));
						participantPairs.Add(new ParticipantPairDescription(true, true));
						break;
					case 10:
						participantPairs.Add(new ParticipantPairDescription(true, true));
						participantPairs.Add(new ParticipantPairDescription(false, true));
						participantPairs.Add(new ParticipantPairDescription(true, true));
						participantPairs.Add(new ParticipantPairDescription(true, true));
						participantPairs.Add(new ParticipantPairDescription(true, true));
						participantPairs.Add(new ParticipantPairDescription(false, true));
						break;
					case 11:
						participantPairs.Add(new ParticipantPairDescription(true, true));
						participantPairs.Add(new ParticipantPairDescription(true, true));
						participantPairs.Add(new ParticipantPairDescription(true, true));
						participantPairs.Add(new ParticipantPairDescription(true, true));
						participantPairs.Add(new ParticipantPairDescription(true, true));
						participantPairs.Add(new ParticipantPairDescription(false, true));
						break;
					case 12:
						participantPairs.Add(new ParticipantPairDescription(true, true));
						participantPairs.Add(new ParticipantPairDescription(true, true));
						participantPairs.Add(new ParticipantPairDescription(true, true));
						participantPairs.Add(new ParticipantPairDescription(true, true));
						participantPairs.Add(new ParticipantPairDescription(true, true));
						participantPairs.Add(new ParticipantPairDescription(true, true));
						break;
					case 13:
						participantPairs.Add(new ParticipantPairDescription(true, true));
						participantPairs.Add(new ParticipantPairDescription(false, true));
						participantPairs.Add(new ParticipantPairDescription(true, false));
						participantPairs.Add(new ParticipantPairDescription(true, true));
						participantPairs.Add(new ParticipantPairDescription(true, true));
						participantPairs.Add(new ParticipantPairDescription(true, true));
						participantPairs.Add(new ParticipantPairDescription(true, false));
						participantPairs.Add(new ParticipantPairDescription(true, true));
						break;
					case 14:
						participantPairs.Add(new ParticipantPairDescription(true, true));
						participantPairs.Add(new ParticipantPairDescription(false, true));
						participantPairs.Add(new ParticipantPairDescription(true, true));
						participantPairs.Add(new ParticipantPairDescription(true, true));
						participantPairs.Add(new ParticipantPairDescription(true, true));
						participantPairs.Add(new ParticipantPairDescription(true, true));
						participantPairs.Add(new ParticipantPairDescription(true, false));
						participantPairs.Add(new ParticipantPairDescription(true, true));
						break;
					case 15:
						participantPairs.Add(new ParticipantPairDescription(true, true));
						participantPairs.Add(new ParticipantPairDescription(false, true));
						participantPairs.Add(new ParticipantPairDescription(true, true));
						participantPairs.Add(new ParticipantPairDescription(true, true));
						participantPairs.Add(new ParticipantPairDescription(false, true));
						participantPairs.Add(new ParticipantPairDescription(true, true));
						participantPairs.Add(new ParticipantPairDescription(true, true));
						participantPairs.Add(new ParticipantPairDescription(true, false));
						participantPairs.Add(new ParticipantPairDescription(true, true));
						break;
					case 16:
						participantPairs.Add(new ParticipantPairDescription(true, true));
						participantPairs.Add(new ParticipantPairDescription(true, true));
						participantPairs.Add(new ParticipantPairDescription(true, true));
						participantPairs.Add(new ParticipantPairDescription(true, true));
						participantPairs.Add(new ParticipantPairDescription(true, true));
						participantPairs.Add(new ParticipantPairDescription(true, true));
						participantPairs.Add(new ParticipantPairDescription(true, true));
						participantPairs.Add(new ParticipantPairDescription(true, true));
						break;
					case 17:
						participantPairs.Add(new ParticipantPairDescription(true, true));
						participantPairs.Add(new ParticipantPairDescription(true, true));
						participantPairs.Add(new ParticipantPairDescription(true, true));
						participantPairs.Add(new ParticipantPairDescription(false, true));
						participantPairs.Add(new ParticipantPairDescription(true, true));
						participantPairs.Add(new ParticipantPairDescription(true, true));
						participantPairs.Add(new ParticipantPairDescription(true, true));
						participantPairs.Add(new ParticipantPairDescription(true, true));
						participantPairs.Add(new ParticipantPairDescription(true, true));
						break;
					case 18:
						participantPairs.Add(new ParticipantPairDescription(true, true));
						participantPairs.Add(new ParticipantPairDescription(true, true));
						participantPairs.Add(new ParticipantPairDescription(true, true));
						participantPairs.Add(new ParticipantPairDescription(true, true));
						participantPairs.Add(new ParticipantPairDescription(false, true));
						participantPairs.Add(new ParticipantPairDescription(true, false));
						participantPairs.Add(new ParticipantPairDescription(true, true));
						participantPairs.Add(new ParticipantPairDescription(true, true));
						participantPairs.Add(new ParticipantPairDescription(true, true));
						participantPairs.Add(new ParticipantPairDescription(true, true));
						break;
					case 19:
						participantPairs.Add(new ParticipantPairDescription(true, true));
						participantPairs.Add(new ParticipantPairDescription(true, true));
						participantPairs.Add(new ParticipantPairDescription(true, true));
						participantPairs.Add(new ParticipantPairDescription(true, true));
						participantPairs.Add(new ParticipantPairDescription(true, true));
						participantPairs.Add(new ParticipantPairDescription(true, false));
						participantPairs.Add(new ParticipantPairDescription(true, true));
						participantPairs.Add(new ParticipantPairDescription(true, true));
						participantPairs.Add(new ParticipantPairDescription(true, true));
						participantPairs.Add(new ParticipantPairDescription(true, true));
						break;
					case 20:
						participantPairs.Add(new ParticipantPairDescription(true, true));
						participantPairs.Add(new ParticipantPairDescription(true, true));
						participantPairs.Add(new ParticipantPairDescription(true, true));
						participantPairs.Add(new ParticipantPairDescription(true, true));
						participantPairs.Add(new ParticipantPairDescription(true, true));
						participantPairs.Add(new ParticipantPairDescription(true, true));
						participantPairs.Add(new ParticipantPairDescription(true, true));
						participantPairs.Add(new ParticipantPairDescription(true, true));
						participantPairs.Add(new ParticipantPairDescription(true, true));
						participantPairs.Add(new ParticipantPairDescription(true, true));
						break;
					case 21:
						participantPairs.Add(new ParticipantPairDescription(true, true));
						participantPairs.Add(new ParticipantPairDescription(true, true));
						participantPairs.Add(new ParticipantPairDescription(true, true));
						participantPairs.Add(new ParticipantPairDescription(false, true));
						participantPairs.Add(new ParticipantPairDescription(true, true));
						participantPairs.Add(new ParticipantPairDescription(true, true));
						participantPairs.Add(new ParticipantPairDescription(true, true));
						participantPairs.Add(new ParticipantPairDescription(true, true));
						participantPairs.Add(new ParticipantPairDescription(true, true));
						participantPairs.Add(new ParticipantPairDescription(true, true));
						participantPairs.Add(new ParticipantPairDescription(true, true));
						break;
					case 22:
						participantPairs.Add(new ParticipantPairDescription(true, true));
						participantPairs.Add(new ParticipantPairDescription(true, true));
						participantPairs.Add(new ParticipantPairDescription(true, true));
						participantPairs.Add(new ParticipantPairDescription(false, true));
						participantPairs.Add(new ParticipantPairDescription(true, true));
						participantPairs.Add(new ParticipantPairDescription(true, true));
						participantPairs.Add(new ParticipantPairDescription(true, true));
						participantPairs.Add(new ParticipantPairDescription(true, true));
						participantPairs.Add(new ParticipantPairDescription(true, false));
						participantPairs.Add(new ParticipantPairDescription(true, true));
						participantPairs.Add(new ParticipantPairDescription(true, true));
						participantPairs.Add(new ParticipantPairDescription(true, true));
						break;
					case 23:
						participantPairs.Add(new ParticipantPairDescription(true, true));
						participantPairs.Add(new ParticipantPairDescription(true, true));
						participantPairs.Add(new ParticipantPairDescription(true, true));
						participantPairs.Add(new ParticipantPairDescription(true, true));
						participantPairs.Add(new ParticipantPairDescription(true, true));
						participantPairs.Add(new ParticipantPairDescription(true, true));
						participantPairs.Add(new ParticipantPairDescription(true, true));
						participantPairs.Add(new ParticipantPairDescription(true, true));
						participantPairs.Add(new ParticipantPairDescription(true, false));
						participantPairs.Add(new ParticipantPairDescription(true, true));
						participantPairs.Add(new ParticipantPairDescription(true, true));
						participantPairs.Add(new ParticipantPairDescription(true, true));
						break;
					case 24:
						participantPairs.Add(new ParticipantPairDescription(true, true));
						participantPairs.Add(new ParticipantPairDescription(true, true));
						participantPairs.Add(new ParticipantPairDescription(true, true));
						participantPairs.Add(new ParticipantPairDescription(true, true));
						participantPairs.Add(new ParticipantPairDescription(true, true));
						participantPairs.Add(new ParticipantPairDescription(true, true));
						participantPairs.Add(new ParticipantPairDescription(true, true));
						participantPairs.Add(new ParticipantPairDescription(true, true));
						participantPairs.Add(new ParticipantPairDescription(true, true));
						participantPairs.Add(new ParticipantPairDescription(true, true));
						participantPairs.Add(new ParticipantPairDescription(true, true));
						participantPairs.Add(new ParticipantPairDescription(true, true));
						break;
					case 25:
						participantPairs.Add(new ParticipantPairDescription(true, true));
						participantPairs.Add(new ParticipantPairDescription(true, true));
						participantPairs.Add(new ParticipantPairDescription(false, true));
						participantPairs.Add(new ParticipantPairDescription(true, true));
						participantPairs.Add(new ParticipantPairDescription(true, true));
						participantPairs.Add(new ParticipantPairDescription(true, true));
						participantPairs.Add(new ParticipantPairDescription(true, true));
						participantPairs.Add(new ParticipantPairDescription(true, true));
						participantPairs.Add(new ParticipantPairDescription(true, true));
						participantPairs.Add(new ParticipantPairDescription(true, true));
						participantPairs.Add(new ParticipantPairDescription(true, true));
						participantPairs.Add(new ParticipantPairDescription(true, true));
						participantPairs.Add(new ParticipantPairDescription(true, true));
						break;
					case 26:
						participantPairs.Add(new ParticipantPairDescription(true, true));
						participantPairs.Add(new ParticipantPairDescription(true, true));
						participantPairs.Add(new ParticipantPairDescription(false, true));
						participantPairs.Add(new ParticipantPairDescription(true, true));
						participantPairs.Add(new ParticipantPairDescription(true, true));
						participantPairs.Add(new ParticipantPairDescription(true, true));
						participantPairs.Add(new ParticipantPairDescription(true, true));
						participantPairs.Add(new ParticipantPairDescription(true, true));
						participantPairs.Add(new ParticipantPairDescription(true, true));
						participantPairs.Add(new ParticipantPairDescription(true, true));
						participantPairs.Add(new ParticipantPairDescription(true, true));
						participantPairs.Add(new ParticipantPairDescription(true, false));
						participantPairs.Add(new ParticipantPairDescription(true, true));
						participantPairs.Add(new ParticipantPairDescription(true, true));
						break;
				}
				if (participantPairs.Count > 0)
				{
					this.firstRound.Add(i, participantPairs);
					participantPairs = new List<ParticipantPairDescription>();
				}
			}
		}

		private int changeParticipants(Team newTeam)
		{
			int num = 0;
			foreach (Category category in this.categories)
				category.getParticipants().RemoveAll((Predicate<Participant>)(p => p.getTeam() == newTeam.getName()));
			using (List<Participant>.Enumerator enumerator = newTeam.getParticipants().GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					Participant p = enumerator.Current;
					foreach (Category category in this.categories)
					{
						try
						{
							category.getParticipants().First<Participant>((Func<Participant, bool>)(s => s.getId() == p.getId())).setName(p.getName());
							if (!category.getParticipants().Contains(p) && category.getFilter().participantMatch(p))
							{
								category.getParticipants().Add(p);
								++num;
							}
						}
						catch (Exception ex)
						{
							if (!category.getParticipants().Contains(p) && category.getFilter().participantMatch(p))
							{
								p.setTeam(newTeam.getName());
								category.getParticipants().Add(p);
							}
							++num;
						}
					}
				}
			}
			return num;
		}

		protected void OnCompetitionChange()
		{
			if (this.CompetitionChange == null)
				return;
			this.CompetitionChange();
		}

		protected void OnTeamsChange()
		{
			if (this.TeamsChange == null)
				return;
			this.TeamsChange();
		}

		protected void OnCategoriesChange()
		{
			if (this.CategoriesChange == null)
				return;
			this.CategoriesChange();
		}

		protected void OnCategoryAdded(Category c)
		{
			if (this.CategoryAdded == null)
				return;
			this.CategoryAdded(c);
		}

		public string getTitle()
		{
			return this.title;
		}

		public DateTime getDate()
		{
			return this.date;
		}

		public string getPlace()
		{
			return this.place;
		}

		public string getReferee()
		{
			return this.mainReferee;
		}

		public string getSecretary()
		{
			return this.mainSecretary;
		}

		public void setTitle(string title)
		{
			this.title = title;
			this.OnCompetitionChange();
		}

		public void setDate(DateTime date)
		{
			this.date = date;
			this.OnCompetitionChange();
		}

		public void setPlace(string place)
		{
			this.place = place;
			this.OnCompetitionChange();
		}

		public void setMainReferee(string referee)
		{
			this.mainReferee = referee;
			this.OnCompetitionChange();
		}

		public void setMainSecretary(string secretary)
		{
			this.mainSecretary = secretary;
			this.OnCompetitionChange();
		}

		public void setTeams(List<Team> teams)
		{
			this.teams = teams;
			this.OnTeamsChange();
		}

		public List<Team> getTeams()
		{
			return this.teams;
		}

		public void addTeam(Team team)
		{
			if (this.teams == null)
				this.teams = new List<Team>();
			this.teams.Add(team);
			if (this.changeParticipants(team) > 0)
				this.OnCategoriesChange();
			this.OnTeamsChange();
		}

		public void removeTeam(string name)
		{
			try
			{
				this.teams.Remove(this.teams.First<Team>((Func<Team, bool>)(s => s.getName() == name)));
				this.OnTeamsChange();
			}
			catch (Exception ex)
			{
			}
		}

		public void changeTeam(string name, Team newTeam)
		{
			int num = 0;
			try
			{
				this.teams.First<Team>((Func<Team, bool>)(s => s.getName() == name)).setParticipants(newTeam.getParticipants());
				this.teams.First<Team>((Func<Team, bool>)(s => s.getName() == name)).setName(newTeam.getName());
				num = this.changeParticipants(newTeam);
			}
			catch (Exception ex)
			{
			}
			foreach (Category category in this.categories)
			{
				foreach (Participant participant in category.getParticipants())
				{
					if (participant.getTeam() == name)
					{
						participant.setTeam(newTeam.getName());
						++num;
					}
				}
			}
			if (num > 0)
				this.OnCategoriesChange();
			this.OnTeamsChange();
		}

		public List<Category> getCategories()
		{
			return this.categories;
		}

		public void addCategory(string name, CategoryFilter filter)
		{
			List<Participant> participants = new List<Participant>();
			foreach (Team team in this.teams)
			{
				team.getParticipants().Shuffle<Participant>();
				foreach (Participant participant in team.getParticipants())
				{
					if (filter.participantMatch(participant))
					{
						participant.setTeam(team.getName());
						participants.Add(participant);
					}
				}
			}
			Category c = new Category(name, participants, filter);
			this.categories.Add(c);
			this.OnCategoryAdded(c);
		}

		public void addCategory(Category c)
		{
			this.categories.Add(c);
			this.OnCategoryAdded(c);
		}

		public void deleteCategory(string name)
		{
			try
			{
				this.categories.Remove(this.categories.First<Category>((Func<Category, bool>)(s => s.getName() == name)));
			}
			catch (Exception ex)
			{
			}
		}

		public void updateCategory(string name, Category newValue)
		{
			try
			{
				this.categories.First<Category>((Func<Category, bool>)(s => s.getName() == name)).setParticipants(newValue.getParticipants());
				this.categories.First<Category>((Func<Category, bool>)(s => s.getName() == name)).setName(newValue.getName());
			}
			catch (Exception ex)
			{
			}
		}

		public List<ParticipantPair> draw(string categoryName)
		{
			List<ParticipantPair> participantPairList = new List<ParticipantPair>();
			Dictionary<string, List<Participant>> dictionary = new Dictionary<string, List<Participant>>();
			Category category = this.categories.First<Category>((Func<Category, bool>)(s => s.getName() == categoryName));
			//Dictionary<int, List<ParticipantPairDescription>> firstRound = new Dictionary<int, List<ParticipantPairDescription>>(this.firstRound);
			//Dictionary<int, List<ParticipantPairDescription>> firstRound = this.firstRound.ToDictionary(entry => entry.Key,
			//entry => entry.Value);
			if (category != null)
			{
				int num = 0;
				category.getParticipants().Shuffle<Participant>();
				foreach (Participant participant in category.getParticipants())
				{
					if (!dictionary.Keys.Contains<string>(participant.getTeam()))
						dictionary[participant.getTeam()] = new List<Participant>();
					dictionary[participant.getTeam()].Add(participant);
					++num;
				}
				int categoryLength = num;
				ParticipantPair participantPair = new ParticipantPair();
				ParticipantPairDescription ppd = new ParticipantPairDescription(true, true);
				List<ParticipantPairDescription> firstRound = new List<ParticipantPairDescription>();
				if (this.firstRound.ContainsKey(categoryLength))
				{
					foreach (ParticipantPairDescription description in this.firstRound[categoryLength])
					{
						firstRound.Add(description);
					}
				}
				while (num > 0)
				{
					foreach (KeyValuePair<string, List<Participant>> keyValuePair in dictionary)
					{
						if (firstRound.Count > 0)
						{
							ppd = firstRound[0];
							//foreach (ParticipantPairDescription ppd in this.firstRound[categoryLength])
							//{
							//if (ppd.aka)
							//{

							//}
							//}
						}
						else
						{
							ppd = new ParticipantPairDescription(true, true);
						}
						if (!ppd.aka && participantPair.aka == null)
						{
							participantPair.addParticipant(new FakeParticipant());
						}
						else if (!ppd.siro && participantPair.aka != null)
						{
							participantPair.addParticipant(new FakeParticipant());
						}
						else if (dictionary[keyValuePair.Key].Count > 0)
						{
							participantPair.addParticipant(dictionary[keyValuePair.Key][0]);
							--num;
							dictionary[keyValuePair.Key].RemoveAt(0);
						}
						if (participantPair.aka != null && participantPair.siro != null)
						{
							participantPairList.Add(participantPair);
							participantPair.aka = (Participant)null;
							participantPair.siro = (Participant)null;
							if (firstRound.Count > 0)
							{
								firstRound.RemoveAt(0);
							}
						}
					}
				}
				if (participantPair.aka != null)
					participantPairList.Add(participantPair);
			}
			return participantPairList;
		}

		public void clear()
		{
			this.categories.Clear();
			this.teams.Clear();
			this.OnCompetitionChange();
			this.OnCategoriesChange();
			this.OnTeamsChange();
		}

		public delegate void CompetitionChangeHandler();

		public delegate void TeamsChangeHandler();

		public delegate void CategoriesChangeHandler();

		public delegate void CategoryAddedHandler(Category c);
	}
}
