/* In this line we import the C main Archive that is stdio.h we need it 
to program in C, it contains all the variables, datatypes, methods,
reserverd words,etc we shall need to program in C Language*/
#include <stdio.h>
/* In this line we declare the main method, it is the method that
starts the program */
int main()
{
	/* we declare 3 integer values where we'll stock the data we shall
	need to make the program work*/
	int n1,n2,res;
	/* This is an opcional line on the program, when you use the
	method system you are calling the Operative System (OS) command
	line cmd in Windows case,Bash terminal on GNU/Linux case, Unix Terminal
	on Mac OS case. so what we are doing here is to write in the command
	line color a on windows it will change the color of the console 
	letter to green */
	// system("color a");
	// printf method serves to print text on the screen console.
	printf("Please insert the first number: ");
	// scanf method serves to read text on the screen console. and then to
	// save it on a variable.
	scanf("%d",&n1);
	printf("Please insert the second number: ");
	scanf("%d",&n2);
	/* in C we can stock the result of a simple aritmethic
	expresion just as 1+1 on a variable, in this line we assign the
	result of adding n1 and n2 value on the res variable. */
	res = n1 + n2;
	/* We will print n1 + n2 = res but with it values
	example if n1 and n2 equals 1 then it will show 
	1 + 1 = 2 */
	printf("%d + %d = %d",n1,n2,res);
	/* the getch method serves to wait an enter key input in order to
	continue the program, we use it for waiting an enter to finalize
	the program,so the user can see the result until he wants to end the
	program pressing the enter key */
	getch();
	/* As you could see this is an int method it means that
	at the end of it, we must return a integer value so we return
	zero because it is a standard, i recommend you to respect
	programming standards but actually you can return the value you want*/
	return 0;
}
