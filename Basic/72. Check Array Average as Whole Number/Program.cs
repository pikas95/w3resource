/* 72. Check Array Average as Whole Number

Write a C# Sharp program to check whether the average value 
of the elements of a given array of numbers is a whole number or not.
Sample Output:
nums = { 1, 2, 3, 5, 4, 2, 3, 4 }
Check the average value of the said array is a whole number or not: True
nums1 = { 2, 4, 2, 6, 4, 8 }
Check the average value of the said array is a whole number or not: False*/
int[] nums = { 1, 2, 3, 5, 4, 2, 3, 4 };
Console.WriteLine("nums: " + AverageWholeNumber(nums));
int[] nums1 = { 2, 4, 2, 6, 4, 8 };
Console.WriteLine("nums1: " + AverageWholeNumber(nums1));
bool AverageWholeNumber(int[] array) => array.Average() % 1 == 0;