using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;



namespace MathGame{  
 public class Program{   
 public static void Main(string [] args){

MathGame();

}

//method
public static void MathGame(){



  bool playagain=true;
  int score=0;
  int limit=0;
  
while(playagain){



int answer=1;
string Operator="";

Random rnd=new Random();

int randomnumber1=rnd.Next(1,100);
int randomnumber2=rnd.Next(1,100);
int randomoperator=rnd.Next(1,4);

switch(randomoperator){

case 1:
Operator="+";
answer=randomnumber1+randomnumber2;
limit++;

break;

case 2:
Operator="-";
answer=randomnumber1-randomnumber2;
limit++;

break;

case 3:
Operator="X";
answer=randomnumber1*randomnumber2;
limit++;

break;


}

Console.Write("\n");
Console.WriteLine($"Question  is : {randomnumber1} {Operator} {randomnumber2} = ? \t\tPlayer Score {score } out of 21");
Console.Write("\n");
Console.Write("Answer : ");
int userinput=Convert.ToInt32(Console.ReadLine());
Console.Write("\n");
if(userinput == answer){

Console.WriteLine("It Is A Correct Answer");
score++;
Console.Write("\n");

}else{

Console.WriteLine("It Is A InCorrect Answer");
Console.Write("\n");

}


if(limit>20){
    playagain=false;
}


}

Console.WriteLine($"Your Score Is {score} Out Of 21");
Console.Write("\n");

Console.WriteLine("Enter y for restart ");
Console.Write("\n");
string condition=Console.ReadLine();
Console.Write("\n");

if(condition=="Y"||condition=="y"){
Console.Clear();
playagain=true;
limit=1;
MathGame();

}else{

playagain=false;

}



}


}
}
