/*
Challenge 1. Given a jagged array of integers (two dimensions).
Find the common elements in the nested arrays.
Example: int[][] arr = { new int[] {1, 2}, new int[] {2, 1, 5}}
Expected result: int[] {1,2} since 1 and 2 are both available in sub arrays.
*/

int[] CommonItems(int[][] jaggedArray)
{
    if (jaggedArray.Length == 0)
    {
        return Array.Empty<int>();
    }
    int[] commonElements = jaggedArray[0];
    for (int i = 1; i < jaggedArray.Length; i++)
    {
        commonElements = commonElements.Intersect(jaggedArray[i]).ToArray();
    }
    return commonElements;
}
int[][] arr1 = { new int[] { 1, 2, 6, 5 }, new int[] { 2, 1, 5, 19, 65, 5 } };
int[] arr1Common = CommonItems(arr1);
Console.WriteLine("Common Element: " + string.Join(", ", arr1Common));

/* 
Challenge 2. Inverse the elements of a jagged array.
For example, int[][] arr = {new int[] {1,2}, new int[]{1,2,3}} 
Expected result: int[][] arr = {new int[]{2, 1}, new int[]{3, 2, 1}}
*/
void InverseJagged(int[][] jaggedArray)
{
    for (int i = 0; i < jaggedArray.Length; i++)
    {
        Array.Reverse(jaggedArray[i]);
    }
}

int[][] arr2 = { new int[] { 1, 2, 4, 15, 5 }, new int[] { 1, 2, 3, 7, 17, 9 } };
InverseJagged(arr2);

Console.WriteLine("Inverse Jagged Array:");
for (int i = 0; i < arr2.Length; i++)
{
    Console.WriteLine(string.Join(", ", arr2[i]));
}

/* 
Challenge 3.Find the difference between 2 consecutive elements of an array.
For example, int[][] arr = {new int[] {1,2}, new int[]{1,2,3}} 
Expected result: int[][] arr = {new int[] {-1}, new int[]{-1, -1}}
 */
void CalculateDiff(int[][] jaggedArray)
{
    for (int i = 0; i < jaggedArray.Length; i++)
    {
        int[] subarray = jaggedArray[i];
        int[] diffArray = new int[subarray.Length - 1];

        for (int j = 0; j < subarray.Length - 1; j++)
        {
            diffArray[j] = subarray[j + 1] - subarray[j];
        }

        jaggedArray[i] = diffArray;
    }
}
int[][] arr3 = { new int[] { 1, 2, 5, 8, 6 }, new int[] { 1, 2, 3, 5, 9, 11, 8 } };
CalculateDiff(arr3);
/* write method to print arr3 */
Console.WriteLine("Difference Jagged Array:");
for (int i = 0; i < arr3.Length; i++)
{
    Console.WriteLine(string.Join(", ", arr3[i]));
}


/* 
Challenge 4. Inverse column/row of a rectangular array.
For example, given: int[,] arr = {{1,2,3}, {4,5,6}}
Expected result: {{1,4},{2,5},{3,6}}
 */
int[,] InverseRec(int[,] recArray)
{

}
int[,] arr4 = { { 1, 2, 3 }, { 4, 5, 6 } };
int[,] arr4Inverse = InverseRec(arr4);
/* write method to print arr4Inverse */

/* 
Challenge 5. Write a function that accepts a variable number of params of any of these types: 
string, number. 
- For strings, join them in a sentence. 
- For numbers then sum them up. 
- Finally print everything out. 
Example: Demo("hello", 1, 2, "world") 
Expected result: hello world; 3 */
void Demo()
{

}
Demo("hello", 1, 2, "world"); //should print out "hello world; 3"
Demo("My", 2, 3, "daughter", true, "is");//should print put "My daughter is; 5"


/* Challenge 6. Write a function to swap 2 objects but only if they are of the same type 
and if they’re string, lengths have to be more than 5. 
If they’re numbers, they have to be more than 18. */
void SwapTwo()
{

}

/* Challenge 7. Write a function that does the guessing game. 
The function will think of a random integer number (lets say within 100) 
and ask the user to input a guess. 
It’ll repeat the asking until the user puts the correct answer. */
void GuessingGame()
{

}
GuessingGame();

/* Challenge 8. Provide class Product, OrderItem, Cart, which make a feature of a store
Complete the required features in OrderItem and Cart, so that the test codes are error-free */

var product1 = new Product(1, 30);
var product2 = new Product(2, 50);
var product3 = new Product(3, 40);
var product4 = new Product(4, 35);
var product5 = new Product(5, 75);

var orderItem1 = new OrderItem(product1, 2);
var orderItem2 = new OrderItem(product2, 1);
var orderItem3 = new OrderItem(product3, 3);
var orderItem4 = new OrderItem(product4, 2);
var orderItem5 = new OrderItem(product5, 5);
var orderItem6 = new OrderItem(product2, 2);

var cart = new Cart();
cart.AddToCart(orderItem1, orderItem2, orderItem3, orderItem4, orderItem5, orderItem6);

//get 1st item in cart
var firstItem = cart[0];
Console.WriteLine(firstItem);

//Get cart info
cart.GetCartInfo(out int totalPrice, out int totalQuantity);
Console.WriteLine("Total Quantity: {0}, Total Price: {1}", totalQuantity, totalPrice);

//get sub array from a range
var subCart = cart[1, 3];
Console.WriteLine(subCart);

class Product
{
    public int Id { get; set; }
    public int Price { get; set; }

    public Product(int id, int price)
    {
        this.Id = id;
        this.Price = price;
    }
}

class OrderItem : Product
{
    public int Quantity { get; set; }

    public OrderItem(Product product, int quantity) : base(product.Id, product.Price)
    {
        this.Quantity = quantity;
    }

    /* Override ToString() method so the item can be printed out conveniently with Id, Price, and Quantity */
}

class Cart
{
    private List<OrderItem> _cart { get; set; } = new List<OrderItem>();

    /* Write indexer property to get nth item from _cart */

    /* Write indexer property to get items of a range from _cart */

    public void AddToCart(params OrderItem[] items)
    {
        /* this method should check if each item exists --> increase value / or else, add item to cart */
    }
    /* Write another method called Index */

    /* Write another method called GetCartInfo(), which out put 2 values: 
    total price, total products in cart*/

    /* Override ToString() method so Console.WriteLine(cart) can print
    id, unit price, unit quantity of each item*/

}