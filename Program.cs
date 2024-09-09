const double SANDWICH_COST = 4.75;
const double TOPPING_COST = 0.55;
const double DISCOUNT = 0.1;


int numOfSandwiches = 0;
int numberOfToppings = 0;
double tip = 0;

Console.WriteLine("enter number of sandwiches: ");
numberOfSandwiches = int.Parse(Console.ReadLine());

Console.WriteLine("enter number of toppings: ");
numberOfToppings = int.Parse(Console.ReadLine());

Console.WriteLine("enter tip amount: ");
tip = int.Parse(Console.ReadLine());


double sandwichCost = 0;
sandwichCost = sandwichCost * numOfSandwiches;

double toppingCost = 0;
toppingCost = sandwichCost * numOfToppings;


double cost = 0;
cost = sandwichCost * toppingCost;


double order = 0;
order = sandwichCost +toppingCost;



