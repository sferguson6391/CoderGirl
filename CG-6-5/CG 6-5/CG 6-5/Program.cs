using System;

namespace CG_6_5
{
    class Program
    {
        DateTime[] signDates;
        DateTime userBirthday;

        String[] horoscopes;
        int thisYear;

        public Program()
        {
            this.getUserBirthday();
            this.getSignDates();
            this.getHoroscopes();
        }

        private void getUserBirthday()
        {
            Console.Write("Enter your birthday to see your horoscope: ");
            this.userBirthday = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine($"You were born on a {userBirthday.DayOfWeek}");

            this.thisYear = DateTime.Now.Year;
            DateTime futureBirthday = new DateTime(userBirthday.Year + 1, userBirthday.Month, userBirthday.Day);

            Console.WriteLine($"Your next birthday will be on a {futureBirthday.DayOfWeek}");
        }

        private void getSignDates()
        {
            this.signDates =  new DateTime[] {new DateTime(this.userBirthday.Year, 3, 21),
                        new DateTime(this.userBirthday.Year, 4, 20),
                        new DateTime(this.userBirthday.Year, 5, 21),
                        new DateTime(this.userBirthday.Year, 6, 21),
                        new DateTime(this.userBirthday.Year, 7, 23),
                        new DateTime(this.userBirthday.Year, 8, 23),
                        new DateTime(this.userBirthday.Year, 9, 23),
                        new DateTime(this.userBirthday.Year, 10, 23),
                        new DateTime(this.userBirthday.Year, 11, 22),
                        new DateTime(this.userBirthday.Year, 12, 22),
                        new DateTime(this.userBirthday.Year, 1, 20),
                        new DateTime(this.userBirthday.Year, 2, 19)};
        }

        private void getHoroscopes()
        {
            this.horoscopes = new string[] {"You are an Aries: With a number of retrogrades in force, it would be no " +
                    "\nsurprise if you found it difficult to make as much progress as you’d like. And with " +
                    "\nfiery Mars, your guide planet, now back into Capricorn, you might feel very eager " +
                    "\nconcerning your career or personal responsibilities. This is certainly a time to finish " +
                    "\noff anything that’s long overdue.",

                    "You are a Taurus: With dynamic Mars back in Capricorn and your sector of far " +
                    "\nhorizons until September 10, you might get a second bite at the cherry. Even though feisty " +
                    "\nMars is currently retrograde, an opportunity to travel, study, or work abroad could come " +
                    "\nyour way again. While it might take some time to get moving, this can be your chance to " +
                    "\nregister your interest",

                     "You are a Gemini: Enhanced determination could motivate you today, Gemini, " +
                    "\ngiving you the zip to plow through your work. Finish projects that have been pending " +
                    "\nand think about what you want to tackle next. Don't hesitate to do something that feels " +
                    "\ncomplicated or big. You'll probably be able to handle anything, and it will feel great " +
                    "\nwhen you're done.",

                     "You are a Cancer: As eloquent Mercury forges a tie with lovely Venus in your " +
                    "\nhome zone over this week, what seems like a bargain may not be. If you’re tempted by an " +
                    "\nitem, it might be better to wait until next week before purchasing it. In the meantime, " +
                    "\nconsider looking around for similar items because you could find something of much better " +
                    "\nquality at a really good price.",

                     "You are a Leo: As talkative Mercury slows down this week prior to turning direct " +
                    "\nthis weekend, you might experience further delays and frustrations. And with other retrogrades " +
                    "\nin play, this isn’t a time to rush into anything. Instead, it’s better to have patience and " +
                    "\ntake a steady approach. This is an opportunity to clear away anything that may be blocking " +
                    "\nyour progress.",

                     "You are a Virgo: Beautiful energies that pervade your chart this week link to " +
                    "\nyour relationship zone and social sector, and they could certainly enhance your love life, " +
                    "\ntoo. With positive Jupiter aligning with idealistic Neptune, you might easily see the best " +
                    "\nin people, and this can immediately help to forge special bonds. The coming week can be " +
                    "\nexcellent for romantic dates, whether it’s a first outing or you are long-time partners.",

                     "You are a Libra: Feisty Mars, your relationship planet, has moved back into " +
                    "\nCapricorn and your family sector, so this can be an opportunity to clear up any unfinished " +
                    "\nbusiness. Whether that relates to DIY tasks, getting rid of clutter, or other important " +
                    "\nfamily issues, this is your chance to complete everything to your satisfaction.",

                     "You are a Scorpio: Dynamic Mars, your co-ruler, is now in Capricorn and your " +
                    "\nsector of talk and thought, which could be your chance to get up to speed with paperwork " +
                    "\nand administrative tasks. If you have any deadlines looming, you can see to them as well. " +
                    "\nWhatever responsibilities you may have pushed to one side can now be tackled with a little " +
                    "\nmore enthusiasm.",

                     "You are a Sagittarius: Restless Mercury slows down this week prior to turning " +
                    "\ndirect in your travel sector over the weekend. It would help to check schedules and make " +
                    "\nsure you have everything you need for traveling because lively Mercury could confuse issues " +
                    "\nat this time. Once it forges ahead again on Saturday, things can gradually fall back into place.",

                     "You are a Capricorn: Messenger Mercury slows down this week as it prepares " +
                    "\nto turn direct over the weekend, and it does so in a more intense sector of your chart. " +
                    "\nAs a result, it might be wise to delay signing any contracts that involve a lot of money, " +
                    "\ntaking out a loan, or applying for credit right now. Wait a week or so and the process " +
                    "\nshould go much more smoothly.",

                     "You are an Aquarius: The focus on your sector of relating continues this week, " +
                    "\nso you could still be under the influence of last week’s solar eclipse in this zone. And " +
                    "\nwith eloquent Mercury slowing in preparation for turning direct this coming weekend, it " +
                    "\nmight be just as well to wait before you make any important decisions.",

                     "You are a Pisces: A positive aspect between expansive and dreamy Neptune in " +
                    "\nyour sign is at its peak, which could inspire you to get away from it all and enjoy a " +
                    "\npeaceful vacation. This might be just a short break or you could plan something longer. " +
                    "\nEither way, you need this time to soak up the peace and quiet and center yourself, especially " +
                    "\nif you’ve been very busy lately. "
            };
        }

        private void getHoroscope()
        {
            for(uint i = 0; i < this.signDates.Length; i++)
            {
                if (i == 0)
                {
                    if (this.userBirthday > this.signDates[this.signDates.Length - 1] && this.userBirthday < this.signDates[i])
                    {
                        Console.WriteLine(this.horoscopes[0]);
                        break;
                    }
                }
                else if (this.userBirthday < this.signDates[i])
                {
                    Console.WriteLine(this.horoscopes[i-1]);
                    break;
                }
            }
        }
       static void Main(string[] args)
        {
            Program program = new Program();
            program.getHoroscope();
            Console.ReadLine();
        }
    }
}
