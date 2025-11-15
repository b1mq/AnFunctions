using FunctionsAn.Domain.Entities;




//List<int> Mylist = new List<int>() {1,2,3,4,5,6,7,8,9,11,12,13,14,15,16,17,18,19,20 };
//var NumbersKr7 = Mylist.FindAll(x => x % 7 == 0);
//var NumbersPositive = Mylist.FindAll(x => x >= 0);
//var NumbersNegativeAndUnikum = Mylist.FindAll(x => x >= 0);
//Func <string,string,bool> containsWord = (text,word)  => text.Contains(word);
//var UniqueNums = (int[] a) => a.Where(x => x < 0).Distinct();


int[] data = {1,2,3,4,5,6,7,8,9,10 };

Func<int[], int[]> EvenNumbersInArray = array => array.Where(x => x % 2 == 0).ToArray();
Func<int[], int[]> OddNumbersInArray = array => array.Where(x => x % 2 != 0).ToArray();
Func<int[], int[]> PrimeNums = array => array.Where(n =>
    n > 1 &&
    Enumerable.Range(2, (int)Math.Sqrt(n)).All(i => n % i != 0)
).ToArray();

Action ShowTimeAction = () => Console.WriteLine($"Time: {DateTime.Now.ToString("HH:mm:ss")}");
Action ShowDayOfTheWeekAction = () => Console.WriteLine($"Day: {DateTime.Now.DayOfWeek}");
Action ShowDataAction = () => Console.WriteLine($"Data: {DateOnly.FromDateTime(DateTime.Now).ToString()}");

Func<double,double,double> TriangleS = (a,b) => 0.5 * a * b ;
Func<double,double,double> SquareS = (a,b) =>  a * b ;

int[] Evenum = EvenNumbersInArray(data);
int[] Oddnum = OddNumbersInArray(data);
