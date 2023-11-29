namespace ConditionalExpression
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var x = 100;
            var y = 200;
            var z = 300;
            //comparison operator
            var isEqual = x == y;
            var isNotEqual = x != y;
            var isGreater = x > y;
            var isLess = x < y;
            var isGreaterOrEqual = x >= y;
            var isLessOrEqual = x <= y;

            //var smth = x => y;
            //var smthElse = x =< y;


            //logical operator 

            
            var isXGreaterThanYOrGreaterThanZ = (x > y) | (x > z);
            var isXGreaterThanYAndZ = (x > y) & (x > z);

            var isXGreaterThanYOrGreaterThanZ2 = (x > y) || (x > z);
            var isXGreaterThanYAndZ2 = (x > y) && (x > z);

            var trueVariable = true;
            var isNotTrue = !trueVariable;
            var isXNotGreaterThanY = !(x > y);

            var isXMoreThanYOrZMoreThanYButNotAtSameTime = (x > y) ^ (z > y);


            // | vs || AND & vs && 
            var orComparing1 = (10 > 7) | (17 > 25);
            var orComparing2 = (10 > 7) || (17 > 25);
        }
    }
}