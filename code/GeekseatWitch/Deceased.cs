namespace GeekseatWitch
{
    public class Deceased
    {
        public int AgeOfDeath { get; }
        public int YearOfDeath { get; }
        public int YearOfBirth => YearOfDeath - AgeOfDeath;

        public Deceased(int ageOfDeath, int yearOfDeath)
        {
            if (ageOfDeath < 1) throw new InvalidDeceasedDataException($"{nameof(ageOfDeath)}");
            if (yearOfDeath <= ageOfDeath) throw new InvalidDeceasedDataException($"{nameof(yearOfDeath)}");

            AgeOfDeath = ageOfDeath;
            YearOfDeath = yearOfDeath;
        }

        public int PeopleKilledOnYoB() => WitchCalculator.TargetCounts(YearOfBirth);
    }
}
