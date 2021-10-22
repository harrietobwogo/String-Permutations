using System;
using  System.Collections.Generic;
class Program {
		public static List<string> permutations = new List<string>();

  public static void Main (string[] args) {
    Console.WriteLine ("Hello World");
		string str="ABC";
	  permutations =	Permute(str,0,str.Length-1);
		foreach(var item in permutations){
			Console.WriteLine(item);
		}

  }
	public static string Swap( string str, int left, int right){
		char [] letters=str.ToCharArray();
		char temp=letters[left];
		letters[left]=letters[right];
		letters[right]=temp;
		return new string(letters);
	}
	public static List<string> Permute(string str, int left, int right){
		if(str.Length==0 || string.IsNullOrEmpty(str)){
			return permutations;
		}
		if(left==right){
			permutations.Add(str);
		}else{
		
				for(int i=left; i<=right; i++){
				str=Swap(str,left,i);
				Permute(str,left+1, right);
				str=Swap(str,left,i);
			}
		}
		return permutations;
	}
}
//String ABC
//Check if the string is Empty or null and either return an empty list or throw an exception
//create an empty list to store the permutations
//Declare two pointers left and right pointers
// if(l==r) add the string to the list
//loop the string while Left<right pointers
		//Call the swap function with the string,left pointer and the current index
		//Recursively call the permutation function on the swapped string
		//Backtrack by swapping the characters again 
//return the list