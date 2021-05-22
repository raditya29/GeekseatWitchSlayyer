using Xunit;

namespace GeekseatWitch.Test
{
    public class DeceasedTest
    {
        [Theory]
        [InlineData(-1, 17)] // age of death is invalid
        [InlineData(10, 9)] // born before witch took control
        [InlineData(10, 10)] // born before witch took control
        public void Constructor_Throw_InvalidDeceasedDataException_Given_InvalidData(int ageOfDeath, int yearOfDeath)
        {
            // act and assert
            Assert.Throws<InvalidDeceasedDataException>(() => new Deceased(ageOfDeath, yearOfDeath));
        }

        [Theory]
        [InlineData(10, 12, 2)]
        [InlineData(13, 17, 4)]
        public void YearOfBirth_Calculated_Correctly_Given_Valid_Data(int ageOfDeath, int yearOfDeath, int expectedYearOfBirth)
        {
            // arrange 
            var deceased = new Deceased(ageOfDeath, yearOfDeath);

            // act and assert
            Assert.Equal(expectedYearOfBirth, deceased.YearOfBirth);
        }

        [Theory]
        [InlineData(10, 12, 2)]
        [InlineData(13, 17, 7)]
        public void PeopleKilledOnYoB_Correctly_Return_TargetCounts(int ageOfDeath, int yearOfDeath, int expectedNumberOfPeopleKilled)
        {
            // arrange 
            var deceased = new Deceased(ageOfDeath, yearOfDeath);

            // act and assert
            Assert.Equal(expectedNumberOfPeopleKilled, deceased.PeopleKilledOnYoB());
        }
    }
}
